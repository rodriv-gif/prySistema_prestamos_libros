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
    public partial class frmFormularioTrabajador : Form
    {
        public frmFormularioTrabajador()
        {
            InitializeComponent();
            CargarCombos();
        }

        // Controla si el formulario está registrando uno nuevo o editando uno existente,
        // para que btnGuardar sepa si debe hacer INSERT o UPDATE.
        private bool modoEdicion = false;
        private int numeroControlOriginal = 0;
        private int idDireccionOriginal = 0;

        // Constructor para modo edición: recibe la fila seleccionada en el DataGridView
        // de frmGestionTrabajadores y llena los campos con esos datos.
        public frmFormularioTrabajador(DataGridViewRow filaSeleccionada) : this()
        {
            CargarDatosParaEditar(filaSeleccionada);
        }

        private void CargarDatosParaEditar(DataGridViewRow fila)
        {
            modoEdicion = true;
            numeroControlOriginal = Convert.ToInt32(fila.Cells["Número de Control"].Value);
            idDireccionOriginal = Convert.ToInt32(fila.Cells["id_direccion"].Value);

            txtNumeroControl.Text = fila.Cells["Número de Control"].Value?.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtApellidoPaterno.Text = fila.Cells["Apellido Paterno"].Value?.ToString();
            txtApellidoMaterno.Text = fila.Cells["Apellido Materno"].Value?.ToString();
            txtCorreo.Text = fila.Cells["Correo electrónico"].Value?.ToString();
            txtTelefono.Text = fila.Cells["Teléfono"].Value?.ToString();
            txtCalle.Text = fila.Cells["Calle"].Value?.ToString();

            // Convert.ToString regresa "" si el valor es null en vez de tronar,
            string fechaTexto = Convert.ToString(fila.Cells["Fecha de Registro"].Value);
            if (!string.IsNullOrEmpty(fechaTexto))
                dtpFechaRegistro.Value = Convert.ToDateTime(fechaTexto);

            // Al asignar el texto del código postal se dispara txtCodigoPostal_TextChanged,
            // que carga Municipio y llena cmbColonia con las colonias de ese CP.
            txtCodigoPostal.Text = fila.Cells["Código Postal"].Value?.ToString();

            // Ya con cmbColonia llena la línea de arriba lo carga de forma síncrona(osea enviar datos en bloques,se selecciona la colonia que ya tenía el trabajador.
            string idColonia = fila.Cells["id_colonia"].Value?.ToString();
            if (!string.IsNullOrEmpty(idColonia))
                cmbColonia.SelectedValue = Convert.ToInt32(idColonia);

            // Igual con la carrera/área ya cargada en CargarCombos().
            string idCarrera = fila.Cells["id_carrera"].Value?.ToString();
            if (!string.IsNullOrEmpty(idCarrera))
                cmbCarreraArea.SelectedValue = Convert.ToInt32(idCarrera);
        }

        // Solo dígitos (numero de control, teléfono, código postal). Se usa en los tres campos porque ninguno de ellos acepta letras ni símbolos.
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

        // La calle sí necesita números y algunos símbolos de dirección (# . , -), además de letras y espacio, por eso tiene su propio filtro en vez de reusar los de arriba.
        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            bool permitido = char.IsLetterOrDigit(e.KeyChar) || " #.,-".IndexOf(e.KeyChar) >= 0;
            if (!permitido)
                e.Handled = true;
        }

        // Revisa que cada campo tenga el tipo de dato y el largo correcto antes de mandarlo
        // a la base de datos. Si algo falla, regresa false y ya deja el mensaje mostrado.
        private bool ValidarCampos()
        {
            if (txtNumeroControl.Text.Trim().Length != 6)
            {
                MessageBox.Show("El número de control debe tener exactamente 6 dígitos.", "Número de control inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroControl.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Captura el nombre (solo letras).", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
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

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                clsTrabajador nuevoTrabajador = new clsTrabajador();

                // Datos personales del trabajador
                nuevoTrabajador.NumeroControl = Convert.ToInt32(txtNumeroControl.Text);
                nuevoTrabajador.Nombre = txtNombre.Text;
                nuevoTrabajador.ApellidoPaterno = txtApellidoPaterno.Text;
                nuevoTrabajador.ApellidoMaterno = txtApellidoMaterno.Text;
                nuevoTrabajador.Correo = txtCorreo.Text;
                nuevoTrabajador.Telefono = txtTelefono.Text;
                nuevoTrabajador.FechaRegistro = dtpFechaRegistro.Value;
                nuevoTrabajador.Estado = "Activo";

                // Dirección, la colonia se elige en el combo ya filtrado por el código postal
                nuevoTrabajador.Calle = txtCalle.Text;
                nuevoTrabajador.CodigoPostal = txtCodigoPostal.Text;
                nuevoTrabajador.IdColonia = Convert.ToInt32(cmbColonia.SelectedValue);

                // Datos laborales: carrera/área seleccionada en el combo
                nuevoTrabajador.IdCarrera = Convert.ToInt32(cmbCarreraArea.SelectedValue);

                // Si el formulario se abrió desde Editar, se actualiza el registro existente;
                // si se abrió desde Nuevo, se inserta uno nuevo.
                string msg;
                if (modoEdicion)
                    msg = nuevoTrabajador.ActualizarTrabajador(idDireccionOriginal, numeroControlOriginal);
                else
                    msg = nuevoTrabajador.RegistrarTrabajador();

                MessageBox.Show(msg, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar al trabajador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroControl.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCodigoPostal.Clear();
            txtMunicipio.Clear();
            txtCalle.Clear();
            cmbColonia.DataSource = null;
            cmbColonia.Items.Clear();

            //Para regresar el combobox a la opcion inicial que es seleccione una carrera
            if (cmbCarreraArea.Items.Count > 0)
            {
                cmbCarreraArea.SelectedIndex = 0;
            }
            //Para poner el cursor en la caja de matricula
            txtNumeroControl.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombos()
        {
            clsTrabajador trabajador = new clsTrabajador();
            try
            {
                DataTable dtCarreras = trabajador.ObtenerCarreras();

                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["id_carrera"] = 0;
                filaPCarrera["nombre_carrera"] = "-- Seleccione una carrera/área --";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0);

                cmbCarreraArea.DataSource = dtCarreras;
                cmbCarreraArea.DisplayMember = "nombre_carrera";
                cmbCarreraArea.ValueMember = "id_carrera";
                cmbCarreraArea.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar carreras/áreas: " + ex.Message);
            }
        }

        // Cuando el bibliotecario termina de teclear el código postal (5 dígitos),
        // se busca el municipio y se cargan las colonias que le correspondan.
        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            string cp = txtCodigoPostal.Text.Trim();

            if (cp.Length != 5)
            {
                txtMunicipio.Clear();
                cmbColonia.DataSource = null;
                cmbColonia.Items.Clear();
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
                    cmbColonia.Items.Clear();
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
