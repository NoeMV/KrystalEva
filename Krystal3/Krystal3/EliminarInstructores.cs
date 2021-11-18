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
            catch
            {

            }
        }
        private void eliminarInstructores()
        {
            try
            {
                if (!txtID.Text.Equals(""))
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
                                if (MessageBox.Show($"¿Seguro que quiere eliminar el siguiente instructor?\n{txtClave.Text}\n{txtRFC.Text}", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    sql = $"UPDATE instructores SET status = 0 WHERE instructor_id = {Convert.ToInt32(txtID.Text)}";

                                    try
                                    {
                                        command = new SqlCommand(sql, Conexion);
                                        Conexion.Open();
                                        int read = command.ExecuteNonQuery();

                                        if (read == 1)
                                        {
                                            MessageBox.Show("Se ha eliminado exitosamente.");
                                        }
                                        else if (read == 0)
                                        {
                                            MessageBox.Show("No se pudo eliminar.");
                                        }

                                        Conexion.Close();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("No se pudo Eliminar.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Indique un ID para eliminar.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo eliminar.");
                    }
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
                String sql = $"SELECT claveTipoAgente, rfcAgente FROM instructores WHERE instructor_id = {Convert.ToInt32(txtID.Text)} AND status = 1";

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
    }
}
