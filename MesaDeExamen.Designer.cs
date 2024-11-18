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
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvMesa).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 0;
            label2.Text = "IdMesa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 1;
            label1.Text = "MESA DE EXAMEN";
            // 
            // textIdMesa
            // 
            textIdMesa.Enabled = false;
            textIdMesa.Location = new Point(120, 74);
            textIdMesa.Margin = new Padding(3, 2, 3, 2);
            textIdMesa.Name = "textIdMesa";
            textIdMesa.Size = new Size(135, 23);
            textIdMesa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 170);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Llamado:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(120, 120);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.MaxDate = new DateTime(2024, 9, 25, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(135, 23);
            dtpFecha.TabIndex = 5;
            dtpFecha.Value = new DateTime(2024, 9, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 121);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(304, 75);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 7;
            label5.Text = "Profesor vocal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(353, 170);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 10;
            label6.Text = "Materia:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(12, 249);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 39);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(237, 249);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(108, 39);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(120, 251);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 37);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(363, 249);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 37);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(485, 251);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 40);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(397, 370);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(93, 32);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvMesa
            // 
            dgvMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesa.Location = new Point(652, 24);
            dgvMesa.Margin = new Padding(3, 2, 3, 2);
            dgvMesa.Name = "dgvMesa";
            dgvMesa.RowHeadersWidth = 51;
            dgvMesa.RowTemplate.Height = 29;
            dgvMesa.Size = new Size(474, 502);
            dgvMesa.TabIndex = 21;
            dgvMesa.SelectionChanged += dgvMesa_SelectionChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(336, 216);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 22;
            label9.Text = "Finalizada:";
            // 
            // cboFinalizada
            // 
            cboFinalizada.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFinalizada.Enabled = false;
            cboFinalizada.FormattingEnabled = true;
            cboFinalizada.Items.AddRange(new object[] { "Si", "No" });
            cboFinalizada.Location = new Point(439, 214);
            cboFinalizada.Margin = new Padding(3, 2, 3, 2);
            cboFinalizada.Name = "cboFinalizada";
            cboFinalizada.Size = new Size(156, 23);
            cboFinalizada.TabIndex = 23;
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.Enabled = false;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(439, 122);
            cboCarrera.Margin = new Padding(3, 2, 3, 2);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(156, 23);
            cboCarrera.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(350, 122);
            label10.Name = "label10";
            label10.Size = new Size(69, 21);
            label10.TabIndex = 25;
            label10.Text = "Carrera:";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Enabled = false;
            cboMateria.FormattingEnabled = true;
            cboMateria.Location = new Point(439, 168);
            cboMateria.Margin = new Padding(3, 2, 3, 2);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(156, 23);
            cboMateria.TabIndex = 26;
            // 
            // cboLlamado
            // 
            cboLlamado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLlamado.Enabled = false;
            cboLlamado.FormattingEnabled = true;
            cboLlamado.Location = new Point(120, 168);
            cboLlamado.Margin = new Padding(3, 2, 3, 2);
            cboLlamado.Name = "cboLlamado";
            cboLlamado.Size = new Size(135, 23);
            cboLlamado.TabIndex = 27;
            // 
            // cboProf
            // 
            cboProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProf.Enabled = false;
            cboProf.FormattingEnabled = true;
            cboProf.Location = new Point(439, 75);
            cboProf.Margin = new Padding(3, 2, 3, 2);
            cboProf.Name = "cboProf";
            cboProf.Size = new Size(156, 23);
            cboProf.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(28, 370);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 32;
            label12.Text = "Buscar por fecha:";
            // 
            // dtpBuscarFecha
            // 
            dtpBuscarFecha.Format = DateTimePickerFormat.Custom;
            dtpBuscarFecha.Location = new Point(177, 370);
            dtpBuscarFecha.Name = "dtpBuscarFecha";
            dtpBuscarFecha.Size = new Size(153, 23);
            dtpBuscarFecha.TabIndex = 34;
            dtpBuscarFecha.ValueChanged += dtpFecha1_ValueChanged;
            // 
            // MesaDeExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 550);
            Controls.Add(dtpBuscarFecha);
            Controls.Add(label12);
            Controls.Add(cboProf);
            Controls.Add(cboLlamado);
            Controls.Add(cboMateria);
            Controls.Add(label10);
            Controls.Add(cboCarrera);
            Controls.Add(cboFinalizada);
            Controls.Add(label9);
            Controls.Add(dgvMesa);
            Controls.Add(btnConsultar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(textIdMesa);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MesaDeExamen";
            Text = "MesaDeExamen";
            Load += MesaDeExamen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMesa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
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
    }
}