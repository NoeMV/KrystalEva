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
    public partial class Cursos : Form
    {
        public static string cursoID;
        public static Boolean modificar = false;
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            RegistrarCursos ventana = new RegistrarCursos();
            ventana.ShowDialog();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "select * from cursos;";


            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int n = dgvCursos.Rows.Add();

                    dgvCursos.Rows[n].Cells[1].Value = reader.GetString(1);
                    dgvCursos.Rows[n].Cells[2].Value = reader.GetString(2);
                    dgvCursos.Rows[n].Cells[3].Value = reader.GetString(3);
                    dgvCursos.Rows[n].Cells[4].Value = reader.GetString(4);
                    dgvCursos.Rows[n].Cells[5].Value = reader.GetString(5);
                    dgvCursos.Rows[n].Cells[6].Value = reader.GetString(6);
                    dgvCursos.Rows[n].Cells[7].Value = reader.GetString(7);
                    dgvCursos.Rows[n].Cells[8].Value = reader.GetString(8);
                    dgvCursos.Rows[n].Cells[9].Value = reader.GetString(9);


                }
                Conexion.Close();


                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                modificar = true;
                cursoID = (string)dgvCursos.Rows[n].Cells[0].Value;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RegistrarCursos ventana = new RegistrarCursos();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
