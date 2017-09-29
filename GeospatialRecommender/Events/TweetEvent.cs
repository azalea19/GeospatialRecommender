using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender
{
    class TweetEvent : Event
    {
        public TweetEvent(GRLocation location, string dateTimeStamp, string tweetText) : base(location, dateTimeStamp,"TWEET")
        {
            this.tweetText = tweetText;
        }

        public TweetEvent(GRLocation location, string dateTimeStamp, string tweetText, int ID) : base(location, dateTimeStamp, ID, "TWEET")
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
