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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void CursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos ventana = new Cursos();
            ventana.ShowDialog();
        }

        private void ColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colaboradores ventana = new Colaboradores();
            ventana.ShowDialog();
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructores ventana = new Instructores();
            ventana.ShowDialog();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        private void AbrirFormulario(Form formulario)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PanelDashboard.Controls.Add(formulario);
            PanelDashboard.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void BtnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Cursos());
        }

        private void BtnColaboradores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Colaboradores());
        }

        private void BtnInstructores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Instructores());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new Reportes());
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new Estadisticas());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
