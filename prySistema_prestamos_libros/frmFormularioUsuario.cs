using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmFormularioUsuario : Form
    {
        private object dt;

        public frmFormularioUsuario()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtNumControl.Clear();
            txtNombreTrabajador.Clear();
            txtApellidoPaternoTrabajador.Clear();
            txtApellidoMaternoTrabajador.Clear();
            txtCarreraTrabajador.Clear();

            txtUsuario.Clear();
            txtContrasena.Clear();

            cmbPerfil.SelectedIndex = -1;

            txtNumControl.Focus();
        }
        private void LimpiarTrabajador()
        {
            txtNombreTrabajador.Clear();
            txtApellidoPaternoTrabajador.Clear();
            txtApellidoMaternoTrabajador.Clear();
            txtCarreraTrabajador.Clear();
        }


        private void btnAgregarTrabajador_Click(object sender, EventArgs e)
        {
            if (txtNumControl.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el número de control.");
                txtNumControl.Focus();
                return;
            }

            try
            {
                //en esta parte falta que se cree la clase donde se empleen estos metodos
                //QUITAR LOS PARENTESIS
                clsUsuarios usuario = new clsUsuarios();

                DataTable dt = usuario.BuscaTrabajador(txtNumControl.Text);

                if (dt.Rows.Count > 0)
                {
                    txtNombreTrabajador.Text = dt.Rows[0]["Nombre"].ToString();
                    txtApellidoPaternoTrabajador.Text =dt.Rows[0]["ApellidoPaterno"].ToString();
                    txtApellidoMaternoTrabajador.Text = dt.Rows[0]["ApellidoMaterno"].ToString();
                    txtCarreraTrabajador.Text = dt.Rows[0]["Area"].ToString();
                }
                else
                {
                    MessageBox.Show("Trabajador no encontrado.");
                    LimpiarTrabajador();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            {
                if (txtNumControl.Text == "")
                {
                    MessageBox.Show("Seleccione un trabajador.");
                    return;
                }

                if (cmbPerfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un perfil.");
                    return;
                }

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario.");
                    txtUsuario.Focus();
                    return;
                }

                if (txtContrasena.Text == "")
                {
                    MessageBox.Show("Ingrese una contraseña.");
                    txtContrasena.Focus();
                    return;
                }

                try
                {
                    
                    // falta crear la clase 
                    
                    clsUsuarios usuario = new clsUsuarios();

                    usuario.NumControl = txtNumControl.Text;
                    usuario.IdPerfil = Convert.ToInt32(cmbPerfil.SelectedValue);
                    usuario.Usuario = txtUsuario.Text.Trim();
                    usuario.Password = txtContrasena.Text.Trim();

                    if (usuario.Guardar())
                    {
                        MessageBox.Show("Usuario registrado correctamente.");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            // misma indicacion qitar comentarios ddes pues de crear clase de usuarios
            clsUsuarios usuario = new clsUsuarios();

            cmbPerfil.DataSource = usuario.CargarPerfiles();
            cmbPerfil.DisplayMember = "Perfil";
            cmbPerfil.ValueMember = "IdPerfil";
            cmbPerfil.SelectedIndex = -1;
        }

        // intento de validacion  
        private void txtNumControl_TextChanged(object sender, EventArgs e)
        {
            /*
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            */

        }
    }
    
}   
                
   