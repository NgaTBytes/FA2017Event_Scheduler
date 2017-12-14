using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;
namespace Event_2017FA_CSOS_1320_001
{
    public class Participant : User
    {

        SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");

        public virtual void Register()
        {
            // Code to enbale Participants to regester whther its a closed event
            // they will have the opportunity to call this to register. This method is already 
            // defined in the parent class User.

        }

        public override void Register(string userName, int eventID)
        {
            DateTime today = DateTime.Today;
            connection.Open();
            using (SqlCommand insertRegistration = connection.CreateCommand())
            {
                insertRegistration.CommandText = "INSERT INTO Event_Users (EventID, UserName, DateRegistered) VALUES ( " + eventID + ", '" + userName + "', " + today + ")";
                insertRegistration.ExecuteNonQuery();

            }
        }
    }
}