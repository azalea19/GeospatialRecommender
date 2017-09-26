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
    public partial class frm_address : Form
    {
        public frm_address()
        {
            InitializeComponent();
            unit = null;
            street = null;
            suburb = null;
            postcode = null;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            unit = txt_unit.Text;
            street = txt_street.Text;
            suburb = txt_suburb.Text;
            postcode = txt_postcode.Text;
        }

        private void btn__Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ShowForm()
        {
            unit = null;
            street = null;
            suburb = null;
            postcode = null;
            this.ShowDialog();
        }
               
        private void frm_address_Load(object sender, EventArgs e)
        {

        }

        private string unit { set; get; }
        private string street { set; get; }
        private string suburb { set; get; }
        private string postcode { set; get; }

    }
}
