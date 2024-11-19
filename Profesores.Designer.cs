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
            label8 = new Label();
            textApellidoBusqueda = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "IdProfesor:";
            // 
            // textIdProf
            // 
            textIdProf.Enabled = false;
            textIdProf.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdProf.Location = new Point(173, 24);
            textIdProf.Margin = new Padding(3, 4, 3, 4);
            textIdProf.Name = "textIdProf";
            textIdProf.Size = new Size(138, 32);
            textIdProf.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(390, 103);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Enabled = false;
            textApellido.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textApellido.Location = new Point(502, 87);
            textApellido.Margin = new Padding(3, 4, 3, 4);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(183, 38);
            textApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 103);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // textNomb
            // 
            textNomb.Enabled = false;
            textNomb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textNomb.Location = new Point(173, 87);
            textNomb.Margin = new Padding(3, 4, 3, 4);
            textNomb.Name = "textNomb";
            textNomb.Size = new Size(183, 38);
            textNomb.TabIndex = 6;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(20, 48);
            dgvProfesores.Margin = new Padding(3, 4, 3, 4);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowHeadersWidth = 51;
            dgvProfesores.RowTemplate.Height = 25;
            dgvProfesores.Size = new Size(856, 611);
            dgvProfesores.TabIndex = 24;
            dgvProfesores.Leave += dataGridView1_Leave;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(555, 189);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 51);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkRed;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(449, 474);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(134, 51);
            btnConsultar.TabIndex = 37;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkRed;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(390, 189);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 51);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkRed;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(63, 189);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 51);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(216, 189);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 51);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBusqueda.Location = new Point(173, 478);
            textBusqueda.Margin = new Padding(3, 4, 3, 4);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(183, 34);
            textBusqueda.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 490);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 42;
            label5.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(285, 266);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 51);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 560);
            label6.Name = "label6";
            label6.Size = new Size(119, 22);
            label6.TabIndex = 44;
            label6.Text = " IdProfesor:";
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textIdBusqueda.Location = new Point(173, 551);
            textIdBusqueda.Margin = new Padding(3, 4, 3, 4);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(138, 31);
            textIdBusqueda.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(57, 428);
            label8.Name = "label8";
            label8.Size = new Size(88, 22);
            label8.TabIndex = 47;
            label8.Text = "Apellido:";
            // 
            // textApellidoBusqueda
            // 
            textApellidoBusqueda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textApellidoBusqueda.Location = new Point(173, 416);
            textApellidoBusqueda.Margin = new Padding(3, 4, 3, 4);
            textApellidoBusqueda.Name = "textApellidoBusqueda";
            textApellidoBusqueda.Size = new Size(183, 34);
            textApellidoBusqueda.TabIndex = 48;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1674, 51);
            panel1.TabIndex = 123;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1582, -5);
            label7.Name = "label7";
            label7.Size = new Size(44, 48);
            label7.TabIndex = 58;
            label7.Text = "□";
            label7.Click += label7_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(650, 2);
            label14.Name = "label14";
            label14.Size = new Size(248, 41);
            label14.TabIndex = 102;
            label14.Text = "PROFESORES";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1632, 9);
            label13.Name = "label13";
            label13.Size = new Size(33, 32);
            label13.TabIndex = 0;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textApellidoBusqueda);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textIdBusqueda);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBusqueda);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textIdProf);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textApellido);
            panel2.Controls.Add(textNomb);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnGuardar);
            panel2.Location = new Point(12, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 675);
            panel2.TabIndex = 124;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 359);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 123;
            label1.Text = "Buscar por:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dgvProfesores);
            panel3.Location = new Point(768, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(894, 675);
            panel3.TabIndex = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(20, 16);
            label10.Name = "label10";
            label10.Size = new Size(292, 28);
            label10.TabIndex = 57;
            label10.Text = "Datos de los profesores:";
            // 
            // Profesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1674, 748);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "Profesores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profesores";
            Load += Profesores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Label label8;
        private TextBox textApellidoBusqueda;
        protected Panel panel1;
        private Label label14;
        private Label label13;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label10;
        private Label label7;
    }
}