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
            CargarInstituciones();

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere añadir al colaborador?", "Registrar colaborador", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                String ocupacion = "";
                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = $"SELECT clave FROM ocupaciones WHERE descripcion = '" + cbxOcupaciones.Text + "';";
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ocupacion = reader["clave"].ToString();
                    Conexion.Close();

                    MessageBox.Show("Clave de ocupación: " + ocupacion);

                    int IDclaveEstudio = cbxNivelEstudios.SelectedIndex + 1;
                    int IDclaveDoc = cbxDocProb.SelectedIndex + 1;
                    int IDclaveInst = cbxInstitucion.SelectedIndex + 1;

                    try
                    {

                        miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                        Conexion = new SqlConnection(miConexion);
                        sql = $"INSERT INTO COLABORADORES (curp, nombre, primerApellido, segundoApellido, claveEstado, municipio_id, ocupacion_id, claveNivelEstudios, claveDocProbatorio, claveInstitucion, status) "
                        + "VALUES ('" + txtCURP.Text + "','" + txtNombre.Text + "','" + txtPrimerApellido.Text + "','" + txtSegundoApellido.Text + "','" + Convert.ToString(cbxMunicipios.SelectedIndex) + "','" + ocupacion
                        + "','" + Convert.ToString(IDclaveEstudio) + "','" + Convert.ToString(IDclaveDoc) + "','" + Convert.ToString(IDclaveInst) + "','" + Convert.ToString(1) + "');";
                        command = new SqlCommand(sql, Conexion);
                        Conexion.Open();
                        reader = command.ExecuteReader();
                        Conexion.Close();

                        MessageBox.Show("Registro exitoso.");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo establecer conexión con la base de datos, contacte al administrador.");
                    }
                }
                else
                {
                    MessageBox.Show("Error al tratar de obtener el ID de la ocupación, favor de contactar al administrador.");
                }
                Conexion.Close();

            }

        }
    }
}
