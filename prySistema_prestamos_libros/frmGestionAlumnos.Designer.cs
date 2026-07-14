namespace prySistema_prestamos_libros
{
    partial class frmGestionAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAlumnos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pcbContenedorGestion = new PictureBox();
            btnNuevoRegistro = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            lblBuscar = new Label();
            txtBuscarAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorGestion
            // 
            pcbContenedorGestion.Image = (Image)resources.GetObject("pcbContenedorGestion.Image");
            pcbContenedorGestion.Location = new Point(104, 41);
            pcbContenedorGestion.Name = "pcbContenedorGestion";
            pcbContenedorGestion.Size = new Size(1287, 797);
            pcbContenedorGestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorGestion.TabIndex = 0;
            pcbContenedorGestion.TabStop = false;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoRegistro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoRegistro.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoRegistro.Image = (Image)resources.GetObject("btnNuevoRegistro.Image");
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.Location = new Point(750, 125);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(150, 45);
            btnNuevoRegistro.TabIndex = 1;
            btnNuevoRegistro.Text = "Nuevo ";
            btnNuevoRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            btnNuevoRegistro.Click += btnNuevoRegistro_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(987, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja.ForeColor = Color.FromArgb(122, 32, 32);
            btnDarBaja.Image = (Image)resources.GetObject("btnDarBaja.Image");
            btnDarBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.Location = new Point(1222, 125);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(150, 45);
            btnDarBaja.TabIndex = 3;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.FromArgb(31, 31, 31);
            lblBuscar.Location = new Point(123, 102);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(222, 20);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar por el numero de control";
            // 
            // txtBuscarAlumno
            // 
            txtBuscarAlumno.BackColor = Color.White;
            txtBuscarAlumno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarAlumno.ForeColor = Color.FromArgb(31, 31, 31);
            txtBuscarAlumno.Location = new Point(123, 125);
            txtBuscarAlumno.Multiline = true;
            txtBuscarAlumno.Name = "txtBuscarAlumno";
            txtBuscarAlumno.Size = new Size(245, 30);
            txtBuscarAlumno.TabIndex = 3;
            // 
            // dgvAlumnos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(123, 238);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.Size = new Size(1249, 568);
            dgvAlumnos.TabIndex = 6;
            // 
            // frmGestionAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 875);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtBuscarAlumno);
            Controls.Add(lblBuscar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(pcbContenedorGestion);
            Name = "frmGestionAlumnos";
            Text = "Gestion de Alumnos";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbContenedorGestion;
        private Button btnNuevoRegistro;
        private Button btnEditar;
        private Button btnDarBaja;
        private Label lblBuscar;
        private TextBox txtBuscarAlumno;
        private DataGridView dgvAlumnos;
    }
}