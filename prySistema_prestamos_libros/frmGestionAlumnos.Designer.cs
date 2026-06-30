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
            pictureBox1 = new PictureBox();
            btnNuevoRegistro = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            lblBuscar = new Label();
            txtBuscarAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contenedorgroupCompac;
            pictureBox1.Location = new Point(30, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1367, 797);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoRegistro.Location = new Point(690, 116);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(150, 45);
            btnNuevoRegistro.TabIndex = 1;
            btnNuevoRegistro.Text = "Nuevo registro";
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(933, 116);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja.ForeColor = Color.FromArgb(122, 32, 32);
            btnDarBaja.Location = new Point(1153, 116);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(150, 45);
            btnDarBaja.TabIndex = 3;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.FromArgb(31, 31, 31);
            lblBuscar.Location = new Point(102, 103);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(206, 20);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar por numero de control";
            // 
            // txtBuscarAlumno
            // 
            txtBuscarAlumno.Location = new Point(102, 126);
            txtBuscarAlumno.Multiline = true;
            txtBuscarAlumno.Name = "txtBuscarAlumno";
            txtBuscarAlumno.Size = new Size(249, 30);
            txtBuscarAlumno.TabIndex = 3;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(91, 223);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(1249, 568);
            dgvAlumnos.TabIndex = 6;
            // 
            // frmGestionAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 848);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtBuscarAlumno);
            Controls.Add(lblBuscar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(pictureBox1);
            Name = "frmGestionAlumnos";
            Text = "frmGestionAlumnos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNuevoRegistro;
        private Button btnEditar;
        private Button btnDarBaja;
        private Label lblBuscar;
        private TextBox txtBuscarAlumno;
        private DataGridView dgvAlumnos;
    }
}