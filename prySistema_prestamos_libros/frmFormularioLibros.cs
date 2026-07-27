using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmFormularioLibros : Form
    {
        private bool Editar = false;
        private int id_LibroOriginal = 0;

        public frmFormularioLibros()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarGridAlmacen();
            CargarTodosLosAutores();
        }
        public frmFormularioLibros(DataGridViewRow filaSeleccionada) : this()
        {
            CargarDatosParaEditar(filaSeleccionada);
        }

        private void ConfigurarGridAlmacen()
        {
            if (dgvAlmacenarAutor.Columns.Count == 0)
            {
                dgvAlmacenarAutor.Columns.Add("id_autor", "ID Autor");
                dgvAlmacenarAutor.Columns.Add("nombre_completo", "Nombre Completo");

                dgvAlmacenarAutor.Columns["id_autor"].Visible = false;
                dgvAlmacenarAutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void CargarTodosLosAutores()
        {
            clsGestionAutor autor = new clsGestionAutor();
            autor.ParametroBusqueda = "";
            dgvAutor.DataSource = autor.ConsultarAutor();

            dgvAutor.Columns["id_autor"].Visible = true;

            dgvAutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CargarCombos()
        {
            clsGestionLibros libro = new clsGestionLibros();
            try
            {
                DataTable dtEditoriales = libro.ObtenerEditoriales();
                cmbEditorial.DataSource = dtEditoriales;
                cmbEditorial.DisplayMember = "nombre_editorial";
                cmbEditorial.ValueMember = "id_editorial";

                DataTable dtCategorias = libro.ObtenerCategorias();
                cmbCategoria.DataSource = dtCategorias;
                cmbCategoria.DisplayMember = "nombre";
                cmbCategoria.ValueMember = "id_categoria";

                DataTable dtIdiomas = libro.ObtenerIdiomas();
                cmbIdioma.DataSource = dtIdiomas;
                cmbIdioma.DisplayMember = "nombre_idioma";
                cmbIdioma.ValueMember = "id_idioma";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas desplegables: " + ex.Message);
            }
        }

        private void CargarDatosParaEditar(DataGridViewRow fila)
        {
            Editar = true;
            id_LibroOriginal = Convert.ToInt32(fila.Cells["id_libro"].Value);

            txtISBN.Text = fila.Cells["ISBN"].Value?.ToString();
            txtTitulo.Text = fila.Cells["Título"].Value?.ToString();
            txtNumPaginas.Text = fila.Cells["Páginas"].Value?.ToString();

            string idEditorial = fila.Cells["id_editorial"].Value?.ToString();
            if (!string.IsNullOrEmpty(idEditorial))
                cmbEditorial.SelectedValue = Convert.ToInt32(idEditorial);

            string idCategoria = fila.Cells["id_categoria"].Value?.ToString();
            if (!string.IsNullOrEmpty(idCategoria))
                cmbCategoria.SelectedValue = Convert.ToInt32(idCategoria);

            string idIdioma = fila.Cells["id_idioma"].Value?.ToString();
            if (!string.IsNullOrEmpty(idIdioma))
                cmbIdioma.SelectedValue = Convert.ToInt32(idIdioma);

            CargarAutoresDelLibro(id_LibroOriginal);
        }

        private void CargarAutoresDelLibro(int idLibro)
        {
            clsGestionLibros libro = new clsGestionLibros();
            DataTable dtAutores = libro.ObtenerAutoresPorLibro(idLibro);
            foreach (DataRow row in dtAutores.Rows)
            {
                dgvAlmacenarAutor.Rows.Add(row["id_autor"], row["nombre_completo"]);
            }
        }

        // Solo dígitos (ISBN y número de páginas).
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // permite backspace

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // El título permite letras, números, espacio y puntuación común de títulos
        // (: , . ' -), a diferencia de Nombre/Apellidos que solo aceptan letras.
        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            bool permitido = char.IsLetterOrDigit(e.KeyChar) || " :,.'-".IndexOf(e.KeyChar) >= 0;
            if (!permitido)
                e.Handled = true;
        }

        // Revisa que cada campo tenga el tipo de dato y el largo correcto antes de mandarlo
        // a la base de datos. Si algo falla, regresa false y ya deja el mensaje mostrado.
        private bool ValidarCampos()
        {
            if (txtISBN.Text.Trim().Length != 13)
            {
                MessageBox.Show("El ISBN debe tener exactamente 13 dígitos.", "ISBN inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Captura el título del libro.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (!int.TryParse(txtNumPaginas.Text, out int paginas) || paginas <= 0)
            {
                MessageBox.Show("El número de páginas debe ser un número mayor a 0.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumPaginas.Focus();
                return false;
            }

            if (cmbEditorial.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una editorial.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEditorial.Focus();
                return false;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una categoría.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (cmbIdioma.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un idioma.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIdioma.Focus();
                return false;
            }

            if (dgvAlmacenarAutor.Rows.Count == 0 || (dgvAlmacenarAutor.Rows.Count == 1 && dgvAlmacenarAutor.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debes agregar al menos un autor al libro.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void dgvAutor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarAutor.PerformClick();
        }

        private void dgvAlmacenarAutor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar_Click(sender, e);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvAlmacenarAutor.CurrentRow != null && !dgvAlmacenarAutor.CurrentRow.IsNewRow)
            {
                dgvAlmacenarAutor.Rows.Remove(dgvAlmacenarAutor.CurrentRow);
            }
            else
            {
                MessageBox.Show("Selecciona un autor de la lista del libro para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (dgvAutor.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un autor primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string idAutor = dgvAutor.CurrentRow.Cells["id_autor"].Value.ToString();

            string nombreAutor = dgvAutor.CurrentRow.Cells["Nombre Completo"].Value.ToString();

            foreach (DataGridViewRow fila in dgvAlmacenarAutor.Rows)
            {
                if (fila.Cells["id_autor"].Value != null && fila.Cells["id_autor"].Value.ToString() == idAutor)
                {
                    MessageBox.Show("Este autor ya fue agregado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvAlmacenarAutor.Rows.Add(idAutor, nombreAutor);
        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            var frm = new frmFormularioAutores();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                clsGestionLibros libro = new clsGestionLibros();

                libro.Isbn = txtISBN.Text;
                libro.Titulo = txtTitulo.Text;
                libro.Paginas = Convert.ToInt32(txtNumPaginas.Text);

                libro.IdEditorial = Convert.ToInt32(cmbEditorial.SelectedValue);
                libro.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                libro.IdIdioma = Convert.ToInt32(cmbIdioma.SelectedValue);

                List<int> listaAutores = new List<int>();
                foreach (DataGridViewRow fila in dgvAlmacenarAutor.Rows)
                {
                    if (fila.Cells["id_autor"].Value != null)
                    {
                        listaAutores.Add(Convert.ToInt32(fila.Cells["id_autor"].Value));
                    }
                }

                string msg = "";
                if (Editar)
                {
                    msg = libro.ActualizarLibro(id_LibroOriginal, listaAutores);
                }
                else
                {
                    msg = libro.RegistrarLibro(listaAutores);
                }

                MessageBox.Show(msg, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtTitulo.Clear();
            txtNumPaginas.Clear();
            txtBuscarAutor.Clear();

            dgvAutor.DataSource = null;
            dgvAlmacenarAutor.Rows.Clear();

            if (cmbEditorial.Items.Count > 0) cmbEditorial.SelectedIndex = 0;
            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            if (cmbIdioma.Items.Count > 0) cmbIdioma.SelectedIndex = 0;

            txtISBN.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarAutor_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBuscarAutor.Text))
            {
                CargarTodosLosAutores();
                return;
            }

            try
            {
                clsGestionAutor autor = new clsGestionAutor();
                autor.ParametroBusqueda = txtBuscarAutor.Text;
                dgvAutor.DataSource = autor.ConsultarAutor();

                dgvAutor.Columns["id_autor"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda de autor: " + ex.Message);
            }
        }
    }
}

