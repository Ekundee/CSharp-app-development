using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19cg026424_CakeApp
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home gallery = new home();
            gallery.Show();
        }

    }
}
