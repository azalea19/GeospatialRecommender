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
    public partial class frm_photoEvent : Form
    {
        public frm_photoEvent()
        {
            InitializeComponent();
            picture = null;
        }

        private void btn_choosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(fd.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(fd.FileName);
                pb_preview.Image = Picture;
            }
        }

        public void ShowForm()
        {
            picture = null;
            this.ShowDialog();
        }

        
        private void frm_photoEvent_Load(object sender, EventArgs e)
        {
            
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            dateTime = dtPicker.Value;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Bitmap picture;
        private DateTime dateTime;
        private GRLocation eventLocation;

        public new GRLocation Location
        {
            get
            {
                return eventLocation;
            }
        }
        public Bitmap Picture
        {
            get
            {
                return picture;
            }
        }
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }
    }
}
