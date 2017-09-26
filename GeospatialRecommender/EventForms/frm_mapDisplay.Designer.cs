namespace GeospatialRecommender.EventForms
{
    partial class frm_mapDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.elementHost_map = new System.Windows.Forms.Integration.ElementHost();
            this.MyMapUserControl = new GeospatialRecommender.MapUserControl();
            this.btn_addPolygon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_addPolygon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.elementHost_map);
            this.splitContainer1.Size = new System.Drawing.Size(692, 425);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // elementHost_map
            // 
            this.elementHost_map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost_map.Location = new System.Drawing.Point(0, 0);
            this.elementHost_map.Margin = new System.Windows.Forms.Padding(0);
            this.elementHost_map.Name = "elementHost_map";
            this.elementHost_map.Size = new System.Drawing.Size(458, 425);
            this.elementHost_map.TabIndex = 1;
            this.elementHost_map.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost_map_ChildChanged);
            this.elementHost_map.Child = this.MyMapUserControl;
            // 
            // btn_addPolygon
            // 
            this.btn_addPolygon.Location = new System.Drawing.Point(61, 61);
            this.btn_addPolygon.Name = "btn_addPolygon";
            this.btn_addPolygon.Size = new System.Drawing.Size(75, 23);
            this.btn_addPolygon.TabIndex = 0;
            this.btn_addPolygon.Text = "Add Polygon";
            this.btn_addPolygon.UseVisualStyleBackColor = true;
            this.btn_addPolygon.Click += new System.EventHandler(this.btn_addPolygon_Click);
            // 
            // frm_mapDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 425);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_mapDisplay";
            this.Text = "Manage Events";
            this.Load += new System.EventHandler(this.frm_mapDisplay_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Integration.ElementHost elementHost_map;
        private MapUserControl MyMapUserControl;
        private System.Windows.Forms.Button btn_addPolygon;
    }
}