namespace MesaDeExamen
{
    partial class Menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_principal));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            exit = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnSalir = new Button();
            detalleMesa = new Button();
            btnLlamados = new Button();
            btnEstudiantes = new Button();
            btnProfesores = new Button();
            btnCarreras = new Button();
            btnMaterias = new Button();
            btnMesa = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(457, 9);
            label1.Name = "label1";
            label1.Size = new Size(462, 36);
            label1.TabIndex = 8;
            label1.Text = "GESTION DE MESA DE EXAMEN ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 63);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1021, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 48);
            label2.TabIndex = 16;
            label2.Text = "□";
            label2.Click += label2_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1085, 11);
            exit.Name = "exit";
            exit.Size = new Size(36, 36);
            exit.TabIndex = 11;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(563, 362);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 267);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(detalleMesa);
            panel2.Controls.Add(btnLlamados);
            panel2.Controls.Add(btnEstudiantes);
            panel2.Controls.Add(btnProfesores);
            panel2.Controls.Add(btnCarreras);
            panel2.Controls.Add(btnMaterias);
            panel2.Controls.Add(btnMesa);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 631);
            panel2.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(64, 541);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 49);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // detalleMesa
            // 
            detalleMesa.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            detalleMesa.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            detalleMesa.FlatStyle = FlatStyle.Flat;
            detalleMesa.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            detalleMesa.ForeColor = Color.White;
            detalleMesa.Location = new Point(34, 373);
            detalleMesa.Margin = new Padding(3, 4, 3, 4);
            detalleMesa.Name = "detalleMesa";
            detalleMesa.Size = new Size(283, 49);
            detalleMesa.TabIndex = 21;
            detalleMesa.Text = "DETALLE DE MESA";
            detalleMesa.UseVisualStyleBackColor = true;
            detalleMesa.Click += detalleMesa_Click;
            // 
            // btnLlamados
            // 
            btnLlamados.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnLlamados.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnLlamados.FlatStyle = FlatStyle.Flat;
            btnLlamados.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLlamados.ForeColor = Color.White;
            btnLlamados.Location = new Point(34, 447);
            btnLlamados.Margin = new Padding(3, 4, 3, 4);
            btnLlamados.Name = "btnLlamados";
            btnLlamados.Size = new Size(283, 49);
            btnLlamados.TabIndex = 20;
            btnLlamados.Text = "LLAMADOS";
            btnLlamados.UseVisualStyleBackColor = true;
            btnLlamados.Click += btnLlamados_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = Color.DarkRed;
            btnEstudiantes.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnEstudiantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstudiantes.ForeColor = Color.White;
            btnEstudiantes.Location = new Point(34, 25);
            btnEstudiantes.Margin = new Padding(3, 4, 3, 4);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(283, 49);
            btnEstudiantes.TabIndex = 19;
            btnEstudiantes.Text = "ESTUDIANTES";
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnProfesores.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnProfesores.FlatStyle = FlatStyle.Flat;
            btnProfesores.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfesores.ForeColor = Color.White;
            btnProfesores.Location = new Point(34, 235);
            btnProfesores.Margin = new Padding(3, 4, 3, 4);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(283, 49);
            btnProfesores.TabIndex = 18;
            btnProfesores.Text = "PROFESORES";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnCarreras
            // 
            btnCarreras.AutoSize = true;
            btnCarreras.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnCarreras.FlatStyle = FlatStyle.Flat;
            btnCarreras.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarreras.ForeColor = Color.White;
            btnCarreras.Location = new Point(34, 92);
            btnCarreras.Margin = new Padding(3, 4, 3, 4);
            btnCarreras.Name = "btnCarreras";
            btnCarreras.Size = new Size(283, 49);
            btnCarreras.TabIndex = 17;
            btnCarreras.Text = "CARRERAS";
            btnCarreras.UseVisualStyleBackColor = true;
            btnCarreras.Click += btnCarreras_Click;
            // 
            // btnMaterias
            // 
            btnMaterias.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnMaterias.FlatStyle = FlatStyle.Flat;
            btnMaterias.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaterias.ForeColor = Color.White;
            btnMaterias.Location = new Point(34, 169);
            btnMaterias.Margin = new Padding(3, 4, 3, 4);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(283, 49);
            btnMaterias.TabIndex = 16;
            btnMaterias.Text = "MATERIAS";
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnMesa
            // 
            btnMesa.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btnMesa.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btnMesa.FlatStyle = FlatStyle.Flat;
            btnMesa.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMesa.ForeColor = Color.White;
            btnMesa.Location = new Point(34, 302);
            btnMesa.Margin = new Padding(3, 4, 3, 4);
            btnMesa.Name = "btnMesa";
            btnMesa.Size = new Size(283, 49);
            btnMesa.TabIndex = 15;
            btnMesa.Text = "MESA DE EXAMEN";
            btnMesa.UseVisualStyleBackColor = true;
            btnMesa.Click += btnMesa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.insti;
            pictureBox1.Location = new Point(525, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Menu_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 689);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_principal";
            Load += Menu_principal_Load;
            Resize += Menu_principal_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label exit;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnSalir;
        private Button detalleMesa;
        private Button btnLlamados;
        private Button btnEstudiantes;
        private Button btnProfesores;
        private Button btnCarreras;
        private Button btnMaterias;
        private Button btnMesa;
        private PictureBox pictureBox1;
        private Label label2;
    }
}