using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsEjemplares
    {
        private int id_Ejemplares;
        private int id_Libro;
        private int id_Estado_Ejemplar;
        private string isbn;
        private string localizacion;
        private int inventario;
        private DateTime Fecha_Adquisicion;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private object? idEstadoEjemplar;
        private object? idlibro;
        private object? idEjemplares;
        internal object fechaAdquisicion;
        internal int idLibro;

        public int Id_Ejemplares { get => id_Ejemplares; set => id_Ejemplares = value; }
        public int Id_Libro { get => id_Libro; set => id_Libro = value; }
        public int Id_Estado_Ejemplar { get => id_Estado_Ejemplar; set => id_Estado_Ejemplar = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Localizacion { get => localizacion; set => localizacion = value; }
        public int Inventario { get => inventario; set => inventario = value; }
        public DateTime Fecha_Adquisicion1 { get => Fecha_Adquisicion; set => Fecha_Adquisicion = value; }
        public object? FechaAdquisicion { get; private set; }
        public object? IdLibro { get; private set; }
        public object? IdEstadoEjemplar { get; private set; }
        public object? IdEjemplar { get; private set; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();

                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = @"SELECT
                            e.id_ejemplar AS 'ID Ejemplar',
                            l.ISBN AS 'ISBN',
                            l.titulo_libro AS 'Título',
                            es.nombre_estado AS 'Estado',
                            e.localizacion AS 'Localización',
                            e.inventario AS 'Cantidad',
                            e.fecha_adquisicion AS 'Fecha de adquisición',
                            e.id_libro,
                            e.id_estado_ejemplar
                           FROM tblejemplares e
                           INNER JOIN tbllibros l
                           ON e.id_libro = l.id_libro
                           INNER JOIN tblestado_ejemplar es
                           ON e.id_estado_ejemplar = es.id_estado_ejemplar;";
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

        public DataTable Consultar()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT
                            e.id_ejemplar AS 'ID Ejemplar',
                            l.ISBN AS 'ISBN',
                            l.titulo_libro AS 'Título',
                            es.nombre_estado AS 'Estado',
                            e.localizacion AS 'Localización',
                            e.inventario AS 'Cantidad',
                            e.fecha_adquisicion AS 'Fecha de adquisición',
                            e.id_libro,
                            e.id_estado_ejemplar
                           FROM tblejemplares e
                           INNER JOIN tbllibros l
                                ON e.id_libro = l.id_libro
                           INNER JOIN tblestado_ejemplar es
                                ON e.id_estado_ejemplar = es.id_estado_ejemplar
                           WHERE l.ISBN LIKE @isbn;";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@isbn", "%" + isbn + "%");

                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los ejemplares: " + ex.Message);
            }

            return tabla;
        }
        public DataTable BuscarPorISBN()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT
                            id_libro,
                            ISBN,
                            titulo_libro
                           FROM tbllibros
                           WHERE ISBN = @isbn;";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@isbn", isbn);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el libro: " + ex.Message);
            }

            return tabla;
        }

        public string Insertar()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"INSERT INTO tblejemplares
                          (
                              id_libro,
                              id_estado_ejemplar,
                              localizacion,
                              inventario,
                              fecha_adquisicion
                          )
                          VALUES
                          (
                              @idLibro,
                              @idEstado,
                              @localizacion,
                              @inventario,
                              @fecha
                          );";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdLibro", idlibro);
                        comando.Parameters.AddWithValue("@idEstado", idEstadoEjemplar);
                        comando.Parameters.AddWithValue("@localizacion", Localizacion);
                        comando.Parameters.AddWithValue("@inventario", Inventario);
                        comando.Parameters.AddWithValue("@fecha", FechaAdquisicion);

                        comando.ExecuteNonQuery();
                    }
                }

                return "Ejemplar registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar el ejemplar: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"UPDATE tblejemplares
                           SET
                                id_libro=@idLibro,
                                id_estado_ejemplar=@idEstado,
                                localizacion=@localizacion,
                                inventario=@inventario,
                                fecha_adquisicion=@fecha
                           WHERE id_ejemplar=@idEjemplar;";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idLibro", IdLibro);
                        comando.Parameters.AddWithValue("@idEstado", IdEstadoEjemplar);
                        comando.Parameters.AddWithValue("@localizacion", Localizacion);
                        comando.Parameters.AddWithValue("@inventario", Inventario);
                        comando.Parameters.AddWithValue("@fecha", FechaAdquisicion);
                        comando.Parameters.AddWithValue("@idEjemplar", IdEjemplar);

                        comando.ExecuteNonQuery();
                    }
                }

                return "Ejemplar actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el ejemplar: " + ex.Message;
            }
        }

        public string Eliminar()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"DELETE FROM tblejemplares
                           WHERE id_ejemplar=@idEjemplar;";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idEjemplar", idEjemplares);

                        comando.ExecuteNonQuery();
                    }
                }

                return "Ejemplar eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el ejemplar: " + ex.Message;
            }
        }

    }
}

