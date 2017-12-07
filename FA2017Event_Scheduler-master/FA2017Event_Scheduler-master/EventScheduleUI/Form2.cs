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

            //DataTable viewSelection = new DataTable();
            //this.dgvViewSelection.Columns["EventName"].Visible = false;
            //int[] whatsClicked = new int[10];
            //int counter = 0;
            //if(chkEventName.Checked)
            //{
            //    whatsClicked[counter] = 1;
            //    counter++;
            //    viewSelection.Columns.Add("Event Name",typeof (string));

            //}
            //if (chkLocation.Checked)
            //{
            //    whatsClicked[counter] = 2;
            //    counter++;
            //    viewSelection.Columns.Add("Location", typeof(string));
            //}
            //if (chkStartDate.Checked)
            //{
            //    whatsClicked[counter] = 3;
            //    counter++;
            //    viewSelection.Columns.Add("Start Date", typeof(DateTime));
            //}
            //if (chkEndDate.Checked)
            //{
            //    whatsClicked[counter] = 4;
            //    counter++;
            //    viewSelection.Columns.Add("End Date", typeof(DateTime));
            //}
            //if (chkStartTime.Checked)
            //{
            //    whatsClicked[counter] = 5;
            //    counter++;
            //    viewSelection.Columns.Add("Start Time", typeof(DateTime));
            //}
            //if (chkEndTime.Checked)
            //{
            //    whatsClicked[counter] = 6;
            //    counter++;
            //    viewSelection.Columns.Add("End Time", typeof(DateTime));

            //}
            //if (chkStatus.Checked)
            //{
            //    whatsClicked[counter] = 7;
            //    counter++;
            //    viewSelection.Columns.Add("Status", typeof(string));
            //}
            //if (chkNotes.Checked)
            //{
            //    whatsClicked[counter] = 8;
            //    counter++;
            //    viewSelection.Columns.Add("Notes", typeof(string));
            //}
            //if (chkDescription.Checked)
            //{
            //    whatsClicked[counter] = 9;
            //    counter++;
            //    viewSelection.Columns.Add("Description", typeof(string));
            //}
            //if (chkRegisteredMaxAttendees.Checked)
            //{
            //    whatsClicked[counter] = 10;
            //    counter++;
            //    viewSelection.Columns.Add("Registered/Max Attendees", typeof(int));
            //}
            //for (int i=0; i < whatsClicked.Length; i++)
            //{

            //}

        }
    }
}
