namespace prySistema_prestamos_libros
{
    partial class frmFormularioLibross
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioLibross));
            pcbContenedorCaptura = new PictureBox();
            pcbContenedorCompacto = new PictureBox();
            pcbContainerCompacto = new PictureBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtNumeroControl = new TextBox();
            lblApellidoMaterno = new Label();
            lblFechaRegistro = new Label();
            lblApellidoPaterno = new Label();
            lblcorreo = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblNumControl = new Label();
            lblCodigoPostal = new Label();
            lblcalle = new Label();
            lblcolonia = new Label();
            txtCodigoPostal = new TextBox();
            txtCalle = new TextBox();
            lblArea = new Label();
            cmbCarreraArea = new ComboBox();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblDatosTrabajador = new Label();
            lblDireccion = new Label();
            iblDatosLaborales = new Label();
            dtpFechaRegistro = new DateTimePicker();
            panel1 = new Panel();
            cmbColonia = new ComboBox();
            txtMunicipio = new TextBox();
            lblMunicipio = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContainerCompacto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(5, 3);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1236, 234);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 0;
            pcbContenedorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(5, 282);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1236, 137);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 1;
            pcbContenedorCompacto.TabStop = false;
            // 
            // pcbContainerCompacto
            // 
            pcbContainerCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContainerCompacto.Location = new Point(5, 471);
            pcbContainerCompacto.Name = "pcbContainerCompacto";
            pcbContainerCompacto.Size = new Size(1236, 137);
            pcbContainerCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContainerCompacto.TabIndex = 2;
            pcbContainerCompacto.TabStop = false;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(954, 75);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.MaxLength = 50;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(245, 30);
            txtApellidoMaterno.TabIndex = 27;
            txtApellidoMaterno.KeyPress += SoloLetras_KeyPress;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(649, 75);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.MaxLength = 50;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(245, 30);
            txtApellidoPaterno.TabIndex = 25;
            txtApellidoPaterno.KeyPress += SoloLetras_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(337, 156);
            txtCorreo.Multiline = true;
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(245, 30);
            txtCorreo.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(337, 75);
            txtNombre.Multiline = true;
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 30);
            txtNombre.TabIndex = 23;
            txtNombre.KeyPress += SoloLetras_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(32, 156);
            txtTelefono.Multiline = true;
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(245, 30);
            txtTelefono.TabIndex = 22;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtNumeroControl
            // 
            txtNumeroControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroControl.Location = new Point(32, 75);
            txtNumeroControl.Multiline = true;
            txtNumeroControl.MaxLength = 9;
            txtNumeroControl.Name = "txtNumeroControl";
            txtNumeroControl.Size = new Size(245, 30);
            txtNumeroControl.TabIndex = 21;
            txtNumeroControl.KeyPress += SoloNumeros_KeyPress;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.Location = new Point(954, 52);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(126, 20);
            lblApellidoMaterno.TabIndex = 20;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaRegistro.Location = new Point(649, 133);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(123, 20);
            lblFechaRegistro.TabIndex = 19;
            lblFechaRegistro.Text = "Fecha de registro";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.Location = new Point(650, 52);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(122, 20);
            lblApellidoPaterno.TabIndex = 18;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.BackColor = Color.FromArgb(250, 247, 242);
            lblcorreo.Location = new Point(337, 133);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(132, 20);
            lblcorreo.TabIndex = 17;
            lblcorreo.Text = "Correo electronico";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Location = new Point(337, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 20);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre(s)";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(250, 247, 242);
            lblTelefono.Location = new Point(32, 133);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Telefono";
            // 
            // lblNumControl
            // 
            lblNumControl.AutoSize = true;
            lblNumControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumControl.Location = new Point(31, 52);
            lblNumControl.Name = "lblNumControl";
            lblNumControl.Size = new Size(135, 20);
            lblNumControl.TabIndex = 14;
            lblNumControl.Text = "Numero de control";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.BackColor = Color.FromArgb(250, 247, 242);
            lblCodigoPostal.Location = new Point(32, 328);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(103, 20);
            lblCodigoPostal.TabIndex = 35;
            lblCodigoPostal.Text = "Codigo postal";
            // 
            // lblcalle
            // 
            lblcalle.AutoSize = true;
            lblcalle.BackColor = Color.FromArgb(250, 247, 242);
            lblcalle.Location = new Point(954, 328);
            lblcalle.Name = "lblcalle";
            lblcalle.Size = new Size(42, 20);
            lblcalle.TabIndex = 33;
            lblcalle.Text = "Calle";
            // 
            // lblcolonia
            // 
            lblcolonia.AutoSize = true;
            lblcolonia.BackColor = Color.FromArgb(250, 247, 242);
            lblcolonia.Location = new Point(649, 328);
            lblcolonia.Name = "lblcolonia";
            lblcolonia.Size = new Size(60, 20);
            lblcolonia.TabIndex = 32;
            lblcolonia.Text = "Colonia";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoPostal.Location = new Point(32, 351);
            txtCodigoPostal.Multiline = true;
            txtCodigoPostal.MaxLength = 5;
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(245, 30);
            txtCodigoPostal.TabIndex = 31;
            txtCodigoPostal.TextChanged += txtCodigoPostal_TextChanged;
            txtCodigoPostal.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalle.Location = new Point(954, 351);
            txtCalle.Multiline = true;
            txtCalle.MaxLength = 100;
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(245, 30);
            txtCalle.TabIndex = 29;
            txtCalle.KeyPress += txtCalle_KeyPress;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = Color.FromArgb(250, 247, 242);
            lblArea.Location = new Point(32, 517);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(94, 20);
            lblArea.TabIndex = 37;
            lblArea.Text = "Carrera/Área";
            // 
            // cmbCarreraArea
            // 
            cmbCarreraArea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarreraArea.FormattingEnabled = true;
            cmbCarreraArea.Location = new Point(32, 540);
            cmbCarreraArea.Name = "cmbCarreraArea";
            cmbCarreraArea.Size = new Size(245, 28);
            cmbCarreraArea.TabIndex = 36;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(575, 677);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 45);
            btnLimpiar.TabIndex = 40;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(954, 677);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 168, 76);
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(17, 30, 71);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(201, 677);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblDatosTrabajador
            // 
            lblDatosTrabajador.AutoSize = true;
            lblDatosTrabajador.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosTrabajador.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosTrabajador.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosTrabajador.Location = new Point(21, 14);
            lblDatosTrabajador.Name = "lblDatosTrabajador";
            lblDatosTrabajador.Size = new Size(265, 23);
            lblDatosTrabajador.TabIndex = 41;
            lblDatosTrabajador.Text = "Datos personales del trabajador";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.FromArgb(250, 247, 242);
            lblDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.FromArgb(27, 46, 107);
            lblDireccion.Location = new Point(21, 292);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(85, 23);
            lblDireccion.TabIndex = 42;
            lblDireccion.Text = "Dirección";
            // 
            // iblDatosLaborales
            // 
            iblDatosLaborales.AutoSize = true;
            iblDatosLaborales.BackColor = Color.FromArgb(250, 247, 242);
            iblDatosLaborales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iblDatosLaborales.ForeColor = Color.FromArgb(27, 46, 107);
            iblDatosLaborales.Location = new Point(21, 481);
            iblDatosLaborales.Name = "iblDatosLaborales";
            iblDatosLaborales.Size = new Size(133, 23);
            iblDatosLaborales.TabIndex = 43;
            iblDatosLaborales.Text = "Datos laborales";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(649, 159);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(245, 27);
            dtpFechaRegistro.TabIndex = 44;
            dtpFechaRegistro.Value = new DateTime(2026, 7, 5, 22, 46, 15, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbColonia);
            panel1.Controls.Add(txtMunicipio);
            panel1.Controls.Add(lblMunicipio);
            panel1.Controls.Add(dtpFechaRegistro);
            panel1.Controls.Add(iblDatosLaborales);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(lblDatosTrabajador);
            panel1.Controls.Add(lblArea);
            panel1.Controls.Add(cmbCarreraArea);
            panel1.Controls.Add(lblCodigoPostal);
            panel1.Controls.Add(lblcalle);
            panel1.Controls.Add(lblcolonia);
            panel1.Controls.Add(txtCodigoPostal);
            panel1.Controls.Add(txtCalle);
            panel1.Controls.Add(txtApellidoMaterno);
            panel1.Controls.Add(txtApellidoPaterno);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNumeroControl);
            panel1.Controls.Add(lblApellidoMaterno);
            panel1.Controls.Add(lblFechaRegistro);
            panel1.Controls.Add(lblApellidoPaterno);
            panel1.Controls.Add(lblcorreo);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblNumControl);
            panel1.Controls.Add(pcbContainerCompacto);
            panel1.Controls.Add(pcbContenedorCompacto);
            panel1.Controls.Add(pcbContenedorCaptura);
            panel1.Location = new Point(24, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 609);
            panel1.TabIndex = 45;
            // 
            // cmbColonia
            // 
            cmbColonia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbColonia.FormattingEnabled = true;
            cmbColonia.Location = new Point(649, 353);
            cmbColonia.Name = "cmbColonia";
            cmbColonia.Size = new Size(245, 28);
            cmbColonia.TabIndex = 47;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMunicipio.Location = new Point(337, 351);
            txtMunicipio.Multiline = true;
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(245, 30);
            txtMunicipio.TabIndex = 46;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.BackColor = Color.FromArgb(250, 247, 242);
            lblMunicipio.Location = new Point(337, 328);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(75, 20);
            lblMunicipio.TabIndex = 45;
            lblMunicipio.Text = "Municipio";
            // 
            // frmFormularioTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1292, 750);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "frmFormularioTrabajadores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario de Trabajador";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContainerCompacto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbContenedorCaptura;
        private PictureBox pcbContenedorCompacto;
        private PictureBox pcbContainerCompacto;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtNumeroControl;
        private Label lblApellidoMaterno;
        private Label lblFechaRegistro;
        private Label lblApellidoPaterno;
        private Label lblcorreo;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblNumControl;
        private Label lblCodigoPostal;
        private Label lblcalle;
        private Label lblcolonia;
        private TextBox txtCodigoPostal;
        private TextBox txtCalle;
        private Label lblArea;
        private ComboBox cmbCarreraArea;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblDatosTrabajador;
        private Label lblDireccion;
        private Label iblDatosLaborales;
        private DateTimePicker dtpFechaRegistro;
        private Panel panel1;
        private TextBox txtMunicipio;
        private Label lblMunicipio;
        private ComboBox cmbColonia;
    }
}