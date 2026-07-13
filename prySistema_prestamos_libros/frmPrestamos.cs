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
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            txtTipoSolicitante.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtCarrera.Enabled = false;
        }
    }
}
