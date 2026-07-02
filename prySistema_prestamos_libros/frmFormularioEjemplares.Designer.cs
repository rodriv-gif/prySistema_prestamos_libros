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
            pcb1 = new PictureBox();
            label1 = new Label();
            lblSeleccionLibro = new Label();
            lblCantidad = new Label();
            lblFechaAdquisicion = new Label();
            lblLocalizacion = new Label();
            label7 = new Label();
            cmbLibro = new ComboBox();
            txtLocalizacion = new TextBox();
            dtpFechaAdquisicion = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            txtEstado = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pcb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // pcb1
            // 
            pcb1.Image = Properties.Resources.contenerdorGrupo;
            pcb1.Location = new Point(49, 148);
            pcb1.Name = "pcb1";
            pcb1.Size = new Size(1256, 372);
            pcb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb1.TabIndex = 2;
            pcb1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 247, 242);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(27, 46, 107);
            label1.Location = new Point(98, 181);
            label1.Name = "label1";
            label1.Size = new Size(162, 23);
            label1.TabIndex = 3;
            label1.Text = "Datos del ejemplar";
            // 
            // lblSeleccionLibro
            // 
            lblSeleccionLibro.AutoSize = true;
            lblSeleccionLibro.BackColor = Color.FromArgb(250, 247, 242);
            lblSeleccionLibro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionLibro.ForeColor = Color.Black;
            lblSeleccionLibro.Location = new Point(98, 234);
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
            lblCantidad.Location = new Point(525, 332);
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
            lblFechaAdquisicion.Location = new Point(98, 332);
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
            lblLocalizacion.Location = new Point(525, 234);
            lblLocalizacion.Name = "lblLocalizacion";
            lblLocalizacion.Size = new Size(91, 20);
            lblLocalizacion.TabIndex = 7;
            lblLocalizacion.Text = "Localización";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(250, 247, 242);
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(826, 332);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 9;
            label7.Text = "Estado";
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(98, 262);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(224, 36);
            cmbLibro.TabIndex = 10;
            // 
            // txtLocalizacion
            // 
            txtLocalizacion.BackColor = Color.White;
            txtLocalizacion.ForeColor = Color.FromArgb(31, 31, 31);
            txtLocalizacion.Location = new Point(525, 262);
            txtLocalizacion.Multiline = true;
            txtLocalizacion.Name = "txtLocalizacion";
            txtLocalizacion.Size = new Size(523, 29);
            txtLocalizacion.TabIndex = 11;
            // 
            // dtpFechaAdquisicion
            // 
            dtpFechaAdquisicion.CalendarForeColor = SystemColors.ControlLightLight;
            dtpFechaAdquisicion.Format = DateTimePickerFormat.Short;
            dtpFechaAdquisicion.Location = new Point(98, 360);
            dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            dtpFechaAdquisicion.Size = new Size(224, 34);
            dtpFechaAdquisicion.TabIndex = 13;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(525, 363);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(224, 34);
            nudCantidad.TabIndex = 14;
            // 
            // txtEstado
            // 
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.FormattingEnabled = true;
            txtEstado.Location = new Point(826, 360);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(224, 36);
            txtEstado.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(201, 168, 76);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(17, 30, 71);
            button1.Location = new Point(319, 597);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(107, 122, 153);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(250, 247, 242);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(600, 597);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 17;
            button2.Text = "Limpiar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(242, 196, 196);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(122, 32, 32);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(876, 597);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 18;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // frmFormularioEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEstado);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFechaAdquisicion);
            Controls.Add(txtLocalizacion);
            Controls.Add(cmbLibro);
            Controls.Add(label7);
            Controls.Add(lblLocalizacion);
            Controls.Add(lblFechaAdquisicion);
            Controls.Add(lblCantidad);
            Controls.Add(lblSeleccionLibro);
            Controls.Add(label1);
            Controls.Add(pcb1);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmFormularioEjemplares";
            Text = "Gestion de ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcb1;
        private Label label1;
        private Label lblSeleccionLibro;
        private Label lblCantidad;
        private Label lblFechaAdquisicion;
        private Label lblLocalizacion;
        private Label label7;
        private ComboBox cmbLibro;
        private TextBox txtLocalizacion;
        private DateTimePicker dtpFechaAdquisicion;
        private NumericUpDown nudCantidad;
        private ComboBox txtEstado;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}