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
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=shiki;password=;database=logininfo";
            MySqlConnection myConn = new MySqlConnection(myConnection);
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
                    MessageBox.Show("Username and Password is correct", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    splashscreen ss = new splashscreen();
                    ss.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password");
                }
                else
                {
                    MessageBox.Show("Username and password is not correct");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
