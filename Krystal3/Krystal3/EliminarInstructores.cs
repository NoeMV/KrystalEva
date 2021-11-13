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
    public partial class EliminarInstructores : Form
    {
        public static Boolean si = false;

        private int instructorID;
        /*{
            get
            {
                return instructorID;
            }
            set
            {
                instructorID = value;
            }
        }*/

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
        public EliminarInstructores(int IdAgente)
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

                if(reader.Read())
                {
                    txtID.Text = IdAgente.ToString();
                    txtClave.Text = reader["claveTipoAgente"].ToString();
                    txtRFC.Text = reader["rfcAgente"].ToString();
                }
                Conexion.Close();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        private void eliminarInstructores()
        {
            try
            {
                if (!txtID.Text.Equals(""))
                {
                    if (MessageBox.Show($"¿Seguro que quiere eliminar el siguiente instructor?\n{txtClave.Text}\n{txtRFC.Text}", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                        SqlConnection Conexion = new SqlConnection(miConexion);
                        String sql = $"UPDATE instructores SET status = 0 WHERE instructor_id = {Convert.ToInt32(txtID.Text)}";

                        try
                        {
                            SqlCommand command = new SqlCommand(sql, Conexion);
                            Conexion.Open();
                            int reader = command.ExecuteNonQuery();

                            if (reader == 1)
                            {
                                MessageBox.Show("Se ha eliminado exitosamente.");
                            }
                            else if (reader == 0)
                            {
                                MessageBox.Show("No se pudo eliminar.");
                            }

                            Conexion.Close();
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Indique un ID para eliminar.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Indique un ID valido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarInstructores();
            si = true;
            this.Dispose();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection(miConexion);
                String sql = $"SELECT claveTipoAgente, rfcAgente FROM instructores WHERE instructor_id = {Convert.ToInt32(txtID.Text)}";

                try
                {
                    SqlCommand command = new SqlCommand(sql, Conexion);
                    Conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtClave.Text = reader["claveTipoAgente"].ToString();
                        txtRFC.Text = reader["rfcAgente"].ToString();
                    }
                    Conexion.Close();
                }
                catch (Exception ex)
                {
                    txtID.Text = "";
                    txtClave.Text = "";
                    txtRFC.Text = "";

                    MessageBox.Show("No se encontro el instructor indicado.");
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
