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
            pcbContenedorGestion = new PictureBox();
            lblBuscar = new Label();
            txtBuscarClave = new TextBox();
            dgvEjemplares = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            SuspendLayout();
            // 
            // pcbContenedorGestion
            // 
            pcbContenedorGestion.Image = Properties.Resources.contenerdorGrupo;
            pcbContenedorGestion.Location = new Point(31, 27);
            pcbContenedorGestion.Name = "pcbContenedorGestion";
            pcbContenedorGestion.Size = new Size(1287, 797);
            pcbContenedorGestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbContenedorGestion.TabIndex = 2;
            pcbContenedorGestion.TabStop = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = SystemColors.ControlText;
            lblBuscar.Location = new Point(49, 85);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(117, 20);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar por clave";
            // 
            // txtBuscarClave
            // 
            txtBuscarClave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarClave.Location = new Point(49, 108);
            txtBuscarClave.Multiline = true;
            txtBuscarClave.Name = "txtBuscarClave";
            txtBuscarClave.Size = new Size(245, 30);
            txtBuscarClave.TabIndex = 3;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjemplares.Location = new Point(49, 235);
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.RowHeadersWidth = 51;
            dgvEjemplares.Size = new Size(1249, 568);
            dgvEjemplares.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(201, 168, 76);
            btnNuevo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.FromArgb(17, 30, 71);
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(632, 108);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 45);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo ";
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
            btnEditar.Location = new Point(892, 110);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 45);
            btnEditar.TabIndex = 16;
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
            btnDarBaja.Location = new Point(1148, 110);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(150, 45);
            btnDarBaja.TabIndex = 17;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // frmGestionEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 848);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvEjemplares);
            Controls.Add(txtBuscarClave);
            Controls.Add(lblBuscar);
            Controls.Add(pcbContenedorGestion);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmGestionEjemplares";
            Text = "Gestion de ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcbContenedorGestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbContenedorGestion;
        private TextBox txtBuscarClave;
        private Label lblBuscar;
        private DataGridView dgvEjemplares;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDarBaja;
    }
}