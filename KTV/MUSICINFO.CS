using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using KTV.KTVclass;
namespace KTV
{
    public partial class Musicinfo : Form
    {
        public Musicinfo()
        {
            InitializeComponent();
        }
        public Musicinfo(int intid,string strName)
        {
            InitializeComponent();
            intFalg = intid;
            strId = strName;
        }
        public int intFalg = 0;
        public string strId = null;
        tb_musicinfo tbMusice = new tb_musicinfo();//歌
        tbMusicnfoMenthod tbMuseNeth = new tbMusicnfoMenthod();
        tb_authorinfoMenthod AuMenthod = new tb_authorinfoMenthod();
        frmdictionaryMenthod diction = new frmdictionaryMenthod();
        private void frmMusicinfo_Load(object sender, EventArgs e)
        {

            AuMenthod.tb_authorinfoFill("1", cmbMusic_author);//填冲名星ComBox控件
            diction.dictionaryFind("1", cmbMusic_Kind);//填冲类型ComBox控件
            if (intFalg == 1)//添加
            {
                txtMusic_code.Text = tbMuseNeth.tbMusicnfoID().ToString();
            }
            if (intFalg == 2)//修改
            {
                getupdate();
            }

        }
        public void getupdate()
        {
            OleDbDataReader dr = tbMuseNeth.tbMusicnfoFillReder(strId);
            dr.Read();
            if (dr.HasRows)
            {
                txtMusic_code.Text = dr[0].ToString();
                txtMusicC_name.Text = dr[1].ToString();
                cmbMusic_author.Text = dr[2].ToString();
                cmbMusic_Kind.Text = dr[3].ToString();
                cmbMusic_chinse.Text = dr[4].ToString();
                txtMusic_filepath.Text = dr[5].ToString();
                txtMusic_Ping.Text = dr[6].ToString();
            
            }
            dr.Close();
        
        }

        //确定操作添加或修改
        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (txtMusicC_name.Text == "")
            {
                MessageBox.Show("请输入歌曲名称");
                txtMusicC_name.Focus();
                return;
            }
            if (cmbMusic_author.Text == "")
            {
                MessageBox.Show("请输入歌手名称");
                return;
            }
            if (txtMusic_filepath.Text == "")
            {
                MessageBox.Show("请输入歌典文件路径");
                txtMusic_filepath.Focus();
                return;
            }
            tbMusice.strMusic_code = txtMusic_code.Text;
            tbMusice.strMusicC_name = txtMusicC_name.Text;
            tbMusice.strMusic_author = cmbMusic_author.Text;
            tbMusice.strMusic_Kind = cmbMusic_Kind.Text;
            tbMusice.strMusic_chinse = cmbMusic_chinse.Text;
            tbMusice.strMusic_filepath = txtMusic_filepath.Text;
            tbMusice.strMusic_Ping = txtMusic_Ping.Text;
    
            tbMusice.daMusic_date = DateTime.Now;
            tbMusice.intMusic_falg = 0;
            Main frm = (Main)this.Owner;
            if (intFalg == 1)
            {
                if (tbMuseNeth.tbMusicnfoAdd(tbMusice) == 1)
                {
                    MessageBox.Show("添加成功！");
                   
                    tbMuseNeth.tbMusicnfoFill(frm.lvMuscie);
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                    tbMuseNeth.tbMusicnfoFill(frm.lvMuscie);
                    intFalg = 0;
                    this.Close();
                }
            }
            if (intFalg == 2)
            {
                if (tbMuseNeth.tbMusicnfoUpdate(tbMusice) == 1)
                {
                    MessageBox.Show("修改成功！");
                    tbMuseNeth.tbMusicnfoFill(frm.lvMuscie);
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                    tbMuseNeth.tbMusicnfoFill(frm.lvMuscie);
                    intFalg = 0;
                    this.Close();
                }
            
            }


        }

        private void txtMusicC_name_TextChanged(object sender, EventArgs e)
        {
            if (txtMusicC_name.Text != "")
            { 
                txtMusic_Ping.Text=GetCodstring(txtMusicC_name.Text);
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
        //打开文件路径
        private void bntOpen_Click(object sender, EventArgs e)
        {
            openPath.Filter = "(*.wav)|*.wav|(*.mp3)|*.mp3|(*.avi)|*.avi";
            openPath.FileName = "";
            if (openPath.ShowDialog() == DialogResult.OK)
            {
                txtMusic_filepath.Text = openPath.FileName;
            }

        }
    }
}