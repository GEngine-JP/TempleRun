namespace KTV
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bntOK = new System.Windows.Forms.Button();
            this.bntEsce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntOK
            // 
            this.bntOK.BackgroundImage = global::KTV.Properties.Resources.确定按钮;
            this.bntOK.Location = new System.Drawing.Point(49, 151);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(63, 23);
            this.bntOK.TabIndex = 0;
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // bntEsce
            // 
            this.bntEsce.BackgroundImage = global::KTV.Properties.Resources.取消按钮;
            this.bntEsce.Location = new System.Drawing.Point(202, 151);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(68, 23);
            this.bntEsce.TabIndex = 1;
            this.bntEsce.UseVisualStyleBackColor = true;
            this.bntEsce.Click += new System.EventHandler(this.bntEsce_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "登录名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "登录密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(47, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "登录界面：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(129, 57);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 21);
            this.txtUser.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(129, 84);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(181, 21);
            this.txtPwd.TabIndex = 6;
            // 
            // cmbLogin
            // 
            this.cmbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Items.AddRange(new object[] {
            "后台数据维护",
            "系统点歌"});
            this.cmbLogin.Location = new System.Drawing.Point(129, 111);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(181, 20);
            this.cmbLogin.TabIndex = 7;
            this.cmbLogin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::KTV.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(362, 189);
            this.Controls.Add(this.cmbLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntOK);
            this.Name = "Login";
            this.Text = "登录信息";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button bntEsce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cmbLogin;
    }
}