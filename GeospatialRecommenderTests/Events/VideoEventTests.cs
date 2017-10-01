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
    public class VideoEventTests
    {
        [TestMethod()]
        public void VideoEventTest()
        {
            string expectedPath = "video.avi";
            DateTime dtStart = DateTime.Now;
            DateTime dtEnd = DateTime.Now;
            VideoEvent ve = new VideoEvent(new GRLocation(0, 0), expectedPath, dtStart.ToString(), dtEnd.ToString());

            Assert.AreEqual(expectedPath, ve.GetVideoFilePath());
            Assert.AreEqual(dtStart.ToString(), ve.GetStartTimeStamp());
            Assert.AreEqual(dtEnd.ToString(), ve.GetEndTimeStamp());
        }


        [TestMethod()]
        public void GetStartTimeStampTest()
        {         
            DateTime dtStart = DateTime.Now;         
            VideoEvent ve = new VideoEvent(new GRLocation(0, 0), "", dtStart.ToString(),"");        
            Assert.AreEqual(dtStart.ToString(), ve.GetStartTimeStamp());         
        }

        [TestMethod()]
        public void GetEndTimeStampTest()
        {            
            DateTime dtEnd = DateTime.Now;
            VideoEvent ve = new VideoEvent(new GRLocation(0, 0), "", "", dtEnd.ToString());          
            Assert.AreEqual(dtEnd.ToString(), ve.GetEndTimeStamp());
        }

        [TestMethod()]
        public void GetVideoFilePathTest()
        {
            string expectedPath = "video.avi";            
            VideoEvent ve = new VideoEvent(new GRLocation(0, 0), expectedPath, "", "");
            Assert.AreEqual(expectedPath, ve.GetVideoFilePath());
        }
    }
}