using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender.Events
{
    public class VideoEvent : Event
    {
        public VideoEvent(GRLocation location, string videoFilePath, string startTimeStamp, string endTimeStamp) : base(location, startTimeStamp, "VIDEO")
        {
            this.videoFilePath = videoFilePath;
            this.startTimeStamp = startTimeStamp;
            this.endTimeStamp = endTimeStamp;
        }

        public VideoEvent(GRLocation location, string videoFilePath, string startTimeStamp, string endTimeStamp, int ID) : base(location, startTimeStamp, ID, "VIDEO")
        {
            this.videoFilePath = videoFilePath;
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

        public string GetVideoFilePath()
        {
            return videoFilePath;
        }

        private string startTimeStamp;
        private string endTimeStamp;
        private string videoFilePath;
    }
}
