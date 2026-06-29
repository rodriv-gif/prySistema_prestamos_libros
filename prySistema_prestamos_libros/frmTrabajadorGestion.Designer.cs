namespace prySistema_prestamos_libros
{
    partial class frmTrabajadorGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajadorGestion));
            pictureBox1 = new PictureBox();
            txbbuscar_n_control = new TextBox();
            btndar_baja = new Button();
            btneditar = new Button();
            btnnuevoregistro = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(250, 247, 242);
            pictureBox1.Image = Properties.Resources.contenerdorGrupo;
            pictureBox1.Location = new Point(32, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1367, 797);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txbbuscar_n_control
            // 
            txbbuscar_n_control.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbbuscar_n_control.Location = new Point(64, 96);
            txbbuscar_n_control.Name = "txbbuscar_n_control";
            txbbuscar_n_control.Size = new Size(306, 30);
            txbbuscar_n_control.TabIndex = 16;
            // 
            // btndar_baja
            // 
            btndar_baja.BackColor = Color.FromArgb(242, 196, 196);
            btndar_baja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndar_baja.ForeColor = Color.FromArgb(122, 32, 32);
            btndar_baja.Image = (Image)resources.GetObject("btndar_baja.Image");
            btndar_baja.ImageAlign = ContentAlignment.MiddleLeft;
            btndar_baja.Location = new Point(1149, 96);
            btndar_baja.Name = "btndar_baja";
            btndar_baja.Size = new Size(171, 60);
            btndar_baja.TabIndex = 15;
            btndar_baja.Text = "Dar de baja";
            btndar_baja.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.FromArgb(107, 122, 153);
            btneditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneditar.ForeColor = Color.FromArgb(250, 247, 242);
            btneditar.Image = (Image)resources.GetObject("btneditar.Image");
            btneditar.ImageAlign = ContentAlignment.MiddleLeft;
            btneditar.Location = new Point(941, 96);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(171, 60);
            btneditar.TabIndex = 14;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            // 
            // btnnuevoregistro
            // 
            btnnuevoregistro.BackColor = Color.FromArgb(201, 168, 76);
            btnnuevoregistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnuevoregistro.ForeColor = Color.FromArgb(17, 30, 71);
            btnnuevoregistro.Image = Properties.Resources.Nuevo_registro;
            btnnuevoregistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevoregistro.Location = new Point(729, 96);
            btnnuevoregistro.Name = "btnnuevoregistro";
            btnnuevoregistro.Size = new Size(171, 60);
            btnnuevoregistro.TabIndex = 13;
            btnnuevoregistro.Text = "Nuevo registro";
            btnnuevoregistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevoregistro.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 247, 242);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 75);
            label1.Name = "label1";
            label1.Size = new Size(239, 23);
            label1.TabIndex = 12;
            label1.Text = "Buscar por numero de control";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1299, 568);
            dataGridView1.TabIndex = 17;
            // 
            // frmTrabajadorGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 848);
            Controls.Add(dataGridView1);
            Controls.Add(txbbuscar_n_control);
            Controls.Add(btndar_baja);
            Controls.Add(btneditar);
            Controls.Add(btnnuevoregistro);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmTrabajadorGestion";
            Text = "Gestion de trabajadores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txbbuscar_n_control;
        private Button btndar_baja;
        private Button btneditar;
        private Button btnnuevoregistro;
        private Label label1;
        private DataGridView dataGridView1;
    }
}