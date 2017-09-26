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

namespace GeospatialRecommender.EventForms
{
    public partial class frm_mapDisplay : Form
    {

        public frm_mapDisplay()
        {
            InitializeComponent();
            MyMapUserControl.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AqXJFUzQQmH8NRmKObTCFXN_F0_0998xlZOdMhxr1rQWVUh9FcJ--LgR3Ns-0T6l");
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void frm_mapDisplay_Load(object sender, EventArgs e)
        {

        }

        private void elementHost_map_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btn_addPolygon_Click(object sender, EventArgs e)
        {

        }

        
    }
}
