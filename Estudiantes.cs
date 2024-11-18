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

            if (dgvEstudiantes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int idEstudiante = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value);

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                                MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Valores de los campos de búsqueda
            string idEstudiante = textBox3.Text.Trim();
            string nombre = textBusqueda.Text.Trim();
            string apellido = textBox1.Text.Trim();
            string documento = textBox2.Text.Trim();

            // Comenzamos a construir la consulta SQL
            string consultaSQL = "SELECT * FROM Estudiantes WHERE 1=1";

            // Añadimos condiciones a la consulta según los campos llenos
            if (!string.IsNullOrEmpty(idEstudiante))
            {
                consultaSQL += " AND IdEstudiante = @idEstudiante";
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                consultaSQL += " AND Nombre LIKE @nombre";
            }

            if (!string.IsNullOrEmpty(apellido))
            {
                consultaSQL += " AND Apellido LIKE @apellido";
            }

            if (!string.IsNullOrEmpty(documento))
            {
                consultaSQL += " AND Documento = @documento";
            }

            // Conexión a la base de datos y ejecución de la consulta
            using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
            {
                try
                {
                    cone.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consultaSQL, cone))
                    {
                        // Añadir los parámetros a la consulta si se han proporcionado valores
                        if (!string.IsNullOrEmpty(idEstudiante))
                        {
                            cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                        }

                        if (!string.IsNullOrEmpty(nombre))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                        }

                        if (!string.IsNullOrEmpty(apellido))
                        {
                            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
                        }

                        if (!string.IsNullOrEmpty(documento))
                        {
                            cmd.Parameters.AddWithValue("@documento", documento);
                        }

                        // Ejecutar la consulta y mostrar los resultados
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        int registros = da.Fill(dt);

                        if (registros > 0)
                        {
                            dgvEstudiantes.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros que coincidan con la búsqueda.", "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvEstudiantes.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


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

        private void textIdEstudiante_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
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
    }
}
