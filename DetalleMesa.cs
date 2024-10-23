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
using static MesaDeExamen.Program;

namespace MesaDeExamen
{

    public partial class DetalleMesa : Form
    {
        private List<DetalleMesa> DetalleMesas;
        public DetalleMesa()
        {
            InitializeComponent();
            DetalleMesas = new List<DetalleMesa>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cboEstudiante.Enabled = true;

            cboCarrera.Enabled = true;
            cboLlamado.Enabled = true;
            cboMesa.Enabled = true;
            textIdDet.Text = "0";
            textIdDet.Focus();

        }

        private void DetalleMesa_Load(object sender, EventArgs e)
        {

            MySqlConnection conexión = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            MySqlDataAdapter da = new MySqlDataAdapter("Select detallemesadeexamen.IdDetalle,materias.NombreMateria,estudiantes.Apellido, estudiantes.Nombre, carreras.NombreCarrera, llamados.IdLlamado from detallemesadeexamen left join estudiantes on detallemesadeexamen.IdEstudiante= estudiantes.idEstudiante left join materias on detallemesadeexamen.IdMateria=materias.IdMateria left join carreras on detallemesadeexamen.IdCarrera=carreras.IdCarrera left join llamados on detallemesadeexamen.Llamados=llamados.IdLlamado ", conexión);
            DataTable dt = new DataTable();
            int registros = da.Fill(dt);
            if (registros > 0)
            {
                dgvDetalleMesa.DataSource = dt;
            }
            MySqlDataAdapter daCarreras = new MySqlDataAdapter("Select * from Carreras", conexión);
            DataTable dtCarreras = new DataTable();
            registros = daCarreras.Fill(dtCarreras);
            if (registros > 0)
            {
                cboCarrera.DataSource = dtCarreras;
                cboCarrera.DisplayMember = "NombreCarrera";
                cboCarrera.ValueMember = "IdCarrera";
            }
            MySqlDataAdapter daEstudiantes = new MySqlDataAdapter("Select * from Estudiantes", conexión);
            DataTable dtEstudiantes = new DataTable();
            registros = daEstudiantes.Fill(dtEstudiantes);
            if (registros > 0)
            {
                cboEstudiante.DataSource = dtEstudiantes;
                cboEstudiante.DisplayMember = "Nombre";
                cboEstudiante.ValueMember = "IdEstudiante";
            }
            MySqlDataAdapter damesaexamen = new MySqlDataAdapter("Select * from mesaexamen", conexión);
            DataTable dtmesaexamen = new DataTable();
            registros = damesaexamen.Fill(dtmesaexamen);
            if (registros > 0)
            {
                cboMesa.DataSource = dtmesaexamen;
                cboMesa.DisplayMember = "fecha";
                cboMesa.ValueMember = "IdMesaExamen";
            }
            MySqlDataAdapter damaterias = new MySqlDataAdapter("Select * from materias", conexión);
            DataTable dtmaterias = new DataTable();
            registros = damaterias.Fill(dtmaterias);
            if (registros > 0)
            {
                cboMateria.DataSource = dtmaterias;
                cboMateria.DisplayMember = "NombreMateria";
                cboMateria.ValueMember = "IdMateria";

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cone = new MySqlConnection("Data Source=localhost; Initial Catalog = mesasdeexamenes;Uid = root; pwd = martinaanalista@");
            cone.Open();
            bool lValidado = true;
            string Mensaje = string.Empty;
            if (cboEstudiante.SelectedItem.ToString().Length == 0)
            {
                Mensaje += String.Format("Ingrese estudiante \r");
                lValidado = false;
            }
            if (cboCarrera.SelectedItem.ToString().Length == 0)
            {
                Mensaje += "Ingrese la carrera \r";
                lValidado = false;
            }
            if (cboMesa.SelectedItem.ToString().Length == 0)
            {
                Mensaje += "Ingrese la mesa \r";
                lValidado = false;
            }
            if (cboLlamado.SelectedItem.ToString().Length == 0)
            {
                Mensaje += "Ingrese el nro de llamado \r";
                lValidado = false;
            }
            if (cboMateria.SelectedItem.ToString().Length == 0)
            {
                Mensaje += "Ingrese la materia \r";
                lValidado = false;
            }
            if (lValidado == false)
            {
                MessageBox.Show(Mensaje, "Solicitud del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string sentencia = string.Empty;
            if (textIdDet.Text.Trim() == "0")
            {
                sentencia = string.Format("Insert Into detallemesadeexamen(idestudiante, idmesa, llamados, idcarrera, idmateria) Values({0},{1},{2},{3},{4})", cboEstudiante.SelectedValue, cboMesa.SelectedValue, cboLlamado.SelectedItem.ToString(), cboCarrera.SelectedValue, cboMateria.SelectedValue);
            }
            else
            {
                sentencia = string.Format("Update detallemesadeexamen set idestudiante = {0}, idmesa = {1}, llamados = {2}, idcarrera = {3}, idmateria = {4} where IdDetalle = {5}", cboEstudiante.SelectedValue, cboMesa.SelectedValue, cboLlamado.SelectedItem.ToString(), cboCarrera.SelectedValue, cboMateria.SelectedValue, textIdDet.Text);
            }

            var comando = new MySqlCommand(sentencia, cone);
            comando.ExecuteNonQuery();
            cone.Close();
            DetalleMesa_Load(sender, e);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            textIdDet.Text = string.Empty;
            cboEstudiante.SelectedIndex = -1;
            cboCarrera.SelectedIndex = -1;
            cboMesa.SelectedIndex = -1;
            cboLlamado.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;


            cboEstudiante.Enabled = false;
            cboCarrera.Enabled = false;
            cboLlamado.Enabled = false;
            cboMesa.Enabled = false;
            cboMateria.Enabled = false;


            textIdDet.Focus();


            MessageBox.Show("Operación cancelada.");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleMesa.SelectedRows.Count > 0)
            {

                int idDetalle = Convert.ToInt32(dgvDetalleMesa.SelectedRows[0].Cells["IdDetalle"].Value);


                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                    {
                        cone.Open();


                        string sentencia = string.Format("DELETE FROM detallemesadeexamen WHERE IdDetalle = {0}", idDetalle);
                        MySqlCommand comando = new MySqlCommand(sentencia, cone);

                        comando.ExecuteNonQuery();


                        DetalleMesa_Load(sender, e);
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
            if (dgvDetalleMesa.SelectedRows.Count > 0)
            {

                int idDetalle = Convert.ToInt32(dgvDetalleMesa.SelectedRows[0].Cells["IdDetalle"].Value);


                using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
                {
                    cone.Open();


                    string sentencia = string.Format("SELECT * FROM detallemesadeexamen WHERE IdDetalle = {0}", idDetalle);
                    MySqlCommand comando = new MySqlCommand(sentencia, cone);
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {

                        textIdDet.Text = reader["IdDetalle"].ToString();
                        cboEstudiante.SelectedValue = reader["IdEstudiante"];
                        cboCarrera.SelectedValue = reader["IdCarrera"];
                        cboMesa.SelectedValue = reader["IdMesa"];
                        cboLlamado.SelectedItem = reader["Llamados"].ToString();
                        cboMateria.SelectedValue = reader["IdMateria"];


                        cboEstudiante.Enabled = true;
                        cboCarrera.Enabled = true;
                        cboLlamado.Enabled = true;
                        cboMesa.Enabled = true;
                        cboMateria.Enabled = true;

                        MessageBox.Show("Puedes modificar los datos y luego guardar.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar el registro.");
                    }

                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para modificar.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Valores de los campos de búsqueda
            string idDetalle = textIdDetalleBusqueda.Text.Trim();
            string estudiante = textEstudianteBusqueda.Text.Trim();
            string carrera = textCarreraBusqueda.Text.Trim();

            string materia = textMateriaBusqueda.Text.Trim();
            string llamados = textLlamadoBusqueda.Text.Trim();

            // Empezamos a construir la consulta SQL
            string consultaSQL = "Select detallemesadeexamen.IdDetalle,materias.NombreMateria,estudiantes.Apellido, estudiantes.Nombre, carreras.NombreCarrera, llamados.IdLlamado from detallemesadeexamen left join estudiantes on detallemesadeexamen.IdEstudiante= estudiantes.idEstudiante left join materias on detallemesadeexamen.IdMateria=materias.IdMateria left join carreras on detallemesadeexamen.IdCarrera=carreras.IdCarrera left join llamados on detallemesadeexamen.Llamados=llamados.IdLlamado WHERE ";

            // Añadimos condiciones a la consulta según los campos llenos
            if (!string.IsNullOrEmpty(idDetalle))
            {
                consultaSQL += " detallemesadeexamen.IdDetalle = @idDetalle";
            }

            if (!string.IsNullOrEmpty(estudiante))
            {
                consultaSQL += " detallemesadeexamen.IdEstudiante IN (SELECT IdEstudiante FROM Estudiantes WHERE Nombre LIKE @estudiante)";
            }

            if (!string.IsNullOrEmpty(carrera))
            {
                consultaSQL += "detallemesadeexamen.IdCarrera IN (SELECT IdCarrera FROM Carreras WHERE NombreCarrera LIKE @carrera)";
            }



            if (!string.IsNullOrEmpty(materia))
            {
                consultaSQL += "detallemesadeexamen.IdMateria IN (SELECT IdMateria FROM Materias WHERE NombreMateria LIKE @materia)";
            }

            if (!string.IsNullOrEmpty(llamados))
            {
                consultaSQL += "detallemesadeexamen.Llamados = @llamados";
            }

            using (MySqlConnection cone = new MySqlConnection("Data Source=localhost; Initial Catalog=mesasdeexamenes;Uid=root;pwd=martinaanalista@"))
            {
                cone.Open();

                using (MySqlCommand cmd = new MySqlCommand(consultaSQL, cone))
                {
                    // Añadir los parámetros a la consulta si se han proporcionado valores
                    if (!string.IsNullOrEmpty(idDetalle))
                    {
                        cmd.Parameters.AddWithValue("@idDetalle", idDetalle);
                    }

                    if (!string.IsNullOrEmpty(estudiante))
                    {
                        cmd.Parameters.AddWithValue("@estudiante", "%" + estudiante + "%");
                    }

                    if (!string.IsNullOrEmpty(carrera))
                    {
                        cmd.Parameters.AddWithValue("@carrera", "%" + carrera + "%");
                    }



                    if (!string.IsNullOrEmpty(materia))
                    {
                        cmd.Parameters.AddWithValue("@materia", "%" + materia + "%");
                    }

                    if (!string.IsNullOrEmpty(llamados))
                    {
                        cmd.Parameters.AddWithValue("@llamados", llamados);
                    }

                    // Ejecutar la consulta y mostrar los resultados
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    int registros = da.Fill(dt);

                    if (registros > 0)
                    {
                        dgvDetalleMesa.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros que coincidan con la búsqueda.", "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDetalleMesa.DataSource = null;
                    }
                }
            }



        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textIdDet_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
