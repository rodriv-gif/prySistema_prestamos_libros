namespace prySistema_prestamos_libros
{
    partial class frmFormularioLibros
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtIdioma = new TextBox();
            txtNumPaginas = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtEditorial = new TextBox();
            txtISBN = new TextBox();
            lblIdioma = new Label();
            numPaginas = new Label();
            lblCategoria = new Label();
            lblTitulo = new Label();
            lblEditorial = new Label();
            lblISBN = new Label();
            lblAmaterno = new Label();
            lblApaterno = new Label();
            lblNombre = new Label();
            txtApMaternoAutor = new TextBox();
            txtApPaternoAutor = new TextBox();
            txtNombreAutor = new TextBox();
            btnguardar = new Button();
            btncancelar = new Button();
            btnlimpiar = new Button();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(62, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1302, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.contenedorgroupCompac;
            pictureBox2.Location = new Point(62, 375);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1302, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(871, 250);
            txtIdioma.Multiline = true;
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(236, 30);
            txtIdioma.TabIndex = 23;
            // 
            // txtNumPaginas
            // 
            txtNumPaginas.Location = new Point(871, 161);
            txtNumPaginas.Multiline = true;
            txtNumPaginas.Name = "txtNumPaginas";
            txtNumPaginas.Size = new Size(236, 30);
            txtNumPaginas.TabIndex = 22;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(507, 250);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(236, 30);
            txtCategoria.TabIndex = 21;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(507, 161);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(236, 30);
            txtTitulo.TabIndex = 20;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(96, 250);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(236, 30);
            txtEditorial.TabIndex = 19;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(96, 161);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(236, 30);
            txtISBN.TabIndex = 18;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.BackColor = Color.FromArgb(250, 247, 242);
            lblIdioma.Location = new Point(871, 227);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(56, 20);
            lblIdioma.TabIndex = 17;
            lblIdioma.Text = "Idioma";
            // 
            // numPaginas
            // 
            numPaginas.AutoSize = true;
            numPaginas.BackColor = Color.FromArgb(250, 247, 242);
            numPaginas.Location = new Point(871, 135);
            numPaginas.Name = "numPaginas";
            numPaginas.Size = new Size(140, 20);
            numPaginas.TabIndex = 16;
            numPaginas.Text = "Numero de paginas";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(250, 247, 242);
            lblCategoria.Location = new Point(518, 227);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 15;
            lblCategoria.Text = "Categoria";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(250, 247, 242);
            lblTitulo.Location = new Point(507, 138);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 20);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Titulo del libro";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.BackColor = Color.FromArgb(250, 247, 242);
            lblEditorial.Location = new Point(96, 227);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(65, 20);
            lblEditorial.TabIndex = 13;
            lblEditorial.Text = "Editorial";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.FromArgb(250, 247, 242);
            lblISBN.Location = new Point(96, 135);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 12;
            lblISBN.Text = "ISBN";
            // 
            // lblAmaterno
            // 
            lblAmaterno.AutoSize = true;
            lblAmaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblAmaterno.Location = new Point(871, 426);
            lblAmaterno.Name = "lblAmaterno";
            lblAmaterno.Size = new Size(126, 20);
            lblAmaterno.TabIndex = 29;
            lblAmaterno.Text = "Apellido materno";
            // 
            // lblApaterno
            // 
            lblApaterno.AutoSize = true;
            lblApaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApaterno.Location = new Point(492, 426);
            lblApaterno.Name = "lblApaterno";
            lblApaterno.Size = new Size(122, 20);
            lblApaterno.TabIndex = 28;
            lblApaterno.Text = "Apellido paterno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Location = new Point(96, 426);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 20);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre(s)";
            // 
            // txtApMaternoAutor
            // 
            txtApMaternoAutor.Location = new Point(871, 449);
            txtApMaternoAutor.Multiline = true;
            txtApMaternoAutor.Name = "txtApMaternoAutor";
            txtApMaternoAutor.Size = new Size(236, 30);
            txtApMaternoAutor.TabIndex = 26;
            // 
            // txtApPaternoAutor
            // 
            txtApPaternoAutor.Location = new Point(492, 449);
            txtApPaternoAutor.Multiline = true;
            txtApPaternoAutor.Name = "txtApPaternoAutor";
            txtApPaternoAutor.Size = new Size(236, 30);
            txtApPaternoAutor.TabIndex = 25;
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.Location = new Point(96, 449);
            txtNombreAutor.Multiline = true;
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(236, 30);
            txtNombreAutor.TabIndex = 24;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(201, 168, 76);
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.ForeColor = Color.FromArgb(17, 30, 71);
            btnguardar.Image = Properties.Resources.Guardar;
            btnguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardar.Location = new Point(367, 587);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(150, 45);
            btnguardar.TabIndex = 32;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(242, 196, 196);
            btncancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btncancelar.Image = Properties.Resources.Cancelar1_0;
            btncancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btncancelar.Location = new Point(944, 587);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(150, 45);
            btncancelar.TabIndex = 31;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnlimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnlimpiar.Image = Properties.Resources.Limpiar;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(651, 587);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(150, 45);
            btnlimpiar.TabIndex = 30;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(250, 247, 242);
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(27, 46, 107);
            label10.Location = new Point(71, 103);
            label10.Name = "label10";
            label10.Size = new Size(129, 23);
            label10.TabIndex = 33;
            label10.Text = "Datos del libro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(250, 247, 242);
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(27, 46, 107);
            label11.Location = new Point(66, 384);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 34;
            label11.Text = "Datos del autor";
            // 
            // frmFormularioLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 848);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnguardar);
            Controls.Add(btncancelar);
            Controls.Add(btnlimpiar);
            Controls.Add(lblAmaterno);
            Controls.Add(lblApaterno);
            Controls.Add(lblNombre);
            Controls.Add(txtApMaternoAutor);
            Controls.Add(txtApPaternoAutor);
            Controls.Add(txtNombreAutor);
            Controls.Add(txtIdioma);
            Controls.Add(txtNumPaginas);
            Controls.Add(txtCategoria);
            Controls.Add(txtTitulo);
            Controls.Add(txtEditorial);
            Controls.Add(txtISBN);
            Controls.Add(lblIdioma);
            Controls.Add(numPaginas);
            Controls.Add(lblCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(lblEditorial);
            Controls.Add(lblISBN);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmFormularioLibros";
            Text = "Formularios de libros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtIdioma;
        private TextBox textBox6;
        private TextBox txtNumPaginas;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtEditorial;
        private TextBox txtISBN;
        private Label lblIdioma;
        private Label numPaginas;
        private Label lblCategoria;
        private Label lblTitulo;
        private Label lblEditorial;
        private Label lblISBN;
        private Label lblAmaterno;
        private Label lblApaterno;
        private Label lblNombre;
        private TextBox txtApMaternoAutor;
        private TextBox txtApPaternoAutor;
        private TextBox txtNombreAutor;
        private Button btnguardar;
        private Button btncancelar;
        private Button btnlimpiar;
        private Label label10;
        private Label label11;
    }
}