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

        // Plazo fijo de la política de la biblioteca: no lo decide el bibliotecario.
        private const int DiasPrestamoAlumno = 15;
        private const int DiasPrestamoTrabajador = 20;

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            txtTipoSolicitante.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtCarrera.Enabled = false;

            // El bibliotecario que registra siempre es quien inició sesión, no se escribe
            // a mano (evita que alguien registre a nombre de otro bibliotecario).
            txtBibliotecario.Text = clsLogin.NombreCompleto;
            txtBibliotecario.ReadOnly = true;

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today;
            // Se sigue proponiendo el plazo (15/20 días) como valor inicial al encontrar
            // al solicitante, pero ahora el bibliotecario puede corregirlo a mano si hace falta.

            CargarCombos();
        }

        // Llena cmbTipoPrestamo (Biblioteca/Domicilio) y cmbEstadoPrestamo
        // (Prestado/Devuelto/Vencido) desde sus catálogos en la base de datos.
        private void CargarCombos()
        {
            try
            {
                clsPrestamo prestamo = new clsPrestamo();

                DataTable dtTipos = prestamo.ObtenerTiposPrestamo();
                cmbTipoPrestamo.DataSource = dtTipos;
                cmbTipoPrestamo.DisplayMember = "tipo";
                cmbTipoPrestamo.ValueMember = "id_tipo_prestamo";
                cmbTipoPrestamo.SelectedIndex = -1;

                DataTable dtEstados = prestamo.ObtenerEstadosPrestamo();
                cmbEstadoPrestamo.DataSource = dtEstados;
                cmbEstadoPrestamo.DisplayMember = "estado";
                cmbEstadoPrestamo.ValueMember = "id_estado";

                // Se preselecciona "Prestado" como valor inicial (lo normal para un préstamo
                // nuevo), pero el combo queda habilitado por si el bibliotecario necesita
                // cambiarlo a mano.
                foreach (DataRow filaEstado in dtEstados.Rows)
                {
                    if (filaEstado["estado"].ToString() == "Prestado")
                    {
                        cmbEstadoPrestamo.SelectedValue = filaEstado["id_estado"];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los catálogos de préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calcula la fecha límite de devolución según el plazo fijo de la política
        // (15 días para Alumno, 20 para Trabajador), a partir de la fecha de préstamo.
        private void ActualizarFechaDevolucion()
        {
            int dias;
            if (txtTipoSolicitante.Text == "Alumno")
                dias = DiasPrestamoAlumno;
            else if (txtTipoSolicitante.Text == "Trabajador")
                dias = DiasPrestamoTrabajador;
            else
                return; // sin solicitante válido todavía, no hay nada que calcular

            dtpFechaDevolucion.Value = dtpFechaPrestamo.Value.Date.AddDays(dias);
        }

        // Si el bibliotecario cambia la fecha de préstamo (por ejemplo, para registrar uno
        // atrasado), el plazo se debe recalcular a partir de esa nueva fecha.
        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFechaDevolucion();
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
                    ActualizarFechaDevolucion();
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
                    ActualizarFechaDevolucion();
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
            string busquedaTexto = txtISBN.Text.Trim();

            if (string.IsNullOrEmpty(busquedaTexto))
            {
                dgvLibros.DataSource = null;
                return;
            }

            clsGestionLibros libro = new clsGestionLibros();
            try
            {
                libro.Busqueda = busquedaTexto;
                DataTable dtLibros = libro.Consultar();
                dgvLibros.DataSource = dtLibros;
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el libro: " + ex.Message);
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

        // Revisa que todo lo necesario para registrar el préstamo esté completo antes de
        // tocar la base de datos. Si algo falla, regresa false y ya deja el mensaje mostrado.
        private bool ValidarPrestamo()
        {
            if (txtTipoSolicitante.Text != "Alumno" && txtTipoSolicitante.Text != "Trabajador")
            {
                MessageBox.Show("Busca un solicitante válido (alumno o trabajador) antes de registrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumControlSolicitante.Focus();
                return false;
            }

            if (librosAPrestar.Rows.Count == 0)
            {
                MessageBox.Show("Agrega al menos un libro a la lista de préstamo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTipoPrestamo.SelectedValue == null)
            {
                MessageBox.Show("Selecciona el tipo de préstamo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoPrestamo.Focus();
                return false;
            }

            if (cmbEstadoPrestamo.SelectedValue == null)
            {
                MessageBox.Show("No se encontró el estado 'Prestado' en el catálogo (tblestado_prestamo).", "Error de catálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpFechaDevolucion.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución no puede ser antes que la fecha de préstamo.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarPrestamo())
                return;

            try
            {
                // Solo uno de los dos (matricula/numeroControl) lleva valor, según el tipo
                // de solicitante que ya se encontró al teclear el número de control/matrícula.
                int idSolicitante = Convert.ToInt32(txtNumControlSolicitante.Text.Trim());
                int? matricula = null;
                int? numeroControl = null;

                if (txtTipoSolicitante.Text == "Alumno")
                    matricula = idSolicitante;
                else
                    numeroControl = idSolicitante;

                List<int> idsEjemplares = new List<int>();
                foreach (DataRow fila in librosAPrestar.Rows)
                    idsEjemplares.Add(Convert.ToInt32(fila["id_ejemplar"]));

                clsPrestamo prestamo = new clsPrestamo();
                string msg = prestamo.RegistrarPrestamo(
                    matricula,
                    numeroControl,
                    Convert.ToInt32(cmbTipoPrestamo.SelectedValue),
                    Convert.ToInt32(cmbEstadoPrestamo.SelectedValue),
                    dtpFechaPrestamo.Value,
                    dtpFechaDevolucion.Value,
                    clsLogin.IdBibliotecario,
                    idsEjemplares
                );

                MessageBox.Show(msg, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioCompleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompleto();
        }

        // Deja el formulario como recién abierto, listo para capturar otro préstamo.
        // No toca txtBibliotecario: ese siempre es el usuario logueado.
        private void LimpiarFormularioCompleto()
        {
            txtNumControlSolicitante.Clear();
            LimpiarDatosSolicitante();

            txtISBN.Clear();
            dgvLibros.DataSource = null;
            txtLocalizacion.Clear();
            txtInventario.Clear();
            idEjemplarSeleccionado = 0;

            librosAPrestar.Rows.Clear();

            cmbTipoPrestamo.SelectedIndex = -1;
            // cmbEstadoPrestamo NO se toca: siempre se queda fijo en "Prestado" y bloqueado.
            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today;
        }

        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
