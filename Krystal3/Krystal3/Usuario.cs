using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krystal3
{
    class Usuario
    {
        String nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        } 

        String usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        String contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }

        public Boolean verificarLogin(String user, String password)
        {
            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "select * from usuario";

            Boolean usu = false, pass = false, exito = false;

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (user.Equals(reader.GetString(2)))
                    {
                        usu = true;
                    }
                    if (password.Equals(reader.GetString(3)))
                    {
                        pass = true;
                    }

                }
                Conexion.Close();

                if (usu == true && pass == true)
                {
                    exito = true;
                }
                else
                {
                    exito = false;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return exito;
        }

    }
}
