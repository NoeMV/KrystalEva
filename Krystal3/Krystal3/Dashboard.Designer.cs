
namespace Krystal3
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PanelBarra = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnInstructores = new System.Windows.Forms.Button();
            this.BtnColaboradores = new System.Windows.Forms.Button();
            this.BtnCursos = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarra
            // 
            this.PanelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(75)))));
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarra.Location = new System.Drawing.Point(0, 0);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.Size = new System.Drawing.Size(1100, 40);
            this.PanelBarra.TabIndex = 0;
            this.PanelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseDown);
            this.PanelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseMove);
            this.PanelBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Controls.Add(this.BtnEstadisticas);
            this.panel2.Controls.Add(this.BtnReportes);
            this.panel2.Controls.Add(this.BtnInstructores);
            this.panel2.Controls.Add(this.BtnColaboradores);
            this.panel2.Controls.Add(this.BtnCursos);
            this.panel2.Controls.Add(this.PanelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 710);
            this.panel2.TabIndex = 1;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(175)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.Image = global::Krystal3.Properties.Resources.BtnCerrar;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(0, 665);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(200, 45);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(175)))));
            this.BtnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.BtnEstadisticas.Image = global::Krystal3.Properties.Resources.BtnEstadistica;
            this.BtnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 325);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEstadisticas.Size = new System.Drawing.Size(200, 45);
            this.BtnEstadisticas.TabIndex = 9;
            this.BtnEstadisticas.Text = "Estadísticas";
            this.BtnEstadisticas.UseVisualStyleBackColor = true;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(175)))));
            this.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.BtnReportes.Image = global::Krystal3.Properties.Resources.BtnReporte;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 280);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReportes.Size = new System.Drawing.Size(200, 45);
            this.BtnReportes.TabIndex = 8;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnInstructores
            // 
            this.BtnInstructores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInstructores.FlatAppearance.BorderSize = 0;
            this.BtnInstructores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(175)))));
            this.BtnInstructores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.BtnInstructores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstructores.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.BtnInstructores.Image = global::Krystal3.Properties.Resources.BtnInstructor;
            this.BtnInstructores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInstructores.Location = new System.Drawing.Point(0, 235);
            this.BtnInstructores.Name = "BtnInstructores";
            this.BtnInstructores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInstructores.Size = new System.Drawing.Size(200, 45);
            this.BtnInstructores.TabIndex = 7;
            this.BtnInstructores.Text = "Instructores";
            this.BtnInstructores.UseVisualStyleBackColor = true;
            this.BtnInstructores.Click += new System.EventHandler(this.BtnInstructores_Click);
            // 
            // BtnColaboradores
            // 
            this.BtnColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnColaboradores.FlatAppearance.BorderSize = 0;
            this.BtnColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(175)))));
            this.BtnColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.BtnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColaboradores.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.BtnColaboradores.Image = global::Krystal3.Properties.Resources.BtnColaboradores;
            this.BtnColaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnColaboradores.Location = new System.Drawing.Point(0, 190);
            this.BtnColaboradores.Name = "BtnColaboradores";
            this.BtnColaboradores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnColaboradores.Size = new System.Drawing.Size(200, 45);
            this.BtnColaboradores.TabIndex = 6;
            this.BtnColaboradores.Text = "Trabajadores";
            this.BtnColaboradores.UseVisualStyleBackColor = true;
            this.BtnColaboradores.Click += new System.EventHandler(this.BtnColaboradores_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(175)))));
            this.BtnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCursos.Image = global::Krystal3.Properties.Resources.BtnCurso;
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(0, 145);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCursos.Size = new System.Drawing.Size(200, 45);
            this.BtnCursos.TabIndex = 5;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.UseVisualStyleBackColor = true;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Controls.Add(this.pictureBox2);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 145);
            this.PanelLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Krystal3.Properties.Resources.Krystal_Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 145);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PanelDashboard.Controls.Add(this.LabelTitulo);
            this.PanelDashboard.Controls.Add(this.pictureBox1);
            this.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDashboard.Location = new System.Drawing.Point(200, 40);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(900, 710);
            this.PanelDashboard.TabIndex = 4;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitulo.Font = new System.Drawing.Font("Outfit", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.Black;
            this.LabelTitulo.Location = new System.Drawing.Point(0, 503);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(900, 60);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "Sistema de gestión de capacitación";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelDashboard.ResumeLayout(false);
            this.PanelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEstadisticas;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnInstructores;
        private System.Windows.Forms.Button BtnColaboradores;
        private System.Windows.Forms.Button BtnCursos;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}