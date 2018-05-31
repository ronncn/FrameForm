using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameForm
{
    public partial class TabPanelContent : UserControl
    {
        public TabPanelContent()
        {
            InitializeComponent();
            this.panel2.BackColor = this.BackColor;
        }
    }
}
