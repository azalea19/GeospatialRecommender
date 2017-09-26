using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public class StatusUpdateEvent : Event
    {
        public StatusUpdateEvent(GRLocation location, string dateTimeStamp, string text) : base(location,dateTimeStamp)
        {
            this.statusText = text;
        }

        private string statusText;
    }
}
