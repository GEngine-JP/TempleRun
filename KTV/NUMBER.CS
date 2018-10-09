using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using KTV.KTVclass;
namespace KTV
{
    public partial class Number : Form
    {
        public Number()
        {
            InitializeComponent();
        }
        public Number(int inCount)
        {
            InitializeComponent();
            intFalg = inCount;
        }
        public int intFalg = 0;//控件点歌条件
        private void frmNumber_Load(object sender, EventArgs e)
        {
            if(intFalg==1)//数字
            {
                this.Text = "数字点歌";
            }
            if(intFalg==2)//拼音
            {
                this.Text = "拼音点歌";
            }
            if(intFalg==3)//明星
            {
                this.Text = "明星点歌";
            }
            if(intFalg==4)//歌名
            {
                this.Text = "歌名点歌";
            }
            txtName.Focus();
                

        }

        //确定调用查询结果
        tbMusicnfoMenthod tbMusice = new tbMusicnfoMenthod();//实例方法类
        
        private void bntOK_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("输入正确的查询条件！");
                txtName.Focus();
                return;
            }
            DaiGe daige = (DaiGe)this.Owner;//实例窗体对象
            if (intFalg == 1)//数字
            {
                //调用方法查找结果，填冲控件
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 1) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 1;
                    MessageBox.Show("没有查到结果，请输入其它条件");
                    txtName.Text = "";
                    txtName.Focus();
                
                }
            }
            if (intFalg == 2)//拼音
            {
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 2) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 2;
                    MessageBox.Show("没有结查，请输入其它条件");
                    txtName.Text = "";
                    txtName.Focus();

                }
            }
            if (intFalg == 3)//明星
            {
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 3) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 3;
                    MessageBox.Show("没有结查，请输入其它条件");
                    txtName.Text = "";
                    txtName.Focus();

                }
            }
            if (intFalg == 4)//歌名
            {
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 4) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 4;
                    MessageBox.Show("没有结查，请输入其它条件\n 可以断续输入查询条件或退出","查询提示");
                    txtName.Text = "";
                    txtName.Focus();

                }
            }
        }
        //文本框数字
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (intFalg == 1)//数字
            {
                if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
                {
                    MessageBox.Show("数字点歌，请输入数字！","数字点歌");
                    e.Handled = true;
                
                }
            }
            if (intFalg == 2)//拼音
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                {
                    MessageBox.Show("拼音点歌，请输入拼音！", "拼音点歌");
                    e.Handled = true;

                }
            }

        }
        //退出
        private void bntEsce_Click(object sender, EventArgs e)
        {

            DialogResult dra = MessageBox.Show("是否退出"+this.Text,"信息提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dra == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}