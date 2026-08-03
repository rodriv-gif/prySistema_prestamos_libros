namespace prySistema_prestamos_libros
{
    internal static class Program
    {
        // Punto de entrada de la aplicación.
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal());
                }
            }

        }
    }
}