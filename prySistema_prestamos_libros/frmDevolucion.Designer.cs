namespace prySistema_prestamos_libros
{
    partial class frmDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucion));
            pcbContenedorBusqueda = new PictureBox();
            pcbContenedorCaptura = new PictureBox();
            pcbContenedorCompacto = new PictureBox();
            lblBusquedaSolicitante = new Label();
            txtNumControl = new TextBox();
            txtNombreSolicitante = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtGrado = new TextBox();
            txtGrupo = new TextBox();
            txtCarrera = new TextBox();
            lblNumeroControl = new Label();
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblGrado = new Label();
            lblGrupo = new Label();
            lblCarrera = new Label();
            dgvPrestamosActivos = new DataGridView();
            colSeleccionar = new DataGridViewCheckBoxColumn();
            lblRegistroDevolucion = new Label();
            lblFechaDevolucion = new Label();
            lblMulta = new Label();
            lblLibrosVencidos = new Label();
            lblDiasRetraso = new Label();
            lblMonto = new Label();
            txtLibrosVencidos = new TextBox();
            txtDiasRetraso = new TextBox();
            txtMonto = new TextBox();
            btnRegistrarDevolucion = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            dtpFechaDevolucion = new DateTimePicker();
            lblFechaPago = new Label();
            dtpFechaPago = new DateTimePicker();
            cmbEstadoPrestamo = new ComboBox();
            lblEstadoPrestamo = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbContenedorBusqueda
            // 
            pcbContenedorBusqueda.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorBusqueda.Location = new Point(4, 0);
            pcbContenedorBusqueda.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorBusqueda.Name = "pcbContenedorBusqueda";
            pcbContenedorBusqueda.Size = new Size(1139, 280);
            pcbContenedorBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorBusqueda.TabIndex = 0;
            pcbContenedorBusqueda.TabStop = false;
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(4, 409);
            pcbContenedorCaptura.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1139, 176);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 1;
            pcbContenedorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(4, 293);
            pcbContenedorCompacto.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1139, 103);
            pcbContenedorCompacto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCompacto.TabIndex = 2;
            pcbContenedorCompacto.TabStop = false;
            // 
            // lblBusquedaSolicitante
            // 
            lblBusquedaSolicitante.AutoSize = true;
            lblBusquedaSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblBusquedaSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusquedaSolicitante.ForeColor = Color.FromArgb(27, 46, 107);
            lblBusquedaSolicitante.Location = new Point(13, 4);
            lblBusquedaSolicitante.Name = "lblBusquedaSolicitante";
            lblBusquedaSolicitante.Size = new Size(171, 19);
            lblBusquedaSolicitante.TabIndex = 3;
            lblBusquedaSolicitante.Text = "Búsqueda del solicitante";
            // 
            // txtNumControl
            // 
            txtNumControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControl.Location = new Point(21, 39);
            txtNumControl.Margin = new Padding(3, 2, 3, 2);
            txtNumControl.Multiline = true;
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(215, 24);
            txtNumControl.TabIndex = 4;
            txtNumControl.TextChanged += txtNumControl_TextChanged;
            // 
            // txtNombreSolicitante
            // 
            txtNombreSolicitante.BackColor = Color.White;
            txtNombreSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreSolicitante.Location = new Point(312, 39);
            txtNombreSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtNombreSolicitante.Multiline = true;
            txtNombreSolicitante.Name = "txtNombreSolicitante";
            txtNombreSolicitante.Size = new Size(215, 24);
            txtNombreSolicitante.TabIndex = 5;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.White;
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(616, 39);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(215, 24);
            txtApellidoPaterno.TabIndex = 6;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.White;
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(906, 39);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(215, 24);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.Location = new Point(21, 89);
            txtGrado.Margin = new Padding(3, 2, 3, 2);
            txtGrado.Multiline = true;
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(215, 24);
            txtGrado.TabIndex = 8;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(312, 89);
            txtGrupo.Margin = new Padding(3, 2, 3, 2);
            txtGrupo.Multiline = true;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(215, 24);
            txtGrupo.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.ForeColor = SystemColors.WindowText;
            txtCarrera.Location = new Point(616, 89);
            txtCarrera.Margin = new Padding(3, 2, 3, 2);
            txtCarrera.Multiline = true;
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(215, 24);
            txtCarrera.TabIndex = 10;
            // 
            // lblNumeroControl
            // 
            lblNumeroControl.AutoSize = true;
            lblNumeroControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumeroControl.ForeColor = Color.FromArgb(31, 31, 31);
            lblNumeroControl.Location = new Point(21, 22);
            lblNumeroControl.Name = "lblNumeroControl";
            lblNumeroControl.Size = new Size(163, 15);
            lblNumeroControl.TabIndex = 11;
            lblNumeroControl.Text = "Numero de control/Matricula";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.ForeColor = Color.FromArgb(31, 31, 31);
            lblNombre.Location = new Point(312, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoPaterno.Location = new Point(616, 22);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 13;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoMaterno.Location = new Point(906, 22);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 14;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrado.Location = new Point(21, 72);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(39, 15);
            lblGrado.TabIndex = 15;
            lblGrado.Text = "Grado";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrupo.Location = new Point(312, 72);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 16;
            lblGrupo.Text = "Grupo";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.ForeColor = Color.FromArgb(31, 31, 31);
            lblCarrera.Location = new Point(616, 72);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(80, 15);
            lblCarrera.TabIndex = 17;
            lblCarrera.Text = "Carrera / Área";
            // 
            // dgvPrestamosActivos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dgvPrestamosActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamosActivos.BackgroundColor = Color.FromArgb(250, 247, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPrestamosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPrestamosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosActivos.Columns.AddRange(new DataGridViewColumn[] { colSeleccionar });
            dgvPrestamosActivos.EnableHeadersVisualStyles = false;
            dgvPrestamosActivos.Location = new Point(21, 116);
            dgvPrestamosActivos.Margin = new Padding(3, 2, 3, 2);
            dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            dgvPrestamosActivos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPrestamosActivos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPrestamosActivos.Size = new Size(1093, 148);
            dgvPrestamosActivos.TabIndex = 18;
            dgvPrestamosActivos.CellValueChanged += dgvPrestamosActivos_CellValueChanged;
            dgvPrestamosActivos.CurrentCellDirtyStateChanged += dgvPrestamosActivos_CurrentCellDirtyStateChanged;
            dgvPrestamosActivos.SelectionChanged += dgvPrestamosActivos_SelectionChanged;
            // 
            // colSeleccionar
            // 
            colSeleccionar.HeaderText = "Seleccionar";
            colSeleccionar.MinimumWidth = 6;
            colSeleccionar.Name = "colSeleccionar";
            colSeleccionar.Width = 125;
            // 
            // lblRegistroDevolucion
            // 
            lblRegistroDevolucion.AutoSize = true;
            lblRegistroDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblRegistroDevolucion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroDevolucion.ForeColor = Color.FromArgb(27, 46, 107);
            lblRegistroDevolucion.Location = new Point(13, 301);
            lblRegistroDevolucion.Name = "lblRegistroDevolucion";
            lblRegistroDevolucion.Size = new Size(164, 19);
            lblRegistroDevolucion.TabIndex = 19;
            lblRegistroDevolucion.Text = "Registro de devolución";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaDevolucion.ForeColor = Color.FromArgb(31, 31, 31);
            lblFechaDevolucion.Location = new Point(21, 327);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(116, 15);
            lblFechaDevolucion.TabIndex = 20;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.BackColor = Color.FromArgb(250, 247, 242);
            lblMulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMulta.ForeColor = Color.FromArgb(27, 46, 107);
            lblMulta.Location = new Point(13, 417);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(115, 19);
            lblMulta.TabIndex = 24;
            lblMulta.Text = "Multa generada";
            // 
            // lblLibrosVencidos
            // 
            lblLibrosVencidos.AutoSize = true;
            lblLibrosVencidos.BackColor = Color.FromArgb(250, 247, 242);
            lblLibrosVencidos.ForeColor = Color.FromArgb(31, 31, 31);
            lblLibrosVencidos.Location = new Point(21, 441);
            lblLibrosVencidos.Name = "lblLibrosVencidos";
            lblLibrosVencidos.Size = new Size(89, 15);
            lblLibrosVencidos.TabIndex = 25;
            lblLibrosVencidos.Text = "Libros Vencidos";
            // 
            // lblDiasRetraso
            // 
            lblDiasRetraso.AutoSize = true;
            lblDiasRetraso.BackColor = Color.FromArgb(250, 247, 242);
            lblDiasRetraso.ForeColor = Color.FromArgb(31, 31, 31);
            lblDiasRetraso.Location = new Point(21, 530);
            lblDiasRetraso.Name = "lblDiasRetraso";
            lblDiasRetraso.Size = new Size(84, 15);
            lblDiasRetraso.TabIndex = 26;
            lblDiasRetraso.Text = "Dias de retraso";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.FromArgb(250, 247, 242);
            lblMonto.ForeColor = Color.FromArgb(31, 31, 31);
            lblMonto.Location = new Point(312, 530);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(85, 15);
            lblMonto.TabIndex = 27;
            lblMonto.Text = "Monto a pagar";
            // 
            // txtLibrosVencidos
            // 
            txtLibrosVencidos.BackColor = Color.White;
            txtLibrosVencidos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLibrosVencidos.Location = new Point(22, 458);
            txtLibrosVencidos.Margin = new Padding(3, 2, 3, 2);
            txtLibrosVencidos.Multiline = true;
            txtLibrosVencidos.Name = "txtLibrosVencidos";
            txtLibrosVencidos.Size = new Size(1078, 62);
            txtLibrosVencidos.TabIndex = 30;
            // 
            // txtDiasRetraso
            // 
            txtDiasRetraso.BackColor = Color.White;
            txtDiasRetraso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiasRetraso.Location = new Point(21, 548);
            txtDiasRetraso.Margin = new Padding(3, 2, 3, 2);
            txtDiasRetraso.Multiline = true;
            txtDiasRetraso.Name = "txtDiasRetraso";
            txtDiasRetraso.Size = new Size(215, 24);
            txtDiasRetraso.TabIndex = 31;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.White;
            txtMonto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(312, 548);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Multiline = true;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(215, 24);
            txtMonto.TabIndex = 32;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(201, 168, 76);
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDevolucion.ForeColor = Color.FromArgb(17, 30, 71);
            btnRegistrarDevolucion.Image = (Image)resources.GetObject("btnRegistrarDevolucion.Image");
            btnRegistrarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarDevolucion.Location = new Point(298, 614);
            btnRegistrarDevolucion.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(131, 34);
            btnRegistrarDevolucion.TabIndex = 35;
            btnRegistrarDevolucion.Text = "Registrar";
            btnRegistrarDevolucion.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarDevolucion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(597, 614);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 34);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(892, 614);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 34);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(22, 346);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(215, 23);
            dtpFechaDevolucion.TabIndex = 38;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaPago.ForeColor = Color.FromArgb(31, 31, 31);
            lblFechaPago.Location = new Point(616, 530);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 15);
            lblFechaPago.TabIndex = 39;
            lblFechaPago.Text = "Fecha de pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(616, 546);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(215, 23);
            dtpFechaPago.TabIndex = 41;
            // 
            // cmbEstadoPrestamo
            // 
            cmbEstadoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstadoPrestamo.FormattingEnabled = true;
            cmbEstadoPrestamo.Location = new Point(312, 347);
            cmbEstadoPrestamo.Margin = new Padding(3, 2, 3, 2);
            cmbEstadoPrestamo.Name = "cmbEstadoPrestamo";
            cmbEstadoPrestamo.Size = new Size(215, 23);
            cmbEstadoPrestamo.TabIndex = 43;
            // 
            // lblEstadoPrestamo
            // 
            lblEstadoPrestamo.AutoSize = true;
            lblEstadoPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblEstadoPrestamo.ForeColor = Color.FromArgb(31, 31, 31);
            lblEstadoPrestamo.Location = new Point(312, 330);
            lblEstadoPrestamo.Name = "lblEstadoPrestamo";
            lblEstadoPrestamo.Size = new Size(114, 15);
            lblEstadoPrestamo.TabIndex = 44;
            lblEstadoPrestamo.Text = "Estado del préstamo";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEstadoPrestamo);
            panel1.Controls.Add(cmbEstadoPrestamo);
            panel1.Controls.Add(dtpFechaPago);
            panel1.Controls.Add(lblFechaPago);
            panel1.Controls.Add(dtpFechaDevolucion);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(txtDiasRetraso);
            panel1.Controls.Add(txtLibrosVencidos);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lblDiasRetraso);
            panel1.Controls.Add(lblLibrosVencidos);
            panel1.Controls.Add(lblMulta);
            panel1.Controls.Add(lblFechaDevolucion);
            panel1.Controls.Add(lblRegistroDevolucion);
            panel1.Controls.Add(dgvPrestamosActivos);
            panel1.Controls.Add(lblCarrera);
            panel1.Controls.Add(lblGrupo);
            panel1.Controls.Add(lblGrado);
            panel1.Controls.Add(lblApellidoMaterno);
            panel1.Controls.Add(lblApellidoPaterno);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblNumeroControl);
            panel1.Controls.Add(txtCarrera);
            panel1.Controls.Add(txtGrupo);
            panel1.Controls.Add(txtGrado);
            panel1.Controls.Add(txtApellidoMaterno);
            panel1.Controls.Add(txtApellidoPaterno);
            panel1.Controls.Add(txtNombreSolicitante);
            panel1.Controls.Add(txtNumControl);
            panel1.Controls.Add(lblBusquedaSolicitante);
            panel1.Controls.Add(pcbContenedorCompacto);
            panel1.Controls.Add(pcbContenedorCaptura);
            panel1.Controls.Add(pcbContenedorBusqueda);
            panel1.Location = new Point(80, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 588);
            panel1.TabIndex = 45;
            // 
            // frmDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1199, 670);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrarDevolucion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDevolucion";
            Text = "Formulario de Devolucion";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbContenedorBusqueda;
        private PictureBox pcbContenedorCaptura;
        private PictureBox pcbContenedorCompacto;
        private Label lblBusquedaSolicitante;
        private TextBox txtNumControl;
        private TextBox txtNombreSolicitante;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private TextBox txtGrado;
        private TextBox txtGrupo;
        private TextBox txtCarrera;
        private Label lblNumeroControl;
        private Label lblNombre;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private Label lblGrado;
        private Label lblGrupo;
        private Label lblCarrera;
        private DataGridView dgvPrestamosActivos;
        private Label lblRegistroDevolucion;
        private Label lblFechaDevolucion;
        private Label lblMulta;
        private Label lblLibrosVencidos;
        private Label lblDiasRetraso;
        private Label lblMonto;
        private TextBox txtLibrosVencidos;
        private TextBox txtDiasRetraso;
        private TextBox txtMonto;
        private Button btnRegistrarDevolucion;
        private Button btnLimpiar;
        private Button btnCancelar;
        private DateTimePicker dtpFechaDevolucion;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private DataGridViewCheckBoxColumn colSeleccionar;
        private ComboBox cmbEstadoPrestamo;
        private Label lblEstadoPrestamo;
        private Panel panel1;
    }
}