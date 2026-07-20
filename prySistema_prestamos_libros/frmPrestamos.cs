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

        // Al teclear el número de control / matrícula, se busca primero en Alumnos y,
        // si no aparece ahí, se busca en Trabajadores. El bibliotecario nunca elige el
        // tipo a mano, se llena solo según en cuál tabla se encontró.
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
    }
}
