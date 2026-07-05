using System;
using System.Collections.Generic;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsPrincipal
    {
        //Este es un objeto de tipo float
        private Form misformasabiertas;

        public void agregarAlContenedor(Form formulario, Panel panel)
        {
            //Verifica si esta abierto
            if (misformasabiertas != null)
            {
                misformasabiertas.Close();//cierra la instancia
                misformasabiertas.Dispose();//libera de memoria
            }

            //esto es para abrir el formulario en caso de no estar abierto
            misformasabiertas = formulario;
            panel.Controls.Clear();

            formulario.TopLevel = false;//Este indica que el formulario no es independiente.
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock = DockStyle.Fill;//Esto indica que el formulario va a ocupar todo el espacio.

            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    }
}
