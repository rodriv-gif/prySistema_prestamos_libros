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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            cmbNombreAutor = new ComboBox();
            dataGridView1 = new DataGridView();
            btnBorrar = new Button();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            btnAgregarTrabajador = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbContenendorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pcbContenendorCaptura
            // 
            pcbContenendorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenendorCaptura.Location = new Point(27, 19);
            pcbContenendorCaptura.Name = "pcbContenendorCaptura";
            pcbContenendorCaptura.Size = new Size(1014, 390);
            pcbContenendorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenendorCaptura.TabIndex = 0;
            pcbContenendorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(27, 417);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1014, 244);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 1;
            pcbContenedorCompacto.TabStop = false;
            // 
            // txtNumPaginas
            // 
            txtNumPaginas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumPaginas.Location = new Point(755, 77);
            txtNumPaginas.Multiline = true;
            txtNumPaginas.Name = "txtNumPaginas";
            txtNumPaginas.Size = new Size(245, 30);
            txtNumPaginas.TabIndex = 22;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(411, 77);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(245, 30);
            txtTitulo.TabIndex = 20;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(61, 77);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(245, 30);
            txtISBN.TabIndex = 18;
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
            lblNombre.Location = new Point(64, 499);
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
            btnGuardar.Location = new Point(125, 683);
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
            btnCancelar.Location = new Point(773, 683);
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
            btnLimpiar.Location = new Point(456, 683);
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
            lblDatosAutor.Location = new Point(31, 426);
            lblDatosAutor.Name = "lblDatosAutor";
            lblDatosAutor.Size = new Size(134, 23);
            lblDatosAutor.TabIndex = 34;
            lblDatosAutor.Text = "Datos del autor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(61, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 28);
            comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(411, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 28);
            comboBox2.TabIndex = 36;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(755, 168);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(245, 28);
            comboBox3.TabIndex = 37;
            // 
            // cmbNombreAutor
            // 
            cmbNombreAutor.FormattingEnabled = true;
            cmbNombreAutor.Location = new Point(61, 532);
            cmbNombreAutor.Name = "cmbNombreAutor";
            cmbNombreAutor.Size = new Size(269, 28);
            cmbNombreAutor.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(320, 167);
            dataGridView1.TabIndex = 41;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(27, 46, 107);
            btnBorrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = Color.FromArgb(250, 247, 242);
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(401, 293);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 45);
            btnBorrar.TabIndex = 42;
            btnBorrar.Text = "Limpiar";
            btnBorrar.TextAlign = ContentAlignment.MiddleRight;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 499);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 43;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(376, 448);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(460, 188);
            dataGridView2.TabIndex = 44;
            // 
            // btnAgregarTrabajador
            // 
            btnAgregarTrabajador.BackColor = Color.FromArgb(27, 46, 107);
            btnAgregarTrabajador.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarTrabajador.ForeColor = Color.FromArgb(201, 168, 76);
            btnAgregarTrabajador.Image = (Image)resources.GetObject("btnAgregarTrabajador.Image");
            btnAgregarTrabajador.Location = new Point(864, 485);
            btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            btnAgregarTrabajador.Size = new Size(150, 45);
            btnAgregarTrabajador.TabIndex = 45;
            btnAgregarTrabajador.Text = "Agregar";
            btnAgregarTrabajador.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarTrabajador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarTrabajador.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(242, 196, 196);
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(122, 32, 32);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(864, 569);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 45);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmFormularioLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 753);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarTrabajador);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(btnBorrar);
            Controls.Add(dataGridView1);
            Controls.Add(cmbNombreAutor);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
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
            Text = "Formulario de libros";
            ((System.ComponentModel.ISupportInitialize)pcbContenendorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox cmbNombreAutor;
        private DataGridView dataGridView1;
        private Button btnBorrar;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Button btnAgregarTrabajador;
        private Button btnEliminar;
    }
}