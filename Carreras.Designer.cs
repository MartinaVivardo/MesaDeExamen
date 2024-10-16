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
            textDuracion.Location = new Point(135, 201);
            textDuracion.Margin = new Padding(3, 4, 3, 4);
            textDuracion.Name = "textDuracion";
            textDuracion.Size = new Size(114, 32);
            textDuracion.TabIndex = 30;
            textDuracion.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 137);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 29;
            label4.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Enabled = false;
            textNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNombre.Location = new Point(135, 128);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(277, 32);
            textNombre.TabIndex = 28;
            textNombre.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 201);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 27;
            label3.Text = "Duracion:";
            label3.Click += label3_Click;
            // 
            // textIdCarrera
            // 
            textIdCarrera.Enabled = false;
            textIdCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textIdCarrera.Location = new Point(135, 59);
            textIdCarrera.Margin = new Padding(3, 4, 3, 4);
            textIdCarrera.Name = "textIdCarrera";
            textIdCarrera.Size = new Size(114, 32);
            textIdCarrera.TabIndex = 26;
            textIdCarrera.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 25;
            label2.Text = "IdCarrera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(391, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 24;
            label1.Text = "CARRERA";
            label1.Click += label1_Click;
            // 
            // dgvCarreras
            // 
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Location = new Point(519, 59);
            dgvCarreras.Margin = new Padding(3, 4, 3, 4);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 25;
            dgvCarreras.Size = new Size(493, 624);
            dgvCarreras.TabIndex = 35;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(158, 424);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 53);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(73, 363);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 53);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(253, 363);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 53);
            btnEliminar.TabIndex = 47;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(158, 630);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(113, 53);
            btnConsultar.TabIndex = 46;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(253, 264);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 53);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(73, 264);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 53);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 520);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 52;
            label5.Text = "Buscar por nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(68, 560);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 53;
            label6.Text = "Buscar por Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Location = new Point(217, 521);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(125, 27);
            textBusqueda.TabIndex = 54;
            // 
            // textIdBusqueda
            // 
            textIdBusqueda.Location = new Point(217, 554);
            textIdBusqueda.Name = "textIdBusqueda";
            textIdBusqueda.Size = new Size(125, 27);
            textIdBusqueda.TabIndex = 55;
            // 
            // Carreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 743);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carreras";
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