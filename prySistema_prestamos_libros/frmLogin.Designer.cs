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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pcbLogo = new PictureBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(364, 329);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(224, 28);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(364, 416);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(224, 28);
            txtContraseña.TabIndex = 1;
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
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(242, 196, 196);
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(122, 32, 32);
            btnSalir.Location = new Point(528, 498);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(976, 618);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(pcbLogo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pcbLogo;
        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
