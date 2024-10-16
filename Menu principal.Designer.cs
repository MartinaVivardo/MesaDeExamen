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
            btnEstudiantes = new Button();
            btnProfesores = new Button();
            btnMaterias = new Button();
            btnSalir = new Button();
            btnMesa = new Button();
            btnCarreras = new Button();
            btnLlamados = new Button();
            label1 = new Label();
            detalleMesa = new Button();
            SuspendLayout();
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEstudiantes.ForeColor = Color.Brown;
            btnEstudiantes.Location = new Point(58, 104);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(126, 33);
            btnEstudiantes.TabIndex = 0;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProfesores.ForeColor = Color.Brown;
            btnProfesores.Location = new Point(300, 104);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(111, 28);
            btnProfesores.TabIndex = 1;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnMaterias
            // 
            btnMaterias.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMaterias.ForeColor = Color.Brown;
            btnMaterias.Location = new Point(523, 102);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(97, 30);
            btnMaterias.TabIndex = 2;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Brown;
            btnSalir.Location = new Point(268, 310);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(84, 32);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMesa
            // 
            btnMesa.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMesa.ForeColor = Color.Brown;
            btnMesa.Location = new Point(36, 189);
            btnMesa.Name = "btnMesa";
            btnMesa.Size = new Size(164, 33);
            btnMesa.TabIndex = 4;
            btnMesa.Text = "Mesa de examen";
            btnMesa.UseVisualStyleBackColor = true;
            btnMesa.Click += btnMesa_Click;
            // 
            // btnCarreras
            // 
            btnCarreras.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCarreras.ForeColor = Color.Brown;
            btnCarreras.Location = new Point(523, 189);
            btnCarreras.Name = "btnCarreras";
            btnCarreras.Size = new Size(103, 33);
            btnCarreras.TabIndex = 5;
            btnCarreras.Text = "Carreras";
            btnCarreras.UseVisualStyleBackColor = true;
            btnCarreras.Click += btnCarreras_Click;
            // 
            // btnLlamados
            // 
            btnLlamados.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLlamados.ForeColor = Color.Brown;
            btnLlamados.Location = new Point(303, 177);
            btnLlamados.Name = "btnLlamados";
            btnLlamados.Size = new Size(108, 33);
            btnLlamados.TabIndex = 6;
            btnLlamados.Text = "Llamados";
            btnLlamados.UseVisualStyleBackColor = true;
            btnLlamados.Click += btnLlamados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(215, 42);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 8;
            label1.Text = "GESTION DE MESA DE EXAMEN ";
            // 
            // detalleMesa
            // 
            detalleMesa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            detalleMesa.ForeColor = Color.Brown;
            detalleMesa.Location = new Point(456, 285);
            detalleMesa.Name = "detalleMesa";
            detalleMesa.Size = new Size(164, 30);
            detalleMesa.TabIndex = 9;
            detalleMesa.Text = "Detalle de mesa";
            detalleMesa.UseVisualStyleBackColor = true;
            detalleMesa.Click += detalleMesa_Click;
            // 
            // Menu_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(detalleMesa);
            Controls.Add(label1);
            Controls.Add(btnLlamados);
            Controls.Add(btnCarreras);
            Controls.Add(btnMesa);
            Controls.Add(btnSalir);
            Controls.Add(btnMaterias);
            Controls.Add(btnProfesores);
            Controls.Add(btnEstudiantes);
            Name = "Menu_principal";
            Text = "Menu_principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEstudiantes;
        private Button btnProfesores;
        private Button btnMaterias;
        private Button btnSalir;
        private Button btnMesa;
        private Button btnCarreras;
        private Button btnLlamados;
        private Label label1;
        private Button detalleMesa;
    }
}