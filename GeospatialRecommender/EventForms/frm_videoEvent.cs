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
    public partial class frm_videoEvent : Form
    {
        public frm_videoEvent()
        {
            InitializeComponent();
            filePrefix = "../../../../EventData/";
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Video Files(*.avi; *.mp3; *.mp4; *.wmv)|*.avi; *.mp3; *.mp4; *.wmv";
            if (fd.ShowDialog() == DialogResult.OK)
            {                
            }
        }

        private string filePrefix;
    }
}
