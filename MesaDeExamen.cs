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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT mesaexamen.IdMesaExamen, materias.NombreMateria, llamados.Fecha, carreras.NombreCarrera from mesaexamen left join materias on mesaexamen.IdMateria=materias.NombreMateria  left join carreras on mesaexamen.IdCarrera=carreras.NombreCarrera left join llamados on mesaexamen.Fecha = llamados.Fecha", cone);
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

            MySqlDataAdapter daLlamados = new MySqlDataAdapter("Select Idllamado, concat(Month(Fecha),'-',Year(Fecha)) AS Periodo from Llamados where Activo = 1", cone);
            DataTable dtLlamados = new DataTable();
            registros = daLlamados.Fill(dtLlamados);
            if (registros > 0)
            {
                cboLlamado.DataSource = dtLlamados;
                cboLlamado.DisplayMember = "Periodo";
                cboLlamado.ValueMember = "Idllamado";
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
            // Obtener los valores de los controles
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            int idMateria = Convert.ToInt32(cboIdMateria.SelectedValue);
            int idMesa = 0;

            // Verificar si el campo de IdMesa tiene un valor válido
            if (!string.IsNullOrEmpty(textIdMesa.Text))
            {
                int.TryParse(textIdMesa.Text, out idMesa);
            }

            // Construir la consulta SQL
            string query = "SELECT mesaexamen.IdMesaExamen, materias.NombreMateria, llamados.Fecha, carreras.NombreCarrera from mesaexamen left join materias on mesaexamen.IdMateria=materias.NombreMateria left join carreras on mesaexamen.IdCarrera=carreras.NombreCarrera";

            // Agregar filtro por fecha
            if (dtpFecha.Checked)
            {
                query += $" AND fecha = '{fecha}'";
            }

            // Agregar filtro por idMateria
            if (idMateria > 0)
            {
                query += $" AND idMateria = {idMateria}";
            }

            // Agregar filtro por idMesa si existe
            if (idMesa > 0)
            {
                query += $" AND idMesaexamen = {idMesa}";
            }

            // Conectar a la base de datos y ejecutar la consulta
            using (MySqlConnection cone = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ToString()))
            {
                cone.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, cone);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar los resultados en el DataGridView
                dgvMesa.DataSource = dt;
            }

        }

        private void dgvMesa_SelectionChanged(object sender, EventArgs e)
        {
            //dtpFecha.Value = Convert.ToDateTime(dgvMesa.CurrentRow.Cells["Fecha"].Value);
            cboLlamado.SelectedValue = dgvMesa.CurrentRow.Cells["Fecha"].Value;
            cboProf.SelectedValue = dgvMesa.CurrentRow.Cells["IdProfesorVocal"].Value;
            cboCarrera.SelectedValue = dgvMesa.CurrentRow.Cells["IdCarrera"].Value;
            cboIdMateria.SelectedValue = dgvMesa.CurrentRow.Cells["IdMateria"].Value;
            cboFin.SelectedValue = dgvMesa.CurrentRow.Cells["Finalizada"].Value.ToString();
            textIdMesa.Text = dgvMesa.CurrentRow.Cells["idMesaexamen"].Value.ToString();
        }
    }
}



