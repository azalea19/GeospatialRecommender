using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using Microsoft.Maps.MapControl.WPF;
using System.Windows.Input;
using GeospatialRecommender.Events;

namespace GeospatialRecommender.EventForms
{
    public partial class frm_mapDisplay : Form
    {
        
        public frm_mapDisplay()
        {
            InitializeComponent();
            MyMapUserControl.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AqXJFUzQQmH8NRmKObTCFXN_F0_0998xlZOdMhxr1rQWVUh9FcJ--LgR3Ns-0T6l");
            GREventManager.LoadEvents("lifelog-events.xml");
        }

        private void frm_mapDisplay_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_eventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyMapUserControl.DisplayEvents(cmb_eventType.SelectedIndex);
        }


    }
}
