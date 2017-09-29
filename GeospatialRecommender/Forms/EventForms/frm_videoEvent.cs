using GeospatialRecommender.Events;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeospatialRecommender.EventForms
{
    public partial class frm_videoEvent : Form
    {
        public frm_videoEvent()
        {
            InitializeComponent();
            fileName = null;
        }

        public void ShowForm(Location eventLocation)
        {
            fileName = null;
            this.eventLocation = eventLocation;
            this.ShowDialog();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Video Files(*.avi; *.mp3; *.mp4; *.wmv)|*.avi; *.mp3; *.mp4; *.wmv";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                fileName = Path.GetFileName(fd.FileName);
                System.IO.File.Copy(fd.FileName, GREventManager.GetDataPath() + fileName);
            }
        }

        private void frm_videoEvent_Load(object sender, EventArgs e)
        {

        }

        private bool Ready()
        {
            if(fileName == null)
            {
                MessageBox.Show("Please select a video to upload.");
                return false;
            }
            if(eventLocation == null)
            {
                MessageBox.Show("No location data found for event.");
                return false;
            }
            return true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(Ready())
            {
                Event newEvent = new VideoEvent(new GRLocation(eventLocation.Latitude, eventLocation.Longitude), fileName, dt.ToString(), dt.ToString());
                GREventManager.AddEvent(newEvent);
                MessageBox.Show("Event successfully added!");
            }
            else
            {
                MessageBox.Show("Could not add event.");
            }
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt = dtPicker.Value;
        }

        private Location eventLocation;
        private string fileName;
        private DateTime dt;

        
    }
}
