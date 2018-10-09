using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTV
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }
        public Play(string strPaht)
        {
            InitializeComponent();
            strPath = strPaht;
        }
        public string strPath = null;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
            //播放文件
            this.axWindowsMediaPlayer1.URL = strPath;
        }

        private void bntExce_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }

        private void bntZan_Click(object sender, EventArgs e)
        {
            if (bntZan.Text == "暂停(&K)")
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                bntZan.Text = "继续(&K)";
            }
            else
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                bntZan.Text = "暂停(&K)";
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}