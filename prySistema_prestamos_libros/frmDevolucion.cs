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
                    dgvPrestamosActivos.DataSource = dtPrestamos;
                }
                else
                {
                    // Validación: Si no lo encuentra y ya escribió 8 o más números
                    // (para no mandar el error apenas escriba el primer dígito)
                    if (texto.Length >= 8)
                    {
                        LimpiarDatosSolicitante();
                        dgvPrestamosActivos.DataSource = null;
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
            if (dgvPrestamosActivos.CurrentRow == null)
            {
                // Lo dejamos vacío porque CalcularMultaGlobal() 
                // y los CheckBox ahora hacen todo el trabajo de las multas.
            }

            DataGridViewRow fila = dgvPrestamosActivos.CurrentRow;

            // Guardamos los datos de la fila seleccionada usando los nombres de columnas de tu consulta
            idPrestamoSeleccionado = Convert.ToInt32(fila.Cells["id_prestamo"].Value);
            tituloLibroSeleccionado = fila.Cells["Título"].Value.ToString();
            diasRetrasoSeleccionados = Convert.ToInt32(fila.Cells["Días Retraso"].Value);

            // Si hay días de retraso, calculamos la multa
            if (diasRetrasoSeleccionados > 0)
            {
                // Supongamos que cobran 10 pesos por día de retraso (puedes cambiar este número)
                decimal costoPorDia = 10.00m;
                montoMulta = diasRetrasoSeleccionados * costoPorDia;

                // Llenamos las cajas de texto de la sección "Multa generada"
                txtLibrosVencidos.Text = tituloLibroSeleccionado;
                txtDiasRetraso.Text = diasRetrasoSeleccionados.ToString();
                txtMonto.Text = "$" + montoMulta.ToString("0.00");
            }
            else
            {
                // Si no hay retraso, limpiamos la sección de multas
                LimpiarDatosMulta();
            }
        }

        // Método auxiliar para limpiar la sección de multas
        private void LimpiarDatosMulta()
        {
            idPrestamoSeleccionado = 0;
            diasRetrasoSeleccionados = 0;
            montoMulta = 0;
            tituloLibroSeleccionado = "";

            txtLibrosVencidos.Clear();
            txtDiasRetraso.Clear();
            txtMonto.Clear();
        }
        private void CargarEstadosPrestamo()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                MySqlConnection conexion = conexionBD.AbrirConexion();

                // Buscamos el ID y el nombre del estado en tu base de datos
                string consulta = "SELECT id_estado, estado FROM tblestado_prestamo;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                DataTable dtEstados = new DataTable();
                adapter.Fill(dtEstados);

                cmbEstadoPrestamo.DataSource = dtEstados;

                // DisplayMember: Lo que el bibliotecario va a leer (ej. "Devuelto")
                cmbEstadoPrestamo.DisplayMember = "estado";

                // ValueMember: El número que el sistema usa por debajo (ej. 2)
                cmbEstadoPrestamo.ValueMember = "id_estado";

                conexionBD.CerrarConexion(conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados de préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            bool procesoAlMenosUno = false;
            clsDevolucion gestion = new clsDevolucion();

            // Extraemos la fecha de tu calendario (asegúrate de que se llame dtpFechaPago)
            string fechaSeleccionada = dtpFechaPago.Value.ToString("yyyy-MM-dd");

            // Recorremos la tabla otra vez para guardar los que tengan palomita
            foreach (DataGridViewRow fila in dgvPrestamosActivos.Rows)
            {
                bool estaPalomeado = Convert.ToBoolean(fila.Cells["Seleccionar"].Value);

                if (estaPalomeado)
                {
                    procesoAlMenosUno = true;
                    int idPrestamo = Convert.ToInt32(fila.Cells["id_prestamo"].Value);
                    int dias = Convert.ToInt32(fila.Cells["Días Retraso"].Value);
                    string titulo = fila.Cells["Título"].Value.ToString();

                    // 1. Devolvemos el libro
                    bool exitoDevolucion = gestion.DevolverLibro(idPrestamo);

                    // 2. Si tenía retraso y se devolvió bien, guardamos su multa
                    if (exitoDevolucion && dias > 0)
                    {
                        decimal multaIndividual = dias * 10.00m;
                        string motivo = "Retraso en la entrega de: " + titulo;

                        // Aquí ya le mandamos la fecha que elegiste en el calendario
                        gestion.GuardarMulta(idPrestamo, multaIndividual, motivo, dias, fechaSeleccionada);
                    }
                }
            }

            if (!procesoAlMenosUno)
            {
                MessageBox.Show("Por favor, ponle palomita (selecciona) al menos a un libro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Devolución procesada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volvemos a simular la búsqueda para que la tabla se actualice y desaparezcan los devueltos
            txtNumControl_TextChanged(null, null);

            // Limpiamos las cajas de texto de multas
            txtLibrosVencidos.Clear();
            txtDiasRetraso.Clear();
            txtMonto.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtNumControl.Clear();
            LimpiarDatosSolicitante();
            LimpiarDatosMulta();
            dgvPrestamosActivos.DataSource = null;
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
            if (e.RowIndex >= 0 && dgvPrestamosActivos.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                CalcularMultaGlobal(); // Llamamos al método que suma todo
            }
        }
        private void CalcularMultaGlobal()
        {
            montoTotalMulta = 0;
            int diasRetrasoAcumulados = 0;
            librosVencidosGlobal = "";
            decimal costoPorDia = 10.00m; 

            // Recorremos todas las filas de la tabla
            foreach (DataGridViewRow fila in dgvPrestamosActivos.Rows)
            {
                // Leemos si el CheckBox está palomeado
                bool estaPalomeado = Convert.ToBoolean(fila.Cells["Seleccionar"].Value);

                if (estaPalomeado)
                {
                    int dias = Convert.ToInt32(fila.Cells["Días Retraso"].Value);

                    // Solo sumamos si el libro tiene retraso
                    if (dias > 0)
                    {
                        string titulo = fila.Cells["Título"].Value.ToString();

                        librosVencidosGlobal = librosVencidosGlobal + titulo + ", "; // Juntamos los nombres
                        montoTotalMulta = montoTotalMulta + (dias * costoPorDia); // Sumamos el dinero
                        diasRetrasoAcumulados = diasRetrasoAcumulados + dias; // Sumamos los días
                    }
                }
            }

            // Si detectó libros vencidos, llenamos las cajitas
            if (montoTotalMulta > 0)
            {
                // Quitamos la última coma sobrante del texto
                txtLibrosVencidos.Text = librosVencidosGlobal.TrimEnd(',', ' ');
                txtDiasRetraso.Text = diasRetrasoAcumulados.ToString();
                txtMonto.Text = "$" + montoTotalMulta.ToString("0.00");
            }
            else
            {
                // Si palomeó libros que están a tiempo, dejamos la multa limpia
                txtLibrosVencidos.Clear();
                txtDiasRetraso.Clear();
                txtMonto.Clear();
            }
        }
    }
}
