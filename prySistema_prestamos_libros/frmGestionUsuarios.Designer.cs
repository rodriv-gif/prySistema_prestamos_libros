namespace prySistema_prestamos_libros
{
    partial class frmGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUsuarios));
            pictureBox1 = new PictureBox();
            lblBuscarNumero = new Label();
            txtBuscarUsuario = new TextBox();
            btnNuevoRegistroUsuario = new Button();
            btnEditarUsuario = new Button();
            btnDarBajaUsuario = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1300, 717);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBuscarNumero
            // 
            lblBuscarNumero.AutoSize = true;
            lblBuscarNumero.Font = new Font("Segoe UI", 10.2F);
            lblBuscarNumero.ForeColor = Color.FromArgb(31, 31, 31);
            lblBuscarNumero.Location = new Point(68, 62);
            lblBuscarNumero.Name = "lblBuscarNumero";
            lblBuscarNumero.Size = new Size(192, 19);
            lblBuscarNumero.TabIndex = 1;
            lblBuscarNumero.Text = "Buscar por numero de control";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.BackColor = Color.White;
            txtBuscarUsuario.Location = new Point(68, 82);
            txtBuscarUsuario.Margin = new Padding(3, 2, 3, 2);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(242, 23);
            txtBuscarUsuario.TabIndex = 2;
            // 
            // btnNuevoRegistroUsuario
            // 
            btnNuevoRegistroUsuario.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevoRegistroUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoRegistroUsuario.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevoRegistroUsuario.Image = (Image)resources.GetObject("btnNuevoRegistroUsuario.Image");
            btnNuevoRegistroUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistroUsuario.Location = new Point(623, 68);
            btnNuevoRegistroUsuario.Margin = new Padding(3, 2, 3, 2);
            btnNuevoRegistroUsuario.Name = "btnNuevoRegistroUsuario";
            btnNuevoRegistroUsuario.Size = new Size(150, 45);
            btnNuevoRegistroUsuario.TabIndex = 3;
            btnNuevoRegistroUsuario.Text = "Nuevo registro";
            btnNuevoRegistroUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoRegistroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(107, 122, 153);
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.Image = (Image)resources.GetObject("btnEditarUsuario.Image");
            btnEditarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarUsuario.Location = new Point(845, 68);
            btnEditarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(150, 45);
            btnEditarUsuario.TabIndex = 4;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnDarBajaUsuario
            // 
            btnDarBajaUsuario.BackColor = Color.FromArgb(242, 196, 196);
            btnDarBajaUsuario.Image = (Image)resources.GetObject("btnDarBajaUsuario.Image");
            btnDarBajaUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBajaUsuario.Location = new Point(1039, 68);
            btnDarBajaUsuario.Margin = new Padding(3, 2, 3, 2);
            btnDarBajaUsuario.Name = "btnDarBajaUsuario";
            btnDarBajaUsuario.Size = new Size(150, 45);
            btnDarBajaUsuario.TabIndex = 5;
            btnDarBajaUsuario.Text = "Dar de baja";
            btnDarBajaUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(57, 154);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(1249, 568);
            dgvUsuarios.TabIndex = 6;
            // 
            // frmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnDarBajaUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnNuevoRegistroUsuario);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(lblBuscarNumero);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGestionUsuarios";
            Text = "Gestion de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblBuscarNumero;
        private TextBox txtBuscarUsuario;
        private Button btnNuevoRegistroUsuario;
        private Button btnEditarUsuario;
        private Button btnDarBajaUsuario;
        private DataGridView dgvUsuarios;
    }
}