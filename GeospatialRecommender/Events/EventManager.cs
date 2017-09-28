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
    class EventManager
    {
        public static void AddEvent(Event eventItem)
        {
            eventMap.Add(eventItem.ID, eventItem);
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
        
                
        private static Dictionary<int, Event> eventMap = eventMap = new Dictionary<int, Event>();
        private static string filePathPrefix = "../../../../DataFiles/";
    }
}
