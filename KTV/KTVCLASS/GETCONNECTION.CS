using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KTV.KTVclass
{
    class getConnection
    {
        public OleDbConnection OledCon()
        {
            //�����������ݿ���ַ���
            string reportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
             Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            reportPath += @"\DataBase\db_KTV.mdb";
            string ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + reportPath;
            //����OleDbConnection����
           OleDbConnection con = new OleDbConnection(ConStr);
            //con.Open();
            return con;
        }//end if
    }
}
