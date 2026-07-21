using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsGestionLibros
    {
        // atributo
        private string isbn;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        // propiedad
        public string Isbn { get => isbn; set => isbn = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {

                    string sql = "SELECT l.titulo_libro AS 'Título', " +
                                    "l.ISBN AS 'ISBN', " +
                                    "e.localizacion AS 'Localización', " +
                                    "e.inventario AS 'Inventario', " +
                                    "e.id_ejemplar AS 'id_ejemplar' " +
                                "FROM tbllibros l " +
                                "INNER JOIN tblejemplares e ON l.id_libro = e.id_libro;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la tabla de libros: " + ex.Message);
            }
            return tabla;
        }

        public DataTable Consultar()
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT l.titulo_libro AS 'Título', " +
                                    "l.ISBN AS 'ISBN', " +
                                    "e.localizacion AS 'Localización', " +
                                    "e.inventario AS 'Inventario', " +
                                    "e.id_ejemplar AS 'id_ejemplar' " +
                                "FROM tbllibros l " +
                                "INNER JOIN tblejemplares e ON l.id_libro = e.id_libro " +
                                "WHERE l.ISBN LIKE @isbn;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@isbn", "%" + isbn + "%");
                        using (var adaptador = new MySqlDataAdapter(comando))
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
        public string DarBajaLibro(int idLibro)
        {
            string mensaje = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tbllibros WHERE id_libro = @idLibro;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idLibro", idLibro);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                            mensaje = "El libro fue eliminado correctamente del catálogo.";
                        else
                            mensaje = "No se encontró el libro a eliminar.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo dar de baja. Es posible que el libro tenga ejemplares asociados. Detalles: " + ex.Message);
            }
            return mensaje;
        }
    }
}
