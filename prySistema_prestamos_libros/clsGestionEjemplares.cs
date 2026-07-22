using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsGestionEjemplares
    {
        private int buscarPorClave;

        private MySqlDataAdapter consulta;
        private DataTable tabla;

        // propiedad
        public int BuscarPorClave { get => buscarPorClave; set => buscarPorClave = value; }
        public int IdLibro { get; internal set; }
        public string Localizacion { get; internal set; }
        public int Inventario { get; internal set; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    // Se cargan todos los ejemplares registrados, con el título y el ISBN
                    // del libro al que pertenecen, para mostrarlos en el data grid.
                    string sql = "SELECT e.id_ejemplar AS 'ID Ejemplar', " +
                                    "l.titulo_libro AS 'Título', " +
                                    "l.ISBN AS 'ISBN', " +
                                    "e.localizacion AS 'Localización', " +
                                    "e.inventario AS 'Inventario', " +
                                    "e.fecha_adquisicion AS 'Fecha de adquisición', " +
                                    "e.estado AS 'Estado', " +
                                    "e.id_libro AS 'id_libro' " +
                                "FROM tblejemplares e " +
                                "LEFT JOIN tbllibros l ON e.id_libro = l.id_libro;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los ejemplares: " + ex.Message);
            }
            return tabla;
        }

        // Búsqueda por id_ejemplar (la "clave" que teclea el bibliotecario en la barra
        // de búsqueda), con LIKE para que funcione igual que las demás barras de búsqueda
        // del proyecto (Trabajadores, Alumnos).
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT e.id_ejemplar AS 'ID Ejemplar', " +
                                    "l.titulo_libro AS 'Título', " +
                                    "l.ISBN AS 'ISBN', " +
                                    "e.localizacion AS 'Localización', " +
                                    "e.inventario AS 'Inventario', " +
                                    "e.fecha_adquisicion AS 'Fecha de adquisición', " +
                                    "e.estado AS 'Estado', " +
                                    "e.id_libro AS 'id_libro' " +
                                "FROM tblejemplares e " +
                                "LEFT JOIN tbllibros l ON e.id_libro = l.id_libro " +
                                "WHERE e.id_ejemplar LIKE @clave;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@clave", "%" + buscarPorClave + "%");

                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta: " + ex.Message);
            }

            return tabla;
        }

        // Registra "cantidad" ejemplares nuevos del mismo libro de golpe. A cada uno se le
        // asigna un número de inventario consecutivo, siguiendo el máximo que ya exista para
        // ese libro (si ya hay 2 copias, las nuevas se numeran 3, 4, 5...), sin que el
        // bibliotecario tenga que capturarlo.
        public string RegistrarEjemplares(int idLibro, string localizacion, DateTime fechaAdquisicion, int cantidad)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            int siguienteInventario = 1;
                            string sqlMaximo = "SELECT IFNULL(MAX(inventario), 0) FROM tblejemplares WHERE id_libro = @idLibro;";
                            using (var comandoMaximo = new MySqlCommand(sqlMaximo, conexion, transaccion))
                            {
                                comandoMaximo.Parameters.AddWithValue("@idLibro", idLibro);
                                siguienteInventario = Convert.ToInt32(comandoMaximo.ExecuteScalar()) + 1;
                            }

                            string sqlInsertar = @"INSERT INTO tblejemplares
                                                   (id_libro, localizacion, inventario, fecha_adquisicion, estado)
                                                   VALUES (@idLibro, @localizacion, @inventario, @fecha, @estado);";

                            for (int i = 0; i < cantidad; i++)
                            {
                                using (var comandoInsertar = new MySqlCommand(sqlInsertar, conexion, transaccion))
                                {
                                    comandoInsertar.Parameters.AddWithValue("@idLibro", idLibro);
                                    comandoInsertar.Parameters.AddWithValue("@localizacion", localizacion);
                                    comandoInsertar.Parameters.AddWithValue("@inventario", siguienteInventario + i);
                                    comandoInsertar.Parameters.AddWithValue("@fecha", fechaAdquisicion);
                                    comandoInsertar.Parameters.AddWithValue("@estado", "Activo");
                                    comandoInsertar.ExecuteNonQuery();
                                }
                            }

                            transaccion.Commit();
                            msj = "Se registraron " + cantidad + " ejemplares correctamente";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en la BD: " + ex.Message);
            }

            return msj;
        }

        // Actualiza un ejemplar existente. No toca ni id_libro ni inventario (esos se fijan
        // al momento de crearlo); solo localización y fecha de adquisición son editables.
        public string ActualizarEjemplar(int idEjemplar, string localizacion, DateTime fechaAdquisicion)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"UPDATE tblejemplares
                                   SET localizacion = @localizacion, fecha_adquisicion = @fecha
                                   WHERE id_ejemplar = @idEjemplar;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@localizacion", localizacion);
                        comando.Parameters.AddWithValue("@fecha", fechaAdquisicion);
                        comando.Parameters.AddWithValue("@idEjemplar", idEjemplar);
                        comando.ExecuteNonQuery();
                    }
                }
                msj = "El ejemplar se actualizó correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el ejemplar: " + ex.Message);
            }

            return msj;
        }

        // Baja lógica: no borra la fila, solo marca estado = 'Inactivo'. Igual que
        // DarBajaTrabajador()/DarBajaAlumno() — el registro se puede recuperar después
        // y no rompe referencias de otras tablas (préstamos, etc.).
        public string DarBajaEjemplar(int idEjemplar)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tblejemplares SET estado = 'Inactivo' WHERE id_ejemplar = @idEjemplar;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idEjemplar", idEjemplar);
                        comando.ExecuteNonQuery();
                    }
                }
                msj = "El ejemplar se dio de baja correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja al ejemplar: " + ex.Message);
            }

            return msj;
        }
    }
}
