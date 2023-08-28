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
    public partial class mdi_form : Form
    {
        public mdi_form()
        {
            InitializeComponent();
        }

        private void employeemasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_master em = new employee_master();
            em.Show();
        }

        private void customermasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost_master cm = new cost_master();
            cm.Show();
        }

        private void billingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bill bill = new bill();
            bill.Show();
        }

        private void passportdetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicant ad = new applicant();
            ad.Show();
        }

        private void appoimentdetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            police_appoi pa = new police_appoi();
            pa.Show();
        }

        private void employeeMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emp_mas_report emp = new emp_mas_report();
            emp.Show();
        }

        private void customerMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost_mas_report cr = new cost_mas_report();
            cr.Show();
        }

        private void billingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill_mas_report br = new bill_mas_report();
            br.Show();
        }


        private void passportDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            app_mas_report ar = new app_mas_report();
            ar.Show();
        }

        private void appoimentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            police_mas_report pr = new police_mas_report();
            pr.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cpassword cp = new cpassword();
            cp.Show();
        }

        private void aboutOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ab_owner ab_owner = new ab_owner();
            ab_owner.Show();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            about_us about_us = new about_us();
            about_us.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit from MDI form..?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }
    }
}
