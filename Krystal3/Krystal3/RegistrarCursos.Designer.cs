
namespace Krystal3
{
    partial class RegistrarCursos
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
            this.dteFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbDuracion = new System.Windows.Forms.ComboBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.dteFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtClaveAreaTema = new System.Windows.Forms.TextBox();
            this.txtClaveCurso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbClaveModalidad = new System.Windows.Forms.ComboBox();
            this.cmbClaveObjetivo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dteFechaFin
            // 
            this.dteFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFechaFin.Location = new System.Drawing.Point(171, 227);
            this.dteFechaFin.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dteFechaFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dteFechaFin.Name = "dteFechaFin";
            this.dteFechaFin.Size = new System.Drawing.Size(480, 22);
            this.dteFechaFin.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(417, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(195, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbDuracion
            // 
            this.cmbDuracion.FormattingEnabled = true;
            this.cmbDuracion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbDuracion.Location = new System.Drawing.Point(171, 144);
            this.cmbDuracion.Name = "cmbDuracion";
            this.cmbDuracion.Size = new System.Drawing.Size(428, 24);
            this.cmbDuracion.TabIndex = 24;
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(171, 392);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(480, 24);
            this.cmbInstructor.TabIndex = 30;
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(171, 356);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(480, 24);
            this.cmbCompetencia.TabIndex = 29;
            // 
            // dteFechaInicio
            // 
            this.dteFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFechaInicio.Location = new System.Drawing.Point(171, 186);
            this.dteFechaInicio.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dteFechaInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dteFechaInicio.Name = "dteFechaInicio";
            this.dteFechaInicio.Size = new System.Drawing.Size(480, 22);
            this.dteFechaInicio.TabIndex = 25;
            // 
            // txtClaveAreaTema
            // 
            this.txtClaveAreaTema.Location = new System.Drawing.Point(171, 107);
            this.txtClaveAreaTema.Name = "txtClaveAreaTema";
            this.txtClaveAreaTema.Size = new System.Drawing.Size(480, 22);
            this.txtClaveAreaTema.TabIndex = 23;
            // 
            // txtClaveCurso
            // 
            this.txtClaveCurso.Location = new System.Drawing.Point(171, 28);
            this.txtClaveCurso.Name = "txtClaveCurso";
            this.txtClaveCurso.Size = new System.Drawing.Size(480, 22);
            this.txtClaveCurso.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Instructor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Competencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Clave objetivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha de Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Duracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Clave area tema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre del curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Clave del curso";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(171, 69);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(480, 22);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Clave modalidad";
            // 
            // cmbClaveModalidad
            // 
            this.cmbClaveModalidad.FormattingEnabled = true;
            this.cmbClaveModalidad.Items.AddRange(new object[] {
            "Presencial",
            "En linea",
            "Mixta"});
            this.cmbClaveModalidad.Location = new System.Drawing.Point(171, 311);
            this.cmbClaveModalidad.Name = "cmbClaveModalidad";
            this.cmbClaveModalidad.Size = new System.Drawing.Size(480, 24);
            this.cmbClaveModalidad.TabIndex = 28;
            // 
            // cmbClaveObjetivo
            // 
            this.cmbClaveObjetivo.FormattingEnabled = true;
            this.cmbClaveObjetivo.Items.AddRange(new object[] {
            "Actualizar y perfeccionar conocimientos y habilidades",
            "Proporcionar informacion de nuevas tecnologias",
            "Preparar para ocupar vacantes o puestos de nueva creacion",
            "Prevenir riesgos de trabajo",
            "Incremento a la productividad"});
            this.cmbClaveObjetivo.Location = new System.Drawing.Point(171, 266);
            this.cmbClaveObjetivo.Name = "cmbClaveObjetivo";
            this.cmbClaveObjetivo.Size = new System.Drawing.Size(480, 24);
            this.cmbClaveObjetivo.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(605, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Horas";
            // 
            // RegistrarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 535);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbClaveObjetivo);
            this.Controls.Add(this.cmbClaveModalidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dteFechaFin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDuracion);
            this.Controls.Add(this.cmbInstructor);
            this.Controls.Add(this.cmbCompetencia);
            this.Controls.Add(this.dteFechaInicio);
            this.Controls.Add(this.txtClaveAreaTema);
            this.Controls.Add(this.txtClaveCurso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCurso);
            this.Name = "RegistrarCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistrarCursos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarCursos_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarCursos_Load);
            this.Leave += new System.EventHandler(this.RegistrarCursos_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteFechaFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbDuracion;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.ComboBox cmbCompetencia;
        private System.Windows.Forms.DateTimePicker dteFechaInicio;
        private System.Windows.Forms.TextBox txtClaveAreaTema;
        private System.Windows.Forms.TextBox txtClaveCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbClaveModalidad;
        private System.Windows.Forms.ComboBox cmbClaveObjetivo;
        private System.Windows.Forms.Label label11;
    }
}