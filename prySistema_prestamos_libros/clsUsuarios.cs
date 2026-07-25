using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsUsuarios
    {
        clsConexion cn = new clsConexion();

        // son las propiedades 
        public string NumeroControl { get; set; }
        public int IdPerfil { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string NumControl { get; internal set; }

       
        //en esta parte se buscan a los trabajadores
        public DataTable BuscaTrabajador(string numeroControl)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection conexion = cn.AbrirConexion();

                MySqlCommand cmd = new MySqlCommand(
                "SELECT Nombre,ApellidoPaterno,ApellidoMaterno,Area " +
                "FROM trabajador WHERE NumeroControl=@NumeroControl",
                conexion);

                cmd.Parameters.AddWithValue("@NumeroControl", numeroControl);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cn.CerrarConexion();
            }
            catch
            {
                throw;
            }

            return dt;
        }

        

        public DataTable CargarPerfiles()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection conexion = cn.AbrirConexion();

                MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT IdPerfil,Perfil FROM perfil",
                conexion);

                da.Fill(dt);

                cn.CerrarConexion();
            }
            catch
            {
                throw;
            }

            return dt;
        }

        
        public bool Guardar()
        {
            bool respuesta = false;

            try
            {
                MySqlConnection conexion = cn.AbrirConexion();

                MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO usuarios(NumeroControl,IdPerfil,Usuario,Password) " +
                "VALUES(@NumeroControl,@IdPerfil,@Usuario,@Password)",
                conexion);

                cmd.Parameters.AddWithValue("@NumeroControl", NumeroControl);
                cmd.Parameters.AddWithValue("@IdPerfil", IdPerfil);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Password", Password);

                if (cmd.ExecuteNonQuery() > 0)
                    respuesta = true;

                cn.CerrarConexion();
            }
            catch
            {
                throw;
            }

            return respuesta;
        }

        
        public bool ExisteUsuario()
        {
            bool existe = false;

            try
            {
                MySqlConnection conexion = cn.AbrirConexion();

                MySqlCommand cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM usuarios WHERE Usuario=@Usuario",
                conexion);

                cmd.Parameters.AddWithValue("@Usuario", Usuario);

                int total = Convert.ToInt32(cmd.ExecuteScalar());

                if (total > 0)
                    existe = true;

                cn.CerrarConexion();
            }
            catch
            {
                throw;
            }

            return existe;
        }

    }
}
