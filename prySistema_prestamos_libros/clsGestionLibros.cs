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

        // propiedad
        public string Isbn { get => isbn; set => isbn = value; }

        // Trae los ejemplares que coincidan con el ISBN tecleado.
        // Un mismo libro puede tener varios ejemplares, por eso puede regresar más de una fila,
        // una por cada copia física distinta.
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
    }
}
