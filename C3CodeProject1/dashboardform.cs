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
    public partial class dashboardform : Form
    {
        //Panels
        cctvrequestforms cctvReqForms = new cctvrequestforms();
        
        public dashboardform()
        {
            InitializeComponent();
            tmr_dash.Start();
        }

        private void tmr_dash_Tick(object sender, EventArgs e)
        {
            lbl_timeanddate.Text = DateTime.Now.ToString("MMMM dd, yyyy HH:mm:ss ");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            cctvReqForms.Hide();
        }

        private void btn_cctvreqforms_Click(object sender, EventArgs e)
        {
            cctvReqForms.TopLevel = false;
            pnl_mainpanel.Controls.Add(cctvReqForms);
            cctvReqForms.BringToFront();
            cctvReqForms.Show();
        }

        private void btn_cctvreports_Click(object sender, EventArgs e)
        {

        }

        private void btn_sitrep_Click(object sender, EventArgs e)
        {

        }

        private void btn_endorsement_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
