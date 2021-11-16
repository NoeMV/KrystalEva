namespace Krystal3
{
    partial class Colaboradores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colaborador_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveNivelEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDocProbatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveInstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colaborador_id,
            this.curp,
            this.nombre,
            this.primerApellido,
            this.segundoApellido,
            this.claveEstado,
            this.municipio_id,
            this.ocupacion_id,
            this.claveNivelEstudios,
            this.claveDocProbatorio,
            this.claveInstitucion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // colaborador_id
            // 
            this.colaborador_id.HeaderText = "#";
            this.colaborador_id.Name = "colaborador_id";
            this.colaborador_id.ReadOnly = true;
            // 
            // curp
            // 
            this.curp.HeaderText = "CURP";
            this.curp.Name = "curp";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // primerApellido
            // 
            this.primerApellido.HeaderText = "PRIMER APELLIDO";
            this.primerApellido.Name = "primerApellido";
            // 
            // segundoApellido
            // 
            this.segundoApellido.HeaderText = "SEGUNDO APELLIDO";
            this.segundoApellido.Name = "segundoApellido";
            // 
            // claveEstado
            // 
            this.claveEstado.HeaderText = "CLAVE ESTADO";
            this.claveEstado.Name = "claveEstado";
            // 
            // municipio_id
            // 
            this.municipio_id.HeaderText = "CLAVE MUNICIPIO";
            this.municipio_id.Name = "municipio_id";
            // 
            // ocupacion_id
            // 
            this.ocupacion_id.HeaderText = "CLAVE OCUPACIÓN";
            this.ocupacion_id.Name = "ocupacion_id";
            // 
            // claveNivelEstudios
            // 
            this.claveNivelEstudios.HeaderText = "CLAVE NIV ESTUDIOS";
            this.claveNivelEstudios.Name = "claveNivelEstudios";
            // 
            // claveDocProbatorio
            // 
            this.claveDocProbatorio.HeaderText = "CLAVE DOC PROBATORIO";
            this.claveDocProbatorio.Name = "claveDocProbatorio";
            // 
            // claveInstitucion
            // 
            this.claveInstitucion.HeaderText = "CLAVE INSTITUCION";
            this.claveInstitucion.Name = "claveInstitucion";
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 382);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaborador_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveNivelEstudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDocProbatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveInstitucion;
    }
}