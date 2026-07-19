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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
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
            pcbContenedorGestion.Location = new Point(91, 31);
            pcbContenedorGestion.Margin = new Padding(3, 2, 3, 2);
            pcbContenedorGestion.Name = "pcbContenedorGestion";
            pcbContenedorGestion.Size = new Size(1126, 598);
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
            btnNuevoRegistro.Location = new Point(656, 94);
            btnNuevoRegistro.Margin = new Padding(3, 2, 3, 2);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(131, 34);
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
            btnEditar.Location = new Point(864, 94);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja.ForeColor = Color.FromArgb(122, 32, 32);
            btnDarBaja.Image = (Image)resources.GetObject("btnDarBaja.Image");
            btnDarBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.Location = new Point(1069, 94);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(131, 34);
            btnDarBaja.TabIndex = 3;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.FromArgb(31, 31, 31);
            lblBuscar.Location = new Point(108, 76);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(116, 15);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar por matricula";
            // 
            // txtBuscarAlumno
            // 
            txtBuscarAlumno.BackColor = Color.White;
            txtBuscarAlumno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarAlumno.ForeColor = Color.FromArgb(31, 31, 31);
            txtBuscarAlumno.Location = new Point(108, 94);
            txtBuscarAlumno.Margin = new Padding(3, 2, 3, 2);
            txtBuscarAlumno.Multiline = true;
            txtBuscarAlumno.Name = "txtBuscarAlumno";
            txtBuscarAlumno.Size = new Size(215, 24);
            txtBuscarAlumno.TabIndex = 3;
            txtBuscarAlumno.TextChanged += txtBuscarAlumno_TextChanged;
            // 
            // dgvAlumnos
            // 
            dataGridViewCellStyle16.BackColor = Color.FromArgb(221, 214, 202);
            dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvAlumnos.BackgroundColor = Color.FromArgb(250, 247, 242);
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(108, 178);
            dgvAlumnos.Margin = new Padding(3, 2, 3, 2);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = Color.White;
            dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dgvAlumnos.Size = new Size(1093, 426);
            dgvAlumnos.TabIndex = 6;
            // 
            // frmGestionAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1199, 562);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtBuscarAlumno);
            Controls.Add(lblBuscar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(pcbContenedorGestion);
            Margin = new Padding(3, 2, 3, 2);
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