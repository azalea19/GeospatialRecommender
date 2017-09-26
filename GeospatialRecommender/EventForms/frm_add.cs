using GeospatialRecommender.EventForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeospatialRecommender
{
    public partial class frm_add : Form
    {
        public frm_add()
        {
            InitializeComponent();
            photoEventForm = new frm_photoEvent();
            photoEvent = null;
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

        }

        private void btn_addVideo_Click(object sender, EventArgs e)
        {

        }

        private void btn_addTweet_Click(object sender, EventArgs e)
        {

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

        private frm_photoEvent photoEventForm;
        private PhotoEvent photoEvent;
    }
}
