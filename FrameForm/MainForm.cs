using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameForm.Skin
{
    public partial class MainForm : ZForm
    {
        //声明变量
        public Color formTitleBackColor = Color.FromArgb(54,78,111);
        public Color formGetFocus = Color.FromArgb(255, 242, 157);
        public Color formBackColor = Color.FromArgb(214, 219, 233);
        public Color formStateBcakColor = Color.FromArgb(0, 122, 204);


        public MainForm()
        {
            InitializeComponent();
            this.dockTab1.parentForm = this;
            this.TitleBcakColor = formBackColor;
            this.menuStrip1.BackColor = formBackColor;
        }

        //用于DockPanel生成DockForm
        public void createDockForm(DockForm df, DockPanel dp, Point point)
        {
            df.Title = dp.DockPanelTitle;
            df.StartPosition = FormStartPosition.Manual;
            df.Location = point;
            df.Size = dp.Size;
            df.viewPanels.Controls.Add(dp.tempPanel);
            df.Show();
        }

        //用于DockForm生成DockPanel
        public void createDockPanel(DockForm df, DockStyle ds)
        {
            df.Show(this,ds,df.viewPanels);
        }

        //窗体MainForm加载事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show(this,DockStyle.Left,f1.viewPanels);
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            foreach(Control c in viewPanels.Controls)
            {
                if(c is DockPanel)
                {
                    DockPanel c1 = (DockPanel)c;
                    c1.DockPanelIsFocus = false;
                }
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dockTab1.AddTab();
        }
    }
}
