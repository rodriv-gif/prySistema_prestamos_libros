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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(27, 46, 107);
            label1.Location = new Point(98, 181);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 3;
            label1.Text = "Datos del ejemplar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 247, 242);
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(106, 112, 144);
            label2.Location = new Point(98, 234);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 4;
            label2.Text = "Libro al que pertenece";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(250, 247, 242);
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(106, 112, 144);
            label3.Location = new Point(525, 332);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(250, 247, 242);
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(106, 112, 144);
            label4.Location = new Point(98, 332);
            label4.Name = "label4";
            label4.Size = new Size(238, 32);
            label4.TabIndex = 6;
            label4.Text = "Fecha de adquisición";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(250, 247, 242);
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.FromArgb(106, 112, 144);
            label5.Location = new Point(525, 234);
            label5.Name = "label5";
            label5.Size = new Size(142, 32);
            label5.TabIndex = 7;
            label5.Text = "Localización";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(250, 247, 242);
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.FromArgb(106, 112, 144);
            label7.Location = new Point(826, 332);
            label7.Name = "label7";
            label7.Size = new Size(84, 32);
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
            nudCantidad.Location = new Point(526, 364);
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
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
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