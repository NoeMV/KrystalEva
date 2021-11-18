using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Krystal3
{
    public partial class ModificarColaboradores : Form
    {

        private string claveEstado, claveMunicipio, claveOcupacion, claveEstudios, claveDoc, claveInstitucion;

        public ModificarColaboradores(String CURP)
        {
            InitializeComponent();
            CargarEstados();
            CargarMunicipios();
            CargarOcupaciones();
            CargarNivelesEstudio();
            CargarDocProb();
            CargarInstituciones();
            GetColaborador(CURP);

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

            cbxEstados.SelectedIndex = 0;

        }

        public void GetColaborador(String CURP)
        {
            
            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT nombre, primerApellido, segundoApellido, claveEstado, municipio_id, ocupacion_id, claveNivelEstudios, claveDocProbatorio, claveInstitucion FROM colaboradores WHERE curp = '" + CURP + "';";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        txtCURP.Text = CURP;
                        txtNombre.Text = reader["nombre"].ToString();
                        txtPrimerApellido.Text = reader["primerApellido"].ToString();
                        txtSegundoApellido.Text = reader["segundoApellido"].ToString();
                        claveEstado = reader["claveEstado"].ToString();
                        claveMunicipio = reader["municipio_id"].ToString();
                        claveOcupacion = reader["ocupacion_id"].ToString();
                        claveEstudios = reader["claveNivelEstudios"].ToString();
                        claveDoc = reader["claveDocProbatorio"].ToString(); ;
                        claveInstitucion = reader["claveInstitucion"].ToString(); ;

                        MatchClaves(claveEstado, claveMunicipio, claveOcupacion, claveEstudios, claveDoc, claveInstitucion);
                    }

                }

                else
                {
                    MessageBox.Show("No se han encontrado los datos del colaborador.");
                }

                Conexion.Close();

            }

            catch (Exception e)
            {
                MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);
            }
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

                    cbxMunicipios.SelectedIndex = 0;

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

                    cbxOcupaciones.SelectedIndex = 0;
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

            cbxNivelEstudios.SelectedIndex = 0;

        }

        private void CargarDocProb()
        {

            cbxDocProb.Items.Add("Título");
            cbxDocProb.Items.Add("Certificado");
            cbxDocProb.Items.Add("Diploma");
            cbxDocProb.Items.Add("Otro");
            cbxDocProb.Items.Add("Ninguno");

            cbxDocProb.SelectedIndex = 0;

        }

        private void CargarInstituciones()
        {

            cbxInstitucion.Items.Add("Pública");
            cbxInstitucion.Items.Add("Privada");
            cbxInstitucion.Items.Add("Ninguna");

            cbxInstitucion.SelectedIndex = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void MatchClaves(String estado, String municipio, String ocupacion, String estudios, String doc, String institucion)
        {

            // Obteniendo estado
            if (estado == "1")
            {
                cbxEstados.Text = "AGUASCALIENTES";
            }
            if (estado == "2")
            {
                cbxEstados.Text = "BAJA CALIFORNIA";
            }
            if (estado == "3")
            {
                cbxEstados.Text = "BAJA CALIFORNIA SUR";
            }
            if (estado == "4")
            {
                cbxEstados.Text = "CAMPECHE";
            }
            if (estado == "5")
            {
                cbxEstados.Text = "COAHUILA";
            }
            if (estado == "6")
            {
                cbxEstados.Text = "COLIMA";
            }
            if (estado == "7")
            {
                cbxEstados.Text = "CHIAPAS";
            }
            if (estado == "8")
            {
                cbxEstados.Text = "CHIHUAHUA";
            }
            if (estado == "9")
            {
                cbxEstados.Text = "DISTRITO FEDERAL";
            }
            if (estado == "10")
            {
                cbxEstados.Text = "DURANGO";
            }
            if (estado == "11")
            {
                cbxEstados.Text = "GUANAJUATO";
            }
            if (estado == "12")
            {
                cbxEstados.Text = "GUERRERO";
            }
            if (estado == "13")
            {
                cbxEstados.Text = "HIDALGO";
            }
            if (estado == "14")
            {
                cbxEstados.Text = "JALISCO";
            }
            if (estado == "15")
            {
                cbxEstados.Text = "MEXICO";
            }
            if (estado == "16")
            {
                cbxEstados.Text = "MICHOACAN";
            }
            if (estado == "17")
            {
                cbxEstados.Text = "MORELOS";
            }
            if (estado == "18")
            {
                cbxEstados.Text = "NAYARIT";
            }
            if (estado == "19")
            {
                cbxEstados.Text = "NUEVO LEON";
            }
            if (estado == "20")
            {
                cbxEstados.Text = "OAXACA";
            }
            if (estado == "21")
            {
                cbxEstados.Text = "PUEBLA";
            }
            if (estado == "22")
            {
                cbxEstados.Text = "QUERETARO";
            }
            if (estado == "23")
            {
                cbxEstados.Text = "QUINTANA ROO";
            }
            if (estado == "24")
            {
                cbxEstados.Text = "SAN LUIS POTOSI";
            }
            if (estado == "25")
            {
                cbxEstados.Text = "SINALOA";
            }
            if (estado == "26")
            {
                cbxEstados.Text = "SONORA";
            }
            if (estado == "27")
            {
                cbxEstados.Text = "TABASCO";
            }
            if (estado == "28")
            {
                cbxEstados.Text = "TAMAULIPAS";
            }
            if (estado == "29")
            {
                cbxEstados.Text = "TLAXCALA";
            }
            if (estado == "30")
            {
                cbxEstados.Text = "VERACRUZ DE IGNACIO DE LA LLAVE";
            }
            if (estado == "31")
            {
                cbxEstados.Text = "YUCATAN";
            }
            if (estado == "32")
            {
                cbxEstados.Text = "ZACATECAS";
            }

            // Obteniendo municipio

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT descripcion from municipios WHERE municipio_id = '" + Convert.ToInt32(municipio) + "';";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        cbxMunicipios.Text = reader["descripcion"].ToString();

                    }

                }

                else
                {
                    MessageBox.Show("Error al obtener el municipio del colaborador.");
                }

                Conexion.Close();

            }

            catch (Exception e)
            {
                MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);
            }
            Conexion.Close();

            // Obteniendo ocupacion

            miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            Conexion = new SqlConnection(miConexion);
            sql = "SELECT descripcion from ocupaciones WHERE ocupacion_id = '" + ocupacion + "';";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        cbxOcupaciones.Text = reader["descripcion"].ToString();

                    }

                }

                else
                {
                    MessageBox.Show("Error al obtener la ocupación del trabajdor.");
                }

                Conexion.Close();

            }

            catch (Exception e)
            {
                MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);
            }
            Conexion.Close();

            // Obteniendo estudios

            if(estudios == "1")
            {
                cbxNivelEstudios.Text = "Ninguno";
            }
            if(estudios == "2")
            {
                cbxNivelEstudios.Text = "Primaria";
            }
            if(estudios == "3")
            {
                cbxNivelEstudios.Text = "Secundaria";
            }
            if(estudios == "4")
            {
                cbxNivelEstudios.Text = "Bachillerato";
            }
            if(estudios == "5")
            {
                cbxNivelEstudios.Text = "Carrera técnica";
            }
            if(estudios == "6")
            {
                cbxNivelEstudios.Text = "Licenciatura";
            }
            if(estudios == "7")
            {
                cbxNivelEstudios.Text = "Especialidad";
            }
            if(estudios == "8")
            {
                cbxNivelEstudios.Text = "Maestría";
            }
            if(estudios == "9")
            {
                cbxNivelEstudios.Text = "Doctorado";
            }

            // Obteniendo documento

            if(doc == "1")
            {
                cbxDocProb.Text = "Título";
            }
            if(doc == "2")
            {
                cbxDocProb.Text = "Certificado";
            }
            if(doc == "3")
            {
                cbxDocProb.Text = "Diploma";
            }
            if(doc == "4")
            {
                cbxDocProb.Text = "Otro";
            }
            if(doc == "5")
            {
                cbxDocProb.Text = "Ninguno";
            }

            // Obteniendo tipo de institución

            if(institucion == "1")
            {
                cbxInstitucion.Text = "Pública";
            }
            if(institucion == "2")
            {
                cbxInstitucion.Text = "Privada";
            }
            if(institucion == "3")
            {
                cbxInstitucion.Text = "Ninguna";
            }
        }
    }
}
