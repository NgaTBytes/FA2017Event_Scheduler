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
            // initialize sqlcommand object
            using (SqlCommand insertRegistration = connection.CreateCommand())
            {
                // create an datetmie objectthat represents todays date
                DateTime today = DateTime.Today;

                //open connnection
                connection.Open();
                // try in case of shenanigans
                try
                {
                    // create insert statement based on info passed into the method
                    insertRegistration.CommandText = "insert into Event_Users values (" + eventID + ", '" + userName + "', '" + today + "');";

                    // execute the insert statement
                    insertRegistration.ExecuteNonQuery();

                }
                catch
                {

                }
                // close connection 
                connection.Close();
            }

        }
    }
}