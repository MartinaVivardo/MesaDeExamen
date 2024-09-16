using System;
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

        }
    }
}

