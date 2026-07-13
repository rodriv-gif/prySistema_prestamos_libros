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

        //propiedades
        public static bool EsAdministrador { get => esAdministrador; }
        public static bool EsBibliotecario { get => esBibliotecario; }

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
    }
}
