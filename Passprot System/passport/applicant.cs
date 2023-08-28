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
    public partial class applicant : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da; 

        DataSet ds;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        Classlog empcs = new Classlog();
        int btflag = 0;

        public applicant()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");

        }

        private void applicant_Load(object sender, EventArgs e)
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
            rb_fresh.Enabled = b;
            rb_renew.Enabled = b;
            rb_replace.Enabled = b;
            com_app.Enabled = b;
            com_page.Enabled = b;
            //
            txt_fname.Enabled = b;
            com_bindia.Enabled = b;
           
            txt_edu.Enabled = b;
            dtp_ddate.Enabled = b;
            txt_marid.Enabled = b;
            txt_aadhar.Enabled = b;
            //
            txt_father.Enabled = b;
            txt_mother.Enabled = b;
            //
            com_pres.Enabled = b;
            com_per.Enabled = b;
            //
            txt_address.Enabled = b;
            //txt_city.Enabled = b;
            txt_email.Enabled = b;
            txt_phone.Enabled = b;
       
        }
        public void clear()
        {
            txt_id.Text = "";
            txt_appno.Text = "";

            if (rb_fresh.Checked)
                rb_fresh.Checked = false;
            else if(rb_renew.Checked)
                rb_renew.Checked = false;
            else
                rb_replace.Checked = false;

            com_app.Text = "";
            com_page.Text = "";
            //
            txt_fname.Text = "";
            com_bindia.Text = "";
            txt_edu.Text = "";
            dtp_ddate.Text = DateTime.Now.ToShortDateString();
            txt_marid.Text = "";
            txt_aadhar.Text = "";
            //
            txt_father.Text = "";
            txt_mother.Text = "";
            //
            com_pres.Text = "";
            com_per.Text = "";
            //

            txt_address.Text = "";
            txt_phone.Text = "";
             txt_email.Text = "";
           
           
            
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
            dataGridView1.Columns[1].HeaderText = "APPLICATION NO";
            dataGridView1.Columns[2].HeaderText = "APPLYING_FOR";
            dataGridView1.Columns[3].HeaderText = "TPYE_APPLICATION";
            dataGridView1.Columns[4].HeaderText = "BOOKLET";
            //
            dataGridView1.Columns[5].HeaderText = "APPLICANT'S_NAME";
            dataGridView1.Columns[6].HeaderText = "BIRTH_INDIA";
            dataGridView1.Columns[7].HeaderText = "EDUCATION";
            dataGridView1.Columns[8].HeaderText = "DATE_OF_BIRTH";
            dataGridView1.Columns[9].HeaderText = "MARITAL SATUS";
            dataGridView1.Columns[10].HeaderText = "AADHAAR_NO";
            //
            dataGridView1.Columns[11].HeaderText = "FATHER_NAME";
            dataGridView1.Columns[12].HeaderText = "MOTHER_NAME";
            //
            dataGridView1.Columns[13].HeaderText = "PRESENT_INDIA";
            dataGridView1.Columns[14].HeaderText = "PERMENENT_ADD";
            //
            dataGridView1.Columns[15].HeaderText = "ADDRESS";
            dataGridView1.Columns[16].HeaderText = "PHON_NO";
            dataGridView1.Columns[17].HeaderText = "E-MAIL";

        }
        public void datagrid()
        {
            ds = empcs.select_data("select * from dbappli");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = empcs.select_data("select max(id) from dbappli");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            ds = empcs.select_data("select max(appno) from dbappli");

            //int y;
            //if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
            //    y = 1001;
            //else
            //    y = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            txt_id.Text = x.ToString();
            //txt_appno.Text = y.ToString();
            txt_id.Enabled = false;
            txt_fname.Focus();
            btenable(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string s1;
            // Applying for
            if (rb_fresh.Checked)
                s1 = rb_fresh.Text;
            else if(rb_renew.Checked)
                s1 = rb_renew.Text;
            else
                s1 = rb_replace.Text;

            if (btflag == 1)
            {
                bool ans = empcs.insert_up_delet("insert into dbappli values(" + txt_id.Text + ",'"+txt_appno.Text+"','" + s1 + "','" + com_app.Text+ "','" +com_page.Text + "','" + txt_fname.Text + "','" + com_bindia.Text + "','" + txt_edu.Text + "','" + dtp_ddate.Value.ToShortDateString() + "','"+txt_marid.Text + "','" + txt_aadhar.Text + "','" + txt_father.Text + "','" + txt_mother.Text + "','" + com_pres.Text + "','" + com_per.Text + "','" + txt_address.Text + "','" + txt_phone.Text + "','" + txt_email.Text + "')");

                if (ans)
                    MessageBox.Show("Insert record successfully");
                else
                    MessageBox.Show("Error insert record into employee table");
            }
            if (btflag == 2)
            {
                bool ans = empcs.insert_up_delet("update dbappli set appno='"+txt_appno.Text+"',applyfor='" + s1 + "',typeappli='" + com_app.Text + "',booklet='" + com_page.Text + "',appliname='" + txt_fname.Text + "',birthindia='" + com_bindia.Text + "',edu='" + txt_edu.Text + "',bdate='" + dtp_ddate.Value.ToShortDateString() + "',marital='" + txt_marid.Text + "',aadhaar='" + txt_aadhar.Text + "',fathernm='" + txt_father.Text + "',mothernm='" + txt_mother.Text + "',present='" + com_pres.Text + "',permanet='" + com_per.Text + "',address='" + txt_address.Text + "',phone='" + txt_phone.Text + "',email='" + txt_email.Text + "' where id=" + txt_id.Text + " ");
              
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
                txt_id.Text = r.Cells["id"].Value.ToString();
                txt_appno.Text = r.Cells["appno"].Value.ToString();

                string s1 = r.Cells["applyfor"].Value.ToString();
                if (s1.Trim().Equals("Fresh passport"))
                    rb_fresh.Checked = true;
                else if (s1.Trim().Equals("Renew passport"))
                    rb_renew.Checked = true;
                else
                    rb_replace.Checked = true;

                //
                com_app.Text = r.Cells["typeappli"].Value.ToString();
                com_page.Text = r.Cells["booklet"].Value.ToString();
                txt_fname.Text = r.Cells["appliname"].Value.ToString();

                com_bindia.Text = r.Cells["birthindia"].Value.ToString();
                txt_edu.Text = r.Cells["edu"].Value.ToString();
                dtp_ddate.Text = r.Cells["bdate"].Value.ToString();
                txt_marid.Text= r.Cells["marital"].Value.ToString();
              txt_aadhar.Text = r.Cells["aadhaar"].Value.ToString();
                //
              txt_father.Text= r.Cells["fathernm"].Value.ToString();
              txt_mother.Text = r.Cells["mothernm"].Value.ToString();
                //
              com_pres.Text = r.Cells["present"].Value.ToString();
              com_per.Text = r.Cells["permanet"].Value.ToString();

                //

                txt_address.Text = r.Cells["address"].Value.ToString();
                txt_phone.Text = r.Cells["phone"].Value.ToString();
                txt_email.Text = r.Cells["email"].Value.ToString();


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record..?", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                bool ans = empcs.insert_up_delet("delete from dbappli where id=" + txt_id.Text + "");

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

       

        private void btn_update_Click(object sender, EventArgs e)
        {
            btflag = 2;
            dis_enable_control(true);
            btenable(false);
        }

        private void rb_id_CheckedChanged(object sender, EventArgs e)
        {
            com_id.Visible = true;
            txt_nm.Visible = false;

            da = new OleDbDataAdapter("select id from dbappli", cn);
            ds = new DataSet();
            da.Fill(ds);

            com_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                com_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void com_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(com_id.SelectedItem.ToString());
            da = new OleDbDataAdapter("select * from dbappli where id=" + x + "", cn);
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
            da = new OleDbDataAdapter("select * from dbappli where appliname Like '%" + txt_nm.Text + "%'", cn);
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

        private void txt_aadhar_Leave(object sender, EventArgs e)
        {
            Regex valmob = new Regex(@"\d{12}");
            if (valmob.IsMatch(txt_aadhar.Text.Trim()) == false || txt_aadhar.Text.Length > 12 || txt_aadhar.Text.Length < 12)
            {
                MessageBox.Show("Please enter Aadhaar card 12 Digits", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            Regex valmob = new Regex(@"\d{10}");
            if (valmob.IsMatch(txt_phone.Text.Trim()) == false || txt_phone.Text.Length > 10 || txt_phone.Text.Length < 10)
            {
                MessageBox.Show("Please enter contact number 10 Digits", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_marid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsLower(e.KeyChar)) && !(char.IsUpper(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit from Applicant Details form..?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

    
      
    }
}
