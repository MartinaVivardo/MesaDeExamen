﻿namespace MesaDeExamen
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
            label10 = new Label();
            cboAño = new ComboBox();
            FormCarreras = new Button();
            formularioProf = new Button();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 160);
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
            dgvMaterias.Location = new Point(622, 27);
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
            btnCancelar.Location = new Point(368, 218);
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
            label8.Location = new Point(12, 331);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 109;
            label8.Text = "Nombre:";
            // 
            // textBusquedaNombre
            // 
            textBusquedaNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusquedaNombre.Location = new Point(189, 331);
            textBusquedaNombre.Name = "textBusquedaNombre";
            textBusquedaNombre.Size = new Size(100, 27);
            textBusquedaNombre.TabIndex = 108;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(139, 218);
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
            btnEliminar.Location = new Point(486, 218);
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
            btnConsultar.Location = new Point(409, 349);
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
            btnModificar.Location = new Point(252, 218);
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
            btnAgregar.Location = new Point(21, 218);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 103;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(285, 73);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(121, 23);
            cboCarrera.TabIndex = 111;
            // 
            // cboProf
            // 
            cboProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProf.FormattingEnabled = true;
            cboProf.Location = new Point(295, 115);
            cboProf.Name = "cboProf";
            cboProf.Size = new Size(121, 23);
            cboProf.TabIndex = 112;
            cboProf.SelectedIndexChanged += cboProf_SelectedIndexChanged;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 381);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 115;
            label9.Text = "IdMateria:";
            // 
            // textBusquedaId
            // 
            textBusquedaId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusquedaId.Location = new Point(189, 381);
            textBusquedaId.Name = "textBusquedaId";
            textBusquedaId.Size = new Size(100, 27);
            textBusquedaId.TabIndex = 116;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 292);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 117;
            label10.Text = "Buscar por:";
            // 
            // cboAño
            // 
            cboAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAño.FormattingEnabled = true;
            cboAño.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboAño.Location = new Point(76, 161);
            cboAño.Name = "cboAño";
            cboAño.Size = new Size(55, 23);
            cboAño.TabIndex = 118;
            // 
            // FormCarreras
            // 
            FormCarreras.Location = new Point(446, 73);
            FormCarreras.Name = "FormCarreras";
            FormCarreras.Size = new Size(139, 23);
            FormCarreras.TabIndex = 119;
            FormCarreras.Text = "Abrir carreras";
            FormCarreras.UseVisualStyleBackColor = true;
            FormCarreras.Click += FormCarreras_Click;
            // 
            // formularioProf
            // 
            formularioProf.Location = new Point(446, 115);
            formularioProf.Name = "formularioProf";
            formularioProf.Size = new Size(163, 23);
            formularioProf.TabIndex = 120;
            formularioProf.Text = "Abrir  profesores";
            formularioProf.UseVisualStyleBackColor = true;
            formularioProf.Click += formularioProf_Click;
            // 
            // Materias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(formularioProf);
            Controls.Add(FormCarreras);
            Controls.Add(cboAño);
            Controls.Add(label10);
            Controls.Add(textBusquedaId);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textIdMateria);
            Controls.Add(cboProf);
            Controls.Add(cboCarrera);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(textBusquedaNombre);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMaterias);
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
        private Label label10;
        private ComboBox cboAño;
        private Button FormCarreras;
        private Button formularioProf;
    }
}