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
            pcbContenedorBusqueda = new PictureBox();
            lblDatosEjemplar = new Label();
            lblSeleccionLibro = new Label();
            lblCantidad = new Label();
            lblFechaAdquisicion = new Label();
            lblLocalizacion = new Label();
            lblEstado = new Label();
            cmbLibro = new ComboBox();
            txtLocalizacion = new TextBox();
            dtpFechaAdquisicion = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            txtEstado = new ComboBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorBusqueda
            // 
            pcbContenedorBusqueda.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorBusqueda.Location = new Point(25, 108);
            pcbContenedorBusqueda.Name = "pcbContenedorBusqueda";
            pcbContenedorBusqueda.Size = new Size(1302, 374);
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
            lblDatosEjemplar.Location = new Point(38, 119);
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
            lblSeleccionLibro.Location = new Point(61, 190);
            lblSeleccionLibro.Name = "lblSeleccionLibro";
            lblSeleccionLibro.Size = new Size(158, 20);
            lblSeleccionLibro.TabIndex = 4;
            lblSeleccionLibro.Text = "Libro al que pertenece";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(250, 247, 242);
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.Black;
            lblCantidad.Location = new Point(479, 314);
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
            lblFechaAdquisicion.Location = new Point(61, 314);
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
            lblLocalizacion.Location = new Point(479, 190);
            lblLocalizacion.Name = "lblLocalizacion";
            lblLocalizacion.Size = new Size(91, 20);
            lblLocalizacion.TabIndex = 7;
            lblLocalizacion.Text = "Localización";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.FromArgb(250, 247, 242);
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(864, 314);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado";
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(61, 226);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(245, 28);
            cmbLibro.TabIndex = 10;
            // 
            // txtLocalizacion
            // 
            txtLocalizacion.BackColor = Color.White;
            txtLocalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            txtLocalizacion.Location = new Point(479, 226);
            txtLocalizacion.Multiline = true;
            txtLocalizacion.Name = "txtLocalizacion";
            txtLocalizacion.Size = new Size(630, 29);
            txtLocalizacion.TabIndex = 11;
            // 
            // dtpFechaAdquisicion
            // 
            dtpFechaAdquisicion.CalendarForeColor = SystemColors.ControlLightLight;
            dtpFechaAdquisicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaAdquisicion.Format = DateTimePickerFormat.Short;
            dtpFechaAdquisicion.Location = new Point(61, 358);
            dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            dtpFechaAdquisicion.Size = new Size(245, 27);
            dtpFechaAdquisicion.TabIndex = 13;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(479, 358);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(245, 27);
            nudCantidad.TabIndex = 14;
            // 
            // txtEstado
            // 
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.FormattingEnabled = true;
            txtEstado.Location = new Point(864, 357);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(245, 28);
            txtEstado.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 168, 76);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(17, 30, 71);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(233, 597);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 122, 153);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(250, 247, 242);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(574, 597);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 45);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 196, 196);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(122, 32, 32);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(915, 597);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmFormularioEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 848);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstado);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFechaAdquisicion);
            Controls.Add(txtLocalizacion);
            Controls.Add(cmbLibro);
            Controls.Add(lblEstado);
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
            Text = "Formulario de Ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
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
        private Label lblEstado;
        private ComboBox cmbLibro;
        private TextBox txtLocalizacion;
        private DateTimePicker dtpFechaAdquisicion;
        private NumericUpDown nudCantidad;
        private ComboBox txtEstado;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCancelar;
    }
}