namespace prySistema_prestamos_libros
{
    partial class frmGestionTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionTrabajadores));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pcbContenedorGestion = new PictureBox();
            txtBuscarTrabajador = new TextBox();
            btnDarBaja = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            lblBuscar = new Label();
            dgvTrabajadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorGestion
            // 
            pcbContenedorGestion.BackColor = Color.FromArgb(250, 247, 242);
            pcbContenedorGestion.Image = (Image)resources.GetObject("pcbContenedorGestion.Image");
            pcbContenedorGestion.Location = new Point(104, 41);
            pcbContenedorGestion.Name = "pcbContenedorGestion";
            pcbContenedorGestion.Size = new Size(1287, 797);
            pcbContenedorGestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorGestion.TabIndex = 0;
            pcbContenedorGestion.TabStop = false;
            // 
            // txtBuscarTrabajador
            // 
            txtBuscarTrabajador.BackColor = Color.White;
            txtBuscarTrabajador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTrabajador.ForeColor = Color.Black;
            txtBuscarTrabajador.Location = new Point(123, 125);
            txtBuscarTrabajador.Multiline = true;
            txtBuscarTrabajador.Name = "txtBuscarTrabajador";
            txtBuscarTrabajador.Size = new Size(245, 30);
            txtBuscarTrabajador.TabIndex = 12;
            txtBuscarTrabajador.TextChanged += txtBuscarTrabajador_TextChanged;
            txtBuscarTrabajador.KeyPress += txtBuscarTrabajador_KeyPress;
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
            btnDarBaja.TabIndex = 15;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
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
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo ";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.Black;
            lblBuscar.Location = new Point(123, 102);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(275, 20);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar por numero de control o nombre";
            // 
            // dgvTrabajadores
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 214, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvTrabajadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrabajadores.BackgroundColor = Color.FromArgb(250, 247, 242);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 46, 107);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTrabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajadores.EnableHeadersVisualStyles = false;
            dgvTrabajadores.Location = new Point(123, 238);
            dgvTrabajadores.Name = "dgvTrabajadores";
            dgvTrabajadores.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvTrabajadores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTrabajadores.Size = new Size(1249, 568);
            dgvTrabajadores.TabIndex = 17;
            // 
            // frmGestionTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 875);
            Controls.Add(dgvTrabajadores);
            Controls.Add(txtBuscarTrabajador);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblBuscar);
            Controls.Add(pcbContenedorGestion);
            Name = "frmGestionTrabajadores";
            Text = "Gestion de trabajadores";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbContenedorGestion;
        private TextBox txtBuscarTrabajador;
        private Button btnDarBaja;
        private Button btnEditar;
        private Button btnNuevo;
        private Label lblBuscar;
        private DataGridView dgvTrabajadores;
    }
}