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
