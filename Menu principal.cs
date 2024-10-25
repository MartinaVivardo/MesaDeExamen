﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesaDeExamen
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();

        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes formulario = new Estudiantes();
            formulario.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            Profesores formulario = new Profesores();
            formulario.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias formulario = new Materias();
            formulario.ShowDialog();
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            MesaDeExamen formulario = new MesaDeExamen();
            formulario.ShowDialog();

        }

        private void btnLlamados_Click(object sender, EventArgs e)
        {
            Llamados formulario = new Llamados();
            formulario.ShowDialog();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            Carreras formulario = new Carreras();
            formulario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void detalleMesa_Click(object sender, EventArgs e)
        {

            DetalleMesa formulario = new DetalleMesa();
            formulario.ShowDialog();
        }

        private void btnEstudiantes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProfesores_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Menu_principal_Resize(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                CenterControls();
            }
        }

        private void CenterControls()
        {
            // Calcular el nuevo centro para cada control
            foreach (Control control in this.Controls)
            {
                // Asegurarte de que los controles no sean null y tengan un tamaño definido
                if (control != null && control.Name != "panel2" && control.Width > 0 && control.Height > 0)
                {
                    control.Left = (this.ClientSize.Width - control.Width) / 2;
                    control.Top = (this.ClientSize.Height - control.Height) / 2;
                }
            }
        }
    }
}

