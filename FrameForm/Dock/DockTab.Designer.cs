namespace FrameForm.Skin
{
    partial class DockTab
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
            this.TabBox = new System.Windows.Forms.Panel();
            this.ContentBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TabBox
            // 
            this.TabBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.TabBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabBox.Location = new System.Drawing.Point(0, 0);
            this.TabBox.Name = "TabBox";
            this.TabBox.Size = new System.Drawing.Size(842, 32);
            this.TabBox.TabIndex = 0;
            // 
            // ContentBox
            // 
            this.ContentBox.BackColor = System.Drawing.Color.SeaShell;
            this.ContentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentBox.Location = new System.Drawing.Point(0, 32);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(842, 497);
            this.ContentBox.TabIndex = 1;
            // 
            // DockTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.TabBox);
            this.Name = "DockTab";
            this.Size = new System.Drawing.Size(842, 529);
            this.Load += new System.EventHandler(this.DockTab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TabBox;
        private System.Windows.Forms.Panel ContentBox;
    }
}
