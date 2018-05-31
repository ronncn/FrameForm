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
    public partial class DockForm : ZForm
    {
        private MainForm m_form;        //传入的主窗体
        private DockStyle m_ds;         //传入的停靠位置

        public DockForm()
        {
            InitializeComponent();
        }

        public DockForm(MainForm form)
        {
            InitializeComponent();
            m_form = form;
        }

        public DockForm(MainForm form,DockStyle ds)
        { 
            InitializeComponent();
            m_form = form;
            m_ds = ds;
        }
        /// <summary>
        /// 重载窗体显示
        /// </summary>
        /// <param name="form">传入的主窗体</param>
        /// <param name="dockstyle">传入停靠的位置</param>
        /// <param name="panel">传入停靠的内容</param>
        public void Show(MainForm form, DockStyle dockstyle, Panel panel)
        {
            DockPanel dp = new DockPanel(form);
            form.MainContent.Controls.Add(dp);
            dp.tempPanel = panel;
            dp.DockPanelTitle = this.Title;
            dp.content.Controls.Add(this.viewPanels);
            dp.slideDockStyle = dockstyle;
            dp.Dock = dockstyle;
            dp.Focus();
            var list = GetAllControls(dp);
            foreach(Control c in list)
            {
                c.Click += new System.EventHandler(this.DockForm_Click);
            }
        }

        public List<Control> GetAllControls(Control control)
        {
            var list = new List<Control>();
            foreach (Control con in control.Controls)
            {
                list.Add(con);
                if (con.Controls.Count > 0)
                {
                    list.AddRange(GetAllControls(con));
                }
            }
            return list;
        }

        private void DockForm_Click(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            con.Focus();
        }

        private void DockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(m_form != null)
            {
                m_form.createDockPanel(this, m_ds);
            }
        }

        private void DockForm_Activated(object sender, EventArgs e)
        {
            if(m_form != null)
            {
                this.TitleBcakColor = m_form.formTitleBackColor;
                this.TitleColor = Color.White;
            }
        }

        private void DockForm_Deactivate(object sender, EventArgs e)
        {
            if (m_form!=null)
            {
                this.TitleBcakColor = m_form.formGetFocus;
                this.TitleColor = Color.White;
            }
        }
    }
}
