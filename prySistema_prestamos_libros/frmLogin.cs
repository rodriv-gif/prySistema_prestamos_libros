namespace prySistema_prestamos_libros
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Usuario = txtUsuario.Text;
                login.Password = txtPassword.Text;

                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); //Se cierra el login y posteriormente abre el formulario principal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
