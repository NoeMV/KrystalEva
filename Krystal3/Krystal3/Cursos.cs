using System;
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
    public partial class Cursos : Form
    {
        public static string cursoID="";
        public static Boolean modificar = false, seleccion=false;
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            RegistrarCursos ventana = new RegistrarCursos();
            ventana.ShowDialog();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dgvCursos.CurrentCell = dgvCursos.Rows[-1].Cells[-1];
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            
            if (n != -1)
            {
               
                modificar = true;
                seleccion = true;
                cursoID = (string)dgvCursos.Rows[n].Cells[0].Value;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (seleccion)
            {

                RegistrarCursos ventana = new RegistrarCursos();
                ventana.ShowDialog();

            }
            else
            {
                MessageBox.Show("Para modificar seleccione un curso");
            }
            
        }

        private void Cursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            seleccion = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (seleccion)
            {

                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = "update cursos set status='0' where curso_id='" + cursoID + "';";


                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("El curso se eliminó con exito");
                    Conexion.Close();
                    vaciarTabla();
                    llenarTabla();
                    

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                    MessageBox.Show(exception.Message);
                }

            }
            

        }

        private string obtenerDato(string sql, int datobd)
        {
            string dato="";
            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);



            //String sql = "select instructor_id from instructores where rfcAgente='" + (string)cmbCompetencia.SelectedItem + "';";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    dato = reader.GetString(datobd);

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error al obtener instructorID");
                MessageBox.Show(exception.Message);
            }

            return dato;
        }

        public void llenarTabla()
        {
            int instructorID = 0, competenciaID = 0;

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "select * from cursos where status='1';";


            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    competenciaID = Convert.ToInt32(reader["competencia_id"].ToString());
                    instructorID = Convert.ToInt32(reader["instructor_id"].ToString());
                    string sqlInstructor = "select rfcAgente from instructores where instructor_id='" + instructorID + "';";
                    string sqlCompetencia = "select descripcion from competencias where competencia_id='" + competenciaID + "';";
                    int n = dgvCursos.Rows.Add();

                    dgvCursos.Rows[n].Cells[0].Value = Convert.ToString(Convert.ToInt32(reader["curso_id"].ToString()));
                    dgvCursos.Rows[n].Cells[1].Value = reader.GetString(1);
                    dgvCursos.Rows[n].Cells[2].Value = reader.GetString(2);
                    dgvCursos.Rows[n].Cells[3].Value = reader.GetString(3);
                    dgvCursos.Rows[n].Cells[4].Value = Convert.ToString(Convert.ToInt32(reader["duracion"].ToString()));
                    dgvCursos.Rows[n].Cells[5].Value = Convert.ToString((Convert.ToDateTime(reader["fechaInicio"].ToString())).ToString("yyyy/MM/dd"));
                    dgvCursos.Rows[n].Cells[6].Value = Convert.ToString((Convert.ToDateTime(reader["fechaFin"].ToString())).ToString("yyyy/MM/dd"));
                    dgvCursos.Rows[n].Cells[7].Value = reader.GetString(7);
                    dgvCursos.Rows[n].Cells[8].Value = reader.GetString(8);
                    dgvCursos.Rows[n].Cells[9].Value = obtenerDato(sqlCompetencia, 0);
                    dgvCursos.Rows[n].Cells[10].Value = obtenerDato(sqlInstructor, 0);

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
            }


        }

        private void dgvCursos_Enter(object sender, EventArgs e)
        {
            
        }

        public void vaciarTabla()
        {
            dgvCursos.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
