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
    public class PhotoEventTests
    {
        [TestMethod()]
        public void PhotoEventTest()
        {
            string expectedPath = "myphoto.png";
            PhotoEvent pe = new PhotoEvent(new GRLocation(0, 0), "", expectedPath);
            Assert.AreEqual(expectedPath, pe.GetPhotoFilePath());
        }

        [TestMethod()]
        public void GetPhotoFilePathTest()
        {
            string expectedPath = "myphoto.png";
            PhotoEvent pe = new PhotoEvent(new GRLocation(0, 0), "", expectedPath);
            Assert.AreEqual(expectedPath, pe.GetPhotoFilePath());
        }
    }
}