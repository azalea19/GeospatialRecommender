using GeospatialRecommender.Events;
using GeospatialRecommender.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeospatialRecommender.Forms
{
    public partial class frm_createNewLog : Form
    {
        public frm_createNewLog()
        {
            InitializeComponent();
            fileName = null;
        }

        public string GetFileName()
        {
            return fileName;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            fileName = txt_fileName.Text;
            GREventManager.ClearMap();
            MapUserControl.ClearEventDisplay();   
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string fileName;
    }
}
