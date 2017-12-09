using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_2017FA_CSOS_1320_001
{
    public abstract class Event
    {

        public string Description { get; set; }
        

        public string Category { get; set; }

        public string StartDate { get; set; }

        public string Time { get; set; }

       

        public int MaxAttendees { get; set; }

        public string Title { get; set; }

        public string ParticipantNames { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }

        public int AgeMin { get; set; }

        public int EndDate { get; set; }
 

        public bool Private { get; set; }


    }
}