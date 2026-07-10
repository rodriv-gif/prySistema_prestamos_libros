namespace prySistema_prestamos_libros
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            pcbContenendorBusqueda = new PictureBox();
            pcbContenedorCaptura = new PictureBox();
            lblBusquedaLibro = new Label();
            pcbContenedorCompacto = new PictureBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            dgvLibros = new DataGridView();
            lblLocalizacion = new Label();
            lblInventario = new Label();
            txtLocalizacion = new TextBox();
            txtInventario = new TextBox();
            btnAgregar = new Button();
            button2 = new Button();
            btnLimpiarPrestamo = new Button();
            btnCancelarPrestamo = new Button();
            lblDatosSolicitante = new Label();
            lblNumeroControl = new Label();
            txtNumControlSolicitante = new TextBox();
            txtTipoSolicitante = new TextBox();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtGrado = new TextBox();
            txtGrupo = new TextBox();
            lblTipoSolicitante = new Label();
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblGrado = new Label();
            lblGrupo = new Label();
            txtCarrera = new TextBox();
            lblCarrera = new Label();
            lblTipoPrestamo = new Label();
            lblFechaPrestamo = new Label();
            lblFechaDevolucion = new Label();
            lblBibliotecario = new Label();
            lblDatosPrestamo = new Label();
            cmbTipoPrestamo = new ComboBox();
            cmbBibliotecario = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pcbContenendorBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pcbContenendorBusqueda
            // 
            pcbContenendorBusqueda.Image = Properties.Resources.contenerdorGrupo;
            pcbContenendorBusqueda.Location = new Point(24, 2);
            pcbContenendorBusqueda.Margin = new Padding(3, 2, 3, 2);
            pcbContenendorBusqueda.Name = "pcbContenendorBusqueda";
            pcbContenendorBusqueda.Size = new Size(1139, 280);
            pcbContenendorBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenendorBusqueda.TabIndex = 3;
            pcbContenendorBusqueda.TabStop = false;
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(24, 295);
            pcbContenedorCaptura.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1139, 176);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 4;
            pcbContenedorCaptura.TabStop = false;
            // 
            // lblBusquedaLibro
            // 
            lblBusquedaLibro.AutoSize = true;
            lblBusquedaLibro.BackColor = Color.FromArgb(250, 247, 242);
            lblBusquedaLibro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusquedaLibro.ForeColor = Color.FromArgb(27, 46, 107);
            lblBusquedaLibro.Location = new Point(32, 8);
            lblBusquedaLibro.Name = "lblBusquedaLibro";
            lblBusquedaLibro.Size = new Size(137, 19);
            lblBusquedaLibro.TabIndex = 6;
            lblBusquedaLibro.Text = "Búsqueda de libros";
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(24, 482);
            pcbContenedorCompacto.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1139, 103);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 9;
            pcbContenedorCompacto.TabStop = false;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.FromArgb(250, 247, 242);
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = Color.Black;
            lblISBN.Location = new Point(42, 26);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 10;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.White;
            txtISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.ForeColor = Color.FromArgb(31, 31, 31);
            txtISBN.Location = new Point(42, 43);
            txtISBN.Margin = new Padding(3, 2, 3, 2);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(215, 24);
            txtISBN.TabIndex = 11;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(42, 81);
            dgvLibros.Margin = new Padding(3, 2, 3, 2);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(1093, 148);
            dgvLibros.TabIndex = 12;
            // 
            // lblLocalizacion
            // 
            lblLocalizacion.AutoSize = true;
            lblLocalizacion.BackColor = Color.FromArgb(250, 247, 242);
            lblLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalizacion.ForeColor = Color.Black;
            lblLocalizacion.Location = new Point(42, 233);
            lblLocalizacion.Name = "lblLocalizacion";
            lblLocalizacion.Size = new Size(72, 15);
            lblLocalizacion.TabIndex = 13;
            lblLocalizacion.Text = "Localización";
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.BackColor = Color.FromArgb(250, 247, 242);
            lblInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventario.ForeColor = Color.Black;
            lblInventario.Location = new Point(629, 233);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(124, 15);
            lblInventario.TabIndex = 14;
            lblInventario.Text = "Inventario(Existencias)";
            // 
            // txtLocalizacion
            // 
            txtLocalizacion.BackColor = Color.White;
            txtLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            txtLocalizacion.Location = new Point(42, 250);
            txtLocalizacion.Margin = new Padding(3, 2, 3, 2);
            txtLocalizacion.Name = "txtLocalizacion";
            txtLocalizacion.Size = new Size(504, 23);
            txtLocalizacion.TabIndex = 15;
            // 
            // txtInventario
            // 
            txtInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventario.ForeColor = Color.FromArgb(31, 31, 31);
            txtInventario.Location = new Point(629, 250);
            txtInventario.Margin = new Padding(3, 2, 3, 2);
            txtInventario.Multiline = true;
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(215, 24);
            txtInventario.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(17, 30, 71);
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(201, 168, 76);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(914, 238);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 34);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(201, 168, 76);
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(17, 30, 71);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(232, 592);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(131, 34);
            button2.TabIndex = 18;
            button2.Text = "Registrar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarPrestamo
            // 
            btnLimpiarPrestamo.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiarPrestamo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarPrestamo.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiarPrestamo.Image = (Image)resources.GetObject("btnLimpiarPrestamo.Image");
            btnLimpiarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarPrestamo.Location = new Point(527, 592);
            btnLimpiarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarPrestamo.Name = "btnLimpiarPrestamo";
            btnLimpiarPrestamo.Size = new Size(131, 34);
            btnLimpiarPrestamo.TabIndex = 19;
            btnLimpiarPrestamo.Text = "Limpiar";
            btnLimpiarPrestamo.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarPrestamo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPrestamo
            // 
            btnCancelarPrestamo.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelarPrestamo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarPrestamo.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelarPrestamo.Image = (Image)resources.GetObject("btnCancelarPrestamo.Image");
            btnCancelarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarPrestamo.Location = new Point(819, 592);
            btnCancelarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            btnCancelarPrestamo.Size = new Size(131, 34);
            btnCancelarPrestamo.TabIndex = 20;
            btnCancelarPrestamo.Text = "Cancelar";
            btnCancelarPrestamo.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarPrestamo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarPrestamo.UseVisualStyleBackColor = false;
            // 
            // lblDatosSolicitante
            // 
            lblDatosSolicitante.AutoSize = true;
            lblDatosSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosSolicitante.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosSolicitante.Location = new Point(28, 302);
            lblDatosSolicitante.Name = "lblDatosSolicitante";
            lblDatosSolicitante.Size = new Size(144, 19);
            lblDatosSolicitante.TabIndex = 21;
            lblDatosSolicitante.Text = "Datos del solicitante";
            // 
            // lblNumeroControl
            // 
            lblNumeroControl.AutoSize = true;
            lblNumeroControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumeroControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroControl.ForeColor = Color.Black;
            lblNumeroControl.Location = new Point(38, 320);
            lblNumeroControl.Name = "lblNumeroControl";
            lblNumeroControl.Size = new Size(130, 15);
            lblNumeroControl.TabIndex = 22;
            lblNumeroControl.Text = "Numero de control / ID";
            // 
            // txtNumControlSolicitante
            // 
            txtNumControlSolicitante.BackColor = Color.White;
            txtNumControlSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControlSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            txtNumControlSolicitante.Location = new Point(38, 338);
            txtNumControlSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtNumControlSolicitante.Multiline = true;
            txtNumControlSolicitante.Name = "txtNumControlSolicitante";
            txtNumControlSolicitante.Size = new Size(215, 24);
            txtNumControlSolicitante.TabIndex = 23;
            // 
            // txtTipoSolicitante
            // 
            txtTipoSolicitante.BackColor = Color.White;
            txtTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            txtTipoSolicitante.Location = new Point(332, 338);
            txtTipoSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtTipoSolicitante.Multiline = true;
            txtTipoSolicitante.Name = "txtTipoSolicitante";
            txtTipoSolicitante.Size = new Size(215, 24);
            txtTipoSolicitante.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.FromArgb(31, 31, 31);
            txtNombre.Location = new Point(38, 386);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 24);
            txtNombre.TabIndex = 25;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.White;
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            txtApellidoPaterno.Location = new Point(332, 386);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(215, 24);
            txtApellidoPaterno.TabIndex = 26;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.White;
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            txtApellidoMaterno.Location = new Point(629, 386);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(215, 24);
            txtApellidoMaterno.TabIndex = 27;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.ForeColor = Color.FromArgb(31, 31, 31);
            txtGrado.Location = new Point(38, 436);
            txtGrado.Margin = new Padding(3, 2, 3, 2);
            txtGrado.Multiline = true;
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(215, 24);
            txtGrado.TabIndex = 28;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            txtGrupo.Location = new Point(332, 436);
            txtGrupo.Margin = new Padding(3, 2, 3, 2);
            txtGrupo.Multiline = true;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(215, 24);
            txtGrupo.TabIndex = 29;
            // 
            // lblTipoSolicitante
            // 
            lblTipoSolicitante.AutoSize = true;
            lblTipoSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoSolicitante.ForeColor = Color.Black;
            lblTipoSolicitante.Location = new Point(336, 322);
            lblTipoSolicitante.Name = "lblTipoSolicitante";
            lblTipoSolicitante.Size = new Size(104, 15);
            lblTipoSolicitante.TabIndex = 30;
            lblTipoSolicitante.Text = "Tipo de solicitante";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(38, 368);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.ForeColor = Color.Black;
            lblApellidoPaterno.Location = new Point(336, 368);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 32;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.ForeColor = Color.Black;
            lblApellidoMaterno.Location = new Point(629, 368);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 33;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.ForeColor = Color.Black;
            lblGrado.Location = new Point(38, 418);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(39, 15);
            lblGrado.TabIndex = 34;
            lblGrado.Text = "Grado";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupo.ForeColor = Color.Black;
            lblGrupo.Location = new Point(336, 418);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 35;
            lblGrupo.Text = "Grupo";
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.ForeColor = Color.FromArgb(31, 31, 31);
            txtCarrera.Location = new Point(629, 436);
            txtCarrera.Margin = new Padding(3, 2, 3, 2);
            txtCarrera.Multiline = true;
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(215, 24);
            txtCarrera.TabIndex = 36;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrera.ForeColor = Color.Black;
            lblCarrera.Location = new Point(629, 418);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(80, 15);
            lblCarrera.TabIndex = 37;
            lblCarrera.Text = "Carrera / Área";
            // 
            // lblTipoPrestamo
            // 
            lblTipoPrestamo.AutoSize = true;
            lblTipoPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPrestamo.ForeColor = Color.Black;
            lblTipoPrestamo.Location = new Point(38, 517);
            lblTipoPrestamo.Name = "lblTipoPrestamo";
            lblTipoPrestamo.Size = new Size(100, 15);
            lblTipoPrestamo.TabIndex = 38;
            lblTipoPrestamo.Text = "Tipo de préstamo";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaPrestamo.ForeColor = Color.Black;
            lblFechaPrestamo.Location = new Point(332, 517);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(107, 15);
            lblFechaPrestamo.TabIndex = 39;
            lblFechaPrestamo.Text = "Fecha de préstamo";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaDevolucion.ForeColor = Color.Black;
            lblFechaDevolucion.Location = new Point(629, 517);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(116, 15);
            lblFechaDevolucion.TabIndex = 40;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblBibliotecario
            // 
            lblBibliotecario.AutoSize = true;
            lblBibliotecario.BackColor = Color.FromArgb(250, 247, 242);
            lblBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBibliotecario.ForeColor = Color.Black;
            lblBibliotecario.Location = new Point(906, 517);
            lblBibliotecario.Name = "lblBibliotecario";
            lblBibliotecario.Size = new Size(138, 15);
            lblBibliotecario.TabIndex = 41;
            lblBibliotecario.Text = "Bibliotecario que registra";
            // 
            // lblDatosPrestamo
            // 
            lblDatosPrestamo.AutoSize = true;
            lblDatosPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosPrestamo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPrestamo.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosPrestamo.Location = new Point(28, 488);
            lblDatosPrestamo.Name = "lblDatosPrestamo";
            lblDatosPrestamo.Size = new Size(140, 19);
            lblDatosPrestamo.TabIndex = 46;
            lblDatosPrestamo.Text = "Datos del préstamo";
            // 
            // cmbTipoPrestamo
            // 
            cmbTipoPrestamo.BackColor = Color.White;
            cmbTipoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPrestamo.ForeColor = Color.FromArgb(31, 31, 31);
            cmbTipoPrestamo.FormattingEnabled = true;
            cmbTipoPrestamo.Location = new Point(38, 536);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(215, 23);
            cmbTipoPrestamo.TabIndex = 47;
            // 
            // cmbBibliotecario
            // 
            cmbBibliotecario.BackColor = Color.White;
            cmbBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBibliotecario.ForeColor = Color.FromArgb(31, 31, 31);
            cmbBibliotecario.FormattingEnabled = true;
            cmbBibliotecario.Location = new Point(906, 535);
            cmbBibliotecario.Name = "cmbBibliotecario";
            cmbBibliotecario.Size = new Size(215, 23);
            cmbBibliotecario.TabIndex = 48;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(332, 533);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(215, 23);
            dtpFechaPrestamo.TabIndex = 49;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(629, 533);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(215, 23);
            dtpFechaDevolucion.TabIndex = 50;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 562);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbBibliotecario);
            Controls.Add(cmbTipoPrestamo);
            Controls.Add(lblDatosPrestamo);
            Controls.Add(lblBibliotecario);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(lblTipoPrestamo);
            Controls.Add(lblCarrera);
            Controls.Add(txtCarrera);
            Controls.Add(lblGrupo);
            Controls.Add(lblGrado);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(lblNombre);
            Controls.Add(lblTipoSolicitante);
            Controls.Add(txtGrupo);
            Controls.Add(txtGrado);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtTipoSolicitante);
            Controls.Add(txtNumControlSolicitante);
            Controls.Add(lblNumeroControl);
            Controls.Add(lblDatosSolicitante);
            Controls.Add(btnCancelarPrestamo);
            Controls.Add(btnLimpiarPrestamo);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(txtInventario);
            Controls.Add(txtLocalizacion);
            Controls.Add(lblInventario);
            Controls.Add(lblLocalizacion);
            Controls.Add(dgvLibros);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Controls.Add(pcbContenedorCompacto);
            Controls.Add(lblBusquedaLibro);
            Controls.Add(pcbContenedorCaptura);
            Controls.Add(pcbContenendorBusqueda);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrestamos";
            Text = "Forrmulario para registrar prestamos";
            ((System.ComponentModel.ISupportInitialize)pcbContenendorBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbContenendorBusqueda;
        private PictureBox pcbContenedorCaptura;
        private Label lblBusquedaLibro;
        private PictureBox pcbContenedorCompacto;
        private Label lblISBN;
        private TextBox txtISBN;
        private DataGridView dgvLibros;
        private Label lblLocalizacion;
        private Label lblInventario;
        private TextBox txtLocalizacion;
        private TextBox txtInventario;
        private Button btnAgregar;
        private Button button2;
        private Button btnLimpiarPrestamo;
        private Button btnCancelarPrestamo;
        private Label lblDatosSolicitante;
        private Label lblNumeroControl;
        private TextBox txtNumControlSolicitante;
        private TextBox txtTipoSolicitante;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private TextBox txtGrado;
        private TextBox txtGrupo;
        private Label lblTipoSolicitante;
        private Label lblNombre;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private Label lblGrado;
        private Label lblGrupo;
        private TextBox txtCarrera;
        private Label lblCarrera;
        private Label lblTipoPrestamo;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucion;
        private Label lblBibliotecario;
        private Label lblDatosPrestamo;
        private ComboBox cmbTipoPrestamo;
        private ComboBox cmbBibliotecario;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
    }
}