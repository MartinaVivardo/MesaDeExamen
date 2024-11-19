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


        public MesaDeExamen()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            textIdMesa.Enabled = true;
            cboProf.Enabled = true;
            dtpFecha.Enabled = true;
            cboCarrera.Enabled = true;
            cboMateria.Enabled = true;
            cboLlamado.Enabled = true;
            cboFinalizada.Enabled = true;



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textIdMesa.Enabled = true;
            cboProf.Enabled = true;
            dtpFecha.Enabled = true;
            cboCarrera.Enabled = true;
            cboMateria.Enabled = true;
            cboLlamado.Enabled = true;
            cboFinalizada.Enabled = true;
            textIdMesa.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;Pwd=martinaanalista@");
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;

            // Validaciones
            if (cboProf.SelectedValue == null)
            {
                Mensaje += "Seleccione un profesor.\r";
                lValidado = false;
            }
            if (cboCarrera.SelectedValue == null)
            {
                Mensaje += "Seleccione una carrera.\r";
                lValidado = false;
            }
            if (cboMateria.SelectedValue == null)
            {
                Mensaje += "Seleccione una materia.\r";
                lValidado = false;
            }
            if (cboLlamado.SelectedValue == null)
            {
                Mensaje += "Seleccione un llamado.\r";
                lValidado = false;
            }
            if (string.IsNullOrEmpty(cboFinalizada.Text))
            {
                Mensaje += "Seleccione si la mesa está finalizada o no.\r";
                lValidado = false;
            }

            if (!lValidado)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Preparar sentencia SQL
            string sentencia = string.Empty;

            if (string.IsNullOrEmpty(textIdMesa.Text.Trim()) || textIdMesa.Text.Trim() == "0")
            {
                // Insertar nueva mesa de examen
                sentencia = string.Format(
                    "INSERT INTO mesaexamen (Fecha, Finalizada, IdMateria, IdProfesor, IdCarrera, IdLlamado) VALUES ('{0}', {1}, {2}, {3}, {4}, {5})",
                    dtpFecha.Value.ToString("yyyy-MM-dd"),
                    cboFinalizada.SelectedItem.ToString() == "Si" ? 1 : 0,
                    cboMateria.SelectedValue,
                    cboProf.SelectedValue,
                    cboCarrera.SelectedValue,
                    cboLlamado.SelectedValue
                );
            }
            else
            {
                // Modificar mesa de examen existente
                sentencia = string.Format(
                    "UPDATE mesaexamen SET Fecha = '{0}', Finalizada = {1}, IdMateria = {2}, IdProfesor = {3}, IdCarrera = {4}, IdLlamado = {5} WHERE IdMesaExamen = {6}",
                    dtpFecha.Value.ToString("yyyy-MM-dd"),
                    cboFinalizada.SelectedItem.ToString() == "Si" ? 1 : 0,
                    cboMateria.SelectedValue,
                    cboProf.SelectedValue,
                    cboCarrera.SelectedValue,
                    cboLlamado.SelectedValue,
                    textIdMesa.Text.Trim()
                );
            }

            try
            {
                // Ejecutar la sentencia
                var comando = new MySqlCommand(sentencia, cone);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar la vista
                MesaDeExamen_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cone.Close();
            }


        }



        private void dgvMesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Verifica que se haya seleccionado una fila válida
            {
                int idMesaExamen = Convert.ToInt32(dgvMesa.Rows[e.RowIndex].Cells["IdMesaExamen"].Value);
                CargarDatosRegistro(idMesaExamen);  // Llama al método para cargar los datos
            }
        }

        private void CargarDatosRegistro(int idMesaExamen)
        {
            using (MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;Pwd=martinaanalista@"))
            {
                string query = "SELECT * FROM mesaexamen WHERE IdMesaExamen = @IdMesaExamen";
                MySqlCommand comando = new MySqlCommand(query, conexión);
                comando.Parameters.AddWithValue("@IdMesaExamen", idMesaExamen);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    // Cargar datos del registro en los controles
                    textIdMesa.Text = reader["IdMesaExamen"].ToString();
                    dtpFecha.Value = Convert.ToDateTime(reader["Fecha"]);
                    cboFinalizada.SelectedItem = reader["Finalizada"].ToString() == "1" ? "Si" : "No";
                    cboMateria.SelectedValue = reader["IdMateria"];
                    cboProf.SelectedValue = reader["IdProfesor"];
                    cboCarrera.SelectedValue = reader["IdCarrera"];
                    cboLlamado.SelectedValue = reader["IdLlamado"];
                }
                else
                {
                    MessageBox.Show("Registro no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MesaDeExamen_Load(object sender, EventArgs e)
        {

            using (MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;Pwd=martinaanalista@"))
            {

                MySqlDataAdapter da = new MySqlDataAdapter("Select mesaexamen.IdMesaExamen , mesaexamen.Fecha , mesaexamen.Finalizada , profesores.Nombre , materias.NombreMateria , carreras.NombreCarrera , llamados.NroLlamado from mesaexamen left join profesores on mesaexamen.IdProfesor= profesores.IdProfesor left join materias on mesaexamen.IdMateria=materias.IdMateria left join carreras on mesaexamen.IdCarrera=carreras.IdCarrera left join llamados on mesaexamen.IdLlamado=llamados.IdLlamado  ", conexión);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMesa.DataSource = dt;
                dgvMesa.Refresh();


                MySqlDataAdapter daCarreras = new MySqlDataAdapter("SELECT * FROM Carreras", conexión);
                DataTable dtCarreras = new DataTable();
                daCarreras.Fill(dtCarreras);
                cboCarrera.DataSource = dtCarreras;
                cboCarrera.DisplayMember = "NombreCarrera";
                cboCarrera.ValueMember = "IdCarrera";

                MySqlDataAdapter daProfesores = new MySqlDataAdapter("SELECT * FROM Profesores", conexión);
                DataTable dtProfesores = new DataTable();
                daProfesores.Fill(dtProfesores);
                cboProf.DataSource = dtProfesores;
                cboProf.DisplayMember = "Nombre";
                cboProf.ValueMember = "IdProfesor";

                MySqlDataAdapter daMaterias = new MySqlDataAdapter("SELECT * FROM Materias", conexión);
                DataTable dtMaterias = new DataTable();
                daMaterias.Fill(dtMaterias);
                cboMateria.DataSource = dtMaterias;
                cboMateria.DisplayMember = "NombreMateria";
                cboMateria.ValueMember = "IdMateria";

                MySqlDataAdapter daLlamados = new MySqlDataAdapter("SELECT * FROM Llamados", conexión);
                DataTable dtLlamados = new DataTable();
                daLlamados.Fill(dtLlamados);
                cboLlamado.DataSource = dtLlamados;
                cboLlamado.ValueMember = "NroLlamado";
                cboLlamado.ValueMember = "IdLlamado";
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {


            textIdMesa.Enabled = false;
            cboProf.Enabled = false;

            cboCarrera.Enabled = false;
            cboMateria.Enabled = false;
            cboLlamado.Enabled = false;
            cboFinalizada.Enabled = false;


            textIdMesa.Text = string.Empty;
            cboProf.SelectedIndex = -1;

            cboCarrera.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboLlamado.SelectedIndex = -1;
            cboFinalizada.SelectedIndex = -1;


            MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (dgvMesa.SelectedRows.Count > 0)
            {
                string idMesaExamen = dgvMesa.SelectedRows[0].Cells["IdMesaExamen"].Value.ToString();


                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                    "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {

                    using (var cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;Pwd=martinaanalista@"))
                    {
                        try
                        {
                            cone.Open();


                            string sentencia = "DELETE FROM mesaexamen WHERE IdMesaExamen = @IdMesaExamen";
                            using (var comando = new MySqlCommand(sentencia, cone))
                            {
                                comando.Parameters.AddWithValue("@IdMesaExamen", idMesaExamen);
                                int filasAfectadas = comando.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Registro eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    MesaDeExamen_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el registro. Verifique los datos.", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cone.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;Pwd=martinaanalista@"))
            {
                try
                {
                    conexion.Open();

                    // Consulta específica para buscar por fecha
                    string consulta = "SELECT mesaexamen.IdMesaExamen, mesaexamen.Fecha, mesaexamen.Finalizada, " +
                                      "profesores.Nombre AS Profesor, materias.NombreMateria, " +
                                      "carreras.NombreCarrera, llamados.NroLlamado " +
                                      "FROM mesaexamen " +
                                      "LEFT JOIN profesores ON mesaexamen.IdProfesor = profesores.IdProfesor " +
                                      "LEFT JOIN materias ON mesaexamen.IdMateria = materias.IdMateria " +
                                      "LEFT JOIN carreras ON mesaexamen.IdCarrera = carreras.IdCarrera " +
                                      "LEFT JOIN llamados ON mesaexamen.IdLlamado = llamados.IdLlamado " +
                                      "WHERE mesaexamen.Fecha = @Fecha";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Parámetro de fecha tomado del DateTimePicker
                    comando.Parameters.AddWithValue("@Fecha", dtpFecha.Value.ToString("yyyy-MM-dd"));

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable dtResultados = new DataTable();
                    adaptador.Fill(dtResultados);

                    dgvMesa.DataSource = dtResultados;
                    dgvMesa.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }




        private void dgvMesa_SelectionChanged(object sender, EventArgs e)
        {
            // Asegurarse de que se haya seleccionado una fila

            // Obtener los valores de las celdas de la fila seleccionada
            textIdMesa.Text = dgvMesa.CurrentRow.Cells["IdMesaExamen"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvMesa.CurrentRow.Cells["Fecha"].Value.ToString());
            cboFinalizada.Text = dgvMesa.CurrentRow.Cells["Finalizada"].Value.ToString();
            cboMateria.SelectedValue = dgvMesa.CurrentRow.Cells["NombreMateria"].Value.ToString();
            cboProf.SelectedValue = dgvMesa.CurrentRow.Cells["Profesor"].Value.ToString();
            cboCarrera.SelectedValue = dgvMesa.CurrentRow.Cells["NombreCarrera"].Value.ToString();
            cboLlamado.SelectedValue = dgvMesa.CurrentRow.Cells["NroLlamado"].Value.ToString();

        }



        private void dtpFecha1_ValueChanged(object sender, EventArgs e)
        {

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






