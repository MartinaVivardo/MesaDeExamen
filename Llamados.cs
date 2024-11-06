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
            dateTimePickerFecha.Enabled = true;
            cboActivo.Enabled = true;
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
            if (dateTimePickerFecha.ToString().Length == 0)
            {
                Mensaje += "Ingrese la fecha\r";
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
                sentencia = string.Format("Insert Into llamados(nrollamado, activo, fecha) Values({0}, {1}, {2})",
            textNroLlamado.Text.Trim(), activo, dateTimePickerFecha.Value.ToString("yyyy-MM-dd"));
            else
                sentencia = string.Format("Update llamados set nrollamado = {0}, activo = {1}, fecha = '{2}' where idllamado = {3}",
          textNroLlamado.Text.Trim(), activo, dateTimePickerFecha.Value.ToString("yyyy-MM-dd"), textIdLlamado.Text.Trim());

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            Llamados_Load(sender, e);
        }

        private void dgvLlamados_Leave(object sender, EventArgs e)
        {
            textNroLlamado.Text = dgvLlamados.CurrentRow.Cells["NroLlamado"].Value.ToString();
            cboActivo.Text = dgvLlamados.CurrentRow.Cells["Activo"].Value.ToString();
            dateTimePickerFecha.Text = dgvLlamados.CurrentRow.Cells["Fecha"].Value.ToString();
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
            dateTimePickerFecha.Enabled = true;
            textNroLlamado.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esNuevoRegistro && IdLlamadoActual != -1)
            {
                textNroLlamado.Text = nrollamadoOriginal;
            }
        }
        private void dgvLlamados_SelectionChanged(object sender, EventArgs e)
        {
            textNroLlamado.Text = dgvLlamados.CurrentRow.Cells["Nrollamado"].Value.ToString();
            dateTimePickerFecha.Text = dgvLlamados.CurrentRow.Cells["Fecha"].Value.ToString();
            textIdLlamado.Text = dgvLlamados.CurrentRow.Cells["IdLlamado"].Value.ToString();
            cboActivo.Text = dgvLlamados.CurrentRow.Cells["Activo"].Value.ToString();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (!string.IsNullOrEmpty(txtIdLlamadoConsulta.Text.Trim()))
            {
                filtro = $"WHERE IdLlamado = {txtIdLlamadoConsulta.Text.Trim()}";
            }
            else if (!string.IsNullOrEmpty(txtNroLlamadoConsulta.Text.Trim()))
            {
                filtro = $"WHERE Nrollamado = {txtNroLlamadoConsulta.Text.Trim()}";
            }
            else if (dateTimePickerFechaConsulta.Value != null)
            {
                filtro = $"WHERE Fecha = '{dateTimePickerFechaConsulta.Value.ToString("yyyy-MM-dd")}'";
            }

            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Por favor, ingrese un criterio de búsqueda.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM Llamados {filtro}", conexión);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvLlamados.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados con los criterios ingresados.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvLlamados.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
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

