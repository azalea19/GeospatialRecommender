using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using GeospatialRecommender.Events;

namespace GeospatialRecommender
{
    public static class EventReader
    {      
        public static List<Event> GetEvents(string filePath)
        {           
            //Reformat the soap file so it can be loaded.
            Reformat(filePath);      
     
            XmlDocument soapFile = new XmlDocument();
            soapFile.Load(filePath);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(soapFile.NameTable);
            
            nsmgr.AddNamespace("lle", "http://www.xyz.org/lifelogevents");
            
            //Get all of the Event nodes in the soap file.
            XmlNodeList eventNodes = soapFile.DocumentElement.SelectNodes("//lle:Event", nsmgr);

            List<Event> eventList = GetEvents(eventNodes, nsmgr);           
                     
            return eventList;
        }

        private static void Reformat(string filePath)
        {
            string text = File.ReadAllText(filePath);
            text = text.Replace("SOAP-ENV", "soapenv");
            text = text.Replace("SOAPENV", "soapenv");
            File.WriteAllText(filePath, text);
        }

        //Returns a node if the parent has a child that contains a node with elementName
        private static XmlNode GetNodeWithTag(string elementName, XmlNode parentNode, XmlNamespaceManager nsmgr)
        {
            //Iterate over each child node
            foreach (XmlNode child in parentNode)
            {              
                //If child found return its data
                if (child.Name.Contains(elementName))
                {
                    return child;
                }
            }
            return null;
        }

        private static TweetEvent ProcessTweet(XmlNode tweetNode, XmlNamespaceManager nsmgr)
        {
            XmlNode dateTimeNode = GetNodeWithTag("datetimestamp", tweetNode, nsmgr);
            XmlNode tweetTextNode = GetNodeWithTag("text", tweetNode, nsmgr);
            Location location = GetLocationFromNode(tweetNode, nsmgr);
            return new TweetEvent(location, dateTimeNode.InnerText, tweetTextNode.InnerText);
        }

        private static PhotoEvent ProcessPhotoEvent(XmlNode photoEventNode, XmlNamespaceManager nsmgr)
        {
            XmlNode dateTimeNode = GetNodeWithTag("datetimestamp", photoEventNode, nsmgr);
            XmlNode photoNode = GetNodeWithTag("photo", photoEventNode, nsmgr);
            XmlNode filepathNode = GetNodeWithTag("filepath", photoEventNode, nsmgr);
            Location location = GetLocationFromNode(photoEventNode, nsmgr);

            return new PhotoEvent(location, dateTimeNode.InnerText, filepathNode.InnerText);
        }

        private static StatusUpdateEvent ProcessStatusEvent(XmlNode statusNode, XmlNamespaceManager nsmgr)
        {
            XmlNode dateTimeNode = GetNodeWithTag("datetimestamp", statusNode, nsmgr);
            XmlNode statusTextNode = GetNodeWithTag("text", statusNode, nsmgr);

            Location location = GetLocationFromNode(statusNode, nsmgr);
            return new StatusUpdateEvent(location, dateTimeNode.InnerText, statusTextNode.InnerText);
        }

        private static VideoEvent ProcessVideoEvent(XmlNode videoEventNode, XmlNamespaceManager nsmgr)
        {
            XmlNode startTimeNode = GetNodeWithTag("start-time", videoEventNode, nsmgr);
            XmlNode endTimeNode = GetNodeWithTag("end-time", videoEventNode, nsmgr);
            XmlNode dtStartNode = GetNodeWithTag("datetimestamp", startTimeNode, nsmgr);
            XmlNode dtEndNode = GetNodeWithTag("datetimestamp", endTimeNode, nsmgr);
            XmlNode filepathNode = GetNodeWithTag("filepath", videoEventNode, nsmgr);
            Location location = GetLocationFromNode(videoEventNode, nsmgr);

            return new VideoEvent(location, filepathNode.InnerText, dtStartNode.InnerText, dtEndNode.InnerText);
        }

        private static TrackLogEvent ProcessTrackLog(XmlNode trackEventNode, XmlNamespaceManager nsmgr)
        {
            XmlNode startTimeNode = GetNodeWithTag("start-time", trackEventNode, nsmgr);
            XmlNode endTimeNode = GetNodeWithTag("end-time", trackEventNode, nsmgr);
            XmlNode dtStartNode = GetNodeWithTag("datetimestamp", startTimeNode, nsmgr);
            XmlNode dtEndNode = GetNodeWithTag("datetimestamp", endTimeNode, nsmgr);
            XmlNode filepathNode = GetNodeWithTag("filepath", trackEventNode, nsmgr);
            Location location = GetLocationFromNode(trackEventNode, nsmgr);

            return new TrackLogEvent(location, filepathNode.InnerText, dtStartNode.InnerText, dtEndNode.InnerText);

        }

        private static Location GetLocationFromNode(XmlNode parent, XmlNamespaceManager nsmgr)
        {
            XmlNode locationNode = GetNodeWithTag("location", parent, nsmgr);
            XmlNode latNode = GetNodeWithTag("lat", locationNode, nsmgr);
            XmlNode longNode = GetNodeWithTag("long", locationNode, nsmgr);

            Location location = new Location();
            location.latitude = Convert.ToInt32(latNode.InnerText);
            location.longitude = Convert.ToInt32(latNode.InnerText);

            return location;
        }

        private static List<Event> GetEvents(XmlNodeList eventNodes, XmlNamespaceManager nsmgr)
        {
            List<Event> eventLog = new List<Event>();

            for (int i =0; i < eventNodes.Count; i++)
            {
                //Tweet event found
                XmlNode tweetEventNode = GetNodeWithTag("tweet", eventNodes[i], nsmgr);
                if (tweetEventNode != null)
                {
                    TweetEvent tEvent = ProcessTweet(tweetEventNode, nsmgr);
                    eventLog.Add(tEvent);
                }

                XmlNode statusEventNode = GetNodeWithTag("facebook-status-update", eventNodes[i], nsmgr);
                if (statusEventNode != null)
                {
                    StatusUpdateEvent suEvent = ProcessStatusEvent(statusEventNode, nsmgr);
                    eventLog.Add(suEvent);
                }

                XmlNode photoEventNode = GetNodeWithTag("photo", eventNodes[i], nsmgr);
                if (photoEventNode != null)
                {
                    PhotoEvent pEvent = ProcessPhotoEvent(photoEventNode, nsmgr);
                    eventLog.Add(pEvent);
                }

                XmlNode videoEventNode = GetNodeWithTag("video", eventNodes[i], nsmgr);
                if (videoEventNode != null)
                {
                    VideoEvent vEvent = ProcessVideoEvent(videoEventNode, nsmgr);
                    eventLog.Add(vEvent);
                }

                XmlNode trackLogEventNode = GetNodeWithTag("tracklog", eventNodes[i], nsmgr);
                if (trackLogEventNode != null)
                {
                    TrackLogEvent tlEvent = ProcessTrackLog(trackLogEventNode, nsmgr);
                    eventLog.Add(tlEvent);
                }
            }
            return eventLog;
        }
    }
}
