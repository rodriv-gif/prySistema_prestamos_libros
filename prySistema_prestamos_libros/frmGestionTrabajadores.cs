using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmGestionTrabajadores : Form
    {
        clsGestionTrabajador trabajador;
        public frmGestionTrabajadores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            trabajador = new clsGestionTrabajador();
            dgvTrabajadores.DataSource = null;
            dgvTrabajadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTrabajadores.DataSource = trabajador.CargarDataGrid();
                dgvTrabajadores.Columns["id_carrera"].Visible = false;
                dgvTrabajadores.Columns["Fecha de Registro"].Visible = false;
                dgvTrabajadores.Columns["Calle"].Visible = false;
                dgvTrabajadores.Columns["Colonia"].Visible = false;
                dgvTrabajadores.Columns["Código Postal"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioTrabajadores();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un trabajador de la lista antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Datos de la fila seleccionada, listos para mandarlos al formulario de captura
            // en cuanto tenga un constructor/método que los reciba.
            DataGridViewRow fila = dgvTrabajadores.CurrentRow;
            string numeroControl = fila.Cells["Número de Control"].Value.ToString();
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string apellidoPaterno = fila.Cells["Apellido Paterno"].Value.ToString();
            string apellidoMaterno = fila.Cells["Apellido Materno"].Value.ToString();
            string calle = fila.Cells["Calle"].Value.ToString();
            string colonia = fila.Cells["Colonia"].Value.ToString();
            string codigoPostal = fila.Cells["Código Postal"].Value.ToString();
            string correo = fila.Cells["Correo electrónico"].Value.ToString();
            string telefono = fila.Cells["Teléfono"].Value.ToString();
            string idCarrera = fila.Cells["id_carrera"].Value?.ToString();

            // TODO: cuando frmFormularioTrabajadores tenga forma de recibir estos datos
            // (constructor sobrecargado, propiedades públicas, etc.), pasarlos aquí antes de ShowDialog.
            var frm = new frmFormularioTrabajadores();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }
        
    }
}
