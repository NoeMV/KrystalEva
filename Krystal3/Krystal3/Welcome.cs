using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Krystal3
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            PlayVideo();
        }

        private void PlayVideo()
        {
            axWindowsMediaPlayer1.uiMode = "None";
            axWindowsMediaPlayer1.URL = "C:\\Apps\\KrystalEva\\Krystal3\\Krystal3\\V3.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            counter++;
            if (counter == 185)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Visible = false;
                
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start(); 
        }
    }
}
