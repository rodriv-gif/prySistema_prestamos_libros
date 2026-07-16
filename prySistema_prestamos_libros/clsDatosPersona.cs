using System;
using System.Collections.Generic;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsDatosPersona
    {
        //atributos
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string telefono;
        private string correo;
        private DateTime fechaRegistro;
        private int idColonia;
        private string calle;
        private string codigoPostal;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        // Ya no es el nombre de la colonia en texto: es el id que entrega cmbColonia.SelectedValue,
        // porque tbldireccion.id_colonia es la columna que realmente se guarda.
        public int IdColonia { get => idColonia; set => idColonia = value; }
        public string Calle { get => calle; set => calle = value; }
        // No se inserta directo en ninguna tabla; solo se usa para filtrar tblcolonias al capturar.
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
    }
}
