namespace prySistema_prestamos_libros
{
    partial class frmFormularioEjemplares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioEjemplares));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pcbContenedorBusqueda = new PictureBox();
            lblDatosEjemplar = new Label();
            lblSeleccionLibro = new Label();
            lblCantidad = new Label();
            lblFechaAdquisicion = new Label();
            lblLocalizacion = new Label();
            txtLocalizacion = new TextBox();
            dtpFechaAdquisicion = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            dgvLibrosPerteneciente = new DataGridView();
            chkSeleccionar = new DataGridViewCheckBoxColumn();
            txtLibroPerteneciete = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosPerteneciente).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorBusqueda
            // 
            pcbContenedorBusqueda.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorBusqueda.Location = new Point(25, 12);
            pcbContenedorBusqueda.Name = "pcbContenedorBusqueda";
            pcbContenedorBusqueda.Size = new Size(904, 490);
            pcbContenedorBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorBusqueda.TabIndex = 2;
            pcbContenedorBusqueda.TabStop = false;
            // 
            // lblDatosEjemplar
            // 
            lblDatosEjemplar.AutoSize = true;
            lblDatosEjemplar.BackColor = Color.FromArgb(250, 247, 242);
            lblDatosEjemplar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosEjemplar.ForeColor = Color.FromArgb(27, 46, 107);
            lblDatosEjemplar.Location = new Point(28, 23);
            lblDatosEjemplar.Name = "lblDatosEjemplar";
            lblDatosEjemplar.Size = new Size(162, 23);
            lblDatosEjemplar.TabIndex = 3;
            lblDatosEjemplar.Text = "Datos del ejemplar";
            // 
            // lblSeleccionLibro
            // 
            lblSeleccionLibro.AutoSize = true;
            lblSeleccionLibro.BackColor = Color.FromArgb(250, 247, 242);
            lblSeleccionLibro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionLibro.ForeColor = Color.Black;
            lblSeleccionLibro.Location = new Point(61, 60);
            lblSeleccionLibro.Name = "lblSeleccionLibro";
            lblSeleccionLibro.Size = new Size(171, 20);
            lblSeleccionLibro.TabIndex = 4;
            lblSeleccionLibro.Text = "Buscar por ISBN o título ";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(250, 247, 242);
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.Black;
            lblCantidad.Location = new Point(397, 412);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // lblFechaAdquisicion
            // 
            lblFechaAdquisicion.AutoSize = true;
            lblFechaAdquisicion.BackColor = Color.FromArgb(250, 247, 242);
            lblFechaAdquisicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaAdquisicion.ForeColor = Color.Black;
            lblFechaAdquisicion.Location = new Point(61, 412);
            lblFechaAdquisicion.Name = "lblFechaAdquisicion";
            lblFechaAdquisicion.Size = new Size(148, 20);
            lblFechaAdquisicion.TabIndex = 6;
            lblFechaAdquisicion.Text = "Fecha de adquisición";
            // 
            // lblLocalizacion
            // 
            lblLocalizacion.AutoSize = true;
            lblLocalizacion.BackColor = Color.FromArgb(250, 247, 242);
            lblLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalizacion.ForeColor = Color.Black;
            lblLocalizacion.Location = new Point(61, 337);
            lblLocalizacion.Name = "lblLocalizacion";
            lblLocalizacion.Size = new Size(91, 20);
            lblLocalizacion.TabIndex = 7;
            lblLocalizacion.Text = "Localización";
            // 
            // txtLocalizacion
            // 
            txtLocalizacion.BackColor = Color.White;
            txtLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocalizacion.ForeColor = Color.Black;
            txtLocalizacion.Location = new Point(61, 360);
            txtLocalizacion.Multiline = true;
            txtLocalizacion.Name = "txtLocalizacion";
            txtLocalizacion.Size = new Size(556, 30);
            txtLocalizacion.TabIndex = 22;
            // 
            // dtpFechaAdquisicion
            // 
            dtpFechaAdquisicion.CalendarForeColor = Color.Black;
            dtpFechaAdquisicion.CalendarMonthBackground = Color.White;
            dtpFechaAdquisicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaAdquisicion.Format = DateTimePickerFormat.Short;
            dtpFechaAdquisicion.Location = new Point(61, 435);
            dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            dtpFechaAdquisicion.Size = new Size(245, 27);
            dtpFechaAdquisicion.TabIndex = 23;
            // 
            // nudCantidad
            // 
            nudCantidad.BackColor = Color.White;
            nudCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.ForeColor = Color.Black;
            nudCantidad.Location = new Point(397, 435);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(245, 27);
            nudCantidad.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(201, 168, 76);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(17, 30, 71);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(73, 539);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(397, 539);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 45);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(714, 539);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvLibrosPerteneciente
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dgvLibrosPerteneciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLibrosPerteneciente.BackgroundColor = Color.FromArgb(250, 247, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLibrosPerteneciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLibrosPerteneciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrosPerteneciente.Columns.AddRange(new DataGridViewColumn[] { chkSeleccionar });
            dgvLibrosPerteneciente.EnableHeadersVisualStyles = false;
            dgvLibrosPerteneciente.Location = new Point(61, 119);
            dgvLibrosPerteneciente.Name = "dgvLibrosPerteneciente";
            dgvLibrosPerteneciente.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLibrosPerteneciente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvLibrosPerteneciente.Size = new Size(830, 205);
            dgvLibrosPerteneciente.TabIndex = 21;
            dgvLibrosPerteneciente.CellContentClick += dgvLibrosPerteneciente_CellContentClick;
            // 
            // chkSeleccionar
            // 
            chkSeleccionar.HeaderText = "Seleccionar";
            chkSeleccionar.MinimumWidth = 6;
            chkSeleccionar.Name = "chkSeleccionar";
            chkSeleccionar.Width = 125;
            // 
            // txtLibroPerteneciete
            // 
            txtLibroPerteneciete.BackColor = Color.White;
            txtLibroPerteneciete.ForeColor = Color.Black;
            txtLibroPerteneciete.Location = new Point(61, 83);
            txtLibroPerteneciete.Multiline = true;
            txtLibroPerteneciete.Name = "txtLibroPerteneciete";
            txtLibroPerteneciete.Size = new Size(245, 30);
            txtLibroPerteneciete.TabIndex = 20;
            txtLibroPerteneciete.TextChanged += txtLibroPerteneciete_TextChanged;
            // 
            // frmFormularioEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(956, 617);
            Controls.Add(txtLibroPerteneciete);
            Controls.Add(dgvLibrosPerteneciente);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFechaAdquisicion);
            Controls.Add(txtLocalizacion);
            Controls.Add(lblLocalizacion);
            Controls.Add(lblFechaAdquisicion);
            Controls.Add(lblCantidad);
            Controls.Add(lblSeleccionLibro);
            Controls.Add(lblDatosEjemplar);
            Controls.Add(pcbContenedorBusqueda);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmFormularioEjemplares";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario de Ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosPerteneciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbContenedorBusqueda;
        private Label lblDatosEjemplar;
        private Label lblSeleccionLibro;
        private Label lblCantidad;
        private Label lblFechaAdquisicion;
        private Label lblLocalizacion;
        private TextBox txtLocalizacion;
        private DateTimePicker dtpFechaAdquisicion;
        private NumericUpDown nudCantidad;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private DataGridView dgvLibrosPerteneciente;
        private TextBox txtLibroPerteneciete;
        private DataGridViewCheckBoxColumn chkSeleccionar;
    }
}