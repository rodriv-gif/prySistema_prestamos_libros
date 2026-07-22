using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prySistema_prestamos_libros
{
    internal class clsGestionEjemplares
    {
        private int Id_Ejemplar;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private int id_Ejemplar;
        private object? isbnBuscado;
        private string isbn;

        //propiedad
        public int Id_Ejemplar1 { get => Id_Ejemplar; set => Id_Ejemplar = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    /*se cargan todos los ejemplares registrados para mostrarlos en el data grid*/
                    string sql = "SELECT a.id_Ejemplar AS 'id_Ejemplar', " +
                                    "a.id_Libro AS 'id_Libro', " +
                                    "a.id_estado_ejemplar AS 'id_estado_ejemplar', " +
                                    "a.Localizacion AS 'Localizacion', " +
                                    "a.inventario AS 'inventario', " +
                                    "a.fecha_adquisicion AS 'Fecha_adquisicion', " +

                                "FROM tblEjemplares a " +
                                "LEFT JOIN tblLibros l ON e.id_Libro = e.id_Libro; ";
                   
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los ejemplares " + ex.Message);
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
                    string sql = @"SELECT e.id_ejemplar AS 'ID Ejemplar',
                            l.isbn AS 'ISBN',
                            l.titulo AS 'Título',
                            e.localizacion AS 'Localización',
                            e.inventario AS 'Inventario',
                            e.fecha_adquisicion AS 'Fecha de adquisición'
                           FROM tblejemplares e
                           INNER JOIN tbllibros l ON e.id_libro = l.id_libro
                           WHERE l.isbn LIKE @isbn;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@isbn", "%" + isbn + "%");

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


        // Búsqueda exacta (no LIKE) para el formulario de préstamos: el bibliotecario teclea
        // el número/matrícula y necesitamos saber de una vez si existe, sin resultados parciales.
        // Solo trae alumnos con estado 'Activo' (no tiene sentido prestarle a uno dado de baja).
        public DataTable BuscarPorMatricula(int matriculaBuscada)
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT e.id_ejemplar AS 'ID Ejemplar', " +
                                 "l.isbn AS 'ISBN', " +
                                 "l.titulo AS 'Título', " +
                                 "e.localizacion AS 'Localización', " +
                                 "e.inventario AS 'Inventario', " +
                                 "e.fecha_adquisicion AS 'Fecha de adquisición' " +
                                 "FROM tblejemplares e " +
                                 "INNER JOIN tbllibros l ON e.id_libro = l.id_libro " +
                                 "WHERE l.isbn = @isbn;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@isbn", isbnBuscado);

                        using (var adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el ejemplar: " + ex.Message);
            }

            return tabla;
        }
    }
};