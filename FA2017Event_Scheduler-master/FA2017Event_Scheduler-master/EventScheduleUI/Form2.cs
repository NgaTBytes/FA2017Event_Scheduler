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
    public partial class Tabs : Form
    {

        public bool[] isChecked = new bool[10];
        public Tabs()
        {
            InitializeComponent();
            //tabTab.TabPages.Remove(tabListView);

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

        public void btnExecute_Click(object sender, EventArgs e)
        {
            
            



            DataTable viewSelection = new DataTable();
            int[] whatsClicked = new int[10];

            for (int i = 0; i < isChecked.Length; i++)
            {
                isChecked[i] = false;
            }


            if (chkEventName.Checked)
            {
                isChecked[0] = true;
            }
            if (chkLocation.Checked)
            {
                isChecked[1] = true;
            }
            if (chkStartDate.Checked)
            {
                isChecked[2] = true;
            }
            if (chkEndDate.Checked)
            {
                isChecked[3] = true;
            }
            if (chkStartTime.Checked)
            {
                isChecked[4] = true;
            }
            if (chkEndTime.Checked)
            {
                isChecked[5] = true;
            }
            if (chkStatus.Checked)
            {
                isChecked[6] = true;
            }
            if (chkNotes.Checked)
            {
                isChecked[7] = true;
            }
            if (chkDescription.Checked)
            {
                isChecked[8] = true;
            }
            if (chkRegisteredMaxAttendees.Checked)
            {
                isChecked[9] = true;
            }
            ListView listview = new ListView();
            listview.ShowDialog();


        }
    }
}
