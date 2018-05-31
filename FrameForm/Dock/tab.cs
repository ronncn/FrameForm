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
    public partial class tab : UserControl
    {
        private TabPanelContent _tabPanel;
        public Color InitialBackColor;
        DockTab dockTab;
        private bool _TabIsFocus = false;

        public tab()
        {
            InitializeComponent();
        }

        public tab(DockTab dt)
        {
            InitializeComponent();
            dockTab = dt;
            TabBackColor = dt.TabBackColor;
            this.TabTitleLabel.ForeColor = Color.White;
        }

        public int id;

        public string TabTitle
        {
            get { return this.TabTitleLabel.Text; }
            set { this.TabTitleLabel.Text = value; }
        }
        
        public Color TabBackColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public TabPanelContent TabPanel
        {
            get { return _tabPanel; }
            set { _tabPanel = value; }
        }

        //定义delegate
        public delegate void ChangedEventHandler(object sender);
        //用event 关键字声明事件对象
        public event ChangedEventHandler TabIsFocusChangeds;

        public bool TabIsFocus
        {
            get { return _TabIsFocus; }
            set { if (_TabIsFocus != value) { _TabIsFocus = value; onTabIsFocusChanged();  } }
        }

        protected virtual void onTabIsFocusChanged()
        {
            TabIsFocusChangeds(this);
        }

        private void TabCloseBtn_Click(object sender, EventArgs e)
        {
            dockTab.DelTab(this);
        }
    }
}
