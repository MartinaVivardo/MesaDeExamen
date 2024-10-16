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
            textBusqueda = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvDetalleMesa).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(209, 99);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 84;
            label7.Text = "Mesa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 99);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 80;
            label6.Text = "Llamado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(207, 48);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 74;
            label4.Text = "Estudiante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 221);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 72;
            // 
            // textIdDet
            // 
            textIdDet.Enabled = false;
            textIdDet.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdDet.Location = new Point(126, 43);
            textIdDet.Name = "textIdDet";
            textIdDet.Size = new Size(57, 24);
            textIdDet.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 46);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 70;
            label2.Text = "IdDetalle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 69;
            label1.Text = "DETALLE MESA";
            // 
            // dgvDetalleMesa
            // 
            dgvDetalleMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleMesa.Location = new Point(392, 46);
            dgvDetalleMesa.Name = "dgvDetalleMesa";
            dgvDetalleMesa.RowTemplate.Height = 25;
            dgvDetalleMesa.Size = new Size(372, 468);
            dgvDetalleMesa.TabIndex = 85;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(129, 333);
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
            label8.Location = new Point(2, 422);
            label8.Name = "label8";
            label8.Size = new Size(181, 20);
            label8.TabIndex = 92;
            label8.Text = "Buscar por Nombre o Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(206, 419);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(124, 27);
            textBusqueda.TabIndex = 91;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(50, 275);
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
            btnEliminar.Location = new Point(207, 275);
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
            btnConsultar.Location = new Point(129, 459);
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
            btnModificar.Location = new Point(208, 201);
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
            btnAgregar.Location = new Point(50, 201);
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
            cboLlamado.Location = new Point(103, 99);
            cboLlamado.Name = "cboLlamado";
            cboLlamado.Size = new Size(80, 23);
            cboLlamado.TabIndex = 96;
            // 
            // cboEstudiante
            // 
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.FormattingEnabled = true;
            cboEstudiante.Location = new Point(300, 49);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(80, 23);
            cboEstudiante.TabIndex = 97;
            // 
            // cboMesa
            // 
            cboMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMesa.FormattingEnabled = true;
            cboMesa.Location = new Point(275, 99);
            cboMesa.Name = "cboMesa";
            cboMesa.Size = new Size(96, 23);
            cboMesa.TabIndex = 98;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 152);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 99;
            label10.Text = "Carrera:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(91, 149);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(141, 23);
            cboCarrera.TabIndex = 100;
            // 
            // DetalleMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(cboCarrera);
            Controls.Add(label10);
            Controls.Add(cboMesa);
            Controls.Add(cboEstudiante);
            Controls.Add(cboLlamado);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(textBusqueda);
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
            Name = "DetalleMesa";
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
        private TextBox textBusqueda;
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
    }
}