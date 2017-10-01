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

        public GRLocation EventLocation
        {
            get
            {
                return eventLocation;
            }
            set
            {
                eventLocation = value;
            }
        }

        public string EventDateTime
        {
            get
            {
                return dateTimeStamp;
            }
            set
            {
                dateTimeStamp = value;
            }
        }

        public int EventID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public string EventType
        {
            get
            {
                return eventType;
            }
            set
            {
                eventType = value;
            }
        }


        private GRLocation eventLocation;
        private string dateTimeStamp;
        private int ID;
        private string eventType;
    }
}
