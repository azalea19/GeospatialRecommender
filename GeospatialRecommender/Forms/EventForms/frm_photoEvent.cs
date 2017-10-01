using GeospatialRecommender.Events;
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
using Microsoft.Maps.MapControl.WPF;

namespace GeospatialRecommender.EventForms
{
    public partial class frm_photoEvent : Form
    {
        public frm_photoEvent()
        {
            InitializeComponent();
            fileName = null;
            eventLocation = null;
            dt = dtPicker.Value;
        }

        private void btn_choosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                fileName = Path.GetFileName(fd.FileName);
                pb_preview.Image = new Bitmap(new Bitmap(fd.FileName));
                if(fd.FileName != Path.GetFullPath(GREventManager.GetDataPath() + fileName))
                {
                    System.IO.File.Copy(fd.FileName, GREventManager.GetDataPath() + fileName, true);
                }
            }
        }

        public void ShowForm(Location eventLocation)
        {
            fileName = null;
            this.eventLocation = eventLocation;
            this.ShowDialog();
        }

        private void frm_photoEvent_Load(object sender, EventArgs e)
        {
            
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            dt = dtPicker.Value;
        }

        private bool Ready()
        {
            if (fileName == null)
            {
                MessageBox.Show("Please select a photo to upload.");
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
                Event newEvent = new PhotoEvent(new GRLocation(eventLocation.Latitude, eventLocation.Longitude), dt.ToString(),fileName);
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
