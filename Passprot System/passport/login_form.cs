using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;

namespace passport
{
    public partial class login_form : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            lbldate.Text = "Date:" + DateTime.Now.ToShortDateString();



            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");
         
           // con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\dblogin.mdb");
           con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Select * from dblogin where uname='" + txtunm.Text + "'AND upass='" + txtpwd.Text + "'",con);
            dr = cmd.ExecuteReader();

            int c = 0;
            while (dr.Read())
                c++;

            if (c == 1)
            {
                c = 0;
                if (MessageBox.Show("Login Is Successfully", "login", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mdi_form m = new mdi_form();
                    m.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username & Password");
                txtunm.Text = "";
                txtpwd.Text = "";
            }
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure..! Exit this login form...?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }
    }
}

