namespace MesaDeExamen
{
    partial class Profesores
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
            label1 = new Label();
            label2 = new Label();
            textIdProf = new TextBox();
            label3 = new Label();
            textApellido = new TextBox();
            label4 = new Label();
            textNomb = new TextBox();
            dgvProfesores = new DataGridView();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnGuardar = new Button();
            textBusqueda = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            label6 = new Label();
            textIdBusqueda = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textApellidoBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "PROFESORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "IdProfesor:";
            // 
            // textIdProf
            // 
            textIdProf.Enabled = false;
            textIdProf.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdProf.Location = new Point(132, 57);
            textIdProf.Name = "textIdProf";
            textIdProf.Size = new Size(60, 27);
            textIdProf.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(227, 64);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Enabled = false;
            textApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textApellido.Location = new Point(340, 61);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 27);
            textApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 114);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // textNomb
            // 
            textNomb.Enabled = false;
            textNomb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNomb.Location = new Point(132, 111);
            textNomb.Name = "textNomb";
            textNomb.Size = new Size(100, 27);
            textNomb.TabIndex = 6;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(588, 57);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowTemplate.Height = 25;
            dgvProfesores.Size = new Size(484, 427);
            dgvProfesores.TabIndex = 24;
            dgvProfesores.Leave += dataGridView1_Leave;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(341, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(303, 363);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 37;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(227, 215);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(11, 215);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(120, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(132, 392);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(100, 27);
            textBusqueda.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 392);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 42;
            label5.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(455, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 447);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 44;
            label6.Text = " IdProfesor:";
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Location = new Point(151, 444);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(81, 23);
            textIdBusqueda.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 297);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 46;
            label7.Text = "Buscar por:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(33, 345);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 47;
            label8.Text = "Apellido:";
            // 
            // textApellidoBusqueda
            // 
            textApellidoBusqueda.Location = new Point(132, 346);
            textApellidoBusqueda.Name = "textApellidoBusqueda";
            textApellidoBusqueda.Size = new Size(100, 23);
            textApellidoBusqueda.TabIndex = 48;
            // 
            // Profesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(textApellidoBusqueda);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textIdBusqueda);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(textBusqueda);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProfesores);
            Controls.Add(textNomb);
            Controls.Add(label4);
            Controls.Add(textApellido);
            Controls.Add(label3);
            Controls.Add(textIdProf);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Profesores";
            Text = "Profesores";
            Load += Profesores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textIdProf;
        private Label label3;
        private TextBox textApellido;
        private Label label4;
        private TextBox textNomb;
        private DataGridView dgvProfesores;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnGuardar;
        private TextBox textBusqueda;
        private Label label5;
        private Button btnCancelar;
        private Label label6;
        private TextBox textIdBusqueda;
        private Label label7;
        private Label label8;
        private TextBox textApellidoBusqueda;
    }
}