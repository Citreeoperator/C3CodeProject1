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
