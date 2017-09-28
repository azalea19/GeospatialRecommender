using BingMapsRESTToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GeospatialRecommender.Events
{
    static class Geocoder
    {    
        //addressQuery example: "13 Landers Road, Lesmurdie, WA"
        public static Location GeoCode(string addressQuery)
        {
            bool done = false;
            Location geoLocation = null;           
            Uri geocodeRequest = new Uri(string.Format("http://dev.virtualearth.net/REST/v1/Locations?q={0}&key={1}", addressQuery, key));           
            GetResponse(geocodeRequest, (x) =>
            {
                MessageBox.Show(x.ResourceSets[0].Resources.Length + "result(s) found.");
                if(x.ResourceSets[0].Resources.Length > 0)
                {
                    geoLocation = (Location)x.ResourceSets[0].Resources[0];
                }
                done = true;
            });
            while(!done)
            {
                System.Windows.Forms.Application.DoEvents();
            }
            return geoLocation;
        }

        private static void GetResponse(Uri uri, Action<Response> callback)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.OpenReadCompleted += (o, a) =>
            {
                if (callback != null)
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Response));
                    callback(ser.ReadObject(a.Result) as Response);
                }
            };
            wc.OpenReadAsync(uri);
        }

        private static string key = "AqXJFUzQQmH8NRmKObTCFXN_F0_0998xlZOdMhxr1rQWVUh9FcJ--LgR3Ns-0T6l";
    }
}
