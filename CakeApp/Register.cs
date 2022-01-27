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
    


    public partial class Register : MaterialSkin.Controls.MaterialForm
    {
        public static string username;

        public Register()
        {
            InitializeComponent();
        }
        



        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            


            string firstname, lastname, email, password;
            firstname = textBox1.Text;
            lastname = textBox2.Text;
            username = textBox3.Text;
            email = textBox4.Text;
            password = textBox5.Text;
            string conn_method = "datasource=localhost; username = root;password=''; database=cakeapp";
            MySqlConnection conn = new MySqlConnection(conn_method);
            string check4Duplicate = "SELECT `username` FROM admin_users WHERE email = '" + username + "'";
            string register_query = "INSERT INTO admin_users VALUES('','" + firstname + "','" + lastname + "','" + username + "','" + email + "','" + password + "')";
            string create_cart_table = "CREATE TABLE `" + username +"`(`id` INT(225) UNSIGNED auto_increment Primary key , `product` VARCHAR(225) NOT NULL,  `price` VARCHAR(255) NOT NULL, `quantity` VARCHAR(255) NOT NULL)";
            MySqlCommand C4d = new MySqlCommand(check4Duplicate, conn);
            MySqlCommand cmd = new MySqlCommand(register_query, conn);
            MySqlCommand cct = new MySqlCommand(create_cart_table, conn);
            MySqlDataReader exe, C4d_exe, cct_exe;


            conn.Open();
            C4d_exe = C4d.ExecuteReader();
            C4d_exe.Read();
            try
            {
                if (!DBNull.Value.Equals(C4d_exe))
                {
                    C4d_exe.Close();
                    exe = cmd.ExecuteReader();
                    exe.Close();
                    cct_exe = cct.ExecuteReader();
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    MessageBox.Show("Registered");
                    this.Hide();
                    login signin = new login();
                    signin.Show();
                }
                else
                {
                    MessageBox.Show("Email already exists");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login Login = new login();
            Login.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox5.UseSystemPasswordChar = false;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
            }
        }
    }
}
