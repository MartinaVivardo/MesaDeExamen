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
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from Estudiantes", cone);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvEstudiantes.DataSource = dt;
            }

            MySqlDataAdapter daCarreras = new MySqlDataAdapter("Select * from Carreras", cone);
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

            if (dgvEstudiantes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int idEstudiante = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value);

            DialogResult resultado = MessageBox.Show("�Est� seguro que desea eliminar este estudiante?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                    {
                        cone.Open();


                        string sentencia = "DELETE FROM Estudiantes WHERE IdEstudiante = @idEstudiante";

                        using (MySqlCommand cmd = new MySqlCommand(sentencia, cone))
                        {
                            cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);


                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Estudiante eliminado correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Error al intentar eliminar el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurri� un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textNom.Enabled = true;
            textApe.Enabled = true;
            textMatricula.Enabled = true;
            textIdEstudiante.Enabled = true;
            textdni.Enabled = true;
            cboIdCarrera.Enabled = true;
            textNom.Focus();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string nombreABuscar = textBusqueda.Text.Trim();
            string idABuscar = textBusquedaId.Text.Trim();


            if (string.IsNullOrEmpty(nombreABuscar) && string.IsNullOrEmpty(idABuscar))
            {
                MessageBox.Show("Por favor, ingrese un nombre o un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString()))
            {
                try
                {
                    cone.Open();


                    string sentencia = "SELECT * FROM Estudiantes WHERE 1=1";


                    if (!string.IsNullOrEmpty(nombreABuscar))
                    {
                        sentencia += " AND nombre LIKE @nombre";
                    }


                    int idMateria;
                    if (int.TryParse(idABuscar, out idMateria))
                    {
                        sentencia += " AND IdEstudiante = @id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sentencia, cone))
                    {

                        if (!string.IsNullOrEmpty(nombreABuscar))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%" + nombreABuscar + "%");
                        }
                        if (int.TryParse(idABuscar, out idMateria))
                        {
                            cmd.Parameters.AddWithValue("@id", idMateria);
                        }


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvEstudiantes.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron estudiantes con ese nombre o ID.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurri� un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
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

            textNom.Clear();
            textApe.Clear();
            textdni.Clear();
            textMatricula.Clear();
            textIdEstudiante.Clear();
            cboIdCarrera.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;


            textNom.Enabled = false;
            textApe.Enabled = false;
            textdni.Enabled = false;
            textMatricula.Enabled = false;
            cboIdCarrera.Enabled = false;
            cboTipoDoc.Enabled = false;

            textNom.Focus();
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

        private void textApe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
