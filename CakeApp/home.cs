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
    public partial class home : MaterialSkin.Controls.MaterialForm
    {

        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

       
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {
                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Chocolate Cupcake";
                string price = "2000";
                string quantity = textBox1.Text;
                if (textBox1.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox1.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }



                conn.Close();


            }


        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {

                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Vanilla Cake";
                string price = "12000";
                string quantity = textBox2.Text;
                if (textBox2.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox2.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }


                conn.Close();
            }

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {

                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Strawberry Cake";
                string price = "13500";
                string quantity = textBox3.Text;
                if (textBox3.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox3.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }

                conn.Close();
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {

                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Chocolate Cake";
                string price = "10500";
                string quantity = textBox4.Text;
                if (textBox4.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox4.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }


                conn.Close();
            }

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {

                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Banana Cake";
                string price = "15000";
                string quantity = textBox5.Text;
                if (textBox5.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox5.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }

                conn.Close();
            }
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {

                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Candy Cake";
                string price = "13500";
                string quantity = textBox10.Text;
                if (textBox10.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox10.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }


                conn.Close();
            }
        }

       
        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {
                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Frosting Cake";
                string price = "20000";
                string quantity = textBox7.Text;
                if (textBox7.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox7.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }



                conn.Close();
            }
            
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {
                string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
                MySqlConnection conn = new MySqlConnection(conn_method);
                string get_email = "SELECT `email` FROM `admin_users` WHERE username = '" + login.username + "'";
                MySqlCommand cmd_get_email = new MySqlCommand(get_email, conn);
                MySqlDataReader get_email_exe;

                conn.Open();
                get_email_exe = cmd_get_email.ExecuteReader();
                get_email_exe.Read();

                string email = get_email_exe.GetString(0);
                get_email_exe.Close();

                string product_name = "Red velvet Cake";
                string price = "25000";
                string quantity = textBox8.Text;
                if (textBox8.Text != "")
                {
                    string insert_into_cart = "INSERT INTO `" + login.username + "` VALUES('','" + product_name + "','" + price + "' ,'" + quantity + "')";
                    MySqlCommand cmd_insert = new MySqlCommand(insert_into_cart, conn);
                    MySqlDataReader cart_insert_exe;

                    try
                    {
                        cart_insert_exe = cmd_insert.ExecuteReader();
                        MessageBox.Show("Added to cart");
                        textBox8.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Enter a quantity!");
                }



                conn.Close();
            }
            
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            if (login.username == null)
            {
                this.Hide();
                login signin = new login();
                signin.Show();
            }
            else
            {
                this.Hide();
                cart Cart = new cart();
                Cart.Show();
            }
                
        }

        private void materialDivider9_Click(object sender, EventArgs e)
        {

        }
    }
}
