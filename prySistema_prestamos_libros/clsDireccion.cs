using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsDireccion
    {
        // Regresa el nombre del municipio que corresponde a un código postal.
        // Si el CP no existe en el catálogo, regresa string vacío.
        public string ObtenerMunicipioPorCP(string codigoPostal)
        {
            string municipio = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT m.nombre_municipio " +
                                    "FROM tblcodigo_postal cp " +
                                    "INNER JOIN tblmunicipios m ON cp.id_municipio = m.id_municipio " +
                                    "WHERE cp.codigo_postal = @cp;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@cp", codigoPostal);
                        municipio = Convert.ToString(comando.ExecuteScalar()); // si no hay resultado, regresa "" en vez de tronar
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el municipio: " + ex.Message, ex);
            }
            return municipio;
        }

        // Regresa las colonias (id_colonia, nombre_colonia) que pertenecen a un código postal,
        // listas para asignarse como DataSource de un ComboBox.
        public DataTable ObtenerColoniasPorCP(string codigoPostal)
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_colonia, nombre_colonia " +
                                    "FROM tblcolonias " +
                                    "WHERE codigo_postal = @cp;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@cp", codigoPostal);
                        using (var adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las colonias: " + ex.Message, ex);
            }
            return tabla;
        }
    }
}
