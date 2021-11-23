
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
            this.claveModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.claveModalidad,
            this.coluCompetencia,
            this.coluInstructor});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(884, 521);
            this.dgvCursos.TabIndex = 11;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            this.dgvCursos.Enter += new System.EventHandler(this.dgvCursos_Enter);
            // 
            // coluID
            // 
            this.coluID.HeaderText = "ID";
            this.coluID.MinimumWidth = 6;
            this.coluID.Name = "coluID";
            this.coluID.ReadOnly = true;
            this.coluID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluID.Visible = false;
            this.coluID.Width = 125;
            // 
            // coluClave
            // 
            this.coluClave.HeaderText = "Clave";
            this.coluClave.MinimumWidth = 6;
            this.coluClave.Name = "coluClave";
            this.coluClave.ReadOnly = true;
            this.coluClave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluClave.Width = 59;
            // 
            // coluNombre
            // 
            this.coluNombre.HeaderText = "Nombre";
            this.coluNombre.MinimumWidth = 6;
            this.coluNombre.Name = "coluNombre";
            this.coluNombre.ReadOnly = true;
            this.coluNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coluNombre.Width = 69;
            // 
            // coluClaveArea
            // 
            this.coluClaveArea.HeaderText = "Clave area";
            this.coluClaveArea.MinimumWidth = 6;
            this.coluClaveArea.Name = "coluClaveArea";
            this.coluClaveArea.ReadOnly = true;
            this.coluClaveArea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluClaveArea.Width = 83;
            // 
            // coluDuracion
            // 
            this.coluDuracion.HeaderText = "Duracion";
            this.coluDuracion.MinimumWidth = 6;
            this.coluDuracion.Name = "coluDuracion";
            this.coluDuracion.ReadOnly = true;
            this.coluDuracion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluDuracion.Width = 75;
            // 
            // coluFechaIni
            // 
            this.coluFechaIni.HeaderText = "Fecha inicio";
            this.coluFechaIni.MinimumWidth = 6;
            this.coluFechaIni.Name = "coluFechaIni";
            this.coluFechaIni.ReadOnly = true;
            this.coluFechaIni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluFechaIni.Width = 89;
            // 
            // coluFechaFin
            // 
            this.coluFechaFin.HeaderText = "Fecha Fin";
            this.coluFechaFin.MinimumWidth = 6;
            this.coluFechaFin.Name = "coluFechaFin";
            this.coluFechaFin.ReadOnly = true;
            this.coluFechaFin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluFechaFin.Width = 79;
            // 
            // coluClaveObjetivo
            // 
            this.coluClaveObjetivo.HeaderText = "Clave objetivo";
            this.coluClaveObjetivo.MinimumWidth = 6;
            this.coluClaveObjetivo.Name = "coluClaveObjetivo";
            this.coluClaveObjetivo.ReadOnly = true;
            this.coluClaveObjetivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluClaveObjetivo.Width = 99;
            // 
            // claveModalidad
            // 
            this.claveModalidad.HeaderText = "Clave modalidad";
            this.claveModalidad.MinimumWidth = 6;
            this.claveModalidad.Name = "claveModalidad";
            this.claveModalidad.ReadOnly = true;
            this.claveModalidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.claveModalidad.Width = 110;
            // 
            // coluCompetencia
            // 
            this.coluCompetencia.HeaderText = "Competencia";
            this.coluCompetencia.MinimumWidth = 6;
            this.coluCompetencia.Name = "coluCompetencia";
            this.coluCompetencia.ReadOnly = true;
            this.coluCompetencia.Width = 94;
            // 
            // coluInstructor
            // 
            this.coluInstructor.HeaderText = "Instructor";
            this.coluInstructor.MinimumWidth = 6;
            this.coluInstructor.Name = "coluInstructor";
            this.coluInstructor.ReadOnly = true;
            this.coluInstructor.Width = 76;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(131, 581);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(71, 581);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(56, 19);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(11, 581);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(56, 19);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cursos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cursos_FormClosed);
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluClaveArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluFechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluClaveObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluInstructor;
    }
}