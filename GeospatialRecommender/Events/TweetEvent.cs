using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    public class TweetEvent : Event
    {
        public TweetEvent(GRLocation location, string dateTimeStamp, string tweetText) : base(location, dateTimeStamp,"TWEET")
        {
            this.tweetText = tweetText;
        }

        public TweetEvent(GRLocation location, string dateTimeStamp, string tweetText, int ID) : base(location, dateTimeStamp, ID, "TWEET")
        {
            this.tweetText = tweetText;
        }

        public string TweetText
        {
            get
            {
                return tweetText;
            }
            set
            {
                tweetText = value;
            }
        }

        private string tweetText;
    }
}
