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
    public class StatusUpdateEventTests
    {
        [TestMethod()]
        public void StatusUpdateEventTest()
        {
            string expectedText = "my text";
            StatusUpdateEvent se = new StatusUpdateEvent(new GRLocation(0, 0), "", expectedText);
            Assert.AreEqual(expectedText, se.StatusText);
        }
    }
}