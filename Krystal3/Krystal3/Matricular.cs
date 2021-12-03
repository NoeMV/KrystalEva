using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krystal3
{
    public partial class Matricular : Form
    {
        public Matricular()
        {
            InitializeComponent();
            GetClaveMunicipio(0, "");
            GetColaboradoresRegistrados();
            GetColaboradores();
            labelNombre.Text = "Nombre: " + Cursos.cursoNombre;
            labelDuracion.Text = "Duracion: " + Cursos.cursoDuracion;
            labelInicio.Text = "Fecha de Inicio: " + Cursos.cursoFechaInicio;
            labelFin.Text = "Fecha de finalizacion: " + Cursos.cursoFechaFin;
        }

        private static String colaboradorID = "";
        private static String tabla1ID = "";
        private static String tabla2ID = "";
        private static String colaboradorCURP = "";
        private static int row = -1;
        private static String[,] arrayMunicipios = new String[2460, 2];
        private static String claveID = "";

        private void Matricular_Load(object sender, EventArgs e)
        {

        }

        public void GetColaboradoresRegistrados()
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
            String sql = "SELECT * FROM Colaboradores WHERE status = 1 and colaborador_id IN (SELECT colaborador_id FROM Registros WHERE curso_id = "+ Cursos.cursoID +" AND status = 1);";

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
                        GetClaveMunicipio(1, Convert.ToString(listaMunicipioID[i]));
                        fila.Cells[6].Value = claveID;
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

        public void GetColaboradores()
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
            String sql = "SELECT * FROM Colaboradores WHERE status = 1 and NOT colaborador_id IN (SELECT colaborador_id FROM Registros WHERE curso_id = " + Cursos.cursoID + ");";

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
                    dataGridView2.Rows.Clear();
                    for (int i = 0; i < listaColaboradorID.Count; i++)
                    {
                        DataGridViewRow fila = new DataGridViewRow();

                        fila.CreateCells(dataGridView2);
                        fila.Cells[0].Value = Convert.ToInt32(listaColaboradorID[i]);
                        fila.Cells[1].Value = listaCurp[i];
                        fila.Cells[2].Value = listaNombre[i];
                        fila.Cells[3].Value = listaPrimerApellido[i];
                        fila.Cells[4].Value = listaSegundoApellido[i];
                        fila.Cells[5].Value = listaClaveEstado[i];
                        GetClaveMunicipio(1, Convert.ToString(listaMunicipioID[i]));
                        fila.Cells[6].Value = claveID;
                        fila.Cells[7].Value = listaOcupacionID[i];
                        fila.Cells[8].Value = listaNivelEstudios[i];
                        fila.Cells[9].Value = listaClaveDocProbatorio[i];
                        fila.Cells[10].Value = listaClaveInstitucion[i];


                        dataGridView2.Rows.Add(fila);
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

        private void GetClaveMunicipio(int funcion, String clave)
        {
            if (funcion == 0)
            {
                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = "SELECT municipio_id, clave FROM municipios";

                try
                {

                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {

                        int x = 0;
                        while (reader.Read())
                        {

                            arrayMunicipios[x, 0] = reader["municipio_id"].ToString();
                            arrayMunicipios[x, 1] = reader["clave"].ToString();

                            x++;

                        }

                    }
                    else
                    {

                        MessageBox.Show("Error al cargar datos de municipios, si el problema persiste contacte al administrador.");

                    }
                    Conexion.Close();
                }

                catch (Exception e)
                {

                    MessageBox.Show("2: No se pudo establecer conexion.\n" + e.Message);

                }
            }

            else if (funcion == 1)
            {
                int x = Convert.ToInt32(clave) - 1;
                claveID = arrayMunicipios[x, 1];
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!tabla2ID.Equals(""))
            {
                int n = Convert.ToInt32(tabla2ID);

                if (n < dataGridView2.RowCount)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView2);

                    fila.Cells[0].Value = dataGridView2.Rows[n].Cells[0].Value.ToString();
                    fila.Cells[1].Value = dataGridView2.Rows[n].Cells[1].Value.ToString();
                    fila.Cells[2].Value = dataGridView2.Rows[n].Cells[2].Value.ToString();
                    fila.Cells[3].Value = dataGridView2.Rows[n].Cells[3].Value.ToString();
                    fila.Cells[4].Value = dataGridView2.Rows[n].Cells[4].Value.ToString();
                    fila.Cells[5].Value = dataGridView2.Rows[n].Cells[5].Value.ToString();
                    fila.Cells[6].Value = dataGridView2.Rows[n].Cells[6].Value.ToString();
                    fila.Cells[7].Value = dataGridView2.Rows[n].Cells[7].Value.ToString();
                    fila.Cells[8].Value = dataGridView2.Rows[n].Cells[8].Value.ToString();
                    fila.Cells[9].Value = dataGridView2.Rows[n].Cells[9].Value.ToString();
                    fila.Cells[10].Value = dataGridView2.Rows[n].Cells[10].Value.ToString();

                    dataGridView1.Rows.Add(fila);

                    dataGridView2.Rows.RemoveAt(n);
                }
                else
                {
                    MessageBox.Show("Seleccione un campo para añadir al curso");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un campo para añadir al curso");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!tabla1ID.Equals(""))
            {
                int n = Convert.ToInt32(tabla1ID);

                if (n < dataGridView1.RowCount)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);

                    fila.Cells[0].Value = dataGridView1.Rows[n].Cells[0].Value.ToString();
                    fila.Cells[1].Value = dataGridView1.Rows[n].Cells[1].Value.ToString();
                    fila.Cells[2].Value = dataGridView1.Rows[n].Cells[2].Value.ToString();
                    fila.Cells[3].Value = dataGridView1.Rows[n].Cells[3].Value.ToString();
                    fila.Cells[4].Value = dataGridView1.Rows[n].Cells[4].Value.ToString();
                    fila.Cells[5].Value = dataGridView1.Rows[n].Cells[5].Value.ToString();
                    fila.Cells[6].Value = dataGridView1.Rows[n].Cells[6].Value.ToString();
                    fila.Cells[7].Value = dataGridView1.Rows[n].Cells[7].Value.ToString();
                    fila.Cells[8].Value = dataGridView1.Rows[n].Cells[8].Value.ToString();
                    fila.Cells[9].Value = dataGridView1.Rows[n].Cells[9].Value.ToString();
                    fila.Cells[10].Value = dataGridView1.Rows[n].Cells[10].Value.ToString();

                    dataGridView2.Rows.Add(fila);

                    dataGridView1.Rows.RemoveAt(n);
                }
                else
                {
                    MessageBox.Show("Seleccione un campo para eliminar del curso");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un campo para eliminar del curso");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                colaboradorID = dataGridView1.Rows[n].Cells[0].Value.ToString();
                tabla1ID = n.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                colaboradorID = dataGridView2.Rows[n].Cells[0].Value.ToString();
                tabla2ID = n.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            int read = 0;
            bool existe = false;

            ArrayList colaborador_id = new ArrayList();

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT * FROM Registros WHERE status = 1 AND curso_id = " + Cursos.cursoID + ";";
            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        colaborador_id.Add(reader["colaborador_id"].ToString());
                    }
                    Conexion.Close();
                    while (n < dataGridView1.RowCount)
                    {
                        existe = false;
                        m = 0;
                        while (m < colaborador_id.Count)
                        {
                            if (colaborador_id[m].ToString().Equals(dataGridView1.Rows[n].Cells[0].Value.ToString()))
                            {
                                existe = true;
                                m = colaborador_id.Count;
                            }
                            else
                                m++;
                        }
                        if (!existe)
                        {
                            sql = $"INSERT INTO Registros (curso_id, colaborador_id, status) VALUES ({Cursos.cursoID}, {dataGridView1.Rows[n].Cells[0].Value.ToString()}, 1);";
                            command = new SqlCommand(sql, Conexion);
                            Conexion.Open();
                            read = command.ExecuteNonQuery();
                            Conexion.Close();

                            if (read == 0)
                            {
                                MessageBox.Show("Ocurrió un error al registrar.\nInténtelo de nuevo más tarde.");
                                n = dataGridView1.RowCount;
                            }
                        }
                        n++;
                    }
                    n = 0;
                    while(n < dataGridView2.RowCount)
                    {
                        if(Convert.ToInt32(dataGridView2.Rows[n].Cells[0].Value.ToString()) == 12)
                        {
                            String holi = dataGridView2.Rows[n].Cells[0].Value.ToString();
                        }
                        existe = false;
                        m = 0;
                        while(m < colaborador_id.Count)
                        {
                            String hola = colaborador_id[m].ToString();
                            if (colaborador_id[m].ToString().Equals(dataGridView2.Rows[n].Cells[0].Value.ToString()))
                            {
                                existe = true;
                                m = colaborador_id.Count;
                            }
                            else
                                m++;
                        }
                        if (existe)
                        {
                            sql = $"UPDATE Registros SET status = 0 WHERE colaborador_id = {dataGridView2.Rows[n].Cells[0].Value.ToString()} AND status = 1";
                            command = new SqlCommand(sql, Conexion);
                            Conexion.Open();
                            read = command.ExecuteNonQuery();
                            Conexion.Close();

                            if (read == 0)
                            {
                                MessageBox.Show("Ocurrió un error al registrar.\nInténtelo de nuevo más tarde.");
                                n = dataGridView1.RowCount;
                            }
                        }
                        n++;
                    }
                    Conexion.Close();
                }
                else
                {
                    Conexion.Close();
                    while (n < dataGridView1.RowCount)
                    {
                        sql = $"INSERT INTO Registros (curso_id, colaborador_id, status) VALUES ({Cursos.cursoID}, {dataGridView1.Rows[n].Cells[0].Value.ToString()}, 1);";
                        command = new SqlCommand(sql, Conexion);
                        Conexion.Open();
                        read = command.ExecuteNonQuery();
                        Conexion.Close();
                        n++;
                        if(read == 0)
                        {
                            MessageBox.Show("Ocurrió un error al registrar.\nInténtelo de nuevo más tarde.");
                            n = dataGridView1.RowCount;
                        }
                    }
                    Conexion.Close();
                }
                MessageBox.Show("Se han registrado exitosamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion.\n" + ex.Message);
            }
        }
    }
}
