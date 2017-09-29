using GeospatialRecommender.Events;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeospatialRecommender
{
    /// <summary>
    /// Interaction logic for MapUserControl.xaml
    /// </summary>
    public partial class MapUserControl : UserControl
    {
        private enum EventType
        {
            NONE,
            TWEET,
            STATUS,
            PHOTO,
            VIDEO,
            TRACKLOG,
            ALL
        }

        public MapUserControl()
        {
            InitializeComponent();
            addEventForm = new frm_add();
            selection = 0;
        }

        private void OnMapDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            //Get the mouse click coordinates.
            Point mousePosition = e.GetPosition(this);

            //Convert the mouse coordinates to a location on the map.
            Location pinLocation = Map.ViewportPointToLocation(mousePosition);
     

            //The pushpin to add to the map.
            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;
                     
            addEventForm.ShowForm(pinLocation);
            DisplayEvents(selection);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {          
            Map.Focus();
        }

        public void DisplayEvents(int selection)
        {
            this.selection = selection;
            EventType eventsToShow = (EventType)selection;
            Dictionary<int, Event> map = GREventManager.GetEventMap();
            Map.Children.Clear();

            if(eventsToShow == EventType.ALL)
            {
                foreach (KeyValuePair<int, Event> pair in map)
                {
                    Pushpin pin = new Pushpin();
                    pin.Location =  new Location(pair.Value.GetLocation().Latitude, pair.Value.GetLocation().Longitude);
                    //Adds the pushpin to the map.
                    Map.Children.Add(pin);
                }
            }
            else
            {
                foreach(KeyValuePair<int,Event> pair in map)
                {
                    if(pair.Value.eventType == eventsToShow.ToString())
                    {
                        //The pushpin to add to the map.
                        Pushpin pin = new Pushpin();
                        pin.Location = new Location(pair.Value.GetLocation().Latitude,pair.Value.GetLocation().Longitude);
                        //Adds the pushpin to the map.
                        Map.Children.Add(pin);
                    }
                }
            }                                 
        }

        private void OnMouseWheelMove(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            Map.ZoomLevel += e.Delta / 120.0;
            Map.ZoomLevel = Clamp(1, 20, Map.ZoomLevel);                                     
            Console.WriteLine(Map.ZoomLevel);   
        }

        private double Clamp(double min, double max, double value)
        {
            if(value < min)
            {
                return min;
            }
            if(value > max)
            {
                return max;
            }
            return value;
        }

        private frm_add addEventForm;
        private int selection;
    }
}
