using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace KnowKombat
{
    public partial class SplashScreen : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public SplashScreen()
        {
            InitializeComponent();
            player.URL = "msc_Flawess.mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 401)
            {
                timer1.Stop();
                player.controls.play();
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
