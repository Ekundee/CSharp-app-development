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

namespace _19cg026424_CakeApp
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        public static string username;
        public login()
        {
            InitializeComponent();
        }

       

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            string  password;
            username = textBox1.Text;
            password = textBox2.Text;
            string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
            MySqlConnection conn = new MySqlConnection(conn_method);
            string check4username = "SELECT username,password FROM admin_users WHERE username = '" + username + "'";
            MySqlCommand C4u = new MySqlCommand(check4username, conn);
            MySqlDataReader C4u_exe;
            try
            {
                conn.Open();
                C4u_exe = C4u.ExecuteReader();
                C4u_exe.Read();
                if (C4u_exe.GetString(1) == password)
                {
                    this.Hide();
                    home Home = new home();
                    Home.Show();
                    MessageBox.Show("Logged in");
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() == "MySql.Data.MySqlClient.MySqlException")
                {
                    MessageBox.Show("Please register account");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Other exceptions");
                }
                
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
