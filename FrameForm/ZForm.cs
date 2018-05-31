using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FrameForm.Skin
{
    public partial class ZForm : Form
    {
        public new FormBorderStyle FormBorderStyle
        {
            get
            {
                return base.FormBorderStyle;
            }
            set
            {
                base.FormBorderStyle = value;
            }
        }

        #region 隐藏父类的属性，使其不可见
        [Browsable(false)]
        public new string Text
        {
            get
            {
                return titlelabel.Text;
            }
            set
            {

            }
        }

        [Browsable(false)]
        public new bool ControlBox
        {
            get
            {
                return false;
            }
            set
            {
                base.ControlBox = false;
            }
        }
        #endregion

        //[Description("The image associated with the control"), Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题"), Category("标题栏")]
        public string Title
        {
            get
            {
                return titlelabel.Text;
            }
            set
            {
                titlelabel.Text = value;
            }
        }
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("标题字体样式"), Category("标题栏")]
        public Font TitleFont
        {
            get { return titlelabel.Font; }
            set { titlelabel.Font = value; }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("标题字体颜色"), Category("标题栏")]
        public Color TitleColor
        {
            get { return titlelabel.ForeColor; }
            set { titlelabel.ForeColor = value; }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体颜色"), Category("标题栏")]
        public Color TitleBcakColor
        {
            get { return titlepanel.BackColor; }
            set { titlepanel.BackColor = value; }
        }

        private bool _isShow = true;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("状态栏显示"), Category("状态栏")]
        public bool StateIsShow
        {
            get { return _isShow; }
            set { if (_isShow != value) { _isShow = value; isShowChanged(); } }
        }

        private void isShowChanged()
        {
            if (StateIsShow)
            {
                statePanel.Visible = true;
            }
            else
            {
                statePanel.Visible = false;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("状态栏背景颜色"), Category("状态栏")]
        public Color StateBackColor
        {
            get { return statePanel.BackColor; }
            set { statePanel.BackColor = value; }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("状态栏状态文字"), Category("状态栏")]
        public string StateText
        {
            get { return stateLabel.Text; }
            set { stateLabel.Text = value; }
        }
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("状态栏文字颜色"), Category("状态栏")]
        public Color StateTextColor
        {
            get { return stateLabel.ForeColor; }
            set { stateLabel.ForeColor = value; }
        }

        //最大值属性设置
        public new bool MaximizeBox
        {
            get
            {
                return titlepanel.Contains(button2);
            }
            set
            {
                if (!value)
                {
                    titlepanel.Controls.Remove(button2);
                }
                else if (!titlepanel.Contains(button2))
                {
                    titlepanel.Controls.Add(button2);
                }
            }
        }

        //最小值属性设置
        public new bool MinimizeBox
        {
            get
            {
                return titlepanel.Contains(button1);
            }
            set
            {
                if (!value)
                {
                    titlepanel.Controls.Remove(button1);
                }
                else if (!titlepanel.Contains(button1))
                {
                    titlepanel.Controls.Add(button1);
                }
            }
        }

        //图标设置

        private void onTitlePaint()
        {
            if(this.ShowIcon)
            {
                Graphics gIcon = titleIcon.CreateGraphics();
                Rectangle rect = new Rectangle(5, 5, 22, 22);
                gIcon.DrawIcon(Icon, rect);
                gIcon.Dispose();
            }
            else
            {
                titleIcon.Visible = false;
            }
            Graphics g = titlepanel.CreateGraphics();
            string title = this.titlelabel.Text;
            Font font = this.titlelabel.Font;
            SolidBrush brush = new SolidBrush(titlelabel.ForeColor);
            PointF point = new PointF(titlelabel.Location.X + 2 , titlelabel.Location.Y + 9);
            g.DrawString(title, font, brush, point);
            titlelabel.Visible = false;
        }

        public ZForm()
        {
            InitializeComponent();
            ResetTitlePanel();
            this.titlelabel.Enabled = false;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public MainForm mainForm;
        public ZForm(MainForm form)
        {
            InitializeComponent();
            ResetTitlePanel();
            this.titlelabel.Enabled = false;
            mainForm = form;
        }

        private void ResetTitlePanel()
        {
            base.ControlBox = false;
            base.Text = null;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(button3, "关闭");
            button2.Size = button3.Size;
            toolTip.SetToolTip(button2, "最大化还原");
            button1.Size = button3.Size;
            toolTip.SetToolTip(button1, "最小化");
        }

        //Code highlighting produced by Actipro CodeHighlighter(freeware)
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //设置三个按钮的点击事件
        private void Titlebutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "close":
                    {
                        this.Close();
                        break;
                    }
                case "max":
                    {
                        if (this.WindowState == FormWindowState.Maximized)
                        {
                            this.WindowState = FormWindowState.Normal;
                            this.button2.BackgroundImage = global::FrameForm.Properties.Resources.max_1;
                        }
                        else
                        {
                            this.WindowState = FormWindowState.Maximized;
                            this.button2.BackgroundImage = global::FrameForm.Properties.Resources.max_0;
                        }
                        break;
                    }
                case "min":
                    {
                        if (this.WindowState != FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }
                        break;
                    }
            }
        }

        private void titlepanel_DoubleClick(object sender, EventArgs e)
        {
            if (titlepanel.Contains(button2))
            {
                button2.PerformClick();
            }
        }

        private const int WM_NNCLBUTTONDOWN = 0XA1;   //定义鼠标左键按下
        private const int HTCAPTION = 2;

        //申明程序中所Windows的API函數
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        bool unlock = false;

        private void titlepanel_Down(object sender,MouseEventArgs e)
        {
            unlock = true;
        }

        private void rightBottomPanel_Down(object sender,MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage((int)this.Handle, 0x0112, 0xf008, 0);
        }

        private void titlepanel_Move(object sender, MouseEventArgs e)
        {
            if(unlock)
            {
                //為當前的應用程序釋放鼠標鋪獲
                ReleaseCapture();
                //發送消息﹐讓系統誤以為在标题栏上按下鼠標
                SendMessage((int)this.Handle, 0x0112, 0xf012, 0);
            }
        }
        private void titlepanel_Up(object sender, MouseEventArgs e)
        {
            unlock = false;
        }
        
        private void ZForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                //this.notifyIcon1.Visible = true;
                //this.Hide();
                //this.ShowInTaskbar = false;
                this.stateRightBottom.Visible = false;
            }
            else
            {
                this.stateRightBottom.Visible = true;
            }
        }

        private void titlepanel_Paint(object sender, PaintEventArgs e)
        {
            onTitlePaint();
        }

        private void ZForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }

    class NoFocusCueButton : System.Windows.Forms.Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                // 获得焦点的时候什么都不做  
                return false;
            }
        }
    }
}
