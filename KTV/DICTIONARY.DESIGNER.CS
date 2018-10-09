namespace KTV
{
    partial class dictionary
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
            this.txtcodeID = new System.Windows.Forms.TextBox();
            this.txtcodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodeReam = new System.Windows.Forms.TextBox();
            this.bntOK = new System.Windows.Forms.Button();
            this.txtEsce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别名称：";
            // 
            // txtcodeID
            // 
            this.txtcodeID.Location = new System.Drawing.Point(89, 15);
            this.txtcodeID.Name = "txtcodeID";
            this.txtcodeID.Size = new System.Drawing.Size(181, 21);
            this.txtcodeID.TabIndex = 2;
            // 
            // txtcodName
            // 
            this.txtcodName.Location = new System.Drawing.Point(89, 53);
            this.txtcodName.Name = "txtcodName";
            this.txtcodName.Size = new System.Drawing.Size(181, 21);
            this.txtcodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "备注：";
            // 
            // txtcodeReam
            // 
            this.txtcodeReam.Location = new System.Drawing.Point(89, 80);
            this.txtcodeReam.Name = "txtcodeReam";
            this.txtcodeReam.Size = new System.Drawing.Size(181, 21);
            this.txtcodeReam.TabIndex = 5;
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(53, 121);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(75, 23);
            this.bntOK.TabIndex = 6;
            this.bntOK.Text = "确定(&D)";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // txtEsce
            // 
            this.txtEsce.Location = new System.Drawing.Point(178, 121);
            this.txtEsce.Name = "txtEsce";
            this.txtEsce.Size = new System.Drawing.Size(75, 23);
            this.txtEsce.TabIndex = 7;
            this.txtEsce.Text = "取消(&F)";
            this.txtEsce.UseVisualStyleBackColor = true;
            this.txtEsce.Click += new System.EventHandler(this.txtEsce_Click);
            // 
            // frmdictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 159);
            this.Controls.Add(this.txtEsce);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.txtcodeReam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodName);
            this.Controls.Add(this.txtcodeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌曲类型信息";
            this.Load += new System.EventHandler(this.frmdictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodeID;
        private System.Windows.Forms.TextBox txtcodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodeReam;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button txtEsce;
    }
}