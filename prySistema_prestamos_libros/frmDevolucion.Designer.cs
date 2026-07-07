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
            lblRegistroDevolucion = new Label();
            lblFechaDevolucion = new Label();
            lblBibliotecario = new Label();
            cmbBibliotecario = new ComboBox();
            lblMulta = new Label();
            lblLibrosVencidos = new Label();
            lblDiasRetraso = new Label();
            lblMonto = new Label();
            lblEstadoPago = new Label();
            txtLibrosVencidos = new TextBox();
            txtDiasRetraso = new TextBox();
            txtMonto = new TextBox();
            btnRegistrarDevolucion = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            dtpFechaDevolucion = new DateTimePicker();
            lblFechaPago = new Label();
            dtpFechaPago = new DateTimePicker();
            cmbEstadoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorBusqueda
            // 
            pcbContenedorBusqueda.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorBusqueda.Location = new Point(20, 2);
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
            pcbContenedorCaptura.Location = new Point(20, 410);
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
            pcbContenedorCompacto.Location = new Point(20, 295);
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
            lblBusquedaSolicitante.Location = new Point(29, 6);
            lblBusquedaSolicitante.Name = "lblBusquedaSolicitante";
            lblBusquedaSolicitante.Size = new Size(171, 19);
            lblBusquedaSolicitante.TabIndex = 3;
            lblBusquedaSolicitante.Text = "Búsqueda del solicitante";
            // 
            // txtNumControl
            // 
            txtNumControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControl.ForeColor = Color.FromArgb(31, 31, 31);
            txtNumControl.Location = new Point(37, 40);
            txtNumControl.Margin = new Padding(3, 2, 3, 2);
            txtNumControl.Multiline = true;
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(215, 24);
            txtNumControl.TabIndex = 4;
            // 
            // txtNombreSolicitante
            // 
            txtNombreSolicitante.BackColor = Color.White;
            txtNombreSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            txtNombreSolicitante.Location = new Point(327, 40);
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
            txtApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            txtApellidoPaterno.Location = new Point(632, 40);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(215, 24);
            txtApellidoPaterno.TabIndex = 6;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.WhiteSmoke;
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            txtApellidoMaterno.Location = new Point(921, 40);
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
            txtGrado.ForeColor = Color.FromArgb(31, 31, 31);
            txtGrado.Location = new Point(37, 91);
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
            txtGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            txtGrupo.Location = new Point(327, 91);
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
            txtCarrera.ForeColor = Color.FromArgb(31, 31, 31);
            txtCarrera.Location = new Point(632, 91);
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
            lblNumeroControl.ForeColor = SystemColors.ControlText;
            lblNumeroControl.Location = new Point(37, 23);
            lblNumeroControl.Name = "lblNumeroControl";
            lblNumeroControl.Size = new Size(108, 15);
            lblNumeroControl.TabIndex = 11;
            lblNumeroControl.Text = "Numero de control";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(327, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.ForeColor = SystemColors.ControlText;
            lblApellidoPaterno.Location = new Point(632, 23);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 13;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.ForeColor = SystemColors.ControlText;
            lblApellidoMaterno.Location = new Point(921, 23);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 14;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.ForeColor = SystemColors.ControlText;
            lblGrado.Location = new Point(37, 74);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(39, 15);
            lblGrado.TabIndex = 15;
            lblGrado.Text = "Grado";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.ForeColor = SystemColors.ControlText;
            lblGrupo.Location = new Point(327, 74);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 16;
            lblGrupo.Text = "Grupo";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.ForeColor = SystemColors.ControlText;
            lblCarrera.Location = new Point(632, 74);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(80, 15);
            lblCarrera.TabIndex = 17;
            lblCarrera.Text = "Carrera / Área";
            // 
            // dgvPrestamosActivos
            // 
            dgvPrestamosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosActivos.Location = new Point(37, 118);
            dgvPrestamosActivos.Margin = new Padding(3, 2, 3, 2);
            dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            dgvPrestamosActivos.RowHeadersWidth = 51;
            dgvPrestamosActivos.Size = new Size(1093, 148);
            dgvPrestamosActivos.TabIndex = 18;
            // 
            // lblRegistroDevolucion
            // 
            lblRegistroDevolucion.AutoSize = true;
            lblRegistroDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblRegistroDevolucion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroDevolucion.ForeColor = Color.FromArgb(27, 46, 107);
            lblRegistroDevolucion.Location = new Point(29, 302);
            lblRegistroDevolucion.Name = "lblRegistroDevolucion";
            lblRegistroDevolucion.Size = new Size(164, 19);
            lblRegistroDevolucion.TabIndex = 19;
            lblRegistroDevolucion.Text = "Registro de devolución";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaDevolucion.ForeColor = SystemColors.ControlText;
            lblFechaDevolucion.Location = new Point(37, 328);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(116, 15);
            lblFechaDevolucion.TabIndex = 20;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblBibliotecario
            // 
            lblBibliotecario.AutoSize = true;
            lblBibliotecario.BackColor = Color.FromArgb(250, 247, 242);
            lblBibliotecario.ForeColor = SystemColors.ControlText;
            lblBibliotecario.Location = new Point(327, 328);
            lblBibliotecario.Name = "lblBibliotecario";
            lblBibliotecario.Size = new Size(131, 15);
            lblBibliotecario.TabIndex = 21;
            lblBibliotecario.Text = "Biliotecario que registra";
            // 
            // cmbBibliotecario
            // 
            cmbBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBibliotecario.FormattingEnabled = true;
            cmbBibliotecario.Location = new Point(327, 346);
            cmbBibliotecario.Margin = new Padding(3, 2, 3, 2);
            cmbBibliotecario.Name = "cmbBibliotecario";
            cmbBibliotecario.Size = new Size(215, 23);
            cmbBibliotecario.TabIndex = 23;
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.BackColor = Color.FromArgb(250, 247, 242);
            lblMulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMulta.ForeColor = Color.FromArgb(27, 46, 107);
            lblMulta.Location = new Point(29, 418);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(115, 19);
            lblMulta.TabIndex = 24;
            lblMulta.Text = "Multa generada";
            // 
            // lblLibrosVencidos
            // 
            lblLibrosVencidos.AutoSize = true;
            lblLibrosVencidos.BackColor = Color.FromArgb(250, 247, 242);
            lblLibrosVencidos.ForeColor = SystemColors.ControlText;
            lblLibrosVencidos.Location = new Point(37, 442);
            lblLibrosVencidos.Name = "lblLibrosVencidos";
            lblLibrosVencidos.Size = new Size(89, 15);
            lblLibrosVencidos.TabIndex = 25;
            lblLibrosVencidos.Text = "Libros Vencidos";
            // 
            // lblDiasRetraso
            // 
            lblDiasRetraso.AutoSize = true;
            lblDiasRetraso.BackColor = Color.FromArgb(250, 247, 242);
            lblDiasRetraso.ForeColor = SystemColors.ControlText;
            lblDiasRetraso.Location = new Point(37, 532);
            lblDiasRetraso.Name = "lblDiasRetraso";
            lblDiasRetraso.Size = new Size(84, 15);
            lblDiasRetraso.TabIndex = 26;
            lblDiasRetraso.Text = "Dias de retraso";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.FromArgb(250, 247, 242);
            lblMonto.ForeColor = SystemColors.ControlText;
            lblMonto.Location = new Point(327, 532);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(85, 15);
            lblMonto.TabIndex = 27;
            lblMonto.Text = "Monto a pagar";
            // 
            // lblEstadoPago
            // 
            lblEstadoPago.AutoSize = true;
            lblEstadoPago.BackColor = Color.FromArgb(250, 247, 242);
            lblEstadoPago.ForeColor = SystemColors.ControlText;
            lblEstadoPago.Location = new Point(632, 532);
            lblEstadoPago.Name = "lblEstadoPago";
            lblEstadoPago.Size = new Size(88, 15);
            lblEstadoPago.TabIndex = 28;
            lblEstadoPago.Text = "Estado de pago";
            // 
            // txtLibrosVencidos
            // 
            txtLibrosVencidos.BackColor = Color.White;
            txtLibrosVencidos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLibrosVencidos.ForeColor = Color.FromArgb(31, 31, 31);
            txtLibrosVencidos.Location = new Point(38, 460);
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
            txtDiasRetraso.ForeColor = Color.FromArgb(31, 31, 31);
            txtDiasRetraso.Location = new Point(37, 550);
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
            txtMonto.ForeColor = Color.FromArgb(31, 31, 31);
            txtMonto.Location = new Point(327, 549);
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
            btnRegistrarDevolucion.Location = new Point(273, 598);
            btnRegistrarDevolucion.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(131, 34);
            btnRegistrarDevolucion.TabIndex = 35;
            btnRegistrarDevolucion.Text = "Registrar";
            btnRegistrarDevolucion.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarDevolucion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(554, 598);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 34);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(816, 598);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 34);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(38, 347);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(215, 23);
            dtpFechaDevolucion.TabIndex = 38;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaPago.ForeColor = SystemColors.ControlText;
            lblFechaPago.Location = new Point(922, 532);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 15);
            lblFechaPago.TabIndex = 39;
            lblFechaPago.Text = "Fecha de pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(922, 549);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(215, 23);
            dtpFechaPago.TabIndex = 41;
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Location = new Point(632, 553);
            cmbEstadoPago.Margin = new Padding(3, 2, 3, 2);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(215, 23);
            cmbEstadoPago.TabIndex = 42;
            // 
            // frmDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 562);
            Controls.Add(cmbEstadoPago);
            Controls.Add(dtpFechaPago);
            Controls.Add(lblFechaPago);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(txtMonto);
            Controls.Add(txtDiasRetraso);
            Controls.Add(txtLibrosVencidos);
            Controls.Add(lblEstadoPago);
            Controls.Add(lblMonto);
            Controls.Add(lblDiasRetraso);
            Controls.Add(lblLibrosVencidos);
            Controls.Add(lblMulta);
            Controls.Add(cmbBibliotecario);
            Controls.Add(lblBibliotecario);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblRegistroDevolucion);
            Controls.Add(dgvPrestamosActivos);
            Controls.Add(lblCarrera);
            Controls.Add(lblGrupo);
            Controls.Add(lblGrado);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(lblNombre);
            Controls.Add(lblNumeroControl);
            Controls.Add(txtCarrera);
            Controls.Add(txtGrupo);
            Controls.Add(txtGrado);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombreSolicitante);
            Controls.Add(txtNumControl);
            Controls.Add(lblBusquedaSolicitante);
            Controls.Add(pcbContenedorCompacto);
            Controls.Add(pcbContenedorCaptura);
            Controls.Add(pcbContenedorBusqueda);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDevolucion";
            Text = "Formulario de Devolucion";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCaptura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorCompacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblBibliotecario;
        private ComboBox cmbBibliotecario;
        private Label lblMulta;
        private Label lblLibrosVencidos;
        private Label lblDiasRetraso;
        private Label lblMonto;
        private Label lblEstadoPago;
        private TextBox txtLibrosVencidos;
        private TextBox txtDiasRetraso;
        private TextBox txtMonto;
        private Button btnRegistrarDevolucion;
        private Button btnLimpiar;
        private Button btnCancelar;
        private DateTimePicker dtpFechaDevolucion;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private ComboBox cmbEstadoPago;
    }
}