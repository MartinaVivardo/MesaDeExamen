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
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(363, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "PROFESORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "IdProfesor:";
            // 
            // textIdProf
            // 
            textIdProf.Enabled = false;
            textIdProf.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdProf.Location = new Point(151, 76);
            textIdProf.Margin = new Padding(3, 4, 3, 4);
            textIdProf.Name = "textIdProf";
            textIdProf.Size = new Size(68, 32);
            textIdProf.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 144);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Enabled = false;
            textApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textApellido.Location = new Point(151, 140);
            textApellido.Margin = new Padding(3, 4, 3, 4);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(114, 32);
            textApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 207);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // textNomb
            // 
            textNomb.Enabled = false;
            textNomb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNomb.Location = new Point(151, 203);
            textNomb.Margin = new Padding(3, 4, 3, 4);
            textNomb.Name = "textNomb";
            textNomb.Size = new Size(114, 32);
            textNomb.TabIndex = 6;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(356, 57);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowTemplate.Height = 25;
            dgvProfesores.Size = new Size(484, 427);
            dgvProfesores.TabIndex = 24;
            dgvProfesores.Leave += dataGridView1_Leave;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(193, 385);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 53);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(251, 433);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(113, 53);
            btnConsultar.TabIndex = 37;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(193, 287);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 53);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(13, 287);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 53);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(13, 385);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 53);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(164, 395);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(114, 32);
            textBusqueda.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 398);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 42;
            label5.Text = "Buscar por nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(90, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 53);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 444);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 44;
            label6.Text = "Buscar por Id:";
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Location = new Point(132, 441);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(81, 23);
            textIdBusqueda.TabIndex = 45;
            // 
            // Profesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 506);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}