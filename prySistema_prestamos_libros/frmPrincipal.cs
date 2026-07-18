using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace prySistema_prestamos_libros
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal;

        // Botones del menú lateral que representan un módulo del sistema.
        private Button[] botonesModulo;
        private Button botonModuloActivo;

        // Colores normal / activo para marcar en qué módulo está el usuario.
        private static readonly Color colorFondoNormal = Color.FromArgb(201, 168, 76);
        private static readonly Color colorTextoNormal = Color.FromArgb(17, 30, 71);
        private static readonly Color colorFondoActivo = Color.FromArgb(17, 30, 71);
        private static readonly Color colorTextoActivo = Color.FromArgb(201, 168, 76);

        public frmPrincipal()
        {
            InitializeComponent();

            botonesModulo = new[]
            {
                btnNuevoPrestamo,
                btnDevoluciones,
                btnAlumnos,
                btnTrabajadores,
                btnUsuario,
                btnLibro,
                btnEjemplar
            };
        }

        // Quita el resaltado de todos los botones del menú y lo aplica solo al módulo seleccionado.
        private void MarcarModuloActivo(Button boton)
        {
            foreach (Button btn in botonesModulo)
            {
                btn.BackColor = colorFondoNormal;
                btn.ForeColor = colorTextoNormal;
            }

            boton.BackColor = colorFondoActivo;
            boton.ForeColor = colorTextoActivo;
            botonModuloActivo = boton;
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmPrestamos(), pnlContenedor);
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmDevolucion(), pnlContenedor);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmGestionAlumnos(), pnlContenedor);
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmGestionTrabajadores(), pnlContenedor);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmGestionUsuarios(), pnlContenedor);
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmGestionLibros(), pnlContenedor);
        }

        private void btnEjemplar_Click(object sender, EventArgs e)
        {
            MarcarModuloActivo((Button)sender);
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmGestionEjemplares(), pnlContenedor);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Nombre y rol del usuario que inició sesión (se llenan en clsLogin.ValidarAcceso()).
            // El nombre completo solo va en el mensaje de bienvenida; arriba solo se muestra el rol.
            lblBienvenida.Text = "Bienvenido, " + clsLogin.NombreCompleto;
            lblRol.Text = clsLogin.Perfil;

            // lblUsuario tiene AutoSize activado, así que su ancho cambia según el largo del
            // nombre. Si dejamos lblRol y lblAyuda en la posición fija del diseñador, un nombre
            // largo se les encima. Por eso se recalculan aquí, en cascada, según el ancho real
            // que terminó teniendo cada control ya con su texto puesto.
            lblRol.Location = new Point(lblUsuario.Right + 8, lblRol.Location.Y);
            lblAyuda.Location = new Point(lblRol.Right + 8, lblAyuda.Location.Y);
            pcbAyuda.Location = new Point(lblAyuda.Right + 3, pcbAyuda.Location.Y);

            btnNuevoPrestamo.Enabled = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnDevoluciones.Enabled = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnAlumnos.Enabled = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnTrabajadores.Enabled = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnUsuario.Enabled = clsLogin.EsAdministrador;
            btnLibro.Enabled = clsLogin.EsAdministrador;
            btnEjemplar.Enabled = clsLogin.EsAdministrador;


        }
    }
}
