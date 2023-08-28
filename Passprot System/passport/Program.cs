using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new welcome());
            //Application.Run(new cost_master());
         //   Application.Run(new applicant());
          // Application.Run(new mdi());
           //Application.Run(new emp_mas_report());
            //Application.Run(new cost_mas_report());
           // Application.Run(new police_appoi());
          // Application.Run(new cpassword());
           //  
      //  Application.Run(new bill_mas_report());


        }
    }
}
