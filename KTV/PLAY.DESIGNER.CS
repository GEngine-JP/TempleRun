namespace KTV
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bntStop = new System.Windows.Forms.Button();
            this.bntExce = new System.Windows.Forms.Button();
            this.bntZan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(498, 271);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(140, 279);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(75, 23);
            this.bntStop.TabIndex = 1;
            this.bntStop.Text = "停止(&S)";
            this.bntStop.UseVisualStyleBackColor = true;
            this.bntStop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bntExce
            // 
            this.bntExce.Location = new System.Drawing.Point(343, 279);
            this.bntExce.Name = "bntExce";
            this.bntExce.Size = new System.Drawing.Size(75, 23);
            this.bntExce.TabIndex = 2;
            this.bntExce.Text = "退出(&E)";
            this.bntExce.UseVisualStyleBackColor = true;
            this.bntExce.Click += new System.EventHandler(this.bntExce_Click);
            // 
            // bntZan
            // 
            this.bntZan.Location = new System.Drawing.Point(240, 279);
            this.bntZan.Name = "bntZan";
            this.bntZan.Size = new System.Drawing.Size(75, 23);
            this.bntZan.TabIndex = 3;
            this.bntZan.Text = "暂停(&K)";
            this.bntZan.UseVisualStyleBackColor = true;
            this.bntZan.Click += new System.EventHandler(this.bntZan_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 304);
            this.Controls.Add(this.bntZan);
            this.Controls.Add(this.bntExce);
            this.Controls.Add(this.bntStop);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Play";
            this.Text = "播放音乐";
            this.Load += new System.EventHandler(this.frmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.Button bntExce;
        private System.Windows.Forms.Button bntZan;
    }
}