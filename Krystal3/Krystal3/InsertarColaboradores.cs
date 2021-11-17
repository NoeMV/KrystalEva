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
    public partial class InsertarColaboradores : Form
    {
        public InsertarColaboradores()
        {

            InitializeComponent();
            CargarEstados();
            CargarMunicipios();
            CargarOcupaciones();
            CargarNivelesEstudio();
            CargarDocProb();

        }

        private void CargarEstados()
        {

            cbxEstados.Items.Add("AGUASCALIENTES");
            cbxEstados.Items.Add("BAJA CALIFORNIA");
            cbxEstados.Items.Add("BAJA CALIFORNIA SUR");
            cbxEstados.Items.Add("CAMPECHE");
            cbxEstados.Items.Add("COAHUILA");
            cbxEstados.Items.Add("COLIMA");
            cbxEstados.Items.Add("CHIAPAS");
            cbxEstados.Items.Add("CHIHUAHUA");
            cbxEstados.Items.Add("DISTRITO FEDERAL");
            cbxEstados.Items.Add("DURANGO");
            cbxEstados.Items.Add("GUANAJUATO");
            cbxEstados.Items.Add("GUERRERO");
            cbxEstados.Items.Add("HIDALGO");
            cbxEstados.Items.Add("JALISCO");
            cbxEstados.Items.Add("MEXICO");
            cbxEstados.Items.Add("MICHOACAN");
            cbxEstados.Items.Add("MORELOS");
            cbxEstados.Items.Add("NAYARIT");
            cbxEstados.Items.Add("NUEVO LEON");
            cbxEstados.Items.Add("OAXACA");
            cbxEstados.Items.Add("PUEBLA");
            cbxEstados.Items.Add("QUERETARO");
            cbxEstados.Items.Add("QUINTANA ROO");
            cbxEstados.Items.Add("SAN LUIS POTOSI");
            cbxEstados.Items.Add("SINALOA");
            cbxEstados.Items.Add("SONORA");
            cbxEstados.Items.Add("TABASCO");
            cbxEstados.Items.Add("TAMAULIPAS");
            cbxEstados.Items.Add("TLAXCALA");
            cbxEstados.Items.Add("VERACRUZ DE IGNACIO DE LA LLAVE");
            cbxEstados.Items.Add("YUCATAN");
            cbxEstados.Items.Add("ZACATECAS");            

        }

        private void CargarMunicipios()
        {

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT descripcion FROM municipios";

            try
            {

                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cbxMunicipios.Items.Add(reader["descripcion"].ToString());
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

                MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);

            }


        }

        private void CargarOcupaciones()
        {

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT descripcion FROM ocupaciones";

            try
            {

                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cbxOcupaciones.Items.Add(reader["descripcion"].ToString());
                    }

                }
                else
                {

                    MessageBox.Show("Error al cargar datos de ocupaciones, si el problema persiste contacte al administrador.");

                }
                Conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("No se pudo establecer conexión con la base de datos, contacte al administrador.\n" + e.Message);

            }



        }

        private void CargarNivelesEstudio()
        {

            cbxNivelEstudios.Items.Add("Ninguno");
            cbxNivelEstudios.Items.Add("Primaria");
            cbxNivelEstudios.Items.Add("Secundaria");
            cbxNivelEstudios.Items.Add("Bachillerato");
            cbxNivelEstudios.Items.Add("Carrera técnica");
            cbxNivelEstudios.Items.Add("Licenciatura");
            cbxNivelEstudios.Items.Add("Especialidad");
            cbxNivelEstudios.Items.Add("Maestría");
            cbxNivelEstudios.Items.Add("Doctorado");

        }

        private void CargarDocProb()
        {

            cbxDocProb.Items.Add("Título");
            cbxDocProb.Items.Add("Certificado");
            cbxDocProb.Items.Add("Diploma");
            cbxDocProb.Items.Add("Otro");
            cbxDocProb.Items.Add("Ninguno");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
