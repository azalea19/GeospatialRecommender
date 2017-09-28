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
            newEvent = null;
            videoEventForm = new frm_videoEvent();
            statusUpdateForm = new frm_statusUpdateEvent();
            tweetEventForm = new frm_tweetEvent();
            addressForm = new frm_address();
            eventLocation = null;
        }

        public void ShowForm(Location eventLocation)
        {
            this.eventLocation = eventLocation;
            this.ShowDialog();
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            photoEventForm.ShowForm();
            
        }

        private void frm_add_Load(object sender, EventArgs e)
        {

        }

        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            statusUpdateForm.ShowForm();
        }

        private void btn_addVideo_Click(object sender, EventArgs e)
        {
            videoEventForm.ShowDialog();
        }

        private void btn_addTweet_Click(object sender, EventArgs e)
        {
            tweetEventForm.ShowForm();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
        }     

        private void btn_addlog_Click(object sender, EventArgs e)
        {

        }

        private void btn_changeLocation_Click(object sender, EventArgs e)
        {
            addressForm.ShowForm();
            if(addressForm.AddressLocation != null)
            {
                eventLocation = new Location(addressForm.AddressLocation.Point.Coordinates[0], addressForm.AddressLocation.Point.Coordinates[1]);
            }            
        }

        private frm_photoEvent photoEventForm;       
        private frm_videoEvent videoEventForm;
        private frm_statusUpdateEvent statusUpdateForm;
        private frm_tweetEvent tweetEventForm;
        private frm_address addressForm;

        private Event newEvent;
        private Location eventLocation;  
    }
}
