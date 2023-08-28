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

namespace passport
{
    public partial class cpassword : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);


        public cpassword()
        {
            InitializeComponent();
        }

        private void cpassword_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");
            con.Open();
            groupBox1.Visible = false;


            timer1.Enabled = true;
            timer1.Start();
            lbldate.Text = "Date:" + DateTime.Now.ToShortDateString();
        }

        public void clear()
        {
          
            txtcurrentpwd.Text = "";
            txtnewpwd.Text = "";
            txtconfirmpwd.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void btn_con_Click(object sender, EventArgs e)
        {
            if (txtcurrentpwd.Text == "")
            {
                MessageBox.Show("Please enter the current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcurrentpwd.Focus();
            }
            else
            {
                da = new OleDbDataAdapter("select * from dblogin where upass='" + txtcurrentpwd.Text + "'", con);
                ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                    groupBox1.Visible = true;
                else
                {
                    MessageBox.Show("plese enter corect current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcurrentpwd.Text = "";
                    txtcurrentpwd.Focus();

                   // groupBox1.Visible = true;
                }

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (txtnewpwd.Text == "")
            {
                MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                txtnewpwd.Focus();
            }
            else if (txtconfirmpwd.Text == "")
            {
                MessageBox.Show("Please enter confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnewpwd.Focus();
            }
            else
            {
               if (txtnewpwd.Text.Equals(txtconfirmpwd.Text))
                {
                    cmd = new OleDbCommand("update dblogin set upass='" + txtconfirmpwd.Text+ "' where upass='" + txtcurrentpwd.Text + "'", con);
                   int ans=cmd.ExecuteNonQuery();
                   if(ans>0)
                   {
                       MessageBox.Show("your password successfully change", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                       groupBox1.Visible = false;
                       clear();
                       txtcurrentpwd.Focus();

                   }
                   else
                   {

                       MessageBox.Show("your password not change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       txtnewpwd.Text = "";
                    //   txt_repw.Text = "";
                      // txt_repw.Text = "";
                       txtnewpwd.Focus();

                   }
                }

                else
                {
                      MessageBox.Show("please check your password... password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewpwd.Text = "";
                   // txt_repw.Text="";
                    txtconfirmpwd.Text = "";
                    txtnewpwd.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }
      
    }
}







