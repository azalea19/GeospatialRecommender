using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeospatialRecommender.Utility
{
    static class EventWriter
    {
        public static void NewDocument(string fileName)
        {
            XmlTextWriter writer = new XmlTextWriter(filePathPrefix + fileName, System.Text.Encoding.UTF8);
            writer.Formatting = System.Xml.Formatting.Indented;
           
            writer.WriteStartDocument();          
            writer.WriteRaw("\n<soapenv:Envelope xmlns:soapenv = \"http://www.w3.org/2001/12/soap-envelope\" soapenv:encodingStyle = \"http://www.w3.org/2001/12/soap-encoding\">");            
            writer.WriteStartElement("lle", "soapenv", "http://www.xyz.org/lifelogevents");
            Dictionary<int, Event> map = GREventManager.GetEventMap();
            foreach(KeyValuePair<int,Event> pair in map)
            {
                Write("lle:", writer,pair.Value);
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.WriteRaw("</soapenv:Envelope>");
            writer.Close();
        }

        public static void Write(string ns, XmlTextWriter writer, Event aEvent)
        {         
            writer.WriteStartElement(ns+"Event");

            writer.WriteStartElement("eventid");
            writer.WriteString("ID" + aEvent.ID);
            writer.WriteEndElement();

            switch (aEvent.eventType)
            {
                case ("STATUS"):
                    Write(ns, writer, (StatusUpdateEvent)aEvent);
                    break;
                case ("TWEET"):
                    Write(ns, writer, (TweetEvent)aEvent);
                    break;
                case ("TRACKLOG"):
                    Write(ns, writer, (TrackLogEvent)aEvent);
                    break;
                case ("VIDEO"):
                    Write(ns, writer, (VideoEvent)aEvent);
                    break;
                case ("PHOTO"):
                    Write(ns, writer, (PhotoEvent)aEvent);
                    break;
            }
           
            writer.WriteEndElement();
        }

        public static void Write(string ns, XmlTextWriter writer, PhotoEvent aEvent)
        {
            writer.WriteStartElement(ns + "photo");

            writer.WriteStartElement(ns + "filepath");
            writer.WriteString(aEvent.GetPhotoFilePath());
            writer.WriteEndElement();

            Write(ns, writer, aEvent.GetLocation());

            writer.WriteStartElement(ns + "datetimestamp");
            Write(ns, writer, aEvent.GetDT());
            writer.WriteEndElement();            

            writer.WriteEndElement();
            
        }

        public static void Write(string ns, XmlTextWriter writer, VideoEvent aEvent)
        {
            writer.WriteStartElement(ns + "video");

            writer.WriteStartElement(ns + "filepath");
            writer.WriteString(aEvent.GetVideoFilePath());
            writer.WriteEndElement();

            Write(ns, writer, aEvent.GetLocation());

            writer.WriteStartElement(ns + "start-time");
            Write(ns, writer, aEvent.GetDT());
            writer.WriteEndElement();

            writer.WriteStartElement(ns + "end-time");
            Write(ns, writer, aEvent.GetDT());
            writer.WriteEndElement();

            
            writer.WriteEndElement();
        }

        public static void Write(string ns, XmlTextWriter writer, StatusUpdateEvent aEvent)
        {
            writer.WriteStartElement(ns + "facebook-status-update");

            writer.WriteStartElement(ns + "text");
            writer.WriteString(aEvent.StatusText);
            writer.WriteEndElement();

            Write(ns, writer, aEvent.GetLocation());
            Write(ns, writer, aEvent.GetDT());

            
            writer.WriteEndElement();
        }

        public static void Write(string ns, XmlTextWriter writer, TweetEvent aEvent)
        {
            writer.WriteStartElement(ns + "tweet");

            writer.WriteStartElement(ns + "text");
            writer.WriteString(aEvent.TweetText);
            writer.WriteEndElement();

            Write(ns, writer,aEvent.GetLocation());
            Write(ns, writer, aEvent.GetDT());
          
            writer.WriteEndElement();
        }

        public static void Write(string ns, XmlTextWriter writer, TrackLogEvent aEvent)
        {

        }

        private static void Write(string ns, XmlTextWriter writer, GRLocation location)
        {
            writer.WriteStartElement(ns + "location");

            writer.WriteStartElement(ns + "lat");
            writer.WriteString(location.Latitude.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement(ns + "long");
            writer.WriteString(location.Longitude.ToString());
            writer.WriteEndElement();

            writer.WriteEndElement();
        }

        private static void Write(string ns, XmlTextWriter writer, string dt)
        {
            writer.WriteStartElement(ns + "datetimestamp");
            writer.WriteString(dt);
            writer.WriteEndElement();
        }

        private static string filePathPrefix = "../../../EventData/";
    }
}