using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender.Events
{
    public class TrackLogEvent : Event
    {
        public TrackLogEvent(GRLocation location, string logFilePath, string startTimeStamp, string endTimeStamp) : base(location, startTimeStamp)
        {
            this.logFilePath = logFilePath;
            this.startTimeStamp = startTimeStamp;
            this.endTimeStamp = endTimeStamp;
        }

        public string GetStartTimeStamp()
        {
            return startTimeStamp;
        }

        public string GetEndTimeStamp()
        {
            return endTimeStamp;
        }

        public string GetTrackLogFilePath()
        {
            return logFilePath;
        }

        private string startTimeStamp;
        private string endTimeStamp;
        private string logFilePath;


    }
}
