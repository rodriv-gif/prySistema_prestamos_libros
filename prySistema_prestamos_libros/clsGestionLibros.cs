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
        private string busqueda;

        // propiedad
        // Ahora acepta tanto ISBN como título, mismo criterio que las demás búsquedas del proyecto (Trabajadores, Alumnos).
        public string Busqueda { get => busqueda; set => busqueda = value; }
        public int BuscarClave { get; internal set; }

        // Los autores son muchos a muchos (tbllibro_autor), así que si no se agruparan,
        // un libro con 2 autores regresaría 2 filas duplicadas (una por autor), duplicando
        // también el ejemplar. GROUP_CONCAT junta todos los autores de un mismo libro en un
        // solo texto separado por comas, y el GROUP BY evita esas filas repetidas.
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
                                    "ed.nombre_editorial AS 'Editorial', " +
                                    "cat.nombre AS 'Categoría', " +
                                    "idi.nombre_idioma AS 'Idioma', " +
                                    "GROUP_CONCAT(DISTINCT CONCAT(a.nombre, ' ', a.apellido_paterno) SEPARATOR ', ') AS 'Autores', " +
                                    "e.localizacion AS 'Localización', " +
                                    "(SELECT COUNT(*) FROM tblejemplares e2 WHERE e2.id_libro = l.id_libro) AS 'Inventario', " +
                                    "e.id_ejemplar AS 'id_ejemplar' " +
                                "FROM tbllibros l " +
                                "INNER JOIN tblejemplares e ON l.id_libro = e.id_libro " +
                                "LEFT JOIN tbleditoriales ed ON l.id_editorial = ed.id_editorial " +
                                "LEFT JOIN tblcategorias cat ON l.id_categoria = cat.id_categoria " +
                                "LEFT JOIN tblidiomas idi ON l.id_idioma = idi.id_idioma " +
                                "LEFT JOIN tbllibro_autor la ON l.id_libro = la.id_libro " +
                                "LEFT JOIN tblautores a ON la.id_autor = a.id_autor " +
                                "WHERE l.ISBN LIKE @busqueda OR l.titulo_libro LIKE @busqueda " +
                                "GROUP BY l.id_libro, e.id_ejemplar, l.titulo_libro, l.ISBN, " +
                                    "ed.nombre_editorial, cat.nombre, idi.nombre_idioma, e.localizacion, e.inventario;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
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

        // Búsqueda de libros para el formulario de Ejemplares: aquí no importa si el
        // libro ya tiene ejemplares o no (por eso no hay JOIN con tblejemplares), porque el objetivo es encontrar el libro al que se le van a agregar ejemplares nuevos.
        public DataTable BuscarLibroParaEjemplar(string isbnBuscado)
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT l.id_libro AS 'id_libro', " +
                                    "l.titulo_libro AS 'Título', " +
                                    "l.ISBN AS 'ISBN' " +
                                "FROM tbllibros l " +
                                "WHERE l.ISBN LIKE @isbn;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@isbn", "%" + isbnBuscado + "%");
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
