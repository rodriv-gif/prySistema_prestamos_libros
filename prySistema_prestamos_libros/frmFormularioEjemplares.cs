using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmFormularioEjemplares : Form
    {
        // Controla si el formulario está capturando ejemplares nuevos (por lote, con
        // "Cantidad") o editando uno que ya existe, igual que en frmFormularioTrabajadores.
        private bool modoEdicion = false;
        private int idEjemplarOriginal = 0;
        private int idLibroSeleccionado = 0;

        // Temporizador para no buscar en cada tecla: espera 400 ms sin escribir antes de buscar.
        private System.Windows.Forms.Timer timerBusquedaLibro;

        public frmFormularioEjemplares()
        {
            InitializeComponent();

            timerBusquedaLibro = new System.Windows.Forms.Timer();
            timerBusquedaLibro.Interval = 400;
            timerBusquedaLibro.Tick += TimerBusquedaLibro_Tick;
        }

        // Constructor para modo edición: recibe la fila seleccionada en el DataGridView
        // de frmGestionEjemplares y llena los campos con esos datos.
        public frmFormularioEjemplares(DataGridViewRow filaSeleccionada) : this()
        {
            CargarDatosParaEditar(filaSeleccionada);
        }

        private void CargarDatosParaEditar(DataGridViewRow fila)
        {
            modoEdicion = true;
            idEjemplarOriginal = Convert.ToInt32(fila.Cells["ID Ejemplar"].Value);
            idLibroSeleccionado = Convert.ToInt32(fila.Cells["id_libro"].Value);

            txtLibroPerteneciete.Text = fila.Cells["ISBN"].Value?.ToString();
            txtLocalizacion.Text = fila.Cells["Localización"].Value?.ToString();

            string fechaTexto = Convert.ToString(fila.Cells["Fecha de adquisición"].Value);
            if (!string.IsNullOrEmpty(fechaTexto))
                dtpFechaAdquisicion.Value = Convert.ToDateTime(fechaTexto);

            // "Cantidad" solo aplica cuando se capturan varios ejemplares nuevos de golpe;
            // al editar uno que ya existe no tiene sentido, así que se deshabilita.
            nudCantidad.Enabled = false;

            // Asignar .Text no dispara el TextChanged, así que se carga el grid del libro a mano.
            txtLibroPerteneciete.ReadOnly = true;
            CargarLibroEnGrid(txtLibroPerteneciete.Text);
        }

        // Busca el libro por ISBN para marcarlo con checkbox; en modo edición ya viene marcado y de solo lectura.
        private void CargarLibroEnGrid(string isbnBuscado)
        {
            if (string.IsNullOrWhiteSpace(isbnBuscado))
            {
                dgvLibrosPerteneciente.DataSource = null;
                return;
            }

            try
            {
                clsGestionLibros libro = new clsGestionLibros();
                DataTable dtLibros = libro.BuscarLibroParaEjemplar(isbnBuscado);
                dgvLibrosPerteneciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLibrosPerteneciente.DataSource = dtLibros;

                if (dgvLibrosPerteneciente.Columns["id_libro"] != null)
                    dgvLibrosPerteneciente.Columns["id_libro"].Visible = false;

                if (modoEdicion)
                {
                    foreach (DataGridViewRow filaGrid in dgvLibrosPerteneciente.Rows)
                    {
                        int idLibroFila = Convert.ToInt32(filaGrid.Cells["id_libro"].Value);
                        filaGrid.Cells["chkSeleccionar"].Value = (idLibroFila == idLibroSeleccionado);
                    }
                    dgvLibrosPerteneciente.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLibroPerteneciete_TextChanged(object sender, EventArgs e)
        {
            if (modoEdicion) return; // en edición el libro ya viene fijo, no se vuelve a buscar

            // Reinicia el temporizador en cada tecla; la búsqueda real ocurre en
            // TimerBusquedaLibro_Tick, solo cuando el usuario deja de escribir.
            timerBusquedaLibro.Stop();
            timerBusquedaLibro.Start();
        }

        private void TimerBusquedaLibro_Tick(object sender, EventArgs e)
        {
            timerBusquedaLibro.Stop();
            CargarLibroEnGrid(txtLibroPerteneciete.Text.Trim());
        }

        // Al marcar el checkbox de una fila se guarda el id_libro de esa fila. Se
        // desmarcan las demás para que solo se pueda elegir un libro a la vez.
        private void dgvLibrosPerteneciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvLibrosPerteneciente.Columns[e.ColumnIndex].Name != "chkSeleccionar") return;

            dgvLibrosPerteneciente.CommitEdit(DataGridViewDataErrorContexts.Commit);

            DataGridViewRow filaMarcada = dgvLibrosPerteneciente.Rows[e.RowIndex];
            bool marcada = Convert.ToBoolean(filaMarcada.Cells["chkSeleccionar"].Value ?? false);

            foreach (DataGridViewRow fila in dgvLibrosPerteneciente.Rows)
            {
                if (fila.Index != e.RowIndex)
                    fila.Cells["chkSeleccionar"].Value = false;
            }

           idLibroSeleccionado = marcada ? Convert.ToInt32(filaMarcada.Cells["id_libro"].Value) : 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show("Selecciona el libro con el checkbox antes de guardar.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtLocalizacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la localización.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalizacion.Focus();
                return;
            }

            try
            {
                clsGestionEjemplares ejemplar = new clsGestionEjemplares();
                string msg;

                if (modoEdicion)
                {
                    msg = ejemplar.ActualizarEjemplar(idEjemplarOriginal, txtLocalizacion.Text.Trim(), dtpFechaAdquisicion.Value);
                }
                else
                {
                    int cantidad = Convert.ToInt32(nudCantidad.Value);
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0.", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    msg = ejemplar.RegistrarEjemplares(idLibroSeleccionado, txtLocalizacion.Text.Trim(), dtpFechaAdquisicion.Value, cantidad);
                }

                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLibroPerteneciete.Clear();

            txtLocalizacion.Clear();

            nudCantidad.Value = 1;

            dtpFechaAdquisicion.Value = DateTime.Today;

            idLibroSeleccionado = 0;

            dgvLibrosPerteneciente.DataSource = null;

            txtLibroPerteneciete.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarejemplar_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un libro.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar el DataGridView
            dgvnumejemplares.Rows.Clear();

            string isbn = "";

            // Obtener el ISBN del libro seleccionado
            foreach (DataGridViewRow fila in dgvLibrosPerteneciente.Rows)
            {
                bool seleccionado = Convert.ToBoolean(fila.Cells["chkSeleccionar"].Value ?? false);

                if (seleccionado)
                {
                    isbn = fila.Cells["ISBN"].Value.ToString();
                    break;
                }
            }
            // Agregar los ejemplares
            for (int i = 1; i <= (int)nudCantidad.Value; i++)
            {
                dgvnumejemplares.Rows.Add(isbn, i);
            }
        }
        private void frmFormularioEjemplares_Load(object sender, EventArgs e)
        {
            dgvnumejemplares.Columns.Clear();

            dgvnumejemplares.Columns.Add("ISBN", "ISBN");
            dgvnumejemplares.Columns.Add("NumeroEjemplar", "No. Ejemplar");

            dgvnumejemplares.AllowUserToAddRows = false;
            dgvnumejemplares.ReadOnly = true;
            dgvnumejemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }    
    }
}
