namespace prySistema_prestamos_libros
{
    partial class frmFormularioAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioAlumno));
            lblDatosAcademicos = new Label();
            lblDereccion = new Label();
            lblDatosPersonales = new Label();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            lblCodigoPostal = new Label();
            lblNumCalle = new Label();
            lblCalle = new Label();
            lblColonia = new Label();
            txtApellidoPaterno = new TextBox();
            txtNombres = new TextBox();
            txtMatricula = new TextBox();
            lblApellidoMaterno = new Label();
            lblFechaRegistro = new Label();
            lblApellidoPaterno = new Label();
            lblCorreo = new Label();
            lblNombres = new Label();
            lblTelefono = new Label();
            lblMatricula = new Label();
            pcbContenedorCompacto = new PictureBox();
            pcbContainerCompacto = new PictureBox();
            pcbContenedorCaptura = new PictureBox();
            lblGrado = new Label();
            lblGrupo = new Label();
            txtApellidoMaterno = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtColonia = new TextBox();
            txtCalle = new TextBox();
            txtNumCalle = new TextBox();
            txtCodigoPostal = new TextBox();
            txtGrado = new TextBox();
            txtGrupo = new TextBox();
            dtpFechaRegistro = new DateTimePicker();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContainerCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDatosAcademicos
            // 
            lblDatosAcademicos.AutoSize = true;
            lblDatosAcademicos.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosAcademicos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosAcademicos.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosAcademicos.Location = new Point(9, 358);
            lblDatosAcademicos.Name = "lblDatosAcademicos";
            lblDatosAcademicos.Size = new Size(130, 19);
            lblDatosAcademicos.TabIndex = 76;
            lblDatosAcademicos.Text = "Datos academicos";
            // 
            // lblDereccion
            // 
            lblDereccion.AutoSize = true;
            lblDereccion.BackColor = Color.FromArgb(250, 247, 242);
            lblDereccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDereccion.ForeColor = Color.FromArgb(27, 46, 107);
            lblDereccion.Location = new Point(9, 216);
            lblDereccion.Name = "lblDereccion";
            lblDereccion.Size = new Size(72, 19);
            lblDereccion.TabIndex = 75;
            lblDereccion.Text = "Dirección";
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosPersonales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPersonales.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosPersonales.Location = new Point(16, 8);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(202, 19);
            lblDatosPersonales.TabIndex = 74;
            lblDatosPersonales.Text = "Datos personales del alumno";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(503, 508);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 34);
            btnLimpiar.TabIndex = 73;
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
            btnCancelar.Location = new Point(835, 508);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 34);
            btnCancelar.TabIndex = 72;
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
            btnGuardar.Location = new Point(176, 508);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 71;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.Location = new Point(25, 388);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 70;
            lblCarrera.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(25, 405);
            cmbCarrera.Margin = new Padding(3, 2, 3, 2);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(215, 23);
            cmbCarrera.TabIndex = 69;
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.BackColor = Color.FromArgb(250, 247, 242);
            lblCodigoPostal.Location = new Point(841, 256);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(81, 15);
            lblCodigoPostal.TabIndex = 68;
            lblCodigoPostal.Text = "Código postal";
            // 
            // lblNumCalle
            // 
            lblNumCalle.AutoSize = true;
            lblNumCalle.BackColor = Color.FromArgb(250, 247, 242);
            lblNumCalle.Location = new Point(564, 256);
            lblNumCalle.Name = "lblNumCalle";
            lblNumCalle.Size = new Size(94, 15);
            lblNumCalle.TabIndex = 67;
            lblNumCalle.Text = "Número de calle";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.BackColor = Color.FromArgb(250, 247, 242);
            lblCalle.Location = new Point(297, 256);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(33, 15);
            lblCalle.TabIndex = 66;
            lblCalle.Text = "Calle";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.BackColor = Color.FromArgb(250, 247, 242);
            lblColonia.Location = new Point(24, 249);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(48, 15);
            lblColonia.TabIndex = 65;
            lblColonia.Text = "Colonia";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(564, 54);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(215, 24);
            txtApellidoPaterno.TabIndex = 58;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombres.Location = new Point(294, 55);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Multiline = true;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(215, 24);
            txtNombres.TabIndex = 56;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(25, 55);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Multiline = true;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(215, 24);
            txtMatricula.TabIndex = 54;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.ForeColor = SystemColors.ControlText;
            lblApellidoMaterno.Location = new Point(841, 38);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 53;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaRegistro.ForeColor = SystemColors.ControlText;
            lblFechaRegistro.Location = new Point(600, 98);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(97, 15);
            lblFechaRegistro.TabIndex = 52;
            lblFechaRegistro.Text = "Fecha de registro";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.ForeColor = Color.Black;
            lblApellidoPaterno.Location = new Point(610, 37);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 51;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.FromArgb(250, 247, 242);
            lblCorreo.ForeColor = SystemColors.ControlText;
            lblCorreo.Location = new Point(297, 98);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 50;
            lblCorreo.Text = "Correo electronico";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.BackColor = Color.FromArgb(250, 247, 242);
            lblNombres.ForeColor = Color.Black;
            lblNombres.Location = new Point(297, 38);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(64, 15);
            lblNombres.TabIndex = 49;
            lblNombres.Text = "Nombre(s)";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(250, 247, 242);
            lblTelefono.ForeColor = SystemColors.ControlText;
            lblTelefono.Location = new Point(24, 98);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 48;
            lblTelefono.Text = "Telefono";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.BackColor = Color.FromArgb(250, 247, 242);
            lblMatricula.ForeColor = SystemColors.ControlText;
            lblMatricula.Location = new Point(24, 37);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 47;
            lblMatricula.Text = "Matricula";
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(2, 346);
            pcbContenedorCompacto.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1082, 103);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 46;
            pcbContenedorCompacto.TabStop = false;
            // 
            // pcbContainerCompacto
            // 
            pcbContainerCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContainerCompacto.Location = new Point(2, 208);
            pcbContainerCompacto.Margin = new Padding(3, 2, 3, 2);
            pcbContainerCompacto.Name = "pcbContainerCompacto";
            pcbContainerCompacto.Size = new Size(1082, 103);
            pcbContainerCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContainerCompacto.TabIndex = 45;
            pcbContainerCompacto.TabStop = false;
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(2, 1);
            pcbContenedorCaptura.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1082, 176);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 44;
            pcbContenedorCaptura.TabStop = false;
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.Location = new Point(297, 386);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(39, 15);
            lblGrado.TabIndex = 77;
            lblGrado.Text = "Grado";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.Location = new Point(564, 386);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 78;
            lblGrupo.Text = "Grupo";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(841, 54);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(215, 24);
            txtApellidoMaterno.TabIndex = 81;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(24, 116);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 24);
            txtTelefono.TabIndex = 82;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(297, 116);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(215, 24);
            txtCorreo.TabIndex = 83;
            // 
            // txtColonia
            // 
            txtColonia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColonia.Location = new Point(25, 274);
            txtColonia.Margin = new Padding(3, 2, 3, 2);
            txtColonia.Multiline = true;
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(215, 24);
            txtColonia.TabIndex = 85;
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalle.Location = new Point(297, 274);
            txtCalle.Margin = new Padding(3, 2, 3, 2);
            txtCalle.Multiline = true;
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(215, 24);
            txtCalle.TabIndex = 86;
            // 
            // txtNumCalle
            // 
            txtNumCalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumCalle.Location = new Point(564, 274);
            txtNumCalle.Margin = new Padding(3, 2, 3, 2);
            txtNumCalle.Multiline = true;
            txtNumCalle.Name = "txtNumCalle";
            txtNumCalle.Size = new Size(215, 24);
            txtNumCalle.TabIndex = 87;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoPostal.Location = new Point(841, 274);
            txtCodigoPostal.Margin = new Padding(3, 2, 3, 2);
            txtCodigoPostal.Multiline = true;
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(215, 24);
            txtCodigoPostal.TabIndex = 88;
            // 
            // txtGrado
            // 
            txtGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.Location = new Point(294, 404);
            txtGrado.Margin = new Padding(3, 2, 3, 2);
            txtGrado.Multiline = true;
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(215, 24);
            txtGrado.TabIndex = 89;
            // 
            // txtGrupo
            // 
            txtGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(564, 405);
            txtGrupo.Margin = new Padding(3, 2, 3, 2);
            txtGrupo.Multiline = true;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(215, 24);
            txtGrupo.TabIndex = 90;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(564, 118);
            dtpFechaRegistro.Margin = new Padding(3, 2, 3, 2);
            dtpFechaRegistro.MaxDate = new DateTime(2026, 6, 29, 0, 0, 0, 0);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(215, 23);
            dtpFechaRegistro.TabIndex = 91;
            dtpFechaRegistro.Value = new DateTime(2026, 6, 29, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpFechaRegistro);
            panel1.Controls.Add(txtGrupo);
            panel1.Controls.Add(txtGrado);
            panel1.Controls.Add(txtCodigoPostal);
            panel1.Controls.Add(txtNumCalle);
            panel1.Controls.Add(txtCalle);
            panel1.Controls.Add(txtColonia);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtApellidoMaterno);
            panel1.Controls.Add(lblGrupo);
            panel1.Controls.Add(lblGrado);
            panel1.Controls.Add(lblDatosAcademicos);
            panel1.Controls.Add(lblDereccion);
            panel1.Controls.Add(lblDatosPersonales);
            panel1.Controls.Add(lblCarrera);
            panel1.Controls.Add(cmbCarrera);
            panel1.Controls.Add(lblCodigoPostal);
            panel1.Controls.Add(lblNumCalle);
            panel1.Controls.Add(lblCalle);
            panel1.Controls.Add(lblColonia);
            panel1.Controls.Add(txtApellidoPaterno);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(txtMatricula);
            panel1.Controls.Add(lblApellidoMaterno);
            panel1.Controls.Add(lblFechaRegistro);
            panel1.Controls.Add(lblApellidoPaterno);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblNombres);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblMatricula);
            panel1.Controls.Add(pcbContenedorCompacto);
            panel1.Controls.Add(pcbContainerCompacto);
            panel1.Controls.Add(pcbContenedorCaptura);
            panel1.Location = new Point(20, 8);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 458);
            panel1.TabIndex = 92;
            // 
            // frmFormularioAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1127, 559);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFormularioAlumno";
            Text = "Formulario de Alumno";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContainerCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDatosAcademicos;
        private Label lblDereccion;
        private Label lblDatosPersonales;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblCarrera;
        private ComboBox cmbCarrera;
        private Label lblCodigoPostal;
        private Label lblNumCalle;
        private Label lblCalle;
        private Label lblColonia;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombres;
        private TextBox txtMatricula;
        private Label lblApellidoMaterno;
        private Label lblFechaRegistro;
        private Label lblApellidoPaterno;
        private Label lblCorreo;
        private Label lblNombres;
        private Label lblTelefono;
        private Label lblMatricula;
        private PictureBox pcbContenedorCompacto;
        private PictureBox pcbContainerCompacto;
        private PictureBox pcbContenedorCaptura;
        private Label lblGrado;
        private Label lblGrupo;
        private TextBox txtApellidoMaterno;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtColonia;
        private TextBox txtCalle;
        private TextBox txtNumCalle;
        private TextBox txtCodigoPostal;
        private TextBox txtGrado;
        private TextBox txtGrupo;
        private DateTimePicker dtpFechaRegistro;
        private Panel panel1;
    }
}