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
            pcb11 = new PictureBox();
            lblBuscar = new Label();
            txtBuscarTitulo = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pcb11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pcb11
            // 
            pcb11.Image = Properties.Resources.contenerdorGrupo;
            pcb11.Location = new Point(43, 34);
            pcb11.Name = "pcb11";
            pcb11.Size = new Size(1348, 778);
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
            lblBuscar.Location = new Point(102, 116);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(136, 23);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar por titulo";
            // 
            // txtBuscarTitulo
            // 
            txtBuscarTitulo.Location = new Point(102, 142);
            txtBuscarTitulo.Name = "txtBuscarTitulo";
            txtBuscarTitulo.Size = new Size(313, 34);
            txtBuscarTitulo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(102, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1223, 487);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(201, 168, 76);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(17, 30, 71);
            button1.Location = new Point(649, 142);
            button1.Name = "button1";
            button1.Size = new Size(155, 45);
            button1.TabIndex = 7;
            button1.Text = "Nuevo registro";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(107, 122, 153);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(250, 247, 242);
            button2.Location = new Point(892, 142);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 8;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(242, 196, 196);
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(122, 32, 32);
            button3.Location = new Point(1130, 142);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 9;
            button3.Text = "Dar de baja";
            button3.UseVisualStyleBackColor = false;
            // 
            // frmGestionEjemplares
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 848);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscarTitulo);
            Controls.Add(lblBuscar);
            Controls.Add(pcb11);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmGestionEjemplares";
            Text = "Gestion de ejemplares";
            ((System.ComponentModel.ISupportInitialize)pcb11).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcb11;
        private TextBox txtBuscarTitulo;
        private Label lblBuscar;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}