using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public class StatusUpdateEvent : Event
    {
        public StatusUpdateEvent(GRLocation location, string dateTimeStamp, string text) : base(location,dateTimeStamp, "STATUS")
        {
            this.statusText = text;
        }

        public StatusUpdateEvent(GRLocation location, string dateTimeStamp, string text, int ID) : base(location, dateTimeStamp, ID, "STATUS")
        {
            this.statusText = text;
        }

        public string StatusText
        {
            get
            {
                return statusText;
            }
            set
            {
                statusText = value;
            }
        }

        private string statusText;

    }
}
