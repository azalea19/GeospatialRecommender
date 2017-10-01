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
    public class GREventManagerTests
    {
        [TestMethod()]
        public void ClearMapTest()
        {
            GREventManager.AddEvent(new PhotoEvent(new GRLocation(0, 0), "", ""));
            GREventManager.ClearMap();
            Assert.IsTrue(GREventManager.GetEventMap().Count == 0);
        }

        [TestMethod()]
        public void AddEventTest()
        {
            GREventManager.ClearMap();
            GREventManager.AddEvent(new PhotoEvent(new GRLocation(0, 0), "", ""));
            Assert.IsTrue(GREventManager.GetEventMap().Count == 1);
        }

        [TestMethod()]
        public void GetDataPathTest()
        {
            string expectedPath = "../../../EventData/"; ;
            Assert.AreEqual(expectedPath, GREventManager.GetDataPath());
        }

    }
}