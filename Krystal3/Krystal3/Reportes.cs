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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void cargarReportes()
        {
            reportebueno obj = new reportebueno();

            string fechaInicio = Convert.ToString((Convert.ToDateTime(dteFechaInicio.Value)).ToString("yyyy/MM/dd"));
            string fechaFin = Convert.ToString((Convert.ToDateTime(dteFechaFin.Value)).ToString("yyyy/MM/dd"));


            /*fechaFin = "'" + fechaFin + "'";
            fechaInicio = "'" + fechaInicio + "'";*/

            obj.SetDatabaseLogon("noe26_SQLLogin_1", "9ohizywdqn");

            obj.SetParameterValue("@inicia", fechaInicio);
            obj.SetParameterValue("@final", fechaFin);
            

            this.crystalReportViewer1.ReportSource = obj;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarReportes();
        }
    }
}
