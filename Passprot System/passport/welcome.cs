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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        private void welcome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
            login_form lf = new login_form();
              // mdi lf = new mdi();
                
                lf.Show();
                this.Hide();
                timer1.Enabled = false;

            }
            else
            {
                progressBar1.Value += 10;
                lblpv.Text = "" + progressBar1.Value + "%";
            }
            lbldate.Text = "Date :" + DateTime.Now.ToShortDateString();
            lbltime.Text = "Time :" + DateTime.Now.ToShortTimeString();
        }

       
    }
}
