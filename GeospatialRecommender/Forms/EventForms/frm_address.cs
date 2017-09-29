using BingMapsRESTToolkit;
using GeospatialRecommender.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeospatialRecommender.EventForms
{
    public partial class frm_address : Form
    {
        public frm_address()
        {
            InitializeComponent();
            unit = null;
            streetNumber = null;
            street = null;
            suburb = null;
            state = null;
            postcode = null;       
            addressLocation = null;
        }

        public void ShowForm()
        {
            unit = null;
            streetNumber = null;
            street = null;
            suburb = null;
            state = null;
            postcode = null;
            addressLocation = null;
            this.ShowDialog();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            unit = txt_unit.Text;
            street = txt_street.Text;
            streetNumber = txt_stNumber.Text;
            suburb = txt_suburb.Text;
            state = txt_state.Text;
            postcode = txt_postcode.Text;

            string addressQuery = unit + " " +
                                  streetNumber + " " +
                                  street + ", " +
                                  suburb + ", " +
                                  state + ", " +
                                  postcode;

            Location newLocation = Geocoder.GeoCode(addressQuery);

            if (newLocation == null)
            {
                MessageBox.Show("Could not locate address.");
            }
            else
            {
                MessageBox.Show("Address location found.");
                addressLocation = newLocation;
                this.Hide();
            }
        }
       
        private void frm_address_Load(object sender, EventArgs e)
        {
           
        }

        private Location addressLocation;
        public Location AddressLocation
        {
            get
            {
                return addressLocation;
            }
        }

        private string unit;
        private string streetNumber;
        private string street;
        private string suburb;
        private string state;
        private string postcode;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
