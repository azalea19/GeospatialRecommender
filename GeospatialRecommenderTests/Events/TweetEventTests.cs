using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeospatialRecommender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeospatialRecommender.Events;

namespace GeospatialRecommender.Tests
{
    [TestClass()]
    public class TweetEventTests
    {
        [TestMethod()]
        public void TweetEventTest()
        {
            string expectedText = "my text";
            TweetEvent te = new TweetEvent(new GRLocation(0, 0), "", expectedText);
            Assert.AreEqual(expectedText, te.TweetText);
        }

    }
}