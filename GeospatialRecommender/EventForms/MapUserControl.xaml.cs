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
        public MapUserControl()
        {
            InitializeComponent();
            addEventForm = new frm_add();
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

            //Adds the pushpin to the map.
            Map.Children.Add(pin);
           
            addEventForm.ShowForm(pinLocation);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {          
            Map.Focus();
        }

        private void DisplayEvents(object sender, EventArgs e)
        {
           
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
    }
}
