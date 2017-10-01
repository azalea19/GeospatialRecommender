using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender.Events
{
    public class TrackLogEvent : Event
    {
        public TrackLogEvent(GRLocation location, string logFilePath, string startTimeStamp, string endTimeStamp) : base(location, startTimeStamp, "TRACKLOG")
        {
            this.logFilePath = logFilePath;
            this.startTimeStamp = startTimeStamp;
            this.endTimeStamp = endTimeStamp;
        }
        public TrackLogEvent(GRLocation location, string logFilePath, string startTimeStamp, string endTimeStamp, int ID) : base(location, startTimeStamp,ID, "TRACKLOG")
        {
            this.logFilePath = logFilePath;
            this.startTimeStamp = startTimeStamp;
            this.endTimeStamp = endTimeStamp;
        }


        public string StartTimeStamp
        {
            get
            {
                return startTimeStamp;
            }
            set
            {
                startTimeStamp = value;
            }
        }

        public string EndTimeStamp
        {
            get
            {
                return endTimeStamp;
            }
            set
            {
                endTimeStamp = value;
            }
        }

        public string TrackLogFilePath
        {
            get
            {
                return logFilePath;
            }
            set
            {
                logFilePath = value;
            }
           
        }

        private string startTimeStamp;
        private string endTimeStamp;
        private string logFilePath;


    }
}
