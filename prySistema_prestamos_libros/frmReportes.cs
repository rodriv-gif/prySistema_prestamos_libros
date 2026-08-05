using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmReportes : Form
    {
        clsReportes reportes;
        DataTable tabla;
        public frmReportes()
        {
            InitializeComponent();
            // Llamamos a este método para que al abrir la ventana, 
            // las fechas se oculten o muestren correctamente desde el segundo cero.
            ConfigurarVisibilidadFechas();

            // Es solo para mostrar resultados; no se debe poder agregar filas escribiendo directo en el grid.
            dgvReportes.AllowUserToAddRows = false;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            reportes = new clsReportes();
            tabla = new DataTable();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReportes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            try
            {
                if (rdbOpcion1.Checked == true)
                {
                    DateTime fechaInicio = dtpFechaInicio.Value.Date;
                    DateTime fechaFin = dtpFechaFin.Value.Date;

                    // Validación sencilla para evitar errores lógicos
                    if (fechaInicio > fechaFin)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    tabla = reportes.LibrosMasSolicitadosPorMes(fechaInicio, fechaFin);
                    dgvReportes.DataSource = tabla;

                }
                else if (rdbOpcion2.Checked == true)
                {
                    //llamar la consulta para cargar el grid
                    tabla = reportes.ConsultarLibrosVencidos();
                    dgvReportes.DataSource = tabla;
                }
                else if (rdbOpcion3.Checked == true)
                {
                    //llamar la consulta para cargar el grid
                    DateTime fechaInicio = dtpFechaInicio.Value.Date;
                    DateTime fechaFin = dtpFechaFin.Value.Date;

                    // Validación para que no pongan una fecha de inicio mayor a la de fin
                    if (fechaInicio > fechaFin)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Pasamos las fechas al método
                    tabla = reportes.LibrosPrestadosEnSemana(fechaInicio, fechaFin);
                    dgvReportes.DataSource = tabla;
                }
                else if (rdbOpcion4.Checked == true)
                {
                    tabla = reportes.DisponibilidadTotalLibros();
                    dgvReportes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            reportes = new clsReportes();
            if (rdbOpcion1.Checked == true)
            {

                reportes.ExportarPDF(tabla, "Reporte de los libros que son más solicitados al mes", "Libros solicitados al mes.pdf");
            }
            else if (rdbOpcion2.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de los prestamos vencidos", "Prestamos vencidos.pdf");
            }
            else if (rdbOpcion3.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de los libros que se han prestado durante la semana", "Libros prestados por semana.pdf");
            }
            else if (rdbOpcion4.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte del total de libros y la disponibilidad", "Total libros y disponibilidad.pdf");
            }
        }
        private void ConfigurarVisibilidadFechas()
        {
            // Verificamos si la opción 2 (Mes) o la opción 4 (Semana) están seleccionadas
            if (rdbOpcion1.Checked == true || rdbOpcion3.Checked == true)
            {
                // Si alguna de esas dos está marcada, hacemos visibles (true) los controles
                dtpFechaInicio.Visible = true;
                dtpFechaFin.Visible = true;
                lblInicio.Visible = true;
                lblFin.Visible = true;
            }
            else
            {
                // Si seleccionó la opción 1 o 3, ocultamos (false) los controles
                dtpFechaInicio.Visible = false;
                dtpFechaFin.Visible = false;
                lblInicio.Visible = false;
                lblFin.Visible = false;
            }
        }
       
        private void rdbOpcion1_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarVisibilidadFechas();
        }

        private void rdbOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarVisibilidadFechas();
        }

        private void rdbOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarVisibilidadFechas();
        }

        private void rdbOpcion4_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarVisibilidadFechas();
        }
    }
}
