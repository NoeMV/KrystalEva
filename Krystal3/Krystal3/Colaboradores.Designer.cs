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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.claveInstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDocProbatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveNivelEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaborador_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(145, 624);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(250, 624);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Elimimar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(227)))));
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(143)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Outfit", 15F);
            this.btnInsertar.ForeColor = System.Drawing.Color.Black;
            this.btnInsertar.Location = new System.Drawing.Point(24, 624);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(15, 18, 15, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(91, 35);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // claveInstitucion
            // 
            this.claveInstitucion.HeaderText = "CLAVE INSTITUCION";
            this.claveInstitucion.MinimumWidth = 6;
            this.claveInstitucion.Name = "claveInstitucion";
            this.claveInstitucion.ReadOnly = true;
            this.claveInstitucion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.claveInstitucion.Width = 175;
            // 
            // claveDocProbatorio
            // 
            this.claveDocProbatorio.HeaderText = "CLAVE DOC PROBATORIO";
            this.claveDocProbatorio.MinimumWidth = 6;
            this.claveDocProbatorio.Name = "claveDocProbatorio";
            this.claveDocProbatorio.ReadOnly = true;
            this.claveDocProbatorio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.claveDocProbatorio.Width = 212;
            // 
            // claveNivelEstudios
            // 
            this.claveNivelEstudios.HeaderText = "CLAVE NIV ESTUDIOS";
            this.claveNivelEstudios.MinimumWidth = 6;
            this.claveNivelEstudios.Name = "claveNivelEstudios";
            this.claveNivelEstudios.ReadOnly = true;
            this.claveNivelEstudios.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.claveNivelEstudios.Width = 181;
            // 
            // ocupacion_id
            // 
            this.ocupacion_id.HeaderText = "CLAVE OCUPACIÓN";
            this.ocupacion_id.MinimumWidth = 6;
            this.ocupacion_id.Name = "ocupacion_id";
            this.ocupacion_id.ReadOnly = true;
            this.ocupacion_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ocupacion_id.Width = 170;
            // 
            // municipio_id
            // 
            this.municipio_id.HeaderText = "CLAVE MUNICIPIO";
            this.municipio_id.MinimumWidth = 6;
            this.municipio_id.Name = "municipio_id";
            this.municipio_id.ReadOnly = true;
            this.municipio_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.municipio_id.Width = 159;
            // 
            // claveEstado
            // 
            this.claveEstado.HeaderText = "CLAVE ESTADO";
            this.claveEstado.MinimumWidth = 6;
            this.claveEstado.Name = "claveEstado";
            this.claveEstado.ReadOnly = true;
            this.claveEstado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.claveEstado.Width = 141;
            // 
            // segundoApellido
            // 
            this.segundoApellido.HeaderText = "SEGUNDO APELLIDO";
            this.segundoApellido.MinimumWidth = 6;
            this.segundoApellido.Name = "segundoApellido";
            this.segundoApellido.ReadOnly = true;
            this.segundoApellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.segundoApellido.Width = 178;
            // 
            // primerApellido
            // 
            this.primerApellido.HeaderText = "PRIMER APELLIDO";
            this.primerApellido.MinimumWidth = 6;
            this.primerApellido.Name = "primerApellido";
            this.primerApellido.ReadOnly = true;
            this.primerApellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.primerApellido.Width = 159;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 102;
            // 
            // curp
            // 
            this.curp.HeaderText = "CURP";
            this.curp.MinimumWidth = 6;
            this.curp.Name = "curp";
            this.curp.ReadOnly = true;
            this.curp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.curp.Width = 75;
            // 
            // colaborador_id
            // 
            this.colaborador_id.HeaderText = "#";
            this.colaborador_id.MinimumWidth = 6;
            this.colaborador_id.Name = "colaborador_id";
            this.colaborador_id.ReadOnly = true;
            this.colaborador_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colaborador_id.Width = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Outfit", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(66)))), ((int)(((byte)(57)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 595);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Colaboradores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 671);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Colaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colaboradores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveInstitucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDocProbatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveNivelEstudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaborador_id;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}