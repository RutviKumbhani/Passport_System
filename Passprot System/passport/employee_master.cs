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
    public partial class employee_master : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataSet ds;
        Classlog empcs = new Classlog();
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        int btflag = 0;

        public employee_master()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");
         

        }

       

        private void employee_master_Load(object sender, EventArgs e)
        {
            dis_enable_control(false);
            btenable(true);

            datagrid();
            datagrid_Header();

            com_eid.Visible = false;
            txt_enm.Visible = false;
            rb_id.Checked = false;
            rb_all.Checked = true;


            timer1.Enabled = true;
            timer1.Start();
            lbldate.Text = "Date:" + DateTime.Now.ToShortDateString();
        }
        public void dis_enable_control(Boolean b)
        {
            txt_id.Enabled = b;
            txt_name.Enabled = b;
            txt_city.Enabled = b;
            txt_email.Enabled = b;
            txt_salary.Enabled = b;
            txt_phone.Enabled = b;
            dtp_jdate.Enabled = b;

        }
        public void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_city.Text = "";
            txt_email.Text = "";
            txt_salary.Text = "";
            txt_phone.Text = "";
            dtp_jdate.Text = DateTime.Now.ToShortDateString();
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
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "CITY";
            dataGridView1.Columns[3].HeaderText = "EMAIL";
            dataGridView1.Columns[4].HeaderText = "SALARY";
            dataGridView1.Columns[5].HeaderText = "PHONE";
            dataGridView1.Columns[6].HeaderText = "JOINING DATE";
        }
        public void datagrid()
        {
            ds = empcs.select_data("select * from dbemp");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = empcs.select_data("Select max(eid) from dbemp");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            txt_id.Text = x.ToString();
            txt_id.Enabled = false;
            txt_name.Focus();
            btenable(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btflag == 1)
            {
                bool ans = empcs.insert_up_delet("insert into dbemp values(" + txt_id.Text + ",'" + txt_name.Text + "','" + txt_city.Text + "','" + txt_email.Text + "','" + txt_salary.Text + "','" + txt_phone.Text + "','" + dtp_jdate.Value.ToShortDateString() + "')");

                if (ans)
                    MessageBox.Show("Insert record successfully");
                else
                    MessageBox.Show("Error insert record into employee table");
            }
            if (btflag == 2)
            {
                bool ans = empcs.insert_up_delet("update dbemp set ename='" + txt_name.Text + "',city='" + txt_city.Text + "',email='" + txt_email.Text + "',salary='" + txt_salary.Text + "',phone='" + txt_phone.Text + "',jdate='" + dtp_jdate.Value.ToShortDateString() + "' where eid=" + txt_id.Text + "");

                if (ans)
                    MessageBox.Show("update record successfully");
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
                txt_id.Text = r.Cells["eid"].Value.ToString();
                txt_name.Text = r.Cells["ename"].Value.ToString();
                txt_city.Text = r.Cells["city"].Value.ToString();
                txt_email.Text = r.Cells["email"].Value.ToString();
                txt_salary.Text = r.Cells["salary"].Value.ToString();
                txt_phone.Text = r.Cells["phone"].Value.ToString();
                dtp_jdate.Text = r.Cells["jdate"].Value.ToString();

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
                bool ans = empcs.insert_up_delet("delete from dbemp where eid=" + txt_id.Text + "");

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
            com_eid.Visible = true;
            txt_enm.Visible = false;

            da = new OleDbDataAdapter("select eid from dbemp", cn);
            ds = new DataSet();
            da.Fill(ds);

            com_eid.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                com_eid.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void com_eid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(com_eid.SelectedItem.ToString());
            da = new OleDbDataAdapter("select * from dbemp where eid=" + x + "", cn);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rb_nm_CheckedChanged(object sender, EventArgs e)
        {
            com_eid.Visible = false;
            txt_enm.Visible = true;
        }

        private void txt_enm_TextChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select * from dbemp where ename Like '%" + txt_enm.Text + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (txt_id.Text == " ")
            {
                MessageBox.Show("please enter emplyoyee id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {

            if (txt_name.Text == " ")
            {
                MessageBox.Show("please enter emplyoyee name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_name.Focus();
            }
        }

        private void txt_city_Leave(object sender, EventArgs e)
        {
            if (txt_city.Text == " ")
            {
                MessageBox.Show("please enter emplyoyee city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_city.Focus();
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

        private void txt_salary_Leave(object sender, EventArgs e)
        {
            if (txt_salary.Text == " ")
            {
                MessageBox.Show("please enter employee salary", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_salary.Focus();
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            Regex valmob = new Regex(@"\d{10}");
            if (valmob.IsMatch(txt_phone.Text.Trim()) == false || txt_phone.Text.Length > 10 || txt_phone.Text.Length < 10)
            {
                MessageBox.Show("please enter only 10 digits", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phone.Focus();
            }
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

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit from Employee master form..?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }
    }
}
