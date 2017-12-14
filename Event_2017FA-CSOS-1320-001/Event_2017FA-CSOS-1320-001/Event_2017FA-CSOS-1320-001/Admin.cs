using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// using statments
using System.Data.SqlClient;
using System.Data.Sql;
namespace Event_2017FA_CSOS_1320_001
{
    public class Admin : User
    {
        // sql connection string
        SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");

        // Method to allow the user to register.  called by EventSchedule UI Event     btnRegister_Click
        public override void Register(string userName, int eventID)
        {

            connection.Open();
            using (SqlCommand getEventCount = connection.CreateCommand())
            {
                //sql statement
                getEventCount.CommandText = "SELECT COUNT(Event_Users.UserName), Events.MaxAttendees  FROM Project1.dbo.Event_Users INNER JOIN Project1.dbo.Events ON Event_Users.EventID = Events.EventID WHERE Event_Users.EventID = " + eventID;

                //start sql reader
                using (SqlDataReader reader = getEventCount.ExecuteReader())
                {
                    // initialize count variable
                    int count = 0;
                    int maxAttendees = 0;

                    while (reader.Read())
                    {
                        // set count variable to count of users registered
                        count = reader.GetInt32(0);
                        maxAttendees = reader.GetInt32(1);
                    }
                    if (count < maxAttendees)
                    {
                        using (SqlCommand insertRegistration = connection.CreateCommand())
                        {
                            DateTime today = DateTime.Today;
                            insertRegistration.CommandText = "INSERT INTO Event_Users (EventID, UserName, DateRegistered) VALUES ( " + eventID + ", '" + userName + "', '" + today + "')";
                            insertRegistration.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        using (SqlCommand insertWaitlists = connection.CreateCommand())
                        {
                            insertWaitlists.CommandText = "INSERT INTO Waitlists (EventID, UserName) VALUES ( " + eventID + ", '" + userName + "');";
                            insertWaitlists.ExecuteNonQuery();

                        }
                    }

                }
            }

        }
    }
}