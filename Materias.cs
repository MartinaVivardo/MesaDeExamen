using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MesaDeExamen
{
    public partial class Materias : Form
    {
        private bool esNuevoRegistro;
        private int IdMateriaActual;

        private string nombreOriginal;
        private int AñoOriginal;

        public Materias()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var coneDB = ConfigurationManager.ConnectionStrings["conexionDB"].ToString();
            var cone = new MySqlConnection(coneDB);
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            if (textNomb.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese nombre de materia \r");
                lValidado = false;
            }
            if (cboProf.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese nombre del profesor\r");
                lValidado = false;
            }
            if (textAño.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese Año de materia \r");
                lValidado = false;
            }

            if (Convert.ToInt32(cboCarrera.SelectedValue) == 0)
            {
                Mensaje += String.Format("Seleccione carrera \r");
                lValidado = false;
            }

            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string sentencia = string.Empty;
            if (textIdMateria.Text.Trim().Length == 0)
                sentencia = string.Format("Insert Into Materias(NombreMateria, IdCarrera, Año, IdProfesor) Values('{0}',{1},{2},{3})", textNomb.Text.Trim(), cboCarrera.SelectedValue, textAño.Text.Trim(), cboProf.SelectedValue);
            else
                sentencia = string.Format("Update materias set NombreMateria = '{0}', IdCarrera = {1}, Año = {2} , IdProfesor = {3} where IdMateria = {4}", textNomb.Text.Trim(), cboCarrera.SelectedValue, textAño.Text.Trim(), cboProf.SelectedValue, textIdMateria.Text.Trim());

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            Materias_Load(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textNomb.Enabled = true;
            cboCarrera.Enabled = true;
            cboProf.Enabled = true;
            textAño.Text = "0";
            textNomb.Clear();
            textIdMateria.Enabled = true;

        }

        private void Materias_Load(object sender, EventArgs e)
        {
            var coneDB = ConfigurationManager.ConnectionStrings["conexionDB"].ToString();
            MySqlConnection conexión = new MySqlConnection(coneDB);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from Materias", conexión);
            DataTable dtMaterias = new DataTable();
            int registros = da.Fill(dtMaterias);
            if (registros > 0)
            {
                dgvMaterias.DataSource = dtMaterias;
            }

            MySqlDataAdapter daCarreras = new MySqlDataAdapter("Select * from Carreras", conexión);
            DataTable dtCarreras = new DataTable();
            registros = daCarreras.Fill(dtCarreras);
            if (registros > 0)
            {
                cboCarrera.DataSource = dtCarreras;
                cboCarrera.DisplayMember = "NombreCarrera";
                cboCarrera.ValueMember = "IdCarrera";

            }

            MySqlDataAdapter daProfesores = new MySqlDataAdapter("Select IdProfesor, concat(Apellido,' ', Nombre) as NombreCompleto from Profesores", conexión);
            DataTable dtProfesores = new DataTable();
            registros = daProfesores.Fill(dtProfesores);
            if (registros > 0)
            {
                cboProf.DataSource = dtProfesores;
                cboProf.DisplayMember = "NombreCompleto";
                cboProf.ValueMember = "IdProfesor";

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {


            textNomb.Text = dgvMaterias.CurrentRow.Cells["NombreMateria"].Value.ToString();
            textAño.Text = dgvMaterias.CurrentRow.Cells["Año"].Value.ToString();
            textIdMateria.Text = dgvMaterias.CurrentRow.Cells["IdMateria"].Value.ToString();
            cboCarrera.Text = dgvMaterias.CurrentRow.Cells["IdCarrera"].Value.ToString();
            cboProf.Text = dgvMaterias.CurrentRow.Cells["IdProfesor"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realmente eliminar esta materia?", "Solicitud del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                var cone = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
                cone.Open();

                string sentencia = string.Format("Delete From materias Where idmateria = {0}", textIdMateria.Text.Trim());
                var cmdEliminar = new MySqlCommand(sentencia, cone);
                cmdEliminar.ExecuteNonQuery();

                cone.Close();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (!esNuevoRegistro && IdMateriaActual != -1)
            {

                textNomb.Text = nombreOriginal;

                textAño.Text = AñoOriginal.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textIdMateria.Text))
            {
                MessageBox.Show("Debe seleccionar una materia para modificar.", "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (textNomb.Text.Trim().Length == 0 || textAño.Text.Trim().Length == 0 || cboCarrera.SelectedValue == null || cboProf.SelectedValue == null)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios antes de modificar.", "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                var coneDB = ConfigurationManager.ConnectionStrings["conexionDB"].ToString();
                using (var cone = new MySqlConnection(coneDB))
                {
                    cone.Open();

                   
                    string sentencia = string.Format(
                        "UPDATE materias SET NombreMateria = '{0}', IdCarrera = {1}, Año = {2}, IdProfesor = {3} WHERE IdMateria = {4}",
                        textNomb.Text.Trim(),
                        cboCarrera.SelectedValue,
                        textAño.Text.Trim(),
                        cboProf.SelectedValue,
                        textIdMateria.Text.Trim()
                    );

                    
                    var comando = new MySqlCommand(sentencia, cone);
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Materia modificada correctamente.", "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                        Materias_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la materia. Verifique los datos e intente nuevamente.", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Ocurrió un error al modificar la materia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
