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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void bntOK_Click(object sender, EventArgs e)
        {
             tb_computer computer = new tb_computer();
            if(txtUser.Text=="")
            {
                MessageBox.Show("登录名称不能为空！");
                txtUser.Focus();
                return;
            }
            if(txtPwd.Text=="")
            {
                MessageBox.Show("登录密码不能为空！");
                txtPwd.Focus();
                return;
            }
            if(cmbLogin.Text=="")
            {
                MessageBox.Show("请选择登录界面");
                cmbLogin.Focus();
                return;
            }
            computer.strcmp_name=txtUser.Text;
            computer.strcmp_Paww=txtPwd.Text;
            if (computer.tb_computerLogin(computer, 2) == 1)
            {
                if (cmbLogin.Text == "后台数据维护")
                {
                    Main frm = new Main();
                    frm.Show();
                    this.Hide();
                }
                if (cmbLogin.Text == "系统点歌")
                {
                    DaiGe daige = new DaiGe();
                    daige.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("登录失败！");
                txtPwd.Text = "";
                txtUser.Text = "";
                cmbLogin.Text = "";
                txtUser.Focus();
            }
            

        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}