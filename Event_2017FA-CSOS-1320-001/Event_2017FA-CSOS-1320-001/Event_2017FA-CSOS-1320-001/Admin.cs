using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_2017FA_CSOS_1320_001
{
    public class Admin : User
    {
        public void CreateEvent()
        {
            bool isClosed = false;
            if(isClosed)
            {
                Close someEvent = new Close();
            }
            else
            {
                Opened someEvent = new Opened();
            }
        }

        public void DestroyEvent()
        {
            throw new System.NotImplementedException();
        }

        public void ViewEvent()
        {
            throw new System.NotImplementedException();
        }

        public void EventRules()
        {
            throw new System.NotImplementedException();
        }
        // Method to allow the admin to register
        public virtual void Register()
        {
            // Method is created in the parent user class.
        }
 
    }
}