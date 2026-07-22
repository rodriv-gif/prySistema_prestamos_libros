using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmGestionEjemplares : Form
    {
        clsGestionEjemplares Ejemplar;
        public frmGestionEjemplares()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioEjemplares();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);

        }
        public void CargarGrid()
        {
            try
            {
                clsGestionEjemplares ejemplar = new clsGestionEjemplares();

                dgvEjemplares.AutoGenerateColumns = true;
                dgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEjemplares.DataSource = ejemplar.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message,
                                "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEjemplares.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un trabajador de la lista antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvEjemplares.CurrentRow;

            var frm = new frmFormularioEjemplares (fila);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvEjemplares.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un trabajador de la lista antes de dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvEjemplares.CurrentRow;
            string nombre = fila.Cells["Nombre"].Value?.ToString();
            int numeroControl = Convert.ToInt32(fila.Cells["Número de Control"].Value);

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que quieres dar de baja a {nombre}?",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;
            try
            {
                clsTrabajador trabajadorBaja = new clsTrabajador();
                string msg = trabajadorBaja.DarBajaTrabajador(numeroControl);
                MessageBox.Show(msg, "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo dar de baja al trabajador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtBuscarClave_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarClave.Text))
            {
                CargarGrid();
                return;
            }
            Ejemplar = new clsGestionEjemplares();
            dgvEjemplares.DataSource = null;
            dgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                Ejemplar.BuscarPorClave = int.Parse(txtBuscarClave.Text);
                dgvEjemplares.DataSource = Ejemplar.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos" + ex.Message);
            }
        }
    }
}
