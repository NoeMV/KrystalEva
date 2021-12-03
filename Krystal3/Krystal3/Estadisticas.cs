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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            chartCursos.Series[0].Color = Color.Coral;
            chartHoras.Series[0].Color = Color.Coral;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            
            llenarCursos();
            llenarHoM();
            horascursos();
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

                    cantCursos = Convert.ToInt32(reader["cantidad"].ToString());

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
            int enero = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-01-01' AND fechaFin<= '2021-01-30'");
            int febrero = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-02-01' AND fechaFin<= '2021-02-28'");
            int marzo = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-03-01' AND fechaFin<= '2021-03-31'");
            int abril = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-04-01' AND fechaFin<= '2021-04-30'");
            int mayo = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-05-01' AND fechaFin<= '2021-05-31'");
            int junio = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-06-01' AND fechaFin<= '2021-06-30'");
            int julio = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-07-01' AND fechaFin<= '2021-07-31'");
            int agosto = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-08-01' AND fechaFin<= '2021-08-31'");
            int septiembre = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-09-01' AND fechaFin<= '2021-09-30'");
            int octubre = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-01-10' AND fechaFin<= '2021-10-31'");
            int noviembre = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-11-01' AND fechaFin<= '2021-11-30'");
            int diciembre = cantidadCursos("SELECT count(*) as cantidad FROM Cursos where status=1 AND fechaInicio>= '2021-12-01' AND fechaFin<= '2021-12-31'");

            chartCursos.Series[0].Points.AddXY("ENERO",enero);
            chartCursos.Series[0].Points.AddXY("FEBRERO",febrero);
            chartCursos.Series[0].Points.AddXY("MARZO",marzo);
            chartCursos.Series[0].Points.AddXY("ABRIL",abril);
            chartCursos.Series[0].Points.AddXY("MAYO",mayo);
            chartCursos.Series[0].Points.AddXY("JUNIO",junio);
            chartCursos.Series[0].Points.AddXY("JULIO",julio);
            chartCursos.Series[0].Points.AddXY("AGOSTO",agosto);
            chartCursos.Series[0].Points.AddXY("SEPTIEMBRE",septiembre);
            chartCursos.Series[0].Points.AddXY("OCTUBRE",octubre);
            chartCursos.Series[0].Points.AddXY("NOVIEMBRE",noviembre);
            chartCursos.Series[0].Points.AddXY("DICIEMBRE",diciembre);




        }

        public String getOcupacion(String sql) {

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String ocupacion="";
            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    ocupacion=reader["descripcion"].ToString();

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener la ocupacion");
            }

            return ocupacion;

        }

        public void llenarHoM()
        {
            String sql = "Select DISTINCT colaborador_id from Registros where status=1;";
            ArrayList sexoM = new ArrayList();
            ArrayList colaboradorID= new ArrayList();
            
            int cantHombres = 0, cantMujeres=0;

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            
            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   colaboradorID.Add(Convert.ToString(Convert.ToInt32(reader["colaborador_id"].ToString())));


                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener el colaborador id");
            }

            
            try
            {
               
                for (int i=0;i<colaboradorID.Count;i++)
                {
                    sql = "select curp from Colaboradores where colaborador_id='" + Convert.ToString(colaboradorID[i]) + "';";

                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show("Si entra");
                        String curp = reader["curp"].ToString();
                        sexoM.Add(curp.Substring(10, 1));

                        if ((sexoM[i].ToString()).Equals("H"))
                        {
                            cantHombres = cantHombres + 1;

                        }else if ((sexoM[i].ToString()).Equals("M"))
                        {
                            cantMujeres = cantMujeres + 1;

                        }
                        
                    }
                    Conexion.Close();
                }
                
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener el genero del colaborador");
            }

            chartHoM.Series[0].Points.AddXY("Hombres", cantHombres);
            chartHoM.Series[0].Points.AddXY("Mujeres", cantMujeres);

        }

        public void llenarOcupacion()
        {

            String sql = "Select DISTINCT colaborador_id from Registros where status=1;";
            ArrayList puestos = new ArrayList();
            ArrayList colaboradorID = new ArrayList();
           
            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colaboradorID.Add(Convert.ToString(Convert.ToInt32(reader["colaborador_id"].ToString())));


                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener el colaborador id");
            }


            try
            {

                for (int i = 0; i < colaboradorID.Count; i++)
                {
                    sql = "select DISTINCT ocupacion_id from Colaboradores where colaborador_id='" + Convert.ToString(colaboradorID[i]) + "';";
                    String ocupacion= getOcupacion(sql);

                    sql = "select DISTINCT descripcion from Ocupaciones where ocupacion_id='" + ocupacion + "';";

                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show("Si entra");
                        
                        puestos.Add(reader["descripcion"].ToString());

                        

                    }
                    Conexion.Close();
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener el genero del colaborador");
            }

            for (int i = 0; i < puestos.Count; i++)
            {
                chartHoM.Series[0].Points.AddXY(puestos[i]);
               


            }
            


        }

        public void horascursos()
        {
            String sql = "Select DISTINCT claveObjetivo from Cursos where status=1 order by claveObjetivo asc";
            ArrayList claveObjetivo = new ArrayList();
            ArrayList horasPorObjetivo = new ArrayList();
            ArrayList objetivoID = new ArrayList();

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    claveObjetivo.Add((Convert.ToInt32(reader["claveObjetivo"].ToString())));


                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al obtener el la clave objetivo");
            }

            for(int i = 0; i < claveObjetivo.Count; i++)
            {

                sql = "select sum(duracion) as duracion FROM Cursos where claveObjetivo = '" + Convert.ToString(claveObjetivo[i])+"' and status='1';";

                miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                Conexion = new SqlConnection(miConexion);

                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        objetivoID.Add(claveObjetivo[i]);
                        horasPorObjetivo.Add((reader["duracion"].ToString()));


                    }
                    Conexion.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    MessageBox.Show("Ha ocurrido un error al obtener las horas de los cursos");
                }
            }

            for (int i = 0; i < claveObjetivo.Count; i++)
            {
                chartHoras.Series[0].Points.AddXY(getObjetivo(Convert.ToInt32(objetivoID[i])),horasPorObjetivo[i]);



            }



        }

        private string getObjetivo(int clave)
        {
            string objetivo = "";

            switch (clave)
            {

                case 1:
                    objetivo = "Actualizar y perfeccionar conocimientos y habilidades";
                    break;

                case 2:
                    objetivo = "Proporcionar informacion de nuevas tecnologias";
                    break;

                case 3:
                    objetivo = "Preparar para ocupar vacantes o puestos de nueva creacion";
                    break;

                case 4:
                    objetivo = "Prevenir riesgos de trabajo";
                    break;

                case 5:
                    objetivo = "Incremento a la productividad";
                    break;
            }

            return objetivo;

        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            chartHoras.Visible = true;
            chartHoM.Visible = false;
            chartCursos.Visible = false;
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            chartHoras.Visible = false;
            chartHoM.Visible = true;
            chartCursos.Visible = false;
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            chartHoras.Visible = false;
            chartHoM.Visible = false;
            chartCursos.Visible = true;
        }
    }
    
}
