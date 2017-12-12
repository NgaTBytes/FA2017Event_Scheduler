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
        public bool admin { get; set; }
       
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

        private void btnExecute_Click(object sender, EventArgs e)
        {

            //data grid table is hidden until selection made
            this.dgvListView.Visible = true;

            this.dgvListView.Columns["EventNameForm2"].Visible = true;
            this.dgvListView.Columns["LocationForm2"].Visible = true;
            this.dgvListView.Columns["StartDateForm2"].Visible = true;
            this.dgvListView.Columns["EndDateForm2"].Visible = true;
            this.dgvListView.Columns["StartTimeForm2"].Visible = true;
            this.dgvListView.Columns["EndTimeForm2"].Visible = true;
            this.dgvListView.Columns["StatusForm2"].Visible = true;
            this.dgvListView.Columns["NotesForm2"].Visible = true;
            this.dgvListView.Columns["DescriptionForm2"].Visible = true;
            this.dgvListView.Columns["AttendeesForm2"].Visible = true;

            if (!chkEventName.Checked)
                {
                    this.dgvListView.Columns["EventNameForm2"].Visible = false;
                }
                if (!chkLocation.Checked)
                {
                    this.dgvListView.Columns["LocationForm2"].Visible = false;
                }
                if (!chkStartDate.Checked)
                {
                    this.dgvListView.Columns["StartDateForm2"].Visible = false;
                }
                if (!chkEndDate.Checked)
                {
                    this.dgvListView.Columns["EndDateForm2"].Visible = false;
                }
                if (!chkStartTime.Checked)
                {
                    this.dgvListView.Columns["StartTimeForm2"].Visible = false;
                }
                if (!chkEndTime.Checked)
                {
                    this.dgvListView.Columns["EndTimeForm2"].Visible = false;
                }
                if (!chkStatus.Checked)
                {
                    this.dgvListView.Columns["StatusForm2"].Visible = false;
                }
                if (!chkNotes.Checked)
                {
                    this.dgvListView.Columns["NotesForm2"].Visible = false;
                }
                if (!chkDescription.Checked)
                {
                    this.dgvListView.Columns["DescriptionForm2"].Visible = false;
                }
                if (!chkRegisteredMaxAttendees.Checked)
                {
                    this.dgvListView.Columns["AttendeesForm2"].Visible = false;
                }
            
            
            




            //DataTable viewSelection = new DataTable();
            //int[] whatsClicked = new int[10];

            //for (int i = 0; i < isChecked.Length; i++)
            //{
            //    isChecked[i] = false;
            //}


            //if (chkEventName.Checked)
            //{
            //    isChecked[0] = true;
            //}
            //if (chkLocation.Checked)
            //{
            //    isChecked[1] = true;
            //}
            //if (chkStartDate.Checked)
            //{
            //    isChecked[2] = true;
            //}
            //if (chkEndDate.Checked)
            //{
            //    isChecked[3] = true;
            //}
            //if (chkStartTime.Checked)
            //{
            //    isChecked[4] = true;
            //}
            //if (chkEndTime.Checked)
            //{
            //    isChecked[5] = true;
            //}
            //if (chkStatus.Checked)
            //{
            //    isChecked[6] = true;
            //}
            //if (chkNotes.Checked)
            //{
            //isChecked[7] = true;
            //}
            //if (chkDescription.Checked)
            //{
            //    isChecked[8] = true;
            //}
            //if (chkRegisteredMaxAttendees.Checked)
            //{
            //    isChecked[9] = true;
            //}
            //ListView listview = new ListView();
            //listview.ShowDialog();



        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
        }

        

        private void tabTab_Enter(object sender, EventArgs e)
        {
            if (admin == true)
            {
                MessageBox.Show("success");
            }
        }
    }
}
