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
            ((System.ComponentModel.ISupportInitialize)dgvDetalleMesa).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(294, 145);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 84;
            label7.Text = "Mesa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 99);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 80;
            label6.Text = "Llamado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(215, 44);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
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
            textIdDet.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdDet.Location = new Point(115, 40);
            textIdDet.Name = "textIdDet";
            textIdDet.Size = new Size(57, 24);
            textIdDet.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 43);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 70;
            label2.Text = "IdDetalle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 69;
            label1.Text = "DETALLE MESA";
            // 
            // dgvDetalleMesa
            // 
            dgvDetalleMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleMesa.Location = new Point(552, 49);
            dgvDetalleMesa.Name = "dgvDetalleMesa";
            dgvDetalleMesa.RowTemplate.Height = 25;
            dgvDetalleMesa.Size = new Size(520, 468);
            dgvDetalleMesa.TabIndex = 85;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(447, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 93;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(4, 295);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 92;
            label8.Text = "Buscar por:";
            // 
            // textIdDetalleBusqueda
            // 
            textIdDetalleBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdDetalleBusqueda.Location = new Point(103, 330);
            textIdDetalleBusqueda.Name = "textIdDetalleBusqueda";
            textIdDetalleBusqueda.Size = new Size(124, 27);
            textIdDetalleBusqueda.TabIndex = 91;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(115, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 90;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(342, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 89;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(420, 416);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 88;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(226, 213);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 87;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(4, 213);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 86;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboLlamado
            // 
            cboLlamado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLlamado.FormattingEnabled = true;
            cboLlamado.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cboLlamado.Location = new Point(103, 96);
            cboLlamado.Name = "cboLlamado";
            cboLlamado.Size = new Size(80, 23);
            cboLlamado.TabIndex = 96;
            // 
            // cboEstudiante
            // 
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.FormattingEnabled = true;
            cboEstudiante.Location = new Point(324, 44);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(154, 23);
            cboEstudiante.TabIndex = 97;
            // 
            // cboMesa
            // 
            cboMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMesa.FormattingEnabled = true;
            cboMesa.Location = new Point(364, 142);
            cboMesa.Name = "cboMesa";
            cboMesa.Size = new Size(96, 23);
            cboMesa.TabIndex = 98;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(215, 97);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 99;
            label10.Text = "Carrera:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(322, 99);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(165, 23);
            cboCarrera.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 144);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 101;
            label5.Text = "Materia:";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.FormattingEnabled = true;
            cboMateria.Location = new Point(103, 145);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(165, 23);
            cboMateria.TabIndex = 102;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 333);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 103;
            label9.Text = "IdDetalle:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 377);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 105;
            label11.Text = "Estudiante:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 415);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 108;
            label12.Text = "Carrera:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(12, 448);
            label14.Name = "label14";
            label14.Size = new Size(67, 20);
            label14.TabIndex = 112;
            label14.Text = "Materia:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(10, 493);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 114;
            label15.Text = "Llamado:";
            label15.Click += label15_Click;
            // 
            // textLlamadoBusqueda
            // 
            textLlamadoBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textLlamadoBusqueda.Location = new Point(107, 490);
            textLlamadoBusqueda.Name = "textLlamadoBusqueda";
            textLlamadoBusqueda.Size = new Size(124, 27);
            textLlamadoBusqueda.TabIndex = 113;
            // 
            // textEstudianteBusqueda
            // 
            textEstudianteBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textEstudianteBusqueda.Location = new Point(107, 379);
            textEstudianteBusqueda.Name = "textEstudianteBusqueda";
            textEstudianteBusqueda.Size = new Size(124, 27);
            textEstudianteBusqueda.TabIndex = 115;
            // 
            // textCarreraBusqueda
            // 
            textCarreraBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textCarreraBusqueda.Location = new Point(103, 412);
            textCarreraBusqueda.Name = "textCarreraBusqueda";
            textCarreraBusqueda.Size = new Size(124, 27);
            textCarreraBusqueda.TabIndex = 116;
            // 
            // textMateriaBusqueda
            // 
            textMateriaBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textMateriaBusqueda.Location = new Point(103, 449);
            textMateriaBusqueda.Name = "textMateriaBusqueda";
            textMateriaBusqueda.Size = new Size(124, 27);
            textMateriaBusqueda.TabIndex = 117;
            // 
            // DetalleMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(textMateriaBusqueda);
            Controls.Add(textCarreraBusqueda);
            Controls.Add(textEstudianteBusqueda);
            Controls.Add(label15);
            Controls.Add(textLlamadoBusqueda);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(cboMateria);
            Controls.Add(label5);
            Controls.Add(cboCarrera);
            Controls.Add(label10);
            Controls.Add(cboMesa);
            Controls.Add(cboEstudiante);
            Controls.Add(cboLlamado);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(textIdDetalleBusqueda);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDetalleMesa);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textIdDet);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleMesa";
            Load += DetalleMesa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleMesa).EndInit();
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
    }
}