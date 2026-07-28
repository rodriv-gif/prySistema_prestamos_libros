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

                    // id_prestamo es solo para uso interno del programa (saber qué préstamo
                    // actualizar); no le sirve de nada verlo al bibliotecario.
                    if (dgvPrestamosActivos.Columns["id_prestamo"] != null)
                    {
                        dgvPrestamosActivos.Columns["id_prestamo"].Visible = false;
                    }

                    // Además, traemos las multas de visitas anteriores que sigue debiendo
                    // (no tienen relación con los libros que se están devolviendo ahorita).
                    DataTable dtMultasPendientes = devolucion.ObtenerMultasPendientes(idBuscado);

                    // Columna oculta para diferenciar las multas VIEJAS (ya existen en la BD)
                    // de las filas de "vista previa" que agregamos nosotros mismos más abajo,
                    // para la multa NUEVA que se generaría al devolver un libro con retraso.
                    // En las viejas se queda en NULL; en las de vista previa guarda el
                    // id_prestamo al que pertenecen, para saber a cuál libro corresponde.
                    if (!dtMultasPendientes.Columns.Contains("id_prestamo_origen"))
                    {
                        dtMultasPendientes.Columns.Add("id_prestamo_origen", typeof(int)).AllowDBNull = true;
                    }

                    dgvMultasPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMultasPendientes.DataSource = dtMultasPendientes;
                    // Evita el renglón en blanco al final del grid: como es de solo
                    // lectura + checkbox, no tiene sentido "agregar" una multa a mano ahí.
                    dgvMultasPendientes.AllowUserToAddRows = false;

                    // id_prestamo_origen e id_multa son solo identificadores internos que
                    // usa el programa para saber qué renglón actualizar en la base de datos;
                    // no le sirven de nada al bibliotecario verlos en pantalla.
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
                    // Validación: Si no lo encuentra y ya escribió 8 o más números
                    // (para no mandar el error apenas escriba el primer dígito)
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

            // Guardamos los datos de la fila seleccionada usando los nombres de columnas de tu consulta.
            // El monto/días/motivo que se ven en pantalla ya no dependen de cuál fila esté
            // seleccionada aquí, sino de cuáles tengan la palomita puesta (RecalcularTotales()).
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

                // Buscamos el ID y el nombre del estado en tu base de datos. Excluimos
                // "Vencido": ese estado solo describe un préstamo que TODAVÍA no se ha
                // devuelto y ya se pasó de su fecha límite; en cuanto el bibliotecario está
                // parado aquí registrando la devolución, el libro ya está regresando, así
                // que no tiene caso poder dejarlo marcado como vencido.
                string consulta = "SELECT id_estado, estado FROM tblestado_prestamo WHERE estado <> 'Vencido';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                DataTable dtEstados = new DataTable();
                adapter.Fill(dtEstados);

                cmbEstadoPrestamo.DataSource = dtEstados;

                // DisplayMember: Lo que el bibliotecario va a leer (ej. "Devuelto")
                cmbEstadoPrestamo.DisplayMember = "estado";

                // ValueMember: El número que el sistema usa por debajo (ej. 2)
                cmbEstadoPrestamo.ValueMember = "id_estado";

                // Preseleccionamos "Devuelto" como valor por defecto (lo más común al
                // registrar una devolución), pero el bibliotecario lo puede cambiar si
                // el catálogo tiene otro estado más adecuado para ese caso.
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
            clsDevolucion gestion = new clsDevolucion();

            // Fecha real de devolución elegida en el calendario (por defecto es hoy,
            // pero el bibliotecario puede cambiarla si captura una devolución tardía).
            DateTime fechaDevolucionReal = dtpFechaDevolucion.Value.Date;
            int idEstadoSeleccionado = Convert.ToInt32(cmbEstadoPrestamo.SelectedValue);

            // Fecha en la que se están pagando las multas viejas seleccionadas hoy.
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

                    // 2. Si tenía retraso y se devolvió bien, guardamos su multa (nace "Pendiente";
                    // que el libro se devuelva hoy no significa que la multa ya se haya pagado).
                    if (exitoDevolucion && dias > 0)
                    {
                        // El motivo se arma siempre con el título de ESTE libro; no se usa
                        // txtMotivo aquí porque esa caja es solo un resumen en pantalla y
                        // puede mezclar el texto de varios libros si hay más de uno con
                        // retraso (se vería mal que a un libro se le guarde el motivo de otro).
                        decimal multaIndividual = dias * 10.00m;
                        string motivo = "Retraso en la entrega de: " + titulo;

                        // Si el bibliotecario palomeó "Pagar" en la fila de vista previa de
                        // esta multa (en dgvMultasPendientes, sección de multas), nace
                        // directamente como Pagado con la fecha de dtpFechaPago.
                        bool sePagaAhora = SePagaLaMultaNuevaDeEsePrestamo(idPrestamo);

                        gestion.GuardarMulta(idPrestamo, multaIndividual, motivo, dias,
                                              sePagaAhora, fechaPagoSeleccionada);
                    }
                }
            }

            // 2) Procesamos las multas VIEJAS que el bibliotecario decidió cobrar ahorita
            // (las filas de vista previa de multas NUEVAS ya se procesaron arriba, junto
            // con la devolución del libro, así que aquí las saltamos).
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

            MessageBox.Show("Devolución procesada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Dejamos el formulario completamente limpio y listo para el siguiente
            // solicitante (antes se quedaban el nombre y los demás datos en pantalla).
            LimpiarFormularioCompleto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompleto();
        }

        // Regresa el formulario a su estado inicial: borra la búsqueda, los datos del
        // solicitante, la sección de multas y quita ambos grids.
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
                // Al palomear/despalomear un libro, actualizamos la vista previa de su
                // multa nueva en la sección de multas (dgvMultasPendientes), que es donde
                // se decide si se paga ahorita o se queda pendiente.
                SincronizarMultasNuevasEnGrid();
                RecalcularTotales();
            }
        }

        // Refleja en dgvMultasPendientes una fila por cada libro palomeado en
        // dgvPrestamosActivos que tenga retraso, simulando la multa que se va a crear
        // apenas se le dé clic a "Registrar". Así el bibliotecario puede decidir en la
        // MISMA sección de multas si esa multa nueva se paga ahora o queda pendiente,
        // igual que ya decide con las multas viejas.
        private void SincronizarMultasNuevasEnGrid()
        {
            if (dgvMultasPendientes.DataSource == null) return;

            DataTable dtMultas = (DataTable)dgvMultasPendientes.DataSource;
            if (!dtMultas.Columns.Contains("id_prestamo_origen")) return;

            // 1) Quitamos las filas de vista previa cuyo libro ya no está palomeado o ya
            // no tiene retraso, para que no quede una multa "fantasma" en la lista.
            // Las filas de multas VIEJAS (id_prestamo_origen en NULL) nunca se tocan aquí.
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

            // 2) Agregamos una fila de vista previa por cada libro palomeado con retraso
            // que todavía no la tenga (si ya la tiene, la dejamos como está, para no
            // perder si el bibliotecario ya había palomeado "Pagar" en esa fila).
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

        // Revisa si el libro de este id_prestamo sigue palomeado y con retraso en
        // dgvPrestamosActivos (es decir, si todavía le corresponde una multa nueva).
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

        // Revisa si ya existe una fila de vista previa en dtMultas para ese préstamo.
        private bool YaTieneFilaDeMultaNueva(DataTable dtMultas, int idPrestamo)
        {
            foreach (DataRow fila in dtMultas.Rows)
            {
                if (fila["id_prestamo_origen"] == DBNull.Value) continue;
                if (Convert.ToInt32(fila["id_prestamo_origen"]) == idPrestamo) return true;
            }
            return false;
        }

        // Revisa en dgvMultasPendientes si el bibliotecario palomeó "Pagar" en la fila de
        // vista previa de la multa nueva que le corresponde a este préstamo.
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

        // Actualiza la sección "Multa generada" en base a lo que esté palomeado con
        // "Pagar" en dgvMultasPendientes (ahí están tanto las multas VIEJAS como la
        // vista previa de las NUEVAS que se van a generar hoy). Así, si el solicitante
        // ya había devuelto el libro y solo viene a pagar una multa vieja, en cuanto la
        // palomea se llenan Días de retraso y Motivo con los datos de ESA multa.
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
