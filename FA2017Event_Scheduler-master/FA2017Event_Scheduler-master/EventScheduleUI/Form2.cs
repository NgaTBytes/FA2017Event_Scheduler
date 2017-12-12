using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;
namespace EventScheduleUI
{
    public partial class Tabs : Form
    {
       
        SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");
        SqlDataAdapter sda2;
        DataTable dt;

        public bool admin { get; set; }
       
        public Tabs()
        {
            InitializeComponent();
            //tabTab.TabPages.Remove(tabListView);
            SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");
            SqlDataAdapter sda2;
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
            sda2 = new SqlDataAdapter(@"SELECT Events.EventID, Events.EventName, Events.Location, Events.Status, Events.StartDate, Events.EndDate, Events.StartTime, Events.EndTime, Events.AgeRequirement, Events.EventNotes, Events.EventDescription
            FROM Events", connection);
            dt = new DataTable();
            sda2.Fill(dt);
            dgvListView.DataSource = dt;
            //data grid table is hidden until selection made
            this.dgvListView.Visible = true;

            //this.dgvListView.Columns["eventNameDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["locationDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["startDateDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["endDateDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["startTimeDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["endTimeDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["ageRequirementDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["status1DataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["eventNotesDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["eventDescriptionDataGridViewTextBoxColumn"].Visible = true;
            //this.dgvListView.Columns["AttendeesForm2"].Visible = true;
            for(int i = 0; i < this.dgvListView.Columns.Count; i++)
            {
                this.dgvListView.Columns[i].Visible = true;
            }
            int counter = 0;
            foreach (Control control in tabListView.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox temp = control as CheckBox;
                    if (temp.Checked)
                    {
                        counter++;
                    }
                }
            }
            if(counter == 0)
            {
                this.dgvListView.Columns[0].Visible = false;
            }
            //tabListView.Controls.Find("")

            if (!chkEventName.Checked)
            {
                this.dgvListView.Columns[1].Visible = false;
            }
            if (!chkLocation.Checked)
            {
                this.dgvListView.Columns[2].Visible = false;
            }
            if (!chkStartDate.Checked)
            {
                this.dgvListView.Columns[3].Visible = false;
            }
            if (!chkEndDate.Checked)
            {
                this.dgvListView.Columns[4].Visible = false;
            }
            if (!chkStartTime.Checked)
            {
                this.dgvListView.Columns[5].Visible = false;
            }
            if (!chkEndTime.Checked)
            {
                this.dgvListView.Columns[6].Visible = false;
            }
            if (!chkAge.Checked)
            {
                this.dgvListView.Columns[7].Visible = false;
            }
            if (!chkStatus.Checked)
            {
                this.dgvListView.Columns[8].Visible = false;
            }
            if (!chkNotes.Checked)
            {
                this.dgvListView.Columns[9].Visible = false;
            }
            if (!chkDescription.Checked)
            {
                this.dgvListView.Columns[10].Visible = false;
            }
            //if (!chkRegisteredMaxAttendees.Checked)
            //{
            //    this.dgvListView.Columns[11].Visible = false;
            //}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }



        private void tabTab_Enter(object sender, EventArgs e)
        {

        }
        //{
        //    if (admin == false)
        //    {
        //        tabTab.TabPages.Remove(tabListView);
        //    }
        //}

        private void Tabs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet.Events' table. You can move, or remove it, as needed.
            //this.eventsTableAdapter.Fill(this.project1DataSet.Events);

        }

        private void dgvListView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvListView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(sda2);
            sda2.Update(dt);
           
        }
    }
}
