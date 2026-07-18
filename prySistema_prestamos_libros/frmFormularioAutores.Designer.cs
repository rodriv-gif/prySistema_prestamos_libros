namespace prySistema_prestamos_libros
{
    partial class frmFormularioAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioAutores));
            lblRegidtroAutor = new Label();
            pcbContenedorAutores = new PictureBox();
            lblNombreAutor = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            rxtNombreAutor = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorAutores).BeginInit();
            SuspendLayout();
            // 
            // lblRegidtroAutor
            // 
            lblRegidtroAutor.AutoSize = true;
            lblRegidtroAutor.BackColor = Color.FromArgb(250, 247, 242);
            lblRegidtroAutor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegidtroAutor.ForeColor = Color.FromArgb(27, 46, 107);
            lblRegidtroAutor.Location = new Point(34, 34);
            lblRegidtroAutor.Name = "lblRegidtroAutor";
            lblRegidtroAutor.Size = new Size(166, 23);
            lblRegidtroAutor.TabIndex = 0;
            lblRegidtroAutor.Text = "Registro de autores";
            // 
            // pcbContenedorAutores
            // 
            pcbContenedorAutores.Image = Properties.Resources.Imagen1;
            pcbContenedorAutores.Location = new Point(25, 23);
            pcbContenedorAutores.Name = "pcbContenedorAutores";
            pcbContenedorAutores.Size = new Size(582, 215);
            pcbContenedorAutores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorAutores.TabIndex = 1;
            pcbContenedorAutores.TabStop = false;
            // 
            // lblNombreAutor
            // 
            lblNombreAutor.AutoSize = true;
            lblNombreAutor.BackColor = Color.FromArgb(250, 247, 242);
            lblNombreAutor.Location = new Point(46, 72);
            lblNombreAutor.Name = "lblNombreAutor";
            lblNombreAutor.Size = new Size(64, 20);
            lblNombreAutor.TabIndex = 2;
            lblNombreAutor.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.Location = new Point(339, 72);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(122, 20);
            lblApellidoPaterno.TabIndex = 3;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.Location = new Point(46, 144);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(122, 20);
            lblApellidoMaterno.TabIndex = 4;
            lblApellidoMaterno.Text = "ApellidoMaterno";
            // 
            // rxtNombreAutor
            // 
            rxtNombreAutor.Location = new Point(46, 95);
            rxtNombreAutor.Multiline = true;
            rxtNombreAutor.Name = "rxtNombreAutor";
            rxtNombreAutor.Size = new Size(245, 30);
            rxtNombreAutor.TabIndex = 5;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(339, 95);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(245, 30);
            txtApellidoPaterno.TabIndex = 6;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(46, 167);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(245, 30);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(201, 168, 7);
            btnRegistrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(17, 30, 71);
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(123, 278);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 45);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(339, 278);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmFormularioAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 346);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(rxtNombreAutor);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(lblNombreAutor);
            Controls.Add(lblRegidtroAutor);
            Controls.Add(pcbContenedorAutores);
            Name = "frmFormularioAutores";
            Text = "Formulario de autores";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegidtroAutor;
        private PictureBox pcbContenedorAutores;
        private Label lblNombreAutor;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private TextBox rxtNombreAutor;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}