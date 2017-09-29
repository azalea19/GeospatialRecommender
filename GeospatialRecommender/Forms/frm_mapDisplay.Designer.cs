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
            this.grp_eventDisplay = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_eventType = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_logName = new System.Windows.Forms.Label();
            this.elementHost_map = new System.Windows.Forms.Integration.ElementHost();
            this.MyMapUserControl = new GeospatialRecommender.MapUserControl();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_eventDisplay.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_new);
            this.splitContainer1.Panel1.Controls.Add(this.btn_save);
            this.splitContainer1.Panel1.Controls.Add(this.btn_load);
            this.splitContainer1.Panel1.Controls.Add(this.grp_eventDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.elementHost_map);
            this.splitContainer1.Size = new System.Drawing.Size(692, 425);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_eventDisplay
            // 
            this.grp_eventDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_eventDisplay.Controls.Add(this.lbl_logName);
            this.grp_eventDisplay.Controls.Add(this.label2);
            this.grp_eventDisplay.Controls.Add(this.label1);
            this.grp_eventDisplay.Controls.Add(this.cmb_eventType);
            this.grp_eventDisplay.Location = new System.Drawing.Point(15, 204);
            this.grp_eventDisplay.Name = "grp_eventDisplay";
            this.grp_eventDisplay.Size = new System.Drawing.Size(201, 132);
            this.grp_eventDisplay.TabIndex = 0;
            this.grp_eventDisplay.TabStop = false;
            this.grp_eventDisplay.Text = "Display Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Type";
            // 
            // cmb_eventType
            // 
            this.cmb_eventType.FormattingEnabled = true;
            this.cmb_eventType.Items.AddRange(new object[] {
            "(None)",
            "Tweet ",
            "Facebook Status Update",
            "Photo",
            "Video",
            "Tracklog",
            "All"});
            this.cmb_eventType.Location = new System.Drawing.Point(9, 96);
            this.cmb_eventType.Name = "cmb_eventType";
            this.cmb_eventType.Size = new System.Drawing.Size(185, 21);
            this.cmb_eventType.TabIndex = 0;
            this.cmb_eventType.Text = "(None)";
            this.cmb_eventType.SelectedIndexChanged += new System.EventHandler(this.cmb_eventType_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(16, 78);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(200, 58);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load Event Log";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(16, 142);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 56);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save Log";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Log Loaded:";
            // 
            // lbl_logName
            // 
            this.lbl_logName.AutoSize = true;
            this.lbl_logName.Location = new System.Drawing.Point(9, 54);
            this.lbl_logName.Name = "lbl_logName";
            this.lbl_logName.Size = new System.Drawing.Size(61, 13);
            this.lbl_logName.TabIndex = 3;
            this.lbl_logName.Text = "------------------";
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
            this.elementHost_map.Child = this.MyMapUserControl;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(16, 13);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(200, 59);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "New Log";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
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
            this.grp_eventDisplay.ResumeLayout(false);
            this.grp_eventDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Integration.ElementHost elementHost_map;
        private MapUserControl MyMapUserControl;
        private System.Windows.Forms.GroupBox grp_eventDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_eventType;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_logName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_new;
    }
}