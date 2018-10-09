using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
namespace KTV.KTVclass
{
	public class tb_computer
	{
		 private string cmp_ID;
		 public string strcmp_ID
			 {
				 get{ return cmp_ID;}
				 set{ cmp_ID=value;}
			 }
		 private string cmp_name;
		 public string strcmp_name
			 {
				 get{ return cmp_name;}
				 set{ cmp_name=value;}
			 }
		 private string cmp_Paww;
		 public string strcmp_Paww
			 {
				 get{ return cmp_Paww;}
				 set{ cmp_Paww=value;}
			 }
		 private string cmp_DataTime;
		 public string strcmp_DataTime
			 {
				 get{ return cmp_DataTime;}
				 set{ cmp_DataTime=value;}
			 }
		 private string cmp_Falg;
		 public string strcmp_Falg
			 {
				 get{ return cmp_Falg;}
				 set{ cmp_Falg=value;}
			 }
             OleDbCommand oledcmd = null;
             OleDbConnection oledCon = null;
             OleDbDataReader oleRed = null;
        #region Ìí¼Ó
        public int tb_computerAdd(tb_computer compay)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "insert into tb_computer values( ";
                strAdd += "'" + compay.cmp_ID + "','" + compay.cmp_name + "','" + compay.cmp_Paww + "','" + compay.cmp_DataTime + "',";
                strAdd += "'" + compay.cmp_Falg + "')";
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
        #region ÐÞ¸Ä
        public int tb_computerUpdate(tb_computer compay)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "update tb_computer set ";
                strAdd += "cmp_name='" + compay.cmp_name + "',cmp_Paww='" + compay.cmp_Paww + "',cmp_DataTime='" + compay.cmp_DataTime + "',";
                strAdd += "cmp_Falg ='" + compay.cmp_Falg + "' where  cmp_ID='" + compay.cmp_ID + "'";
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
        #region É¾³ý
        public int tb_computerDelete(tb_computer compay)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "update tb_computer set ";
                strAdd += "cmp_Falg ='" + compay.cmp_Falg + "' where  cmp_ID='" + compay.cmp_ID + "'";
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


            return ("UI-" + strTime);

        }
        #endregion
        #region ²éÑ¯
        public void tbMusicnfoFill(object obj)
        {

            try
            {

                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "select * from tb_computer where cmp_Falg='"+ 0 +"'";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                oleRed = oledcmd.ExecuteReader();

                ListView lv = (ListView)obj;
                lv.Items.Clear();
                while (oleRed.Read())
                {

                    ListViewItem lv1 = new ListViewItem(oleRed[0].ToString());
                    lv1.SubItems.Add(oleRed[1].ToString());
                    lv.Items.Add(lv1);
                }
                oleRed.Close();


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());

            }


        }
              #endregion
        #region ²éÑ¯
        public OleDbDataReader tbFill(string obj)
        {

            try
            {

                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "select * from tb_computer where cmp_ID='"+obj+"' ";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                oleRed = oledcmd.ExecuteReader();
                return oleRed;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return oleRed;

            }


        }
           #endregion

        #region µÇÂ¼
        public int tb_computerLogin(tb_computer compay,int intFalg)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd=null;
                switch (intFalg)
                { 
                    case 1:
                        strAdd = "select  * from tb_computer  where  cmp_name='" + compay.strcmp_name + "' and cmp_Falg='" + 0 + "'";
                        break;
                    case 2:
                        strAdd = "select *  from tb_computer  where cmp_name='" + compay.strcmp_name + "'and cmp_Paww='" + compay.strcmp_Paww + "' and cmp_Falg='" + 0 + "'";
                        break;
                }
               
                oledcmd = new OleDbCommand(strAdd, oledCon);
                oleRed = oledcmd.ExecuteReader();
                if (oleRed.HasRows)
                {
                    intResult++;
                }
                return intResult;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }

        }
        #endregion



	} 
}