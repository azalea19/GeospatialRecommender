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

        public void ShowForm()
        {
            txt_tweet.Text = "";
            this.ShowDialog();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            tweetText = txt_tweet.Text;
            dt = dtPicker.Value;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            dt = dtPicker.Value;
        }

        private string tweetText;
        private DateTime dt;
    }
}
