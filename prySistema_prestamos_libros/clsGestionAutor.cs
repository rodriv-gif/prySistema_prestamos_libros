using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsGestionAutor
    {
        private string parametroBusqueda;
        public string ParametroBusqueda { get => parametroBusqueda; set => parametroBusqueda = value; }

        public DataTable ConsultarAutor()
        {
            DataTable tabla = new DataTable();
            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {
                string sql = "SELECT id_autor, " +
                             "CONCAT_WS(' ', nombre, apellido_paterno, apellido_materno) AS 'Nombre Completo' " +
                             "FROM tblautores " +
                             "WHERE nombre LIKE @busqueda OR apellido_paterno LIKE @busqueda OR apellido_materno LIKE @busqueda;";

                using (var comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@busqueda", "%" + (parametroBusqueda ?? "") + "%");
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }
        public string RegistrarAutor(string nombre, string apPaterno, string apMaterno)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblautores (nombre, apellido_paterno, apellido_materno) VALUES (@nom, @pat, @mat);";
                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@nom", nombre);
                        comando.Parameters.AddWithValue("@pat", apPaterno);

                        if (string.IsNullOrEmpty(apMaterno))
                            comando.Parameters.AddWithValue("@mat", DBNull.Value);
                        else
                            comando.Parameters.AddWithValue("@mat", apMaterno);

                        comando.ExecuteNonQuery();
                        return "Autor registrado con éxito.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar autor: " + ex.Message);
            }
        }
    }
}

