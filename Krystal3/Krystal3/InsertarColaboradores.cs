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

        private String[,] arrayOcupaciones = new String[4737, 3];
        private String[,] arrayMunicipios = new String[2460, 3];

        public InsertarColaboradores()
        {

            InitializeComponent();
            CargarEstados();
            CargarMunicipios(0);
            CargarMunicipios(1);
            CargarOcupaciones();
            CargarNivelesEstudio();
            CargarDocProb();
            CargarInstituciones();
            cbxOcupaciones.DropDownWidth = CbxAncho(cbxOcupaciones);

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

        private void CargarMunicipios(int funcion)
        {

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT * FROM municipios";

            if (funcion == 0)
            {
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
                            arrayMunicipios[x, 2] = reader["descripcion"].ToString();

                            cbxMunicipios.Items.Add(reader["descripcion"].ToString());
                            x++;
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

            if (funcion == 1)
            {
                if (cbxEstados.SelectedIndex == 0)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 0; x < 11; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 1)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 11; x < 16; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 2)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 16; x < 21; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 3)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 21; x < 32; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 4)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 32; x < 155; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 5)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 155; x < 222; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 6)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 222; x < 260; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 7)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 260; x < 270; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 8)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 270; x < 286; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 9)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 286; x < 325; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 10)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 325; x < 371; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 11)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 371; x < 452; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 12)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 452; x < 536; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 13)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 536; x < 660; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 14)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 660; x < 785; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 15)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 785; x < 898; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 16)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 898; x < 931; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 17)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 931; x < 951; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 18)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 951; x < 1003; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 19)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1003; x < 1573; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 20)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1573; x < 1790; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 21)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1790; x < 1808; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 22)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1808; x < 1819; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 23)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1819; x < 1877; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 24)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1877; x < 1895; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 25)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1895; x < 1965; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 26)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1965; x < 1982; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 27)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 1982; x < 2025; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 28)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 2025; x < 2085; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 29)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 2085; x < 2297; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 30)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 2297; x < 2403; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
                else if (cbxEstados.SelectedIndex == 31)
                {
                    cbxMunicipios.Items.Clear();
                    for (int x = 2403; x < 2460; x++)
                    {
                        cbxMunicipios.Items.Add(arrayMunicipios[x, 2]);
                        cbxMunicipios.SelectedIndex = 0;
                    }
                }
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
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

        private void CbxEstados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (arrayMunicipios[0, 0] != null)
            {
                CargarMunicipios(1);
            }
        }

        private int CbxAncho(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }
    }
}
