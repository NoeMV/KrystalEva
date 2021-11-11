﻿using System;
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
using System.Collections;

namespace Krystal3
{
    public partial class Instructores : Form
    {
        public Instructores()
        {
            InitializeComponent();
            consultarInstructores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void consultarInstructores()
        {
            ArrayList listaID = new ArrayList();
            ArrayList listaClave = new ArrayList();
            ArrayList listaRFC = new ArrayList();

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT instructor_id, claveTipoAgente, rfcAgente FROM instructores";

            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listaID.Add(reader["instructor_id"].ToString());
                        listaClave.Add(reader["claveTipoAgente"].ToString());
                        listaRFC.Add(reader["rfcAgente"].ToString());
                    }
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < listaID.Count; i++)
                    {
                        DataGridViewRow fila = new DataGridViewRow();

                        fila.CreateCells(dataGridView1);
                        fila.Cells[0].Value = listaID[i];
                        fila.Cells[1].Value = listaClave[i];
                        fila.Cells[2].Value = listaRFC[i];

                        dataGridView1.Rows.Add(fila);
                    }
                }
                else
                {
                    MessageBox.Show("No se han encontrado los datos.");
                }
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo establecer conexion.\n" + e.Message);
            }
        }

        //private Boolean modificarInstructores();

        //private Boolean eliminarInstructores()

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            consultarInstructores();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarInstructores ventana = new RegistrarInstructores();
            ventana.ShowDialog();
        }
    }
}