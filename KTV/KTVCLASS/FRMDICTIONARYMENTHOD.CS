using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;
namespace KTV.KTVclass
{
   public  class frmdictionaryMenthod
    {
        OleDbCommand oledcmd = null;
        OleDbConnection oledCon = null;
       OleDbDataReader oleRed = null;
        #region 添加
       public int dictionaryAdd(tb_dictionary tb_aut)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
               // oledCon = new OleDbConnection(ConfigurationSettings.AppSettings["StrCon"].ToString());
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "insert into tb_dictionary (codeID,codName,codeReam) values ( ";
                strAdd += "'"+tb_aut.strcodeID +"','"+tb_aut.strcodeName+"','"+tb_aut.strcodeReam+"')";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                intResult = oledcmd.ExecuteNonQuery();
                return intResult;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }


        }
        #endregion
       #region 修改
       public int dictionaryUpdate(tb_dictionary tb_aut)
       {
           int intResult = 0;
           try
           {
               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();
               string strAdd = "update tb_dictionary  set ";
               strAdd += " codName ='" + tb_aut.strcodeName + "', codeReam='" + tb_aut.strcodeReam + "' where  codeID='" + tb_aut.strcodeID + "'";

                oledcmd = new OleDbCommand(strAdd, oledCon);
               intResult = oledcmd.ExecuteNonQuery();
               return intResult;
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.Message.ToString());
               return intResult;
           }


       }
       #endregion
       #region 查询
       public void dictionaryFind(string strFalg,object obj)
       {
         
           try
           {
               
               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();
               string strAdd = "select * from tb_dictionary ";
               oledcmd = new OleDbCommand(strAdd, oledCon);
               oleRed=oledcmd.ExecuteReader();
                        if(strFalg=="1")
                        {
                           ComboBox cmb=(ComboBox)obj;
                            while(oleRed.Read())
                            {
                                cmb.Items.Add(oleRed[1].ToString());
                            }
                            oleRed.Close();
                        }
                        if(strFalg=="2")
                        {
                       
                            ListView lv=(ListView)obj;
                            lv.Items.Clear();
                            while(oleRed.Read())
                            {
                             
                                ListViewItem lv1 = new ListViewItem(oleRed[0].ToString());
                                    lv1.SubItems.Add(oleRed[1].ToString());
                                    lv1.SubItems.Add(oleRed[2].ToString());
                                    lv.Items.Add(lv1);
                                   
                                                                    
                              
                                
                            }
                            oleRed.Close();
                        }//
               
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.Message.ToString());
            
           }


       }
       #endregion
       #region
       public string getSellID()
       {
           int intYear = DateTime.Now.Day;
           int intMonth = DateTime.Now.Month;
           int intDate = DateTime.Now.Year;
           int intHour = DateTime.Now.Hour;
           int intSecond = DateTime.Now.Second;
           int intMinute = DateTime.Now.Minute;
           string strTime = null;
           strTime = intYear.ToString();
           if (intMonth < 10)
           {
               strTime += "0" + intMonth.ToString();
           }
           else
           {
               strTime += intMonth.ToString();
           }
           if (intDate < 10)
           {
               strTime += "0" + intDate.ToString();
           }
           else
           {
               strTime += intDate.ToString();
           }
           if (intHour < 10)
           {
               strTime += "0" + intHour.ToString();
           }
           else
           {
               strTime += intHour.ToString();
           }
           if (intMinute < 10)
           {

               strTime += "0" + intMinute.ToString();
           }
           else
           {
               strTime += intMinute.ToString();
           }
           if (intSecond < 10)
           {

               strTime += "0" + intSecond.ToString();
           }
           else
           {
               strTime += intSecond.ToString();
           }


           return ("GQ-" + strTime);

       }
       #endregion
       #region 删除
       public void dictionaryDelete(string strFalg)
       {

           try
           {

               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();
               string strAdd = "delete * from tb_dictionary  where  codeID='" + strFalg + "'";
               oledcmd = new OleDbCommand(strAdd, oledCon);
               oleRed = oledcmd.ExecuteReader();
          

           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.Message.ToString());

           }


       }
         #endregion


   }
}
