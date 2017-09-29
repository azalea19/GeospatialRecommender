using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeospatialRecommender.Events
{
    public class GRLocation
    {
        public GRLocation()
        {

        }

        public GRLocation(double lat, double longt)
        {
            latitude = lat;
            longitude = longt;
        }

        private double latitude;
        private double longitude;

        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
            }
        }
        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
            }
        }
    }
}
