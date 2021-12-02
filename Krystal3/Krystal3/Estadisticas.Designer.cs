
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
            this.chartHoM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHoras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHoras = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.chartCursos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHoM
            // 
            chartArea1.AxisX.Title = "Colaboradores que toman cursos por genero";
            chartArea1.Name = "ChartArea1";
            this.chartHoM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHoM.Legends.Add(legend1);
            this.chartHoM.Location = new System.Drawing.Point(186, 39);
            this.chartHoM.Name = "chartHoM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartHoM.Series.Add(series1);
            this.chartHoM.Size = new System.Drawing.Size(530, 350);
            this.chartHoM.TabIndex = 1;
            this.chartHoM.Text = "chart1";
            this.chartHoM.Visible = false;
            // 
            // chartHoras
            // 
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "Horas de cursos";
            this.chartHoras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHoras.Legends.Add(legend2);
            this.chartHoras.Location = new System.Drawing.Point(186, 39);
            this.chartHoras.Name = "chartHoras";
            series2.ChartArea = "Horas de cursos";
            series2.Legend = "Legend1";
            series2.Name = "Horas de cursos";
            this.chartHoras.Series.Add(series2);
            this.chartHoras.Size = new System.Drawing.Size(530, 350);
            this.chartHoras.TabIndex = 2;
            this.chartHoras.Text = "chart1";
            this.chartHoras.Visible = false;
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(37, 121);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(93, 47);
            this.btnHoras.TabIndex = 3;
            this.btnHoras.Text = "Horas Cursos";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.Location = new System.Drawing.Point(37, 186);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(93, 60);
            this.btnGenero.TabIndex = 4;
            this.btnGenero.Text = "Cursos por genero";
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(37, 273);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(93, 48);
            this.btnMeses.TabIndex = 5;
            this.btnMeses.Text = "Cursos por mes";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // chartCursos
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.Name = "ChartArea1";
            this.chartCursos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCursos.Legends.Add(legend3);
            this.chartCursos.Location = new System.Drawing.Point(186, 39);
            this.chartCursos.Name = "chartCursos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCursos.Series.Add(series3);
            this.chartCursos.Size = new System.Drawing.Size(530, 350);
            this.chartCursos.TabIndex = 6;
            this.chartCursos.Text = "chart1";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartCursos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.btnGenero);
            this.Controls.Add(this.btnHoras);
            this.Controls.Add(this.chartHoras);
            this.Controls.Add(this.chartHoM);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHoM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoras;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCursos;
    }
}