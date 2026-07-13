namespace prySistema_prestamos_libros
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pcbLogo = new PictureBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnAcceder = new Button();
            btnSalir = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.logol;
            pcbLogo.Location = new Point(344, 12);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(280, 280);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(17, 30, 71);
            lblUsuario.Location = new Point(437, 295);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(92, 31);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.FromArgb(17, 30, 71);
            lblContraseña.Location = new Point(418, 382);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(129, 31);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(27, 46, 107);
            btnAcceder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.FromArgb(201, 168, 76);
            btnAcceder.Location = new Point(259, 498);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(150, 45);
            btnAcceder.TabIndex = 5;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(107, 122, 153);
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(250, 247, 242);
            btnSalir.Location = new Point(528, 498);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(364, 427);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(245, 34);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(364, 339);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(245, 30);
            txtUsuario.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(976, 618);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(pcbLogo);
            Name = "frmLogin";
            Text = "Control de acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbLogo;
        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnAcceder;
        private Button btnSalir;
        private TextBox txtPassword;
        private TextBox txtUsuario;
    }
}
