using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krystal3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        private bool mouseDown;
        private Point offset;

        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void PanelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void PanelBarra_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
