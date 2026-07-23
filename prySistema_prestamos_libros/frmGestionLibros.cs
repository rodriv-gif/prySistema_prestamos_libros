using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmGestionLibros : Form
    {
        clsGestionLibros Libros;
        public frmGestionLibros()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            Libros = new clsGestionLibros();
            dgvLibros.DataSource = null;

            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                dgvLibros.DataSource = Libros.CargarDataGrid();
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
            
            if (dgvLibros.Columns["id_libro"] != null)
                dgvLibros.Columns["id_libro"].Visible = false;
            if (dgvLibros.Columns["id_editorial"] != null)
                dgvLibros.Columns["id_editorial"].Visible = false;
            if (dgvLibros.Columns["id_categoria"] != null)
                dgvLibros.Columns["id_categoria"].Visible = false;
            if (dgvLibros.Columns["id_idioma"] != null)
                dgvLibros.Columns["id_idioma"].Visible = false;
            if (dgvLibros.Columns["id_ejemplar"] != null)
                dgvLibros.Columns["id_ejemplar"].Visible = false;

            if (dgvLibros.Columns["Editorial"] != null)
                dgvLibros.Columns["Editorial"].Visible = false;
            if (dgvLibros.Columns["Páginas"] != null)
                dgvLibros.Columns["Páginas"].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioLibros();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un libro de la lista antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvLibros.CurrentRow;
            var frm = new frmFormularioLibros(fila);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un libro de la lista antes de dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvLibros.CurrentRow;

            string tituloLibro = fila.Cells["Título"].Value?.ToString();
            int idLibro = Convert.ToInt32(fila.Cells["id_libro"].Value);

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que quieres dar de baja el libro '{tituloLibro}'?",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                clsGestionLibros libroBaja = new clsGestionLibros();
                string msg = libroBaja.DarBajaLibro(idLibro);
                MessageBox.Show(msg, "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo dar de baja el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarLibro.Text))
            {
                CargarGrid();
                return;
            }

            dgvLibros.DataSource = null;

            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                Libros = new clsGestionLibros();
                Libros.Isbn = txtBuscarLibro.Text;
                dgvLibros.DataSource = Libros.Consultar();
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos: " + ex.Message);
            }
        }
    }
}
