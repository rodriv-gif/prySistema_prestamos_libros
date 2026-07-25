using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace prySistema_prestamos_libros
{
    internal class clsConexion
    {
        // Conexión remota (hosting) 
        private string hostRemoto = "189.240.192.140";
        private string bdRemota = "Equipo5_Library_Manager";
        private string usuarioRemoto = "usuario5GB";
        private string passwordRemoto = "equipo5gb";
        private string puertoRemoto = "3306";

        // Conexión local 
        // Ajusta estos 5 valores a los de tu MySQL local
        private string hostLocal = "localhost";
        private string bdLocal = "Equipo5_Library_Manager";
        private string usuarioLocal = "root";
        private string passwordLocal = "rootMy142007";
        private string puertoLocal = "3306";

        private string CadenaConexion(string host, string bd, string usuario, string password, string puerto)
            => $"server={host};database={bd};user={usuario};password={password};port={puerto};";

        // Indica cuál conexión quedó activa después de AbrirConexion()
        public bool UsandoRespaldoLocal { get; private set; }

        // Abre la conexión: intenta primero el hosting remoto,
        // si falla, cae automáticamente a la base local de respaldo.
        public MySqlConnection AbrirConexion()
        {
            var conexionRemota = new MySqlConnection(CadenaConexion(hostRemoto, bdRemota, usuarioRemoto, passwordRemoto, puertoRemoto));

            try
            {
                conexionRemota.Open();
                UsandoRespaldoLocal = false;
                return conexionRemota;
            }
            catch (Exception exRemota)
            {
                // El hosting no respondió, se intenta con la base local
                try
                {
                    var conexionLocal = new MySqlConnection(CadenaConexion(hostLocal, bdLocal, usuarioLocal, passwordLocal, puertoLocal));
                    conexionLocal.Open();
                    UsandoRespaldoLocal = true;
                    return conexionLocal;
                }
                catch (Exception exLocal)
                {
                    throw new Exception(
                        "No se pudo conectar ni al servidor remoto ni a la base local de respaldo.\n" +
                        "Error remoto: " + exRemota.Message + "\n" +
                        "Error local: " + exLocal.Message, exLocal);
                }
            }
        }

        // Cierra la conexión con la BD
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos: " + ex.Message, ex);
            }
        }

        internal void CerrarConexion()
        {
            throw new NotImplementedException();
        }
    }
}



