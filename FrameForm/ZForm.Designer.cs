namespace FrameForm.Skin
{
    partial class ZForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZForm));
            this.titlepanel = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.titleIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new FrameForm.Skin.NoFocusCueButton();
            this.button2 = new FrameForm.Skin.NoFocusCueButton();
            this.button3 = new FrameForm.Skin.NoFocusCueButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statePanel = new System.Windows.Forms.Panel();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateRightBottom = new System.Windows.Forms.Panel();
            this.viewPanels = new System.Windows.Forms.Panel();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            this.statePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlepanel
            // 
            this.titlepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titlepanel.Controls.Add(this.titlelabel);
            this.titlepanel.Controls.Add(this.titleIcon);
            this.titlepanel.Controls.Add(this.button1);
            this.titlepanel.Controls.Add(this.button2);
            this.titlepanel.Controls.Add(this.button3);
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(2, 2);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(469, 32);
            this.titlepanel.TabIndex = 0;
            this.titlepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlepanel_Paint);
            this.titlepanel.DoubleClick += new System.EventHandler(this.titlepanel_DoubleClick);
            this.titlepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlepanel_Down);
            this.titlepanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlepanel_Move);
            this.titlepanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlepanel_Up);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titlelabel.Location = new System.Drawing.Point(32, 0);
            this.titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Padding = new System.Windows.Forms.Padding(9);
            this.titlelabel.Size = new System.Drawing.Size(59, 30);
            this.titlelabel.TabIndex = 3;
            this.titlelabel.Text = "label1";
            // 
            // titleIcon
            // 
            this.titleIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleIcon.Location = new System.Drawing.Point(0, 0);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(32, 32);
            this.titleIcon.TabIndex = 4;
            this.titleIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::FrameForm.Properties.Resources.min;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(364, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Tag = "min";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::FrameForm.Properties.Resources.max_1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(399, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 32);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Tag = "max";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::FrameForm.Properties.Resources.close;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(434, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 32);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Tag = "close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // statePanel
            // 
            this.statePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statePanel.Controls.Add(this.stateLabel);
            this.statePanel.Controls.Add(this.stateRightBottom);
            this.statePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statePanel.Location = new System.Drawing.Point(2, 379);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(469, 22);
            this.statePanel.TabIndex = 5;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(6, 5);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(29, 12);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "状态";
            // 
            // stateRightBottom
            // 
            this.stateRightBottom.BackColor = System.Drawing.Color.Transparent;
            this.stateRightBottom.BackgroundImage = global::FrameForm.Properties.Resources.rb1;
            this.stateRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stateRightBottom.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.stateRightBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.stateRightBottom.Location = new System.Drawing.Point(447, 0);
            this.stateRightBottom.Name = "stateRightBottom";
            this.stateRightBottom.Size = new System.Drawing.Size(22, 22);
            this.stateRightBottom.TabIndex = 3;
            this.stateRightBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightBottomPanel_Down);
            // 
            // viewPanels
            // 
            this.viewPanels.BackColor = System.Drawing.Color.White;
            this.viewPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanels.Location = new System.Drawing.Point(2, 34);
            this.viewPanels.Name = "viewPanels";
            this.viewPanels.Size = new System.Drawing.Size(469, 345);
            this.viewPanels.TabIndex = 6;
            // 
            // ZForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.ControlBox = false;
            this.Controls.Add(this.viewPanels);
            this.Controls.Add(this.titlepanel);
            this.Controls.Add(this.statePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZForm_FormClosing);
            this.Resize += new System.EventHandler(this.ZForm_Resize);
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            this.statePanel.ResumeLayout(false);
            this.statePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.ToolTip toolTip;
        private NoFocusCueButton button3;
        private NoFocusCueButton button2;
        private NoFocusCueButton button1;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Panel stateRightBottom;
        private System.Windows.Forms.Label stateLabel;
        public System.Windows.Forms.Panel viewPanels;
        private System.Windows.Forms.PictureBox titleIcon;
    }
}

