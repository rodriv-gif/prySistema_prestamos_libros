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
            if (dgvTrabajadores.Columns["Nombre"] != null)
                dgvTrabajadores.Columns["Nombre"].Visible = false;
            if (dgvTrabajadores.Columns["Apellido paterno"] != null)
                dgvTrabajadores.Columns["Apellido paterno"].Visible = false;
            if (dgvTrabajadores.Columns["Apellido materno"] != null)
                dgvTrabajadores.Columns["Apellido materno"].Visible = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioLibross();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // CurrentRow se actualiza con solo darle clic a una celda; SelectedRows.Count solo
            // cuenta cuando se selecciona la fila completa (clic en el encabezado gris de la izquierda).
            if (dgvTrabajadores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un trabajador de la lista antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvTrabajadores.CurrentRow;

            var frm = new frmFormularioLibross(fila);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un trabajador de la lista antes de dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvTrabajadores.CurrentRow;
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
