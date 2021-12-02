
namespace Krystal3
{
    partial class Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCursos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHoM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOcupaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcupaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCursos
            // 
            chartArea1.AxisX.Title = "Cursos efectuados por mes";
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea1.Name = "ChartArea1";
            this.chartCursos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCursos.Legends.Add(legend1);
            this.chartCursos.Location = new System.Drawing.Point(248, 91);
            this.chartCursos.Name = "chartCursos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cursos";
            this.chartCursos.Series.Add(series1);
            this.chartCursos.Size = new System.Drawing.Size(387, 300);
            this.chartCursos.TabIndex = 0;
            this.chartCursos.Text = "chart1";
            this.chartCursos.Visible = false;
            // 
            // chartHoM
            // 
            chartArea2.AxisX.Title = "Colaboradores que toman cursos por genero";
            chartArea2.Name = "ChartArea1";
            this.chartHoM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHoM.Legends.Add(legend2);
            this.chartHoM.Location = new System.Drawing.Point(277, 81);
            this.chartHoM.Name = "chartHoM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chartHoM.Series.Add(series2);
            this.chartHoM.Size = new System.Drawing.Size(300, 300);
            this.chartHoM.TabIndex = 1;
            this.chartHoM.Text = "chart1";
            // 
            // chartOcupaciones
            // 
            chartArea3.Name = "ChartArea1";
            this.chartOcupaciones.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartOcupaciones.Legends.Add(legend3);
            this.chartOcupaciones.Location = new System.Drawing.Point(299, 46);
            this.chartOcupaciones.Name = "chartOcupaciones";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartOcupaciones.Series.Add(series3);
            this.chartOcupaciones.Size = new System.Drawing.Size(300, 300);
            this.chartOcupaciones.TabIndex = 2;
            this.chartOcupaciones.Text = "chart1";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartOcupaciones);
            this.Controls.Add(this.chartHoM);
            this.Controls.Add(this.chartCursos);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcupaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCursos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOcupaciones;
    }
}