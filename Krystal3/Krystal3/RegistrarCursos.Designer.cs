
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
            this.dteFechaFin.Font = new System.Drawing.Font("Outfit", 15F);
            this.dteFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFechaFin.Location = new System.Drawing.Point(236, 214);
            this.dteFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dteFechaFin.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dteFechaFin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dteFechaFin.Name = "dteFechaFin";
            this.dteFechaFin.Size = new System.Drawing.Size(407, 33);
            this.dteFechaFin.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(540, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 36);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnGuardar.Location = new System.Drawing.Point(19, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 36);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbDuracion
            // 
            this.cmbDuracion.Font = new System.Drawing.Font("Outfit", 15F);
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
            this.cmbDuracion.Location = new System.Drawing.Point(236, 135);
            this.cmbDuracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDuracion.Name = "cmbDuracion";
            this.cmbDuracion.Size = new System.Drawing.Size(322, 33);
            this.cmbDuracion.TabIndex = 24;
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.Font = new System.Drawing.Font("Outfit", 15F);
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(236, 375);
            this.cmbInstructor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(407, 33);
            this.cmbInstructor.TabIndex = 30;
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.Font = new System.Drawing.Font("Outfit", 15F);
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(236, 335);
            this.cmbCompetencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(407, 33);
            this.cmbCompetencia.TabIndex = 29;
            // 
            // dteFechaInicio
            // 
            this.dteFechaInicio.Font = new System.Drawing.Font("Outfit", 15F);
            this.dteFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFechaInicio.Location = new System.Drawing.Point(236, 174);
            this.dteFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dteFechaInicio.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dteFechaInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dteFechaInicio.Name = "dteFechaInicio";
            this.dteFechaInicio.Size = new System.Drawing.Size(407, 33);
            this.dteFechaInicio.TabIndex = 25;
            // 
            // txtClaveAreaTema
            // 
            this.txtClaveAreaTema.Font = new System.Drawing.Font("Outfit", 15F);
            this.txtClaveAreaTema.Location = new System.Drawing.Point(236, 95);
            this.txtClaveAreaTema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClaveAreaTema.Name = "txtClaveAreaTema";
            this.txtClaveAreaTema.Size = new System.Drawing.Size(407, 33);
            this.txtClaveAreaTema.TabIndex = 23;
            // 
            // txtClaveCurso
            // 
            this.txtClaveCurso.Font = new System.Drawing.Font("Outfit", 15F);
            this.txtClaveCurso.Location = new System.Drawing.Point(236, 15);
            this.txtClaveCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClaveCurso.Name = "txtClaveCurso";
            this.txtClaveCurso.Size = new System.Drawing.Size(407, 33);
            this.txtClaveCurso.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "Instructor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "Competencia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Clave objetivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha de fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "Duración:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Clave área tema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre del curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Clave del curso:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Font = new System.Drawing.Font("Outfit", 15F);
            this.txtNombreCurso.Location = new System.Drawing.Point(236, 55);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(407, 33);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(14, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 30);
            this.label10.TabIndex = 41;
            this.label10.Text = "Clave modalidad:";
            // 
            // cmbClaveModalidad
            // 
            this.cmbClaveModalidad.Font = new System.Drawing.Font("Outfit", 15F);
            this.cmbClaveModalidad.FormattingEnabled = true;
            this.cmbClaveModalidad.Items.AddRange(new object[] {
            "Presencial",
            "En linea",
            "Mixta"});
            this.cmbClaveModalidad.Location = new System.Drawing.Point(236, 295);
            this.cmbClaveModalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClaveModalidad.Name = "cmbClaveModalidad";
            this.cmbClaveModalidad.Size = new System.Drawing.Size(407, 33);
            this.cmbClaveModalidad.TabIndex = 28;
            // 
            // cmbClaveObjetivo
            // 
            this.cmbClaveObjetivo.Font = new System.Drawing.Font("Outfit", 15F);
            this.cmbClaveObjetivo.FormattingEnabled = true;
            this.cmbClaveObjetivo.Items.AddRange(new object[] {
            "Actualizar y perfeccionar conocimientos y habilidades",
            "Proporcionar informacion de nuevas tecnologias",
            "Preparar para ocupar vacantes o puestos de nueva creacion",
            "Prevenir riesgos de trabajo",
            "Incremento a la productividad"});
            this.cmbClaveObjetivo.Location = new System.Drawing.Point(236, 255);
            this.cmbClaveObjetivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClaveObjetivo.Name = "cmbClaveObjetivo";
            this.cmbClaveObjetivo.Size = new System.Drawing.Size(407, 33);
            this.cmbClaveObjetivo.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(562, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 30);
            this.label11.TabIndex = 42;
            this.label11.Text = "Horas";
            // 
            // RegistrarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 463);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarCursos";
            this.ShowInTaskbar = false;
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