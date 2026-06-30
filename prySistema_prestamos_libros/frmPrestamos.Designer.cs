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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            lblISBN = new Label();
            txtIsbn = new TextBox();
            dataGridView1 = new DataGridView();
            lbllocalizacion = new Label();
            lblInventario = new Label();
            textBox2 = new TextBox();
            txtInventario = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnLimpiarPrestamo = new Button();
            btnCancelarPrestamo = new Button();
            label5 = new Label();
            lblNumeroControl = new Label();
            txtNumControlSolicitante = new TextBox();
            txtTipoSolicitante = new TextBox();
            textBox6 = new TextBox();
            txtApPatSolicitante = new TextBox();
            txtApMatSolicitante = new TextBox();
            txtGrado = new TextBox();
            txtGrupo = new TextBox();
            lblTipoSolicitante = new Label();
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblGrado = new Label();
            lblGrupo = new Label();
            txtCarreraSolicitante = new TextBox();
            label13 = new Label();
            lblTipoPrestamo = new Label();
            lblFechaPrestamo = new Label();
            label16 = new Label();
            lblBibliotecario = new Label();
            label18 = new Label();
            cmbTipoPrestamo = new ComboBox();
            cmbBibliotecario = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(64, 18);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1283, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.contenerdorGrupo;
            pictureBox2.Location = new Point(64, 362);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1283, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 247, 242);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(27, 46, 107);
            label1.Location = new Point(64, 18);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 6;
            label1.Text = "Búsqueda de libros";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.contenedorgroupCompac;
            pictureBox3.Location = new Point(64, 549);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1139, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.FromArgb(250, 247, 242);
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = Color.FromArgb(31, 31, 31);
            lblISBN.Location = new Point(82, 35);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 10;
            lblISBN.Text = "ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.BackColor = Color.White;
            txtIsbn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIsbn.Location = new Point(82, 52);
            txtIsbn.Margin = new Padding(3, 2, 3, 2);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(137, 26);
            txtIsbn.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 82);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1249, 197);
            dataGridView1.TabIndex = 12;
            // 
            // lbllocalizacion
            // 
            lbllocalizacion.AutoSize = true;
            lbllocalizacion.BackColor = Color.FromArgb(250, 247, 242);
            lbllocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            lbllocalizacion.Location = new Point(79, 296);
            lbllocalizacion.Name = "lbllocalizacion";
            lbllocalizacion.Size = new Size(72, 15);
            lbllocalizacion.TabIndex = 13;
            lbllocalizacion.Text = "Localización";
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.BackColor = Color.FromArgb(250, 247, 242);
            lblInventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventario.ForeColor = Color.FromArgb(31, 31, 31);
            lblInventario.Location = new Point(372, 296);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(124, 15);
            lblInventario.TabIndex = 14;
            lblInventario.Text = "Inventario(Existencias)";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(78, 313);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 26);
            textBox2.TabIndex = 15;
            // 
            // txtInventario
            // 
            txtInventario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventario.Location = new Point(368, 313);
            txtInventario.Margin = new Padding(3, 2, 3, 2);
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(199, 26);
            txtInventario.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 30, 71);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(201, 168, 76);
            button1.Location = new Point(618, 294);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 17;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(201, 168, 76);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(17, 30, 71);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(368, 679);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 18;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarPrestamo
            // 
            btnLimpiarPrestamo.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarPrestamo.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiarPrestamo.Image = Properties.Resources.Limpiar;
            btnLimpiarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarPrestamo.Location = new Point(590, 679);
            btnLimpiarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarPrestamo.Name = "btnLimpiarPrestamo";
            btnLimpiarPrestamo.Size = new Size(150, 45);
            btnLimpiarPrestamo.TabIndex = 19;
            btnLimpiarPrestamo.Text = "Limpiar";
            btnLimpiarPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPrestamo
            // 
            btnCancelarPrestamo.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarPrestamo.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelarPrestamo.Image = Properties.Resources.Cancelar1_0;
            btnCancelarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarPrestamo.Location = new Point(808, 679);
            btnCancelarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            btnCancelarPrestamo.Size = new Size(150, 45);
            btnCancelarPrestamo.TabIndex = 20;
            btnCancelarPrestamo.Text = "Cancelar";
            btnCancelarPrestamo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(250, 247, 242);
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(27, 46, 107);
            label5.Location = new Point(68, 369);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 21;
            label5.Text = "Datos del solicitante";
            // 
            // lblNumeroControl
            // 
            lblNumeroControl.AutoSize = true;
            lblNumeroControl.BackColor = Color.FromArgb(250, 247, 242);
            lblNumeroControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroControl.ForeColor = Color.FromArgb(31, 31, 31);
            lblNumeroControl.Location = new Point(79, 387);
            lblNumeroControl.Name = "lblNumeroControl";
            lblNumeroControl.Size = new Size(130, 15);
            lblNumeroControl.TabIndex = 22;
            lblNumeroControl.Text = "Numero de control / ID";
            // 
            // txtNumControlSolicitante
            // 
            txtNumControlSolicitante.BackColor = Color.White;
            txtNumControlSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumControlSolicitante.Location = new Point(79, 406);
            txtNumControlSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtNumControlSolicitante.Name = "txtNumControlSolicitante";
            txtNumControlSolicitante.Size = new Size(218, 26);
            txtNumControlSolicitante.TabIndex = 23;
            // 
            // txtTipoSolicitante
            // 
            txtTipoSolicitante.BackColor = Color.White;
            txtTipoSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoSolicitante.Location = new Point(372, 406);
            txtTipoSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtTipoSolicitante.Name = "txtTipoSolicitante";
            txtTipoSolicitante.Size = new Size(210, 26);
            txtTipoSolicitante.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(79, 453);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(218, 26);
            textBox6.TabIndex = 25;
            // 
            // txtApPatSolicitante
            // 
            txtApPatSolicitante.BackColor = Color.White;
            txtApPatSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApPatSolicitante.Location = new Point(372, 453);
            txtApPatSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtApPatSolicitante.Name = "txtApPatSolicitante";
            txtApPatSolicitante.Size = new Size(210, 26);
            txtApPatSolicitante.TabIndex = 26;
            // 
            // txtApMatSolicitante
            // 
            txtApMatSolicitante.BackColor = Color.White;
            txtApMatSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApMatSolicitante.Location = new Point(669, 453);
            txtApMatSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtApMatSolicitante.Name = "txtApMatSolicitante";
            txtApMatSolicitante.Size = new Size(207, 26);
            txtApMatSolicitante.TabIndex = 27;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrado.Location = new Point(79, 503);
            txtGrado.Margin = new Padding(3, 2, 3, 2);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(218, 26);
            txtGrado.TabIndex = 28;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(372, 503);
            txtGrupo.Margin = new Padding(3, 2, 3, 2);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(210, 26);
            txtGrupo.TabIndex = 29;
            // 
            // lblTipoSolicitante
            // 
            lblTipoSolicitante.AutoSize = true;
            lblTipoSolicitante.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoSolicitante.ForeColor = Color.FromArgb(31, 31, 31);
            lblTipoSolicitante.Location = new Point(376, 389);
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
            lblNombre.ForeColor = Color.FromArgb(31, 31, 31);
            lblNombre.Location = new Point(79, 436);
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
            lblApellidoPaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoPaterno.Location = new Point(376, 436);
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
            lblApellidoMaterno.ForeColor = Color.FromArgb(31, 31, 31);
            lblApellidoMaterno.Location = new Point(669, 436);
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
            lblGrado.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrado.Location = new Point(79, 486);
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
            lblGrupo.ForeColor = Color.FromArgb(31, 31, 31);
            lblGrupo.Location = new Point(376, 486);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 35;
            lblGrupo.Text = "Grupo";
            // 
            // txtCarreraSolicitante
            // 
            txtCarreraSolicitante.BackColor = Color.White;
            txtCarreraSolicitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarreraSolicitante.Location = new Point(669, 503);
            txtCarreraSolicitante.Margin = new Padding(3, 2, 3, 2);
            txtCarreraSolicitante.Name = "txtCarreraSolicitante";
            txtCarreraSolicitante.Size = new Size(207, 26);
            txtCarreraSolicitante.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(250, 247, 242);
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(669, 486);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 37;
            label13.Text = "Carrera / Área";
            // 
            // lblTipoPrestamo
            // 
            lblTipoPrestamo.AutoSize = true;
            lblTipoPrestamo.BackColor = Color.FromArgb(250, 247, 242);
            lblTipoPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPrestamo.ForeColor = Color.FromArgb(31, 31, 31);
            lblTipoPrestamo.Location = new Point(79, 584);
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
            lblFechaPrestamo.Location = new Point(372, 584);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(107, 15);
            lblFechaPrestamo.TabIndex = 39;
            lblFechaPrestamo.Text = "Fecha de préstamo";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(250, 247, 242);
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(669, 584);
            label16.Name = "label16";
            label16.Size = new Size(116, 15);
            label16.TabIndex = 40;
            label16.Text = "Fecha de devolución";
            // 
            // lblBibliotecario
            // 
            lblBibliotecario.AutoSize = true;
            lblBibliotecario.BackColor = Color.FromArgb(250, 247, 242);
            lblBibliotecario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBibliotecario.ForeColor = Color.FromArgb(31, 31, 31);
            lblBibliotecario.Location = new Point(946, 584);
            lblBibliotecario.Name = "lblBibliotecario";
            lblBibliotecario.Size = new Size(138, 15);
            lblBibliotecario.TabIndex = 41;
            lblBibliotecario.Text = "Bibliotecario que registra";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(250, 247, 242);
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(27, 46, 107);
            label18.Location = new Point(68, 555);
            label18.Name = "label18";
            label18.Size = new Size(140, 19);
            label18.TabIndex = 46;
            label18.Text = "Datos del préstamo";
            // 
            // cmbTipoPrestamo
            // 
            cmbTipoPrestamo.BackColor = Color.White;
            cmbTipoPrestamo.FormattingEnabled = true;
            cmbTipoPrestamo.Location = new Point(79, 604);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(207, 23);
            cmbTipoPrestamo.TabIndex = 47;
            // 
            // cmbBibliotecario
            // 
            cmbBibliotecario.BackColor = Color.White;
            cmbBibliotecario.FormattingEnabled = true;
            cmbBibliotecario.Location = new Point(946, 602);
            cmbBibliotecario.Name = "cmbBibliotecario";
            cmbBibliotecario.Size = new Size(200, 23);
            cmbBibliotecario.TabIndex = 48;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(372, 601);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(160, 23);
            dtpFechaPrestamo.TabIndex = 49;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(669, 601);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(160, 23);
            dtpFechaDevolucion.TabIndex = 50;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbBibliotecario);
            Controls.Add(cmbTipoPrestamo);
            Controls.Add(label18);
            Controls.Add(lblBibliotecario);
            Controls.Add(label16);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(lblTipoPrestamo);
            Controls.Add(label13);
            Controls.Add(txtCarreraSolicitante);
            Controls.Add(lblGrupo);
            Controls.Add(lblGrado);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(lblNombre);
            Controls.Add(lblTipoSolicitante);
            Controls.Add(txtGrupo);
            Controls.Add(txtGrado);
            Controls.Add(txtApMatSolicitante);
            Controls.Add(txtApPatSolicitante);
            Controls.Add(textBox6);
            Controls.Add(txtTipoSolicitante);
            Controls.Add(txtNumControlSolicitante);
            Controls.Add(lblNumeroControl);
            Controls.Add(label5);
            Controls.Add(btnCancelarPrestamo);
            Controls.Add(btnLimpiarPrestamo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtInventario);
            Controls.Add(textBox2);
            Controls.Add(lblInventario);
            Controls.Add(lbllocalizacion);
            Controls.Add(dataGridView1);
            Controls.Add(txtIsbn);
            Controls.Add(lblISBN);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrestamos";
            Text = "frmPrestamos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label lblISBN;
        private TextBox txtIsbn;
        private DataGridView dataGridView1;
        private Label lbllocalizacion;
        private Label lblInventario;
        private TextBox textBox2;
        private TextBox txtInventario;
        private Button button1;
        private Button button2;
        private Button btnLimpiarPrestamo;
        private Button btnCancelarPrestamo;
        private Label label5;
        private Label lblNumeroControl;
        private TextBox txtNumControlSolicitante;
        private TextBox txtTipoSolicitante;
        private TextBox textBox6;
        private TextBox txtApPatSolicitante;
        private TextBox txtApMatSolicitante;
        private TextBox txtGrado;
        private TextBox txtGrupo;
        private Label lblTipoSolicitante;
        private Label lblNombre;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private Label lblGrado;
        private Label lblGrupo;
        private TextBox txtCarreraSolicitante;
        private Label label13;
        private Label lblTipoPrestamo;
        private Label lblFechaPrestamo;
        private Label label16;
        private Label lblBibliotecario;
        private Label label18;
        private ComboBox cmbTipoPrestamo;
        private ComboBox cmbBibliotecario;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
    }
}