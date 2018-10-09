using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KTV.KTVclass;
using System.Data.OleDb;
namespace KTV
{
    public partial class Auton : Form
    {
        public Auton()
        {
            InitializeComponent();
        }
        public Auton(int intcunt,string strId)
        {
            InitializeComponent();
            intFalg = intcunt;
            strgetId = strId;
        }
        public int intFalg = 0;
        public string strgetId = null;
        frmdictionaryMenthod frmDictiyon = new frmdictionaryMenthod();
        tb_authorinfo tbAu = new tb_authorinfo();
        tb_authorinfoMenthod tbAuMenthod = new tb_authorinfoMenthod();
        private void frmAuton_Load(object sender, EventArgs e)
        {
            frmDictiyon.dictionaryFind("1",cmbauthorcompany);
         
            if (intFalg == 1)
            {
                txtauthorId.Text = tbAuMenthod.gettb_authorinfoID();
            }
            if (intFalg == 2)
            {
                getFill();
            }

         }

        public void getFill()
        {
            OleDbDataReader dr = tbAuMenthod.AuthFind(strgetId);
            dr.Read();
            if (dr.HasRows)
            {
                txtauthorId.Text = dr[0].ToString();
                txtauthorName.Text=dr[1].ToString();
                cmbauthorSex.Text=dr[2].ToString();
                daAuthorbirthday.Value=Convert.ToDateTime(dr[3].ToString());
                comboBox2.Text=dr[4].ToString();
               cmbauthorcompany.Text=dr[5].ToString();
                txtauthorRecma.Text=dr[6].ToString();
                  txtauthorzjm.Text=dr[7].ToString();
           
            }
            dr.Close();
        }
        private void bntSure_Click(object sender, EventArgs e)
        {
            if (txtauthorName.Text == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            tbAu.intauthorId = txtauthorId.Text;
            tbAu.strauthorName = txtauthorName.Text;
            tbAu.strauthorSex = cmbauthorSex.Text;
            tbAu.daauthorbirthday = daAuthorbirthday.Value;
            tbAu.strauthorGenre = comboBox2.Text;
            tbAu.strauthorcompany = cmbauthorcompany.Text;
            tbAu.strauthorRecma = txtauthorRecma.Text;
            tbAu.strauthorzjm = txtauthorzjm.Text;
            tbAu.daRdateTime = DateTime.Now;
            if (intFalg == 1)
            {
                if (tbAuMenthod.AuthAdd(tbAu) == 1)
                {
                    MessageBox.Show("添加成功！");
                    Main frm = (Main)this.Owner;
                    tbAuMenthod.tb_authorinfoFill("2",frm.lvAuton);
                    intFalg = 0;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("添加失败");
                    intFalg = 0;
                    this.Close();
                }
            }
            if (intFalg == 2)
            {
                if (tbAuMenthod.AuthUpdate(tbAu) == 1)
                {

                    MessageBox.Show("修改成功");
                    Main frm = (Main)this.Owner;
                    tbAuMenthod.tb_authorinfoFill("2", frm.lvAuton);
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                    intFalg = 0;
                    this.Close();
              
                }
            }
        }
        public static string GetCodstring(string UnName)
        {
            int i = 0;
            ushort key = 0;
            string strResult = string.Empty;

            //创建两个不同的encoding对象
            Encoding unicode = Encoding.Unicode;
            //创建GBK码对象
            Encoding gbk = Encoding.GetEncoding(936);
            //将unicode字符串转换为字节
            byte[] unicodeBytes = unicode.GetBytes(UnName);
            //再转化为GBK码
            byte[] gbkBytes = Encoding.Convert(unicode, gbk, unicodeBytes);
            while (i < gbkBytes.Length)
            {
                //如果为数字\字母\其他ASCII符号
                if (gbkBytes[i] <= 127)
                {
                    strResult = strResult + (char)gbkBytes[i];
                    i++;
                }
                #region 否则生成汉字拼音简码,取拼音首字母
                else
                {

                    key = (ushort)(gbkBytes[i] * 256 + gbkBytes[i + 1]);
                    if (key >= '\uB0A1' && key <= '\uB0C4')
                    {
                        strResult = strResult + "A";
                    }
                    else if (key >= '\uB0C5' && key <= '\uB2C0')
                    {
                        strResult = strResult + "B";
                    }
                    else if (key >= '\uB2C1' && key <= '\uB4ED')
                    {
                        strResult = strResult + "C";
                    }
                    else if (key >= '\uB4EE' && key <= '\uB6E9')
                    {
                        strResult = strResult + "D";
                    }
                    else if (key >= '\uB6EA' && key <= '\uB7A1')
                    {
                        strResult = strResult + "E";
                    }
                    else if (key >= '\uB7A2' && key <= '\uB8C0')
                    {
                        strResult = strResult + "F";
                    }
                    else if (key >= '\uB8C1' && key <= '\uB9FD')
                    {
                        strResult = strResult + "G";
                    }
                    else if (key >= '\uB9FE' && key <= '\uBBF6')
                    {
                        strResult = strResult + "H";
                    }
                    else if (key >= '\uBBF7' && key <= '\uBFA5')
                    {
                        strResult = strResult + "J";
                    }
                    else if (key >= '\uBFA6' && key <= '\uC0AB')
                    {
                        strResult = strResult + "K";
                    }
                    else if (key >= '\uC0AC' && key <= '\uC2E7')
                    {
                        strResult = strResult + "L";
                    }
                    else if (key >= '\uC2E8' && key <= '\uC4C2')
                    {
                        strResult = strResult + "M";
                    }
                    else if (key >= '\uC4C3' && key <= '\uC5B5')
                    {
                        strResult = strResult + "N";
                    }
                    else if (key >= '\uC5B6' && key <= '\uC5BD')
                    {
                        strResult = strResult + "O";
                    }
                    else if (key >= '\uC5BE' && key <= '\uC6D9')
                    {
                        strResult = strResult + "P";
                    }
                    else if (key >= '\uC6DA' && key <= '\uC8BA')
                    {
                        strResult = strResult + "Q";
                    }
                    else if (key >= '\uC8BB' && key <= '\uC8F5')
                    {
                        strResult = strResult + "R";
                    }
                    else if (key >= '\uC8F6' && key <= '\uCBF9')
                    {
                        strResult = strResult + "S";
                    }
                    else if (key >= '\uCBFA' && key <= '\uCDD9')
                    {
                        strResult = strResult + "T";
                    }
                    else if (key >= '\uCDDA' && key <= '\uCEF3')
                    {
                        strResult = strResult + "W";
                    }
                    else if (key >= '\uCEF4' && key <= '\uD188')
                    {
                        strResult = strResult + "X";
                    }
                    else if (key >= '\uD1B9' && key <= '\uD4D0')
                    {
                        strResult = strResult + "Y";
                    }
                    else if (key >= '\uD4D1' && key <= '\uD7F9')
                    {
                        strResult = strResult + "Z";
                    }
                    else
                    {
                        strResult = strResult + "?";
                    }
                    i = i + 2;
                }
                #endregion
            }//end while

            return strResult;
        }

        private void txtauthorName_TextChanged(object sender, EventArgs e)
        {
            if (txtauthorName.Text != "")
            {
                txtauthorzjm.Text = GetCodstring(txtauthorName.Text);
            }
        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}