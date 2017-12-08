using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_2017FA_CSOS_1320_001
{
    public class Close : Event
    {
        public Close()
        {
        }

        // Contructor that will pre-populate the values needed to get form the end-user.
        public Close(string theDescription, string theStartDate, string theTime, string theTitle,
            string theCategory, string theNotes, int theMaxAttendees,
            int theEndDate, int theAgeMin, string theStatus)
        {
            theDescription = Description;
            theStartDate = StartDate;
            theTime = Time;
            theTitle = Title;
            theCategory = Category;
            theNotes = Notes;
            theMaxAttendees = MaxAttendees;
            theEndDate = EndDate;
            theAgeMin = AgeMin;
            theStatus = Status;
        }      
    }
}