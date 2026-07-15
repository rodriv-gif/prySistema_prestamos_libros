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
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Cada vez que se asigna un DataSource nuevo a dgvTrabajadores (CargarGrid o una búsqueda),
        // la grid regenera sus columnas y pierde la visibilidad anterior. Por eso se creo este método se
        // llama en TODOS los lugares donde se reasigne el DataSource.
        private void OcultarColumnas()
        {
            if (dgvTrabajadores.Columns["id_carrera"] != null)
                dgvTrabajadores.Columns["id_carrera"].Visible = false;
            if (dgvTrabajadores.Columns["id_direccion"] != null)
                dgvTrabajadores.Columns["id_direccion"].Visible = false;
            if (dgvTrabajadores.Columns["id_colonia"] != null)
                dgvTrabajadores.Columns["id_colonia"].Visible = false;
            if (dgvTrabajadores.Columns["Fecha de Registro"] != null)
                dgvTrabajadores.Columns["Fecha de Registro"].Visible = false;
            if (dgvTrabajadores.Columns["Calle"] != null)
                dgvTrabajadores.Columns["Calle"].Visible = false;
            if (dgvTrabajadores.Columns["Colonia"] != null)
                dgvTrabajadores.Columns["Colonia"].Visible = false;
            if (dgvTrabajadores.Columns["Código Postal"] != null)
                dgvTrabajadores.Columns["Código Postal"].Visible = false;
            if (dgvTrabajadores.Columns["Municipio"] != null)
                dgvTrabajadores.Columns["Municipio"].Visible = false;
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
            string calle = fila.Cells["Calle"].Value?.ToString();
            string colonia = fila.Cells["Colonia"].Value?.ToString();
            string codigoPostal = fila.Cells["Código Postal"].Value?.ToString();
            string municipio = fila.Cells["Municipio"].Value?.ToString();
            string correo = fila.Cells["Correo electrónico"].Value.ToString();
            string telefono = fila.Cells["Teléfono"].Value.ToString();
            string idCarrera = fila.Cells["id_carrera"].Value?.ToString();
            string idDireccion = fila.Cells["id_direccion"].Value?.ToString();
            string idColonia = fila.Cells["id_colonia"].Value?.ToString();

            // TODO: cuando frmFormularioTrabajadores tenga forma de recibir estos datos
            // (constructor sobrecargado, propiedades públicas, etc.), pasarlos aquí antes de ShowDialog.
            var frm = new frmFormularioTrabajadores();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void txtBuscarTrabajador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarTrabajador.Text))
            {
                CargarGrid();
                return;
            }
            trabajador = new clsGestionTrabajador();
            dgvTrabajadores.DataSource = null;
            dgvTrabajadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                trabajador.NumComtrol = int.Parse(txtBuscarTrabajador.Text);
                dgvTrabajadores.DataSource = trabajador.Consultar();
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos" + ex.Message);
            }
        }
    }
}
