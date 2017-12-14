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
using Event_2017FA_CSOS_1320_001;
namespace EventScheduleUI
{
    public partial class Tabs : Form
    {
        Admin someAdmin = new Admin();
        
        SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");
        SqlDataAdapter sda2;
        SqlDataAdapter sda3;
        DataTable dt;
        DataTable dt1;

        public bool admin { get; set; }
        public string userName { get; set; } 

        public Tabs(string username)
        {
            userName = username;
            InitializeComponent();
            if (admin == true)
            {
                tabTab.TabPages.Remove(tabListView);
            }

            SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");
            connection.Open();
            sda3 = new SqlDataAdapter(@"SELECT Users.Username, Users.Passsword, Users.UserFirstName, Users.UserLastName, Users.UserAge, Users.RoleID
            FROM Users", connection);
            dt1 = new DataTable();
            sda3.Fill(dt1);
            dgvParticipantView.DataSource = dt1;
            using (SqlCommand getAllEventRecs = connection.CreateCommand())
            {
                getAllEventRecs.CommandText = "SELECT EventName, Location, Status, StartDate, EndDate, StartTime, EndTime, AgeRequirement, EventDescription, EventNotes, MaxAttendees FROM Events;";

                using (SqlDataReader reader = getAllEventRecs.ExecuteReader())
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dgvFullView.Rows.Add();
                        dgvFullView.Rows[c].Cells[0].Value = reader.GetString(0);
                        dgvFullView.Rows[c].Cells[1].Value = reader.GetString(1);
                        dgvFullView.Rows[c].Cells[2].Value = reader.GetString(2);
                        dgvFullView.Rows[c].Cells[3].Value = reader.GetDateTime(3);
                        dgvFullView.Rows[c].Cells[4].Value = reader.GetDateTime(4);
                        dgvFullView.Rows[c].Cells[5].Value = reader.GetTimeSpan(5);
                        dgvFullView.Rows[c].Cells[6].Value = reader.GetTimeSpan(6);
                        dgvFullView.Rows[c].Cells[7].Value = reader.GetInt32(7);
                        dgvFullView.Rows[c].Cells[8].Value = reader.GetInt32(10);
                        dgvFullView.Rows[c].Cells[9].Value = reader.GetString(9);
                        dgvFullView.Rows[c].Cells[10].Value = reader.GetString(8);
                        //dgvFullView.Rows[c].Cells[11].Value = reader.GetString(11);

                        c++;
                        
                       
                    }
                }
            }
            using (SqlCommand getTeaserEventRecs = connection.CreateCommand())
            {
                getTeaserEventRecs.CommandText = "SELECT EventName, Location, StartDate, CategoryDescription FROM Events INNER JOIN Categories ON Events.CategoryID = Categories.CategoryID;";


                using (SqlDataReader reader = getTeaserEventRecs.ExecuteReader())
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dgvTeaser.Rows.Add();
                        dgvTeaser.Rows[c].Cells[0].Value = reader.GetString(0);
                        dgvTeaser.Rows[c].Cells[1].Value = reader.GetString(1);
                        dgvTeaser.Rows[c].Cells[2].Value = reader.GetDateTime(2);
                        dgvTeaser.Rows[c].Cells[3].Value = reader.GetString(3);
                        c++;

                    }
                }
            }
            
            MessageBox.Show("Hello, " + userName);
        }



        private void btnExecute_Click(object sender, EventArgs e)
        {
            sda2 = new SqlDataAdapter(@"SELECT EventId, Events.EventName, Events.Location, Events.Status, Events.StartDate, Events.EndDate, Events.StartTime, Events.EndTime, Events.AgeRequirement, Events.EventNotes, Events.EventDescription, Events.MaxAttendees, Events.CategoryID, Events.Private, Events.Closed
            FROM Events", connection);
            dt = new DataTable();
            sda2.Fill(dt);
            dgvListView.DataSource = dt;
            //data grid table is hidden until selection made
            this.dgvListView.Visible = true;

           
            //this.dgvListView.Columns["AttendeesForm2"].Visible = true;
            for (int i = 0; i < this.dgvListView.Columns.Count; i++)
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
            this.dgvListView.Columns[0].Width = 75;
            this.dgvListView.Columns[1].Width = 130;
            this.dgvListView.Columns[2].Width = 80;
            this.dgvListView.Columns[3].Width = 60;
            this.dgvListView.Columns[4].Width = 75;
            this.dgvListView.Columns[5].Width = 75;
            this.dgvListView.Columns[6].Width = 75;
            this.dgvListView.Columns[7].Width = 75;
            this.dgvListView.Columns[8].Width = 80;
            this.dgvListView.Columns[9].Width = 100;
            this.dgvListView.Columns[10].Width = 250;
            this.dgvListView.Columns[9].Width = 100;
            this.dgvListView.Columns[11].Width = 100;
            this.dgvListView.Columns[12].Width = 100;
            this.dgvListView.Columns[13].Width = 100;



            if (counter == 0)
            {
                this.dgvListView.Columns[0].Visible = false;
                this.dgvListView.Columns[13].Visible = false;
                this.dgvListView.Columns[12].Visible = false;
                this.dgvListView.Columns[14].Visible = false;
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
            if (!chkStatus.Checked)
            {
                this.dgvListView.Columns[3].Visible = false;
            }
            if (!chkStartDate.Checked)
            {
                this.dgvListView.Columns[4].Visible = false;
            }
            if (!chkEndDate.Checked)
            {
                this.dgvListView.Columns[5].Visible = false;
            }
            if (!chkStartTime.Checked)
            {
                this.dgvListView.Columns[6].Visible = false;
            }
            if (!chkEndTime.Checked)
            {
                this.dgvListView.Columns[7].Visible = false;
            }
            if (!chkAge.Checked)
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
            if (!chkRegisteredMaxAttendees.Checked)
            {
                this.dgvListView.Columns[11].Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }



        private void tabTab_Enter(object sender, EventArgs e)
        {
            if (admin == false)
            {

                tabTab.TabPages.Remove(tabListView);
                tabTab.TabPages.Remove(tabPaticipantsView);
            }
        }


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(sda3);
            sda3.Update(dt1);
        }

        private void dgvFullView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int eventID = 0;
            if (int.TryParse(txtEventID.Text, out eventID))
            {
                //MessageBox.Show("heloo comrade" + userName + eventID.ToString());
                someAdmin.Register(userName, eventID);
            }
            else
            {
                MessageBox.Show("Enter a number, please sir and/or madam.");
            }
        }
    }
}
 