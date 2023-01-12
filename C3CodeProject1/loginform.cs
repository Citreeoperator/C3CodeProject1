using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace C3CodeProject1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            copyrightchanger();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(connectionclass.myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from logininformation where infousername='" + this.txt_username.Text + "' and infopassword='" + this.txt_password.Text + "';", myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    splashscreen ss = new splashscreen();
                    ss.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "";
                    txt_password.Text = "";
                    this.txt_username.Focus();
                }
                else
                {
                    MessageBox.Show("Username and Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "";
                    txt_password.Text = "";
                    this.txt_username.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyrightchanger()
        {
            lbl_copyright.Text = "© " + DateTime.Now.Year.ToString() + "- All Rights Reserved.";
        }
    }
}
