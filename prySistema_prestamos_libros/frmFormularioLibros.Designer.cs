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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioLibros));
            pcbContenendorCaptura = new PictureBox();
            pcbContenedorCompacto = new PictureBox();
            txtIdioma = new TextBox();
            txtNumPaginas = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtEditorial = new TextBox();
            txtISBN = new TextBox();
            lblIdioma = new Label();
            lblNumPaginas = new Label();
            lblCategoria = new Label();
            lblTitulo = new Label();
            lblEditorial = new Label();
            lblISBN = new Label();
            lblApellidoMaterno = new Label();
            lblApaterno = new Label();
            lblNombre = new Label();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombreAutor = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            lblDatosLibro = new Label();
            lblDatosAutor = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbContenendorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            SuspendLayout();
            // 
            // pcbContenendorCaptura
            // 
            pcbContenendorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenendorCaptura.Location = new Point(21, 119);
            pcbContenendorCaptura.Name = "pcbContenendorCaptura";
            pcbContenendorCaptura.Size = new Size(1302, 234);
            pcbContenendorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenendorCaptura.TabIndex = 0;
            pcbContenendorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(21, 398);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1302, 137);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 1;
            pcbContenedorCompacto.TabStop = false;
            // 
            // txtIdioma
            // 
            txtIdioma.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdioma.Location = new Point(790, 273);
            txtIdioma.Multiline = true;
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(245, 30);
            txtIdioma.TabIndex = 23;
            // 
            // txtNumPaginas
            // 
            txtNumPaginas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumPaginas.Location = new Point(790, 181);
            txtNumPaginas.Multiline = true;
            txtNumPaginas.Name = "txtNumPaginas";
            txtNumPaginas.Size = new Size(245, 30);
            txtNumPaginas.TabIndex = 22;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(417, 273);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(245, 30);
            txtCategoria.TabIndex = 21;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(417, 184);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(245, 30);
            txtTitulo.TabIndex = 20;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditorial.Location = new Point(55, 273);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(245, 30);
            txtEditorial.TabIndex = 19;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(55, 184);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(245, 30);
            txtISBN.TabIndex = 18;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.BackColor = Color.FromArgb(250, 247, 242);
            lblIdioma.Location = new Point(790, 250);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(56, 20);
            lblIdioma.TabIndex = 17;
            lblIdioma.Text = "Idioma";
            // 
            // lblNumPaginas
            // 
            lblNumPaginas.AutoSize = true;
            lblNumPaginas.BackColor = Color.FromArgb(250, 247, 242);
            lblNumPaginas.Location = new Point(790, 158);
            lblNumPaginas.Name = "lblNumPaginas";
            lblNumPaginas.Size = new Size(140, 20);
            lblNumPaginas.TabIndex = 16;
            lblNumPaginas.Text = "Numero de páginas";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(250, 247, 242);
            lblCategoria.Location = new Point(417, 250);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 15;
            lblCategoria.Text = "Categoría";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(250, 247, 242);
            lblTitulo.Location = new Point(417, 158);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 20);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Titulo del libro";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.BackColor = Color.FromArgb(250, 247, 242);
            lblEditorial.Location = new Point(55, 250);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(65, 20);
            lblEditorial.TabIndex = 13;
            lblEditorial.Text = "Editorial";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.FromArgb(250, 247, 242);
            lblISBN.Location = new Point(55, 158);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 12;
            lblISBN.Text = "ISBN";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.Location = new Point(790, 449);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(126, 20);
            lblApellidoMaterno.TabIndex = 29;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblApaterno
            // 
            lblApaterno.AutoSize = true;
            lblApaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApaterno.Location = new Point(417, 449);
            lblApaterno.Name = "lblApaterno";
            lblApaterno.Size = new Size(122, 20);
            lblApaterno.TabIndex = 28;
            lblApaterno.Text = "Apellido paterno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Location = new Point(55, 449);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 20);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre(s)";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(790, 472);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(245, 30);
            txtApellidoMaterno.TabIndex = 26;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(417, 472);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(245, 30);
            txtApellidoPaterno.TabIndex = 25;
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreAutor.Location = new Point(55, 472);
            txtNombreAutor.Multiline = true;
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(245, 30);
            txtNombreAutor.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 168, 76);
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(17, 30, 71);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(278, 627);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(926, 627);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(609, 627);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 45);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblDatosLibro
            // 
            lblDatosLibro.AutoSize = true;
            lblDatosLibro.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosLibro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosLibro.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosLibro.Location = new Point(30, 126);
            lblDatosLibro.Name = "lblDatosLibro";
            lblDatosLibro.Size = new Size(129, 23);
            lblDatosLibro.TabIndex = 33;
            lblDatosLibro.Text = "Datos del libro";
            // 
            // lblDatosAutor
            // 
            lblDatosAutor.AutoSize = true;
            lblDatosAutor.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosAutor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosAutor.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosAutor.Location = new Point(25, 407);
            lblDatosAutor.Name = "lblDatosAutor";
            lblDatosAutor.Size = new Size(134, 23);
            lblDatosAutor.TabIndex = 34;
            lblDatosAutor.Text = "Datos del autor";
            // 
            // frmFormularioLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 848);
            Controls.Add(lblDatosAutor);
            Controls.Add(lblDatosLibro);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApaterno);
            Controls.Add(lblNombre);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombreAutor);
            Controls.Add(txtIdioma);
            Controls.Add(txtNumPaginas);
            Controls.Add(txtCategoria);
            Controls.Add(txtTitulo);
            Controls.Add(txtEditorial);
            Controls.Add(txtISBN);
            Controls.Add(lblIdioma);
            Controls.Add(lblNumPaginas);
            Controls.Add(lblCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(lblEditorial);
            Controls.Add(lblISBN);
            Controls.Add(pcbContenedorCompacto);
            Controls.Add(pcbContenendorCaptura);
            Name = "frmFormularioLibros";
            Text = "Formulario de libros";
            ((System.ComponentModel.ISupportInitialize)pcbContenendorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbContenendorCaptura;
        private PictureBox pcbContenedorCompacto;
        private TextBox txtIdioma;
        private TextBox textBox6;
        private TextBox txtNumPaginas;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtEditorial;
        private TextBox txtISBN;
        private Label lblIdioma;
        private Label lblNumPaginas;
        private Label lblCategoria;
        private Label lblTitulo;
        private Label lblEditorial;
        private Label lblISBN;
        private Label lblApellidoMaterno;
        private Label lblApaterno;
        private Label lblNombre;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombreAutor;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Label lblDatosLibro;
        private Label lblDatosAutor;
    }
}