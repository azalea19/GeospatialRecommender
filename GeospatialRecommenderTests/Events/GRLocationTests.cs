using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender.Events.Tests
{
    [TestClass()]
    public class GRLocationTests
    {
        [TestMethod()]
        public void GRLocationTest()
        {
            double lat = 0;
            double longt = 0;
            GRLocation location1 = new GRLocation(lat, longt);          

            Assert.AreEqual(lat, location1.Latitude);
            Assert.AreEqual(longt, location1.Longitude);
        }
    }
}