using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3CodeProject1
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            pBar_splash.Increment(3);
            Random rnd = new Random();
            int random = rnd.Next(1, 4);
            if (random == 1)
            {
                lbl_splash.Text = "Loading...";
            }
            else if (random == 2)
            {
                lbl_splash.Text = "Loading";
            }
            else if (random == 3)
            {
                lbl_splash.Text = "Loading.";
            }
            else if (random == 4)
            {
                lbl_splash.Text = "Loading..";
            }
            if (pBar_splash.Value == 100)
            {
                tmr_splash.Stop();
                this.Hide();
                dashboardform dshBoard = new dashboardform();
                dshBoard.Show();
            }
        }
    }
}
