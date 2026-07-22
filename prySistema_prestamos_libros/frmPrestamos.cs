using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();

            librosAPrestar = new DataTable();
            librosAPrestar.Columns.Add("Título");
            librosAPrestar.Columns.Add("ISBN");
            librosAPrestar.Columns.Add("Editorial");
            librosAPrestar.Columns.Add("Categoría");
            librosAPrestar.Columns.Add("Idioma");
            librosAPrestar.Columns.Add("Autores");
            librosAPrestar.Columns.Add("id_ejemplar");
            dgvLibrosPrestar.DataSource = librosAPrestar;
            dgvLibrosPrestar.Columns["id_ejemplar"].HeaderText = "Ejemplar";
        }

        private int idEjemplarSeleccionado;
        private DataTable librosAPrestar;

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            txtTipoSolicitante.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtCarrera.Enabled = false;
        }

        // Al teclear el número de control / matrícula, se busca primero en Alumnos y,
        // si no aparece ahí, se busca en Trabajadores. El bibliotecario nunca elige el
        // tipo a mano, se llena solo según en cuál tabla se encontró.
        private void txtNumControlSolicitante_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNumControlSolicitante.Text.Trim();

            if (!int.TryParse(texto, out int idBuscado))
            {
                LimpiarDatosSolicitante();
                return;
            }

            try
            {
                clsGestionAlumno alumno = new clsGestionAlumno();
                DataTable dtAlumno = alumno.BuscarPorMatricula(idBuscado);
                if (dtAlumno.Rows.Count > 0)
                {
                    DataRow fila = dtAlumno.Rows[0];
                    txtTipoSolicitante.Text = "Alumno";
                    txtNombre.Text = fila["Nombre"].ToString();
                    txtApellidoPaterno.Text = fila["Apellido Paterno"].ToString();
                    txtApellidoMaterno.Text = fila["Apellido Materno"].ToString();
                    txtCarrera.Text = fila["Carrera"].ToString();
                    txtGrado.Text = fila["Grado"].ToString();
                    txtGrupo.Text = fila["Grupo"].ToString();
                    return;
                }

                clsGestionTrabajador trabajador = new clsGestionTrabajador();
                DataTable dtTrabajador = trabajador.BuscarPorNumeroControl(idBuscado);
                if (dtTrabajador.Rows.Count > 0)
                {
                    DataRow fila = dtTrabajador.Rows[0];
                    txtTipoSolicitante.Text = "Trabajador";
                    txtNombre.Text = fila["Nombre"].ToString();
                    txtApellidoPaterno.Text = fila["Apellido Paterno"].ToString();
                    txtApellidoMaterno.Text = fila["Apellido Materno"].ToString();
                    txtCarrera.Text = fila["Carrera"].ToString();
                    txtGrado.Clear();
                    txtGrupo.Clear();
                    return;
                }

                // No se encontró en ninguna de las dos tablas
                LimpiarDatosSolicitante();
                txtTipoSolicitante.Text = "No encontrado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al solicitante: " + ex.Message);
            }
        }

        private void LimpiarDatosSolicitante()
        {
            txtTipoSolicitante.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCarrera.Clear();
            txtGrado.Clear();
            txtGrupo.Clear();
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            string isbnTexto = txtISBN.Text.Trim();

            if (string.IsNullOrEmpty(isbnTexto))
            {
                dgvLibros.DataSource = null;
                return;
            }

            clsGestionLibros libro = new clsGestionLibros();
            try
            {
                libro.Isbn = isbnTexto;
                DataTable dtLibros = libro.Consultar();
                dgvLibros.DataSource = dtLibros;
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el libro" + ex.Message);
            }
        }

        private void LimpiarDataGridLibros()
        {
            dgvLibros.Rows.Clear();
        }

        private void OcultarColumnas()
        {
            if (dgvLibros.Columns["id_ejemplar"] != null)
                dgvLibros.Columns["id_ejemplar"].Visible = false;
            if (dgvLibros.Columns["Localización"] != null)
                dgvLibros.Columns["Localización"].Visible = false;
            if (dgvLibros.Columns["Inventario"] != null)
                dgvLibros.Columns["Inventario"].Visible = false;
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvLibros.CurrentRow;

            if (fila == null)
            {
                return;
            }

            txtLocalizacion.Text = fila.Cells["Localización"].Value?.ToString();
            txtInventario.Text = fila.Cells["Inventario"].Value?.ToString();
            idEjemplarSeleccionado = Convert.ToInt32(fila.Cells["id_ejemplar"].Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //primero Validar que sí se haya seleccionado un libro
            if (idEjemplarSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un libro primero");
                return;
            }

            //validad para evitar agregar el mismo ejemplar dos veces
            foreach (DataRow filaExistente in librosAPrestar.Rows)
            {
                if (Convert.ToInt32(filaExistente["id_ejemplar"]) == idEjemplarSeleccionado)
                {
                    MessageBox.Show("Ese ejemplar ya está seleccionado en la lista");
                    return;
                }
            }

            //Tomar de nuevo la fila seleccionada en dgvLibros
            DataGridViewRow filaSeleccionada = dgvLibros.CurrentRow;
             librosAPrestar.Rows.Add(
                filaSeleccionada.Cells["Título"].Value,
                filaSeleccionada.Cells["ISBN"].Value,
                filaSeleccionada.Cells["Editorial"].Value,
                filaSeleccionada.Cells["Categoría"].Value,
                filaSeleccionada.Cells["Idioma"].Value,
                filaSeleccionada.Cells["Autores"].Value,
                idEjemplarSeleccionado
            );
        }
    }
}
