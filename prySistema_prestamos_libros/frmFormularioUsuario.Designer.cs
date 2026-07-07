namespace prySistema_prestamos_libros
{
    partial class frmFormularioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioUsuario));
            pcbContenedorCaptura = new PictureBox();
            pcbContenedorCompacto = new PictureBox();
            lblVincularTrabajador = new Label();
            lblNumControl = new Label();
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblCarrera = new Label();
            btnAgregarTrabajador = new Button();
            lblAccesoSistema = new Label();
            lblPerfil = new Label();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            cmbPerfil = new ComboBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            txtApellidoPaternoTrabajador = new TextBox();
            txtApellidoMaternoTrabajador = new TextBox();
            txtCarreraTrabajador = new TextBox();
            txtNombreTrabajador = new TextBox();
            txtNumControl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCaptura.Location = new Point(20, 105);
            pcbContenedorCaptura.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1139, 176);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 0;
            pcbContenedorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(20, 314);
            pcbContenedorCompacto.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1139, 103);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 1;
            pcbContenedorCompacto.TabStop = false;
            // 
            // lblVincularTrabajador
            // 
            lblVincularTrabajador.AutoSize = true;
            lblVincularTrabajador.BackColor = Color.FromArgb(250, 247, 242);
            lblVincularTrabajador.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblVincularTrabajador.ForeColor = Color.FromArgb(27, 46, 107);
            lblVincularTrabajador.Location = new Point(34, 112);
            lblVincularTrabajador.Name = "lblVincularTrabajador";
            lblVincularTrabajador.Size = new Size(139, 19);
            lblVincularTrabajador.TabIndex = 3;
            lblVincularTrabajador.Text = "Vincular trabajador";
            // 
            // lblNumControl
            // 
            lblNumControl.AutoSize = true;
            lblNumControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumControl.ForeColor = SystemColors.ControlText;
            lblNumControl.Location = new Point(35, 137);
            lblNumControl.Name = "lblNumControl";
            lblNumControl.Size = new Size(108, 15);
            lblNumControl.TabIndex = 4;
            lblNumControl.Text = "Numero de control";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(34, 186);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.ForeColor = SystemColors.ControlText;
            lblApellidoPaterno.Location = new Point(322, 186);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 6;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.ForeColor = SystemColors.ControlText;
            lblApellidoMaterno.Location = new Point(622, 186);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 7;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.ForeColor = SystemColors.ControlText;
            lblCarrera.Location = new Point(916, 186);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(74, 15);
            lblCarrera.TabIndex = 8;
            lblCarrera.Text = "Carrera/Área";
            // 
            // btnAgregarTrabajador
            // 
            btnAgregarTrabajador.BackColor = Color.FromArgb(27, 46, 107);
            btnAgregarTrabajador.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarTrabajador.ForeColor = Color.FromArgb(201, 168, 76);
            btnAgregarTrabajador.Image = (Image)resources.GetObject("btnAgregarTrabajador.Image");
            btnAgregarTrabajador.Location = new Point(514, 238);
            btnAgregarTrabajador.Margin = new Padding(3, 2, 3, 2);
            btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            btnAgregarTrabajador.Size = new Size(131, 34);
            btnAgregarTrabajador.TabIndex = 9;
            btnAgregarTrabajador.Text = "Agregar";
            btnAgregarTrabajador.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarTrabajador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarTrabajador.UseVisualStyleBackColor = false;
            // 
            // lblAccesoSistema
            // 
            lblAccesoSistema.AutoSize = true;
            lblAccesoSistema.BackColor = Color.FromArgb(250, 247, 242);
            lblAccesoSistema.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAccesoSistema.ForeColor = Color.FromArgb(27, 46, 107);
            lblAccesoSistema.Location = new Point(36, 323);
            lblAccesoSistema.Name = "lblAccesoSistema";
            lblAccesoSistema.Size = new Size(126, 19);
            lblAccesoSistema.TabIndex = 10;
            lblAccesoSistema.Text = "Acceso al sistema";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.FromArgb(250, 247, 242);
            lblPerfil.ForeColor = SystemColors.ControlText;
            lblPerfil.Location = new Point(36, 352);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 11;
            lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(250, 247, 242);
            lblUsuario.ForeColor = SystemColors.ControlText;
            lblUsuario.Location = new Point(323, 352);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.FromArgb(250, 247, 242);
            lblContrasenia.ForeColor = SystemColors.ControlText;
            lblContrasenia.Location = new Point(623, 353);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 13;
            lblContrasenia.Text = "Contraseña";
            // 
            // cmbPerfil
            // 
            cmbPerfil.BackColor = Color.White;
            cmbPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(36, 370);
            cmbPerfil.Margin = new Padding(3, 2, 3, 2);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(215, 23);
            cmbPerfil.TabIndex = 14;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(31, 31, 31);
            txtUsuario.Location = new Point(323, 370);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(215, 24);
            txtUsuario.TabIndex = 15;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.White;
            txtContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.FromArgb(31, 31, 31);
            txtContrasena.Location = new Point(623, 370);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(215, 24);
            txtContrasena.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 168, 76);
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(31, 31, 31);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(211, 512);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(514, 512);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 34);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(860, 512);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 34);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtApellidoPaternoTrabajador
            // 
            txtApellidoPaternoTrabajador.BackColor = Color.White;
            txtApellidoPaternoTrabajador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaternoTrabajador.ForeColor = Color.FromArgb(31, 31, 31);
            txtApellidoPaternoTrabajador.Location = new Point(322, 203);
            txtApellidoPaternoTrabajador.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaternoTrabajador.Multiline = true;
            txtApellidoPaternoTrabajador.Name = "txtApellidoPaternoTrabajador";
            txtApellidoPaternoTrabajador.Size = new Size(215, 24);
            txtApellidoPaternoTrabajador.TabIndex = 20;
            // 
            // txtApellidoMaternoTrabajador
            // 
            txtApellidoMaternoTrabajador.BackColor = Color.White;
            txtApellidoMaternoTrabajador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaternoTrabajador.ForeColor = Color.FromArgb(31, 31, 31);
            txtApellidoMaternoTrabajador.Location = new Point(622, 202);
            txtApellidoMaternoTrabajador.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaternoTrabajador.Multiline = true;
            txtApellidoMaternoTrabajador.Name = "txtApellidoMaternoTrabajador";
            txtApellidoMaternoTrabajador.Size = new Size(215, 24);
            txtApellidoMaternoTrabajador.TabIndex = 21;
            // 
            // txtCarreraTrabajador
            // 
            txtCarreraTrabajador.BackColor = Color.White;
            txtCarreraTrabajador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarreraTrabajador.ForeColor = Color.FromArgb(31, 31, 31);
            txtCarreraTrabajador.Location = new Point(916, 202);
            txtCarreraTrabajador.Margin = new Padding(3, 2, 3, 2);
            txtCarreraTrabajador.Multiline = true;
            txtCarreraTrabajador.Name = "txtCarreraTrabajador";
            txtCarreraTrabajador.Size = new Size(215, 24);
            txtCarreraTrabajador.TabIndex = 23;
            txtCarreraTrabajador.TextChanged += textBox6_TextChanged;
            // 
            // txtNombreTrabajador
            // 
            txtNombreTrabajador.BackColor = Color.White;
            txtNombreTrabajador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreTrabajador.ForeColor = Color.FromArgb(31, 31, 31);
            txtNombreTrabajador.Location = new Point(35, 203);
            txtNombreTrabajador.Margin = new Padding(3, 2, 3, 2);
            txtNombreTrabajador.Multiline = true;
            txtNombreTrabajador.Name = "txtNombreTrabajador";
            txtNombreTrabajador.Size = new Size(215, 24);
            txtNombreTrabajador.TabIndex = 24;
            // 
            // txtNumControl
            // 
            txtNumControl.BackColor = Color.White;
            txtNumControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControl.ForeColor = Color.FromArgb(31, 31, 31);
            txtNumControl.Location = new Point(35, 154);
            txtNumControl.Margin = new Padding(3, 2, 3, 2);
            txtNumControl.Multiline = true;
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(215, 24);
            txtNumControl.TabIndex = 25;
            // 
            // frmFormularioUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 562);
            Controls.Add(txtNumControl);
            Controls.Add(txtNombreTrabajador);
            Controls.Add(txtCarreraTrabajador);
            Controls.Add(txtApellidoMaternoTrabajador);
            Controls.Add(txtApellidoPaternoTrabajador);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(cmbPerfil);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblPerfil);
            Controls.Add(lblAccesoSistema);
            Controls.Add(btnAgregarTrabajador);
            Controls.Add(lblCarrera);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(lblNombre);
            Controls.Add(lblNumControl);
            Controls.Add(lblVincularTrabajador);
            Controls.Add(pcbContenedorCompacto);
            Controls.Add(pcbContenedorCaptura);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFormularioUsuario";
            Text = "Formulario de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbContenedorCaptura;
        private PictureBox pcbContenedorCompacto;
        private Label lblVincularTrabajador;
        private Label lblNumControl;
        private Label lblNombre;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private Label lblCarrera;
        private Button btnAgregarTrabajador;
        private Label lblAccesoSistema;
        private Label lblPerfil;
        private Label lblUsuario;
        private Label lblContrasenia;
        private ComboBox cmbPerfil;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private TextBox txtApellidoPaternoTrabajador;
        private TextBox txtApellidoMaternoTrabajador;
        private TextBox txtCarreraTrabajador;
        private TextBox txtNombreTrabajador;
        private TextBox txtNumControl;
    }
}