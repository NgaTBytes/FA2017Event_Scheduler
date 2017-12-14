using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using statements
using System.Data.SqlClient;
using System.Data.Sql;
using Event_2017FA_CSOS_1320_001;
namespace EventScheduleUI
{
    public partial class Tabs : Form
    {
        //instantiate Admin
        Admin someAdmin = new Admin();

        // data adapters, data tables, and connection strings
        SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");
        SqlDataAdapter sda2;
        SqlDataAdapter sda3;
        DataTable dt;
        DataTable dt1;

        //property used to to show if user is an admin or not.
        public bool admin { get; set; }

        // Overcome variable scope by putting this variable in class method
        public string userName;

        // adajusted Tabs Constructor to also bring in the username from previous form
        public Tabs(string username)
        {
            userName = username;
            InitializeComponent();
            //sql connection opem

            connection.Open();

            //Get data adapter, and data table ready to be used in participant view
            sda3 = new SqlDataAdapter(@"SELECT Users.Username, Users.Passsword, Users.UserFirstName, Users.UserLastName, Users.UserAge, Users.RoleID
            FROM Users", connection);
            dt1 = new DataTable();

            // use the data from the adapter to fill the table
            sda3.Fill(dt1);

            // make the data source the newly filled data table
            dgvParticipantView.DataSource = dt1;

            // begin sql for Full View
            using (SqlCommand getAllEventRecs = connection.CreateCommand())
            {
                // SQL statement
                getAllEventRecs.CommandText = "SELECT EventID, EventName, Location, Status, StartDate, EndDate, StartTime, EndTime, AgeRequirement, EventDescription, EventNotes, MaxAttendees FROM Events;";

                //start sql reader
                using (SqlDataReader reader = getAllEventRecs.ExecuteReader())
                {

                    // Row Counter
                    int c = 0;
                    while (reader.Read())
                    {
                        //populate Full View
                        dgvFullView.Rows.Add();
                        dgvFullView.Rows[c].Cells[0].Value = reader.GetInt32(0);
                        dgvFullView.Rows[c].Cells[1].Value = reader.GetString(1);
                        dgvFullView.Rows[c].Cells[2].Value = reader.GetString(2);
                        dgvFullView.Rows[c].Cells[3].Value = reader.GetString(3);
                        dgvFullView.Rows[c].Cells[4].Value = reader.GetDateTime(4);
                        dgvFullView.Rows[c].Cells[5].Value = reader.GetDateTime(5);
                        dgvFullView.Rows[c].Cells[6].Value = reader.GetTimeSpan(6);
                        dgvFullView.Rows[c].Cells[7].Value = reader.GetTimeSpan(7);
                        dgvFullView.Rows[c].Cells[8].Value = reader.GetInt32(8);
                        dgvFullView.Rows[c].Cells[9].Value = reader.GetInt32(11);
                        dgvFullView.Rows[c].Cells[10].Value = reader.GetString(10);
                        dgvFullView.Rows[c].Cells[11].Value = reader.GetString(9);


                        c++;


                    }
                }
            }

            //begin Sql for Teaser view
            using (SqlCommand getTeaserEventRecs = connection.CreateCommand())
            {
                //sql statement
                getTeaserEventRecs.CommandText = "SELECT EventName, Location, StartDate, CategoryDescription FROM Events INNER JOIN Categories ON Events.CategoryID = Categories.CategoryID;";

                //start sql reader
                using (SqlDataReader reader = getTeaserEventRecs.ExecuteReader())
                {
                    // row counter
                    int c = 0;

                    //Populate teaser view
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
            //  Greet the user, showing that we have recorded their username
            MessageBox.Show("Hello, " + userName);
        }


        // View selection button in list view is selected this happens
        private void btnViewSelection_Click(object sender, EventArgs e)
        {

            // List view sql data adapter
            sda2 = new SqlDataAdapter(@"SELECT EventId, Events.EventName, Events.Location, Events.Status, Events.StartDate, Events.EndDate, Events.StartTime, Events.EndTime, Events.AgeRequirement, Events.EventNotes, Events.EventDescription, Events.MaxAttendees, Events.CategoryID, Events.Private, Events.Closed
            FROM Events", connection);

            // make the data table
            dt = new DataTable();

            //fill the data table using the data adapter
            sda2.Fill(dt);

            //that table is the source for the list view datagridview
            dgvListView.DataSource = dt;

            //data grid table and update button are hidden until selection made
            this.dgvListView.Visible = true;
            this.btnUpdateList.Visible = true;

            //Set all columns.visible to a default of visible.
            for (int i = 0; i < this.dgvListView.Columns.Count; i++)
            {
                this.dgvListView.Columns[i].Visible = true;
            }

            // Higgs golden code
            int counter = 0;

            //loop through every control in the form
            foreach (Control control in tabListView.Controls)
            {
                // check if control is listed as a checkbox
                if (control is CheckBox)
                {
                    // instantiate temporary checkbox object of the checkbox
                    CheckBox temp = control as CheckBox;

                    // check if the object is checked
                    if (temp.Checked)
                    {
                        // if it is, make the counter go up
                        counter++;
                    }
                }
            }

            //slight formatting, adjusting the width of columns just a bit
            
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
            this.dgvListView.Columns[11].Width = 100;
            this.dgvListView.Columns[12].Width = 80;
            this.dgvListView.Columns[13].Width = 80;
            this.dgvListView.Columns[14].Width = 80;


            // if that counter from before is still zero, then nothing is checked, and we want to keep our default columns from showing.
            if (counter == 0)
            {
                this.dgvListView.Columns[0].Visible = false;
                this.dgvListView.Columns[13].Visible = false;
                this.dgvListView.Columns[12].Visible = false;
                this.dgvListView.Columns[14].Visible = false;

                //also hide the data grid view and update button to make things look more dynamic
                this.dgvListView.Visible = false;
                this.btnUpdateList.Visible = false;

                //also tell end user to select a check box
                MessageBox.Show("Please select 1 or more check boxes.");
            }


            //Big, giant set of if statments.  they check if a checkbox is NOT checked, and if it isn't,
            //the corresponding column is made invisible
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
        //When tabTab (our tab pages group object) becomes the focus (it happens immediately upon opening form 2)
        //this code excecutes
        private void tabTab_Enter(object sender, EventArgs e)
        {
            // We check our admin property's value, and if false, remove admin only tabs (list view/participant view)
            if (admin == false)
            {
                tabTab.TabPages.Remove(tabListView);
                tabTab.TabPages.Remove(tabPaticipantsView);
            }

        }

        // if the update button on list view is pressed, this code runs
        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            // try catch n case of shenanigans
            try
            {
                // build and excecute a command based on changes made to the data grid view
                SqlCommandBuilder builder;
                builder = new SqlCommandBuilder(sda2);
                sda2.Update(dt);
            }
            catch
            {
                //if an error happens
                MessageBox.Show("An error has occured.");
            }
            // call view selection method to show updated data grid view
            btnViewSelection_Click(sender, e);
        }

        // When the update button on Participant view is clicked, this runs
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Build and execute sql command based on user interaction with dgvParticpantView
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(sda3);
            sda3.Update(dt1);
        }

        //When the register button on full view is clicked, this code runs
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //intialize variable for event ID
            int eventID = 0;

            //try to parse the alleged event ID the user enters
            if (int.TryParse(txtEventID.Text, out eventID))
            {
                //MessageBox.Show("heloo comrade" + userName + eventID.ToString());

                // run the code in the dll for register, sending aong the users username and the event ID they want to register for
                someAdmin.Register(userName, eventID);

                // if the whole shibang doesn't crash, display a confirmation message with no real backing behind it.
                MessageBox.Show("You have registered for event " + eventID + ".");
            }
            else
            {
                // Inform the user that they did not type a whole number
                MessageBox.Show("Enter a number, please sir and/or madam.");
            }
        }

        //when you click the logout button, this code runs
        private void Logout_Click(object sender, EventArgs e)
        {
            // instantiate new object of the login form
            Login someLogin = new Login();

            //hide tab form
            this.Hide();

            //show login form
            someLogin.ShowDialog();

            // stop the tab form
            Environment.Exit(0);

        }
    }
}
