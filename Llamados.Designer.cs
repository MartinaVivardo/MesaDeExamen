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
            label1 = new Label();
            textAño = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textNroLlamado = new TextBox();
            label4 = new Label();
            textMes = new TextBox();
            label3 = new Label();
            textIdLlamado = new TextBox();
            label2 = new Label();
            dgvLlamados = new DataGridView();
            btnCancelar = new Button();
            label8 = new Label();
            textNroLlamadoBuscar = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label7 = new Label();
            cboActivo = new ComboBox();
            label9 = new Label();
            textIdBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLlamados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "LLAMADOS";
            // 
            // textAño
            // 
            textAño.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textAño.Location = new Point(345, 115);
            textAño.Name = "textAño";
            textAño.Size = new Size(72, 27);
            textAño.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(258, 122);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 51;
            label5.Text = "Año:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 122);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 49;
            label6.Text = "Activo:";
            // 
            // textNroLlamado
            // 
            textNroLlamado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNroLlamado.Location = new Point(373, 66);
            textNroLlamado.Name = "textNroLlamado";
            textNroLlamado.Size = new Size(44, 27);
            textNroLlamado.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(258, 69);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 43;
            label4.Text = "NroLlamado:";
            // 
            // textMes
            // 
            textMes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textMes.Location = new Point(354, 168);
            textMes.Name = "textMes";
            textMes.Size = new Size(52, 27);
            textMes.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(258, 175);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 41;
            label3.Text = "Mes:";
            // 
            // textIdLlamado
            // 
            textIdLlamado.Enabled = false;
            textIdLlamado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdLlamado.Location = new Point(139, 62);
            textIdLlamado.Name = "textIdLlamado";
            textIdLlamado.Size = new Size(52, 27);
            textIdLlamado.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 39;
            label2.Text = "IdLlamado:";
            // 
            // dgvLlamados
            // 
            dgvLlamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLlamados.Location = new Point(477, 53);
            dgvLlamados.Name = "dgvLlamados";
            dgvLlamados.RowTemplate.Height = 25;
            dgvLlamados.Size = new Size(365, 415);
            dgvLlamados.TabIndex = 53;
            dgvLlamados.SelectionChanged += dgvLlamados_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(155, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 102;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 402);
            label8.Name = "label8";
            label8.Size = new Size(179, 20);
            label8.TabIndex = 101;
            label8.Text = "Buscar por NroLlamado:";
            // 
            // textNroLlamadoBuscar
            // 
            textNroLlamadoBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNroLlamadoBuscar.Location = new Point(198, 402);
            textNroLlamadoBuscar.Name = "textNroLlamadoBuscar";
            textNroLlamadoBuscar.Size = new Size(100, 27);
            textNroLlamadoBuscar.TabIndex = 100;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(76, 276);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 99;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(233, 276);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 98;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(345, 413);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 97;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(234, 210);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 96;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(76, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 95;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(87, 192);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 94;
            // 
            // cboActivo
            // 
            cboActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboActivo.FormattingEnabled = true;
            cboActivo.Items.AddRange(new object[] { "Si", "No" });
            cboActivo.Location = new Point(120, 122);
            cboActivo.Name = "cboActivo";
            cboActivo.Size = new Size(89, 28);
            cboActivo.TabIndex = 103;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 448);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 105;
            label9.Text = "Buscar por Id:";
            // 
            // textIdBusca
            // 
            textIdBusca.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdBusca.Location = new Point(198, 445);
            textIdBusca.Name = "textIdBusca";
            textIdBusca.Size = new Size(100, 27);
            textIdBusca.TabIndex = 104;
            // 
            // Llamados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 523);
            Controls.Add(label9);
            Controls.Add(textIdBusca);
            Controls.Add(cboActivo);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(textNroLlamadoBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(dgvLlamados);
            Controls.Add(textAño);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textNroLlamado);
            Controls.Add(label4);
            Controls.Add(textMes);
            Controls.Add(label3);
            Controls.Add(textIdLlamado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Llamados";
            Text = "Llamados";
            Load += Llamados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLlamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textAño;
        private Label label5;
        private Label label6;
        private TextBox textNroLlamado;
        private Label label4;
        private TextBox textMes;
        private Label label3;
        private TextBox textIdLlamado;
        private Label label2;
        private DataGridView dgvLlamados;
        private Button btnCancelar;
        private Label label8;
        private TextBox textNroLlamadoBuscar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label7;
        private ComboBox cboActivo;
        private Label label9;
        private TextBox textIdBusca;
    }
}