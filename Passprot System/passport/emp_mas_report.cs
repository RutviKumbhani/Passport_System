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
using System.Text.RegularExpressions;


namespace passport
{
    public partial class emp_mas_report : Form
    {
        Classlog csemp = new Classlog();
        DataSet ds;

     
        public emp_mas_report()
        {
            InitializeComponent();

            rbid.Checked = false;
        }

      

        private void emp_mas_report_Load(object sender, EventArgs e)
        {
            comeid.Visible = false;
            comenm.Visible = false;

            timer1.Enabled = true;
            timer1.Start();
            lbldate.Text = "Date:" + DateTime.Now.ToShortDateString();
        }

        private void rbid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbid.Checked)

            {
                comeid.Visible = true;
                ds = csemp.select_data("select eid from dbemp");
                comeid.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comeid.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
            else
                comeid.Visible = false;
          
          
        }

        private void rbenm_CheckedChanged(object sender, EventArgs e)
        {
            if(rbenm.Checked)
            {
                comenm.Visible = true;
                ds = csemp.select_data("select ename from dbemp");
                comenm.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comenm.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
            else
                comenm.Visible = false;
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            //string s1 = Application.StartupPath + @"C:\project\passport\passport\bin\Debug\report\emloyee_report.rpt";
          //  axCrystalReport1.ReportFileName = s1;
            //  axCrystalReport1.ReportFileName=@"C:\project\passport\passport\bin\Debug\report\emloyee_report.rpt";
             // axCrystalReport1.ReportFileName = @"C:\project\passport\passport\bin\Debug\report\emp_report.rpt";

            string s1 = Application.StartupPath + @"\report\emp_report.rpt";
            axCrystalReport1.ReportFileName = s1;

            if (rbid.Checked)
                axCrystalReport1.SelectionFormula = "{dbemp.eid}=" + comeid.Text + "";
            else if (rbenm.Checked)
                axCrystalReport1.SelectionFormula = "{dbemp.ename}='" + comenm.Text + "'";
            else
                axCrystalReport1.SelectionFormula = "{dbemp.eid}>0";

            axCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized;
            axCrystalReport1.WindowShowRefreshBtn = true;
            
            axCrystalReport1.Action = 1;
        }
       

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit from Employee master report form", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

       
    }
}
