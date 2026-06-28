namespace prySistema_prestamos_libros
{
    partial class frmRegistrarEjemplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEjemplar));
            pnlCabecera = new Panel();
            lblTituloModulo = new Label();
            lblBiblioteca = new Label();
            pcbLogo2 = new PictureBox();
            pnlLineaDorada = new Panel();
            panel1 = new Panel();
            pcb1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo2).BeginInit();
            pnlLineaDorada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(17, 30, 51);
            pnlCabecera.Controls.Add(lblTituloModulo);
            pnlCabecera.Controls.Add(lblBiblioteca);
            pnlCabecera.Controls.Add(pcbLogo2);
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
            lblTituloModulo.Size = new Size(132, 30);
            lblTituloModulo.TabIndex = 2;
            lblTituloModulo.Text = " Ejemplares";
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
            // pcbLogo2
            // 
            pcbLogo2.BackColor = Color.FromArgb(17, 30, 71);
            pcbLogo2.Image = (Image)resources.GetObject("pcbLogo2.Image");
            pcbLogo2.Location = new Point(12, 12);
            pcbLogo2.Name = "pcbLogo2";
            pcbLogo2.Size = new Size(87, 73);
            pcbLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo2.TabIndex = 0;
            pcbLogo2.TabStop = false;
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
            // pcb1
            // 
            pcb1.Image = Properties.Resources.contenedor;
            pcb1.Location = new Point(49, 148);
            pcb1.Name = "pcb1";
            pcb1.Size = new Size(1256, 372);
            pcb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb1.TabIndex = 2;
            pcb1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 247, 242);
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(27, 46, 107);
            label1.Location = new Point(98, 181);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 3;
            label1.Text = "Datos del ejemplar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 247, 242);
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(106, 112, 144);
            label2.Location = new Point(98, 234);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 4;
            label2.Text = "Libro al que pertenece";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(250, 247, 242);
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(106, 112, 144);
            label3.Location = new Point(525, 332);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(250, 247, 242);
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(106, 112, 144);
            label4.Location = new Point(98, 332);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 6;
            label4.Text = "Fecha de adquisición";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(250, 247, 242);
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.FromArgb(106, 112, 144);
            label5.Location = new Point(525, 234);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 7;
            label5.Text = "Localización";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(250, 247, 242);
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.FromArgb(106, 112, 144);
            label7.Location = new Point(826, 332);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 9;
            label7.Text = "Estado";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 29);
            comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.FromArgb(31, 31, 31);
            textBox1.Location = new Point(525, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(523, 29);
            textBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ControlLightLight;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(98, 360);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 29);
            dateTimePicker1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(526, 364);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(224, 29);
            numericUpDown1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(826, 360);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 29);
            comboBox2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(201, 168, 76);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(17, 30, 71);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(297, 625);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(107, 122, 153);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(250, 247, 242);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(547, 625);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 17;
            button2.Text = "Limpiar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(242, 196, 196);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(122, 32, 32);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(797, 625);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 18;
            button3.Text = "Cancelar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarEjemplar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pcb1);
            Controls.Add(pnlLineaDorada);
            Controls.Add(pnlCabecera);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmRegistrarEjemplar";
            Text = "Gestion de ejemplares";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo2).EndInit();
            pnlLineaDorada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecera;
        private PictureBox pcbLogo2;
        private Label lblBiblioteca;
        private Label lblTituloModulo;
        private Panel pnlLineaDorada;
        private PictureBox pcb1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}