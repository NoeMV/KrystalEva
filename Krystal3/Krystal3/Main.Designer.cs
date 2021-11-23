
namespace Krystal3
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnInstructores = new System.Windows.Forms.Button();
            this.BtnColaboradores = new System.Windows.Forms.Button();
            this.BtnCursos = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuLateral.SuspendLayout();
            this.PanelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.Controls.Add(this.BtnSalir);
            this.MenuLateral.Controls.Add(this.BtnEstadisticas);
            this.MenuLateral.Controls.Add(this.BtnReportes);
            this.MenuLateral.Controls.Add(this.BtnInstructores);
            this.MenuLateral.Controls.Add(this.BtnColaboradores);
            this.MenuLateral.Controls.Add(this.BtnCursos);
            this.MenuLateral.Controls.Add(this.PanelLogo);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(200, 650);
            this.MenuLateral.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::Krystal3.Properties.Resources.BtnCerrar;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(0, 605);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(200, 45);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadisticas.Image = global::Krystal3.Properties.Resources.BtnEstadistica;
            this.BtnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 325);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEstadisticas.Size = new System.Drawing.Size(200, 45);
            this.BtnEstadisticas.TabIndex = 4;
            this.BtnEstadisticas.Text = "Estadísticas";
            this.BtnEstadisticas.UseVisualStyleBackColor = true;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Image = global::Krystal3.Properties.Resources.BtnReporte;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 280);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReportes.Size = new System.Drawing.Size(200, 45);
            this.BtnReportes.TabIndex = 3;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnInstructores
            // 
            this.BtnInstructores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInstructores.FlatAppearance.BorderSize = 0;
            this.BtnInstructores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstructores.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstructores.Image = global::Krystal3.Properties.Resources.BtnInstructor;
            this.BtnInstructores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInstructores.Location = new System.Drawing.Point(0, 235);
            this.BtnInstructores.Name = "BtnInstructores";
            this.BtnInstructores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInstructores.Size = new System.Drawing.Size(200, 45);
            this.BtnInstructores.TabIndex = 2;
            this.BtnInstructores.Text = "Instructores";
            this.BtnInstructores.UseVisualStyleBackColor = true;
            this.BtnInstructores.Click += new System.EventHandler(this.BtnInstructores_Click);
            // 
            // BtnColaboradores
            // 
            this.BtnColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnColaboradores.FlatAppearance.BorderSize = 0;
            this.BtnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColaboradores.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColaboradores.Image = global::Krystal3.Properties.Resources.BtnColaboradores;
            this.BtnColaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnColaboradores.Location = new System.Drawing.Point(0, 190);
            this.BtnColaboradores.Name = "BtnColaboradores";
            this.BtnColaboradores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnColaboradores.Size = new System.Drawing.Size(200, 45);
            this.BtnColaboradores.TabIndex = 1;
            this.BtnColaboradores.Text = "Trabajadores";
            this.BtnColaboradores.UseVisualStyleBackColor = true;
            this.BtnColaboradores.Click += new System.EventHandler(this.BtnColaboradores_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCursos.Image = global::Krystal3.Properties.Resources.BtnCurso;
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(0, 145);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCursos.Size = new System.Drawing.Size(200, 45);
            this.BtnCursos.TabIndex = 0;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.UseVisualStyleBackColor = true;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImage = global::Krystal3.Properties.Resources.Krystal_Logo;
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 145);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.Controls.Add(this.pictureBox1);
            this.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDashboard.Location = new System.Drawing.Point(200, 0);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(900, 650);
            this.PanelDashboard.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Krystal3.Properties.Resources.Krystal_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(282, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuLateral.ResumeLayout(false);
            this.PanelDashboard.ResumeLayout(false);
            this.PanelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Button BtnCursos;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnInstructores;
        private System.Windows.Forms.Button BtnColaboradores;
        private System.Windows.Forms.Button BtnEstadisticas;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSalir;
    }
}

