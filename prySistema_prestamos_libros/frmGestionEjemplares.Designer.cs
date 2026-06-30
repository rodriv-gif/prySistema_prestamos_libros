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
            lblBuscar = new Label();
            txtBuscarTitulo = new TextBox();
            dgbEjemplares = new DataGridView();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pcb11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgbEjemplares).BeginInit();
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
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(250, 247, 242);
            lblBuscar.Font = new Font("Segoe UI", 10.2F);
            lblBuscar.ForeColor = SystemColors.ControlText;
            lblBuscar.Location = new Point(68, 62);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(136, 23);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar por titulo";
            // 
            // txtBuscarTitulo
            // 
            txtBuscarTitulo.Location = new Point(68, 93);
            txtBuscarTitulo.Multiline = true;
            txtBuscarTitulo.Name = "txtBuscarTitulo";
            txtBuscarTitulo.Size = new Size(313, 29);
            txtBuscarTitulo.TabIndex = 3;
            // 
            // dgbEjemplares
            // 
            dgbEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbEjemplares.Location = new Point(86, 180);
            dgbEjemplares.Name = "dgbEjemplares";
            dgbEjemplares.RowHeadersWidth = 51;
            dgbEjemplares.Size = new Size(1249, 568);
            dgbEjemplares.TabIndex = 6;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(201, 168, 76);
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.FromArgb(17, 30, 71);
            btn1.Image = Properties.Resources.Nuevo_registro;
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(633, 72);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 45);
            btn1.TabIndex = 15;
            btn1.Text = "Nuevo registro";
            btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(107, 122, 153);
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.FromArgb(250, 247, 242);
            btn2.Image = (Image)resources.GetObject("btn2.Image");
            btn2.ImageAlign = ContentAlignment.MiddleLeft;
            btn2.Location = new Point(823, 72);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 45);
            btn2.TabIndex = 16;
            btn2.Text = "Editar";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(242, 196, 196);
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.FromArgb(122, 32, 32);
            btn3.Image = (Image)resources.GetObject("btn3.Image");
            btn3.ImageAlign = ContentAlignment.MiddleLeft;
            btn3.Location = new Point(1005, 72);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 45);
            btn3.TabIndex = 17;
            btn3.Text = "Dar de baja";
            btn3.UseVisualStyleBackColor = false;
            // 
            // frmGestionEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 848);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(dgbEjemplares);
            Controls.Add(txtBuscarTitulo);
            Controls.Add(lblBuscar);
            Controls.Add(pcb11);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmGestionEjemplares";
            Text = "Gestion de ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcb11).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgbEjemplares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcb11;
        private TextBox txtBuscarTitulo;
        private Label lblBuscar;
        private DataGridView dgbEjemplares;
        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}