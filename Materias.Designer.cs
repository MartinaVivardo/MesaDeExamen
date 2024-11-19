namespace MesaDeExamen
{
    partial class Materias
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
            textNomb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvMaterias = new DataGridView();
            btnCancelar = new Button();
            label8 = new Label();
            textBusquedaNombre = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cboCarrera = new ComboBox();
            cboProf = new ComboBox();
            textIdMateria = new TextBox();
            label7 = new Label();
            label9 = new Label();
            textBusquedaId = new TextBox();
            cboAño = new ComboBox();
            FormCarreras = new Button();
            formularioProf = new Button();
            panel1 = new Panel();
            label11 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textNomb
            // 
            textNomb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textNomb.Location = new Point(131, 83);
            textNomb.Margin = new Padding(3, 4, 3, 4);
            textNomb.Name = "textNomb";
            textNomb.Size = new Size(199, 38);
            textNomb.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 82);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 29;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(369, 93);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 27;
            label3.Text = "Profesor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(60, 148);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 37;
            label5.Text = "Año:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(377, 34);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 35;
            label6.Text = "Carrera:";
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(14, 50);
            dgvMaterias.Margin = new Padding(3, 4, 3, 4);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(852, 602);
            dgvMaterias.TabIndex = 39;
            dgvMaterias.SelectionChanged += dgvMaterias_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(300, 355);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 51);
            btnCancelar.TabIndex = 110;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(43, 500);
            label8.Name = "label8";
            label8.Size = new Size(89, 22);
            label8.TabIndex = 109;
            label8.Text = "Nombre:";
            // 
            // textBusquedaNombre
            // 
            textBusquedaNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBusquedaNombre.Location = new Point(144, 484);
            textBusquedaNombre.Margin = new Padding(3, 4, 3, 4);
            textBusquedaNombre.Name = "textBusquedaNombre";
            textBusquedaNombre.Size = new Size(199, 38);
            textBusquedaNombre.TabIndex = 108;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(209, 275);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 51);
            btnGuardar.TabIndex = 107;
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
            btnEliminar.Location = new Point(560, 275);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 51);
            btnEliminar.TabIndex = 106;
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
            btnConsultar.Location = new Point(440, 511);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(134, 51);
            btnConsultar.TabIndex = 105;
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
            btnModificar.Location = new Point(377, 275);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(145, 51);
            btnModificar.TabIndex = 104;
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
            btnAgregar.Location = new Point(46, 275);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 51);
            btnAgregar.TabIndex = 103;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(477, 24);
            cboCarrera.Margin = new Padding(3, 4, 3, 4);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(202, 39);
            cboCarrera.TabIndex = 111;
            // 
            // cboProf
            // 
            cboProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProf.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboProf.FormattingEnabled = true;
            cboProf.Location = new Point(477, 82);
            cboProf.Margin = new Padding(3, 4, 3, 4);
            cboProf.Name = "cboProf";
            cboProf.Size = new Size(202, 39);
            cboProf.TabIndex = 112;
            cboProf.SelectedIndexChanged += cboProf_SelectedIndexChanged;
            // 
            // textIdMateria
            // 
            textIdMateria.Enabled = false;
            textIdMateria.Location = new Point(131, 27);
            textIdMateria.Margin = new Padding(3, 4, 3, 4);
            textIdMateria.Name = "textIdMateria";
            textIdMateria.Size = new Size(138, 27);
            textIdMateria.TabIndex = 113;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(106, 22);
            label7.TabIndex = 114;
            label7.Text = "IdMateria:";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(43, 567);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 115;
            label9.Text = "IdMateria:";
            // 
            // textBusquedaId
            // 
            textBusquedaId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusquedaId.Location = new Point(149, 562);
            textBusquedaId.Margin = new Padding(3, 4, 3, 4);
            textBusquedaId.Name = "textBusquedaId";
            textBusquedaId.Size = new Size(153, 32);
            textBusquedaId.TabIndex = 116;
            // 
            // cboAño
            // 
            cboAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAño.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboAño.FormattingEnabled = true;
            cboAño.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboAño.Location = new Point(131, 138);
            cboAño.Margin = new Padding(3, 4, 3, 4);
            cboAño.Name = "cboAño";
            cboAño.Size = new Size(146, 39);
            cboAño.TabIndex = 118;
            // 
            // FormCarreras
            // 
            FormCarreras.BackColor = Color.DarkRed;
            FormCarreras.FlatStyle = FlatStyle.Flat;
            FormCarreras.Font = new Font("Microsoft PhagsPa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormCarreras.ForeColor = Color.White;
            FormCarreras.Location = new Point(333, 158);
            FormCarreras.Margin = new Padding(3, 4, 3, 4);
            FormCarreras.Name = "FormCarreras";
            FormCarreras.Size = new Size(166, 51);
            FormCarreras.TabIndex = 119;
            FormCarreras.Text = "Abrir carreras";
            FormCarreras.UseVisualStyleBackColor = false;
            FormCarreras.Click += FormCarreras_Click;
            // 
            // formularioProf
            // 
            formularioProf.BackColor = Color.DarkRed;
            formularioProf.FlatStyle = FlatStyle.Flat;
            formularioProf.Font = new Font("Microsoft PhagsPa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            formularioProf.ForeColor = Color.White;
            formularioProf.Location = new Point(525, 158);
            formularioProf.Margin = new Padding(3, 4, 3, 4);
            formularioProf.Name = "formularioProf";
            formularioProf.Size = new Size(166, 51);
            formularioProf.TabIndex = 120;
            formularioProf.Text = "Abrir  profesores";
            formularioProf.UseVisualStyleBackColor = false;
            formularioProf.Click += formularioProf_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1678, 51);
            panel1.TabIndex = 121;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1582, -5);
            label11.Name = "label11";
            label11.Size = new Size(44, 48);
            label11.TabIndex = 56;
            label11.Text = "□";
            label11.Click += label11_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(650, 2);
            label14.Name = "label14";
            label14.Size = new Size(199, 41);
            label14.TabIndex = 102;
            label14.Text = "MATERIAS";
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
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBusquedaId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBusquedaNombre);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cboAño);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(formularioProf);
            panel2.Controls.Add(textNomb);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(FormCarreras);
            panel2.Controls.Add(textIdMateria);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(cboCarrera);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(cboProf);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(14, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 679);
            panel2.TabIndex = 122;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 406);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 121;
            label1.Text = "Buscar por:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dgvMaterias);
            panel3.Location = new Point(780, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 679);
            panel3.TabIndex = 123;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 18);
            label10.Name = "label10";
            label10.Size = new Size(272, 28);
            label10.TabIndex = 55;
            label10.Text = "Datos de las materias:";
            // 
            // Materias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 748);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "Materias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materias";
            Load += Materias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textNomb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private DataGridView dgvMaterias;
        private Button btnCancelar;
        private Label label8;
        private TextBox textBusquedaNombre;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cboCarrera;
        private ComboBox cboProf;
        private TextBox textIdMateria;
        private Label label7;
        private Label label9;
        private TextBox textBusquedaId;
        private ComboBox cboAño;
        private Button FormCarreras;
        private Button formularioProf;
        protected Panel panel1;
        private Label label14;
        private Label label13;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label10;
        private Label label11;
    }
}