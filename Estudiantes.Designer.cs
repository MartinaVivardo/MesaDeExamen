﻿namespace MesaDeExamen
{
    partial class Estudiantes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textIdEstudiante = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label = new Label();
            textApe = new TextBox();
            textdni = new TextBox();
            textNom = new TextBox();
            textMatricula = new TextBox();
            cboTipoDoc = new ComboBox();
            cboIdCarrera = new ComboBox();
            dgvEstudiantes = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            textBusqueda = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // textIdEstudiante
            // 
            textIdEstudiante.Enabled = false;
            textIdEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdEstudiante.Location = new Point(134, 56);
            textIdEstudiante.Name = "textIdEstudiante";
            textIdEstudiante.Size = new Size(62, 27);
            textIdEstudiante.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Estudiante";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 120);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(209, 189);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "Documento:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 184);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 5;
            label5.Text = "TipoDoc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 248);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 6;
            label6.Text = "NroMatricula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 56);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 7;
            label7.Text = "IdEstudiante:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(224, 256);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 8;
            label.Text = "Carrera:";
            // 
            // textApe
            // 
            textApe.Enabled = false;
            textApe.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textApe.Location = new Point(114, 117);
            textApe.Name = "textApe";
            textApe.Size = new Size(100, 27);
            textApe.TabIndex = 9;
            // 
            // textdni
            // 
            textdni.Enabled = false;
            textdni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textdni.Location = new Point(309, 181);
            textdni.Name = "textdni";
            textdni.Size = new Size(100, 27);
            textdni.TabIndex = 10;
            // 
            // textNom
            // 
            textNom.Enabled = false;
            textNom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNom.Location = new Point(309, 120);
            textNom.Name = "textNom";
            textNom.Size = new Size(100, 27);
            textNom.TabIndex = 12;
            // 
            // textMatricula
            // 
            textMatricula.Enabled = false;
            textMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textMatricula.Location = new Point(135, 248);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(79, 27);
            textMatricula.TabIndex = 14;
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.Enabled = false;
            cboTipoDoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Items.AddRange(new object[] { "DNI", "Pasaporte", "CUIL/CUIT", "Libreta civica" });
            cboTipoDoc.Location = new Point(112, 180);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(89, 28);
            cboTipoDoc.TabIndex = 15;
            // 
            // cboIdCarrera
            // 
            cboIdCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdCarrera.Enabled = false;
            cboIdCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboIdCarrera.FormattingEnabled = true;
            cboIdCarrera.Location = new Point(309, 253);
            cboIdCarrera.Name = "cboIdCarrera";
            cboIdCarrera.Size = new Size(100, 28);
            cboIdCarrera.TabIndex = 20;
            cboIdCarrera.SelectedIndexChanged += cboIdCarrera_SelectedIndexChanged;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(426, 56);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(438, 453);
            dgvEstudiantes.TabIndex = 21;
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(44, 298);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 38);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(200, 298);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 38);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(158, 489);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(85, 38);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(200, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 38);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(134, 409);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 38);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(23, 459);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 44;
            label9.Text = "Buscar por nombre o Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(228, 456);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(100, 27);
            textBusqueda.TabIndex = 43;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(44, 363);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 91;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 532);
            Controls.Add(btnGuardar);
            Controls.Add(label9);
            Controls.Add(textBusqueda);
            Controls.Add(btnCancelar);
            Controls.Add(dgvEstudiantes);
            Controls.Add(cboIdCarrera);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cboTipoDoc);
            Controls.Add(textMatricula);
            Controls.Add(textNom);
            Controls.Add(textdni);
            Controls.Add(textApe);
            Controls.Add(label);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textIdEstudiante);
            Name = "Estudiantes";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textIdEstudiante;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label;
        private TextBox textApe;
        private TextBox textdni;
        private TextBox textNom;
        private TextBox textMatricula;
        private ComboBox cboTipoDoc;
        private ComboBox cboIdCarrera;
        private DataGridView dgvEstudiantes;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label9;
        private TextBox textBusqueda;
        private Button btnGuardar;
    }
}