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
            pcbContenendorBusqueda.Location = new Point(27, 3);
            pcbContenendorBusqueda.Name = "pcbContenendorBusqueda";
            pcbContenendorBusqueda.Size = new Size(1302, 374);
            pcbContenendorBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenendorBusqueda.TabIndex = 3;
            pcbContenendorBusqueda.TabStop = false;
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(27, 393);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1302, 234);
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
            lblBusquedaLibro.Location = new Point(36, 11);
            lblBusquedaLibro.Name = "lblBusquedaLibro";
            lblBusquedaLibro.Size = new Size(163, 23);
            lblBusquedaLibro.TabIndex = 6;
            lblBusquedaLibro.Text = "Búsqueda de libros";
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(27, 642);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1302, 137);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 9;
            pcbContenedorCompacto.TabStop = false;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.FromArgb(250, 247, 242);
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = Color.FromArgb(31, 31, 31);
            lblISBN.Location = new Point(48, 34);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 10;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.White;
            txtISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.ForeColor = Color.FromArgb(31, 31, 31);
            txtISBN.Location = new Point(48, 57);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(245, 30);
            txtISBN.TabIndex = 11;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(48, 108);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(1249, 197);
            dgvLibros.TabIndex = 12;
            // 
            // lblLocalizacion
            // 
            lblLocalizacion.AutoSize = true;
            lblLocalizacion.BackColor = Color.FromArgb(250, 247, 242);
            lblLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            lblLocalizacion.Location = new Point(48, 311);
            lblLocalizacion.Name = "lblLocalizacion";
            lblLocalizacion.Size = new Size(91, 20);
            lblLocalizacion.TabIndex = 13;
            lblLocalizacion.Text = "Localización";
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.BackColor = Color.FromArgb(250, 247, 242);
            lblInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventario.ForeColor = Color.FromArgb(31, 31, 31);
            lblInventario.Location = new Point(719, 311);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(156, 20);
            lblInventario.TabIndex = 14;
            lblInventario.Text = "Inventario(Existencias)";
            // 
            // txtLocalizacion
            // 
            txtLocalizacion.BackColor = Color.White;
            txtLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            txtLocalizacion.Location = new Point(48, 334);
            txtLocalizacion.Name = "txtLocalizacion";
            txtLocalizacion.Size = new Size(576, 27);
            txtLocalizacion.TabIndex = 15;
            // 
            // txtInventario
            // 
            txtInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventario.ForeColor = Color.FromArgb(31, 31, 31);
            txtInventario.Location = new Point(719, 334);
            txtInventario.Multiline = true;
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(245, 30);
            txtInventario.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(17, 30, 71);
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(201, 168, 76);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(1045, 317);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 45);
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
            button2.Location = new Point(265, 789);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
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
            btnLimpiarPrestamo.Location = new Point(602, 789);
            btnLimpiarPrestamo.Name = "btnLimpiarPrestamo";
            btnLimpiarPrestamo.Size = new Size(150, 45);
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
            btnCancelarPrestamo.Location = new Point(936, 789);
            btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            btnCancelarPrestamo.Size = new Size(150, 45);
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
            lblDatosSolicitante.Location = new Point(32, 402);
            lblDatosSolicitante.Name = "lblDatosSolicitante";
            lblDatosSolicitante.Size = new Size(173, 23);
            lblDatosSolicitante.TabIndex = 21;
            lblDatosSolicitante.Text = "Datos del solicitante";
            // 
            // lblNumeroControl
            // 
            lblNumeroControl.AutoSize = true;
            lblNumeroControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumeroControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroControl.ForeColor = Color.FromArgb(31, 31, 31);
            lblNumeroControl.Location = new Point(44, 426);
            lblNumeroControl.Name = "lblNumeroControl";
            lblNumeroControl.Size = new Size(164, 20);
            lblNumeroControl.TabIndex = 22;
            lblNumeroControl.Text = "Numero de control / ID";
            // 
            // txtNumControlSolicitante
            // 
            txtNumControlSolicitante.BackColor = Color.White;
            txtNumControlSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControlSolicitante.Location = new Point(44, 451);
            txtNumControlSolicitante.Multiline = true;
            txtNumControlSolicitante.Name = "txtNumControlSolicitante";
            txtNumControlSolicitante.Size = new Size(245, 30);
            txtNumControlSolicitante.TabIndex = 23;
            // 
            // txtTipoSolicitante
            // 
            txtTipoSolicitante.BackColor = Color.White;
            txtTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoSolicitante.Location = new Point(379, 451);
            txtTipoSolicitante.Multiline = true;
            txtTipoSolicitante.Name = "txtTipoSolicitante";
            txtTipoSolicitante.Size = new Size(245, 30);
            txtTipoSolicitante.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(44, 514);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 30);
            txtNombre.TabIndex = 25;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.White;
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(379, 514);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(245, 30);
            txtApellidoPaterno.TabIndex = 26;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.White;
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(719, 514);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(245, 30);
            txtApellidoMaterno.TabIndex = 27;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.Location = new Point(44, 581);
            txtGrado.Multiline = true;
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(245, 30);
            txtGrado.TabIndex = 28;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(379, 581);
            txtGrupo.Multiline = true;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(245, 30);
            txtGrupo.TabIndex = 29;
            // 
            // lblTipoSolicitante
            // 
            lblTipoSolicitante.AutoSize = true;
            lblTipoSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            lblTipoSolicitante.Location = new Point(384, 429);
            lblTipoSolicitante.Name = "lblTipoSolicitante";
            lblTipoSolicitante.Size = new Size(132, 20);
            lblTipoSolicitante.TabIndex = 30;
            lblTipoSolicitante.Text = "Tipo de solicitante";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(31, 31, 31);
            lblNombre.Location = new Point(44, 491);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoPaterno.Location = new Point(384, 491);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(122, 20);
            lblApellidoPaterno.TabIndex = 32;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoMaterno.Location = new Point(719, 491);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(126, 20);
            lblApellidoMaterno.TabIndex = 33;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrado.Location = new Point(44, 558);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(50, 20);
            lblGrado.TabIndex = 34;
            lblGrado.Text = "Grado";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrupo.Location = new Point(384, 558);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(50, 20);
            lblGrupo.TabIndex = 35;
            lblGrupo.Text = "Grupo";
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.Location = new Point(719, 581);
            txtCarrera.Multiline = true;
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(245, 30);
            txtCarrera.TabIndex = 36;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(719, 558);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(102, 20);
            lblCarrera.TabIndex = 37;
            lblCarrera.Text = "Carrera / Área";
            // 
            // lblTipoPrestamo
            // 
            lblTipoPrestamo.AutoSize = true;
            lblTipoPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPrestamo.ForeColor = Color.FromArgb(31, 31, 31);
            lblTipoPrestamo.Location = new Point(44, 689);
            lblTipoPrestamo.Name = "lblTipoPrestamo";
            lblTipoPrestamo.Size = new Size(127, 20);
            lblTipoPrestamo.TabIndex = 38;
            lblTipoPrestamo.Text = "Tipo de préstamo";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaPrestamo.Location = new Point(379, 689);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(135, 20);
            lblFechaPrestamo.TabIndex = 39;
            lblFechaPrestamo.Text = "Fecha de préstamo";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaDevolucion.Location = new Point(719, 689);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(145, 20);
            lblFechaDevolucion.TabIndex = 40;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblBibliotecario
            // 
            lblBibliotecario.AutoSize = true;
            lblBibliotecario.BackColor = Color.FromArgb(250, 247, 242);
            lblBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBibliotecario.ForeColor = Color.FromArgb(31, 31, 31);
            lblBibliotecario.Location = new Point(1035, 689);
            lblBibliotecario.Name = "lblBibliotecario";
            lblBibliotecario.Size = new Size(177, 20);
            lblBibliotecario.TabIndex = 41;
            lblBibliotecario.Text = "Bibliotecario que registra";
            // 
            // lblDatosPrestamo
            // 
            lblDatosPrestamo.AutoSize = true;
            lblDatosPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosPrestamo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPrestamo.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosPrestamo.Location = new Point(32, 650);
            lblDatosPrestamo.Name = "lblDatosPrestamo";
            lblDatosPrestamo.Size = new Size(167, 23);
            lblDatosPrestamo.TabIndex = 46;
            lblDatosPrestamo.Text = "Datos del préstamo";
            // 
            // cmbTipoPrestamo
            // 
            cmbTipoPrestamo.BackColor = Color.White;
            cmbTipoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPrestamo.FormattingEnabled = true;
            cmbTipoPrestamo.Location = new Point(44, 715);
            cmbTipoPrestamo.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(245, 28);
            cmbTipoPrestamo.TabIndex = 47;
            // 
            // cmbBibliotecario
            // 
            cmbBibliotecario.BackColor = Color.White;
            cmbBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBibliotecario.FormattingEnabled = true;
            cmbBibliotecario.Location = new Point(1035, 713);
            cmbBibliotecario.Margin = new Padding(3, 4, 3, 4);
            cmbBibliotecario.Name = "cmbBibliotecario";
            cmbBibliotecario.Size = new Size(245, 28);
            cmbBibliotecario.TabIndex = 48;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(379, 711);
            dtpFechaPrestamo.Margin = new Padding(3, 4, 3, 4);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(245, 27);
            dtpFechaPrestamo.TabIndex = 49;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(719, 711);
            dtpFechaDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(245, 27);
            dtpFechaDevolucion.TabIndex = 50;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 848);
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