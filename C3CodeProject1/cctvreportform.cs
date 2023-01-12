using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C3CodeProject1
{
    public partial class cctvreportform : Form
    {
        public cctvreportform()
        {
            InitializeComponent();
            DisplayValue();
        }

        private void DisplayValue()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_c3blackops.c3_request_form", myConn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridReports.DataSource = dt;
            dataGridReports.Update();
            dataGridReports.Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_c3blackops.c3_request_form WHERE " + drop_searchfilter.Text + " LIKE '%" + txt_search.Text + "%'", myConn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridReports.DataSource = dt;
                dataGridReports.Update();
                dataGridReports.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease try again." + " If the problem persists, please contact your system administrator.");
            }
        }

        private void cctvreportform_Load(object sender, EventArgs e)
        {
            //reset all data and fields
            DisplayValue();
            txt_search.Text = "";
            drop_searchfilter.Text = "";
        }
    }
}
