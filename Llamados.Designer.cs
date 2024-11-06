namespace MesaDeExamen
{
    partial class Llamados
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
            label6 = new Label();
            textNroLlamado = new TextBox();
            label4 = new Label();
            textIdLlamado = new TextBox();
            label2 = new Label();
            dgvLlamados = new DataGridView();
            btnCancelar = new Button();
            label8 = new Label();
            txtIdLlamadoConsulta = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label7 = new Label();
            cboActivo = new ComboBox();
            label9 = new Label();
            txtNroLlamadoConsulta = new TextBox();
            label3 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            label10 = new Label();
            dateTimePickerFechaConsulta = new DateTimePicker();
            panel1 = new Panel();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLlamados).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 97);
            label6.Name = "label6";
            label6.Size = new Size(80, 24);
            label6.TabIndex = 49;
            label6.Text = "Activo:";
            // 
            // textNroLlamado
            // 
            textNroLlamado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNroLlamado.Location = new Point(490, 86);
            textNroLlamado.Margin = new Padding(3, 4, 3, 4);
            textNroLlamado.Name = "textNroLlamado";
            textNroLlamado.Size = new Size(153, 32);
            textNroLlamado.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(346, 94);
            label4.Name = "label4";
            label4.Size = new Size(138, 24);
            label4.TabIndex = 43;
            label4.Text = "NroLlamado:";
            // 
            // textIdLlamado
            // 
            textIdLlamado.Enabled = false;
            textIdLlamado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdLlamado.Location = new Point(490, 22);
            textIdLlamado.Margin = new Padding(3, 4, 3, 4);
            textIdLlamado.Name = "textIdLlamado";
            textIdLlamado.Size = new Size(153, 32);
            textIdLlamado.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(347, 30);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 39;
            label2.Text = "IdLlamado:";
            // 
            // dgvLlamados
            // 
            dgvLlamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLlamados.Location = new Point(28, 49);
            dgvLlamados.Margin = new Padding(3, 4, 3, 4);
            dgvLlamados.Name = "dgvLlamados";
            dgvLlamados.RowHeadersWidth = 51;
            dgvLlamados.RowTemplate.Height = 25;
            dgvLlamados.Size = new Size(824, 592);
            dgvLlamados.TabIndex = 53;
            dgvLlamados.SelectionChanged += dgvLlamados_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(269, 250);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 51);
            btnCancelar.TabIndex = 86;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(36, 481);
            label8.Name = "label8";
            label8.Size = new Size(131, 22);
            label8.TabIndex = 101;
            label8.Text = " NroLlamado:";
            // 
            // txtIdLlamadoConsulta
            // 
            txtIdLlamadoConsulta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdLlamadoConsulta.Location = new Point(180, 411);
            txtIdLlamadoConsulta.Margin = new Padding(3, 4, 3, 4);
            txtIdLlamadoConsulta.Name = "txtIdLlamadoConsulta";
            txtIdLlamadoConsulta.Size = new Size(165, 32);
            txtIdLlamadoConsulta.TabIndex = 100;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(201, 174);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 51);
            btnGuardar.TabIndex = 86;
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
            btnEliminar.Location = new Point(516, 174);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 51);
            btnEliminar.TabIndex = 86;
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
            btnConsultar.Location = new Point(460, 452);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(113, 51);
            btnConsultar.TabIndex = 86;
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
            btnModificar.Location = new Point(343, 174);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 51);
            btnModificar.TabIndex = 86;
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
            btnAgregar.Location = new Point(55, 174);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 51);
            btnAgregar.TabIndex = 86;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(167, 150);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 94;
            // 
            // cboActivo
            // 
            cboActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboActivo.FormattingEnabled = true;
            cboActivo.Items.AddRange(new object[] { "Si", "No" });
            cboActivo.Location = new Point(115, 91);
            cboActivo.Margin = new Padding(3, 4, 3, 4);
            cboActivo.Name = "cboActivo";
            cboActivo.Size = new Size(165, 33);
            cboActivo.TabIndex = 103;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(48, 421);
            label9.Name = "label9";
            label9.Size = new Size(113, 22);
            label9.TabIndex = 105;
            label9.Text = "IdLlamado:";
            // 
            // txtNroLlamadoConsulta
            // 
            txtNroLlamadoConsulta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroLlamadoConsulta.Location = new Point(180, 471);
            txtNroLlamadoConsulta.Margin = new Padding(3, 4, 3, 4);
            txtNroLlamadoConsulta.Name = "txtNroLlamadoConsulta";
            txtNroLlamadoConsulta.Size = new Size(168, 32);
            txtNroLlamadoConsulta.TabIndex = 104;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 30);
            label3.Name = "label3";
            label3.Size = new Size(77, 24);
            label3.TabIndex = 107;
            label3.Text = "Fecha:";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CustomFormat = "MM/yyyy";
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(115, 24);
            dateTimePickerFecha.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.ShowUpDown = true;
            dateTimePickerFecha.Size = new Size(165, 27);
            dateTimePickerFecha.TabIndex = 108;
            dateTimePickerFecha.ValueChanged += dateTimePickerFecha_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(90, 542);
            label10.Name = "label10";
            label10.Size = new Size(71, 22);
            label10.TabIndex = 110;
            label10.Text = "Fecha:";
            // 
            // dateTimePickerFechaConsulta
            // 
            dateTimePickerFechaConsulta.Location = new Point(180, 539);
            dateTimePickerFechaConsulta.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechaConsulta.Name = "dateTimePickerFechaConsulta";
            dateTimePickerFechaConsulta.Size = new Size(228, 27);
            dateTimePickerFechaConsulta.TabIndex = 111;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1666, 51);
            panel1.TabIndex = 112;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(650, 2);
            label14.Name = "label14";
            label14.Size = new Size(206, 41);
            label14.TabIndex = 102;
            label14.Text = "LLAMADOS";
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
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(dateTimePickerFechaConsulta);
            panel2.Controls.Add(textIdLlamado);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textNroLlamado);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNroLlamadoConsulta);
            panel2.Controls.Add(cboActivo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateTimePickerFecha);
            panel2.Controls.Add(txtIdLlamadoConsulta);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Location = new Point(12, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 662);
            panel2.TabIndex = 113;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 331);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 110;
            label1.Text = "Buscar por:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dgvLlamados);
            panel3.Location = new Point(778, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 662);
            panel3.TabIndex = 114;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 17);
            label5.Name = "label5";
            label5.Size = new Size(228, 28);
            label5.TabIndex = 54;
            label5.Text = "Datos del llamado:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(1582, -7);
            label16.Name = "label16";
            label16.Size = new Size(44, 48);
            label16.TabIndex = 71;
            label16.Text = "□";
            label16.Click += label16_Click;
            // 
            // Llamados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 731);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Llamados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Llamados";
            Load += Llamados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLlamados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private TextBox textNroLlamado;
        private Label label4;
        private TextBox textIdLlamado;
        private Label label2;
        private DataGridView dgvLlamados;
        private Button btnCancelar;
        private Label label8;
        private TextBox txtIdLlamadoConsulta;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label7;
        private ComboBox cboActivo;
        private Label label9;
        private TextBox txtNroLlamadoConsulta;
        private Label label3;
        private DateTimePicker dateTimePickerFecha;
        private Label label10;
        private DateTimePicker dateTimePickerFechaConsulta;
        protected Panel panel1;
        private Label label14;
        private Label label13;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private Label label16;
    }
}