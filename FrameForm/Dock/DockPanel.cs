using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameForm.Skin
{
    public partial class DockPanel : UserControl
    {
        public Color InitialBackColor;    //初始化的标题背景颜色
        public Panel tempPanel;           //传入临时的Panel
        private DockStyle _slideDockStyle = DockStyle.Left;   //属性--停靠的的位置
        private bool isDown = false;        //鼠标按下开关
        private bool unlock = false;        //按下后小锁
        private Point startPoint;           //鼠标按下的起始点
        private DockForm dd;                //生成的DockForm窗体
        private Point point;                //窗体生成的起始点
        private MainForm dpForm;          //传入主题窗口
        private DockStyle dockstyle;       //传入的停靠位置
        private bool isClick = false;       //侧栏点击收缩开关
        private int PanelWidth = 0;         //记录侧栏收缩之前的宽度
        private bool _IsFocus = false;      //获得焦点属性的初始值

        public DockPanel()
        {
            InitializeComponent();
            InitialBackColor = this.DockPanelTitleBackColor;
        }

        public DockPanel(MainForm form)
        {
            InitializeComponent();
            dpForm = form;
            DockPanelTitleBackColor = form.formTitleBackColor;
            DockPanelFocusTitleBackColor = form.formGetFocus;
            this.tabBtn.BackColor = form.formTitleBackColor;
            this.slidePanel.BackColor = form.formTitleBackColor;
            InitialBackColor = this.DockPanelTitleBackColor;
        }

#region DockPanel属性的设置
        //DockPanel的标题
        public string DockPanelTitle
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; this.tabBtn.Text = value; }
        }
        //DockPanel标题的背景颜色
        public Color DockPanelTitleBackColor
        {
            get { return this.panel1.BackColor; }
            set { this.panel1.BackColor = value; }
        }
        //DockPanel获得焦点的标题背景颜色
        private Color _dpftbc;
        public Color DockPanelFocusTitleBackColor
        {
            get { return _dpftbc; }
            set { _dpftbc = value; }
        }
        //DockPanel标题字体颜色
        public Color DockPanelTitleForeColor
        {
            get { return this.label1.ForeColor; }
            set { this.label1.ForeColor = value; }
        }
        //DockPanel获得焦点的标题字体颜色
        private Color _dpftfc;
        public Color DockPanelFocusTitleForeColor
        {
            get { return _dpftfc; }
            set { _dpftfc = value; }
        }
        //DockPanel侧栏停靠的位置
        public DockStyle slideDockStyle
        {
            get { return _slideDockStyle; }
            set {if (_slideDockStyle != value) { _slideDockStyle = value; SlideDockStyleChanged(); } }
        }
        //DockPanel是否获得焦点
        public bool DockPanelIsFocus
        {
            get { return _IsFocus; }
            set { if (_IsFocus != value) { _IsFocus = value; DockPanelIsFocusChanged(); } }
        }
        //DockPanel侧栏停靠位置改变事件
        private void SlideDockStyleChanged()
        {
            this.slidePanel.Dock = slideDockStyle;
        }
        //DockPanel焦点改变事件
        private void DockPanelIsFocusChanged()
        {
            if(DockPanelIsFocus)
            {
                this.panel1.BackColor = dpForm.formGetFocus;
                this.tabBtn.BackColor = dpForm.formGetFocus;
                this.label1.ForeColor = Color.Black;
                this.tabBtn.ForeColor = Color.Black;
            }
            else
            {
                this.panel1.BackColor = InitialBackColor;
                this.tabBtn.BackColor = InitialBackColor;
                this.label1.ForeColor = Color.White;
                this.tabBtn.ForeColor = Color.White;
            }
        }
#endregion

#region panel1的按下、移动、抬起
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            unlock = true;
            startPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDown)
            {
                point = new Point(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
                if (unlock)
                {
                    this.Visible = false;
                    dd = new DockForm(dpForm,this.Dock);
                    dpForm.createDockForm(dd, this, point);
                    unlock = false;
                }
                else
                {
                    dd.Left = point.X;
                    dd.Top = point.Y;
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            unlock = false;
            if(dd!=null)
            {
                this.Dispose();
            }
        }
        #endregion
        private void slideDock()
        {
            switch(this.Dock)
            {
                case DockStyle.Left:
                    slideDockStyle = DockStyle.Left;
                    break;
                case DockStyle.Right:
                    slideDockStyle = DockStyle.Right;
                    break;
                default:
                    break;
            }
        }

        private void FocusClick(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > this.Width - 5 && e.X <= this.Width || e.X >= 0 && e.X < 5)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
            dockstyle = this.Dock;
            switch (dockstyle)
            {
                case DockStyle.Left:
                    if(isDown)
                    {
                        this.Size = new Size(e.X,this.Height);
                    }
                    break;
                case DockStyle.Right:
                    if (isDown)
                    {
                        //int cur = 0;
                        this.Width += -(Cursor.Position.X - startPoint.X);
                        startPoint.X = Cursor.Position.X;
                    }
                    break;
                default:
                    break;
            }
        }

        private void DockPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.SizeWE)
            {
                isDown = true;
            }
            startPoint = Cursor.Position;
        }

        private void DockPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void DockPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void DockPanel_Enter(object sender, EventArgs e)
        {
            DockPanelIsFocus = true;
        }

        private void DockPanel_Leave(object sender, EventArgs e)
        {
            DockPanelIsFocus = false;
        }

        private void tabBtn_Click(object sender, EventArgs e)
        {
            isClick = !isClick;
            if (isClick)
            {
                PanelWidth = this.panel1.Width;
                this.panel1.Visible = false;
                this.content.Visible = false;
                this.Width -= this.panel1.Width;
            }
            else
            {
                this.Width += PanelWidth;
                this.panel1.Visible = true;
                this.content.Visible = true;
            }
        }
    }
}
