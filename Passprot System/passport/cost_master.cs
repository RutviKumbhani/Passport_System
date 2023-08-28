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
    public partial class cost_master : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        
        DataSet ds;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        Classlog empcs = new Classlog();
        int btflag = 0;

        public cost_master()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");
        }

        private void cost_master_Load(object sender, EventArgs e)
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
            txt_appno.Enabled = b;
            txt_name.Enabled = b;
            txt_add.Enabled = b;
            txt_city.Enabled = b;
            txt_email.Enabled = b;
            txt_phone.Enabled = b;
            rb_fresh.Enabled = b;
            rb_renew.Enabled = b;
            rb_replace.Enabled = b;

        }
        public void clear()
        {
            txt_id.Text = "";
            txt_appno.Text = "";
            txt_name.Text = "";
            txt_add.Text = "";
            txt_city.Text = "";
            txt_email.Text = "";
            txt_add.Text = "";
            txt_phone.Text = "";
            if (rb_fresh.Checked)
                rb_fresh.Checked = false;
            else if (rb_renew.Checked)
                rb_renew.Checked = false;
            else
                rb_replace.Checked = false;
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
            dataGridView1.Columns[1].HeaderText = "APPLICTION NO";
            dataGridView1.Columns[2].HeaderText = "NAME";
            dataGridView1.Columns[3].HeaderText = "ADDRESS";
            dataGridView1.Columns[4].HeaderText = "CITY";
            dataGridView1.Columns[5].HeaderText = "EMAIL";
            dataGridView1.Columns[6].HeaderText = "CONTECT";
            dataGridView1.Columns[7].HeaderText = "PASSPORT TYPE";
        }
        public void datagrid()
        {
            ds = empcs.select_data("select * from dbcost");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = empcs.select_data("select max(cid) from dbcost");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            ds = empcs.select_data("select max(appno) from dbcost");
            int y;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                y = 1001;
            else
                y = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            txt_id.Text = x.ToString();
            txt_appno.Text = y.ToString();
            txt_id.Enabled = false;
            txt_name.Focus();
            btenable(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string s1;
            if (rb_fresh.Checked)
                s1 = rb_fresh.Text;
            else if(rb_renew.Checked)
                s1 = rb_renew.Text;
            else
                s1 = rb_replace.Text;


            if (btflag == 1)
            {
                bool ans = empcs.insert_up_delet("insert into dbcost values(" + txt_id.Text + ",'" + txt_appno.Text + "','" + txt_name.Text + "','" + txt_add.Text + "','" + txt_city.Text + "','" + txt_email.Text + "','" + txt_phone.Text + "','" + s1 + "')");

                if (ans)
                    MessageBox.Show("Insert record successfully");
                else
                    MessageBox.Show("Error insert record into employee table");
            }
            if (btflag == 2)
            {
                bool ans = empcs.insert_up_delet("update dbcost set appno='"+txt_appno.Text+"',cname='" + txt_name.Text + "',address='" + txt_add.Text + "',city='" + txt_city.Text + "',email='" + txt_email.Text + "',phone='" + txt_phone.Text + "',ptype='" + s1 + "' where cid=" + txt_id.Text + " ");

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
                txt_id.Text = r.Cells["cid"].Value.ToString();
                txt_appno.Text = r.Cells["appno"].Value.ToString();
                txt_name.Text = r.Cells["cname"].Value.ToString();
                txt_add.Text = r.Cells["address"].Value.ToString();
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
                bool ans = empcs.insert_up_delet("delete from dbcost where cid=" + txt_id.Text + "");

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

            da = new OleDbDataAdapter("select cid from dbcost", cn);
            ds = new DataSet();
            da.Fill(ds);

            com_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                com_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void com_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(com_id.SelectedItem.ToString());
            da = new OleDbDataAdapter("select * from dbcost where cid=" + x + "", cn);
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
            da = new OleDbDataAdapter("select * from dbcost where cname Like '%" + txt_nm.Text + "%'", cn);
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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit from Costomer master form..?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void txt_appno_Leave(object sender, EventArgs e)
        {
            Regex valmob = new Regex(@"\d{4}");
            if (valmob.IsMatch(txt_phone.Text.Trim()) == false || txt_phone.Text.Length > 4 || txt_phone.Text.Length < 4)
            {
                MessageBox.Show("please enter only 4 digits", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }

}