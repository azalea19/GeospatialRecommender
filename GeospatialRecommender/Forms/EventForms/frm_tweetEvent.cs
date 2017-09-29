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
    public partial class frm_tweetEvent : Form
    {
        public frm_tweetEvent()
        {
            InitializeComponent();
            tweetText = null;
        }

        public void ShowForm(Location eventLocation)
        {
            this.eventLocation = eventLocation;
            txt_tweet.Text = null;
            this.ShowDialog();
        }

        private bool Ready()
        {
            if (tweetText == null)
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
            tweetText = txt_tweet.Text;
            dt = dtPicker.Value;

            if (Ready())
            {
                Event newEvent = new TweetEvent(new GRLocation(eventLocation.Latitude, eventLocation.Longitude), dt.ToString(), tweetText);
                GREventManager.AddEvent(newEvent);
                MessageBox.Show("Event successfully added!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Could not add event.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            dt = dtPicker.Value;
        }

        private void frm_tweetEvent_Load(object sender, EventArgs e)
        {

        }

        private Location eventLocation;
        private string tweetText;
        private DateTime dt;
    }
}
