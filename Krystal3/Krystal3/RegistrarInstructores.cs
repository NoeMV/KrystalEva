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
    public partial class RegistrarInstructores : Form
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
        public RegistrarInstructores()
        {
            InitializeComponent();
        }

        private Boolean registrarInstructores()
        {
            if (!txtClave.Text.Equals("") && !txtRFC.Text.Equals(""))
            {
                try
                {
                    claveTipoAgente = Convert.ToInt32(txtClave.Text);
                    rfcAgente = txtRFC.Text;

                    String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                    SqlConnection Conexion = new SqlConnection(miConexion);
                    String sql = $"INSERT INTO instructores (claveTipoAgente, rfcAgente, status) VALUES ({claveTipoAgente}, '{rfcAgente}', 1)";

                    try
                    {
                        SqlCommand command = new SqlCommand(sql, Conexion);
                        Conexion.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        Conexion.Close();

                        MessageBox.Show("Registro exitoso.");
                        rfcAgente = "";
                        claveTipoAgente = 0;
                        txtClave.Text = "";
                        txtRFC.Text = "";
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese una clave valida.");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos para continuar.");
            }
            return false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (registrarInstructores())
            {
                si = true;
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
