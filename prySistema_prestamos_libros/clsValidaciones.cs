using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    // Clase de apoyo para validar que los formularios de captura no se guarden con campos vacíos.
    internal static class clsValidaciones
    {
        // Revisa una lista de controles (TextBox, ComboBox, NumericUpDown) contra su nombre para el usuario.
        // Regresa false y arma el mensaje de error si algún campo obligatorio quedó vacío.
        public static bool ValidarCamposVacios(List<(Control control, string nombre)> campos, out string mensaje)
        {
            List<string> vacios = new List<string>();

            foreach (var campo in campos)
            {
                switch (campo.control)
                {
                    case TextBox txt:
                        if (string.IsNullOrWhiteSpace(txt.Text))
                            vacios.Add(campo.nombre);
                        break;

                    case ComboBox cmb:
                        if (cmb.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmb.Text))
                            vacios.Add(campo.nombre);
                        break;

                    case NumericUpDown nud:
                        if (nud.Value <= 0)
                            vacios.Add(campo.nombre);
                        break;
                }
            }

            if (vacios.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Los siguientes campos son obligatorios y no pueden quedar vacíos:");
                sb.AppendLine();
                foreach (string campo in vacios)
                    sb.AppendLine("- " + campo);

                mensaje = sb.ToString();
                return false;
            }

            mensaje = string.Empty;
            return true;
        }

        // Muestra el mensaje de error estándar para campos vacíos.
        public static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
