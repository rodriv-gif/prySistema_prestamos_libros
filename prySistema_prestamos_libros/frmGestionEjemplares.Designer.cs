namespace prySistema_prestamos_libros
{
    partial class frmGestionEjemplares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEjemplares));
            pcb11 = new PictureBox();
            lblBuscarTitulo = new Label();
            txtBuscarTitulo = new TextBox();
            dgvEjemplares = new DataGridView();
            btnNuevoTitulo = new Button();
            btnEditarEjemplar = new Button();
            btnDarBajaEjemplar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcb11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            SuspendLayout();
            // 
            // pcb11
            // 
            pcb11.Image = Properties.Resources.contenerdorGrupo;
            pcb11.Location = new Point(31, 27);
            pcb11.Name = "pcb11";
            pcb11.Size = new Size(1367, 797);
            pcb11.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb11.TabIndex = 2;
            pcb11.TabStop = false;
            // 
            // lblBuscarTitulo
            // 
            lblBuscarTitulo.AutoSize = true;
            lblBuscarTitulo.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscarTitulo.Font = new Font("Segoe UI", 10.2F);
            lblBuscarTitulo.ForeColor = SystemColors.ControlText;
            lblBuscarTitulo.Location = new Point(68, 62);
            lblBuscarTitulo.Name = "lblBuscarTitulo";
            lblBuscarTitulo.Size = new Size(136, 23);
            lblBuscarTitulo.TabIndex = 3;
            lblBuscarTitulo.Text = "Buscar por titulo";
            // 
            // txtBuscarTitulo
            // 
            txtBuscarTitulo.Location = new Point(68, 93);
            txtBuscarTitulo.Multiline = true;
            txtBuscarTitulo.Name = "txtBuscarTitulo";
            txtBuscarTitulo.Size = new Size(313, 29);
            txtBuscarTitulo.TabIndex = 3;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjemplares.Location = new Point(86, 180);
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.RowHeadersWidth = 51;
            dgvEjemplares.Size = new Size(1249, 568);
            dgvEjemplares.TabIndex = 6;
            // 
            // btnNuevoTitulo
            // 
            btnNuevoTitulo.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoTitulo.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoTitulo.Image = Properties.Resources.Nuevo_registro;
            btnNuevoTitulo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoTitulo.Location = new Point(633, 72);
            btnNuevoTitulo.Margin = new Padding(3, 2, 3, 2);
            btnNuevoTitulo.Name = "btnNuevoTitulo";
            btnNuevoTitulo.Size = new Size(150, 45);
            btnNuevoTitulo.TabIndex = 15;
            btnNuevoTitulo.Text = "Nuevo registro";
            btnNuevoTitulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoTitulo.UseVisualStyleBackColor = false;
            // 
            // btnEditarEjemplar
            // 
            btnEditarEjemplar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditarEjemplar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEjemplar.ForeColor = Color.FromArgb(250, 247, 242);
            btnEditarEjemplar.Image = (Image)resources.GetObject("btnEditarEjemplar.Image");
            btnEditarEjemplar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarEjemplar.Location = new Point(823, 72);
            btnEditarEjemplar.Margin = new Padding(3, 2, 3, 2);
            btnEditarEjemplar.Name = "btnEditarEjemplar";
            btnEditarEjemplar.Size = new Size(150, 45);
            btnEditarEjemplar.TabIndex = 16;
            btnEditarEjemplar.Text = "Editar";
            btnEditarEjemplar.UseVisualStyleBackColor = false;
            // 
            // btnDarBajaEjemplar
            // 
            btnDarBajaEjemplar.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBajaEjemplar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBajaEjemplar.ForeColor = Color.FromArgb(122, 32, 32);
            btnDarBajaEjemplar.Image = (Image)resources.GetObject("btnDarBajaEjemplar.Image");
            btnDarBajaEjemplar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBajaEjemplar.Location = new Point(1005, 72);
            btnDarBajaEjemplar.Margin = new Padding(3, 2, 3, 2);
            btnDarBajaEjemplar.Name = "btnDarBajaEjemplar";
            btnDarBajaEjemplar.Size = new Size(150, 45);
            btnDarBajaEjemplar.TabIndex = 17;
            btnDarBajaEjemplar.Text = "Dar de baja";
            btnDarBajaEjemplar.UseVisualStyleBackColor = false;
            // 
            // frmGestionEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 848);
            Controls.Add(btnDarBajaEjemplar);
            Controls.Add(btnEditarEjemplar);
            Controls.Add(btnNuevoTitulo);
            Controls.Add(dgvEjemplares);
            Controls.Add(txtBuscarTitulo);
            Controls.Add(lblBuscarTitulo);
            Controls.Add(pcb11);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmGestionEjemplares";
            Text = "Gestion de ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcb11).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcb11;
        private TextBox txtBuscarTitulo;
        private Label lblBuscarTitulo;
        private DataGridView dgvEjemplares;
        private Button btnNuevoTitulo;
        private Button btnEditarEjemplar;
        private Button btnDarBajaEjemplar;
    }
}