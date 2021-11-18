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
    public partial class RegistrarCursos : Form
    {
        public RegistrarCursos()
        {
            InitializeComponent();
        }

        private void RegistrarCursos_Load(object sender, EventArgs e)
        {
            int instructorID = 0, competenciaID = 0;
            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "select rfcAgente from instructores;";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    cmbInstructor.Items.Add(reader.GetString(0));

                }
                Conexion.Close();



            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                MessageBox.Show(exception.Message);
            }

            sql = "select descripcion from competencias;";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    cmbCompetencia.Items.Add(reader.GetString(0));

                }
                Conexion.Close();



            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                MessageBox.Show(exception.Message);
            }



            if (Cursos.modificar)
            {
                
                sql = "select * from cursos where curso_id=" + Cursos.cursoID + ";";

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

                        txtClaveCurso.Text = reader.GetString(1);
                        txtNombreCurso.Text = reader.GetString(2);
                        txtClaveAreaTema.Text = reader.GetString(3);
                        cmbDuracion.SelectedItem = Convert.ToString(Convert.ToInt32(reader["duracion"].ToString()));
                        dteFechaInicio.Value = Convert.ToDateTime(reader["fechaInicio"].ToString());
                        dteFechaFin.Value = Convert.ToDateTime(reader["fechaFin"].ToString());
                        cmbClaveObjetivo.Text = reader.GetString(7);
                        cmbClaveModalidad.Text = reader.GetString(8);
                        cmbCompetencia.SelectedItem = obtenerDato(sqlCompetencia,0);
                        cmbInstructor.SelectedItem = obtenerDato(sqlInstructor, 0);

                    }
                    Conexion.Close();



                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void RegistrarCursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursos.modificar = false;
        }

        private void RegistrarCursos_Leave(object sender, EventArgs e)
        {
            Cursos.modificar = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int instructorID = 0, competenciaID = 0;
            string fechaFin = Convert.ToString((Convert.ToDateTime(dteFechaFin.Value)).ToString("yyyy/MM/dd"));
            string fechaInicio = Convert.ToString((Convert.ToDateTime(dteFechaInicio.Value)).ToString("yyyy/MM/dd"));

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);

            String sql = "select instructor_id from instructores where rfcAgente='" + cmbInstructor.Text + "';";

            try
            {
                MessageBox.Show("si entra");
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    instructorID = Convert.ToInt32(reader["instructor_id"].ToString());

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error al obtener instructorID");
                MessageBox.Show(exception.Message);
            }


            sql = "select competencia_id from competencias where descripcion='" + (string)cmbCompetencia.SelectedItem + "';";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    competenciaID = Convert.ToInt32(reader["competencia_id"].ToString());

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error al obtener CompetenciaID");
                MessageBox.Show(exception.Message);
            }



            if (Cursos.modificar)
            {


                sql = "update cursos set claveCurso='" + txtClaveCurso.Text + "', nombreCurso='" + txtNombreCurso.Text +
                              "',claveAreaTema='" + txtClaveAreaTema.Text + "',duracion='" + (string)cmbDuracion.SelectedItem +
                              "',fechaInicio='" + fechaInicio + "', fechaFin='" + fechaFin +
                              "', claveObjetivo='" + cmbClaveObjetivo.Text + "',claveModalidad='" + cmbClaveModalidad + "',competencia_id='" + competenciaID +
                              "', instructor_id='" + instructorID + "' where curso_id='" + Cursos.cursoID + "' ;";

                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    command.ExecuteReader();
                    Conexion.Close();
                    MessageBox.Show("El curso de modifico con exito");
                    this.Dispose();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error al modificar el curso");
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {

                sql = "insert into cursos (claveCurso,nombreCurso,claveAreaTema,duracion,fechaInicio,fechaFin,claveObjetivo," +
                    "claveModalidad,competencia_id,instructor_id,status) values ('" + txtClaveCurso.Text + "','" + txtNombreCurso.Text + "'," +
                    "'" + txtClaveAreaTema.Text + "','" + (string)cmbDuracion.SelectedItem + "','" + fechaInicio + "','" + fechaFin + "'," +
                    "'" + cmbClaveObjetivo.Text + "','" + cmbClaveModalidad.Text + "'," + competenciaID + "," + instructorID + ",1);";
                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    command.ExecuteReader();
                    Conexion.Close();
                    MessageBox.Show("El curso se añadio con exito");
                    this.Dispose();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar curso");
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private string obtenerDato(string sql, int datobd)
        {
            string dato = "";
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
    }
}
