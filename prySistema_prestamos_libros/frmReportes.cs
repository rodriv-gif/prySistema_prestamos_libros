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
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            reportes = new clsReportes();
            tabla = new DataTable();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                if (rdbOpcion1.Checked == true)
                {
                    //llamar la consulta para cargar el grid
                    tabla = reportes.CategoriasMasSolicitadasMes();
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
                    tabla = reportes.LibrosPrestadosEnSemana();
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

                reportes.ExportarPDF(tabla, "Reporte de las categorias que son más solicitadas al mes", "Categorias solicitadas al mes.pdf");
            }
            else if (rdbOpcion2.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de los prestamos vencidos", "Prestamos vencidos.pdf");
            }
            else if (rdbOpcion3.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de los libros que se han prestado durante la semana", "Libros prestados por semana.pdf");
            }
        }
    }
}
