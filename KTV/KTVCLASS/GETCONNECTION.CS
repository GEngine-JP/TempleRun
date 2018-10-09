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
            //创建连接数据库的字符串
            string reportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
             Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            reportPath += @"\DataBase\db_KTV.mdb";
            string ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + reportPath;
            //创建OleDbConnection对象
           OleDbConnection con = new OleDbConnection(ConStr);
            //con.Open();
            return con;
        }//end if
    }
}
