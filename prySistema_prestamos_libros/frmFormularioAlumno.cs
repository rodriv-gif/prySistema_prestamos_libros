using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmFormularioAlumno : Form
    {
        public frmFormularioAlumno()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clsAlumnos nuevoAlumno = new clsAlumnos();

                //Llenar las cajas de texto
                nuevoAlumno.Matricula = txtMatricula.Text;
                nuevoAlumno.Nombre = txtNombres.Text;
                nuevoAlumno.ApellidoPaterno = txtApellidoPaterno.Text;
                nuevoAlumno.ApellidoMaterno = txtApellidoMaterno.Text;
                nuevoAlumno.Calle = txtCalle.Text;
                nuevoAlumno.Colonia = txtColonia.Text;
                nuevoAlumno.CodigoPostal = txtCodigoPostal.Text;
                nuevoAlumno.Correo = txtCorreo.Text;
                nuevoAlumno.Telefono = txtTelefono.Text;
                nuevoAlumno.Grado = int.Parse(txtGrado.Text);
                nuevoAlumno.Grupo = txtGrupo.Text;

                //Para atrapar el id de la carrera al momento de que se seleccione la carrera en el combo
                nuevoAlumno.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);

                //Se guarda los registros en la base de datos
                string msg = nuevoAlumno.Registrar();
                //Mostramos un mensaje del registro
                MessageBox.Show(msg, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Mensaje por si falla el registro
                MessageBox.Show("No se pudo registrar al alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar todas las cajas de texto
            txtMatricula.Clear();
            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCalle.Clear();
            txtColonia.Clear();
            txtCodigoPostal.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtGrado.Clear();
            txtGrupo.Clear();

            //Para regresar el combobox a la opcion inicial que es seleccione una carrera
            if (cmbCarrera.Items.Count > 0)
            {
                cmbCarrera.SelectedIndex = 0;
            }
            //Para poner el cursor en la caja de matricula
            txtMatricula.Focus();
        }

        //evento para cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombos()
        {
            clsAlumnos alumnos = new clsAlumnos();
            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();

                // Creamos una fila falsa para que sea el mensaje de instrucción
                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["id_carrera"] = 0;
                filaPCarrera["nombre_carrera"] = "-- Seleccione una carrera --";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0);

                // Conectamos la tabla de SQL con el control visual
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMember = "nombre_carrera"; // Lo que el usuario lee
                cmbCarrera.ValueMember = "id_carrera";       // El ID oculto que se guarda en la BD
                cmbCarrera.SelectedIndex = 0;                // Forzamos a mostrar el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las carreras: " + ex.Message);
            }
        }
    }
}
