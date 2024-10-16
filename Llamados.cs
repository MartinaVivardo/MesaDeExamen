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
    public partial class Llamados : Form
    {
        private List<Llamados> llamados;

        private bool esNuevoRegistro;
        private int IdLlamadoActual;

        private string añoOriginal;
        private string mesOriginal;
        private string nrollamadoOriginal;

        public Llamados()
        {
            InitializeComponent();
            llamados = new List<Llamados>();

        }

        private void Llamados_Load(object sender, EventArgs e)
        {

            MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from Llamados", conexión);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvLlamados.DataSource = dt;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textNroLlamado.Enabled = true;
            textNroLlamado.Clear();
            textAño.Enabled = true;
            textAño.Clear();
            cboActivo.Enabled = true;
            textMes.Enabled = true;
            textMes.Clear();
            textIdLlamado.Text = "0";
            textNroLlamado.Focus();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            if (textNroLlamado.Text.Trim().Length == 0)
            {
                Mensaje += String.Format("Ingrese el numero del llamado \r");
                lValidado = false;
            }
            if (textAño.Text.Trim().Length == 0)
            {
                Mensaje += "Ingrese el año \r";
                lValidado = false;
            }
            if (textMes.Text.Trim().Length == 0)
            {
                Mensaje += "Ingrese el mes \r";
                lValidado = false;
            }
            if (cboActivo.SelectedItem.ToString().Length == 0)
            {
                Mensaje += "Seleccione si el llamado se encuentra activo \r";
                lValidado = false;
            }

            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            int activo = cboActivo.SelectedItem.ToString() == "Si" ? 1 : 0;
            string sentencia = string.Empty;
            if (textIdLlamado.Text.Trim() == "0")
                sentencia = string.Format("Insert Into llamados( nrollamado, año, activo, mes) Values({0},{1},{2},{3})", textNroLlamado.Text.Trim(), textAño.Text.Trim(), activo, textMes.Text.Trim());
            else
                sentencia = string.Format("Update llamados set nrollamado = {0}, año = {1}, mes = {2}, activo = {3} where idllamado = {4}", textNroLlamado.Text.Trim(), textAño.Text.Trim(), textMes.Text.Trim(), activo, textIdLlamado.Text.Trim());

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            Llamados_Load(sender, e);
        }

        private void dgvLlamados_Leave(object sender, EventArgs e)
        {
            textNroLlamado.Text = dgvLlamados.CurrentRow.Cells["NroLlamado"].Value.ToString();
            cboActivo.Text = dgvLlamados.CurrentRow.Cells["Activo"].Value.ToString();
            textAño.Text = dgvLlamados.CurrentRow.Cells["Año"].Value.ToString();
            textMes.Text = dgvLlamados.CurrentRow.Cells["Mes"].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLlamados.SelectedRows.Count > 0)
            {

                int idLlamado = Convert.ToInt32(textIdLlamado.Text.Trim());


                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                    {
                        cone.Open();


                        string sentencia = string.Format("DELETE FROM llamados WHERE IdLlamado = {0}", idLlamado);
                        MySqlCommand comando = new MySqlCommand(sentencia, cone);

                        comando.ExecuteNonQuery();


                        Llamados_Load(sender, e);
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
            textNroLlamado.Enabled = true;
            cboActivo.Enabled = true;
            textAño.Enabled = true;
            textMes.Enabled = true;
            textNroLlamado.Focus();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esNuevoRegistro && IdLlamadoActual != -1)
            {

                textNroLlamado.Text = nrollamadoOriginal;
                textAño.Text = añoOriginal;
                textMes.Text = mesOriginal;
            }

        }
        private void dgvLlamados_SelectionChanged(object sender, EventArgs e)
        {
            textNroLlamado.Text = dgvLlamados.CurrentRow.Cells["Nrollamado"].Value.ToString();
            textAño.Text = dgvLlamados.CurrentRow.Cells["Año"].Value.ToString();
            textMes.Text = dgvLlamados.CurrentRow.Cells["Mes"].Value.ToString();
            textIdLlamado.Text = dgvLlamados.CurrentRow.Cells["IdLlamado"].Value.ToString();
            cboActivo.Text = dgvLlamados.CurrentRow.Cells["Activo"].Value.ToString();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            string idLlamado = textIdBusca.Text.Trim();  
            string nroLlamado = textNroLlamadoBuscar.Text.Trim();  

            
            string consulta = "SELECT * FROM llamados WHERE 1=1"; 

            if (!string.IsNullOrEmpty(idLlamado))
            {
                consulta += $" AND idllamado = {idLlamado}";
            }

            if (!string.IsNullOrEmpty(nroLlamado))
            {
                consulta += $" AND nrollamado LIKE '%{nroLlamado}%'";
            }

            
            try
            {
                var cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@");
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, cone);
                DataTable dt = new DataTable();
                int registros = da.Fill(dt);
                if (registros > 0)
                {
                    dgvLlamados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLlamados.DataSource = null;  // Limpiar los datos si no hay resultados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

