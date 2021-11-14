using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Krystal3
{
    public partial class ModificarInstructores : Form
    {
        public static Boolean si = false;

        private int claveTipoAgente;
        /*{
            get
            {
                return claveTipoAgente;
            }
            set
            {
                try
                {
                    claveTipoAgente = value;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ingrese un valor valido para la Clave de Agente.\n" + e.Message);
                }
            }
        }*/

        private String rfcAgente;
        /*{
            get
            {
                return rfcAgente;
            }
            set
            {
                rfcAgente = value;
            }
        }*/
        public ModificarInstructores(int IdAgente)
        {
            InitializeComponent();

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = $"SELECT claveTipoAgente, rfcAgente FROM instructores WHERE instructor_id = {IdAgente}";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    claveTipoAgente = Convert.ToInt32(reader["claveTipoAgente"].ToString());
                    rfcAgente = reader["rfcAgente"].ToString();

                    txtID.Text = IdAgente.ToString();
                    txtClave.Text = claveTipoAgente.ToString();
                    txtRFC.Text = rfcAgente;
                }
                Conexion.Close();
            }
            catch 
            {
                
            }
        }

        private void modificarInstructores()
        {
            try
            {
                if (!txtID.Text.Equals("") && !txtClave.Text.Equals("") && !txtRFC.Text.Equals(""))
                {
                    String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                    SqlConnection Conexion = new SqlConnection(miConexion);
                    String sql = $"SELECT status FROM instructores WHERE instructor_id = {Convert.ToInt32(txtID.Text)}";

                    try
                    {
                        SqlCommand command = new SqlCommand(sql, Conexion);
                        Conexion.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            if (reader["status"].ToString().Equals("0"))
                            {
                                MessageBox.Show("Este Instructor no está disponible.");
                            }
                            else
                            {
                                Conexion.Close();
                                if (MessageBox.Show($"¿Seguro que quiere modificar el siguiente instructor?\n{claveTipoAgente}\n{rfcAgente}", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    sql = $"UPDATE instructores SET claveTipoAgente = {Convert.ToInt32(txtClave.Text)}, rfcAgente = '{txtRFC.Text}' WHERE instructor_id = {Convert.ToInt32(txtID.Text)}";

                                    try
                                    {
                                        command = new SqlCommand(sql, Conexion);
                                        Conexion.Open();
                                        int read = command.ExecuteNonQuery();

                                        if (read == 1)
                                        {
                                            MessageBox.Show("Se ha modificado exitosamente.");
                                        }
                                        else if (read == 0)
                                        {
                                            MessageBox.Show("No se pudo modificar.");
                                        }

                                        Conexion.Close();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("No se pudo modificar.");
                                    }
                                }
                            }
                        }
                        Conexion.Close();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo modificar.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Llene todos los campos para modificar.");
                }
            }
            catch
            {
                MessageBox.Show("Indique un ID valido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = $"SELECT claveTipoAgente, rfcAgente FROM instructores WHERE instructor_id = {Convert.ToInt32(txtID.Text)} AND status = 1";

                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        claveTipoAgente = Convert.ToInt32(reader["claveTipoAgente"].ToString());
                        rfcAgente = reader["rfcAgente"].ToString();

                        txtClave.Text = claveTipoAgente.ToString();
                        txtRFC.Text = rfcAgente;
                    }
                    Conexion.Close();
                }
                catch
                {
                    txtID.Text = "";
                    txtClave.Text = "";
                    txtRFC.Text = "";

                    MessageBox.Show("No se encontro el instructor indicado.");
                }
            }
            catch
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarInstructores();
            si = true;
            this.Dispose();
        }
    }
}
