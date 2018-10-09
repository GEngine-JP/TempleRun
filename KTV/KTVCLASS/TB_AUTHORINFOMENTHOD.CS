using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace KTV.KTVclass
{
   public class tb_authorinfoMenthod
    {
        OleDbCommand oledcmd = null;
        OleDbConnection oledCon = null;
       OleDbDataReader oleRed = null;
              #region 查询
       public void tb_authorinfoFill(string strFalg,object obj)
       {
         
           try
           {
               
               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();
               string strAdd = "select * from tb_authorinfo ";
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
                                    lv1.SubItems.Add(oleRed[4].ToString());
                                    lv1.SubItems.Add(oleRed[5].ToString());
                                    lv1.SubItems.Add(oleRed[3].ToString());
                                    lv1.SubItems.Add(oleRed[6].ToString());
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
       public string gettb_authorinfoID()
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

           return ("AU-" + strTime);

       }
       #endregion
        #region 添加
       public int AuthAdd(tb_authorinfo tb_aut)

       {
           int intResult = 0;
           try
           {
               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();
               string strAdd = "insert into tb_authorinfo values( ";
               strAdd += "'" + tb_aut.intauthorId+ "','" + tb_aut.strauthorName + "','" + tb_aut.strauthorSex + "','" + tb_aut.daauthorbirthday + "',";
               strAdd += "'" + tb_aut.strauthorGenre + "','" + tb_aut.strauthorcompany + "','" + tb_aut.strauthorRecma + "',";
               strAdd += "'" + tb_aut.strauthorzjm + "','" + tb_aut.daRdateTime + "')";
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
       public int AuthUpdate(tb_authorinfo tb_aut)
       {
           int intResult = 0;
           try
           {
               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();

               string strAdd = "update tb_authorinfo  set ";
               strAdd += "authorName='" + tb_aut.strauthorName + "',authorSex='" + tb_aut.strauthorSex + "',authorbirthday ='" + tb_aut.daauthorbirthday + "',";
               strAdd += "authorGenre='" + tb_aut.strauthorGenre + "',authorcompany='" + tb_aut.strauthorcompany + "',authorRecma ='" + tb_aut.strauthorRecma + "',";
               strAdd += "authorzjm='" + tb_aut.strauthorzjm + "',RdateTime='" + tb_aut.daRdateTime + "' where authorId='" + tb_aut.intauthorId + "'";
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
       public OleDbDataReader  AuthFind(string tb_aut)
       {
        
           try
           {
               getConnection getCon = new getConnection();
               oledCon = getCon.OledCon();
               oledCon.Open();

               string strAdd = "select * from tb_authorinfo   where authorId='" + tb_aut + "'";
               
               oledcmd = new OleDbCommand(strAdd, oledCon);
              oleRed=oledcmd.ExecuteReader();
              return oleRed;
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.Message.ToString());
               return oleRed;
           }
       
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
               string strAdd = "delete * from tb_authorinfo where  authorId='" + strFalg + "'";
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
