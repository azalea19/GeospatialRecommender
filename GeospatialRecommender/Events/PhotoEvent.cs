using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public class PhotoEvent : Event
    {
        public PhotoEvent(GRLocation location, string dateTimeStamp, string photoFilePath) : base(location, dateTimeStamp, "PHOTO")
        {
            this.photoFilePath = photoFilePath;
        }

        public PhotoEvent(GRLocation location, string dateTimeStamp, string photoFilePath, int ID) : base(location, dateTimeStamp, ID, "PHOTO")
        {
            this.photoFilePath = photoFilePath;
        }
        
        public string PhotoFilePath
        {
            get
            {
                return photoFilePath;
            }
            set
            {
                photoFilePath = value;
            }
        }

        private string photoFilePath;

    }
}
