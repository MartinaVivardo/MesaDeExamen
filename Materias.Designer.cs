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
            label1 = new Label();
            textAño = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dgvMaterias = new DataGridView();
            btnCancelar = new Button();
            label8 = new Label();
            textBusqueda = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cboCarrera = new ComboBox();
            cboProf = new ComboBox();
            textIdMateria = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // textNomb
            // 
            textNomb.Location = new Point(97, 116);
            textNomb.Name = "textNomb";
            textNomb.Size = new Size(86, 23);
            textNomb.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 115);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 29;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(215, 115);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 27;
            label3.Text = "Profesor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 18);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 24;
            label1.Text = "MATERIAS";
            // 
            // textAño
            // 
            textAño.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textAño.Location = new Point(97, 160);
            textAño.Name = "textAño";
            textAño.Size = new Size(59, 27);
            textAño.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 160);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 37;
            label5.Text = "Año:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(215, 72);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 35;
            label6.Text = "Carrera:";
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(464, 50);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(450, 466);
            dgvMaterias.TabIndex = 39;
            dgvMaterias.SelectionChanged += dgvMaterias_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(159, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 110;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(46, 435);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 109;
            label8.Text = "Buscar por nombre o Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(251, 432);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(100, 27);
            textBusqueda.TabIndex = 108;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(80, 282);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 107;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(237, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 106;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(128, 470);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 105;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(238, 204);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 104;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(80, 204);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 103;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboCarrera
            // 
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(285, 73);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(121, 23);
            cboCarrera.TabIndex = 111;
            // 
            // cboProf
            // 
            cboProf.FormattingEnabled = true;
            cboProf.Location = new Point(295, 115);
            cboProf.Name = "cboProf";
            cboProf.Size = new Size(121, 23);
            cboProf.TabIndex = 112;
            // 
            // textIdMateria
            // 
            textIdMateria.Enabled = false;
            textIdMateria.Location = new Point(97, 77);
            textIdMateria.Name = "textIdMateria";
            textIdMateria.Size = new Size(100, 23);
            textIdMateria.TabIndex = 113;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 76);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 114;
            label7.Text = "IdMateria:";
            label7.Click += label7_Click;
            // 
            // Materias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 528);
            Controls.Add(label7);
            Controls.Add(textIdMateria);
            Controls.Add(cboProf);
            Controls.Add(cboCarrera);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(textBusqueda);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMaterias);
            Controls.Add(textAño);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textNomb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Materias";
            Text = "Materias";
            Load += Materias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textNomb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textAño;
        private Label label5;
        private Label label6;
        private DataGridView dgvMaterias;
        private Button btnCancelar;
        private Label label8;
        private TextBox textBusqueda;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cboCarrera;
        private ComboBox cboProf;
        private TextBox textIdMateria;
        private Label label7;
    }
}