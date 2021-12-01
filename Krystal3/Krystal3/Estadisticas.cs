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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        public int cantidadCursos(String sql)
        {

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            int cantCursos = 0;
            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    cantCursos = Convert.ToInt32(reader.GetString(0));

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener la cantidad de cursos");
            }

            return cantCursos;

        }

        public void llenarCursos()
        {
            int enero = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-01-01' AND fechaFin<= '2021-01-31'");
            int febrero = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-02-01' AND fechaFin<= '2021-02-28'");
            int marzo = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-03-01' AND fechaFin<= '2021-03-31'");
            int abril = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-04-01' AND fechaFin<= '2021-04-30'");
            int mayo = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-05-01' AND fechaFin<= '2021-05-31'");
            int junio = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-06-01' AND fechaFin<= '2021-06-30'");
            int julio = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-07-01' AND fechaFin<= '2021-07-31'");
            int agosto = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-08-01' AND fechaFin<= '2021-08-31'");
            int septiembre = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-09-01' AND fechaFin<= '2021-09-30'");
            int octubre = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-01-10' AND fechaFin<= '2021-10-31'");
            int noviembre = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-11-01' AND fechaFin<= '2021-11-30'");
            int diciembre = cantidadCursos("SELECT count(*) FROM Cursos where status=1 AND fechaInicio>= '2021-12-01' AND fechaFin<= '2021-12-31'");






        }

    }
    
}
