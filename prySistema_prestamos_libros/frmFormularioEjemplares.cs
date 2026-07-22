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

        public frmFormularioEjemplares()
        {
            InitializeComponent();
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

            txtLibroPerteneciete.Text = fila.Cells["ISBN"].Value?.ToString();
            txtLocalizacion.Text = fila.Cells["Localización"].Value?.ToString();

            string fechaTexto = Convert.ToString(fila.Cells["Fecha de adquisición"].Value);
            if (!string.IsNullOrEmpty(fechaTexto))
                dtpFechaAdquisicion.Value = Convert.ToDateTime(fechaTexto);

            // "Cantidad" solo aplica cuando se capturan varios ejemplares nuevos de golpe;
            // al editar uno que ya existe no tiene sentido, así que se deshabilita.
            nudCantidad.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
