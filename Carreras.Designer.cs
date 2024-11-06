namespace MesaDeExamen
{
    partial class Carreras
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
            textDuracion = new TextBox();
            label4 = new Label();
            textNombre = new TextBox();
            label3 = new Label();
            textIdCarrera = new TextBox();
            label2 = new Label();
            dgvCarreras = new DataGridView();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label6 = new Label();
            textBusqueda = new TextBox();
            textIdBusqueda = new TextBox();
            panel1 = new Panel();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textDuracion
            // 
            textDuracion.Enabled = false;
            textDuracion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textDuracion.Location = new Point(521, 89);
            textDuracion.Margin = new Padding(3, 4, 3, 4);
            textDuracion.Name = "textDuracion";
            textDuracion.Size = new Size(138, 32);
            textDuracion.TabIndex = 30;
            textDuracion.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 99);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 29;
            label4.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Enabled = false;
            textNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textNombre.Location = new Point(147, 83);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(208, 38);
            textNombre.TabIndex = 28;
            textNombre.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(405, 99);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 27;
            label3.Text = "Duracion:";
            label3.Click += label3_Click;
            // 
            // textIdCarrera
            // 
            textIdCarrera.Enabled = false;
            textIdCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdCarrera.Location = new Point(147, 15);
            textIdCarrera.Margin = new Padding(3, 4, 3, 4);
            textIdCarrera.Name = "textIdCarrera";
            textIdCarrera.Size = new Size(138, 32);
            textIdCarrera.TabIndex = 26;
            textIdCarrera.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 25);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 25;
            label2.Text = "IdCarrera:";
            // 
            // dgvCarreras
            // 
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Location = new Point(23, 52);
            dgvCarreras.Margin = new Padding(3, 4, 3, 4);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 25;
            dgvCarreras.Size = new Size(845, 627);
            dgvCarreras.TabIndex = 35;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(300, 262);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 51);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(209, 186);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 51);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(558, 186);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 51);
            btnEliminar.TabIndex = 47;
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
            btnConsultar.Location = new Point(405, 488);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(134, 51);
            btnConsultar.TabIndex = 46;
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
            btnModificar.Location = new Point(382, 186);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 51);
            btnModificar.TabIndex = 45;
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
            btnAgregar.Location = new Point(34, 186);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 51);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 473);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 52;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 533);
            label6.Name = "label6";
            label6.Size = new Size(111, 22);
            label6.TabIndex = 53;
            label6.Text = " IdCarrera:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBusqueda.Location = new Point(135, 457);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(208, 38);
            textBusqueda.TabIndex = 54;
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textIdBusqueda.Location = new Point(135, 528);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(138, 31);
            textIdBusqueda.TabIndex = 55;
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
            panel1.Size = new Size(1683, 51);
            panel1.TabIndex = 122;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(650, 2);
            label14.Name = "label14";
            label14.Size = new Size(205, 41);
            label14.TabIndex = 102;
            label14.Text = "CARRERAS";
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textIdBusqueda);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBusqueda);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textIdCarrera);
            panel2.Controls.Add(textNombre);
            panel2.Controls.Add(textDuracion);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(12, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 700);
            panel2.TabIndex = 123;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 391);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 122;
            label1.Text = "Buscar por:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dgvCarreras);
            panel3.Location = new Point(779, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(886, 700);
            panel3.TabIndex = 124;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(23, 15);
            label10.Name = "label10";
            label10.Size = new Size(265, 28);
            label10.TabIndex = 56;
            label10.Text = "Datos de las carreras:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1582, -5);
            label7.Name = "label7";
            label7.Size = new Size(44, 48);
            label7.TabIndex = 57;
            label7.Text = "□";
            label7.Click += label7_Click;
            // 
            // Carreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1683, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carreras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carreras";
            Load += Carreras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textDuracion;
        private Label label4;
        private TextBox textNombre;
        private Label label3;
        private TextBox textIdCarrera;
        private Label label2;
        private DataGridView dgvCarreras;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label5;
        private Label label6;
        private TextBox textBusqueda;
        private TextBox textIdBusqueda;
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