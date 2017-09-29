using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using Microsoft.Maps.MapControl.WPF;
using System.Windows.Input;
using GeospatialRecommender.Events;
using GeospatialRecommender.Utility;
using GeospatialRecommender.Forms;
using System.IO;

namespace GeospatialRecommender.EventForms
{
    public partial class frm_mapDisplay : Form
    {
        
        public frm_mapDisplay()
        {
            InitializeComponent();
            MyMapUserControl.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AqXJFUzQQmH8NRmKObTCFXN_F0_0998xlZOdMhxr1rQWVUh9FcJ--LgR3Ns-0T6l");            
            createNewForm = new frm_createNewLog();
            fileName = null;
        }

        private void frm_mapDisplay_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_eventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapUserControl.DisplayEvents(cmb_eventType.SelectedIndex);
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(fileName == null)
            {
                MessageBox.Show("Filename not specified. Please create a new file or load an event file");
            }
            else
            {
                EventWriter.NewDocument(fileName);
            }         
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Xml Files(*.xml;)|*.xml;";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                fileName = Path.GetFileName(filePath);
                lbl_logName.Text = fileName;
                GREventManager.LoadEvents(filePath);               
            }
            MapUserControl.DisplayEvents(cmb_eventType.SelectedIndex);

        }
        
        private void btn_new_Click(object sender, EventArgs e)
        {
            createNewForm.ShowDialog();
            fileName = createNewForm.GetFileName();
            lbl_logName.Text = fileName;
        }

        private string fileName;
        private frm_createNewLog createNewForm;
    }
}
