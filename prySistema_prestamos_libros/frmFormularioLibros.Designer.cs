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
            txtNumPaginas = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblIdioma = new Label();
            lblNumPaginas = new Label();
            lblCategoria = new Label();
            lblTitulo = new Label();
            lblEditorial = new Label();
            lblISBN = new Label();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            lblDatosLibro = new Label();
            lblDatosAutor = new Label();
            cmbEditorial = new ComboBox();
            cmbCategoria = new ComboBox();
            cmbIdioma = new ComboBox();
            txtBuscarAutor = new TextBox();
            dgvAutor = new DataGridView();
            dgvAlmacenarAutor = new DataGridView();
            btnBorrar = new Button();
            btnAgregarAutor = new Button();
            btnNuevoAutor = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbContenendorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAutor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacenarAutor).BeginInit();
            SuspendLayout();
            // 
            // pcbContenendorCaptura
            // 
            pcbContenendorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenendorCaptura.Location = new Point(27, 19);
            pcbContenendorCaptura.Name = "pcbContenendorCaptura";
            pcbContenendorCaptura.Size = new Size(1014, 330);
            pcbContenendorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenendorCaptura.TabIndex = 0;
            pcbContenendorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(27, 369);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1014, 228);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 1;
            pcbContenedorCompacto.TabStop = false;
            // 
            // txtNumPaginas
            // 
            txtNumPaginas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumPaginas.Location = new Point(755, 77);
            txtNumPaginas.MaxLength = 5;
            txtNumPaginas.Multiline = true;
            txtNumPaginas.Name = "txtNumPaginas";
            txtNumPaginas.Size = new Size(245, 30);
            txtNumPaginas.TabIndex = 22;
            txtNumPaginas.KeyPress += SoloNumeros_KeyPress;
            //
            // txtTitulo
            //
            txtTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(411, 77);
            txtTitulo.MaxLength = 150;
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(245, 30);
            txtTitulo.TabIndex = 20;
            txtTitulo.KeyPress += txtTitulo_KeyPress;
            //
            // txtISBN
            //
            txtISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(61, 77);
            txtISBN.MaxLength = 13;
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(245, 30);
            txtISBN.TabIndex = 18;
            txtISBN.KeyPress += SoloNumeros_KeyPress;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.BackColor = Color.FromArgb(250, 247, 242);
            lblIdioma.Location = new Point(755, 143);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(56, 20);
            lblIdioma.TabIndex = 17;
            lblIdioma.Text = "Idioma";
            // 
            // lblNumPaginas
            // 
            lblNumPaginas.AutoSize = true;
            lblNumPaginas.BackColor = Color.FromArgb(250, 247, 242);
            lblNumPaginas.Location = new Point(755, 51);
            lblNumPaginas.Name = "lblNumPaginas";
            lblNumPaginas.Size = new Size(140, 20);
            lblNumPaginas.TabIndex = 16;
            lblNumPaginas.Text = "Numero de páginas";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(250, 247, 242);
            lblCategoria.Location = new Point(411, 143);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 15;
            lblCategoria.Text = "Categoría";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(250, 247, 242);
            lblTitulo.Location = new Point(411, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 20);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Titulo del libro";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.BackColor = Color.FromArgb(250, 247, 242);
            lblEditorial.Location = new Point(61, 145);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(65, 20);
            lblEditorial.TabIndex = 13;
            lblEditorial.Text = "Editorial";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.FromArgb(250, 247, 242);
            lblISBN.Location = new Point(61, 51);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 12;
            lblISBN.Text = "ISBN";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Location = new Point(165, 412);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 20);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre(s)";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 168, 76);
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(17, 30, 71);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(125, 623);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(773, 623);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(456, 623);
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
            lblDatosLibro.Location = new Point(41, 28);
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
            lblDatosAutor.Location = new Point(31, 378);
            lblDatosAutor.Name = "lblDatosAutor";
            lblDatosAutor.Size = new Size(134, 23);
            lblDatosAutor.TabIndex = 34;
            lblDatosAutor.Text = "Datos del autor";
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(61, 168);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(245, 28);
            cmbEditorial.TabIndex = 35;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(411, 168);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(245, 28);
            cmbCategoria.TabIndex = 36;
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(755, 168);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(245, 28);
            cmbIdioma.TabIndex = 37;
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.Location = new Point(251, 409);
            txtBuscarAutor.Multiline = true;
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.Size = new Size(322, 30);
            txtBuscarAutor.TabIndex = 39;
            txtBuscarAutor.TextChanged += txtBuscarAutor_TextChanged;
            // 
            // dgvAutor
            // 
            dgvAutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutor.Location = new Point(165, 445);
            dgvAutor.Name = "dgvAutor";
            dgvAutor.RowHeadersWidth = 51;
            dgvAutor.Size = new Size(423, 128);
            dgvAutor.TabIndex = 41;
            dgvAutor.CellDoubleClick += dgvAutor_CellDoubleClick;
            // 
            // dgvAlmacenarAutor
            // 
            dgvAlmacenarAutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlmacenarAutor.Location = new Point(61, 230);
            dgvAlmacenarAutor.Name = "dgvAlmacenarAutor";
            dgvAlmacenarAutor.RowHeadersWidth = 51;
            dgvAlmacenarAutor.Size = new Size(370, 95);
            dgvAlmacenarAutor.TabIndex = 42;
            dgvAlmacenarAutor.CellContentDoubleClick += dgvAlmacenarAutor_CellContentDoubleClick;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(27, 46, 107);
            btnBorrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = Color.FromArgb(250, 247, 242);
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(469, 255);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 45);
            btnBorrar.TabIndex = 43;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextAlign = ContentAlignment.MiddleRight;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.BackColor = Color.FromArgb(27, 46, 107);
            btnAgregarAutor.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarAutor.ForeColor = Color.FromArgb(201, 168, 76);
            btnAgregarAutor.Image = (Image)resources.GetObject("btnAgregarAutor.Image");
            btnAgregarAutor.Location = new Point(610, 484);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(150, 45);
            btnAgregarAutor.TabIndex = 44;
            btnAgregarAutor.Text = "Agregar";
            btnAgregarAutor.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarAutor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarAutor.UseVisualStyleBackColor = false;
            btnAgregarAutor.Click += btnAgregarAutor_Click;
            // 
            // btnNuevoAutor
            // 
            btnNuevoAutor.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoAutor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAutor.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoAutor.Image = (Image)resources.GetObject("btnNuevoAutor.Image");
            btnNuevoAutor.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoAutor.Location = new Point(810, 484);
            btnNuevoAutor.Name = "btnNuevoAutor";
            btnNuevoAutor.Size = new Size(150, 45);
            btnNuevoAutor.TabIndex = 45;
            btnNuevoAutor.Text = "Nuevo";
            btnNuevoAutor.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoAutor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoAutor.UseVisualStyleBackColor = false;
            btnNuevoAutor.Click += btnNuevoAutor_Click;
            // 
            // frmFormularioLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 693);
            Controls.Add(btnNuevoAutor);
            Controls.Add(btnAgregarAutor);
            Controls.Add(btnBorrar);
            Controls.Add(dgvAlmacenarAutor);
            Controls.Add(dgvAutor);
            Controls.Add(txtBuscarAutor);
            Controls.Add(cmbIdioma);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbEditorial);
            Controls.Add(lblDatosAutor);
            Controls.Add(lblDatosLibro);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblNombre);
            Controls.Add(txtNumPaginas);
            Controls.Add(txtTitulo);
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario de libros";
            ((System.ComponentModel.ISupportInitialize)pcbContenendorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAutor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacenarAutor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbContenendorCaptura;
        private PictureBox pcbContenedorCompacto;
        private TextBox textBox6;
        private TextBox txtNumPaginas;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private Label lblIdioma;
        private Label lblNumPaginas;
        private Label lblCategoria;
        private Label lblTitulo;
        private Label lblEditorial;
        private Label lblISBN;
        private Label lblNombre;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Label lblDatosLibro;
        private Label lblDatosAutor;
        private ComboBox cmbEditorial;
        private ComboBox cmbCategoria;
        private ComboBox cmbIdioma;
        private TextBox txtBuscarAutor;
        private Button btnAgregarNuevoAutor;
        private DataGridView dgvAutor;
        private DataGridView dgvAlmacenarAutor;
        private Button btnBorrar;
        private Button btnAgregarAutor;
        private Button btnNuevoAutor;
    }
}