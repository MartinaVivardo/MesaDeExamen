namespace MesaDeExamen
{
    partial class Estudiantes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textIdEstudiante = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label = new Label();
            textApe = new TextBox();
            textdni = new TextBox();
            textNom = new TextBox();
            textMatricula = new TextBox();
            cboTipoDoc = new ComboBox();
            cboIdCarrera = new ComboBox();
            dgvEstudiantes = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            textBusqueda = new TextBox();
            btnGuardar = new Button();
            label8 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textIdEstudiante
            // 
            textIdEstudiante.Enabled = false;
            textIdEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdEstudiante.Location = new Point(162, 20);
            textIdEstudiante.Margin = new Padding(3, 4, 3, 4);
            textIdEstudiante.Name = "textIdEstudiante";
            textIdEstudiante.Size = new Size(148, 32);
            textIdEstudiante.TabIndex = 0;
            textIdEstudiante.TextChanged += textIdEstudiante_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 8);
            label1.Name = "label1";
            label1.Size = new Size(254, 28);
            label1.TabIndex = 1;
            label1.Text = "Datos de Estudiante:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 154);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 85);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(401, 227);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 4;
            label4.Text = "Documento:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 227);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 5;
            label5.Text = "TipoDoc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(387, 78);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 6;
            label6.Text = "NroMatricula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 25);
            label7.Name = "label7";
            label7.Size = new Size(133, 22);
            label7.TabIndex = 7;
            label7.Text = "IdEstudiante:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(429, 152);
            label.Name = "label";
            label.Size = new Size(83, 25);
            label.TabIndex = 8;
            label.Text = "Carrera:";
            // 
            // textApe
            // 
            textApe.Enabled = false;
            textApe.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textApe.Location = new Point(162, 143);
            textApe.Margin = new Padding(3, 4, 3, 4);
            textApe.Name = "textApe";
            textApe.Size = new Size(203, 41);
            textApe.TabIndex = 9;
            textApe.TextChanged += textApe_TextChanged;
            // 
            // textdni
            // 
            textdni.Enabled = false;
            textdni.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textdni.Location = new Point(529, 216);
            textdni.Margin = new Padding(3, 4, 3, 4);
            textdni.Name = "textdni";
            textdni.Size = new Size(203, 41);
            textdni.TabIndex = 10;
            // 
            // textNom
            // 
            textNom.Enabled = false;
            textNom.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textNom.Location = new Point(162, 70);
            textNom.Margin = new Padding(3, 4, 3, 4);
            textNom.Name = "textNom";
            textNom.Size = new Size(203, 41);
            textNom.TabIndex = 12;
            // 
            // textMatricula
            // 
            textMatricula.Enabled = false;
            textMatricula.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textMatricula.Location = new Point(531, 67);
            textMatricula.Margin = new Padding(3, 4, 3, 4);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(201, 41);
            textMatricula.TabIndex = 14;
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.Enabled = false;
            cboTipoDoc.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Items.AddRange(new object[] { "DNI", "Pasaporte", "CUIL/CUIT", "Libreta civica" });
            cboTipoDoc.Location = new Point(162, 216);
            cboTipoDoc.Margin = new Padding(3, 4, 3, 4);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(203, 43);
            cboTipoDoc.TabIndex = 15;
            // 
            // cboIdCarrera
            // 
            cboIdCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdCarrera.Enabled = false;
            cboIdCarrera.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            cboIdCarrera.FormattingEnabled = true;
            cboIdCarrera.Items.AddRange(new object[] { "Analista de Sistemas", "Psicopedagogia", "Inicial" });
            cboIdCarrera.Location = new Point(531, 141);
            cboIdCarrera.Margin = new Padding(3, 4, 3, 4);
            cboIdCarrera.Name = "cboIdCarrera";
            cboIdCarrera.Size = new Size(201, 43);
            cboIdCarrera.TabIndex = 20;
            cboIdCarrera.SelectedIndexChanged += cboIdCarrera_SelectedIndexChanged;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(33, 40);
            dgvEstudiantes.Margin = new Padding(3, 4, 3, 4);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(824, 636);
            dgvEstudiantes.TabIndex = 21;
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkRed;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(65, 306);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 51);
            btnAgregar.TabIndex = 86;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkRed;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(387, 306);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 51);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkRed;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(276, 639);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(124, 51);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(571, 306);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 51);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(276, 393);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 51);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(50, 588);
            label9.Name = "label9";
            label9.Size = new Size(96, 25);
            label9.TabIndex = 44;
            label9.Text = " Nombre:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(162, 577);
            textBusqueda.Margin = new Padding(3, 4, 3, 4);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(185, 41);
            textBusqueda.TabIndex = 43;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(219, 306);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 51);
            btnGuardar.TabIndex = 91;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 510);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 92;
            label8.Text = "IdEstudiante:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 448);
            label10.Name = "label10";
            label10.Size = new Size(144, 28);
            label10.TabIndex = 95;
            label10.Text = "Buscar por:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(547, 572);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 41);
            textBox1.TabIndex = 94;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(421, 588);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 96;
            label11.Text = "Apellido:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(381, 510);
            label12.Name = "label12";
            label12.Size = new Size(160, 25);
            label12.TabIndex = 97;
            label12.Text = "Nro documento:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(547, 494);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 41);
            textBox2.TabIndex = 98;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(162, 499);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 41);
            textBox3.TabIndex = 99;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1684, 51);
            panel1.TabIndex = 100;
            panel1.Paint += panel1_Paint;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(1106, -7);
            label15.Name = "label15";
            label15.Size = new Size(44, 48);
            label15.TabIndex = 103;
            label15.Text = "□";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(650, 2);
            label14.Name = "label14";
            label14.Size = new Size(262, 41);
            label14.TabIndex = 102;
            label14.Text = "ESTUDIANTES";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1156, 9);
            label13.Name = "label13";
            label13.Size = new Size(33, 32);
            label13.TabIndex = 0;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textIdEstudiante);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textNom);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textApe);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cboTipoDoc);
            panel2.Controls.Add(textBusqueda);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textdni);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(textMatricula);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(cboIdCarrera);
            panel2.Controls.Add(label);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnAgregar);
            panel2.Location = new Point(12, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 709);
            panel2.TabIndex = 101;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvEstudiantes);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(786, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(879, 695);
            panel3.TabIndex = 102;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 778);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Estudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textIdEstudiante;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label;
        private TextBox textApe;
        private TextBox textdni;
        private TextBox textNom;
        private TextBox textMatricula;
        private ComboBox cboTipoDoc;
        private ComboBox cboIdCarrera;
        private DataGridView dgvEstudiantes;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label9;
        private TextBox textBusqueda;
        private Button btnGuardar;
        private Label label8;
        private Label label10;
        private TextBox textBox1;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private TextBox textBox3;
        protected Panel panel1;
        private Label label13;
        private Panel panel2;
        private Label label14;
        private Panel panel3;
        private Label label15;
    }
}