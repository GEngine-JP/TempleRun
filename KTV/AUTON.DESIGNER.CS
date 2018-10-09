namespace KTV
{
    partial class Auton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtauthorId = new System.Windows.Forms.TextBox();
            this.txtauthorName = new System.Windows.Forms.TextBox();
            this.txtauthorRecma = new System.Windows.Forms.TextBox();
            this.txtauthorzjm = new System.Windows.Forms.TextBox();
            this.daAuthorbirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbauthorSex = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbauthorcompany = new System.Windows.Forms.ComboBox();
            this.bntSure = new System.Windows.Forms.Button();
            this.bntEsce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "拼音：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "国籍：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "性别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "生日：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "备注：";
            // 
            // txtauthorId
            // 
            this.txtauthorId.Enabled = false;
            this.txtauthorId.Location = new System.Drawing.Point(102, 14);
            this.txtauthorId.Name = "txtauthorId";
            this.txtauthorId.Size = new System.Drawing.Size(133, 21);
            this.txtauthorId.TabIndex = 8;
            // 
            // txtauthorName
            // 
            this.txtauthorName.Location = new System.Drawing.Point(102, 56);
            this.txtauthorName.Name = "txtauthorName";
            this.txtauthorName.Size = new System.Drawing.Size(133, 21);
            this.txtauthorName.TabIndex = 9;
            this.txtauthorName.TextChanged += new System.EventHandler(this.txtauthorName_TextChanged);
            // 
            // txtauthorRecma
            // 
            this.txtauthorRecma.Location = new System.Drawing.Point(103, 126);
            this.txtauthorRecma.Name = "txtauthorRecma";
            this.txtauthorRecma.Size = new System.Drawing.Size(133, 21);
            this.txtauthorRecma.TabIndex = 10;
            // 
            // txtauthorzjm
            // 
            this.txtauthorzjm.Enabled = false;
            this.txtauthorzjm.Location = new System.Drawing.Point(298, 126);
            this.txtauthorzjm.Name = "txtauthorzjm";
            this.txtauthorzjm.Size = new System.Drawing.Size(122, 21);
            this.txtauthorzjm.TabIndex = 11;
            // 
            // daAuthorbirthday
            // 
            this.daAuthorbirthday.Location = new System.Drawing.Point(103, 90);
            this.daAuthorbirthday.Name = "daAuthorbirthday";
            this.daAuthorbirthday.Size = new System.Drawing.Size(132, 21);
            this.daAuthorbirthday.TabIndex = 12;
            // 
            // cmbauthorSex
            // 
            this.cmbauthorSex.FormattingEnabled = true;
            this.cmbauthorSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbauthorSex.Location = new System.Drawing.Point(298, 15);
            this.cmbauthorSex.Name = "cmbauthorSex";
            this.cmbauthorSex.Size = new System.Drawing.Size(121, 20);
            this.cmbauthorSex.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "大陆",
            "海外"});
            this.comboBox2.Location = new System.Drawing.Point(298, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbauthorcompany
            // 
            this.cmbauthorcompany.FormattingEnabled = true;
            this.cmbauthorcompany.Location = new System.Drawing.Point(298, 86);
            this.cmbauthorcompany.Name = "cmbauthorcompany";
            this.cmbauthorcompany.Size = new System.Drawing.Size(121, 20);
            this.cmbauthorcompany.TabIndex = 15;
            // 
            // bntSure
            // 
            this.bntSure.Location = new System.Drawing.Point(126, 169);
            this.bntSure.Name = "bntSure";
            this.bntSure.Size = new System.Drawing.Size(75, 23);
            this.bntSure.TabIndex = 16;
            this.bntSure.Text = "确定(&D)";
            this.bntSure.UseVisualStyleBackColor = true;
            this.bntSure.Click += new System.EventHandler(this.bntSure_Click);
            // 
            // bntEsce
            // 
            this.bntEsce.Location = new System.Drawing.Point(269, 169);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(75, 23);
            this.bntEsce.TabIndex = 17;
            this.bntEsce.Text = "取消(&E)";
            this.bntEsce.UseVisualStyleBackColor = true;
            this.bntEsce.Click += new System.EventHandler(this.bntEsce_Click);
            // 
            // Auton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 208);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntSure);
            this.Controls.Add(this.cmbauthorcompany);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbauthorSex);
            this.Controls.Add(this.daAuthorbirthday);
            this.Controls.Add(this.txtauthorzjm);
            this.Controls.Add(this.txtauthorRecma);
            this.Controls.Add(this.txtauthorName);
            this.Controls.Add(this.txtauthorId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Auton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "明星添加";
            this.Load += new System.EventHandler(this.frmAuton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtauthorId;
        private System.Windows.Forms.TextBox txtauthorName;
        private System.Windows.Forms.TextBox txtauthorRecma;
        private System.Windows.Forms.TextBox txtauthorzjm;
        private System.Windows.Forms.DateTimePicker daAuthorbirthday;
        private System.Windows.Forms.ComboBox cmbauthorSex;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbauthorcompany;
        private System.Windows.Forms.Button bntSure;
        private System.Windows.Forms.Button bntEsce;
    }
}