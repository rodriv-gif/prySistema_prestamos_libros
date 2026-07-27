using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
        // Controla si el formulario está registrando uno nuevo o editando uno existente,
        // para que btnGuardar sepa si debe hacer INSERT o UPDATE.
        private bool modoEdicion = false;
        private int matriculaOriginal = 0;
        private int idDireccionOriginal = 0;

        // Constructor para modo edición: recibe la fila seleccionada en el DataGridView
        // de frmGestionAlumnos y llena los campos con esos datos.
        public frmFormularioAlumno(DataGridViewRow filaSeleccionada) : this()
        {
            CargarDatosParaEditar(filaSeleccionada);
        }

        private void CargarDatosParaEditar(DataGridViewRow fila)
        {
            modoEdicion = true;
            matriculaOriginal = Convert.ToInt32(fila.Cells["Matricula"].Value);
            idDireccionOriginal = Convert.ToInt32(fila.Cells["id_direccion"].Value);

            txtMatricula.Text = fila.Cells["Matricula"].Value?.ToString();
            txtNombres.Text = fila.Cells["Nombre"].Value?.ToString();
            txtApellidoPaterno.Text = fila.Cells["Apellido Paterno"].Value?.ToString();
            txtApellidoMaterno.Text = fila.Cells["Apellido Materno"].Value?.ToString();
            txtCorreo.Text = fila.Cells["Correo electrónico"].Value?.ToString();
            txtTelefono.Text = fila.Cells["Teléfono"].Value?.ToString();
            txtCalle.Text = fila.Cells["Calle"].Value?.ToString();
            txtGrado.Text = fila.Cells["Grado"].Value?.ToString();
            txtGrupo.Text = fila.Cells["Grupo"].Value?.ToString();

            // Convert.ToString regresa "" si el valor es null en vez de tronar,
            string fechaTexto = Convert.ToString(fila.Cells["Fecha de Registro"].Value);
            if (!string.IsNullOrEmpty(fechaTexto))
                dtpFechaRegistro.Value = Convert.ToDateTime(fechaTexto);

            //Asignamos el código postal (Esto intentará disparar el evento automáticamente)
            string cp = fila.Cells["Código Postal"].Value?.ToString();
            txtCodigoPostal.Text = cp;

            // Si el evento automático fue bloqueado por la carga del formulario y el DataSource sigue vacío,forzamos a la clase dirección a traer las colonias en este instante.
            if (cmbColonia.DataSource == null && !string.IsNullOrEmpty(cp) && cp.Trim().Length == 5)
            {
                clsDireccion direccion = new clsDireccion();
                txtMunicipio.Text = direccion.ObtenerMunicipioPorCP(cp.Trim());
                cmbColonia.DataSource = direccion.ObtenerColoniasPorCP(cp.Trim());
                cmbColonia.DisplayMember = "nombre_colonia";
                cmbColonia.ValueMember = "id_colonia";
            }

            // Ya con cmbColonia llena la línea de arriba lo carga de forma síncrona(osea enviar datos en bloques,se selecciona la colonia que ya tenía el alumno.
            string idColonia = fila.Cells["id_colonia"].Value?.ToString();
            if (!string.IsNullOrEmpty(idColonia))
                cmbColonia.SelectedValue = Convert.ToInt32(idColonia);

            // Igual con la carrera/área ya cargada en CargarCombos().
            string idCarrera = fila.Cells["id_carrera"].Value?.ToString();
            if (!string.IsNullOrEmpty(idCarrera))
                cmbCarrera.SelectedValue = Convert.ToInt32(idCarrera);
        }
        // Solo dígitos (matrícula, teléfono, código postal, grado). Se usa en varios campos porque ninguno de ellos acepta letras ni símbolos.
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // permite backspace

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Solo letras y espacio (nombre, apellidos). char.IsLetter ya incluye acentos y Ñ.
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        // La calle sí necesita números y algunos símbolos de dirección (# . , -), además
        // de letras y espacio, por eso tiene su propio filtro en vez de reusar los de arriba.
        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            bool permitido = char.IsLetterOrDigit(e.KeyChar) || " #.,-".IndexOf(e.KeyChar) >= 0;
            if (!permitido)
                e.Handled = true;
        }

        // El grupo puede ser "A", "301", "3A", etc., por eso acepta letras y números pero
        // no espacios ni símbolos.
        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        // Revisa que cada campo tenga el tipo de dato y el largo correcto antes de mandarlo
        // a la base de datos. Si algo falla, regresa false y ya deja el mensaje mostrado.
        private bool ValidarCampos()
        {
            if (txtMatricula.Text.Trim().Length != 7)
            {
                MessageBox.Show("La matrícula debe tener exactamente 7 dígitos.", "Matrícula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show("Captura el nombre (solo letras).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MessageBox.Show("Captura el apellido paterno (solo letras).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoPaterno.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
            {
                MessageBox.Show("Captura el apellido materno (solo letras).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoMaterno.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                !Regex.IsMatch(txtCorreo.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido. Debe ser algo como ejemplo@dominio.com.",
                    "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (txtTelefono.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 dígitos.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                MessageBox.Show("Captura la calle.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalle.Focus();
                return false;
            }

            if (txtCodigoPostal.Text.Trim().Length != 5)
            {
                MessageBox.Show("El código postal debe tener exactamente 5 dígitos.", "Código postal inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoPostal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGrado.Text))
            {
                MessageBox.Show("Captura el grado (solo números).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGrupo.Text))
            {
                MessageBox.Show("Captura el grupo.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrupo.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                clsAlumnos nuevoAlumno = new clsAlumnos();

                //Llenar las cajas de texto
                nuevoAlumno.Matricula = Convert.ToInt32(txtMatricula.Text);
                nuevoAlumno.Nombre = txtNombres.Text;
                nuevoAlumno.ApellidoPaterno = txtApellidoPaterno.Text;
                nuevoAlumno.ApellidoMaterno = txtApellidoMaterno.Text;
                nuevoAlumno.Correo = txtCorreo.Text;
                nuevoAlumno.Telefono = txtTelefono.Text;
                nuevoAlumno.Grado = Convert.ToInt32(txtGrado.Text);
                nuevoAlumno.Grupo = txtGrupo.Text;
                nuevoAlumno.FechaRegistro = dtpFechaRegistro.Value;
                nuevoAlumno.Estado = "Activo";

                // Dirección, la colonia se elige en el combo ya filtrado por el código postal
                nuevoAlumno.Calle = txtCalle.Text;
                nuevoAlumno.CodigoPostal = txtCodigoPostal.Text;
                nuevoAlumno.IdColonia = Convert.ToInt32(cmbColonia.SelectedValue);
                //Para atrapar el id de la carrera al momento de que se seleccione la carrera en el combo
                nuevoAlumno.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                // Si el formulario se abrió desde Editar, se actualiza el registro existente; si se abrió desde Nuevo, se inserta uno nuevo.
                string msg;
                if (modoEdicion)
                    msg = nuevoAlumno.ActualizarAlumno(idDireccionOriginal, matriculaOriginal);
                else
                    msg = nuevoAlumno.RegistrarAlumno();
                MessageBox.Show(msg, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                //Mensaje por si falla el registro
                MessageBox.Show("No se pudo registrar el alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar todas las cajas de texto
            txtMatricula.Clear();
            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCodigoPostal.Clear();
            txtMunicipio.Clear();
            txtCalle.Clear();
            txtGrado.Clear();
            txtGrupo.Clear();
            cmbColonia.DataSource = null;

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

        // Cuando el bibliotecario o administador termina de teclear el código postal (5 dígitos),
        // se busca el municipio y se cargan las colonias que le correspondan.
        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            string cp = txtCodigoPostal.Text.Trim();

            if (cp.Length != 5)
            {
                txtMunicipio.Clear();
                cmbColonia.DataSource = null;
                return;
            }

            clsDireccion direccion = new clsDireccion();
            try
            {
                txtMunicipio.Text = direccion.ObtenerMunicipioPorCP(cp);

                DataTable dtColonias = direccion.ObtenerColoniasPorCP(cp);
                if (dtColonias.Rows.Count == 0)
                {
                    cmbColonia.DataSource = null;
                    MessageBox.Show("No se encontraron colonias para ese código postal.");
                    return;
                }

                cmbColonia.DataSource = dtColonias;
                cmbColonia.DisplayMember = "nombre_colonia";
                cmbColonia.ValueMember = "id_colonia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el código postal: " + ex.Message);
            }
        }
    }
}
