using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Returns a node if the parent has a child that contains a node with elementName.
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

        private static TweetEvent ProcessTweet(XmlNode eventNode, XmlNode tweetNode, XmlNamespaceManager nsmgr)
        {
            XmlNode idNode = GetNodeWithTag("eventid", eventNode, nsmgr);
            XmlNode dateTimeNode = GetNodeWithTag("datetimestamp", tweetNode, nsmgr);
            XmlNode tweetTextNode = GetNodeWithTag("text", tweetNode, nsmgr);
            GRLocation location = GetLocationFromNode(tweetNode, nsmgr);

            string stringID = idNode.InnerText.Substring(2);
            int ID = Convert.ToInt32(stringID);
            return new TweetEvent(location, dateTimeNode.InnerText, tweetTextNode.InnerText, ID);
        }

        private static PhotoEvent ProcessPhotoEvent(XmlNode eventNode, XmlNode photoEventNode, XmlNamespaceManager nsmgr)
        {
            XmlNode idNode = GetNodeWithTag("eventid", eventNode, nsmgr);
            XmlNode dateTimeNode = GetNodeWithTag("datetimestamp", photoEventNode, nsmgr);
            XmlNode photoNode = GetNodeWithTag("photo", photoEventNode, nsmgr);
            XmlNode filepathNode = GetNodeWithTag("filepath", photoEventNode, nsmgr);
            GRLocation location = GetLocationFromNode(photoEventNode, nsmgr);

            string stringID = idNode.InnerText.Substring(2);
            int ID = Convert.ToInt32(stringID);
            return new PhotoEvent(location, dateTimeNode.InnerText, filepathNode.InnerText, ID);
        }

        private static StatusUpdateEvent ProcessStatusEvent(XmlNode eventNode, XmlNode statusNode, XmlNamespaceManager nsmgr)
        {
            XmlNode idNode = GetNodeWithTag("eventid", eventNode, nsmgr);
            XmlNode dateTimeNode = GetNodeWithTag("datetimestamp", statusNode, nsmgr);
            XmlNode statusTextNode = GetNodeWithTag("text", statusNode, nsmgr);

            string stringID = idNode.InnerText.Substring(2);
            int ID = Convert.ToInt32(stringID);
            GRLocation location = GetLocationFromNode(statusNode, nsmgr);
            return new StatusUpdateEvent(location, dateTimeNode.InnerText, statusTextNode.InnerText, ID);
        }

        private static VideoEvent ProcessVideoEvent(XmlNode eventNode, XmlNode videoEventNode, XmlNamespaceManager nsmgr)
        {
            XmlNode idNode = GetNodeWithTag("eventid", eventNode, nsmgr);
            XmlNode startTimeNode = GetNodeWithTag("start-time", videoEventNode, nsmgr);
            XmlNode endTimeNode = GetNodeWithTag("end-time", videoEventNode, nsmgr);
            XmlNode dtStartNode = GetNodeWithTag("datetimestamp", startTimeNode, nsmgr);
            XmlNode dtEndNode = GetNodeWithTag("datetimestamp", endTimeNode, nsmgr);
            XmlNode filepathNode = GetNodeWithTag("filepath", videoEventNode, nsmgr);
            GRLocation location = GetLocationFromNode(videoEventNode, nsmgr);

            string stringID = idNode.InnerText.Substring(2);
            int ID = Convert.ToInt32(stringID);
            return new VideoEvent(location, filepathNode.InnerText, dtStartNode.InnerText, dtEndNode.InnerText, ID);
        }

        private static TrackLogEvent ProcessTrackLog(XmlNode eventNode, XmlNode trackEventNode, XmlNamespaceManager nsmgr)
        {
            XmlNode idNode = GetNodeWithTag("eventid", eventNode, nsmgr);
            XmlNode startTimeNode = GetNodeWithTag("start-time", trackEventNode, nsmgr);
            XmlNode endTimeNode = GetNodeWithTag("end-time", trackEventNode, nsmgr);
            XmlNode dtStartNode = GetNodeWithTag("datetimestamp", startTimeNode, nsmgr);
            XmlNode dtEndNode = GetNodeWithTag("datetimestamp", endTimeNode, nsmgr);
            XmlNode filepathNode = GetNodeWithTag("filepath", trackEventNode, nsmgr);
            GRLocation location = GetLocationFromNode(trackEventNode, nsmgr);

            string stringID = idNode.InnerText.Substring(2);
            int ID = Convert.ToInt32(stringID);
            return new TrackLogEvent(location, filepathNode.InnerText, dtStartNode.InnerText, dtEndNode.InnerText,ID);
        }

        private static GRLocation GetLocationFromNode(XmlNode parent, XmlNamespaceManager nsmgr)
        {
            XmlNode locationNode = GetNodeWithTag("location", parent, nsmgr);
            XmlNode latNode = GetNodeWithTag("lat", locationNode, nsmgr);
            XmlNode longNode = GetNodeWithTag("long", locationNode, nsmgr);

            GRLocation location = new GRLocation(Convert.ToDouble(latNode.InnerText), Convert.ToDouble(longNode.InnerText));
     
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
                    TweetEvent tEvent = ProcessTweet(eventNodes[i],tweetEventNode, nsmgr);                  
                    eventLog.Add(tEvent);
                }

                XmlNode statusEventNode = GetNodeWithTag("facebook-status-update", eventNodes[i], nsmgr);
                if (statusEventNode != null)
                {
                    StatusUpdateEvent suEvent = ProcessStatusEvent(eventNodes[i],statusEventNode, nsmgr);
                    eventLog.Add(suEvent);
                }

                XmlNode photoEventNode = GetNodeWithTag("photo", eventNodes[i], nsmgr);
                if (photoEventNode != null)
                {
                    PhotoEvent pEvent = ProcessPhotoEvent(eventNodes[i],photoEventNode, nsmgr);
                    eventLog.Add(pEvent);
                }

                XmlNode videoEventNode = GetNodeWithTag("video", eventNodes[i], nsmgr);
                if (videoEventNode != null)
                {
                    VideoEvent vEvent = ProcessVideoEvent(eventNodes[i],videoEventNode, nsmgr);
                    eventLog.Add(vEvent);
                }

                XmlNode trackLogEventNode = GetNodeWithTag("tracklog", eventNodes[i], nsmgr);
                if (trackLogEventNode != null)
                {
                    TrackLogEvent tlEvent = ProcessTrackLog(eventNodes[i],trackLogEventNode, nsmgr);
                    eventLog.Add(tlEvent);
                }
            }
            return eventLog;
        }

        private static void CheckMaxID(Event e)
        {
            if(e.ID > maxID)
            {
                maxID = e.ID;
            }
        }
        private static int maxID = 0;
    }
}
