using BingMapsRESTToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeospatialRecommender.Events
{
    class GREventManager
    {
        public static void LoadEvents(string logFileName)
        {
            List<Event> events = EventReader.GetEvents(filePathPrefix + logFileName);
            for(int i=0; i < events.Count; i++)
            {
                if(events[i].ID > maxEventID)
                {
                    maxEventID = events[i].ID;
                }
                eventMap.Add(events[i].ID, events[i]);
            }
        }
         
        public static void AddEvent(Event eventItem)
        {
            maxEventID++;
            eventMap.Add(maxEventID, eventItem);
        }

        public static Event GetEvent(int ID, Event e)
        {
            if (eventMap.TryGetValue(ID, out e))
            {
                return e;
            }

            MessageBox.Show("Event not found.");
            return null;
        }

        public static string GetDataPath()
        {
            return filePathPrefix;
        }
              
        public static Dictionary<int,Event> GetEventMap()
        {
            return eventMap;
        }
               
        private static int maxEventID = 0;
        private static Dictionary<int, Event> eventMap = eventMap = new Dictionary<int, Event>();
        private static string filePathPrefix = "../../../EventData/";
    }
}
