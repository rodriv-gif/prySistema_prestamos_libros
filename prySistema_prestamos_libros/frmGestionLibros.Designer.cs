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
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 83);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 1;
            label1.Text = "Buscar por ISBN o Titulo";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(78, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 30);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1299, 568);
            dataGridView1.TabIndex = 9;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(201, 168, 76);
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.FromArgb(17, 30, 71);
            btn1.Image = Properties.Resources.Nuevo_registro;
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(723, 96);
            btn1.Name = "btn1";
            btn1.Size = new Size(171, 60);
            btn1.TabIndex = 14;
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
            btn2.Location = new Point(941, 96);
            btn2.Name = "btn2";
            btn2.Size = new Size(171, 60);
            btn2.TabIndex = 15;
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
            btn3.Location = new Point(1149, 96);
            btn3.Name = "btn3";
            btn3.Size = new Size(171, 60);
            btn3.TabIndex = 16;
            btn3.Text = "Dar de baja";
            btn3.UseVisualStyleBackColor = false;
            // 
            // frmGestionLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 848);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmGestionLibros";
            Text = "Gestión de libros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}