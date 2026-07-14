namespace prySistema_prestamos_libros
{
    partial class frmGestionLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionLibros));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pcbContenedorGestion = new PictureBox();
            lblBuscar = new Label();
            txtBuscarLibro = new TextBox();
            dgvLibros = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
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
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = SystemColors.ControlText;
            lblBuscar.Location = new Point(123, 102);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(119, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar por ISBN ";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarLibro.Location = new Point(123, 125);
            txtBuscarLibro.Multiline = true;
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.Size = new Size(245, 30);
            txtBuscarLibro.TabIndex = 2;
            // 
            // dgvLibros
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.Location = new Point(123, 238);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLibros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvLibros.Size = new Size(1249, 568);
            dgvLibros.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(750, 125);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 45);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo ";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(250, 247, 242);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(987, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 15;
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
            btnDarBaja.TabIndex = 16;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // frmGestionLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 875);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvLibros);
            Controls.Add(txtBuscarLibro);
            Controls.Add(lblBuscar);
            Controls.Add(pcbContenedorGestion);
            Name = "frmGestionLibros";
            Text = "Gestión de Libros";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBuscar;
        private TextBox txtBuscarLibro;
        private DataGridView dgvLibros;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDarBaja;
        private PictureBox pcbContenedorGestion;
    }
}