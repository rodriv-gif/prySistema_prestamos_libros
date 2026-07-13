namespace prySistema_prestamos_libros
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal());
                }
            }
            

            /*Application.Run(new frmPrestamos());
            Application.Run(new frmFormularioAlumno());
            Application.Run(new frmPrincipal());
            Application.Run(new frmGestionAlumnos());
            */
        }
    }
}