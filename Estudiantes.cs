using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;
using static MesaDeExamen.Program;

namespace MesaDeExamen
{
    public partial class Estudiantes : Form
    {
        private List<Estudiante> estudiantes;
        private bool esNuevoRegistro;
        private int idEstudianteActual;

        private string nombreOriginal;
        private string apellidoOriginal;
        private int matriculaOriginal;

        public Estudiantes()
        {

            InitializeComponent();
            estudiantes = new List<Estudiante>();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from Estudiantes", conexión);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvEstudiantes.DataSource = dt;
            }

            MySqlDataAdapter daCarreras = new MySqlDataAdapter("Select * from Carreras", conexión);
            DataTable dtCarreras = new DataTable();
            registros = daCarreras.Fill(dtCarreras);
            if (registros > 0)
            {
                cboIdCarrera.DataSource = dtCarreras;
                cboIdCarrera.DisplayMember = "NombreCarrera";
                cboIdCarrera.ValueMember = "IdCarrera";
            }

        }

        private void textIdEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textApe.Enabled = true;
            textApe.Clear();
            textNom.Enabled = true;
            textNom.Clear();
            cboIdCarrera.Enabled = true;
            cboTipoDoc.Enabled = true;
            textdni.Enabled = true;
            textdni.Clear();
            textMatricula.Enabled = true;
            textMatricula.Clear();
            textIdEstudiante.Text = "0";
            textApe.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realmente eliminar este estudiante?", "Solicitud del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                var cone = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
                cone.Open();

                string sentencia = string.Format("Delete From estudiantes Where idestudiante = {0}", textIdEstudiante.Text.Trim());
                var cmdEliminar = new MySqlCommand(sentencia, cone);
                cmdEliminar.ExecuteNonQuery();

                cone.Close();
                Close();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            
            if (textIdEstudiante.Text == "0" || string.IsNullOrEmpty(textIdEstudiante.Text))
            {
                MessageBox.Show("Por favor, seleccione un estudiante para modificar.");
                return;
            }

            bool lValidado = true;
            string Mensaje = string.Empty;

           
            if (textApe.Text.Trim().Length == 0)
            {
                Mensaje += "Ingrese apellido \r";
                lValidado = false;
            }
            if (textNom.Text.Trim().Length == 0)
            {
                Mensaje += "Ingrese nombre \r";
                lValidado = false;
            }
            if (textdni.Text.Trim().Length < 8)
            {
                Mensaje += "Ingrese DNI válido \r";
                lValidado = false;
            }
            if (Convert.ToInt32(cboIdCarrera.SelectedValue) == 0)
            {
                Mensaje += "Seleccione carrera \r";
                lValidado = false;
            }

            if (!lValidado)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

          
            using (var cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
            {
                try
                {
                    cone.Open();
                    string sentencia = string.Format("Update estudiantes set nombre = '{0}', apellido = '{1}', tipodoc = '{2}', documento = '{3}', idcarrera = {4}, nromatricula = {5} where idestudiante = {6}",
                                                     textNom.Text.Trim(),
                                                     textApe.Text.Trim(),
                                                     cboTipoDoc.SelectedItem.ToString(),
                                                     textdni.Text.Trim(),
                                                     cboIdCarrera.SelectedValue,
                                                     textMatricula.Text.Trim(),
                                                     textIdEstudiante.Text.Trim());

                    var comando = new MySqlCommand(sentencia, cone);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Estudiante modificado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al modificar el estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            if (textApe.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese apellido \r");
                lValidado = false;
            }
            if (textNom.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese nombre \r");
                lValidado = false;
            }
            if (textdni.Text.Trim().Length < 8)
            {
                Mensaje += String.Format("Ingrese DNI \r");
                lValidado = false;
            }

            if (Convert.ToInt32(cboIdCarrera.SelectedValue) == 0)
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
            if (textIdEstudiante.Text.Trim() == "0")
                sentencia = string.Format("Insert Into estudiantes(nombre, apellido, tipodoc, documento, idcarrera, nromatricula) Values('{0}','{1}','{2}','{3}',{4},{5})", textNom.Text.Trim(), textApe.Text.Trim(), cboTipoDoc.SelectedItem.ToString(), textdni.Text.Trim(), cboIdCarrera.SelectedValue, textMatricula.Text.Trim());
            else
                sentencia = string.Format("Update estudiantes set nombre = '{0}', apellido = '{1}', tipodoc = '{2}' , documento = '{3}', idcarrera = {4}, nromatricula = {5} where idestudiante = {6}", textNom.Text.Trim(), textApe.Text.Trim(), cboTipoDoc.SelectedItem.ToString(), textdni.Text.Trim(), cboIdCarrera.SelectedValue, textMatricula.Text.Trim(), textIdEstudiante.Text.Trim());

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            Form1_Load(sender, e);
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esNuevoRegistro && idEstudianteActual != -1)
            {

                textNom.Text = nombreOriginal;
                textApe.Text = apellidoOriginal;
                textMatricula.Text = matriculaOriginal.ToString();
            }

        }

        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            textApe.Text = dgvEstudiantes.CurrentRow.Cells["Apellido"].Value.ToString();
            textNom.Text = dgvEstudiantes.CurrentRow.Cells["Nombre"].Value.ToString();
            textMatricula.Text = dgvEstudiantes.CurrentRow.Cells["NroMatricula"].Value.ToString();
            textdni.Text = dgvEstudiantes.CurrentRow.Cells["Documento"].Value.ToString();
            textIdEstudiante.Text = dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value.ToString();
            cboIdCarrera.Text = dgvEstudiantes.CurrentRow.Cells["IdCarrera"].Value.ToString();
            cboTipoDoc.Text = dgvEstudiantes.CurrentRow.Cells["TipoDoc"].Value.ToString();
        }

        private void cboIdCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
