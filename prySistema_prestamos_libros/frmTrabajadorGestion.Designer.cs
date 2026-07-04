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
            pictureBox1 = new PictureBox();
            txtBuscarTrabajador = new TextBox();
            btnDarBaja = new Button();
            btnEditar = new Button();
            btnNuevoRegistro = new Button();
            iblBuscar = new Label();
            dgvTrabajadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(250, 247, 242);
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(28, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1337, 717);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarTrabajador
            // 
            txtBuscarTrabajador.BackColor = Color.White;
            txtBuscarTrabajador.Font = new Font("Segoe UI", 9F);
            txtBuscarTrabajador.Location = new Point(68, 82);
            txtBuscarTrabajador.Margin = new Padding(3, 2, 3, 2);
            txtBuscarTrabajador.Multiline = true;
            txtBuscarTrabajador.Name = "txtBuscarTrabajador";
            txtBuscarTrabajador.Size = new Size(220, 28);
            txtBuscarTrabajador.TabIndex = 16;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBaja.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDarBaja.ForeColor = Color.FromArgb(122, 32, 32);
            btnDarBaja.Image = (Image)resources.GetObject("btnDarBaja.Image");
            btnDarBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.Location = new Point(1095, 70);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(150, 45);
            btnDarBaja.TabIndex = 15;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(250, 247, 242);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(898, 70);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnNuevoRegistro.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoRegistro.Image = Properties.Resources.Nuevo_registro;
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.Location = new Point(703, 70);
            btnNuevoRegistro.Margin = new Padding(3, 2, 3, 2);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(150, 45);
            btnNuevoRegistro.TabIndex = 13;
            btnNuevoRegistro.Text = "Nuevo registro";
            btnNuevoRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            // 
            // iblBuscar
            // 
            iblBuscar.AutoSize = true;
            iblBuscar.BackColor = Color.White;
            iblBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iblBuscar.ForeColor = Color.Black;
            iblBuscar.Location = new Point(68, 62);
            iblBuscar.Name = "iblBuscar";
            iblBuscar.Size = new Size(192, 19);
            iblBuscar.TabIndex = 12;
            iblBuscar.Text = "Buscar por numero de control";
            // 
            // dgvTrabajadores
            // 
            dgvTrabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajadores.Location = new Point(56, 148);
            dgvTrabajadores.Margin = new Padding(3, 2, 3, 2);
            dgvTrabajadores.Name = "dgvTrabajadores";
            dgvTrabajadores.RowHeadersWidth = 51;
            dgvTrabajadores.Size = new Size(1299, 568);
            dgvTrabajadores.TabIndex = 17;
            // 
            // frmGestionTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(dgvTrabajadores);
            Controls.Add(txtBuscarTrabajador);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(iblBuscar);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGestionTrabajadores";
            Text = "frmGestiontrabajadores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtBuscarTrabajador;
        private Button btnDarBaja;
        private Button btnEditar;
        private Button btnNuevoRegistro;
        private Label iblBuscar;
        private DataGridView dgvTrabajadores;
    }
}