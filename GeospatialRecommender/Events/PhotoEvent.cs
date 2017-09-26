using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public class PhotoEvent : Event
    {
        public PhotoEvent(GRLocation location, string dateTimeStamp, string photoFilePath) : base(location, dateTimeStamp)
        {
            this.photoFilePath = photoFilePath;
        }

        public string GetPhotoFilePath()
        {
            return photoFilePath;
        }

        private string photoFilePath;

    }
}
