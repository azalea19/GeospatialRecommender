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

namespace GeospatialRecommender
{
    public static class EventReader
    {
        public static void Reformat(string filePath)
        {
            string text = File.ReadAllText(filePath);
            text = text.Replace("SOAP-ENV", "soapenv");
            text = text.Replace("SOAPENV", "soapenv");
            File.WriteAllText(filePath, text);          
        }

        public static List<Event> GetEvents(string filePath)
        {
            //List of events to return.
            List<Event> myEvents = new List<Event>();
            
            //Reformat the soap file so it can be loaded.
            Reformat(filePath);      
     
            XmlDocument soapFile = new XmlDocument();
            soapFile.Load(filePath);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(soapFile.NameTable);
            
            nsmgr.AddNamespace("lle", "http://www.xyz.org/lifelogevents");
            
            //Get all of the Event nodes in the soap file.
            XmlNodeList eventNodes = soapFile.DocumentElement.SelectNodes("//lle:Event", nsmgr);

            foreach (XmlNode xn in eventNodes)
            {
                CheckEventType(xn, nsmgr);           
            }
            
            return myEvents;
        }

        private static string GetTag(string elementName, XmlNode xn, XmlNamespaceManager nsmgr)
        {
            //Iterate over each child node
            foreach (XmlNode child in xn.ChildNodes)
            {
                GetTag(elementName, child, nsmgr);

                //If child found return its data
                if (child.Name.Contains(elementName))
                {
                    return child.InnerText;
                }

            }
            return "Element not found.";
        }


        private static void CheckEventType(XmlNode xn, XmlNamespaceManager nsmgr)
        {
            XmlNodeList tweetNodes = xn.SelectNodes("//lle:tweet", nsmgr);
            if (tweetNodes.Count >= 1)
            {
                Console.WriteLine("Found a tweet event.");
            }
            //Loop over each child node in the parent and
            //determine what kind of node it is.
            for (int i =1; i < xn.ChildNodes.Count; i++)
            {
                
                //Tweet event found
                if (xn.ChildNodes[i].Name.Contains("tweet"))
                {
                    TweetEvent tw;
                    
                    foreach (XmlNode child in xn.ChildNodes)
                    {

                    }

                }
                //Video event found      
                if (xn.ChildNodes[i].Name.Contains("video"))
                {

                }
                //Photo event found
                if (xn.ChildNodes[i].Name.Contains("photo"))
                {

                }
                //Status update event found
                if (xn.ChildNodes[i].Name.Contains("facebook-status-update"))
                {

                }
                //TrackLog event found
                if (xn.ChildNodes[i].Name.Contains("tracklog"))
                {

                }
            }

        }


    }
}
