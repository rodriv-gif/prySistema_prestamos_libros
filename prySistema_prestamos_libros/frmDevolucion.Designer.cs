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
            pcbContenedorBusqueda.Location = new Point(23, 2);
            pcbContenedorBusqueda.Name = "pcbContenedorBusqueda";
            pcbContenedorBusqueda.Size = new Size(1302, 374);
            pcbContenedorBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorBusqueda.TabIndex = 0;
            pcbContenedorBusqueda.TabStop = false;
            // 
            // pcbContenedorCaptura
            // 
            pcbContenedorCaptura.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorCaptura.Location = new Point(23, 547);
            pcbContenedorCaptura.Name = "pcbContenedorCaptura";
            pcbContenedorCaptura.Size = new Size(1302, 234);
            pcbContenedorCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorCaptura.TabIndex = 1;
            pcbContenedorCaptura.TabStop = false;
            // 
            // pcbContenedorCompacto
            // 
            pcbContenedorCompacto.Image = Properties.Resources.contenedorgroupCompac;
            pcbContenedorCompacto.Location = new Point(23, 393);
            pcbContenedorCompacto.Name = "pcbContenedorCompacto";
            pcbContenedorCompacto.Size = new Size(1302, 137);
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
            lblBusquedaSolicitante.Location = new Point(33, 8);
            lblBusquedaSolicitante.Name = "lblBusquedaSolicitante";
            lblBusquedaSolicitante.Size = new Size(205, 23);
            lblBusquedaSolicitante.TabIndex = 3;
            lblBusquedaSolicitante.Text = "Búsqueda del solicitante";
            // 
            // txtNumControl
            // 
            txtNumControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControl.Location = new Point(42, 54);
            txtNumControl.Multiline = true;
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(245, 30);
            txtNumControl.TabIndex = 4;
            // 
            // txtNombreSolicitante
            // 
            txtNombreSolicitante.BackColor = Color.White;
            txtNombreSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreSolicitante.Location = new Point(374, 54);
            txtNombreSolicitante.Multiline = true;
            txtNombreSolicitante.Name = "txtNombreSolicitante";
            txtNombreSolicitante.Size = new Size(245, 30);
            txtNombreSolicitante.TabIndex = 5;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.White;
            txtApellidoPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(722, 54);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(245, 30);
            txtApellidoPaterno.TabIndex = 6;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.WhiteSmoke;
            txtApellidoMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(1053, 54);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(245, 30);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.Location = new Point(42, 121);
            txtGrado.Multiline = true;
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(245, 30);
            txtGrado.TabIndex = 8;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(374, 121);
            txtGrupo.Multiline = true;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(245, 30);
            txtGrupo.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.ForeColor = SystemColors.WindowText;
            txtCarrera.Location = new Point(722, 121);
            txtCarrera.Multiline = true;
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(245, 30);
            txtCarrera.TabIndex = 10;
            // 
            // lblNumeroControl
            // 
            lblNumeroControl.AutoSize = true;
            lblNumeroControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumeroControl.ForeColor = Color.FromArgb(31, 31, 31);
            lblNumeroControl.Location = new Point(42, 31);
            lblNumeroControl.Name = "lblNumeroControl";
            lblNumeroControl.Size = new Size(135, 20);
            lblNumeroControl.TabIndex = 11;
            lblNumeroControl.Text = "Numero de control";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(250, 247, 242);
            lblNombre.ForeColor = Color.FromArgb(31, 31, 31);
            lblNombre.Location = new Point(374, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoPaterno.Location = new Point(722, 31);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(122, 20);
            lblApellidoPaterno.TabIndex = 13;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.BackColor = Color.FromArgb(250, 247, 242);
            lblApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoMaterno.Location = new Point(1053, 31);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(126, 20);
            lblApellidoMaterno.TabIndex = 14;
            lblApellidoMaterno.Text = "Apellido materno";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.BackColor = Color.FromArgb(250, 247, 242);
            lblGrado.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrado.Location = new Point(42, 98);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(50, 20);
            lblGrado.TabIndex = 15;
            lblGrado.Text = "Grado";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.FromArgb(250, 247, 242);
            lblGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrupo.Location = new Point(374, 98);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(50, 20);
            lblGrupo.TabIndex = 16;
            lblGrupo.Text = "Grupo";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.FromArgb(250, 247, 242);
            lblCarrera.ForeColor = Color.FromArgb(31, 31, 31);
            lblCarrera.Location = new Point(722, 98);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(102, 20);
            lblCarrera.TabIndex = 17;
            lblCarrera.Text = "Carrera / Área";
            // 
            // dgvPrestamosActivos
            // 
            dgvPrestamosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosActivos.Location = new Point(42, 157);
            dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            dgvPrestamosActivos.RowHeadersWidth = 51;
            dgvPrestamosActivos.Size = new Size(1249, 197);
            dgvPrestamosActivos.TabIndex = 18;
            // 
            // lblRegistroDevolucion
            // 
            lblRegistroDevolucion.AutoSize = true;
            lblRegistroDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblRegistroDevolucion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroDevolucion.ForeColor = Color.FromArgb(27, 46, 107);
            lblRegistroDevolucion.Location = new Point(33, 403);
            lblRegistroDevolucion.Name = "lblRegistroDevolucion";
            lblRegistroDevolucion.Size = new Size(194, 23);
            lblRegistroDevolucion.TabIndex = 19;
            lblRegistroDevolucion.Text = "Registro de devolución";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaDevolucion.ForeColor = Color.FromArgb(31, 31, 31);
            lblFechaDevolucion.Location = new Point(42, 438);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(145, 20);
            lblFechaDevolucion.TabIndex = 20;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblBibliotecario
            // 
            lblBibliotecario.AutoSize = true;
            lblBibliotecario.BackColor = Color.FromArgb(250, 247, 242);
            lblBibliotecario.ForeColor = Color.FromArgb(31, 31, 31);
            lblBibliotecario.Location = new Point(374, 438);
            lblBibliotecario.Name = "lblBibliotecario";
            lblBibliotecario.Size = new Size(168, 20);
            lblBibliotecario.TabIndex = 21;
            lblBibliotecario.Text = "Biliotecario que registra";
            // 
            // cmbBibliotecario
            // 
            cmbBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBibliotecario.FormattingEnabled = true;
            cmbBibliotecario.Location = new Point(374, 461);
            cmbBibliotecario.Name = "cmbBibliotecario";
            cmbBibliotecario.Size = new Size(245, 28);
            cmbBibliotecario.TabIndex = 23;
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.BackColor = Color.FromArgb(250, 247, 242);
            lblMulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMulta.ForeColor = Color.FromArgb(27, 46, 107);
            lblMulta.Location = new Point(33, 558);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(137, 23);
            lblMulta.TabIndex = 24;
            lblMulta.Text = "Multa generada";
            // 
            // lblLibrosVencidos
            // 
            lblLibrosVencidos.AutoSize = true;
            lblLibrosVencidos.BackColor = Color.FromArgb(250, 247, 242);
            lblLibrosVencidos.ForeColor = Color.FromArgb(31, 31, 31);
            lblLibrosVencidos.Location = new Point(42, 590);
            lblLibrosVencidos.Name = "lblLibrosVencidos";
            lblLibrosVencidos.Size = new Size(112, 20);
            lblLibrosVencidos.TabIndex = 25;
            lblLibrosVencidos.Text = "Libros Vencidos";
            // 
            // lblDiasRetraso
            // 
            lblDiasRetraso.AutoSize = true;
            lblDiasRetraso.BackColor = Color.FromArgb(250, 247, 242);
            lblDiasRetraso.ForeColor = Color.FromArgb(31, 31, 31);
            lblDiasRetraso.Location = new Point(42, 709);
            lblDiasRetraso.Name = "lblDiasRetraso";
            lblDiasRetraso.Size = new Size(109, 20);
            lblDiasRetraso.TabIndex = 26;
            lblDiasRetraso.Text = "Dias de retraso";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.FromArgb(250, 247, 242);
            lblMonto.ForeColor = Color.FromArgb(31, 31, 31);
            lblMonto.Location = new Point(374, 709);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(108, 20);
            lblMonto.TabIndex = 27;
            lblMonto.Text = "Monto a pagar";
            // 
            // lblEstadoPago
            // 
            lblEstadoPago.AutoSize = true;
            lblEstadoPago.BackColor = Color.FromArgb(250, 247, 242);
            lblEstadoPago.ForeColor = Color.FromArgb(31, 31, 31);
            lblEstadoPago.Location = new Point(722, 709);
            lblEstadoPago.Name = "lblEstadoPago";
            lblEstadoPago.Size = new Size(114, 20);
            lblEstadoPago.TabIndex = 28;
            lblEstadoPago.Text = "Estado de pago";
            // 
            // txtLibrosVencidos
            // 
            txtLibrosVencidos.BackColor = Color.White;
            txtLibrosVencidos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLibrosVencidos.Location = new Point(43, 613);
            txtLibrosVencidos.Multiline = true;
            txtLibrosVencidos.Name = "txtLibrosVencidos";
            txtLibrosVencidos.Size = new Size(1231, 81);
            txtLibrosVencidos.TabIndex = 30;
            // 
            // txtDiasRetraso
            // 
            txtDiasRetraso.BackColor = Color.White;
            txtDiasRetraso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiasRetraso.Location = new Point(42, 733);
            txtDiasRetraso.Multiline = true;
            txtDiasRetraso.Name = "txtDiasRetraso";
            txtDiasRetraso.Size = new Size(245, 30);
            txtDiasRetraso.TabIndex = 31;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.White;
            txtMonto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(374, 732);
            txtMonto.Multiline = true;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(245, 30);
            txtMonto.TabIndex = 32;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(201, 168, 76);
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDevolucion.ForeColor = Color.FromArgb(17, 30, 71);
            btnRegistrarDevolucion.Image = (Image)resources.GetObject("btnRegistrarDevolucion.Image");
            btnRegistrarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarDevolucion.Location = new Point(312, 798);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(150, 45);
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
            btnLimpiar.Location = new Point(633, 798);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 45);
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
            btnCancelar.Location = new Point(932, 798);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
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
            dtpFechaDevolucion.Location = new Point(43, 463);
            dtpFechaDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(245, 27);
            dtpFechaDevolucion.TabIndex = 38;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaPago.ForeColor = Color.FromArgb(31, 31, 31);
            lblFechaPago.Location = new Point(1054, 710);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(107, 20);
            lblFechaPago.TabIndex = 39;
            lblFechaPago.Text = "Fecha de pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(1054, 732);
            dtpFechaPago.Margin = new Padding(3, 4, 3, 4);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(245, 27);
            dtpFechaPago.TabIndex = 41;
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Location = new Point(722, 737);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(245, 28);
            cmbEstadoPago.TabIndex = 42;
            // 
            // frmDevolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 848);
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