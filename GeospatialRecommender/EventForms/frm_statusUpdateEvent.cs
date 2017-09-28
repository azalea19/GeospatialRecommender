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
    public partial class frm_statusUpdateEvent : Form
    {
        public frm_statusUpdateEvent()
        {
            InitializeComponent();
            statusText = null;           
        }

        public void ShowForm()
        {
            txt_statusUpdate.Text = "";
            this.ShowDialog();
        }

        public string StatusText
        {
            get
            {
                return statusText;
            }
        }
        public DateTime DT
        {
            get
            {
                return dt;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            statusText = txt_statusUpdate.Text;
            dt = dtPicker.Value;
            this.Hide();
        }

        private void frm_statusUpdate_Load(object sender, EventArgs e)
        {

        }

        private string statusText;
        private DateTime dt;

    }
}
