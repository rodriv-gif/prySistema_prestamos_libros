using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        //atributo estático
        private static string perfil;
        private static bool esAdministrador;
        private static bool esBibliotecario;
        private static string nombreUsuario;
        private static string apellidoPaternoUsuario;
        private static int idBibliotecario;

        //propiedades
        public static bool EsAdministrador { get => esAdministrador; }
        public static bool EsBibliotecario { get => esBibliotecario; }
        public static string Perfil { get => perfil; }
        public static string NombreCompleto { get => nombreUsuario + " " + apellidoPaternoUsuario; }
        // Id propio de tblbibliotecario (no es el numero_control del trabajador), se usa
        // para llenar id_bibliotecario al registrar un préstamo.
        public static int IdBibliotecario { get => idBibliotecario; }

        public void AsignarPermisos()
        {
            switch (perfil)
            {
                case "Administrador":
                    esAdministrador = true;
                    esBibliotecario = false;
                    break;
                case "Bibliotecario":
                    esAdministrador = false;
                    esBibliotecario = true;
                    break;
            }
        }
        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    string sql = "SELECT b.id_bibliotecario, " +
                                    "b.numero_control, " +
                                    "t.nombre, " +
                                    "t.apellido_paterno, " +
                                    "p.perfil AS perfil " +
                                "FROM tblbibliotecario b " +
                                "INNER JOIN tbltrabajadores t ON b.numero_control = t.numero_control " +
                                "INNER JOIN tblperfil p ON b.id_perfil = p.id_perfil " +
                                "WHERE b.usuario = @usuario AND b.contrasenia = @password; ";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                nombreUsuario = resultado.GetString("nombre");
                                apellidoPaternoUsuario = resultado.GetString("apellido_paterno");
                                idBibliotecario = resultado.GetInt32("id_bibliotecario");
                                AsignarPermisos();
                                if (!esAdministrador && !esBibliotecario)
                                {
                                    throw new Exception("No tiene permisos para acceder");
                                }
                                MessageBox.Show("Tu perfil es:" + perfil, "Sistema");
                                return true;

                            }
                            else
                            {
                                throw new Exception("Usuarios o contraseña incorrecta.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
