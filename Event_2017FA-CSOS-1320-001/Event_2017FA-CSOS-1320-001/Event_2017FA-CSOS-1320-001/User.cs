using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_2017FA_CSOS_1320_001
{
    public abstract class User
    {
        
        public string FirstName { get; set; }
        

        public string LastName { get; set; }
       

        public int Age
        { get; set; }

        public virtual void Register(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void Unregister()
        {

        }
        // Method so that the open events will show the info for 
        // participants to view the event.
        public void DetailedOverview()
        {
            
        }
    }
}