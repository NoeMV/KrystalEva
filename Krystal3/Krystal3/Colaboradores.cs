using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Krystal3
{
    public partial class Colaboradores : Form
    {
        private static int colaboradorID = 0;
        private static String colaboradorCURP = "";
        private static int row = -1;
        public Colaboradores()
        {
            InitializeComponent();
            getColaboradores();
        }


        public void getColaboradores()
        {
            ArrayList listaColaboradorID = new ArrayList();
            ArrayList listaCurp = new ArrayList();
            ArrayList listaNombre = new ArrayList();
            ArrayList listaPrimerApellido = new ArrayList();
            ArrayList listaSegundoApellido = new ArrayList();
            ArrayList listaClaveEstado = new ArrayList();
            ArrayList listaMunicipioID = new ArrayList();
            ArrayList listaOcupacionID = new ArrayList();
            ArrayList listaNivelEstudios = new ArrayList();
            ArrayList listaClaveDocProbatorio = new ArrayList();
            ArrayList listaClaveInstitucion = new ArrayList();

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT * FROM colaboradores WHERE status = 1";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listaColaboradorID.Add(reader["colaborador_id"].ToString());
                        listaCurp.Add(reader["curp"].ToString());
                        listaNombre.Add(reader["nombre"].ToString());
                        listaPrimerApellido.Add(reader["primerApellido"].ToString());
                        listaSegundoApellido.Add(reader["segundoApellido"].ToString());
                        listaClaveEstado.Add(reader["claveEstado"].ToString());
                        listaMunicipioID.Add(reader["municipio_id"].ToString());
                        listaOcupacionID.Add(reader["ocupacion_id"].ToString());
                        listaNivelEstudios.Add(reader["claveNivelEstudios"].ToString());
                        listaClaveDocProbatorio.Add(reader["claveDocProbatorio"].ToString());
                        listaClaveInstitucion.Add(reader["claveInstitucion"].ToString());
                    }
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < listaColaboradorID.Count; i++)
                    {
                        DataGridViewRow fila = new DataGridViewRow();

                        fila.CreateCells(dataGridView1);
                        fila.Cells[0].Value = Convert.ToInt32(listaColaboradorID[i]);
                        fila.Cells[1].Value = listaCurp[i];
                        fila.Cells[2].Value = listaNombre[i];
                        fila.Cells[3].Value = listaPrimerApellido[i];
                        fila.Cells[4].Value = listaSegundoApellido[i];
                        fila.Cells[5].Value = listaClaveEstado[i];
                        fila.Cells[6].Value = listaMunicipioID[i];
                        fila.Cells[7].Value = listaOcupacionID[i];
                        fila.Cells[8].Value = listaNivelEstudios[i];
                        fila.Cells[9].Value = listaClaveDocProbatorio[i];
                        fila.Cells[10].Value = listaClaveInstitucion[i];


                        dataGridView1.Rows.Add(fila);
                    }

                }
                else
                {
                    MessageBox.Show("No se han encontrado los datos.");
                }
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            InsertarColaboradores ventana = new InsertarColaboradores();
            ventana.ShowDialog();
            dataGridView1.Rows.Clear();
            getColaboradores();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere eliminar al colaborador?", "Eliminar colaborador", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = "UPDATE colaboradores SET status = 0 WHERE colaborador_id = '" + colaboradorID + "';";
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                Conexion.Close();

                MessageBox.Show("¡Colaborador eliminado satisfactoriamente!");
                this.dataGridView1.Rows.Clear();
                getColaboradores();

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            row = e.RowIndex;
            if (row >= 0)
            {

                colaboradorCURP = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (row <= -1)
            {

                MessageBox.Show("Favor de seleccionar un usuario de la lista.");

            }
            else if (row >= 0)
            {

                ModificarColaboradores modificar = new ModificarColaboradores(colaboradorCURP);
                modificar.ShowDialog();
                dataGridView1.Rows.Clear();
                getColaboradores();

            }
        }
    }
}
