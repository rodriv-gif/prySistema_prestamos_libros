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
            pcbContenedorGestion = new PictureBox();
            lblBuscarNumero = new Label();
            txtBuscarUsuario = new TextBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorGestion
            // 
            pcbContenedorGestion.Image = (Image)resources.GetObject("pcbContenedorGestion.Image");
            pcbContenedorGestion.Location = new Point(33, 28);
            pcbContenedorGestion.Name = "pcbContenedorGestion";
            pcbContenedorGestion.Size = new Size(1287, 797);
            pcbContenedorGestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorGestion.TabIndex = 0;
            pcbContenedorGestion.TabStop = false;
            // 
            // lblBuscarNumero
            // 
            lblBuscarNumero.AutoSize = true;
            lblBuscarNumero.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscarNumero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarNumero.ForeColor = Color.FromArgb(31, 31, 31);
            lblBuscarNumero.Location = new Point(52, 87);
            lblBuscarNumero.Name = "lblBuscarNumero";
            lblBuscarNumero.Size = new Size(206, 20);
            lblBuscarNumero.TabIndex = 1;
            lblBuscarNumero.Text = "Buscar por numero de control";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.BackColor = Color.White;
            txtBuscarUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarUsuario.Location = new Point(52, 110);
            txtBuscarUsuario.Multiline = true;
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(245, 30);
            txtBuscarUsuario.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(654, 119);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 45);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(107, 122, 153);
            btnEditar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(250, 247, 242);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(907, 119);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 4;
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
            btnDarBaja.Location = new Point(1151, 121);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(150, 45);
            btnDarBaja.TabIndex = 5;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(52, 235);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(1249, 568);
            dgvUsuarios.TabIndex = 6;
            // 
            // frmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 848);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(lblBuscarNumero);
            Controls.Add(pcbContenedorGestion);
            Name = "frmGestionUsuarios";
            Text = "Gestion de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbContenedorGestion;
        private Label lblBuscarNumero;
        private TextBox txtBuscarUsuario;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDarBaja;
        private DataGridView dgvUsuarios;
    }
}