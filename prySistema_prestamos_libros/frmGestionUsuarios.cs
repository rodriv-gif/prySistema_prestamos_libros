using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmGestionUsuarios : Form
    {
        clsUsuarios usuario = new clsUsuarios();
        public frmGestionUsuarios()
        {
            InitializeComponent();

            // Es solo para consultar; no se debe poder agregar filas escribiendo directo en el grid.
            dgvUsuarios.AllowUserToAddRows = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioUsuario();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }
        private void Cargargrid()
        {
            try
            {

                dgvUsuarios.DataSource =
                    usuario.CargarUsuarios();


                dgvUsuarios.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                OcultarColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Se llama en todo lugar que reasigne el DataSource, porque eso resetea la visibilidad de columnas.
        private void OcultarColumnas()
        {
            if (dgvUsuarios.Columns["Nombre"] != null)
                dgvUsuarios.Columns["Nombre"].Visible = false;
            if (dgvUsuarios.Columns["Apellido Paterno"] != null)
                dgvUsuarios.Columns["Apellido Paterno"].Visible = false;
            if (dgvUsuarios.Columns["Apellido Materno"] != null)
                dgvUsuarios.Columns["Apellido Materno"].Visible = false;
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuario.BuscarUsuarios(txtBuscarUsuario.Text);
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OcultarColumnas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // CurrentRow se actualiza con solo darle clic a una celda; SelectedRows.Count solo
            // cuenta cuando se selecciona la fila completa (clic en el encabezado gris de la izquierda).
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }


            frmFormularioUsuario frm =
                new frmFormularioUsuario();


            frm.EsEdicion = true;


            frm.IdBibliotecario =
                Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["ID Bibliotecario"].Value);


            frm.ShowDialog();


            Cargargrid();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id =
            Convert.ToInt32(
            dgvUsuarios.CurrentRow.Cells["ID Bibliotecario"].Value);

            DialogResult respuesta =
                MessageBox.Show(
                "¿Desea dar de baja este usuario?",
                "Sistema",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {

                if (usuario.DarBaja(id))
                {

                    MessageBox.Show(
                    "Usuario dado de baja.");


                    Cargargrid();

                }
            }
        }
    }
}
