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
    public class GREventManager
    {
        public static void ClearMap()
        {
            eventMap.Clear();
        }

        public static void LoadEvents(string logFileName)
        {
            eventMap.Clear();
            maxEventID = 0;
            List<Event> events = EventReader.GetEvents(logFileName);       
            
            for (int i=0; i < events.Count; i++)
            { 
                bool unique = true;
                foreach (KeyValuePair<int,Event> pair in eventMap)
                {
                    if(events[i].EventID == pair.Value.EventID)
                    {
                        //Duplicate ID found create new ID                                            
                        unique = false;
                        break;
                    }
                }

                if(unique)
                {             
                    maxEventID = events[i].EventID > maxEventID ? events[i].EventID : maxEventID;
                }
                else
                {
                    events[i].EventID = ++maxEventID;
                }

                eventMap.Add(events[i].EventID, events[i]);
            }
        }
         
        public static void AddEvent(Event eventItem)
        {
            ++maxEventID;
            eventItem.EventID = maxEventID;
            eventMap.Add(eventItem.EventID, eventItem);
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
