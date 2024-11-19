namespace MesaDeExamen
{
    partial class MesaDeExamen
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
            textIdMesa = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnConsultar = new Button();
            dgvMesa = new DataGridView();
            label9 = new Label();
            cboFinalizada = new ComboBox();
            cboCarrera = new ComboBox();
            label10 = new Label();
            cboMateria = new ComboBox();
            cboLlamado = new ComboBox();
            cboProf = new ComboBox();
            label12 = new Label();
            dtpBuscarFecha = new DateTimePicker();
            panel1 = new Panel();
            label7 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMesa).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 25);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 0;
            label2.Text = "IdMesa:";
            // 
            // textIdMesa
            // 
            textIdMesa.Enabled = false;
            textIdMesa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textIdMesa.Location = new Point(163, 20);
            textIdMesa.Name = "textIdMesa";
            textIdMesa.Size = new Size(154, 31);
            textIdMesa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 100);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 4;
            label3.Text = "Llamado:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(506, 16);
            dtpFecha.MaxDate = new DateTime(2024, 9, 25, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(151, 31);
            dtpFecha.TabIndex = 5;
            dtpFecha.Value = new DateTime(2024, 9, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(419, 20);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 175);
            label5.Name = "label5";
            label5.Size = new Size(146, 22);
            label5.TabIndex = 7;
            label5.Text = "Profesor vocal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(404, 175);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 10;
            label6.Text = "Materia:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkRed;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(42, 324);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 51);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkRed;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(375, 324);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 51);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(207, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 51);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(548, 324);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 51);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(294, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 51);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkRed;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(294, 526);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(134, 51);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvMesa
            // 
            dgvMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesa.Location = new Point(16, 45);
            dgvMesa.Name = "dgvMesa";
            dgvMesa.RowHeadersWidth = 51;
            dgvMesa.RowTemplate.Height = 29;
            dgvMesa.Size = new Size(860, 608);
            dgvMesa.TabIndex = 21;
            dgvMesa.SelectionChanged += dgvMesa_SelectionChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(35, 256);
            label9.Name = "label9";
            label9.Size = new Size(107, 22);
            label9.TabIndex = 22;
            label9.Text = "Finalizada:";
            // 
            // cboFinalizada
            // 
            cboFinalizada.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFinalizada.Enabled = false;
            cboFinalizada.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            cboFinalizada.FormattingEnabled = true;
            cboFinalizada.Items.AddRange(new object[] { "Si", "No" });
            cboFinalizada.Location = new Point(163, 247);
            cboFinalizada.Name = "cboFinalizada";
            cboFinalizada.Size = new Size(178, 38);
            cboFinalizada.TabIndex = 23;
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.Enabled = false;
            cboCarrera.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(506, 84);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(206, 38);
            cboCarrera.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(404, 95);
            label10.Name = "label10";
            label10.Size = new Size(86, 22);
            label10.TabIndex = 25;
            label10.Text = "Carrera:";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Enabled = false;
            cboMateria.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            cboMateria.FormattingEnabled = true;
            cboMateria.Location = new Point(506, 159);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(206, 38);
            cboMateria.TabIndex = 26;
            // 
            // cboLlamado
            // 
            cboLlamado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLlamado.Enabled = false;
            cboLlamado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboLlamado.FormattingEnabled = true;
            cboLlamado.Location = new Point(163, 88);
            cboLlamado.Name = "cboLlamado";
            cboLlamado.Size = new Size(154, 33);
            cboLlamado.TabIndex = 27;
            // 
            // cboProf
            // 
            cboProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProf.Enabled = false;
            cboProf.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            cboProf.FormattingEnabled = true;
            cboProf.Location = new Point(163, 175);
            cboProf.Name = "cboProf";
            cboProf.Size = new Size(206, 38);
            cboProf.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(32, 541);
            label12.Name = "label12";
            label12.Size = new Size(71, 22);
            label12.TabIndex = 32;
            label12.Text = "Fecha:";
            // 
            // dtpBuscarFecha
            // 
            dtpBuscarFecha.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBuscarFecha.Format = DateTimePickerFormat.Custom;
            dtpBuscarFecha.Location = new Point(109, 538);
            dtpBuscarFecha.Margin = new Padding(3, 4, 3, 4);
            dtpBuscarFecha.Name = "dtpBuscarFecha";
            dtpBuscarFecha.Size = new Size(151, 27);
            dtpBuscarFecha.TabIndex = 34;
            dtpBuscarFecha.ValueChanged += dtpFecha1_ValueChanged;
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
            panel1.TabIndex = 124;
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
            label14.Size = new Size(347, 41);
            label14.TabIndex = 102;
            label14.Text = "MESAS DE EXAMEN";
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
            panel2.Controls.Add(textIdMesa);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dtpBuscarFecha);
            panel2.Controls.Add(dtpFecha);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboFinalizada);
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(cboMateria);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cboProf);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cboCarrera);
            panel2.Controls.Add(cboLlamado);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 675);
            panel2.TabIndex = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 476);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 124;
            label1.Text = "Buscar por:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dgvMesa);
            panel3.Location = new Point(768, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(894, 675);
            panel3.TabIndex = 126;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 14);
            label8.Name = "label8";
            label8.Size = new Size(243, 28);
            label8.TabIndex = 58;
            label8.Text = "Datos de las mesas:";
            // 
            // MesaDeExamen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1674, 748);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MesaDeExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MesaDeExamen";
            Load += MesaDeExamen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMesa).EndInit();
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
        private TextBox textIdMesa;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnConsultar;
        private DataGridView dgvMesa;
        private Label label9;
        private ComboBox cboFinalizada;
        private ComboBox cboCarrera;
        private Label label10;
        private ComboBox cboMateria;
        private ComboBox cboLlamado;
        private ComboBox cboProf;
        private Label label12;
        private DateTimePicker dtpBuscarFecha;
        protected Panel panel1;
        private Label label7;
        private Label label14;
        private Label label13;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label8;
    }
}