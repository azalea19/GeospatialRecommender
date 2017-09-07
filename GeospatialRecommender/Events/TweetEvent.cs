using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    class TweetEvent : Event
    {
        public TweetEvent(Location location, string dateTimeStamp, string tweetText) : base(location, dateTimeStamp)
        {
            this.tweetText = tweetText;
        }

        public string GetTweetText()
        {
            return tweetText;
        }

        public void SetTweetText(string text)
        {
            this.tweetText = text;
        }

        private string tweetText;
    }
}
