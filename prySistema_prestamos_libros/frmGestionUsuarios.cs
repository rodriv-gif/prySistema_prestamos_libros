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
                    DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuario.BuscarUsuarios(txtBuscarUsuario.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }


            frmFormularioUsuario frm =
                new frmFormularioUsuario();


            frm.EsEdicion = true;


            frm.IdBibliotecario =
                Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["id_bibliotecario"].Value);


            frm.ShowDialog();


            Cargargrid();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id =
            Convert.ToInt32(
            dgvUsuarios.CurrentRow.Cells["id_bibliotecario"].Value);

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
