using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventScheduleUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //tabTab.TabPages.Remove(tabListView);
            string[,] exampleArray = new string[2, 11];
            for(int i = 0; i < exampleArray.GetLength(0); i++)
            {
                for (int j = 0; j < exampleArray.GetLength(1); j++)
                {
                    exampleArray[i, j] = "3";
                }
            }
        }

        private void tabListView_Click(object sender, EventArgs e)
        {
            //If admin show tabListView
            // if participant hide tabListView
            tabFull.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
