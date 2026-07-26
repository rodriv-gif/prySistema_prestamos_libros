using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace prySistema_prestamos_libros
{
    internal class clsGestionLibros
    {
        private string isbn;
        private string titulo;
        private int paginas;
        private int idEditorial;
        private int idCategoria;
        private int idIdioma;
        private string busqueda;

        public string Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Paginas { get => paginas; set => paginas = value; }
        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdIdioma { get => idIdioma; set => idIdioma = value; }

        public string Busqueda { get => busqueda; set => busqueda = value; }
        public int BuscarClave { get; internal set; }

        private MySqlDataAdapter consulta;
        private DataTable tabla;


        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT l.ISBN AS 'ISBN', " +
                                 "l.titulo_libro AS 'Título', " +
                                 "GROUP_CONCAT(DISTINCT CONCAT(a.nombre, ' ', a.apellido_paterno) SEPARATOR ', ') AS 'Autores', " +
                                 "cat.nombre AS 'Categoría', " +
                                 "idi.nombre_idioma AS 'Idioma', " +
                                 "ed.nombre_editorial AS 'Editorial', " +
                                 "l.paginas AS 'Páginas', " +
                                 "l.id_libro AS 'id_libro', " +
                                 "l.id_editorial AS 'id_editorial', " +
                                 "l.id_categoria AS 'id_categoria', " +
                                 "l.id_idioma AS 'id_idioma' " +
                                 "FROM tbllibros l " +
                                 "LEFT JOIN tbleditoriales ed ON l.id_editorial = ed.id_editorial " +
                                 "LEFT JOIN tblcategorias cat ON l.id_categoria = cat.id_categoria " +
                                 "LEFT JOIN tblidiomas idi ON l.id_idioma = idi.id_idioma " +
                                 "LEFT JOIN tbllibro_autor la ON l.id_libro = la.id_libro " +
                                 "LEFT JOIN tblautores a ON la.id_autor = a.id_autor " +
                                 "GROUP BY l.id_libro, l.ISBN, l.titulo_libro, ed.nombre_editorial, " +
                                 "cat.nombre, idi.nombre_idioma, l.paginas, l.id_editorial, l.id_categoria, l.id_idioma;";

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
                    string sql = "SELECT l.ISBN AS 'ISBN', " +
                                 "l.titulo_libro AS 'Título', " +
                                 "GROUP_CONCAT(DISTINCT CONCAT(a.nombre, ' ', a.apellido_paterno) SEPARATOR ', ') AS 'Autores', " +
                                 "cat.nombre AS 'Categoría', " +
                                 "idi.nombre_idioma AS 'Idioma', " +
                                 "ed.nombre_editorial AS 'Editorial', " +
                                 "l.paginas AS 'Páginas', " +
                                 "l.id_libro AS 'id_libro', " +
                                 "l.id_editorial AS 'id_editorial', " +
                                 "l.id_categoria AS 'id_categoria', " +
                                 "l.id_idioma AS 'id_idioma' " +
                                 "FROM tbllibros l " +
                                 "LEFT JOIN tbleditoriales ed ON l.id_editorial = ed.id_editorial " +
                                 "LEFT JOIN tblcategorias cat ON l.id_categoria = cat.id_categoria " +
                                 "LEFT JOIN tblidiomas idi ON l.id_idioma = idi.id_idioma " +
                                 "LEFT JOIN tbllibro_autor la ON l.id_libro = la.id_libro " +
                                 "LEFT JOIN tblautores a ON la.id_autor = a.id_autor " +
                                 "WHERE l.ISBN LIKE @busqueda OR l.titulo_libro LIKE @busqueda " +
                                 "GROUP BY l.id_libro, l.ISBN, l.titulo_libro, ed.nombre_editorial, " +
                                 "cat.nombre, idi.nombre_idioma, l.paginas, l.id_editorial, l.id_categoria, l.id_idioma;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@busqueda", "%" + (busqueda ?? "") + "%");
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
        // Búsqueda específica para el formulario de Préstamos: aquí sí importa el ejemplar
        // físico (localización, inventario, id_ejemplar), porque lo que se presta es una
        // copia concreta, no "el libro" en abstracto. Por eso NO reutiliza Consultar() de
        // arriba (esa es para el catálogo de frmGestionLibros y ya no trae ejemplares) —
        // son responsabilidades distintas aunque ambas empiecen en tbllibros.
        public DataTable BuscarLibrosConEjemplares(string busquedaTexto)
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
                                "WHERE (l.ISBN LIKE @busqueda OR l.titulo_libro LIKE @busqueda) " +
                                    "AND e.estado = 'Activo' " +
                                    "AND NOT EXISTS ( " +
                                        "SELECT 1 FROM tblprestamos p2 " +
                                        "WHERE p2.id_ejemplar = e.id_ejemplar " +
                                        "AND p2.fecha_devolucion_real IS NULL " +
                                    ") " +
                                    // Si solo queda 1 disponible, ese ES el de referencia, así que la condición lo excluye automáticamente.
                                    "AND e.inventario > ( " +
                                        "SELECT MIN(e3.inventario) FROM tblejemplares e3 " +
                                        "WHERE e3.id_libro = e.id_libro " +
                                        "AND e3.estado = 'Activo' " +
                                        "AND NOT EXISTS ( " +
                                            "SELECT 1 FROM tblprestamos p3 " +
                                            "WHERE p3.id_ejemplar = e3.id_ejemplar " +
                                            "AND p3.fecha_devolucion_real IS NULL " +
                                        ") " +
                                    ") " +
                                "GROUP BY l.id_libro, e.id_ejemplar, l.titulo_libro, l.ISBN, " +
                                    "ed.nombre_editorial, cat.nombre, idi.nombre_idioma, e.localizacion, e.inventario;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@busqueda", "%" + (busquedaTexto ?? "") + "%");
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
                throw new Exception("No se pudo dar de baja. Detalles: " + ex.Message);
            }
            return mensaje;
        }

        public DataTable ObtenerEditoriales()
        {
            DataTable dt = new DataTable();
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                string sql = "SELECT id_editorial, nombre_editorial FROM tbleditoriales;";
                using (var adaptador = new MySqlDataAdapter(sql, conexion))
                {
                    adaptador.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerCategorias()
        {
            DataTable dt = new DataTable();
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                string sql = "SELECT id_categoria, nombre FROM tblcategorias;";
                using (var adaptador = new MySqlDataAdapter(sql, conexion))
                {
                    adaptador.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable ObtenerIdiomas()
        {
            DataTable dt = new DataTable();
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                string sql = "SELECT id_idioma, nombre_idioma FROM tblidiomas;";
                using (var adaptador = new MySqlDataAdapter(sql, conexion))
                {
                    adaptador.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerAutoresPorLibro(int idLibro)
        {
            DataTable dt = new DataTable();
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                string sql = "SELECT a.id_autor, CONCAT_WS(' ', a.nombre, a.apellido_paterno) AS 'nombre_completo' " +
                             "FROM tblautores a " +
                             "INNER JOIN tbllibro_autor la ON a.id_autor = la.id_autor " +
                             "WHERE la.id_libro = @idLibro;";
                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@idLibro", idLibro);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public string RegistrarLibro(List<int> listaAutores)
        {
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string sqlLibro = "INSERT INTO tbllibros (id_editorial, id_categoria, id_idioma, titulo_libro, paginas, ISBN) " +
                                          "VALUES (@editorial, @categoria, @idioma, @titulo, @paginas, @isbn);";

                        long idLibroGenerado = 0;
                        using (var cmdLibro = new MySqlCommand(sqlLibro, conexion, transaccion))
                        {
                            cmdLibro.Parameters.AddWithValue("@editorial", idEditorial);
                            cmdLibro.Parameters.AddWithValue("@categoria", idCategoria);
                            cmdLibro.Parameters.AddWithValue("@idioma", idIdioma);
                            cmdLibro.Parameters.AddWithValue("@titulo", titulo);
                            cmdLibro.Parameters.AddWithValue("@paginas", paginas);
                            cmdLibro.Parameters.AddWithValue("@isbn", isbn);

                            cmdLibro.ExecuteNonQuery();
                            idLibroGenerado = cmdLibro.LastInsertedId;
                        }

                        foreach (int idAutor in listaAutores)
                        {
                            string sqlRelacion = "INSERT INTO tbllibro_autor (id_libro, id_autor) VALUES (@idLibro, @idAutor);";
                            using (var cmdRelacion = new MySqlCommand(sqlRelacion, conexion, transaccion))
                            {
                                cmdRelacion.Parameters.AddWithValue("@idLibro", idLibroGenerado);
                                cmdRelacion.Parameters.AddWithValue("@idAutor", idAutor);
                                cmdRelacion.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                        return "Se ha registrado correctamente.";
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        throw new Exception("Error en la transacción de registro: " + ex.Message);
                    }
                }
            }
        }

        public string ActualizarLibro(int idLibro, List<int> listaAutores)
        {
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string sqlLibro = "UPDATE tbllibros SET id_editorial = @editorial, id_categoria = @categoria, " +
                                          "id_idioma = @idioma, titulo_libro = @titulo, paginas = @paginas, ISBN = @isbn " +
                                          "WHERE id_libro = @idLibro;";

                        using (var cmdLibro = new MySqlCommand(sqlLibro, conexion, transaccion))
                        {
                            cmdLibro.Parameters.AddWithValue("@editorial", idEditorial);
                            cmdLibro.Parameters.AddWithValue("@categoria", idCategoria);
                            cmdLibro.Parameters.AddWithValue("@idioma", idIdioma);
                            cmdLibro.Parameters.AddWithValue("@titulo", titulo);
                            cmdLibro.Parameters.AddWithValue("@paginas", paginas);
                            cmdLibro.Parameters.AddWithValue("@isbn", isbn);
                            cmdLibro.Parameters.AddWithValue("@idLibro", idLibro);
                            cmdLibro.ExecuteNonQuery();
                        }

                        string sqlDelete = "DELETE FROM tbllibro_autor WHERE id_libro = @idLibro;";
                        using (var cmdDelete = new MySqlCommand(sqlDelete, conexion, transaccion))
                        {
                            cmdDelete.Parameters.AddWithValue("@idLibro", idLibro);
                            cmdDelete.ExecuteNonQuery();
                        }

                        foreach (int idAutor in listaAutores)
                        {
                            string sqlRelacion = "INSERT INTO tbllibro_autor (id_libro, id_autor) VALUES (@idLibro, @idAutor);";
                            using (var cmdRelacion = new MySqlCommand(sqlRelacion, conexion, transaccion))
                            {
                                cmdRelacion.Parameters.AddWithValue("@idLibro", idLibro);
                                cmdRelacion.Parameters.AddWithValue("@idAutor", idAutor);
                                cmdRelacion.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                        return "Libro actualizado correctamente.";
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        throw new Exception("Error en la transacción de actualización: " + ex.Message);
                    }
                }
            }
        }
    }
}
