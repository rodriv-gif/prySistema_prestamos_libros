using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
            CargarEstadosPrestamo();
        }
        // Variables para recordar qué libro se seleccionó
        private int idPrestamoSeleccionado = 0;
        private int diasRetrasoSeleccionados = 0;
        private decimal montoMulta = 0;
        private string tituloLibroSeleccionado = "";
        private decimal montoTotalMulta = 0;
        private string librosVencidosGlobal = "";
        private void txtNumControl_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNumControl.Text.Trim();

            //Si borraron todo el texto, limpiamos las cajas y la tabla
            if (string.IsNullOrEmpty(texto))
            {
                LimpiarDatosSolicitante();
                dgvPrestamosActivos.DataSource = null;
                dgvMultasPendientes.DataSource = null;
                return;
            }

            // Convertimos el texto a número para poder buscarlo
            if (!int.TryParse(texto, out int idBuscado)) return;

            try
            {
                bool encontrado = false;

                // Buscamos primero en la tabla de Alumnos
                clsGestionAlumno alumno = new clsGestionAlumno();
                DataTable dtAlumno = alumno.BuscarPorMatricula(idBuscado);

                if (dtAlumno.Rows.Count > 0)
                {
                    DataRow fila = dtAlumno.Rows[0];
                    txtNombreSolicitante.Text = fila["Nombre"].ToString();
                    txtApellidoPaterno.Text = fila["Apellido Paterno"].ToString();
                    txtApellidoMaterno.Text = fila["Apellido Materno"].ToString();
                    txtCarrera.Text = fila["Carrera"].ToString();
                    txtGrado.Text = fila["Grado"].ToString();
                    txtGrupo.Text = fila["Grupo"].ToString();
                    encontrado = true;
                }
                else
                {
                    // Si no es alumno, buscamos en la tabla de Trabajadores
                    clsGestionTrabajador trabajador = new clsGestionTrabajador();
                    DataTable dtTrabajador = trabajador.BuscarPorNumeroControl(idBuscado);

                    if (dtTrabajador.Rows.Count > 0)
                    {
                        DataRow fila = dtTrabajador.Rows[0];
                        txtNombreSolicitante.Text = fila["Nombre"].ToString();
                        txtApellidoPaterno.Text = fila["Apellido Paterno"].ToString();
                        txtApellidoMaterno.Text = fila["Apellido Materno"].ToString();
                        txtCarrera.Text = fila["Carrera"].ToString();
                        txtGrado.Clear(); // Limpiamos porque no tienen grado
                        txtGrupo.Clear(); // Limpiamos porque no tienen grupo
                        encontrado = true;
                    }
                }

                // Si encontramos al solicitante, buscamos si tiene libros pendientes
                if (encontrado)
                {
                    clsDevolucion devolucion = new clsDevolucion();
                    // Llamamos a la clase que arreglamos en el paso anterior
                    DataTable dtPrestamos = devolucion.ObtenerPrestamosPendientes(idBuscado);

                    // Llenamos la tabla visual con los resultados
                    dgvPrestamosActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvPrestamosActivos.DataSource = dtPrestamos;
                    dgvPrestamosActivos.AllowUserToAddRows = false;

                    // id_prestamo es uso interno, no se le muestra al bibliotecario.
                    if (dgvPrestamosActivos.Columns["id_prestamo"] != null)
                    {
                        dgvPrestamosActivos.Columns["id_prestamo"].Visible = false;
                    }

                    // Multas de visitas anteriores, sin relación con los libros de hoy.
                    DataTable dtMultasPendientes = devolucion.ObtenerMultasPendientes(idBuscado);

                    // Columna oculta: en NULL para multas viejas; guarda el id_prestamo
                    // en las filas de vista previa de multas nuevas.
                    if (!dtMultasPendientes.Columns.Contains("id_prestamo_origen"))
                    {
                        dtMultasPendientes.Columns.Add("id_prestamo_origen", typeof(int)).AllowDBNull = true;
                    }

                    dgvMultasPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMultasPendientes.DataSource = dtMultasPendientes;
                    // Evita el renglón en blanco al final (es de solo lectura).
                    dgvMultasPendientes.AllowUserToAddRows = false;

                    // id_prestamo_origen e id_multa son uso interno, no se muestran.
                    if (dgvMultasPendientes.Columns["id_prestamo_origen"] != null)
                    {
                        dgvMultasPendientes.Columns["id_prestamo_origen"].Visible = false;
                    }
                    if (dgvMultasPendientes.Columns["id_multa"] != null)
                    {
                        dgvMultasPendientes.Columns["id_multa"].Visible = false;
                    }
                }
                else
                {
                    // Solo avisa si ya escribió 8+ dígitos (no desde el primero).
                    if (texto.Length >= 8)
                    {
                        LimpiarDatosSolicitante();
                        dgvPrestamosActivos.DataSource = null;
                        dgvMultasPendientes.DataSource = null;
                        MessageBox.Show("No se encontró ningún solicitante con esa matrícula o número de control.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método auxiliar para limpiar las cajas de texto de forma rápida
        private void LimpiarDatosSolicitante()
        {
            txtNombreSolicitante.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCarrera.Clear();
            txtGrado.Clear();
            txtGrupo.Clear();
        }

        private void dgvPrestamosActivos_SelectionChanged(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dgvPrestamosActivos.CurrentRow == null) return;

            DataGridViewRow fila = dgvPrestamosActivos.CurrentRow;

            // El monto/días/motivo en pantalla ya no dependen de esto, sino de RecalcularTotales().
            idPrestamoSeleccionado = Convert.ToInt32(fila.Cells["id_prestamo"].Value);
            tituloLibroSeleccionado = fila.Cells["Título"].Value.ToString();
            diasRetrasoSeleccionados = Convert.ToInt32(fila.Cells["Días Retraso"].Value);
        }

        // Método auxiliar para limpiar la sección de multas
        private void LimpiarDatosMulta()
        {
            idPrestamoSeleccionado = 0;
            diasRetrasoSeleccionados = 0;
            montoMulta = 0;
            tituloLibroSeleccionado = "";

            txtDiasRetraso.Clear();
            txtMonto.Clear();
            txtMotivo.Clear();
        }
        private void CargarEstadosPrestamo()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                MySqlConnection conexion = conexionBD.AbrirConexion();

                // Excluimos "Vencido": solo aplica a préstamos aún no devueltos.
                string consulta = "SELECT id_estado, estado FROM tblestado_prestamo WHERE estado <> 'Vencido';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                DataTable dtEstados = new DataTable();
                adapter.Fill(dtEstados);

                cmbEstadoPrestamo.DataSource = dtEstados;

                // DisplayMember: Lo que el bibliotecario va a leer (ej. "Devuelto")
                cmbEstadoPrestamo.DisplayMember = "estado";

                // ValueMember: El número que el sistema usa por debajo (ej. 2)
                cmbEstadoPrestamo.ValueMember = "id_estado";

                // Preseleccionamos "Devuelto" por defecto; se puede cambiar.
                foreach (DataRow filaEstado in dtEstados.Rows)
                {
                    if (filaEstado["estado"].ToString() == "Devuelto")
                    {
                        cmbEstadoPrestamo.SelectedValue = filaEstado["id_estado"];
                        break;
                    }
                }

                conexionBD.CerrarConexion(conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados de préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (cmbEstadoPrestamo.SelectedValue == null)
            {
                MessageBox.Show("Selecciona el estado del préstamo antes de registrar la devolución.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool procesoAlMenosUno = false;

            // Para saber qué mensaje mostrar al final: si se devolvió libro, si se pagó multa, o ambos.
            bool seDevolvioLibro = false;
            bool sePagoMulta = false;

            clsDevolucion gestion = new clsDevolucion();

            // Fecha real de devolución (por defecto hoy, editable).
            DateTime fechaDevolucionReal = dtpFechaDevolucion.Value.Date;
            int idEstadoSeleccionado = Convert.ToInt32(cmbEstadoPrestamo.SelectedValue);

            // Fecha en que se pagan las multas seleccionadas hoy.
            DateTime fechaPagoSeleccionada = dtpFechaPago.Value.Date;

            // 1) Procesamos los libros que se están devolviendo hoy (dgvPrestamosActivos)
            foreach (DataGridViewRow fila in dgvPrestamosActivos.Rows)
            {
                if (fila.IsNewRow) continue;
                if (fila.Cells["colSeleccionar"].Value == null) continue;
                bool estaPalomeado = Convert.ToBoolean(fila.Cells["colSeleccionar"].Value);

                if (estaPalomeado)
                {
                    procesoAlMenosUno = true;
                    int idPrestamo = Convert.ToInt32(fila.Cells["id_prestamo"].Value);
                    int dias = Convert.ToInt32(fila.Cells["Días Retraso"].Value);
                    string titulo = fila.Cells["Título"].Value.ToString();

                    // 1. Devolvemos el libro, con la fecha y el estado que eligió el bibliotecario
                    bool exitoDevolucion = gestion.DevolverLibro(idPrestamo, fechaDevolucionReal, idEstadoSeleccionado);

                    if (exitoDevolucion)
                    {
                        seDevolvioLibro = true;
                    }

                    // 2. Si tenía retraso, se guarda la multa (nace "Pendiente").
                    if (exitoDevolucion && dias > 0)
                    {
                        // Motivo con el título de este libro (no txtMotivo, que puede mezclar varios).
                        decimal multaIndividual = dias * 10.00m;
                        string motivo = "Retraso en la entrega de: " + titulo;

                        // Si se palomeó "Pagar" en su vista previa, nace como Pagado.
                        bool sePagaAhora = SePagaLaMultaNuevaDeEsePrestamo(idPrestamo);

                        if (sePagaAhora)
                        {
                            sePagoMulta = true;
                        }

                        gestion.GuardarMulta(idPrestamo, multaIndividual, motivo, dias,
                                              sePagaAhora, fechaPagoSeleccionada);
                    }
                }
            }

            // 2) Multas viejas a cobrar; las de vista previa ya se procesaron arriba.
            if (dgvMultasPendientes.DataSource != null)
            {
                foreach (DataGridViewRow fila in dgvMultasPendientes.Rows)
                {
                    if (fila.IsNewRow) continue;
                    if (fila.Cells["colPagarMulta"].Value == null) continue;

                    bool esVistaPreviaDeMultaNueva = fila.Cells["id_prestamo_origen"].Value != null
                        && fila.Cells["id_prestamo_origen"].Value != DBNull.Value;
                    if (esVistaPreviaDeMultaNueva) continue;

                    bool sePaga = Convert.ToBoolean(fila.Cells["colPagarMulta"].Value);
                    if (sePaga)
                    {
                        procesoAlMenosUno = true;
                        sePagoMulta = true;
                        int idMulta = Convert.ToInt32(fila.Cells["id_multa"].Value);
                        gestion.RegistrarPagoMulta(idMulta, fechaPagoSeleccionada);
                    }
                }
            }

            if (!procesoAlMenosUno)
            {
                MessageBox.Show("Selecciona al menos un libro para devolver o una multa pendiente para pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mensaje distinto según lo que en verdad se procesó, para que quede claro qué pasó.
            if (seDevolvioLibro && sePagoMulta)
            {
                MessageBox.Show("El libro se devolvió y la multa se pagó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (seDevolvioLibro)
            {
                MessageBox.Show("El libro se devolvió correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sePagoMulta)
            {
                MessageBox.Show("La multa se pagó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo completar la operación. Intenta de nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Deja el formulario limpio para el siguiente solicitante.
            LimpiarFormularioCompleto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompleto();
        }

        // Regresa el formulario a su estado inicial.
        private void LimpiarFormularioCompleto()
        {
            txtNumControl.Clear();
            LimpiarDatosSolicitante();
            LimpiarDatosMulta();
            dgvPrestamosActivos.DataSource = null;
            dgvMultasPendientes.DataSource = null;
            txtNumControl.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrestamosActivos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Esto fuerza a la tabla a "guardar" el cambio de la palomita de inmediato
            if (dgvPrestamosActivos.IsCurrentCellDirty)
            {
                dgvPrestamosActivos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvPrestamosActivos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrestamosActivos.Columns[e.ColumnIndex].Name == "colSeleccionar")
            {
                // Al palomear un libro, actualiza la vista previa de su multa en dgvMultasPendientes.
                SincronizarMultasNuevasEnGrid();
                RecalcularTotales();
            }
        }

        // Agrega/quita en dgvMultasPendientes la vista previa de la multa de cada libro palomeado con retraso.
        private void SincronizarMultasNuevasEnGrid()
        {
            if (dgvMultasPendientes.DataSource == null) return;

            DataTable dtMultas = (DataTable)dgvMultasPendientes.DataSource;
            if (!dtMultas.Columns.Contains("id_prestamo_origen")) return;

            // 1) Quita vista previa de libros ya no palomeados; las multas viejas no se tocan.
            for (int i = dtMultas.Rows.Count - 1; i >= 0; i--)
            {
                DataRow filaTabla = dtMultas.Rows[i];
                if (filaTabla["id_prestamo_origen"] == DBNull.Value) continue;

                int idPrestamoDeEstaFila = Convert.ToInt32(filaTabla["id_prestamo_origen"]);
                if (!SigueSeleccionadoConRetraso(idPrestamoDeEstaFila))
                {
                    dtMultas.Rows.Remove(filaTabla);
                }
            }

            // 2) Agrega vista previa a los libros palomeados con retraso que aún no la tengan.
            foreach (DataGridViewRow filaPrestamo in dgvPrestamosActivos.Rows)
            {
                if (filaPrestamo.IsNewRow) continue;
                if (filaPrestamo.Cells["colSeleccionar"].Value == null) continue;

                bool estaPalomeado = Convert.ToBoolean(filaPrestamo.Cells["colSeleccionar"].Value);
                int dias = Convert.ToInt32(filaPrestamo.Cells["Días Retraso"].Value);
                if (!estaPalomeado || dias <= 0) continue;

                int idPrestamo = Convert.ToInt32(filaPrestamo.Cells["id_prestamo"].Value);
                if (YaTieneFilaDeMultaNueva(dtMultas, idPrestamo)) continue;

                string titulo = filaPrestamo.Cells["Título"].Value.ToString();
                decimal monto = dias * 10.00m;

                DataRow nuevaFila = dtMultas.NewRow();
                nuevaFila["id_multa"] = DBNull.Value;
                nuevaFila["Título"] = titulo;
                nuevaFila["Motivo"] = "Retraso en la entrega de: " + titulo;
                nuevaFila["Monto"] = monto;
                nuevaFila["Días Atrasados"] = dias;
                nuevaFila["id_prestamo_origen"] = idPrestamo;
                dtMultas.Rows.Add(nuevaFila);
            }
        }

        // ¿El préstamo sigue palomeado y con retraso?
        private bool SigueSeleccionadoConRetraso(int idPrestamo)
        {
            foreach (DataGridViewRow filaPrestamo in dgvPrestamosActivos.Rows)
            {
                if (filaPrestamo.IsNewRow) continue;
                if (filaPrestamo.Cells["colSeleccionar"].Value == null) continue;
                if (Convert.ToInt32(filaPrestamo.Cells["id_prestamo"].Value) != idPrestamo) continue;

                bool estaPalomeado = Convert.ToBoolean(filaPrestamo.Cells["colSeleccionar"].Value);
                int dias = Convert.ToInt32(filaPrestamo.Cells["Días Retraso"].Value);
                return estaPalomeado && dias > 0;
            }
            return false;
        }

        // ¿Ya existe la vista previa de este préstamo?
        private bool YaTieneFilaDeMultaNueva(DataTable dtMultas, int idPrestamo)
        {
            foreach (DataRow fila in dtMultas.Rows)
            {
                if (fila["id_prestamo_origen"] == DBNull.Value) continue;
                if (Convert.ToInt32(fila["id_prestamo_origen"]) == idPrestamo) return true;
            }
            return false;
        }

        // ¿Se palomeó "Pagar" en la vista previa de este préstamo?
        private bool SePagaLaMultaNuevaDeEsePrestamo(int idPrestamo)
        {
            if (dgvMultasPendientes.Columns["id_prestamo_origen"] == null) return false;

            foreach (DataGridViewRow filaMulta in dgvMultasPendientes.Rows)
            {
                if (filaMulta.IsNewRow) continue;
                if (filaMulta.Cells["id_prestamo_origen"].Value == null || filaMulta.Cells["id_prestamo_origen"].Value == DBNull.Value) continue;
                if (Convert.ToInt32(filaMulta.Cells["id_prestamo_origen"].Value) != idPrestamo) continue;

                if (filaMulta.Cells["colPagarMulta"].Value == null || filaMulta.Cells["colPagarMulta"].Value == DBNull.Value) return false;
                return Convert.ToBoolean(filaMulta.Cells["colPagarMulta"].Value);
            }
            return false;
        }

        private void dgvMultasPendientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Mismo truco que en dgvPrestamosActivos: fuerza a "guardar" la palomita de inmediato.
            if (dgvMultasPendientes.IsCurrentCellDirty)
            {
                dgvMultasPendientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvMultasPendientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMultasPendientes.Columns[e.ColumnIndex].Name == "colPagarMulta")
            {
                RecalcularTotales();
            }
        }

        // Llena Días/Motivo/Monto según lo palomeado con "Pagar" en dgvMultasPendientes.
        private void RecalcularTotales()
        {
            int diasTotales = 0;
            string motivos = "";
            decimal montoAPagarHoy = 0;

            if (dgvMultasPendientes.DataSource != null)
            {
                foreach (DataGridViewRow fila in dgvMultasPendientes.Rows)
                {
                    if (fila.IsNewRow) continue;
                    if (fila.Cells["colPagarMulta"].Value == null || fila.Cells["colPagarMulta"].Value == DBNull.Value) continue;
                    bool sePaga = Convert.ToBoolean(fila.Cells["colPagarMulta"].Value);

                    if (sePaga)
                    {
                        if (fila.Cells["Días Atrasados"].Value != null && fila.Cells["Días Atrasados"].Value != DBNull.Value)
                        {
                            diasTotales = diasTotales + Convert.ToInt32(fila.Cells["Días Atrasados"].Value);
                        }

                        if (fila.Cells["Motivo"].Value != null && fila.Cells["Motivo"].Value != DBNull.Value)
                        {
                            motivos = motivos + fila.Cells["Motivo"].Value.ToString() + "; ";
                        }

                        if (fila.Cells["Monto"].Value != null && fila.Cells["Monto"].Value != DBNull.Value)
                        {
                            montoAPagarHoy = montoAPagarHoy + Convert.ToDecimal(fila.Cells["Monto"].Value);
                        }
                    }
                }
            }

            montoTotalMulta = montoAPagarHoy;

            if (diasTotales > 0)
            {
                txtDiasRetraso.Text = diasTotales.ToString();
                txtMotivo.Text = motivos.TrimEnd(';', ' ');
            }
            else
            {
                txtDiasRetraso.Clear();
                txtMotivo.Clear();
            }

            if (montoTotalMulta > 0)
            {
                txtMonto.Text = "$" + montoTotalMulta.ToString("0.00");
            }
            else
            {
                txtMonto.Clear();
            }
        }
    }
}
