namespace prySistema_prestamos_libros
{
    partial class frmGestion_de_trabajadores
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
            pictureBox1 = new PictureBox();
            txbbuscar_n_control = new TextBox();
            btndar_baja = new Button();
            btneditar = new Button();
            btnnuevoregistro = new Button();
            label1 = new Label();
            dgvgestion_trabajadores = new DataGridView();
            noControl = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvgestion_trabajadores).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagen2222;
            pictureBox1.Location = new Point(26, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1276, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txbbuscar_n_control
            // 
            txbbuscar_n_control.Location = new Point(50, 94);
            txbbuscar_n_control.Name = "txbbuscar_n_control";
            txbbuscar_n_control.Size = new Size(229, 27);
            txbbuscar_n_control.TabIndex = 16;
            // 
            // btndar_baja
            // 
            btndar_baja.Location = new Point(1092, 76);
            btndar_baja.Name = "btndar_baja";
            btndar_baja.Size = new Size(150, 45);
            btndar_baja.TabIndex = 15;
            btndar_baja.Text = "Dar de baja";
            btndar_baja.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(884, 76);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(150, 45);
            btneditar.TabIndex = 14;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btnnuevoregistro
            // 
            btnnuevoregistro.Location = new Point(672, 76);
            btnnuevoregistro.Name = "btnnuevoregistro";
            btnnuevoregistro.Size = new Size(150, 45);
            btnnuevoregistro.TabIndex = 13;
            btnnuevoregistro.Text = "Nuevo registro";
            btnnuevoregistro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 57);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 12;
            label1.Text = "Buscar por numero de control";
            // 
            // dgvgestion_trabajadores
            // 
            dgvgestion_trabajadores.AllowUserToOrderColumns = true;
            dgvgestion_trabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvgestion_trabajadores.Columns.AddRange(new DataGridViewColumn[] { noControl, Nombre, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvgestion_trabajadores.Location = new Point(74, 178);
            dgvgestion_trabajadores.Name = "dgvgestion_trabajadores";
            dgvgestion_trabajadores.RowHeadersWidth = 51;
            dgvgestion_trabajadores.Size = new Size(1168, 518);
            dgvgestion_trabajadores.TabIndex = 17;
            // 
            // noControl
            // 
            noControl.HeaderText = "noControl";
            noControl.MinimumWidth = 6;
            noControl.Name = "noControl";
            noControl.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido Paterno";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido Materno";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Carrera";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefono";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Estatus";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // frmGestion_de_libros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 776);
            Controls.Add(dgvgestion_trabajadores);
            Controls.Add(txbbuscar_n_control);
            Controls.Add(btndar_baja);
            Controls.Add(btneditar);
            Controls.Add(btnnuevoregistro);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmGestion_de_libros";
            Text = "Gestion de trabajadores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvgestion_trabajadores).EndInit();
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
        private DataGridView dgvgestion_trabajadores;
        private DataGridViewTextBoxColumn noControl;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}