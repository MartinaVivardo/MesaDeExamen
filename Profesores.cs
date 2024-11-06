using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MesaDeExamen
{
    public partial class Profesores : Form
    {
        private bool esNuevoRegistro;
        private int idProfesorActual;

        private string nombreOriginal;
        private string apellidoOriginal;
        private int idprofesorOriginal;
        public Profesores()
        {
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from Profesores", conexión);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvProfesores.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textApellido.Enabled = true;
            textApellido.Clear();
            textNomb.Enabled = true;
            textNomb.Clear();
            textIdProf.Text = "0";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {

                int idProf = Convert.ToInt32(textIdProf.Text.Trim());


                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                    {
                        cone.Open();


                        string sentencia = string.Format("DELETE FROM profesores WHERE Idprofesor = {0}", idProf);
                        MySqlCommand comando = new MySqlCommand(sentencia, cone);

                        comando.ExecuteNonQuery();


                        Profesores_Load(sender, e);
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes; Uid=root; pwd=martinaanalista@");
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;


            if (textApellido.Text.Trim().Length == 0)
            {
                Mensaje += "Ingrese apellido del profesor \r";
                lValidado = false;
            }

            if (textNomb.Text.Trim().Length == 0)
            {
                Mensaje += "Ingrese nombre del profesor \r";
                lValidado = false;
            }

            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string sentencia = string.Empty;


            if (textIdProf.Text.Trim() == "0" || string.IsNullOrEmpty(textIdProf.Text.Trim()))
            {
                sentencia = string.Format("Insert Into profesores(nombre, apellido) Values('{0}', '{1}')", textNomb.Text.Trim(), textApellido.Text.Trim());
            }
            else
            {
                sentencia = string.Format("Update profesores set nombre = '{0}', apellido = '{1}' where IdProfesor = {2}", textNomb.Text.Trim(), textApellido.Text.Trim(), textIdProf.Text.Trim());
            }

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            Profesores_Load(sender, e);

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            textApellido.Text = dgvProfesores.CurrentRow.Cells["Apellido"].Value.ToString();
            textNomb.Text = dgvProfesores.CurrentRow.Cells["Nombre"].Value.ToString();
            textIdProf.Text = dgvProfesores.CurrentRow.Cells["IdProfesor"].Value.ToString();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esNuevoRegistro && idProfesorActual != -1)
            {

                textNomb.Text = nombreOriginal;
                textApellido.Text = apellidoOriginal;
                textIdProf.Text = idprofesorOriginal.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textNomb.Enabled = true;
            textApellido.Enabled = true;
            textIdProf.Enabled = true;
            textNomb.Focus();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = textBusqueda.Text.Trim();
            string idABuscar = textIdBusqueda.Text.Trim();
            string apellidoABuscar = textApellidoBusqueda.Text.Trim(); // Nuevo campo para el apellido

            if (string.IsNullOrEmpty(nombreABuscar) && string.IsNullOrEmpty(idABuscar) && string.IsNullOrEmpty(apellidoABuscar))
            {
                MessageBox.Show("Por favor, ingrese un nombre, apellido o un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
            {
                try
                {
                    cone.Open();

                    // Define la base de la consulta
                    string sentencia = "SELECT * FROM profesores WHERE 1=1";

                    // Añade condiciones dinámicamente según lo que se haya ingresado
                    if (!string.IsNullOrEmpty(nombreABuscar))
                    {
                        sentencia += " AND nombre LIKE @nombre";
                    }

                    if (!string.IsNullOrEmpty(apellidoABuscar)) // Condición para buscar por apellido
                    {
                        sentencia += " AND apellido LIKE @apellido";
                    }

                    int idProfesor;
                    if (int.TryParse(idABuscar, out idProfesor))
                    {
                        sentencia += " AND IdProfesor = @id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sentencia, cone))
                    {
                        // Agrega el parámetro de nombre si se ingresó
                        if (!string.IsNullOrEmpty(nombreABuscar))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%" + nombreABuscar + "%");
                        }

                        // Agrega el parámetro de apellido si se ingresó
                        if (!string.IsNullOrEmpty(apellidoABuscar))
                        {
                            cmd.Parameters.AddWithValue("@apellido", "%" + apellidoABuscar + "%");
                        }

                        // Agrega el parámetro de ID si se ingresó un número válido
                        if (int.TryParse(idABuscar, out idProfesor))
                        {
                            cmd.Parameters.AddWithValue("@id", idProfesor);
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvProfesores.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron profesores con ese nombre, apellido o ID.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
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