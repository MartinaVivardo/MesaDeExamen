namespace MesaDeExamen
{
    partial class DetalleMesa
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
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textIdDet = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvDetalleMesa = new DataGridView();
            btnCancelar = new Button();
            label8 = new Label();
            textIdDetalleBusqueda = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cboLlamado = new ComboBox();
            cboEstudiante = new ComboBox();
            cboMesa = new ComboBox();
            label10 = new Label();
            cboCarrera = new ComboBox();
            label5 = new Label();
            cboMateria = new ComboBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            textLlamadoBusqueda = new TextBox();
            textEstudianteBusqueda = new TextBox();
            textCarreraBusqueda = new TextBox();
            textMateriaBusqueda = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label13 = new Label();
            panel3 = new Panel();
            exit = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleMesa).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(340, 121);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 84;
            label7.Text = "Mesa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 189);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 80;
            label6.Text = "Llamado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 74);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 74;
            label4.Text = "Estudiante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(128, 275);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 72;
            // 
            // textIdDet
            // 
            textIdDet.Enabled = false;
            textIdDet.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textIdDet.Location = new Point(126, 22);
            textIdDet.Name = "textIdDet";
            textIdDet.Size = new Size(132, 27);
            textIdDet.TabIndex = 71;
            textIdDet.TextChanged += textIdDet_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 70;
            label2.Text = "IdDetalle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(591, 2);
            label1.Name = "label1";
            label1.Size = new Size(218, 33);
            label1.TabIndex = 69;
            label1.Text = "DETALLE MESA";
            // 
            // dgvDetalleMesa
            // 
            dgvDetalleMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleMesa.Location = new Point(22, 36);
            dgvDetalleMesa.Name = "dgvDetalleMesa";
            dgvDetalleMesa.RowHeadersWidth = 51;
            dgvDetalleMesa.RowTemplate.Height = 25;
            dgvDetalleMesa.Size = new Size(855, 477);
            dgvDetalleMesa.TabIndex = 85;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(280, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 93;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(27, 327);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 92;
            label8.Text = "Buscar por:";
            // 
            // textIdDetalleBusqueda
            // 
            textIdDetalleBusqueda.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textIdDetalleBusqueda.Location = new Point(108, 370);
            textIdDetalleBusqueda.Name = "textIdDetalleBusqueda";
            textIdDetalleBusqueda.Size = new Size(124, 31);
            textIdDetalleBusqueda.TabIndex = 91;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkRed;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(205, 230);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 90;
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
            btnEliminar.Location = new Point(466, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 89;
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
            btnConsultar.Location = new Point(528, 416);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 88;
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
            btnModificar.Location = new Point(332, 230);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 40);
            btnModificar.TabIndex = 87;
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
            btnAgregar.Location = new Point(74, 230);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 86;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboLlamado
            // 
            cboLlamado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLlamado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboLlamado.FormattingEnabled = true;
            cboLlamado.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cboLlamado.Location = new Point(126, 174);
            cboLlamado.Name = "cboLlamado";
            cboLlamado.Size = new Size(172, 36);
            cboLlamado.TabIndex = 96;
            // 
            // cboEstudiante
            // 
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstudiante.FormattingEnabled = true;
            cboEstudiante.Location = new Point(126, 64);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(172, 36);
            cboEstudiante.TabIndex = 97;
            // 
            // cboMesa
            // 
            cboMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMesa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboMesa.FormattingEnabled = true;
            cboMesa.Location = new Point(411, 112);
            cboMesa.Name = "cboMesa";
            cboMesa.Size = new Size(172, 36);
            cboMesa.TabIndex = 98;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(320, 68);
            label10.Name = "label10";
            label10.Size = new Size(71, 18);
            label10.TabIndex = 99;
            label10.Text = "Carrera:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(411, 58);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(172, 36);
            cboCarrera.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 128);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 101;
            label5.Text = "Materia:";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboMateria.FormattingEnabled = true;
            cboMateria.Location = new Point(126, 114);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(172, 36);
            cboMateria.TabIndex = 102;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 379);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 103;
            label9.Text = "IdDetalle:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(265, 402);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 105;
            label11.Text = "Estudiante:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(19, 431);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 108;
            label12.Text = "Carrera:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(22, 480);
            label14.Name = "label14";
            label14.Size = new Size(67, 20);
            label14.TabIndex = 112;
            label14.Text = "Materia:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(280, 454);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 114;
            label15.Text = "Llamado:";
            label15.Click += label15_Click;
            // 
            // textLlamadoBusqueda
            // 
            textLlamadoBusqueda.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textLlamadoBusqueda.Location = new Point(367, 446);
            textLlamadoBusqueda.Name = "textLlamadoBusqueda";
            textLlamadoBusqueda.Size = new Size(124, 34);
            textLlamadoBusqueda.TabIndex = 113;
            // 
            // textEstudianteBusqueda
            // 
            textEstudianteBusqueda.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textEstudianteBusqueda.Location = new Point(367, 391);
            textEstudianteBusqueda.Name = "textEstudianteBusqueda";
            textEstudianteBusqueda.Size = new Size(124, 34);
            textEstudianteBusqueda.TabIndex = 115;
            // 
            // textCarreraBusqueda
            // 
            textCarreraBusqueda.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textCarreraBusqueda.Location = new Point(108, 419);
            textCarreraBusqueda.Name = "textCarreraBusqueda";
            textCarreraBusqueda.Size = new Size(124, 34);
            textCarreraBusqueda.TabIndex = 116;
            // 
            // textMateriaBusqueda
            // 
            textMateriaBusqueda.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textMateriaBusqueda.Location = new Point(108, 468);
            textMateriaBusqueda.Name = "textMateriaBusqueda";
            textMateriaBusqueda.Size = new Size(124, 34);
            textMateriaBusqueda.TabIndex = 117;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboEstudiante);
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textMateriaBusqueda);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textIdDet);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(textCarreraBusqueda);
            panel1.Controls.Add(textLlamadoBusqueda);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textEstudianteBusqueda);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(cboCarrera);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(cboMateria);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textIdDetalleBusqueda);
            panel1.Controls.Add(cboMesa);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(cboLlamado);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(20, 41);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 521);
            panel1.TabIndex = 118;
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(dgvDetalleMesa);
            panel2.Location = new Point(686, 41);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 521);
            panel2.TabIndex = 119;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(22, 12);
            label13.Name = "label13";
            label13.Size = new Size(196, 23);
            label13.TabIndex = 86;
            label13.Text = " Datos de Alumnos:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(exit);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 37);
            panel3.TabIndex = 120;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1550, 7);
            exit.Name = "exit";
            exit.Size = new Size(27, 26);
            exit.TabIndex = 12;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // DetalleMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 576);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleMesa";
            Load += DetalleMesa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleMesa).EndInit();
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

        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textIdDet;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetalleMesa;
        private Button btnCancelar;
        private Label label8;
        private TextBox textIdDetalleBusqueda;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cboLlamado;
        private ComboBox cboEstudiante;
        private ComboBox cboMesa;
        private Label label10;
        private ComboBox cboCarrera;
        private Label label5;
        private ComboBox cboMateria;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private TextBox textLlamadoBusqueda;
        private TextBox textEstudianteBusqueda;
        private TextBox textCarreraBusqueda;
        private TextBox textMateriaBusqueda;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label exit;
        private Label label13;
    }
}