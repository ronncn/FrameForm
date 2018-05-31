namespace FrameForm.Skin
{
    partial class tab
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TabCloseBtn = new System.Windows.Forms.Button();
            this.TabTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TabCloseBtn
            // 
            this.TabCloseBtn.BackgroundImage = global::FrameForm.Properties.Resources.close;
            this.TabCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabCloseBtn.FlatAppearance.BorderSize = 0;
            this.TabCloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.TabCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabCloseBtn.Location = new System.Drawing.Point(76, 3);
            this.TabCloseBtn.Name = "TabCloseBtn";
            this.TabCloseBtn.Size = new System.Drawing.Size(20, 20);
            this.TabCloseBtn.TabIndex = 3;
            this.TabCloseBtn.UseVisualStyleBackColor = true;
            this.TabCloseBtn.Click += new System.EventHandler(this.TabCloseBtn_Click);
            // 
            // TabTitleLabel
            // 
            this.TabTitleLabel.Enabled = false;
            this.TabTitleLabel.Location = new System.Drawing.Point(5, 7);
            this.TabTitleLabel.Name = "TabTitleLabel";
            this.TabTitleLabel.Size = new System.Drawing.Size(41, 12);
            this.TabTitleLabel.TabIndex = 2;
            this.TabTitleLabel.Text = "label1";
            // 
            // tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TabCloseBtn);
            this.Controls.Add(this.TabTitleLabel);
            this.Name = "tab";
            this.Size = new System.Drawing.Size(100, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TabCloseBtn;
        private System.Windows.Forms.Label TabTitleLabel;
    }
}
