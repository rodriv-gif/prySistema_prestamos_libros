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
            pnlCabecera = new Panel();
            lblTituloModulo = new Label();
            lblBiblioteca = new Label();
            pcbLogo1 = new PictureBox();
            pnlLineaDorada = new Panel();
            panel1 = new Panel();
            pcb11 = new PictureBox();
            lblBuscar = new Label();
            txtBuscarTitulo = new TextBox();
            btnNuevoEjemplar = new Button();
            btnEditarEjemplar = new Button();
            btnEliminarEjemplar = new Button();
            dgvEjemplares = new DataGridView();
            pictureBox2 = new PictureBox();
            pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo1).BeginInit();
            pnlLineaDorada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(17, 30, 51);
            pnlCabecera.Controls.Add(lblTituloModulo);
            pnlCabecera.Controls.Add(lblBiblioteca);
            pnlCabecera.Controls.Add(pcbLogo1);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1448, 110);
            pnlCabecera.TabIndex = 0;
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloModulo.ForeColor = Color.FromArgb(201, 168, 76);
            lblTituloModulo.Location = new Point(220, 38);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(232, 30);
            lblTituloModulo.TabIndex = 2;
            lblTituloModulo.Text = "Gestionar Ejemplares";
            // 
            // lblBiblioteca
            // 
            lblBiblioteca.AutoSize = true;
            lblBiblioteca.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBiblioteca.ForeColor = Color.FromArgb(201, 168, 76);
            lblBiblioteca.Location = new Point(115, 40);
            lblBiblioteca.Name = "lblBiblioteca";
            lblBiblioteca.Size = new Size(87, 21);
            lblBiblioteca.TabIndex = 1;
            lblBiblioteca.Text = "Biblioteca";
            // 
            // pcbLogo1
            // 
            pcbLogo1.BackColor = Color.FromArgb(17, 30, 71);
            pcbLogo1.Image = (Image)resources.GetObject("pcbLogo1.Image");
            pcbLogo1.Location = new Point(12, 12);
            pcbLogo1.Name = "pcbLogo1";
            pcbLogo1.Size = new Size(87, 73);
            pcbLogo1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo1.TabIndex = 0;
            pcbLogo1.TabStop = false;
            // 
            // pnlLineaDorada
            // 
            pnlLineaDorada.BackColor = Color.FromArgb(201, 168, 76);
            pnlLineaDorada.Controls.Add(panel1);
            pnlLineaDorada.Location = new Point(0, 107);
            pnlLineaDorada.Name = "pnlLineaDorada";
            pnlLineaDorada.Size = new Size(1448, 3);
            pnlLineaDorada.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 168, 76);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1448, 3);
            panel1.TabIndex = 2;
            // 
            // pcb11
            // 
            pcb11.Image = Properties.Resources.contenedor;
            pcb11.Location = new Point(49, 148);
            pcb11.Name = "pcb11";
            pcb11.Size = new Size(1256, 580);
            pcb11.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb11.TabIndex = 2;
            pcb11.TabStop = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(106, 112, 144);
            lblBuscar.Location = new Point(125, 188);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(110, 19);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar por titulo";
            // 
            // txtBuscarTitulo
            // 
            txtBuscarTitulo.Location = new Point(102, 220);
            txtBuscarTitulo.Name = "txtBuscarTitulo";
            txtBuscarTitulo.Size = new Size(313, 29);
            txtBuscarTitulo.TabIndex = 3;
            // 
            // btnNuevoEjemplar
            // 
            btnNuevoEjemplar.BackColor = Color.FromArgb(250, 247, 242);
            btnNuevoEjemplar.Cursor = Cursors.Hand;
            btnNuevoEjemplar.FlatStyle = FlatStyle.Flat;
            btnNuevoEjemplar.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoEjemplar.Image = (Image)resources.GetObject("btnNuevoEjemplar.Image");
            btnNuevoEjemplar.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoEjemplar.Location = new Point(718, 204);
            btnNuevoEjemplar.Name = "btnNuevoEjemplar";
            btnNuevoEjemplar.Size = new Size(155, 45);
            btnNuevoEjemplar.TabIndex = 3;
            btnNuevoEjemplar.Text = "Nuevo registro";
            btnNuevoEjemplar.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoEjemplar.UseVisualStyleBackColor = false;
            // 
            // btnEditarEjemplar
            // 
            btnEditarEjemplar.BackColor = Color.FromArgb(250, 247, 242);
            btnEditarEjemplar.Cursor = Cursors.Hand;
            btnEditarEjemplar.FlatStyle = FlatStyle.Flat;
            btnEditarEjemplar.ForeColor = Color.FromArgb(17, 30, 71);
            btnEditarEjemplar.Image = (Image)resources.GetObject("btnEditarEjemplar.Image");
            btnEditarEjemplar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarEjemplar.Location = new Point(917, 204);
            btnEditarEjemplar.Name = "btnEditarEjemplar";
            btnEditarEjemplar.Size = new Size(90, 45);
            btnEditarEjemplar.TabIndex = 4;
            btnEditarEjemplar.Text = "Editar";
            btnEditarEjemplar.TextAlign = ContentAlignment.MiddleRight;
            btnEditarEjemplar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEjemplar
            // 
            btnEliminarEjemplar.BackColor = Color.FromArgb(250, 247, 242);
            btnEliminarEjemplar.Cursor = Cursors.Hand;
            btnEliminarEjemplar.FlatStyle = FlatStyle.Flat;
            btnEliminarEjemplar.ForeColor = Color.FromArgb(17, 30, 71);
            btnEliminarEjemplar.Image = (Image)resources.GetObject("btnEliminarEjemplar.Image");
            btnEliminarEjemplar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarEjemplar.Location = new Point(1043, 204);
            btnEliminarEjemplar.Name = "btnEliminarEjemplar";
            btnEliminarEjemplar.Size = new Size(155, 45);
            btnEliminarEjemplar.TabIndex = 5;
            btnEliminarEjemplar.Text = "Dar de baja";
            btnEliminarEjemplar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarEjemplar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEjemplar.UseVisualStyleBackColor = false;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.AllowUserToAddRows = false;
            dgvEjemplares.BackgroundColor = Color.White;
            dgvEjemplares.BorderStyle = BorderStyle.None;
            dgvEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjemplares.EnableHeadersVisualStyles = false;
            dgvEjemplares.Location = new Point(102, 267);
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.RowHeadersVisible = false;
            dgvEjemplares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjemplares.Size = new Size(1161, 425);
            dgvEjemplares.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // frmGestionEjemplares
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox2);
            Controls.Add(dgvEjemplares);
            Controls.Add(btnEliminarEjemplar);
            Controls.Add(btnEditarEjemplar);
            Controls.Add(btnNuevoEjemplar);
            Controls.Add(txtBuscarTitulo);
            Controls.Add(lblBuscar);
            Controls.Add(pcb11);
            Controls.Add(pnlLineaDorada);
            Controls.Add(pnlCabecera);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmGestionEjemplares";
            Text = "Gestion de ejemplares";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo1).EndInit();
            pnlLineaDorada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcb11).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecera;
        private PictureBox pcbLogo1;
        private Label lblBiblioteca;
        private Label lblTituloModulo;
        private Panel pnlLineaDorada;
        private PictureBox pcb11;
        private TextBox txtBuscarTitulo;
        private Label lblBuscar;
        private Button btnNuevoEjemplar;
        private Button btnEditarEjemplar;
        private Button btnEliminarEjemplar;
        private DataGridView dgvEjemplares;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}