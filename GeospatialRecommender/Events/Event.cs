using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public struct GRLocation
    {
        public float latitude;
        public float longitude;
    }

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

        //Protected members
        protected Event(GRLocation location, string dateTimeStamp)
        {
            this.eventLocation = location;
            this.dateTimeStamp = dateTimeStamp;
        }

        //Private members
        private GRLocation eventLocation;
        private string dateTimeStamp;
    }
}
