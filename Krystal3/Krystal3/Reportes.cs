using CrystalDecisions.CrystalReports.Engine;
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
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using Krystal3.Reportes;
using System.IO;

namespace Krystal3
{
    public partial class btnDecsargar : Form
    {
        public btnDecsargar()
        {
            InitializeComponent();
            cargarReportes();
            cbxDescarga.SelectedIndex = 0;
        }

        reportebueno obj = new reportebueno();
        DataTable Product = new DataTable();
        string fechaInicio = "";
        string fechaFin = "";

        private void cargarReportes()
        {
            Product.Clear();
            Product.Reset();
            Product.Columns.Add("CURP");
            Product.Columns.Add("NOMBRE");
            Product.Columns.Add("PRIMER_APELLIDO");
            Product.Columns.Add("SEGUNDO_APELLIDO");
            Product.Columns.Add("CLAVE_ESTADO");
            Product.Columns.Add("CLAVE_MUNICIPIO");
            Product.Columns.Add("CLAVE_OCUPACION");
            Product.Columns.Add("CLAVE_NIV_ESTUDIOS");
            Product.Columns.Add("CLAVE_DOC_PROBATORIO");
            Product.Columns.Add("CLAVE_INSTITUCION");
            Product.Columns.Add("CLAVE_CURSO");
            Product.Columns.Add("NOMBRE_CURSO");
            Product.Columns.Add("CLAVE_AREA_TEMA");
            Product.Columns.Add("DURACION");
            Product.Columns.Add("FECHAINICIO");
            Product.Columns.Add("FECHAFIN");
            Product.Columns.Add("CLAVE_TIPO_AGENTE");
            Product.Columns.Add("RFC_AGENTE_STPS");
            Product.Columns.Add("CLAVE_MODALIDAD");

            fechaInicio = Convert.ToString((Convert.ToDateTime(dteFechaInicio.Value)).ToString("yyyy/MM/dd"));
            fechaFin = Convert.ToString((Convert.ToDateTime(dteFechaFin.Value)).ToString("yyyy/MM/dd"));

            String miConexion = ConfigurationManager.ConnectionStrings["NombreConexion"].ConnectionString;
            SqlConnection Conexion = new SqlConnection(miConexion);
            String sql = "SELECT Colaboradores.curp, Colaboradores.nombre, Colaboradores.primerApellido as 'Primer_Apellido', Colaboradores.segundoApellido as 'Segundo_Apellido', Colaboradores.claveEstado as 'Clave_Estado', Municipios.clave as 'Clave_Municipio', Ocupaciones.clave as 'Clave_Ocupacion', Colaboradores.claveNivelEstudios as 'Clave_Niv_Estudios', Colaboradores.claveDocProbatorio as 'Clave_Doc_Probatorio', Colaboradores.claveInstitucion as 'Clave_Institucion', Cursos.claveCurso as 'Clave_Curso', Cursos.nombreCurso as 'Nombre_Curso', Cursos.claveAreaTema as 'Clave_Area_Tema', Cursos.duracion, Cursos.fechaInicio, Cursos.fechaFin, Instructores.rfcAgente as 'RFC_Agente_STPS', Instructores.claveTipoAgente as 'Clave_Tipo_Agente', Cursos.claveModalidad as 'Clave_Modalidad' FROM Registros INNER JOIN Colaboradores ON Registros.colaborador_id = Colaboradores.colaborador_id INNER JOIN Cursos ON Registros.curso_id = Cursos.curso_id INNER JOIN Instructores ON Cursos.instructor_id = Instructores.instructor_id INNER JOIN Municipios ON Colaboradores.municipio_id = Municipios.municipio_id INNER JOIN Ocupaciones ON Colaboradores.ocupacion_id = Ocupaciones.ocupacion_id " +
            "WHERE Cursos.fechaInicio >= '"+ fechaInicio + "' and Cursos.fechaFin <= '" + fechaFin + "' and Registros.status = 1;";


            try
            {
                SqlCommand command = new SqlCommand(sql, Conexion);
                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    String curp = reader.GetString(0);
                    String nombre = reader.GetString(1);
                    String primerApellido = reader.GetString(2);
                    String segundoApellido = reader.GetString(3);
                    String claveEstado = reader.GetString(4);
                    String claveMunicipio = reader.GetString(5);
                    String claveOcupacion = reader.GetString(6);
                    String claveNivEstudios = reader.GetString(7);
                    String claveDocProbatorio = reader.GetString(8);
                    String claveInstitucion = reader.GetString(9);
                    String claveCurso = reader.GetString(10);
                    String nombreCurso = reader.GetString(11);
                    String claveAreaTematica = reader.GetString(12);
                    int duracion = Convert.ToInt32(reader["duracion"].ToString());
                    
                    
                    String claveTipoAgente = reader.GetString(16);
                    String rfcAgente = reader.GetString(17);
                    String claveModalidad = reader.GetString(18);

                    Product.Rows.Add(curp, nombre, primerApellido, segundoApellido, claveEstado, claveMunicipio, claveOcupacion, claveNivEstudios, claveDocProbatorio, claveInstitucion, claveCurso, nombreCurso, claveAreaTematica, duracion, (Convert.ToDateTime(reader["fechaInicio"].ToString())).ToString("yyyy/MM/dd"), (Convert.ToDateTime(reader["fechaFin"].ToString())).ToString("yyyy/MM/dd"), claveTipoAgente, rfcAgente, claveModalidad);

                }
                Conexion.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Ha ocurrido un error al conectar con la base de datos");
            }

            /*fechaFin = "'" + fechaFin + "'";
            fechaInicio = "'" + fechaInicio + "'";

            */

            obj.SetDataSource(Product);

            

            (obj.ReportDefinition.ReportObjects["startDate"] as TextObject).Text = fechaInicio;
            (obj.ReportDefinition.ReportObjects["endDate"] as TextObject).Text = fechaFin;

            this.crystalReportViewer1.ReportSource = obj;

            obj.SetDatabaseLogon("noe26_SQLLogin_1", "9ohizywdqn");

            obj.SetParameterValue("@inicia", fechaInicio);
            obj.SetParameterValue("@final", fechaFin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarReportes();
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            crystalReportViewer1.ParameterFieldInfo[0].DefaultValues.AddValue(DateTime.Today); // First Parameter value set to an Int value

            crystalReportViewer1.ParameterFieldInfo[1].DefaultValues.AddValue(DateTime.Today); // Second Parameter set to a DateTime value
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ParameterFieldInfo[0].DefaultValues.AddValue(DateTime.Today); // First Parameter value set to an Int value

            crystalReportViewer1.ParameterFieldInfo[1].DefaultValues.AddValue(DateTime.Today); // Second Parameter set to a DateTime value
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            ReportDocument rdReport = new ReportDocument();
            string dire2 = Path.Combine(Environment.CurrentDirectory, "reortebueno.rpt");
            string direccion = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Reportes\\reportebueno.rpt");
            rdReport.Load(direccion);
            rdReport.SetDataSource(Product);
            (rdReport.ReportDefinition.ReportObjects["startDate"] as TextObject).Text = fechaInicio;
            (rdReport.ReportDefinition.ReportObjects["endDate"] as TextObject).Text = fechaFin;
            ExportOptions exportOption;
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();

            SaveFileDialog sfd = new SaveFileDialog();
            if (cbxDescarga.SelectedIndex == 0)
            {
                sfd.Filter = "Pdf Files|*.pdf";
            } else
            {
                sfd.Filter = "Excel |*.xls";
            }
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                diskFileDestinationOptions.DiskFileName = sfd.FileName;
            }
            exportOption = rdReport.ExportOptions;
            {
                exportOption.ExportDestinationType = ExportDestinationType.DiskFile;

                exportOption.DestinationOptions = diskFileDestinationOptions;

                if (cbxDescarga.SelectedIndex == 0)
                {
                    exportOption.FormatOptions = new PdfRtfWordFormatOptions();
                    exportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                }
                else
                {
                    exportOption.ExportFormatType = ExportFormatType.Excel;
                    exportOption.FormatOptions = new ExcelFormatOptions();
                }

                
                
                


            }
            rdReport.Export();
        }
    }
}
