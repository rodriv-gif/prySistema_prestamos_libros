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

        // Solo letras y espacio (char.IsLetter ya incluye acentos y Ñ).
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // permite backspace

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreAutor.Text))
            {
                MessageBox.Show("Captura el nombre del autor (solo letras).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreAutor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MessageBox.Show("Captura el apellido paterno del autor (solo letras).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoPaterno.Focus();
                return false;
            }

            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

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

