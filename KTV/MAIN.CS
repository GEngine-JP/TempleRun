using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using KTV.KTVclass;
namespace KTV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        frmdictionaryMenthod frmDictyin = new frmdictionaryMenthod();
        tb_authorinfoMenthod tbAuto = new tb_authorinfoMenthod();
        tbMusicnfoMenthod tbMuseic = new tbMusicnfoMenthod();
        tb_computer computer = new tb_computer();
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDictyin.dictionaryFind("2",lvDitcy);//绑定控件数据
            tbAuto.tb_authorinfoFill("2", lvAuton);//绑定控件数据
            tbMuseic.tbMusicnfoFill(lvMuscie);
            computer.tbMusicnfoFill(LvUser);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //添加歌曲类别
            dictionary dicTory = new dictionary(1,"");
            dicTory.Owner = this;
            dicTory.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (strName == null)
            {
                MessageBox.Show("请选择要修改的内容！");
                return;
            }
            else
            {
               //修改歌典类别信息
                dictionary dicTory = new dictionary(2, strName);
                dicTory.Owner = this;
                dicTory.ShowDialog();
            }
            
        }
        public string strName = null;
        //歌典类别
        private void lvDitcy_Click(object sender, EventArgs e)
        {
            strName = lvDitcy.SelectedItems[0].SubItems[0].Text;//当前选择的值
      

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (strName == null)
            {
                MessageBox.Show("请选择要删除的内容！");
                return;
            }
            else
            {
                //删除歌典信息
                frmDictyin.dictionaryDelete(strName);
                MessageBox.Show("删除成功！");
                frmDictyin.dictionaryFind("2", lvDitcy);
            }
        }

        private void bntAut_Click(object sender, EventArgs e)
        {
            //添加明星
            Auton frmAuAdd = new Auton(1,"");
            frmAuAdd.Owner = this;
            frmAuAdd.ShowDialog();

        }
        public string strNameAuton = null;
    //明星
        private void lvAuton_Click(object sender, EventArgs e)
        {
            strNameAuton=lvAuton.SelectedItems[0].SubItems[0].Text;//当前选择的值

        }

        private void bntAuUpdate_Click(object sender, EventArgs e)
        {
            //修改明星
            if (strNameAuton != null)
            {
                Auton frmAuAdd = new Auton(2,strNameAuton);
                frmAuAdd.Owner = this;
                frmAuAdd.ShowDialog();
            }else
            {
             MessageBox.Show("请选择要修改的内容！");
                return;}
        }

        private void bntAuDelete_Click(object sender, EventArgs e)
        {
            //删除明星
            if (strNameAuton != null)
            {
                tbAuto.dictionaryDelete(strNameAuton);//刷新控件
                MessageBox.Show("删除成功");
                tbAuto.tb_authorinfoFill("2", lvAuton);
                
            }
            else
            {
                MessageBox.Show("请选择要删除的内容！");
                return;
            }

        }
        public string strMuseName = null;
        //歌曲
        private void lvMuscie_MouseClick(object sender, MouseEventArgs e)
        {
            strMuseName = lvMuscie.SelectedItems[0].SubItems[0].Text;

        }
        //修改歌曲
        private void bntMuserUpdate_Click(object sender, EventArgs e)
        {
            if (strMuseName != null)
            {
                Musicinfo frmInfo = new Musicinfo(2,strMuseName);
                frmInfo.Owner = this;
                frmInfo.ShowDialog();

            }
            else
            {
                MessageBox.Show("选择要修改歌典");
            }

        }

        private void bntMuserDelete_Click(object sender, EventArgs e)
        {
            if (strMuseName != null)
            {
                if (tbMuseic.tbMusicnfoDelete(strMuseName) == 1)
                {
                    MessageBox.Show("删除成功");
            tbMuseic.tbMusicnfoFill(lvMuscie);
                }
                else
                {
                    MessageBox.Show("删除失败");
                    tbMuseic.tbMusicnfoFill(lvMuscie);
                }
            }
            else
            {
                MessageBox.Show("选择要删除歌典");

            }

        }
        //歌曲添加
        private void bntMuserAdd_Click(object sender, EventArgs e)
        {
            Musicinfo frmInfo = new Musicinfo(1, "");
            frmInfo.Owner = this;
            frmInfo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult diaol = MessageBox.Show("是否要退出后台管理系统！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
         
            if(diaol==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    
   

        public string strUser = null;
        private void LvUser_Click(object sender, EventArgs e)
        {
            strUser = LvUser.SelectedItems[0].SubItems[0].Text;
            if (strUser != null)
            { fillScoure(); }


        }
        public void fillScoure()
        {
            
                OleDbDataReader dr = computer.tbFill(strUser);
                dr.Read();
                if (dr.HasRows)
                {
                    txtUser.Text = dr[1].ToString();
                    txtUser.Enabled = false;
                }
            

        }
        private void bntUserAdd_Click(object sender, EventArgs e)
        {
                    //添加用户
            intFalg = 1;
            txtPassWord.Text = "";
            txtUser.Text = "";
            txtUser.Enabled = true;
            bntUserAdd.Enabled = true;
            bntUserDelete.Enabled = false;
            bntUserUpdate.Enabled = false;
        }

        private void bntUserUpdate_Click(object sender, EventArgs e)
        { ////修改用户
            intFalg = 2;
            bntUserAdd.Enabled = false;
            bntUserDelete.Enabled = false;
            bntUserUpdate.Enabled = true;
        }
        //删除用户
        private void bntUserDelete_Click(object sender, EventArgs e)
        {
            intFalg =3;
            bntUserAdd.Enabled = false;
            bntUserDelete.Enabled = true;
            bntUserUpdate.Enabled = false;
        }
        public int intFalg = 0;

        //保存用户
        private void bntSave_Click(object sender, EventArgs e)
        {
             if (txtUser.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                txtUser.Focus();
                return;
            }
            if (intFalg != 3)
            {
                if (txtPassWord.Text == "")
                {
                    MessageBox.Show("用户密码不能为空！");
                    txtPassWord.Focus();
                    return;
                }
            }
           
        
            if (intFalg == 1)
            {
                computer.strcmp_ID = computer.getSellID();
                computer.strcmp_name = txtUser.Text;
                computer.strcmp_Paww = txtPassWord.Text;
                computer.strcmp_DataTime = DateTime.Now.Date.ToString();
                computer.strcmp_Falg = "0";
                if (computer.tb_computerLogin(computer, 1) == 1)
                {
                    MessageBox.Show("此用户名已被占用");
                    txtUser.Text = "";
                    txtUser.Focus();
                    txtPassWord.Text = "";
                    return;
                }
                if (computer.tb_computerAdd(computer) == 1)
                {
                    MessageBox.Show("添加成功！", "提示");
                    computer.tbMusicnfoFill(LvUser);
                    txtUser.Enabled = true;
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show("失败失败！", "提示");
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
            }
            if (intFalg == 2)
            {
                if (strUser == null)
                {
                    MessageBox.Show("选择要修改的用户");
                    return;
                }
                else
                {
                    computer.strcmp_ID = strUser;
                }
                computer.strcmp_name = txtUser.Text;
                computer.strcmp_Paww = txtPassWord.Text;
                computer.strcmp_DataTime = DateTime.Now.Date.ToString();
                computer.strcmp_Falg = "0";
                if (computer.tb_computerUpdate(computer) == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    computer.tbMusicnfoFill(LvUser);
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }

            }
            if (intFalg == 3)
            {
                if (strUser == null)
                {
                    MessageBox.Show("选择要删除的用户");
                    return;
                }
                else
                {
                    computer.strcmp_ID = strUser;
                }
                computer.strcmp_Falg = "1";
                if (computer.tb_computerDelete(computer) == 1)
                {
                    MessageBox.Show("删除成功！", "提示");
                    computer.tbMusicnfoFill(LvUser);
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
           }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

   

      
    }
}