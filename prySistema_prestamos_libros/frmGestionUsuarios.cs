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
            CargarGrid();
        }
        private void CargarGrid()
        {
            try
            {
                dgvUsuarios.DataSource = null;

                dgvUsuarios.AutoGenerateColumns = true;

                dgvUsuarios.DataSource = usuario.CargarDataGrid();

                dgvUsuarios.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvUsuarios.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource =
                    usuario.BuscarGrid(txtBuscarUsuario.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No existen registros.");

                return;
            }

            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");

                return;
            }

            frmFormularioUsuario frm = new frmFormularioUsuario();

            frm.IdBibliotecario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

            frm.EsEdicion = true;

            frm.ShowDialog();

            CargarGrid();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrid();
        }
    }
}
