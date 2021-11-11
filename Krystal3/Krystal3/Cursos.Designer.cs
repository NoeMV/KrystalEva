
namespace Krystal3
{
    partial class Cursos
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.coluID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluClaveArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluFechaIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluClaveObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluID,
            this.coluClave,
            this.coluNombre,
            this.coluClaveArea,
            this.coluDuracion,
            this.coluFechaIni,
            this.coluFechaFin,
            this.coluClaveObjetivo,
            this.coluCompetencia,
            this.coluInstructor});
            this.dgvCursos.Location = new System.Drawing.Point(12, 12);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.Size = new System.Drawing.Size(1096, 507);
            this.dgvCursos.TabIndex = 11;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // coluID
            // 
            this.coluID.HeaderText = "ID";
            this.coluID.MinimumWidth = 6;
            this.coluID.Name = "coluID";
            this.coluID.ReadOnly = true;
            this.coluID.Visible = false;
            this.coluID.Width = 125;
            // 
            // coluClave
            // 
            this.coluClave.HeaderText = "Clave";
            this.coluClave.MinimumWidth = 6;
            this.coluClave.Name = "coluClave";
            this.coluClave.ReadOnly = true;
            this.coluClave.Width = 125;
            // 
            // coluNombre
            // 
            this.coluNombre.HeaderText = "Nombre";
            this.coluNombre.MinimumWidth = 6;
            this.coluNombre.Name = "coluNombre";
            this.coluNombre.ReadOnly = true;
            this.coluNombre.Width = 125;
            // 
            // coluClaveArea
            // 
            this.coluClaveArea.HeaderText = "Clave area";
            this.coluClaveArea.MinimumWidth = 6;
            this.coluClaveArea.Name = "coluClaveArea";
            this.coluClaveArea.ReadOnly = true;
            this.coluClaveArea.Width = 125;
            // 
            // coluDuracion
            // 
            this.coluDuracion.HeaderText = "Duracion";
            this.coluDuracion.MinimumWidth = 6;
            this.coluDuracion.Name = "coluDuracion";
            this.coluDuracion.ReadOnly = true;
            this.coluDuracion.Width = 125;
            // 
            // coluFechaIni
            // 
            this.coluFechaIni.HeaderText = "Fecha inicio";
            this.coluFechaIni.MinimumWidth = 6;
            this.coluFechaIni.Name = "coluFechaIni";
            this.coluFechaIni.ReadOnly = true;
            this.coluFechaIni.Width = 125;
            // 
            // coluFechaFin
            // 
            this.coluFechaFin.HeaderText = "Fecha Fin";
            this.coluFechaFin.MinimumWidth = 6;
            this.coluFechaFin.Name = "coluFechaFin";
            this.coluFechaFin.ReadOnly = true;
            this.coluFechaFin.Width = 125;
            // 
            // coluClaveObjetivo
            // 
            this.coluClaveObjetivo.HeaderText = "Clave objetivo";
            this.coluClaveObjetivo.MinimumWidth = 6;
            this.coluClaveObjetivo.Name = "coluClaveObjetivo";
            this.coluClaveObjetivo.ReadOnly = true;
            this.coluClaveObjetivo.Width = 125;
            // 
            // coluCompetencia
            // 
            this.coluCompetencia.HeaderText = "Competencia";
            this.coluCompetencia.MinimumWidth = 6;
            this.coluCompetencia.Name = "coluCompetencia";
            this.coluCompetencia.ReadOnly = true;
            this.coluCompetencia.Width = 125;
            // 
            // coluInstructor
            // 
            this.coluInstructor.HeaderText = "Instructor";
            this.coluInstructor.MinimumWidth = 6;
            this.coluInstructor.Name = "coluInstructor";
            this.coluInstructor.ReadOnly = true;
            this.coluInstructor.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1127, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1127, 119);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1127, 44);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 531);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluClaveArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluFechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluClaveObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluInstructor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
    }
}