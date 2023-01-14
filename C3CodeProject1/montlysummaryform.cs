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
    public partial class montlysummaryform : Form
    {
        public montlysummaryform()
        {
            InitializeComponent();
            monthtext();
            todayentry();
            totalmonth();
            totalreleased();
            freqcamera();
            barangay();
            commonincident();

        }

        private void monthtext()
        {
            lbl_month.Text = DateTime.Now.ToString("MMMM") + ("'s Summary Report");
        }

        private void todayentry()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALTODAY FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM dd yyyy") + "%'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_today.Text = reader["TOTALTODAY"].ToString();
            }
            myConn.Close();
        }

        private void totalmonth()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALMONTH FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_month.Text = reader["TOTALMONTH"].ToString();
            }
            myConn.Close();
        }

        private void totalreleased()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS TOTALRELEASED FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' AND status = 'Released'", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_released.Text = reader["TOTALRELEASED"].ToString();
            }
            myConn.Close();
        }

        private void freqcamera()
        {   
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS COUNTCAM, camera AS FREQCAMERA FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' GROUP BY camera ORDER BY COUNT(camera) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_freq.Text = reader["COUNTCAM"].ToString() + "\n" + reader["FREQCAMERA"].ToString();
                
            }
            myConn.Close();
        }

        private void barangay()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS COUNTBRGY, barangay AS FREQBRGY FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' GROUP BY barangay ORDER BY COUNT(barangay) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_barangay.Text = reader["FREQBRGY"].ToString() + "\n " + reader["COUNTBRGY"].ToString();

            }
            myConn.Close();
        }

        private void commonincident()
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(caseno) AS COUNTINC, typeofincident AS FREQINC FROM db_c3blackops.c3_request_form WHERE recordeddate LIKE '%" + DateTime.Now.ToString("MMMM") + "%' GROUP BY typeofincident ORDER BY COUNT(typeofincident) ASC", myConn);
            myConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_common.Text = reader["FREQINC"].ToString() + "\n " + reader["COUNTINC"].ToString();

            }
            myConn.Close();
        }

        private void montlysummaryform_Load(object sender, EventArgs e)
        {
            monthtext();
            todayentry();
            totalmonth();
            totalreleased();
            freqcamera();
            barangay();
            commonincident();
        }
    }
}
