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
        clsUsuarios usuario = new clsUsuarios();

        public bool EsEdicion = false;

        public int IdBibliotecario = 0;

        public frmFormularioUsuario()
        {
            InitializeComponent();
        }

        private void CargarPerfiless()
        {
            try
            {
                cmbPerfil.DataSource = usuario.CargarPerfiles;

                cmbPerfil.DisplayMember = "nombre_perfil";

                cmbPerfil.ValueMember = "id_perfil";

                cmbPerfil.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmFormularioUsuarios_Load(object sender, EventArgs e)
        {
            CargarPerfiless();

            if (EsEdicion)
            {
                CargarDatos();
            }
        }
        private void LlenarComboPerfil()
        {
            try
            {
                clsUsuarios usuarios = new clsUsuarios();

                cmbPerfil.DataSource = usuarios.CargarPerfil();

                cmbPerfil.DisplayMember = "nombre_perfil";

                cmbPerfil.ValueMember = "id_perfil";

                cmbPerfil.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumControl.Text == "")
                {
                    MessageBox.Show("Ingrese el número de control.");
                    txtNumControl.Focus();
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

                usuario.NumeroControl =
                    Convert.ToInt32(txtNumControl.Text);

                usuario.IdPerfil =
                    Convert.ToInt32(cmbPerfil.SelectedValue);

                usuario.Usuario = txtUsuario.Text.Trim();

                usuario.Contrasenia = txtContrasena.Text.Trim();

                if (!EsEdicion)
                {
                    if (usuario.ExisteUsuario(txtUsuario.Text))
                    {
                        MessageBox.Show("Ese usuario ya existe.");
                        return;
                    }

                    if (usuario.GuardarUsuario())
                    {
                        MessageBox.Show("Usuario registrado correctamente.");

                        this.Close();
                    }
                }
                else
                {
                    usuario.IdBibliotecario = IdBibliotecario;

                    if (usuario.EditarUsuario())
                    {
                        MessageBox.Show("Usuario actualizado.");

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTrabajador_Click_1(object sender, EventArgs e)
        {
            if (txtNumControl.Text == "")
            {
                MessageBox.Show("Ingrese el número de control.");

                txtNumControl.Focus();

                return;
            }

            BuscarTrabajador();
        }
        private void BuscarTrabajador()
        {
            try
            {
                DataTable dt =
                    usuario.BuscarTrabajador(
                    Convert.ToInt32(txtNumControl.Text));

                if (dt.Rows.Count > 0)
                {
                    txtNombreTrabajador.Text =
                        dt.Rows[0]["nombre"].ToString();

                    txtApellidoPaternoTrabajador.Text =
                        dt.Rows[0]["apellido_paterno"].ToString();

                    txtApellidoMaternoTrabajador.Text =
                        dt.Rows[0]["apellido_materno"].ToString();

                    txtCarreraTrabajador.Text =
                        dt.Rows[0]["id_carrera"].ToString();
                }
                else
                {
                    MessageBox.Show("Trabajador no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDatos()
        {
            try
            {
                DataTable dt = usuario.BuscarUsuario(IdBibliotecario);

                if (dt.Rows.Count > 0)
                {
                    txtNumControl.Text = dt.Rows[0]["numero_control"].ToString();
                    txtNombreTrabajador.Text = dt.Rows[0]["nombre"].ToString();
                    txtApellidoPaternoTrabajador.Text = dt.Rows[0]["apellido_paterno"].ToString();
                    txtApellidoMaternoTrabajador.Text = dt.Rows[0]["apellido_materno"].ToString();
                    txtCarreraTrabajador.Text = dt.Rows[0]["id_carrera"].ToString();

                    txtUsuario.Text = dt.Rows[0]["usuario"].ToString();
                    txtContrasena.Text = dt.Rows[0]["contrasenia"].ToString();

                    cmbPerfil.SelectedValue =
                        Convert.ToInt32(dt.Rows[0]["id_perfil"]);

                    txtNumControl.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboPerfil();
        }
    }

}   
                
   