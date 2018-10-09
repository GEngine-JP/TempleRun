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
    public partial class DaiGe : Form
    {
        public DaiGe()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //数字点歌
        private void bntNumber_Click(object sender, EventArgs e)
        {
            Number frm1 = new Number(1);
            frm1.Owner=this;
            frm1.ShowDialog();

        }
        //拼音点歌
        private void bntPing_Click(object sender, EventArgs e)
        {
            Number frm2 = new Number(2);
            frm2.Owner=this;
            frm2.ShowDialog();

        }
        //明星点歌
        private void bntAutor_Click(object sender, EventArgs e)
        {
            Number frm3 = new Number(3);
            frm3.Owner = this;
            frm3.ShowDialog();
        }
        //歌名点歌
        private void bntName_Click(object sender, EventArgs e)
        {
            Number frm4 = new Number(4);
            frm4.Owner = this;
            frm4.ShowDialog();
        }

        private void frmDaiGe_Load(object sender, EventArgs e)
        {
       
        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            DialogResult diaol = MessageBox.Show("是否要退出系统！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (diaol == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        tbMusicnfoMenthod tbMend = new tbMusicnfoMenthod();

        private void bntSelect_Click(object sender, EventArgs e)
        {
         
            if (stringName != null)
            {
                stringName = tbMend.tbFillName(stringName);
                    MessageBox.Show("选择歌曲<<" + strigName2 + ">>完成，单击《播放》按钮，播放歌曲！", "提示");

            }
            else
            {
                MessageBox.Show("请选择要播放的歌曲！","提示");
            }
        }

        private void bntPlay_Click(object sender, EventArgs e)
        {
            if (stringName != null)
            {
                Play frm = new Play(stringName);
                frm.Owner = this;
                frm.ShowDialog();
                stringName = null;
               // lvPlay.SelectedItems[0].Selected = false;
            }
            else
            {
                MessageBox.Show("请选择要播放的歌曲！","提示");
            }
        }
        string stringName = null;
        string strigName2 = null;
        private void lvPlay_Click(object sender, EventArgs e)
        {
            stringName = lvPlay.SelectedItems[0].SubItems[0].Text;
            strigName2 = lvPlay.SelectedItems[0].SubItems[1].Text;
        }
    }
}