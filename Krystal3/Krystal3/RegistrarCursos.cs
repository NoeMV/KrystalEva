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
            if (Cursos.modificar)
            {
                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = "select * from cursos where curso_id=" + Cursos.cursoID + ";";

                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        txtClaveCurso.Text = reader.GetString(1);
                        txtNombreCurso.Text = reader.GetString(2);
                        txtClaveAreaTema.Text = reader.GetString(3);
                        cmbDuracion.SelectedItem = reader.GetString(4);
                        dteFechaInicio.Value = Convert.ToDateTime(reader.GetString(5));
                        dteFechaFin.Value = Convert.ToDateTime(reader.GetString(6));
                        txtClaveObjetivo.Text = reader.GetString(7);
                        cmbCompetencia.SelectedItem = reader.GetString(8);
                        cmbInstructor.SelectedItem = reader.GetString(9);

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
            if (Cursos.modificar)
            {
                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = "update cursos set claveCurso=" + txtClaveCurso.Text + ", nombreCurso=" + txtNombreCurso.Text +
                              ",claveAreaTema=" + txtClaveAreaTema.Text + ",duracion=" + (string)cmbDuracion.SelectedItem +
                              ",fechaInicio=" + dteFechaInicio.Value as string + ", fechaFin=" + dteFechaFin.Value as string +
                              ", claveObjetivo=" + txtClaveObjetivo.Text + ",competencia_id=" + (string)cmbCompetencia.SelectedItem +
                              ", instructor_id=" + (string)cmbInstructor.SelectedItem + " where curso_id=" + Cursos.cursoID + " ;";
            }
            else
            {


            }
        }
    }
}
