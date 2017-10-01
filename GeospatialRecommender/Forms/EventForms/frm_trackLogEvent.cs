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
    public partial class frm_trackLogEvent : Form
    {
        public frm_trackLogEvent()
        {
            InitializeComponent();
            fileName = null;
            dt = dtPicker.Value;
            eventLocation = null;
        }

        public void ShowForm(Location eventLocation)
        {
            this.eventLocation = eventLocation;
            this.ShowDialog();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Track Log Files(*.gpx;)|*.gpx";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                fileName = Path.GetFileName(fd.FileName);             
                if (fd.FileName != Path.GetFullPath(GREventManager.GetDataPath() + fileName))
                {
                    System.IO.File.Copy(fd.FileName, GREventManager.GetDataPath() + fileName, true);
                    dt = dtPicker.Value;
                }
            }

        }
       
        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            dt = dtPicker.Value;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool Ready()
        {
            if (fileName == null)
            {
                MessageBox.Show("Please select a track log to upload.");
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
            dt = dtPicker.Value;
            if (Ready())
            {
                Event newEvent = new TrackLogEvent(new GRLocation(eventLocation.Latitude, eventLocation.Longitude), fileName, dt.ToString(), dt.ToString());
                GREventManager.AddEvent(newEvent);
                MessageBox.Show("Event successfully added!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Could not add event.");
            }
        }

        private Location eventLocation;
        private string fileName;
        private DateTime dt;
    }
}
