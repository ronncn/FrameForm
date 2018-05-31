using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FrameForm.Skin
{
    public partial class DockTab : UserControl
    {
        private List<tab> tabList = new List<tab>();            //标题栏的链表
        private List<TabPanelContent> panelList = new List<TabPanelContent>();      //标题栏对应的内容链表
        private int _DockTabListNumber;                         //设置标题栏初始个数
        private bool TabIsDown = false;                         //标题栏按下开关
        private bool unlack = false;                            //按下生成form小锁
        private tab this_tab;                                   //点击当前的标题栏
        private Point startPoint;                               //按下标题栏出事位置
        private DockForm df;                                    //生成DockForm
        private Point point;                                    //生成时的位置
        private MainForm m_form;                                //父级窗体
        public Color TabBackColor;
        public Color TabGetFocusBackColor;
        
        public DockTab()
        {
            InitializeComponent();
        }
        public DockTab(MainForm form)
        {
            InitializeComponent();
            m_form = form;
        }

        #region DockTab属性设置
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("标题栏BackColor"), Category("DockTab")]
        public Color DockTabBackColor
        {
            get { return this.TabBox.BackColor; }
            set { this.TabBox.BackColor = value; }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Tab集合数量"), Category("DockTab")]
        public int DockTabListNumber
        {
            get { return _DockTabListNumber; }
            set { _DockTabListNumber = value; createTabList(); }
        }

        private MainForm _parentForm;
        public MainForm parentForm
        {
            get { return _parentForm; }
            set { _parentForm = value;if (m_form == null) { m_form = _parentForm; } }
        }
        #endregion

        private void createTabList()
        {
            if (DockTabListNumber > 0)
            {
                tab[] t = new tab[DockTabListNumber];
                TabPanelContent[] p = new TabPanelContent[DockTabListNumber];
                Color[] color = { Color.FromArgb(197, 213, 203),
                                  Color.FromArgb(159,168,163),
                                  Color.FromArgb(227,224,207),
                                  Color.FromArgb(233,236,229),
                                  Color.FromArgb(176,171,194),
                };
                for (int i = 0; i < DockTabListNumber; i++)
                {
                    t[i] = new tab(this);
                    p[i] = new TabPanelContent();
                    p[i].BackColor = color[i];
                    t[i].TabPanel = p[i];
                    t[i].id = i;
                    t[i].TabTitle = "tab" + (i + 1);
                    t[i].MouseDown += new MouseEventHandler(this.Tab_MouseDown);
                    t[i].MouseMove += new MouseEventHandler(this.Tab_MouseMove);
                    t[i].MouseUp += new MouseEventHandler(this.Tab_MouseUp);
                    t[i].MouseLeave += new EventHandler(this.Tab_MouseUp);
                    t[i].TabIsFocusChangeds += new tab.ChangedEventHandler(this.TabIsFocus_Changed);
                    tabList.Add(t[i]);
                    panelList.Add(p[i]);
                }
            }
            else
            {
                tab tab1 = new tab(this);
                TabPanelContent panel1 = new TabPanelContent();
                tab1.id = 0;
                tab1.TabPanel = panel1;
                tab1.TabTitle = "tab1";
                tab1.MouseDown += new MouseEventHandler(this.Tab_MouseDown);
                tabList.Add(tab1);
                panelList.Add(panel1);
            }
        }

        public void DelTab(tab t)
        {
            if (this.TabBox.Controls.Count == 1)
            {
                MessageBox.Show("您要留一个呀", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.TabBox.Controls.Remove(t);
                tabList.Remove(t);
                this.ContentBox.Controls.Remove(t.TabPanel);
                panelList.Remove(t.TabPanel);
                foreachTabList();
            }
        }

        public void AddTab()
        {
            tab tab = new tab(this);
            TabPanelContent panel = new TabPanelContent();
            tab.TabPanel = panel;
            tab.id = tabList.Last<tab>().id + 1;
            tab.TabTitle = "tab" + (tab.id + 1);
            if(m_form != null)
            {
                tab.BackColor = m_form.formTitleBackColor;
            }
            tab.MouseDown += new MouseEventHandler(this.Tab_MouseDown);
            tab.MouseMove += new MouseEventHandler(this.Tab_MouseMove);
            tab.MouseUp += new MouseEventHandler(this.Tab_MouseUp);
            tab.MouseLeave += new EventHandler(this.Tab_MouseUp);
            tab.TabIsFocusChangeds += new tab.ChangedEventHandler(this.TabIsFocus_Changed);
            tabList.Add(tab);
            panelList.Add(panel);
            foreachTabList();
        }

        private void TabIsFocus_Changed(object sender)
        {
            tab this_tab = (tab)sender;
            if (this_tab.TabIsFocus)
            {
                this_tab.Height += 5;
                this_tab.Top -= 5;
                this_tab.TabBackColor = m_form.formGetFocus; ;
                foreachPanelList();
            }
            else
            {
                this_tab.Height -= 5;
                this_tab.Top = 6;
                this_tab.TabBackColor = m_form.formTitleBackColor;
            }
        }

        private void foreachTabList()
        {
            int index = 0;
            bool isTrue = false;
            foreach (tab t in tabList)
            {
                t.Location = new Point(102 * index, 6);
                if(m_form != null)
                {
                    t.BackColor = m_form.formTitleBackColor;
                }
                this.TabBox.Controls.Add(t);
                index++;
                if (t.TabIsFocus) { isTrue = true; }
            }
            if (!isTrue)
            {
                tabList.First<tab>().TabIsFocus = true;
                tabList.First<tab>().TabBackColor = TabGetFocusBackColor;
            }
        }

        private void Tab_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control c in this.TabBox.Controls)
            {
                if (c is tab)
                {
                    tab c_tab = (tab)c;
                    c_tab.TabIsFocus = false;
                }
            }
            this_tab = (tab)sender;
            this_tab.TabIsFocus = true;
            TabIsDown = true;
            unlack = true;
            startPoint = e.Location;
        }
        //申明程序中所Windows的API函數
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private void Tab_MouseMove(object sender, MouseEventArgs e)
        {
            if (TabIsDown)
            {
                if (e.X - startPoint.X > 5)
                {
                    if (this.TabBox.Controls.Count == 1)
                    {
                        MessageBox.Show("您要留一个呀", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (unlack)
                        {
                            df = new DockForm(m_form);
                            point = new Point(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
                            df.Title = this_tab.TabTitle;
                            df.viewPanels.Controls.Add(this_tab.TabPanel);
                            df.Size = this.Size;
                            df.StartPosition = FormStartPosition.Manual;
                            df.Location = point;
                            this.DelTab(this_tab);
                            df.Show();
                            //為當前的應用程序釋放鼠標鋪獲
                            ReleaseCapture();
                            //發送消息﹐讓系統誤以為在标题栏上按下鼠標
                            SendMessage((int)df.Handle, 0x0112, 0xf012, 0);
                            unlack = false;
                        }
                        else
                        {
                            df.Location = new Point(point.X, point.Y);
                        }
                    }
                }
            }
        }

        private void Tab_MouseUp(object sender, MouseEventArgs e)
        {
            TabIsDown = false;
            unlack = false;
        }
        private void Tab_MouseUp(object sender, EventArgs e)
        {
            TabIsDown = false;
            unlack = false;
        }

        private void foreachPanelList()
        {
            foreach (tab t in tabList)
            {
                if (t.TabIsFocus)
                {
                    t.TabPanel.Dock = DockStyle.Fill;
                    this.ContentBox.Controls.Add(t.TabPanel);
                }
                else
                {
                    this.ContentBox.Controls.Remove(t.TabPanel);
                }
            }
        }

        private void DockTab_Load(object sender, EventArgs e)
        {
            foreachTabList();
        }
    }
}
