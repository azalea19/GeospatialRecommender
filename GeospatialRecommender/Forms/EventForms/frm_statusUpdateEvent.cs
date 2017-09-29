using GeospatialRecommender.Events;
using Microsoft.Maps.MapControl.WPF;
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
    public partial class frm_statusUpdateEvent : Form
    {
        public frm_statusUpdateEvent()
        {
            InitializeComponent();
            statusText = null;           
        }

        public void ShowForm(Location eventLocation)
        {
            this.eventLocation = eventLocation;
            txt_statusUpdate.Text = null;
            this.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool Ready()
        {
            if (statusText == null)
            {
                MessageBox.Show("Please enter a status update.");
                return false;
            }
            if (eventLocation == null)
            {
                MessageBox.Show("No location data found for event.");
                return false;
            }
            return true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            statusText = txt_statusUpdate.Text;
            dt = dtPicker.Value;

            if (Ready())
            {
                Event newEvent = new StatusUpdateEvent(new GRLocation(eventLocation.Latitude, eventLocation.Longitude), dt.ToString(), statusText);
                GREventManager.AddEvent(newEvent);
                MessageBox.Show("Event successfully added!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Could not add event.");
            }
        }

        private void frm_statusUpdate_Load(object sender, EventArgs e)
        {

        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            dt = dtPicker.Value;
        }

        private Location eventLocation;
        private string statusText;
        private DateTime dt;
    }
}
