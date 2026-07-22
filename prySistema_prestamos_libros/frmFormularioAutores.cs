using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmFormularioAutores : Form
    {
        public frmFormularioAutores()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAutor.Text) || string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MessageBox.Show("El nombre y el apellido paterno son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsGestionAutor autor = new clsGestionAutor();

                string mensaje = autor.RegistrarAutor(
                    txtNombreAutor.Text.Trim(),
                    txtApellidoPaterno.Text.Trim(),
                    txtApellidoMaterno.Text.Trim()
                );

                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
