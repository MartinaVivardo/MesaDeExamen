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
            label7 = new Label();
            label8 = new Label();
            textBusqueda = new TextBox();
            textIdBusqueda = new TextBox();
            dgvMesa = new DataGridView();
            label9 = new Label();
            cboFin = new ComboBox();
            cboCarrera = new ComboBox();
            label10 = new Label();
            cboIdMateria = new ComboBox();
            cboLlamado = new ComboBox();
            cboProf = new ComboBox();
            cboBusquedaMateria = new ComboBox();
            label11 = new Label();
            cboBusquedaFecha = new ComboBox();
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
            btnAgregar.Location = new Point(66, 237);
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
            btnModificar.Location = new Point(208, 237);
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
            btnGuardar.Location = new Point(67, 292);
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
            btnEliminar.Location = new Point(217, 292);
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
            btnCancelar.Location = new Point(136, 339);
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
            btnConsultar.Location = new Point(459, 439);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(93, 32);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(66, 441);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 17;
            label7.Text = "Buscar por materia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(67, 470);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 18;
            label8.Text = "Buscar por Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Location = new Point(485, 350);
            textBusqueda.Margin = new Padding(3, 2, 3, 2);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(110, 23);
            textBusqueda.TabIndex = 19;
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Location = new Point(235, 470);
            textIdBusqueda.Margin = new Padding(3, 2, 3, 2);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(110, 23);
            textIdBusqueda.TabIndex = 20;
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
            // cboFin
            // 
            cboFin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFin.Enabled = false;
            cboFin.FormattingEnabled = true;
            cboFin.Items.AddRange(new object[] { "Si", "No" });
            cboFin.Location = new Point(439, 214);
            cboFin.Margin = new Padding(3, 2, 3, 2);
            cboFin.Name = "cboFin";
            cboFin.Size = new Size(156, 23);
            cboFin.TabIndex = 23;
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
            // cboIdMateria
            // 
            cboIdMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdMateria.Enabled = false;
            cboIdMateria.FormattingEnabled = true;
            cboIdMateria.Location = new Point(439, 168);
            cboIdMateria.Margin = new Padding(3, 2, 3, 2);
            cboIdMateria.Name = "cboIdMateria";
            cboIdMateria.Size = new Size(156, 23);
            cboIdMateria.TabIndex = 26;
            // 
            // cboLlamado
            // 
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
            // cboBusquedaMateria
            // 
            cboBusquedaMateria.FormattingEnabled = true;
            cboBusquedaMateria.Location = new Point(252, 439);
            cboBusquedaMateria.Name = "cboBusquedaMateria";
            cboBusquedaMateria.Size = new Size(121, 23);
            cboBusquedaMateria.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(66, 399);
            label11.Name = "label11";
            label11.Size = new Size(130, 20);
            label11.TabIndex = 30;
            label11.Text = "Buscar por fecha:";
            // 
            // cboBusquedaFecha
            // 
            cboBusquedaFecha.FormattingEnabled = true;
            cboBusquedaFecha.Location = new Point(252, 399);
            cboBusquedaFecha.Name = "cboBusquedaFecha";
            cboBusquedaFecha.Size = new Size(121, 23);
            cboBusquedaFecha.TabIndex = 31;
            // 
            // MesaDeExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 550);
            Controls.Add(cboBusquedaFecha);
            Controls.Add(label11);
            Controls.Add(cboBusquedaMateria);
            Controls.Add(cboProf);
            Controls.Add(cboLlamado);
            Controls.Add(cboIdMateria);
            Controls.Add(label10);
            Controls.Add(cboCarrera);
            Controls.Add(cboFin);
            Controls.Add(label9);
            Controls.Add(dgvMesa);
            Controls.Add(textIdBusqueda);
            Controls.Add(textBusqueda);
            Controls.Add(label8);
            Controls.Add(label7);
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
        private Label label7;
        private Label label8;
        private TextBox textBusqueda;
        private TextBox textIdBusqueda;
        private DataGridView dgvMesa;
        private Label label9;
        private ComboBox cboFin;
        private ComboBox cboCarrera;
        private Label label10;
        private ComboBox cboIdMateria;
        private ComboBox cboLlamado;
        private ComboBox cboProf;
        private ComboBox cboBusquedaMateria;
        private Label label11;
        private ComboBox cboBusquedaFecha;
    }
}