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
        private void LlenarComboPerfiles()
        {
            try
            {
                DataTable dt = usuario.CargarPerfiles();


                cmbPerfil.DataSource = dt;

                cmbPerfil.DisplayMember = "Perfil";

                cmbPerfil.ValueMember = "id_perfil";

                cmbPerfil.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BuscarTrabajador()
        {
            try
            {

                DataTable dt = usuario.BuscarTrabajador(
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
                        dt.Rows[0]["nombre_carrera"].ToString();

                    // Solo aplica al registrar uno nuevo; al editar el trabajador ya es el mismo.
                    if (!EsEdicion && usuario.ExisteBibliotecarioParaTrabajador(Convert.ToInt32(txtNumControl.Text)))
                    {
                        MessageBox.Show("Este trabajador ya tiene un usuario asignado. Elige otro número de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarTrabajador();
                        txtNumControl.Focus();
                        return;
                    }

                    MessageBox.Show("Trabajador vinculado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void btnAgregarTrabajador_Click(object sender, EventArgs e)
        {

            if (txtNumControl.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el número de control.");
                txtNumControl.Focus();
                return;
            }

            BuscarTrabajador();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNumControl.Text == "")
                {
                    MessageBox.Show("Ingrese número de control.");
                    return;
                }


                if (cmbPerfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un perfil.");
                    return;
                }


                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingrese usuario.");
                    return;
                }


                if (txtContrasena.Text == "")
                {
                    MessageBox.Show("Ingrese contraseña.");
                    return;
                }

                usuario.NumeroControl = Convert.ToInt32(txtNumControl.Text);
                usuario.IdPerfil = Convert.ToInt32(cmbPerfil.SelectedValue);
                usuario.Usuario = txtUsuario.Text.Trim();
                usuario.Contrasena = txtContrasena.Text.Trim();

                if (!EsEdicion)
                {

                    if (usuario.ExisteBibliotecarioParaTrabajador(usuario.NumeroControl))
                    {
                        MessageBox.Show("Este trabajador ya tiene un usuario asignado. No se puede registrar otro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (usuario.ExisteUsuario(txtUsuario.Text))
                    {
                        MessageBox.Show("El usuario ya existe.");
                        return;
                    }


                    if (usuario.GuardarUsuario())
                    {
                        MessageBox.Show("Usuario guardado correctamente.");

                        Close();
                    }

                }
                else
                {

                    usuario.IdBibliotecario = IdBibliotecario;


                    if (usuario.EditarUsuario())
                    {
                        MessageBox.Show("Usuario actualizado.");

                        Close();
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
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtNumControl_TextChanged(object sender, EventArgs e)
        {
            BuscarTrabajadorAutomatico();
        }

        private void frmFormularioUsuario_Load(object sender, EventArgs e)
        {
            LlenarComboPerfiles();

            if (EsEdicion)
            {
                CargarDatos();
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

                    txtCarreraTrabajador.Text = dt.Rows[0]["nombre_carrera"].ToString();

                    txtUsuario.Text = dt.Rows[0]["usuario"].ToString();

                    // La contraseña no se muestra ni se puede editar aquí por seguridad.
                    txtContrasena.Text = "********";
                    txtContrasena.Enabled = false;

                    cmbPerfil.SelectedValue = Convert.ToInt32(dt.Rows[0]["id_perfil"]);

                    // Al editar solo se permite cambiar Perfil y Usuario; trabajador y contraseña no.
                    txtNumControl.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos del usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscarTrabajadorAutomatico()
        {
            try
            {
                int numeroControl;

                if (!int.TryParse(txtNumControl.Text, out numeroControl))
                {
                    txtNombreTrabajador.Clear();
                    txtApellidoPaternoTrabajador.Clear();
                    txtApellidoMaternoTrabajador.Clear();
                    txtCarreraTrabajador.Clear();
                    return;
                }

                DataTable dt = usuario.BuscarTrabajador(numeroControl);

                if (dt.Rows.Count > 0)
                {
                    txtNombreTrabajador.Text = dt.Rows[0]["nombre"].ToString();

                    txtApellidoPaternoTrabajador.Text = dt.Rows[0]["apellido_paterno"].ToString();

                    txtApellidoMaternoTrabajador.Text = dt.Rows[0]["apellido_materno"].ToString();

                    txtCarreraTrabajador.Text = dt.Rows[0]["nombre_carrera"].ToString();
                }
                else
                {
                    txtNombreTrabajador.Clear();

                    txtApellidoPaternoTrabajador.Clear();

                    txtApellidoMaternoTrabajador.Clear();

                    txtCarreraTrabajador.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}   
                
   