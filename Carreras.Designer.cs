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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnCancelar = new Button();
            label5 = new Label();
            textBusqueda = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(118, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 30;
            textBox3.TextChanged += textBox3_TextChanged;
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
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(118, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(118, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
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
            label2.Click += label2_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(454, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(431, 468);
            dataGridView1.TabIndex = 35;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(120, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 417);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 50;
            label5.Text = "Buscar por nombre o Id:";
            // 
            // textBusqueda
            // 
            textBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBusqueda.Location = new Point(225, 414);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(100, 27);
            textBusqueda.TabIndex = 49;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(41, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(199, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 40);
            btnEliminar.TabIndex = 47;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(123, 452);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.TabIndex = 46;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(199, 223);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(41, 223);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 40);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Carreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 524);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(textBusqueda);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Carreras";
            Text = "Carreras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnCancelar;
        private Label label5;
        private TextBox textBusqueda;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}