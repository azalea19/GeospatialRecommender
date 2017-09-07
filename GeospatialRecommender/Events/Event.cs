using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public struct Location
    {
        public float latitude;
        public float longitude;
    }

    public abstract class Event
    {
        //Public members
        public Location GetLocation()
        {
            return eventLocation;
        }

        public void SetLocation(Location location)
        {
            this.eventLocation = location;
        }

        //Protected members
        protected Event(Location location, string dateTimeStamp)
        {
            this.eventLocation = location;
            this.dateTimeStamp = dateTimeStamp;
        }

        //Private members
        private Location eventLocation;
        private string dateTimeStamp;
    }
}
