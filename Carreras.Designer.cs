namespace MesaDeExamen
{
    partial class Carreras
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
            textDuracion = new TextBox();
            label4 = new Label();
            textNombre = new TextBox();
            label3 = new Label();
            textIdCarrera = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvCarreras = new DataGridView();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label6 = new Label();
            textBusqueda = new TextBox();
            textIdBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // textDuracion
            // 
            textDuracion.Enabled = false;
            textDuracion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textDuracion.Location = new Point(118, 151);
            textDuracion.Name = "textDuracion";
            textDuracion.Size = new Size(100, 27);
            textDuracion.TabIndex = 30;
            textDuracion.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 103);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 29;
            label4.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Enabled = false;
            textNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNombre.Location = new Point(118, 96);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(243, 27);
            textNombre.TabIndex = 28;
            textNombre.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 151);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 27;
            label3.Text = "Duracion:";
            label3.Click += label3_Click;
            // 
            // textIdCarrera
            // 
            textIdCarrera.Enabled = false;
            textIdCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdCarrera.Location = new Point(118, 44);
            textIdCarrera.Name = "textIdCarrera";
            textIdCarrera.Size = new Size(100, 27);
            textIdCarrera.TabIndex = 26;
            textIdCarrera.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 25;
            label2.Text = "IdCarrera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 24;
            label1.Text = "CARRERA";
            label1.Click += label1_Click;
            // 
            // dgvCarreras
            // 
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Location = new Point(454, 44);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 25;
            dgvCarreras.Size = new Size(431, 468);
            dgvCarreras.TabIndex = 35;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(138, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(64, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(221, 272);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 47;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(138, 472);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 46;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(221, 198);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(64, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 390);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 52;
            label5.Text = "Buscar por nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 420);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 53;
            label6.Text = "Buscar por Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Location = new Point(190, 391);
            textBusqueda.Margin = new Padding(3, 2, 3, 2);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(110, 23);
            textBusqueda.TabIndex = 54;
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Location = new Point(190, 416);
            textIdBusqueda.Margin = new Padding(3, 2, 3, 2);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(110, 23);
            textIdBusqueda.TabIndex = 55;
            // 
            // Carreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(textIdBusqueda);
            Controls.Add(textBusqueda);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCarreras);
            Controls.Add(textDuracion);
            Controls.Add(label4);
            Controls.Add(textNombre);
            Controls.Add(label3);
            Controls.Add(textIdCarrera);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carreras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carreras";
            Load += Carreras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textDuracion;
        private Label label4;
        private TextBox textNombre;
        private Label label3;
        private TextBox textIdCarrera;
        private Label label2;
        private Label label1;
        private DataGridView dgvCarreras;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label5;
        private Label label6;
        private TextBox textBusqueda;
        private TextBox textIdBusqueda;
    }
}