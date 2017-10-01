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
    public class EventTests
    {
        //Arrange, Act, Assert

        [TestMethod()]
        public void GetLocationTest()
        {
            GRLocation expectedLocation = new GRLocation(10, 12);            
            TweetEvent te = new TweetEvent(expectedLocation, "dateTime", "some text");
            GRLocation eventLocation = te.EventLocation;

            Assert.AreEqual(expectedLocation, eventLocation);
        }

        [TestMethod()]
        public void SetLocationTest()
        {
            GRLocation original = new GRLocation(0, 0);
            GRLocation expectedLocation = new GRLocation(10, 12);
            TweetEvent te = new TweetEvent(original, "dateTime", "some text");
            te.EventLocation = expectedLocation;

            Assert.AreEqual(expectedLocation, te.EventLocation);
        }

        [TestMethod()]
        public void GetDTTest()
        {
            DateTime expectedTime = DateTime.Now;
            TweetEvent te = new TweetEvent(new GRLocation(0, 0), expectedTime.ToString(), "some text");

            Assert.AreEqual(expectedTime.ToString(), te.EventDateTime);
        }
    }
}