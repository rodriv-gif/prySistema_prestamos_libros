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
            pictureBox1 = new PictureBox();
            iblBuscar = new Label();
            txtBuscarLibro = new TextBox();
            dgvLibro = new DataGridView();
            btnNuevoRegistro = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibro).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(33, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1367, 797);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iblBuscar
            // 
            iblBuscar.AutoSize = true;
            iblBuscar.BackColor = Color.White;
            iblBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iblBuscar.ForeColor = Color.Black;
            iblBuscar.Location = new Point(78, 83);
            iblBuscar.Name = "iblBuscar";
            iblBuscar.Size = new Size(196, 23);
            iblBuscar.TabIndex = 1;
            iblBuscar.Text = "Buscar por ISBN o Titulo";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarLibro.Location = new Point(78, 109);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.Size = new Size(220, 30);
            txtBuscarLibro.TabIndex = 2;
            // 
            // dgvLibro
            // 
            dgvLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibro.Location = new Point(65, 205);
            dgvLibro.Name = "dgvLibro";
            dgvLibro.RowHeadersWidth = 51;
            dgvLibro.Size = new Size(1249, 568);
            dgvLibro.TabIndex = 9;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoRegistro.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoRegistro.Image = Properties.Resources.Nuevo_registro;
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.Location = new Point(723, 96);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(150, 45);
            btnNuevoRegistro.TabIndex = 14;
            btnNuevoRegistro.Text = "Nuevo registro";
            btnNuevoRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(250, 247, 242);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(941, 96);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDarBaja.ForeColor = Color.FromArgb(122, 32, 32);
            btnDarBaja.Image = (Image)resources.GetObject("btnDarBaja.Image");
            btnDarBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.Location = new Point(1149, 96);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(150, 45);
            btnDarBaja.TabIndex = 16;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // frmGestionLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 848);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(dgvLibro);
            Controls.Add(txtBuscarLibro);
            Controls.Add(iblBuscar);
            Controls.Add(pictureBox1);
            Name = "frmGestionLibros";
            Text = "frmGestiónLibros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label iblBuscar;
        private TextBox txtBuscarLibro;
        private DataGridView dgvLibro;
        private Button btnNuevoRegistro;
        private Button btnEditar;
        private Button btnDarBaja;
    }
}