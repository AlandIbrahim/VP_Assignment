using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_LEGACY
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm CF=new ChildForm();
            CF.MdiParent = this;
            CF.MainMenuStrip.Visible = false;
            CF.Show();
        }

        private void newFreeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm CF = new ChildForm();
            CF.Show();
        }

        private void closeAllMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)
            {
                item.Close();   
            }
        }

        private void verticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);    
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
