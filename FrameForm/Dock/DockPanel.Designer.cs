namespace FrameForm.Skin
{
    partial class DockPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shrinkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.tabBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.slidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.shrinkBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(34, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // shrinkBtn
            // 
            this.shrinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shrinkBtn.BackgroundImage = global::FrameForm.Properties.Resources.向左__2_;
            this.shrinkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shrinkBtn.FlatAppearance.BorderSize = 0;
            this.shrinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shrinkBtn.Location = new System.Drawing.Point(213, 7);
            this.shrinkBtn.Name = "shrinkBtn";
            this.shrinkBtn.Size = new System.Drawing.Size(18, 18);
            this.shrinkBtn.TabIndex = 1;
            this.shrinkBtn.UseVisualStyleBackColor = true;
            this.shrinkBtn.Click += new System.EventHandler(this.tabBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "资源管理器";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.Control;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(34, 32);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(239, 423);
            this.content.TabIndex = 1;
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slidePanel.Controls.Add(this.tabBtn);
            this.slidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePanel.Location = new System.Drawing.Point(3, 0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(31, 455);
            this.slidePanel.TabIndex = 2;
            // 
            // tabBtn
            // 
            this.tabBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tabBtn.FlatAppearance.BorderSize = 0;
            this.tabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabBtn.ForeColor = System.Drawing.Color.White;
            this.tabBtn.Location = new System.Drawing.Point(0, 0);
            this.tabBtn.Name = "tabBtn";
            this.tabBtn.Padding = new System.Windows.Forms.Padding(5);
            this.tabBtn.Size = new System.Drawing.Size(31, 93);
            this.tabBtn.TabIndex = 0;
            this.tabBtn.Text = "123";
            this.tabBtn.UseVisualStyleBackColor = false;
            this.tabBtn.Click += new System.EventHandler(this.tabBtn_Click);
            // 
            // DockPanel
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slidePanel);
            this.Name = "DockPanel";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Size = new System.Drawing.Size(276, 455);
            this.Enter += new System.EventHandler(this.DockPanel_Enter);
            this.Leave += new System.EventHandler(this.DockPanel_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DockPanel_MouseDown);
            this.MouseLeave += new System.EventHandler(this.DockPanel_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DockPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DockPanel_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.slidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Button tabBtn;
        private System.Windows.Forms.Button shrinkBtn;
    }
}
