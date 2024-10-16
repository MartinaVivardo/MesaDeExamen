using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MesaDeExamen
{
    public partial class Carreras : Form
    {
        private bool esNuevoRegistro;
        private int idCarreraActual;
        private string nombreOriginal;
        private int duracionOriginal;

        public Carreras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textIdCarrera.Enabled = true;
            textIdCarrera.Clear();
            textNombre.Enabled = true;
            textNombre.Clear();
            textDuracion.Enabled = true;
            textDuracion.Clear();
            textIdCarrera.Text = "0";
            textIdCarrera.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            if (textNombre.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese nombre de la carrera \r");
                lValidado = false;
            }
            if (textDuracion.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese la duracion \r");
                lValidado = false;
            }


            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string sentencia = string.Empty;
            if (textIdCarrera.Text.Trim() == "0")
                sentencia = string.Format("Insert Into carreras(nombrecarrera, duracion) Values('{0}',{1})", textNombre.Text.Trim(), textDuracion.Text.Trim());
            else
                sentencia = string.Format("Update carreras set nombrecarrera = '{0}', duracion = {1} where idcarrera = '{2}'", textNombre.Text.Trim(), textDuracion.Text.Trim(), textIdCarrera.Text.Trim());

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            Carreras_Load(sender, e);
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from carreras", cone);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvCarreras.DataSource = dt;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarreras.SelectedRows.Count > 0)
            {

                int idCarrera = Convert.ToInt32(textIdCarrera.Text.Trim());


                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                    {
                        cone.Open();


                        string sentencia = string.Format("DELETE FROM carreras WHERE IdCarrera = {0}", idCarrera);
                        MySqlCommand comando = new MySqlCommand(sentencia, cone);

                        comando.ExecuteNonQuery();


                        Carreras_Load(sender, e);
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textNombre.Enabled = true;
            textDuracion.Enabled = true;
            textNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esNuevoRegistro && idCarreraActual != -1)
            {
                textNombre.Text = nombreOriginal;
                textDuracion.Text = duracionOriginal.ToString();
            }
        }

        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {
            textIdCarrera.Text = dgvCarreras.CurrentRow.Cells["IdCarrera"].Value.ToString();
            textNombre.Text = dgvCarreras.CurrentRow.Cells["NombreCarrera"].Value.ToString();
            textDuracion.Text = dgvCarreras.CurrentRow.Cells["Duracion"].Value.ToString();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = textBusqueda.Text.Trim();
            string idABuscar = textIdBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(nombreABuscar) && string.IsNullOrEmpty(idABuscar))
            {
                MessageBox.Show("Por favor, ingrese un nombre o un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString())
)
            {
                try
                {
                    cone.Open();

                    
                    string sentencia = "SELECT * FROM carreras WHERE 1=1 ";

                  
                    if (!string.IsNullOrEmpty(nombreABuscar))
                    {
                        sentencia += " AND nombrecarrera LIKE @nombrecarrera";
                    }

                    int idProfesor;
                    if (int.TryParse(idABuscar, out idProfesor))
                    {
                        sentencia += " AND IdCarrera = @id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sentencia, cone))
                    {
                        
                        if (!string.IsNullOrEmpty(nombreABuscar))
                        {
                            cmd.Parameters.AddWithValue("@nombrecarrera", "%" +
                                "" + nombreABuscar + "%");
                        }

                        
                        if (int.TryParse(idABuscar, out idCarreraActual))
                        {
                            cmd.Parameters.AddWithValue("@id", idCarreraActual);
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvCarreras.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron carreras con ese nombre o ID.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

