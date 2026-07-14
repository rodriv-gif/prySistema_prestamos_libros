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
        private string colonia;
        private string calle;
        private string numeroCalle;
        private string codigoPostal;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
    }
}
