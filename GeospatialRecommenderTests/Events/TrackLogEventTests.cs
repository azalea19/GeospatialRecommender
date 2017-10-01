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
    public class TrackLogEventTests
    {
        [TestMethod()]
        public void TrackLogEventTest()
        {
            string expectedFilePath = "myfile.gpx";
            DateTime dtStart = DateTime.Now;
            DateTime dtEnd = DateTime.Now;
            TrackLogEvent te = new TrackLogEvent(new GRLocation(0, 0), expectedFilePath, dtStart.ToString(), dtEnd.ToString());

            Assert.AreEqual(expectedFilePath, te.GetTrackLogFilePath());
            Assert.AreEqual(dtStart.ToString(), te.GetStartTimeStamp());
            Assert.AreEqual(dtEnd.ToString(), te.GetEndTimeStamp());

        }

        [TestMethod()]
        public void GetStartTimeStampTest()
        {
            DateTime dtStart = DateTime.Now;           
            TrackLogEvent te = new TrackLogEvent(new GRLocation(0, 0), "", dtStart.ToString(), "");     
            Assert.AreEqual(dtStart.ToString(), te.GetStartTimeStamp());          
        }

        [TestMethod()]
        public void GetEndTimeStampTest()
        {       
            DateTime dtEnd = DateTime.Now;
            TrackLogEvent te = new TrackLogEvent(new GRLocation(0, 0), "", "", dtEnd.ToString());
            Assert.AreEqual(dtEnd.ToString(), te.GetEndTimeStamp());
        }

        [TestMethod()]
        public void GetTrackLogFilePathTest()
        {
            string expectedFilePath = "myfile.gpx";          
            TrackLogEvent te = new TrackLogEvent(new GRLocation(0, 0), expectedFilePath, "", "");
            Assert.AreEqual(expectedFilePath, te.GetTrackLogFilePath());
        }
    }
}