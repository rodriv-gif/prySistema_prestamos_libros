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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pcbContenendorBusqueda = new PictureBox();
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
            btnRegistrar = new Button();
            btnLimpiarPrestamo = new Button();
            btnCancelarPrestamo = new Button();
            lblTipoPrestamo = new Label();
            lblFechaPrestamo = new Label();
            lblFechaDevolucion = new Label();
            lblDatosPrestamo = new Label();
            cmbTipoPrestamo = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            lblGrupo = new Label();
            lblGrado = new Label();
            lblApellidoMaterno = new Label();
            lblApellidoPaterno = new Label();
            lblNombre = new Label();
            lblTipoSolicitante = new Label();
            txtGrupo = new TextBox();
            txtGrado = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            txtTipoSolicitante = new TextBox();
            txtNumControlSolicitante = new TextBox();
            lblNumControlSolicitante = new Label();
            lblDatosSolicitante = new Label();
            pcbContenedorCaptura = new PictureBox();
            dgvLibrosPrestar = new DataGridView();
            lblLibroPrestar = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbContenendorBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosPrestar).BeginInit();
            SuspendLayout();
            // 
            // pcbContenendorBusqueda
            // 
            pcbContenendorBusqueda.Image = Properties.Resources.contenerdorGrupo;
            pcbContenendorBusqueda.Location = new Point(95, 393);
            pcbContenendorBusqueda.Name = "pcbContenendorBusqueda";
            pcbContenendorBusqueda.Size = new Size(1302, 290);
            pcbContenendorBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenendorBusqueda.TabIndex = 3;
            pcbContenendorBusqueda.TabStop = false;
            // 
            // lblBusquedaLibro
            // 
            lblBusquedaLibro.AutoSize = true;
            lblBusquedaLibro.BackColor = Color.FromArgb(250, 247, 242);
            lblBusquedaLibro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusquedaLibro.ForeColor = Color.FromArgb(27, 46, 107);
            lblBusquedaLibro.Location = new Point(104, 401);
            lblBusquedaLibro.Name = "lblBusquedaLibro";
            lblBusquedaLibro.Size = new Size(163, 23);
            lblBusquedaLibro.TabIndex = 6;
            lblBusquedaLibro.Text = "Búsqueda de libros";
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(95, 703);
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
            lblISBN.Location = new Point(116, 424);
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
            txtISBN.Location = new Point(116, 447);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(245, 30);
            txtISBN.TabIndex = 11;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // dgvLibros
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLibros.BackgroundColor = Color.FromArgb(250, 247, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.Location = new Point(117, 483);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLibros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvLibros.Size = new Size(1188, 118);
            dgvLibros.TabIndex = 12;
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
            // 
            // lblLocalizacion
            // 
            lblLocalizacion.AutoSize = true;
            lblLocalizacion.BackColor = Color.FromArgb(250, 247, 242);
            lblLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            lblLocalizacion.Location = new Point(112, 613);
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
            lblInventario.Location = new Point(787, 613);
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
            txtLocalizacion.Location = new Point(116, 636);
            txtLocalizacion.Name = "txtLocalizacion";
            txtLocalizacion.Size = new Size(576, 27);
            txtLocalizacion.TabIndex = 15;
            // 
            // txtInventario
            // 
            txtInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventario.ForeColor = Color.FromArgb(31, 31, 31);
            txtInventario.Location = new Point(787, 636);
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
            btnAgregar.Location = new Point(1155, 613);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 45);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(201, 168, 76);
            btnRegistrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(17, 30, 71);
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(337, 870);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 45);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarPrestamo
            // 
            btnLimpiarPrestamo.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiarPrestamo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarPrestamo.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiarPrestamo.Image = (Image)resources.GetObject("btnLimpiarPrestamo.Image");
            btnLimpiarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarPrestamo.Location = new Point(679, 870);
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
            btnCancelarPrestamo.Location = new Point(1016, 870);
            btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            btnCancelarPrestamo.Size = new Size(150, 45);
            btnCancelarPrestamo.TabIndex = 20;
            btnCancelarPrestamo.Text = "Cancelar";
            btnCancelarPrestamo.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarPrestamo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarPrestamo.UseVisualStyleBackColor = false;
            // 
            // lblTipoPrestamo
            // 
            lblTipoPrestamo.AutoSize = true;
            lblTipoPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPrestamo.ForeColor = Color.FromArgb(31, 31, 31);
            lblTipoPrestamo.Location = new Point(112, 750);
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
            lblFechaPrestamo.Location = new Point(447, 750);
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
            lblFechaDevolucion.Location = new Point(787, 750);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(145, 20);
            lblFechaDevolucion.TabIndex = 40;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblDatosPrestamo
            // 
            lblDatosPrestamo.AutoSize = true;
            lblDatosPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosPrestamo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPrestamo.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosPrestamo.Location = new Point(100, 711);
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
            cmbTipoPrestamo.Location = new Point(112, 776);
            cmbTipoPrestamo.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(245, 28);
            cmbTipoPrestamo.TabIndex = 47;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(447, 772);
            dtpFechaPrestamo.Margin = new Padding(3, 4, 3, 4);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(245, 27);
            dtpFechaPrestamo.TabIndex = 49;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(787, 772);
            dtpFechaDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(245, 27);
            dtpFechaDevolucion.TabIndex = 50;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(787, 177);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(102, 20);
            lblCarrera.TabIndex = 68;
            lblCarrera.Text = "Carrera / Área";
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.ForeColor = Color.Black;
            txtCarrera.Location = new Point(787, 200);
            txtCarrera.Multiline = true;
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(245, 30);
            txtCarrera.TabIndex = 67;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrupo.Location = new Point(452, 177);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(50, 20);
            lblGrupo.TabIndex = 66;
            lblGrupo.Text = "Grupo";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrado.Location = new Point(112, 177);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(50, 20);
            lblGrado.TabIndex = 65;
            lblGrado.Text = "Grado";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoMaterno.Location = new Point(787, 110);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(126, 20);
            lblApellidoMaterno.TabIndex = 64;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoPaterno.Location = new Point(452, 110);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(122, 20);
            lblApellidoPaterno.TabIndex = 63;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(31, 31, 31);
            lblNombre.Location = new Point(112, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 62;
            lblNombre.Text = "Nombre";
            // 
            // lblTipoSolicitante
            // 
            lblTipoSolicitante.AutoSize = true;
            lblTipoSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            lblTipoSolicitante.Location = new Point(452, 48);
            lblTipoSolicitante.Name = "lblTipoSolicitante";
            lblTipoSolicitante.Size = new Size(132, 20);
            lblTipoSolicitante.TabIndex = 61;
            lblTipoSolicitante.Text = "Tipo de solicitante";
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.ForeColor = Color.Black;
            txtGrupo.Location = new Point(447, 200);
            txtGrupo.Multiline = true;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(245, 30);
            txtGrupo.TabIndex = 60;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.ForeColor = Color.Black;
            txtGrado.Location = new Point(112, 200);
            txtGrado.Multiline = true;
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(245, 30);
            txtGrado.TabIndex = 59;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.White;
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.ForeColor = Color.Black;
            txtApellidoMaterno.Location = new Point(787, 133);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(245, 30);
            txtApellidoMaterno.TabIndex = 58;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.White;
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.ForeColor = Color.Black;
            txtApellidoPaterno.Location = new Point(447, 133);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(245, 30);
            txtApellidoPaterno.TabIndex = 57;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(112, 133);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(245, 30);
            txtNombre.TabIndex = 56;
            // 
            // txtTipoSolicitante
            // 
            txtTipoSolicitante.BackColor = Color.White;
            txtTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoSolicitante.ForeColor = Color.Black;
            txtTipoSolicitante.Location = new Point(447, 70);
            txtTipoSolicitante.Multiline = true;
            txtTipoSolicitante.Name = "txtTipoSolicitante";
            txtTipoSolicitante.Size = new Size(245, 30);
            txtTipoSolicitante.TabIndex = 55;
            // 
            // txtNumControlSolicitante
            // 
            txtNumControlSolicitante.BackColor = Color.White;
            txtNumControlSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControlSolicitante.Location = new Point(112, 70);
            txtNumControlSolicitante.Multiline = true;
            txtNumControlSolicitante.Name = "txtNumControlSolicitante";
            txtNumControlSolicitante.Size = new Size(245, 30);
            txtNumControlSolicitante.TabIndex = 54;
            txtNumControlSolicitante.TextChanged += txtNumControlSolicitante_TextChanged;
            // 
            // lblNumControlSolicitante
            // 
            lblNumControlSolicitante.AutoSize = true;
            lblNumControlSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblNumControlSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumControlSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            lblNumControlSolicitante.Location = new Point(112, 45);
            lblNumControlSolicitante.Name = "lblNumControlSolicitante";
            lblNumControlSolicitante.Size = new Size(211, 20);
            lblNumControlSolicitante.TabIndex = 53;
            lblNumControlSolicitante.Text = "Numero de control / Matricula";
            // 
            // lblDatosSolicitante
            // 
            lblDatosSolicitante.AutoSize = true;
            lblDatosSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosSolicitante.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosSolicitante.Location = new Point(100, 21);
            lblDatosSolicitante.Name = "lblDatosSolicitante";
            lblDatosSolicitante.Size = new Size(173, 23);
            lblDatosSolicitante.TabIndex = 52;
            lblDatosSolicitante.Text = "Datos del solicitante";
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(95, 12);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1302, 360);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 51;
            pcbContenedorCaptura.TabStop = false;
            // 
            // dgvLibrosPrestar
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(221, 214, 202);
            dgvLibrosPrestar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLibrosPrestar.BackgroundColor = Color.FromArgb(250, 247, 242);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLibrosPrestar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLibrosPrestar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLibrosPrestar.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLibrosPrestar.EnableHeadersVisualStyles = false;
            dgvLibrosPrestar.Location = new Point(121, 270);
            dgvLibrosPrestar.Name = "dgvLibrosPrestar";
            dgvLibrosPrestar.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLibrosPrestar.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvLibrosPrestar.Size = new Size(911, 83);
            dgvLibrosPrestar.TabIndex = 70;
            // 
            // lblLibroPrestar
            // 
            lblLibroPrestar.AutoSize = true;
            lblLibroPrestar.BackColor = Color.FromArgb(250, 247, 242);
            lblLibroPrestar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLibroPrestar.Location = new Point(117, 247);
            lblLibroPrestar.Name = "lblLibroPrestar";
            lblLibroPrestar.Size = new Size(111, 20);
            lblLibroPrestar.TabIndex = 71;
            lblLibroPrestar.Text = "Libros a prestar";
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 938);
            Controls.Add(lblLibroPrestar);
            Controls.Add(dgvLibrosPrestar);
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
            Controls.Add(lblNumControlSolicitante);
            Controls.Add(lblDatosSolicitante);
            Controls.Add(pcbContenedorCaptura);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbTipoPrestamo);
            Controls.Add(lblDatosPrestamo);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(lblTipoPrestamo);
            Controls.Add(btnCancelarPrestamo);
            Controls.Add(btnLimpiarPrestamo);
            Controls.Add(btnRegistrar);
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
            Controls.Add(pcbContenendorBusqueda);
            Name = "frmPrestamos";
            Text = "Forrmulario para registrar prestamos";
            Load += frmPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)pcbContenendorBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosPrestar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbContenendorBusqueda;
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
        private Button btnRegistrar;
        private Button btnLimpiarPrestamo;
        private Button btnCancelarPrestamo;
        private Label lblTipoPrestamo;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucion;
        private Label lblBibliotecario;
        private Label lblDatosPrestamo;
        private ComboBox cmbTipoPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Label lblCarrera;
        private TextBox txtCarrera;
        private Label lblGrupo;
        private Label lblGrado;
        private Label lblApellidoMaterno;
        private Label lblApellidoPaterno;
        private Label lblNombre;
        private Label lblTipoSolicitante;
        private TextBox txtGrupo;
        private TextBox txtGrado;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombre;
        private TextBox txtTipoSolicitante;
        private TextBox txtNumControlSolicitante;
        private Label lblNumControlSolicitante;
        private Label lblDatosSolicitante;
        private PictureBox pcbContenedorCaptura;
        private TextBox txtBibliotecario;
        private DataGridView dgvLibrosPrestar;
        private Label lblLibroPrestar;
    }
}