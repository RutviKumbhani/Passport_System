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
using System.Net;
using System.Net.Mail;


namespace passport
{
    public partial class police_appoi : Form
    {
        //
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        //

        OleDbConnection cn;
        OleDbDataAdapter da;

        DataSet ds;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        Classlog apolice = new Classlog();
        int btflag = 0;

        public police_appoi()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");
        }

        private void police_appoi_Load(object sender, EventArgs e)
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
            dtp_date.Enabled = b;
            txtTo.Enabled = b;
            txtCC.Enabled = b;
            txtSubject.Enabled = b;
            txtMessage.Enabled = b;
            txtUsername.Enabled = b;
            txtPassword.Enabled = b;
            txtPort.Enabled = b;
            chkSSL.Enabled = b;
            txtSmtp.Enabled = b;
        }
        public void clear()
        {
            txt_id.Text = "";
            dtp_date.Text = "";
            txtTo.Text = "";
            txtCC.Text = "";
            //txtSubject.Text = "";
            //txtMessage.Text = "";
            //txtUsername.Text = "";
            txtPassword.Text = "";
          // txtPort.Text = "";
          // chkSSL.Text = "";
          //  txtSmtp.Text = "";
           
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
            dataGridView1.Columns[1].HeaderText = "DATE";
            dataGridView1.Columns[2].HeaderText = "TO";
            dataGridView1.Columns[3].HeaderText = "CC";
            dataGridView1.Columns[4].HeaderText = "SUBJECT";
            dataGridView1.Columns[5].HeaderText = "MESSAGE";
            dataGridView1.Columns[6].HeaderText = "USER NAME";
            //dataGridView1.Columns[7].HeaderText = "PASSWORD";
            dataGridView1.Columns[7].HeaderText = "PORT";
            dataGridView1.Columns[8].HeaderText = "SSL";
            dataGridView1.Columns[9].HeaderText = "SMTP";
        }
        public void datagrid()
        {
            ds = apolice.select_data("select * from dbpolice");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btflag = 1;
            dis_enable_control(true);
            ds = new DataSet();
            ds = apolice.select_data("Select max(ID) from dbpolice");
            int x;
            if (ds.Tables[0].Rows[0][0].ToString().Equals(""))
                x = 1;
            else
                x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

            txt_id.Text = x.ToString();
            txt_id.Enabled = false;
            txtTo.Focus();
            btenable(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          string  s1 = "";
            if (chkSSL.Checked)
                s1 = chkSSL.Text + "";

            if (btflag == 1)
            {
                bool ans = apolice.insert_up_delet("insert into dbpolice values(" + txt_id.Text + ",'" + dtp_date.Value.ToShortDateString() + "','" + txtTo.Text + "','" + txtCC.Text + "','" + txtSubject.Text + "','" + txtMessage.Text + "','" + txtUsername.Text +  "','" + txtPort.Text + "','" + s1+ "','" + txtSmtp.Text + "')");

                if (ans)
                    MessageBox.Show("Insert record successfully");
                else
                    MessageBox.Show("Error insert record into employee table");
            }
            if (btflag == 2)
            {
                bool ans = apolice.insert_up_delet("update dbpolice set  udate='" + dtp_date.Value.ToShortDateString() + "',Uto='" + txtTo.Text + "',Ucc='" + txtCC.Text + "',Usub='" + txtSubject.Text + "',Ubody='" + txtMessage.Text + "',Unm='" + txtUsername.Text + "',Uport='" + txtPort.Text + "',Ussl='" + s1 + "',Usmtp='" + txtSmtp.Text + "' where ID=" + txt_id.Text + "");

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
                txt_id.Text = r.Cells["ID"].Value.ToString();
                dtp_date.Text = r.Cells["udate"].Value.ToString();
                txtTo.Text = r.Cells["Uto"].Value.ToString();
                txtCC.Text = r.Cells["Ucc"].Value.ToString();
                txtSubject.Text = r.Cells["Usub"].Value.ToString();
                txtMessage.Text = r.Cells["Ubody"].Value.ToString();
                txtUsername.Text = r.Cells["Unm"].Value.ToString();
                txtPort.Text = r.Cells["Uport"].Value.ToString();

                string s1 = r.Cells["Ussl"].Value.ToString();

                string[]str=s1.Split(' ');
                foreach(string s in str)
                {

                if (s1.Trim().Equals("SSL"))
                    chkSSL.Checked = true;
                }
              
                txtSmtp.Text = r.Cells["Usmtp"].Value.ToString();


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
                bool ans = apolice.insert_up_delet("delete from dbpolice where ID=" + txt_id.Text + "");

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
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

     

        private void rb_id_CheckedChanged(object sender, EventArgs e)
        {

            com_id.Visible = true;
            txt_nm.Visible = false;

            da = new OleDbDataAdapter("select ID from dbpolice", cn);
            ds = new DataSet();
            da.Fill(ds);

            com_id.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                com_id.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void com_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(com_id.SelectedItem.ToString());
            da = new OleDbDataAdapter("select * from dbpolice where ID=" + x + "", cn);
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
              da = new OleDbDataAdapter("select * from dbpolice where Uto Like '%" + txt_nm.Text + "%'", cn);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
             login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chkSSL.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtUsername.Text + txtSmtp.Text.Replace("smtp.", "@"), "rutvikumbhani2410", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));
            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));
            msg.Subject = txtSubject.Text;
            msg.Body = txtMessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(Sendcompletedcallback);
            string userstate = "Sending....";
            client.SendAsync(msg, userstate);





            ////created object of SmtpClient details and provides server details
            //SmtpClient MyServer = new SmtpClient("smtp.gmail.com");
            //MyServer.Port = 587;

            ////Server Credentials
            //NetworkCredential NC = new NetworkCredential();
            //NC.UserName = "rutvikumbhani2410@gmail.com";
            //NC.Password =txtPassword.Text;

            ////assigned credetial details to server
            //MyServer.Credentials = NC;
            //MyServer.EnableSsl = true;
            ////create sender address
            //MailAddress from = new MailAddress("rutvikumbhani2410@gmail.com", "Rutvi Kumbhani");

            ////create receiver address
            //MailAddress receiver = new MailAddress("rutvikumbhani@gmail.com", "rutvi kumbhani");

            //MailMessage Mymessage = new MailMessage(from, receiver);
            ////Mymessage.Subject = "Hello KEM 60?";
            ////Mymessage.Body = "Bas Maja";
            //Mymessage.Subject = txtSubject.Text;
            //Mymessage.Body = txtMessage.Text;
            ////sends the email
            //MyServer.Send(Mymessage);
        }

        private static void Sendcompletedcallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0}{1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("your message has been send ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        
        
        

    }
}
       


      
              

      


      