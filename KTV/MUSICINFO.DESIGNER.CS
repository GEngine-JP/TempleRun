namespace KTV
{
    partial class Musicinfo
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMusic_code = new System.Windows.Forms.TextBox();
            this.txtMusicC_name = new System.Windows.Forms.TextBox();
            this.txtMusic_Ping = new System.Windows.Forms.TextBox();
            this.txtMusic_filepath = new System.Windows.Forms.TextBox();
            this.cmbMusic_chinse = new System.Windows.Forms.ComboBox();
            this.cmbMusic_Kind = new System.Windows.Forms.ComboBox();
            this.cmbMusic_author = new System.Windows.Forms.ComboBox();
            this.bntOpen = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntEsce = new System.Windows.Forms.Button();
            this.openPath = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "歌手：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "语种：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "路径：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "类型：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "拼音：";
            // 
            // txtMusic_code
            // 
            this.txtMusic_code.Enabled = false;
            this.txtMusic_code.Location = new System.Drawing.Point(71, 13);
            this.txtMusic_code.Name = "txtMusic_code";
            this.txtMusic_code.Size = new System.Drawing.Size(176, 21);
            this.txtMusic_code.TabIndex = 8;
            // 
            // txtMusicC_name
            // 
            this.txtMusicC_name.Location = new System.Drawing.Point(320, 13);
            this.txtMusicC_name.Name = "txtMusicC_name";
            this.txtMusicC_name.Size = new System.Drawing.Size(176, 21);
            this.txtMusicC_name.TabIndex = 9;
            this.txtMusicC_name.TextChanged += new System.EventHandler(this.txtMusicC_name_TextChanged);
            // 
            // txtMusic_Ping
            // 
            this.txtMusic_Ping.Enabled = false;
            this.txtMusic_Ping.Location = new System.Drawing.Point(320, 99);
            this.txtMusic_Ping.Name = "txtMusic_Ping";
            this.txtMusic_Ping.Size = new System.Drawing.Size(176, 21);
            this.txtMusic_Ping.TabIndex = 11;
            // 
            // txtMusic_filepath
            // 
            this.txtMusic_filepath.Enabled = false;
            this.txtMusic_filepath.Location = new System.Drawing.Point(72, 152);
            this.txtMusic_filepath.Multiline = true;
            this.txtMusic_filepath.Name = "txtMusic_filepath";
            this.txtMusic_filepath.Size = new System.Drawing.Size(390, 65);
            this.txtMusic_filepath.TabIndex = 12;
            // 
            // cmbMusic_chinse
            // 
            this.cmbMusic_chinse.FormattingEnabled = true;
            this.cmbMusic_chinse.Items.AddRange(new object[] {
            "国语",
            "英语"});
            this.cmbMusic_chinse.Location = new System.Drawing.Point(72, 99);
            this.cmbMusic_chinse.Name = "cmbMusic_chinse";
            this.cmbMusic_chinse.Size = new System.Drawing.Size(175, 20);
            this.cmbMusic_chinse.TabIndex = 13;
            // 
            // cmbMusic_Kind
            // 
            this.cmbMusic_Kind.FormattingEnabled = true;
            this.cmbMusic_Kind.Location = new System.Drawing.Point(320, 59);
            this.cmbMusic_Kind.Name = "cmbMusic_Kind";
            this.cmbMusic_Kind.Size = new System.Drawing.Size(175, 20);
            this.cmbMusic_Kind.TabIndex = 14;
            // 
            // cmbMusic_author
            // 
            this.cmbMusic_author.FormattingEnabled = true;
            this.cmbMusic_author.Location = new System.Drawing.Point(71, 59);
            this.cmbMusic_author.Name = "cmbMusic_author";
            this.cmbMusic_author.Size = new System.Drawing.Size(175, 20);
            this.cmbMusic_author.TabIndex = 15;
            // 
            // bntOpen
            // 
            this.bntOpen.Location = new System.Drawing.Point(468, 152);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(28, 65);
            this.bntOpen.TabIndex = 16;
            this.bntOpen.Text = "打开";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(143, 223);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 18;
            this.bntAdd.Text = "确定(&D)";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntEsce
            // 
            this.bntEsce.Location = new System.Drawing.Point(266, 223);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(75, 23);
            this.bntEsce.TabIndex = 19;
            this.bntEsce.Text = "取消(&E)";
            this.bntEsce.UseVisualStyleBackColor = true;
            // 
            // openPath
            // 
            this.openPath.FileName = "openFileDialog1";
            // 
            // frmMusicinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 257);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntOpen);
            this.Controls.Add(this.cmbMusic_author);
            this.Controls.Add(this.cmbMusic_Kind);
            this.Controls.Add(this.cmbMusic_chinse);
            this.Controls.Add(this.txtMusic_filepath);
            this.Controls.Add(this.txtMusic_Ping);
            this.Controls.Add(this.txtMusicC_name);
            this.Controls.Add(this.txtMusic_code);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMusicinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌曲信息";
            this.Load += new System.EventHandler(this.frmMusicinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMusic_code;
        private System.Windows.Forms.TextBox txtMusicC_name;
        private System.Windows.Forms.TextBox txtMusic_Ping;
        private System.Windows.Forms.TextBox txtMusic_filepath;
        private System.Windows.Forms.ComboBox cmbMusic_chinse;
        private System.Windows.Forms.ComboBox cmbMusic_Kind;
        private System.Windows.Forms.ComboBox cmbMusic_author;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntEsce;
        private System.Windows.Forms.OpenFileDialog openPath;
    }
}