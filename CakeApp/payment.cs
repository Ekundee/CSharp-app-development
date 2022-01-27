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
    public partial class payment : MaterialSkin.Controls.MaterialForm
    {
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            label7.Text = cart.sum.ToString();
            textBox5.Text = cart.sum.ToString();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string card_number = textBox1.Text;
            string cvv = textBox3.Text;
            string pin = textBox4.Text;
            string amount_to_pay = textBox5.Text;
            string date = dateTimePicker1.Value.Date.ToString("yyyyMMdd");
            string card_type = comboBox1.Text;

            string conn_method = "datasource=localhost; port=3306; username = root;password=''; database=cakeapp";
            MySqlConnection conn = new MySqlConnection(conn_method);

            string payment_insert = "INSERT INTO `payment` VALUES('' , '" + card_number + "', '" + cvv + "','" + pin + "' , '" + amount_to_pay + "','" + date + "','" + card_type + "')";
            MySqlCommand pay_cmd = new MySqlCommand(payment_insert, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = pay_cmd.ExecuteReader();

                this.Hide();
                paymentDone done = new paymentDone();
                done.Show();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
