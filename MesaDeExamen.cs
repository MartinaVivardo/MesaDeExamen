using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MesaDeExamen
{
    public partial class MesaDeExamen : Form
    {
        private bool esNuevoRegistro;
        private int idMesaActual;
        private int idLlamadoActual;
        private string CarreraActual;
        private int idMateria;

        private string nombreOriginal;

        public MesaDeExamen()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textIdMesa.Enabled = true;
            textIdMesa.Clear();
            cboLlamado.Enabled = true;
            cboProf.Enabled = true;
            cboFin.Enabled = true;
            cboIdMateria.Enabled = true;
            cboCarrera.Enabled = true;
            textIdMesa.Text = "0";
            dtpFecha.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textIdMesa.Enabled = true;
            cboLlamado.Enabled = true;
            cboProf.Enabled = true;
            cboFin.Enabled = true;
            cboIdMateria.Enabled = true;
            cboCarrera.Enabled = true;
            dtpFecha.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            if (cboProf.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese nombre del profesor \r");
                lValidado = false;
            }
            if (cboLlamado.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese el id del llamado \r");
                lValidado = false;
            }
            if (cboIdMateria.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese Materia: \r");
                lValidado = false;
            }
            if (cboCarrera.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese Carrera: \r");
                lValidado = false;
            }
            if (cboFin.SelectedItem.ToString().Length == 0)
            {
                Mensaje += String.Format("Ingrese si esta finalizada: \r");
                lValidado = false;
            }



            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textIdMesa.Enabled = true;
            textIdMesa.Clear();
            cboLlamado.Enabled = true;
            cboProf.Enabled = true;
            cboFin.Enabled = true;
            cboIdMateria.Enabled = true;
            cboCarrera.Enabled = true;
            textIdMesa.Text = "0";
            dtpFecha.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textIdMesa.Enabled = true;
            cboLlamado.Enabled = true;
            cboProf.Enabled = true;
            cboFin.Enabled = true;
            cboIdMateria.Enabled = true;
            cboCarrera.Enabled = true;
            dtpFecha.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            if (cboProf.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese nombre del profesor \r");
                lValidado = false;
            }
            if (cboLlamado.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese el id del llamado \r");
                lValidado = false;
            }
            if (cboIdMateria.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese Materia: \r");
                lValidado = false;
            }
            if (cboCarrera.SelectedValue == null)
            {
                Mensaje += String.Format("Ingrese Carrera: \r");
                lValidado = false;
            }
            if (cboFin.SelectedItem.ToString().Length == 0)
            {
                Mensaje += String.Format("Ingrese si esta finalizada: \r");
                lValidado = false;
            }



            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            int finalizada = cboFin.SelectedItem.ToString() == "Si" ? 1 : 0;
            string sentencia = string.Empty;
            string fecha = string.Format("{0}-{1}-{2}", dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day);

            if (textIdMesa.Text.Trim() == "0")
                sentencia = string.Format("Insert Into mesaexamen(idprofesorvocal, idllamado, idmateria, finalizada, idcarrera, fecha) Values('{0}',{1},{2},{3},{4},cast('{5}' as Date))", cboProf.SelectedValue, cboLlamado.SelectedValue, cboIdMateria.SelectedValue, finalizada, cboCarrera.SelectedValue, fecha);
            else
                sentencia = string.Format("Update mesaexamen set idprofesorvocal = '{0}', idllamado = {1}, idmateria = {2}, finalizada = {3}, idcarrera = {4}, fecha = cast('{5}' as Date) where idmesaexamen = {6}", cboProf.SelectedValue, cboLlamado.SelectedValue, cboIdMateria.SelectedValue, finalizada, cboCarrera.SelectedValue, fecha, textIdMesa.Text.Trim());

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            MesaDeExamen_Load(sender, e);
        }

        private void MesaDeExamen_Load(object sender, EventArgs e)
        {
            var cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString());
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mesaexamen", cone);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvMesa.DataSource = dt;
            }

            MySqlDataAdapter daCarreras = new MySqlDataAdapter("Select * from carreras Order By nombrecarrera", cone);
            DataTable dtCarreras = new DataTable();
            registros = daCarreras.Fill(dtCarreras);
            if (registros > 0)
            {
                cboCarrera.DataSource = dtCarreras;
                cboCarrera.DisplayMember = "nombrecarrera";
                cboCarrera.ValueMember = "idcarrera";
            }

            MySqlDataAdapter daMaterias = new MySqlDataAdapter("Select * from materias Order By nombremateria", cone);
            DataTable dtMaterias = new DataTable();
            registros = daMaterias.Fill(dtMaterias);
            if (registros > 0)
            {
                cboIdMateria.DataSource = dtMaterias;
                cboIdMateria.DisplayMember = "nombremateria";
                cboIdMateria.ValueMember = "idmateria";
            }

            MySqlDataAdapter daLlamados = new MySqlDataAdapter("Select idllamado, concat(mes,'-',año) AS Periodo from llamados where activo = 1", cone);
            DataTable dtLlamados = new DataTable();
            registros = daLlamados.Fill(dtLlamados);
            if (registros > 0)
            {
                cboLlamado.DataSource = dtLlamados;
                cboLlamado.DisplayMember = "Periodo";
                cboLlamado.ValueMember = "idllamado";
            }

            MySqlDataAdapter daProfesor = new MySqlDataAdapter("Select * from profesores Order By nombre", cone);
            DataTable dtProfesor = new DataTable();
            registros = daProfesor.Fill(dtProfesor);
            if (registros > 0)
            {
                cboProf.DataSource = dtProfesor;
                cboProf.DisplayMember = "nombre";
                cboProf.ValueMember = "idprofesor";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esNuevoRegistro && idMesaActual != -1)
            {
                cboProf.Text = nombreOriginal;
                textIdMesa.Text = nombreOriginal;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMesa.SelectedRows.Count > 0)
            {

                int idMesa = Convert.ToInt32(textIdMesa.Text.Trim());


                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                    {
                        cone.Open();


                        string sentencia = string.Format("DELETE FROM mesaexamen WHERE IdMesaexamen = {0}", idMesa);
                        MySqlCommand comando = new MySqlCommand(sentencia, cone);

                        comando.ExecuteNonQuery();


                        MesaDeExamen_Load(sender, e);
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
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


                    string sentencia = "SELECT * FROM mesaexamen WHERE 1=1 ";


                    if (!string.IsNullOrEmpty(nombreABuscar))
                    {
                        sentencia += " AND nombrecarrera LIKE @nombrecarrera";
                    }

                    int idProfesor;
                    if (int.TryParse(idABuscar, out idProfesor))
                    {
                        sentencia += " AND IdMesaExamen = @idmesa";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sentencia, cone))
                    {

                        if (!string.IsNullOrEmpty(nombreABuscar))
                        {
                            cmd.Parameters.AddWithValue("@nombrecarrera", "%" +
                                "" + nombreABuscar + "%");
                        }


                        if (int.TryParse(idABuscar, out idMesaActual))
                        {
                            cmd.Parameters.AddWithValue("@idmesa", idMesaActual);
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvMesa.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron mesas con ese nombre o ID.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvMesa_SelectionChanged(object sender, EventArgs e)
        {
            //dtpFecha.Value = Convert.ToDateTime(dgvMesa.CurrentRow.Cells["Fecha"].Value);
            cboLlamado.SelectedValue = dgvMesa.CurrentRow.Cells["IdLlamado"].Value;
            cboProf.SelectedValue = dgvMesa.CurrentRow.Cells["IdProfesorVocal"].Value;
            cboCarrera.SelectedValue = dgvMesa.CurrentRow.Cells["IdCarrera"].Value;
            cboIdMateria.SelectedValue = dgvMesa.CurrentRow.Cells["IdMateria"].Value;
            cboFin.SelectedValue = dgvMesa.CurrentRow.Cells["Finalizada"].Value.ToString();
            textIdMesa.Text = dgvMesa.CurrentRow.Cells["idMesaexamen"].Value.ToString();
        }
    }
}



