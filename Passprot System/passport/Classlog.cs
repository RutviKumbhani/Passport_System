using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace passport
{
    class Classlog
    {
         OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        
        public bool insert_up_delet(string qry)
        {
        
            
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");
          
            cn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = qry;

            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                return true;
            else
                return false;

        }
        public DataSet select_data(string qry)
        {

            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + @"\database.accdb");

            cn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = qry;

            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();

            return ds;

        }
    }
    
}
