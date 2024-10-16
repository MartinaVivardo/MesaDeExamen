namespace MesaDeExamen
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
            label8 = new Label();
            textBusquedaId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // textIdEstudiante
            // 
            textIdEstudiante.Enabled = false;
            textIdEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdEstudiante.Location = new Point(134, 26);
            textIdEstudiante.Name = "textIdEstudiante";
            textIdEstudiante.Size = new Size(70, 32);
            textIdEstudiante.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(405, 12);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Estudiante";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 90);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(209, 159);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 4;
            label4.Text = "Documento:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 154);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 5;
            label5.Text = "TipoDoc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 218);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 6;
            label6.Text = "NroMatricula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 26);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 7;
            label7.Text = "IdEstudiante:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(209, 218);
            label.Name = "label";
            label.Size = new Size(83, 25);
            label.TabIndex = 8;
            label.Text = "Carrera:";
            // 
            // textApe
            // 
            textApe.Enabled = false;
            textApe.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textApe.Location = new Point(114, 87);
            textApe.Name = "textApe";
            textApe.Size = new Size(114, 32);
            textApe.TabIndex = 9;
            textApe.TextChanged += textApe_TextChanged;
            // 
            // textdni
            // 
            textdni.Enabled = false;
            textdni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textdni.Location = new Point(309, 151);
            textdni.Name = "textdni";
            textdni.Size = new Size(114, 32);
            textdni.TabIndex = 10;
            // 
            // textNom
            // 
            textNom.Enabled = false;
            textNom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNom.Location = new Point(309, 90);
            textNom.Name = "textNom";
            textNom.Size = new Size(114, 32);
            textNom.TabIndex = 12;
            // 
            // textMatricula
            // 
            textMatricula.Enabled = false;
            textMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textMatricula.Location = new Point(117, 211);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(60, 27);
            textMatricula.TabIndex = 14;
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.Enabled = false;
            cboTipoDoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Items.AddRange(new object[] { "DNI", "Pasaporte", "CUIL/CUIT", "Libreta civica" });
            cboTipoDoc.Location = new Point(95, 151);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(111, 28);
            cboTipoDoc.TabIndex = 15;
            // 
            // cboIdCarrera
            // 
            cboIdCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdCarrera.Enabled = false;
            cboIdCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboIdCarrera.FormattingEnabled = true;
            cboIdCarrera.Items.AddRange(new object[] { "Analista de Sistemas", "Psicopedagogia", "Inicial" });
            cboIdCarrera.Location = new Point(279, 215);
            cboIdCarrera.Name = "cboIdCarrera";
            cboIdCarrera.Size = new Size(130, 28);
            cboIdCarrera.TabIndex = 20;
            cboIdCarrera.SelectedIndexChanged += cboIdCarrera_SelectedIndexChanged;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(487, 75);
            dgvEstudiantes.Margin = new Padding(3, 4, 3, 4);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(501, 604);
            dgvEstudiantes.TabIndex = 21;
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(47, 265);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 51);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(203, 265);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 51);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(324, 448);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(145, 51);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(203, 332);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 51);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(137, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 51);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 438);
            label9.Name = "label9";
            label9.Size = new Size(147, 20);
            label9.TabIndex = 44;
            label9.Text = "Buscar por nombre:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(188, 438);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(114, 32);
            textBusqueda.TabIndex = 43;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(47, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 53);
            btnGuardar.TabIndex = 91;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 466);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 92;
            label8.Text = "Buscar por Id:";
            // 
            // textBusquedaId
            // 
            textBusquedaId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusquedaId.Location = new Point(188, 471);
            textBusquedaId.Name = "textBusquedaId";
            textBusquedaId.Size = new Size(100, 27);
            textBusquedaId.TabIndex = 93;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 532);
            Controls.Add(textBusquedaId);
            Controls.Add(label8);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label8;
        private TextBox textBusquedaId;
    }
}