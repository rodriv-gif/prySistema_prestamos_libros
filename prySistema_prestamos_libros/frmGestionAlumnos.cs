using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmGestionAlumnos : Form
    {
        clsGestionAlumno alumno;
        public frmGestionAlumnos()
        {
            InitializeComponent();
            CargarGrid();

            // Solo el Administrador puede dar de baja alumnos; un Bibliotecario no.
            btnDarBaja.Enabled = clsLogin.EsAdministrador;
        }
        public void CargarGrid()
        {
            alumno = new clsGestionAlumno();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvAlumnos.DataSource = alumno.CargarDataGrid();
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
            if (dgvAlumnos.Columns["id_carrera"] != null)
                dgvAlumnos.Columns["id_carrera"].Visible = false;
            if (dgvAlumnos.Columns["id_direccion"] != null)
                dgvAlumnos.Columns["id_direccion"].Visible = false;
            if (dgvAlumnos.Columns["id_colonia"] != null)
                dgvAlumnos.Columns["id_colonia"].Visible = false;
            if (dgvAlumnos.Columns["Fecha de Registro"] != null)
                dgvAlumnos.Columns["Fecha de Registro"].Visible = false;
            if (dgvAlumnos.Columns["Calle"] != null)
                dgvAlumnos.Columns["Calle"].Visible = false;
            if (dgvAlumnos.Columns["Colonia"] != null)
                dgvAlumnos.Columns["Colonia"].Visible = false;
            if (dgvAlumnos.Columns["Código Postal"] != null)
                dgvAlumnos.Columns["Código Postal"].Visible = false;
            if (dgvAlumnos.Columns["Municipio"] != null)
                dgvAlumnos.Columns["Municipio"].Visible = false;
            if (dgvAlumnos.Columns["Nombre"] != null)
                dgvAlumnos.Columns["Nombre"].Visible = false;
            if (dgvAlumnos.Columns["Apellido paterno"] != null)
                dgvAlumnos.Columns["Apellido paterno"].Visible = false;
            if (dgvAlumnos.Columns["Apellido materno"] != null)
                dgvAlumnos.Columns["Apellido materno"].Visible = false;
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioAlumno();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // CurrentRow se actualiza con solo darle clic a una celda; SelectedRows.Count solo
            // cuenta cuando se selecciona la fila completa (clic en el encabezado gris de la izquierda).
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un alumno de la lista antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvAlumnos.CurrentRow;

            var frm = new frmFormularioAlumno(fila);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
            CargarGrid();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un alumno de la lista antes de dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow fila = dgvAlumnos.CurrentRow;
            string nombre = fila.Cells["Nombre"].Value?.ToString();
            int matricula = Convert.ToInt32(fila.Cells["Matricula"].Value);

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que quieres dar de baja a {nombre}?",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                clsAlumnos alumnoBaja = new clsAlumnos();
                string msg = alumnoBaja.DarBajaAlumno(matricula);
                MessageBox.Show(msg, "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo dar de baja al alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bloquea cualquier carácter que no sea letra, número o espacio, para que no
        // se puedan escribir símbolos (%, ', ;, --, etc.) en la barra de búsqueda.
        private void txtBuscarAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // permite backspace

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtBuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarAlumno.Text))
            {
                CargarGrid();
                return;
            }
            alumno = new clsGestionAlumno();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                alumno.Busqueda = txtBuscarAlumno.Text;
                dgvAlumnos.DataSource = alumno.Consultar();
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
