using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public abstract class Event
    {
        //Public members
        public GRLocation GetLocation()
        {
            return eventLocation;
        }

        public void SetLocation(GRLocation location)
        {
            this.eventLocation = location;
        }

        public string GetDT()
        {
            return dateTimeStamp;
        }
        

        //Protected members
        protected Event(GRLocation location, string dateTimeStamp, string eventType)
        {
            this.eventLocation = location;
            this.dateTimeStamp = dateTimeStamp;
            this.ID = 0;
            this.eventType = eventType;
        }

        protected Event(GRLocation location, string dateTimeStamp, int ID, string eventType)
        {
            this.eventLocation = location;
            this.dateTimeStamp = dateTimeStamp;
            this.ID = ID;
            this.eventType = eventType;
        }

        //Private members
        private GRLocation eventLocation;
        private string dateTimeStamp;
        public int ID;
        public string eventType;
    }
}
