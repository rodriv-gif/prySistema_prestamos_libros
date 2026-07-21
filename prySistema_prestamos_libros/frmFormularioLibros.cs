using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmFormularioLibros : Form
    {
        // Control
        private bool modoEdicion = false;
        private int idLibroOriginal = 0;

        public frmFormularioLibros()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarGridAlmacen();
        }
        public frmFormularioLibros(DataGridViewRow filaSeleccionada) : this()
        {
            CargarDatosParaEditar(filaSeleccionada);

        }


        //Selecciona para agregar autores
        private void dgvAutor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Este alamacena datos de autores
        private void dgvAlmacenarAutor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //pertenece cerca del dvgAlamcenar autor

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        //Pertenece en el contenedor datos de autor 
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {

        }

        //Estos pertenecen a la parte inferior de hasta abajo
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarAutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
