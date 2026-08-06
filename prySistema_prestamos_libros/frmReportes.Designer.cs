namespace prySistema_prestamos_libros
{
    partial class frmReportes
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
            gpbOpciones = new GroupBox();
            rdbOpcion4 = new RadioButton();
            rdbOpcion3 = new RadioButton();
            rdbOpcion2 = new RadioButton();
            rdbOpcion1 = new RadioButton();
            dgvReportes = new DataGridView();
            btnGenerarPDF = new Button();
            lblReportes = new Label();
            btnVer = new Button();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            lblInicio = new Label();
            lblFin = new Label();
            gpbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // gpbOpciones
            // 
            gpbOpciones.Controls.Add(rdbOpcion4);
            gpbOpciones.Controls.Add(rdbOpcion3);
            gpbOpciones.Controls.Add(rdbOpcion2);
            gpbOpciones.Controls.Add(rdbOpcion1);
            gpbOpciones.FlatStyle = FlatStyle.Popup;
            gpbOpciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbOpciones.ForeColor = Color.Black;
            gpbOpciones.Location = new Point(165, 121);
            gpbOpciones.Name = "gpbOpciones";
            gpbOpciones.Size = new Size(1152, 211);
            gpbOpciones.TabIndex = 0;
            gpbOpciones.TabStop = false;
            gpbOpciones.Text = "Opciones";
            // 
            // rdbOpcion4
            // 
            rdbOpcion4.AutoSize = true;
            rdbOpcion4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpcion4.ForeColor = Color.Black;
            rdbOpcion4.Location = new Point(21, 41);
            rdbOpcion4.Name = "rdbOpcion4";
            rdbOpcion4.Size = new Size(276, 32);
            rdbOpcion4.TabIndex = 3;
            rdbOpcion4.TabStop = true;
            rdbOpcion4.Text = "Mostrar inventario de libros";
            rdbOpcion4.UseVisualStyleBackColor = true;
            rdbOpcion4.CheckedChanged += rdbOpcion4_CheckedChanged;
            // 
            // rdbOpcion3
            // 
            rdbOpcion3.AutoSize = true;
            rdbOpcion3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpcion3.ForeColor = Color.Black;
            rdbOpcion3.Location = new Point(20, 79);
            rdbOpcion3.Name = "rdbOpcion3";
            rdbOpcion3.Size = new Size(344, 32);
            rdbOpcion3.TabIndex = 2;
            rdbOpcion3.TabStop = true;
            rdbOpcion3.Text = "Mostrar reporte de libros prestados";
            rdbOpcion3.UseVisualStyleBackColor = true;
            rdbOpcion3.CheckedChanged += rdbOpcion3_CheckedChanged;
            // 
            // rdbOpcion2
            // 
            rdbOpcion2.AutoSize = true;
            rdbOpcion2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpcion2.ForeColor = Color.Black;
            rdbOpcion2.Location = new Point(21, 117);
            rdbOpcion2.Name = "rdbOpcion2";
            rdbOpcion2.Size = new Size(377, 32);
            rdbOpcion2.TabIndex = 1;
            rdbOpcion2.TabStop = true;
            rdbOpcion2.Text = "Mostrar reporte de préstamos vencidos";
            rdbOpcion2.UseVisualStyleBackColor = true;
            rdbOpcion2.CheckedChanged += rdbOpcion2_CheckedChanged;
            // 
            // rdbOpcion1
            // 
            rdbOpcion1.AutoSize = true;
            rdbOpcion1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpcion1.ForeColor = Color.Black;
            rdbOpcion1.Location = new Point(21, 155);
            rdbOpcion1.Name = "rdbOpcion1";
            rdbOpcion1.Size = new Size(451, 32);
            rdbOpcion1.TabIndex = 0;
            rdbOpcion1.TabStop = true;
            rdbOpcion1.Text = "Mostrar reporte de libros mas solicitados al mes";
            rdbOpcion1.UseVisualStyleBackColor = true;
            rdbOpcion1.CheckedChanged += rdbOpcion1_CheckedChanged;
            // 
            // dgvReportes
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.Location = new Point(139, 433);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.Size = new Size(1199, 340);
            dgvReportes.TabIndex = 5;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.FromArgb(17, 30, 71);
            btnGenerarPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPDF.ForeColor = Color.FromArgb(201, 168, 76);
            btnGenerarPDF.Location = new Point(527, 795);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(418, 50);
            btnGenerarPDF.TabIndex = 6;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportes.ForeColor = Color.FromArgb(201, 168, 76);
            lblReportes.Location = new Point(601, 20);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(286, 81);
            lblReportes.TabIndex = 1;
            lblReportes.Text = "Reportes";
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(17, 30, 71);
            btnVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.ForeColor = Color.FromArgb(201, 168, 76);
            btnVer.Location = new Point(1058, 377);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(280, 50);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarForeColor = Color.Black;
            dtpFechaInicio.CalendarMonthBackground = Color.White;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(185, 385);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(245, 27);
            dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarForeColor = Color.Black;
            dtpFechaFin.CalendarMonthBackground = Color.White;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(513, 387);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(245, 27);
            dtpFechaFin.TabIndex = 8;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 12F);
            lblInicio.ForeColor = Color.Black;
            lblInicio.Location = new Point(145, 389);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(36, 28);
            lblInicio.TabIndex = 9;
            lblInicio.Text = "De";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Font = new Font("Segoe UI", 12F);
            lblFin.ForeColor = Color.Black;
            lblFin.Location = new Point(450, 385);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(61, 28);
            lblFin.TabIndex = 10;
            lblFin.Text = "Hasta";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 875);
            Controls.Add(lblFin);
            Controls.Add(lblInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(btnVer);
            Controls.Add(lblReportes);
            Controls.Add(btnGenerarPDF);
            Controls.Add(dgvReportes);
            Controls.Add(gpbOpciones);
            Name = "frmReportes";
            Text = "Reportes";
            gpbOpciones.ResumeLayout(false);
            gpbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbOpciones;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion1;
        private DataGridView dgvReportes;
        private Button btnGenerarPDF;
        private Label lblReportes;
        private RadioButton rdbOpcion3;
        private Button btnVer;
        private RadioButton rdbOpcion4;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label lblInicio;
        private Label lblFin;
    }
}