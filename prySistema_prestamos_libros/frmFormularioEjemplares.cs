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
        public frmFormularioEjemplares()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var campos = new List<(Control control, string nombre)>
            {
                (cmbLibro, "Libro al que pertenece"),
                (txtLocalizacion, "Localización"),
                (nudCantidad, "Cantidad"),
                (cmbEstado, "Estado"),
            };

            if (!clsValidaciones.ValidarCamposVacios(campos, out string mensaje))
            {
                clsValidaciones.MostrarError(mensaje);
                return;
            }

            // TODO: guardar el ejemplar en la base de datos.
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case ComboBox cmb:
                        cmb.SelectedIndex = -1;
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
