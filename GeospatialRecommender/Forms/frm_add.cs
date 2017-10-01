using GeospatialRecommender.EventForms;
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
using Microsoft.Maps.MapControl.WPF;

namespace GeospatialRecommender
{
    public partial class frm_add : Form
    {
        public frm_add()
        {
            InitializeComponent();
            photoEventForm = new frm_photoEvent();
            videoEventForm = new frm_videoEvent();
            statusUpdateForm = new frm_statusUpdateEvent();
            tweetEventForm = new frm_tweetEvent();
            addressForm = new frm_address();
            trackLogEventForm = new frm_trackLogEvent();
            eventLocation = null;
        }

        public void ShowForm(Location eventLocation)
        {
            this.eventLocation = eventLocation;
            this.ShowDialog();
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            photoEventForm.ShowForm(eventLocation);
            this.Hide();       
        }

        private void frm_add_Load(object sender, EventArgs e)
        {

        }

        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            statusUpdateForm.ShowForm(eventLocation);
            this.Hide();         
        }

        private void btn_addVideo_Click(object sender, EventArgs e)
        {
            videoEventForm.ShowForm(eventLocation);
            this.Hide();
        }

        private void btn_addTweet_Click(object sender, EventArgs e)
        {
            tweetEventForm.ShowForm(eventLocation);
            this.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {       
            this.Hide();
        }     

        private void btn_addlog_Click(object sender, EventArgs e)
        {
            trackLogEventForm.ShowForm(eventLocation);
            this.Hide();
        }

        private void btn_changeLocation_Click(object sender, EventArgs e)
        {
            addressForm.ShowForm();
            if(addressForm.AddressLocation != null)
            {
                eventLocation = new Location(addressForm.AddressLocation.Point.Coordinates[0], addressForm.AddressLocation.Point.Coordinates[1]);
            }            
        }

        private void frm_add_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private frm_photoEvent photoEventForm;       
        private frm_videoEvent videoEventForm;
        private frm_statusUpdateEvent statusUpdateForm;
        private frm_tweetEvent tweetEventForm;
        private frm_address addressForm;
        private frm_trackLogEvent trackLogEventForm;

        private Location eventLocation;
       
    }
}
