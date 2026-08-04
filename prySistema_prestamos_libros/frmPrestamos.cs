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

            // Ninguno de los dos se debe poder editar escribiendo filas nuevas directo en el grid.
            dgvLibros.AllowUserToAddRows = false;
            dgvLibrosPrestar.AllowUserToAddRows = false;

            librosAPrestar = new DataTable();
            librosAPrestar.Columns.Add("Título");
            librosAPrestar.Columns.Add("ISBN");
            librosAPrestar.Columns.Add("Editorial");
            librosAPrestar.Columns.Add("Categoría");
            librosAPrestar.Columns.Add("Idioma");
            librosAPrestar.Columns.Add("Autores");
            librosAPrestar.Columns.Add("Ejemplar"); // número de ejemplar de ESE libro (1, 2, 3...), no el id interno
            librosAPrestar.Columns.Add("id_ejemplar");
            dgvLibrosPrestar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibrosPrestar.DataSource = librosAPrestar;
            // id_ejemplar es solo para identificar internamente el registro; el usuario ve la columna "Ejemplar".
            dgvLibrosPrestar.Columns["id_ejemplar"].Visible = false;
        }

        private int idEjemplarSeleccionado;
        private DataTable librosAPrestar;

        // Plazo fijo de la política de la biblioteca: no lo decide el bibliotecario.
        private const int DiasPrestamoAlumno = 15;
        private const int DiasPrestamoTrabajador = 20;

        // Máximo de libros que puede tener prestados un solicitante al mismo tiempo.
        private const int LimitePrestamosAlumno = 4;
        private const int LimitePrestamosTrabajador = 6;

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            txtTipoSolicitante.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            txtGrado.ReadOnly = true;
            txtGrupo.ReadOnly = true;
            txtCarrera.ReadOnly = true;

            // El bibliotecario que registra siempre es quien inició sesión, no se escribe
            // a mano (evita que alguien registre a nombre de otro bibliotecario).
            txtBibliotecario.Text = clsLogin.NombreCompleto;
            txtBibliotecario.ReadOnly = true;

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today;
            // Se sigue proponiendo el plazo (15/20 días) como valor inicial al encontrar
            // al solicitante, pero ahora el bibliotecario puede corregirlo a mano si hace falta.

            CargarCombos();
            CargarTodosLosLibros();
        }

        // Precarga el grid con todos los ejemplares disponibles, igual que hacen
        // Alumnos, Trabajadores y Autores; la búsqueda de ISBN/Título solo filtra esta lista.
        private void CargarTodosLosLibros()
        {
            clsGestionLibros libro = new clsGestionLibros();
            try
            {
                DataTable dtLibros = libro.BuscarLibrosConEjemplares("");
                dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLibros.DataSource = dtLibros;
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros: " + ex.Message);
            }
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

                // Se preselecciona "Prestado", pero el combo sigue habilitado por si se necesita cambiar.
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

        // "Biblioteca" devuelve el mismo día; "Domicilio" aplica el plazo fijo (15 días alumno, 20 trabajador).
        private void ActualizarFechaDevolucion()
        {
            int? diasSolicitante = null;
            if (txtTipoSolicitante.Text == "Alumno")
                diasSolicitante = DiasPrestamoAlumno;
            else if (txtTipoSolicitante.Text == "Trabajador")
                diasSolicitante = DiasPrestamoTrabajador;

            if (diasSolicitante == null)
                return; // sin solicitante válido todavía, no hay nada que calcular

            if (cmbTipoPrestamo.Text == "Biblioteca")
                dtpFechaDevolucion.Value = dtpFechaPrestamo.Value.Date;
            else
                dtpFechaDevolucion.Value = dtpFechaPrestamo.Value.Date.AddDays(diasSolicitante.Value);
        }

        // Si cambia la fecha de préstamo, el plazo se recalcula a partir de esa nueva fecha.
        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFechaDevolucion();
        }

        // Si cambian el tipo de préstamo (Biblioteca/Domicilio), también hay que
        // recalcular, ya que ese dato decide si aplica el mismo día o el plazo de 15/20 días.
        private void cmbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarFechaDevolucion();
        }

        // Busca primero en Alumnos y, si no aparece, en Trabajadores; el tipo se llena solo.
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
                // Si se limpia la búsqueda, la selección anterior ya no aplica a nada
                // visible; hay que resetearla para que btnAgregar no la use por error.
                txtLocalizacion.Clear();
                txtInventario.Clear();
                idEjemplarSeleccionado = 0;
                CargarTodosLosLibros();
                return;
            }

            clsGestionLibros libro = new clsGestionLibros();
            try
            {
                DataTable dtLibros = libro.BuscarLibrosConEjemplares(busquedaTexto);
                dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            // La fila vacía de "agregar nueva" no tiene datos; intentar leerla truena la conversión y esto lo evita.
            if (fila.IsNewRow)
            {
                return;
            }

            // Evita un error si el grid ya se está regenerando cuando se retecla muy rápido en ISBN.
            if (dgvLibros.Columns["Localización"] == null)
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

            // Por si idEjemplarSeleccionado quedó con un valor viejo pero el grid ya no
            // tiene ninguna fila seleccionada (por ejemplo, se limpió la búsqueda).
            if (filaSeleccionada == null)
            {
                MessageBox.Show("Selecciona un libro primero");
                idEjemplarSeleccionado = 0;
                return;
            }

            // Si ya hay un solicitante encontrado, se avisa aquí mismo si este libro haría
            // que se pase del límite, antes de agregarlo al carrito.
            if (txtTipoSolicitante.Text == "Alumno" || txtTipoSolicitante.Text == "Trabajador")
            {
                if (!ValidarLimitePrestamos(librosAPrestar.Rows.Count + 1))
                    return;
            }

             librosAPrestar.Rows.Add(
                filaSeleccionada.Cells["Título"].Value,
                filaSeleccionada.Cells["ISBN"].Value,
                filaSeleccionada.Cells["Editorial"].Value,
                filaSeleccionada.Cells["Categoría"].Value,
                filaSeleccionada.Cells["Idioma"].Value,
                filaSeleccionada.Cells["Autores"].Value,
                filaSeleccionada.Cells["Inventario"].Value,
                idEjemplarSeleccionado
            );
        }

        // Avisa si, con lo del carrito, se pasaría del límite (4 alumno, 6 trabajador). Se usa en Agregar y Registrar.
        private bool ValidarLimitePrestamos(int totalLibrosAValidar)
        {
            int idSolicitante = Convert.ToInt32(txtNumControlSolicitante.Text.Trim());
            int limitePrestamos = txtTipoSolicitante.Text == "Alumno" ? LimitePrestamosAlumno : LimitePrestamosTrabajador;

            try
            {
                clsPrestamo prestamoConsulta = new clsPrestamo();
                int prestamosActivos = prestamoConsulta.ContarPrestamosActivos(idSolicitante);
                int totalConEstePrestamo = prestamosActivos + totalLibrosAValidar;

                if (totalConEstePrestamo > limitePrestamos)
                {
                    MessageBox.Show(
                        "No se puede agregar este libro: ya tiene " + prestamosActivos + " de " + limitePrestamos +
                        " libros prestados como máximo. Debe devolver alguno antes de prestar otro.",
                        "Límite de préstamos alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo validar el límite de préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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

            // Validación final por si algo cambió desde que se agregaron los libros al carrito.
            if (!ValidarLimitePrestamos(librosAPrestar.Rows.Count))
                return false;

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
            CargarTodosLosLibros();
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
