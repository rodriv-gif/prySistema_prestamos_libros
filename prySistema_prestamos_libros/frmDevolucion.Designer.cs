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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            txtNombreSolicitante = new TextBox();
            txtApPaternoSolic = new TextBox();
            txtApMaternoSolic = new TextBox();
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
            label9 = new Label();
            lblFechaDev = new Label();
            lblBibliotecarioReg = new Label();
            cmbBibliotecario = new ComboBox();
            label12 = new Label();
            lblLibrosVencidos = new Label();
            lblDiasRetraso = new Label();
            lblMonto = new Label();
            lblEstado = new Label();
            label17 = new Label();
            txtLibrosVencidos = new TextBox();
            txtDiasRetraso = new TextBox();
            txtMonto = new TextBox();
            btnRegistrarDevolucion = new Button();
            btnLimpiarDevolucion = new Button();
            btnCancelarDevolucion = new Button();
            dtpFechaDevolucion = new DateTimePicker();
            lblFechaPago = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(75, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1454, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.contenerdorGrupo;
            pictureBox2.Location = new Point(75, 649);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1454, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.contenedorgroupCompac;
            pictureBox3.Location = new Point(75, 518);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1454, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 247, 242);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(27, 46, 107);
            label1.Location = new Point(94, 21);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 3;
            label1.Text = "Búsqueda del solicitante";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(85, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 30);
            textBox1.TabIndex = 4;
            // 
            // txtNombreSolicitante
            // 
            txtNombreSolicitante.BackColor = Color.White;
            txtNombreSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreSolicitante.Location = new Point(85, 123);
            txtNombreSolicitante.Name = "txtNombreSolicitante";
            txtNombreSolicitante.Size = new Size(219, 30);
            txtNombreSolicitante.TabIndex = 5;
            // 
            // txtApPaternoSolic
            // 
            txtApPaternoSolic.BackColor = Color.White;
            txtApPaternoSolic.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApPaternoSolic.Location = new Point(417, 123);
            txtApPaternoSolic.Name = "txtApPaternoSolic";
            txtApPaternoSolic.Size = new Size(219, 30);
            txtApPaternoSolic.TabIndex = 6;
            // 
            // txtApMaternoSolic
            // 
            txtApMaternoSolic.BackColor = Color.WhiteSmoke;
            txtApMaternoSolic.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApMaternoSolic.Location = new Point(765, 123);
            txtApMaternoSolic.Name = "txtApMaternoSolic";
            txtApMaternoSolic.Size = new Size(219, 30);
            txtApMaternoSolic.TabIndex = 7;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.Location = new Point(85, 179);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(219, 30);
            txtGrado.TabIndex = 8;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(417, 179);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(219, 30);
            txtGrupo.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.ForeColor = SystemColors.WindowText;
            txtCarrera.Location = new Point(765, 179);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(219, 30);
            txtCarrera.TabIndex = 10;
            // 
            // lblNumeroControl
            // 
            lblNumeroControl.AutoSize = true;
            lblNumeroControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumeroControl.ForeColor = Color.FromArgb(31, 31, 31);
            lblNumeroControl.Location = new Point(85, 44);
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
            lblNombre.Location = new Point(85, 100);
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
            lblApellidoPaterno.Location = new Point(417, 100);
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
            lblApellidoMaterno.Location = new Point(765, 100);
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
            lblGrado.Location = new Point(85, 156);
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
            lblGrupo.Location = new Point(417, 156);
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
            lblCarrera.Location = new Point(765, 156);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(102, 20);
            lblCarrera.TabIndex = 17;
            lblCarrera.Text = "Carrera / Área";
            // 
            // dgvPrestamosActivos
            // 
            dgvPrestamosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosActivos.Location = new Point(94, 219);
            dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            dgvPrestamosActivos.RowHeadersWidth = 51;
            dgvPrestamosActivos.Size = new Size(1427, 263);
            dgvPrestamosActivos.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(250, 247, 242);
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(27, 46, 107);
            label9.Location = new Point(85, 528);
            label9.Name = "label9";
            label9.Size = new Size(194, 23);
            label9.TabIndex = 19;
            label9.Text = "Registro de devolución";
            // 
            // lblFechaDev
            // 
            lblFechaDev.AutoSize = true;
            lblFechaDev.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaDev.ForeColor = Color.FromArgb(31, 31, 31);
            lblFechaDev.Location = new Point(94, 563);
            lblFechaDev.Name = "lblFechaDev";
            lblFechaDev.Size = new Size(145, 20);
            lblFechaDev.TabIndex = 20;
            lblFechaDev.Text = "Fecha de devolución";
            // 
            // lblBibliotecarioReg
            // 
            lblBibliotecarioReg.AutoSize = true;
            lblBibliotecarioReg.BackColor = Color.FromArgb(250, 247, 242);
            lblBibliotecarioReg.ForeColor = Color.FromArgb(31, 31, 31);
            lblBibliotecarioReg.Location = new Point(426, 563);
            lblBibliotecarioReg.Name = "lblBibliotecarioReg";
            lblBibliotecarioReg.Size = new Size(168, 20);
            lblBibliotecarioReg.TabIndex = 21;
            lblBibliotecarioReg.Text = "Biliotecario que registra";
            // 
            // cmbBibliotecario
            // 
            cmbBibliotecario.FormattingEnabled = true;
            cmbBibliotecario.Location = new Point(426, 588);
            cmbBibliotecario.Name = "cmbBibliotecario";
            cmbBibliotecario.Size = new Size(230, 28);
            cmbBibliotecario.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(250, 247, 242);
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(27, 46, 107);
            label12.Location = new Point(85, 662);
            label12.Name = "label12";
            label12.Size = new Size(137, 23);
            label12.TabIndex = 24;
            label12.Text = "Multa generada";
            // 
            // lblLibrosVencidos
            // 
            lblLibrosVencidos.AutoSize = true;
            lblLibrosVencidos.BackColor = Color.FromArgb(250, 247, 242);
            lblLibrosVencidos.ForeColor = Color.FromArgb(31, 31, 31);
            lblLibrosVencidos.Location = new Point(94, 685);
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
            lblDiasRetraso.Location = new Point(94, 792);
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
            lblMonto.Location = new Point(426, 792);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(108, 20);
            lblMonto.TabIndex = 27;
            lblMonto.Text = "Monto a pagar";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.FromArgb(250, 247, 242);
            lblEstado.ForeColor = Color.FromArgb(31, 31, 31);
            lblEstado.Location = new Point(774, 792);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(114, 20);
            lblEstado.TabIndex = 28;
            lblEstado.Text = "Estado de pago";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(250, 247, 242);
            label17.Location = new Point(1105, 772);
            label17.Name = "label17";
            label17.Size = new Size(145, 20);
            label17.TabIndex = 29;
            label17.Text = "Fecha de devolución";
            // 
            // txtLibrosVencidos
            // 
            txtLibrosVencidos.BackColor = Color.White;
            txtLibrosVencidos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLibrosVencidos.Location = new Point(94, 708);
            txtLibrosVencidos.Multiline = true;
            txtLibrosVencidos.Name = "txtLibrosVencidos";
            txtLibrosVencidos.Size = new Size(1231, 81);
            txtLibrosVencidos.TabIndex = 30;
            // 
            // txtDiasRetraso
            // 
            txtDiasRetraso.BackColor = Color.White;
            txtDiasRetraso.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiasRetraso.Location = new Point(94, 816);
            txtDiasRetraso.Name = "txtDiasRetraso";
            txtDiasRetraso.Size = new Size(219, 30);
            txtDiasRetraso.TabIndex = 31;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.White;
            txtMonto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(426, 816);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(219, 30);
            txtMonto.TabIndex = 32;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(201, 168, 76);
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDevolucion.ForeColor = Color.FromArgb(17, 30, 71);
            btnRegistrarDevolucion.Image = (Image)resources.GetObject("btnRegistrarDevolucion.Image");
            btnRegistrarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarDevolucion.Location = new Point(417, 906);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(150, 45);
            btnRegistrarDevolucion.TabIndex = 35;
            btnRegistrarDevolucion.Text = "Registrar";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarDevolucion
            // 
            btnLimpiarDevolucion.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarDevolucion.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiarDevolucion.Image = Properties.Resources.Limpiar;
            btnLimpiarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarDevolucion.Location = new Point(684, 906);
            btnLimpiarDevolucion.Name = "btnLimpiarDevolucion";
            btnLimpiarDevolucion.Size = new Size(150, 45);
            btnLimpiarDevolucion.TabIndex = 36;
            btnLimpiarDevolucion.Text = "Limpiar";
            btnLimpiarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnCancelarDevolucion
            // 
            btnCancelarDevolucion.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarDevolucion.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelarDevolucion.Image = Properties.Resources.Cancelar1_0;
            btnCancelarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarDevolucion.Location = new Point(952, 906);
            btnCancelarDevolucion.Name = "btnCancelarDevolucion";
            btnCancelarDevolucion.Size = new Size(150, 45);
            btnCancelarDevolucion.TabIndex = 37;
            btnCancelarDevolucion.Text = "Cancelar";
            btnCancelarDevolucion.UseVisualStyleBackColor = false;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(95, 588);
            dtpFechaDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(219, 27);
            dtpFechaDevolucion.TabIndex = 38;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaPago.ForeColor = Color.FromArgb(31, 31, 31);
            lblFechaPago.Location = new Point(1106, 793);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(107, 20);
            lblFechaPago.TabIndex = 39;
            lblFechaPago.Text = "Fecha de pago";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1106, 820);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 27);
            dateTimePicker1.TabIndex = 41;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(774, 820);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(219, 28);
            comboBox2.TabIndex = 42;
            // 
            // frmDevolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1566, 995);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFechaPago);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(btnCancelarDevolucion);
            Controls.Add(btnLimpiarDevolucion);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(txtMonto);
            Controls.Add(txtDiasRetraso);
            Controls.Add(txtLibrosVencidos);
            Controls.Add(label17);
            Controls.Add(lblEstado);
            Controls.Add(lblMonto);
            Controls.Add(lblDiasRetraso);
            Controls.Add(lblLibrosVencidos);
            Controls.Add(label12);
            Controls.Add(cmbBibliotecario);
            Controls.Add(lblBibliotecarioReg);
            Controls.Add(lblFechaDev);
            Controls.Add(label9);
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
            Controls.Add(txtApMaternoSolic);
            Controls.Add(txtApPaternoSolic);
            Controls.Add(txtNombreSolicitante);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmDevolucion";
            Text = "frmDevolucion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtNombreSolicitante;
        private TextBox txtApPaternoSolic;
        private TextBox txtApMaternoSolic;
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
        private Label label9;
        private Label lblFechaDev;
        private Label lblBibliotecarioReg;
        private ComboBox cmbBibliotecario;
        private Label label12;
        private Label lblLibrosVencidos;
        private Label lblDiasRetraso;
        private Label lblMonto;
        private Label lblEstado;
        private Label label17;
        private TextBox txtLibrosVencidos;
        private TextBox txtDiasRetraso;
        private TextBox txtMonto;
        private Button btnRegistrarDevolucion;
        private Button btnLimpiarDevolucion;
        private Button btnCancelarDevolucion;
        private DateTimePicker dtpFechaDevolucion;
        private Label lblFechaPago;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
    }
}