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
    public partial class bill : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;

        DataSet ds;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        Classlog empcs = new Classlog();
        int btflag = 0;
        public bill()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");

        }

        private void bill_Load(object sender, EventArgs e)
        {
            dis_enable_control(false);
            btenable(true);

            datagrid();
            datagrid_Header();

            com_id.Visible = false;
            txt_nm.Visible = false;
            rb_id.Checked = false;
            rb_all.Checked = true;


            timer1.Enabled = true;
            timer1.Start();
            lbldate.Text = "Date:" + DateTime.Now.ToShortDateString();
        }
        public void dis_enable_control(Boolean b)
        {
            txt_id.Enabled = b;
            txt_bill.Enabled = b;
            txt_appno.Enabled = b;
            txt_name.Enabled = b;
            txt_city.Enabled = b;
            txt_email.Enabled = b;
            txt_phone.Enabled = b;
            rb_fresh.Enabled = b;
            rb_renew.Enabled = b;
            rb_replace.Enabled = b;
            txt_total.Enabled = b;
            txt_pay.Enabled = b;
            dtp_bdate.Enabled = b;



        }
        public void clear()
        {
            txt_id.Text = "";
            txt_bill.Text = "";
            txt_appno.Text = "";
            txt_name.Text = "";
            txt_city.Text = "";
            txt_email.Text = "";
            txt_phone.Text = "";
            if (rb_fresh.Checked)
                rb_fresh.Checked = false;
            else if (rb_renew.Checked)
                rb_renew.Checked = false;
            else
                rb_replace.Checked = false;

           
            txt_total.Text = "";
            txt_pay.Text = "";
            dtp_bdate.Text = DateTime.Now.ToShortDateString();
        }
        public void btenable(Boolean b)
        {
            btn_insert.Enabled = b;
            btn_save.Enabled = !b;
            btn_cancel.Enabled = !b;
            btn_update.Enabled = b;
            btn_delete.Enabled = b;

        }
        public void datagrid_Header()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "BILL NO";
            dataGridView1.Columns[2].HeaderText = "APPLITION NO";

            dataGridView1.Columns[3].HeaderText = "NAME";
            dataGridView1.Columns[4].HeaderText ="CITY";
            dataGridView1.Columns[5].HeaderText = "EMAIL";
            dataGridView1.Columns[6].HeaderText = "CONTECT";
            dataGridView1.Columns[7].HeaderText = "PASSPORT TYPE";
         
            dataGridView1.Columns[8].HeaderText = "PAYMENT";
            dataGridView1.Columns[9].HeaderText = "TYPE OF PAY";
            dataGridView1.Columns[10].HeaderText = "BILL DATE";
        }
        public void datagrid()
        {
            ds = empcs.select_data("select * from dbbill");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = empcs.select_data("select max(ID) from dbbill");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            ds = empcs.select_data("select max(billno) from dbbill");
            int y;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                y = 101;
            else
                y = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

           
           
            txt_id.Text = x.ToString();
            txt_bill.Text = y.ToString();
            txt_id.Enabled = false;
            txt_bill.Focus();
            btenable(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string s1;
            if (rb_fresh.Checked)
                s1 = rb_fresh.Text;
            else
                s1 = rb_renew.Text;

            if (btflag == 1)
            {
                bool ans = empcs.insert_up_delet("insert into dbbill values(" + txt_id.Text + ",'" + txt_bill.Text + "','" + txt_appno.Text + "','" + txt_name.Text + "','" + txt_city.Text + "','" + txt_email.Text + "','" + txt_phone.Text + "','" + s1 + "','" + txt_total.Text + "','" + txt_pay.Text + "','" + dtp_bdate.Value.ToShortDateString() + "')");

                if (ans)
                    MessageBox.Show("Insert record successfully");
                else
                    MessageBox.Show("Error insert record into employee table");
            }
            if (btflag == 2)
            {
                bool ans = empcs.insert_up_delet("update dbbill set billno='" + txt_bill.Text + "',appno='" + txt_appno.Text + "',fname='" + txt_name.Text + "',city='" + txt_city.Text + "',email='" + txt_email.Text + "',phone='" + txt_phone.Text + "',ptype='" + s1 + "',total='" + txt_total.Text + "',pay='" + txt_pay.Text + "',bdate='" + dtp_bdate.Value.ToShortDateString() + "' where ID=" + txt_id.Text + "");

                if (ans)
                    MessageBox.Show("Update record successfully");
                else
                    MessageBox.Show("Error update record into employee table");
            }





            clear();
            dis_enable_control(false);
            btenable(true);
            datagrid();
            btflag = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
            dis_enable_control(false);
            btenable(true);
            btflag = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            clear();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txt_id.Text = r.Cells["ID"].Value.ToString();
                txt_bill.Text = r.Cells["billno"].Value.ToString();
                txt_appno.Text = r.Cells["appno"].Value.ToString();
                txt_name.Text = r.Cells["fname"].Value.ToString();
                txt_city.Text = r.Cells["city"].Value.ToString();
                txt_email.Text = r.Cells["email"].Value.ToString();
                txt_phone.Text = r.Cells["phone"].Value.ToString();
                string s1 = r.Cells["ptype"].Value.ToString();

                if (s1.Trim().Equals("Fresh passport"))
                    rb_fresh.Checked = true;
                else if (s1.Trim().Equals("Renew passport"))
                    rb_renew.Checked = true;
                 else
                    rb_replace.Checked = true;

               
                txt_total.Text = r.Cells["total"].Value.ToString(); 
                txt_pay.Text = r.Cells["pay"].Value.ToString();
                dtp_bdate.Text = r.Cells["bdate"].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btflag = 2;
            dis_enable_control(true);
            btenable(false);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record..?", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                bool ans = empcs.insert_up_delet("delete from dbbill where ID=" + txt_id.Text + "");

                if (ans)
                    MessageBox.Show("Record deleted");
                else
                    MessageBox.Show("Error in delete");
            }

            clear();
            dis_enable_control(false);
            btenable(true);
            datagrid_Header();
            datagrid();
        }

        private void rb_id_CheckedChanged(object sender, EventArgs e)
        {
            com_id.Visible = true;
            txt_nm.Visible = false;

            da = new OleDbDataAdapter("select ID from dbbill", cn);
            ds = new DataSet();
            da.Fill(ds);

            com_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                com_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void com_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(com_id.SelectedItem.ToString());
            da = new OleDbDataAdapter("select * from dbbill where ID=" + x + "", cn);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rb_nm_CheckedChanged(object sender, EventArgs e)
        {
            com_id.Visible = false;
            txt_nm.Visible = true;
        }

        private void txt_nm_TextChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select * from dbbill where fname Like '%" + txt_nm.Text + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            com_id.Visible = false;
            txt_nm.Visible = false;
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txt_bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsControl(e.KeyChar)) && !(char.IsLower(e.KeyChar)) && !(char.IsUpper(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

     

        private void txt_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsLower(e.KeyChar)) && !(char.IsUpper(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            Regex valmob = new Regex(@"\d{10}");
            if (valmob.IsMatch(txt_phone.Text.Trim()) == false || txt_phone.Text.Length > 10 || txt_phone.Text.Length < 10)
            {
                MessageBox.Show("please enter only 10 digits", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == " ")
            {
                MessageBox.Show("please enter emplyoyee email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
            }
            Regex valemailid = new Regex(@"\S+\@\S+\.\S+");
            if (txt_email.Text.Length > 0 && txt_email.Text.Trim().Length != 0)
            {
                if (!valemailid.IsMatch(txt_email.Text.Trim()))
                {
                    MessageBox.Show("please checked your email ID ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_email.SelectAll();
                    txt_email.Focus();
                }
            }
        }

        
        private void txt_cols_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_gov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit from billing form..?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
