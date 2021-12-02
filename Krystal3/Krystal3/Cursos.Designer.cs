
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnMatricula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Outfit", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(66)))), ((int)(((byte)(57)))));
            this.dgvCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCursos.RowHeadersWidth = 50;
            this.dgvCursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(900, 642);
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
            this.coluClave.Width = 76;
            // 
            // coluNombre
            // 
            this.coluNombre.HeaderText = "Nombre";
            this.coluNombre.MinimumWidth = 6;
            this.coluNombre.Name = "coluNombre";
            this.coluNombre.ReadOnly = true;
            this.coluNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coluNombre.Width = 94;
            // 
            // coluClaveArea
            // 
            this.coluClaveArea.HeaderText = "Clave area";
            this.coluClaveArea.MinimumWidth = 6;
            this.coluClaveArea.Name = "coluClaveArea";
            this.coluClaveArea.ReadOnly = true;
            this.coluClaveArea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluClaveArea.Width = 105;
            // 
            // coluDuracion
            // 
            this.coluDuracion.HeaderText = "Duracion";
            this.coluDuracion.MinimumWidth = 6;
            this.coluDuracion.Name = "coluDuracion";
            this.coluDuracion.ReadOnly = true;
            this.coluDuracion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluDuracion.Width = 101;
            // 
            // coluFechaIni
            // 
            this.coluFechaIni.HeaderText = "Fecha inicio";
            this.coluFechaIni.MinimumWidth = 6;
            this.coluFechaIni.Name = "coluFechaIni";
            this.coluFechaIni.ReadOnly = true;
            this.coluFechaIni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluFechaIni.Width = 109;
            // 
            // coluFechaFin
            // 
            this.coluFechaFin.HeaderText = "Fecha Fin";
            this.coluFechaFin.MinimumWidth = 6;
            this.coluFechaFin.Name = "coluFechaFin";
            this.coluFechaFin.ReadOnly = true;
            this.coluFechaFin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluFechaFin.Width = 95;
            // 
            // coluClaveObjetivo
            // 
            this.coluClaveObjetivo.HeaderText = "Clave objetivo";
            this.coluClaveObjetivo.MinimumWidth = 6;
            this.coluClaveObjetivo.Name = "coluClaveObjetivo";
            this.coluClaveObjetivo.ReadOnly = true;
            this.coluClaveObjetivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coluClaveObjetivo.Width = 127;
            // 
            // claveModalidad
            // 
            this.claveModalidad.HeaderText = "Clave modalidad";
            this.claveModalidad.MinimumWidth = 6;
            this.claveModalidad.Name = "claveModalidad";
            this.claveModalidad.ReadOnly = true;
            this.claveModalidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.claveModalidad.Width = 146;
            // 
            // coluCompetencia
            // 
            this.coluCompetencia.HeaderText = "Competencia";
            this.coluCompetencia.MinimumWidth = 6;
            this.coluCompetencia.Name = "coluCompetencia";
            this.coluCompetencia.ReadOnly = true;
            this.coluCompetencia.Width = 132;
            // 
            // coluInstructor
            // 
            this.coluInstructor.HeaderText = "Instructor";
            this.coluInstructor.MinimumWidth = 6;
            this.coluInstructor.Name = "coluInstructor";
            this.coluInstructor.ReadOnly = true;
            this.coluInstructor.Width = 106;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnEliminar.Location = new System.Drawing.Point(783, 664);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnModificar.Location = new System.Drawing.Point(647, 664);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 35);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnCrear.Location = new System.Drawing.Point(542, 664);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 35);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnMatricula.Location = new System.Drawing.Point(24, 664);
            this.btnMatricula.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(281, 35);
            this.btnMatricula.TabIndex = 12;
            this.btnMatricula.Text = "Registrar colaboradores";
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 710);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnMatricula;
    }
}