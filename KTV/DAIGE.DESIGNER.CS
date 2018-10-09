namespace KTV
{
    partial class DaiGe
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
            this.bntPing = new System.Windows.Forms.Button();
            this.bntAutor = new System.Windows.Forms.Button();
            this.bntPlay = new System.Windows.Forms.Button();
            this.lvPlay = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.bntSelect = new System.Windows.Forms.Button();
            this.bntEsce = new System.Windows.Forms.Button();
            this.bntName = new System.Windows.Forms.Button();
            this.bntNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntPing
            // 
            this.bntPing.BackgroundImage = global::KTV.Properties.Resources.拼音点歌;
            this.bntPing.Location = new System.Drawing.Point(41, 103);
            this.bntPing.Name = "bntPing";
            this.bntPing.Size = new System.Drawing.Size(108, 46);
            this.bntPing.TabIndex = 4;
            this.bntPing.UseVisualStyleBackColor = true;
            this.bntPing.Click += new System.EventHandler(this.bntPing_Click);
            // 
            // bntAutor
            // 
            this.bntAutor.BackgroundImage = global::KTV.Properties.Resources.明星点歌;
            this.bntAutor.Location = new System.Drawing.Point(41, 180);
            this.bntAutor.Name = "bntAutor";
            this.bntAutor.Size = new System.Drawing.Size(108, 46);
            this.bntAutor.TabIndex = 5;
            this.bntAutor.UseVisualStyleBackColor = true;
            this.bntAutor.Click += new System.EventHandler(this.bntAutor_Click);
            // 
            // bntPlay
            // 
            this.bntPlay.BackgroundImage = global::KTV.Properties.Resources.播放;
            this.bntPlay.Location = new System.Drawing.Point(313, 253);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(108, 46);
            this.bntPlay.TabIndex = 6;
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // lvPlay
            // 
            this.lvPlay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPlay.FullRowSelect = true;
            this.lvPlay.GridLines = true;
            this.lvPlay.Location = new System.Drawing.Point(170, 29);
            this.lvPlay.Name = "lvPlay";
            this.lvPlay.Size = new System.Drawing.Size(389, 208);
            this.lvPlay.TabIndex = 7;
            this.lvPlay.UseCompatibleStateImageBehavior = false;
            this.lvPlay.View = System.Windows.Forms.View.Details;
            this.lvPlay.Click += new System.EventHandler(this.lvPlay_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲编号";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌曲各称";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "歌手";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "歌曲类型";
            this.columnHeader4.Width = 80;
            // 
            // bntSelect
            // 
            this.bntSelect.BackgroundImage = global::KTV.Properties.Resources.选择;
            this.bntSelect.Location = new System.Drawing.Point(170, 253);
            this.bntSelect.Name = "bntSelect";
            this.bntSelect.Size = new System.Drawing.Size(108, 46);
            this.bntSelect.TabIndex = 8;
            this.bntSelect.UseVisualStyleBackColor = true;
            this.bntSelect.Click += new System.EventHandler(this.bntSelect_Click);
            // 
            // bntEsce
            // 
            this.bntEsce.BackgroundImage = global::KTV.Properties.Resources.退出;
            this.bntEsce.Location = new System.Drawing.Point(451, 253);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(108, 46);
            this.bntEsce.TabIndex = 9;
            this.bntEsce.UseVisualStyleBackColor = true;
            this.bntEsce.Click += new System.EventHandler(this.bntEsce_Click);
            // 
            // bntName
            // 
            this.bntName.BackgroundImage = global::KTV.Properties.Resources.歌名点歌;
            this.bntName.Location = new System.Drawing.Point(41, 253);
            this.bntName.Name = "bntName";
            this.bntName.Size = new System.Drawing.Size(108, 46);
            this.bntName.TabIndex = 10;
            this.bntName.UseVisualStyleBackColor = true;
            this.bntName.Click += new System.EventHandler(this.bntName_Click);
            // 
            // bntNumber
            // 
            this.bntNumber.BackgroundImage = global::KTV.Properties.Resources.数字点歌;
            this.bntNumber.Location = new System.Drawing.Point(41, 29);
            this.bntNumber.Name = "bntNumber";
            this.bntNumber.Size = new System.Drawing.Size(108, 46);
            this.bntNumber.TabIndex = 3;
            this.bntNumber.UseVisualStyleBackColor = true;
            this.bntNumber.Click += new System.EventHandler(this.bntNumber_Click);
            // 
            // frmDaiGe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTV.Properties.Resources.背景图;
            this.ClientSize = new System.Drawing.Size(586, 341);
            this.Controls.Add(this.bntName);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntSelect);
            this.Controls.Add(this.lvPlay);
            this.Controls.Add(this.bntPlay);
            this.Controls.Add(this.bntAutor);
            this.Controls.Add(this.bntPing);
            this.Controls.Add(this.bntNumber);
            this.Name = "frmDaiGe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "卡拉OK点歌系统";
            this.Load += new System.EventHandler(this.frmDaiGe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntNumber;
        private System.Windows.Forms.Button bntPing;
        private System.Windows.Forms.Button bntAutor;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button bntSelect;
        private System.Windows.Forms.Button bntEsce;
        private System.Windows.Forms.Button bntName;
        public System.Windows.Forms.ListView lvPlay;

    }
}