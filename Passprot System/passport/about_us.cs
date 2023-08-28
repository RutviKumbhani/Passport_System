using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passport
{
    public partial class about_us : Form
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rutvi rutu = new rutvi();
            rutu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit from About Us form", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ami ami = new ami();
            ami.Show();
        }

        private void about_us_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            lbldate.Text ="Date:"+ DateTime.Now.ToShortDateString();
           // lbltime.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text ="Time:"+ DateTime.Now.ToShortTimeString();
            timer1.Start();
        }
    }
}
