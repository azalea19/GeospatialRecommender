namespace GeospatialRecommender
{
    partial class frm_add
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
            this.btn_addPhoto = new System.Windows.Forms.Button();
            this.btn_addStatus = new System.Windows.Forms.Button();
            this.btn_addVideo = new System.Windows.Forms.Button();
            this.btn_addTweet = new System.Windows.Forms.Button();
            this.btn_addlog = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_changeLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addPhoto
            // 
            this.btn_addPhoto.Location = new System.Drawing.Point(12, 12);
            this.btn_addPhoto.Name = "btn_addPhoto";
            this.btn_addPhoto.Size = new System.Drawing.Size(84, 40);
            this.btn_addPhoto.TabIndex = 0;
            this.btn_addPhoto.Text = "Add Photo Event";
            this.btn_addPhoto.UseVisualStyleBackColor = true;
            this.btn_addPhoto.Click += new System.EventHandler(this.btn_addPhoto_Click);
            // 
            // btn_addStatus
            // 
            this.btn_addStatus.Location = new System.Drawing.Point(102, 12);
            this.btn_addStatus.Name = "btn_addStatus";
            this.btn_addStatus.Size = new System.Drawing.Size(86, 40);
            this.btn_addStatus.TabIndex = 1;
            this.btn_addStatus.Text = "Add Status Update Event";
            this.btn_addStatus.UseVisualStyleBackColor = true;
            this.btn_addStatus.Click += new System.EventHandler(this.btn_addStatus_Click);
            // 
            // btn_addVideo
            // 
            this.btn_addVideo.Location = new System.Drawing.Point(12, 58);
            this.btn_addVideo.Name = "btn_addVideo";
            this.btn_addVideo.Size = new System.Drawing.Size(84, 40);
            this.btn_addVideo.TabIndex = 2;
            this.btn_addVideo.Text = "Add Video Event";
            this.btn_addVideo.UseVisualStyleBackColor = true;
            this.btn_addVideo.Click += new System.EventHandler(this.btn_addVideo_Click);
            // 
            // btn_addTweet
            // 
            this.btn_addTweet.Location = new System.Drawing.Point(102, 58);
            this.btn_addTweet.Name = "btn_addTweet";
            this.btn_addTweet.Size = new System.Drawing.Size(86, 40);
            this.btn_addTweet.TabIndex = 3;
            this.btn_addTweet.Text = "Add Tweet Event";
            this.btn_addTweet.UseVisualStyleBackColor = true;
            this.btn_addTweet.Click += new System.EventHandler(this.btn_addTweet_Click);
            // 
            // btn_addlog
            // 
            this.btn_addlog.Location = new System.Drawing.Point(194, 12);
            this.btn_addlog.Name = "btn_addlog";
            this.btn_addlog.Size = new System.Drawing.Size(84, 40);
            this.btn_addlog.TabIndex = 4;
            this.btn_addlog.Text = "Add Track Log Event";
            this.btn_addlog.UseVisualStyleBackColor = true;
            this.btn_addlog.Click += new System.EventHandler(this.btn_addlog_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(149, 117);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(57, 117);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(84, 23);
            this.btn_help.TabIndex = 6;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_changeLocation
            // 
            this.btn_changeLocation.Location = new System.Drawing.Point(194, 58);
            this.btn_changeLocation.Name = "btn_changeLocation";
            this.btn_changeLocation.Size = new System.Drawing.Size(84, 40);
            this.btn_changeLocation.TabIndex = 7;
            this.btn_changeLocation.Text = "Change Location";
            this.btn_changeLocation.UseVisualStyleBackColor = true;
            this.btn_changeLocation.Click += new System.EventHandler(this.btn_changeLocation_Click);
            // 
            // frm_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 147);
            this.Controls.Add(this.btn_changeLocation);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addlog);
            this.Controls.Add(this.btn_addTweet);
            this.Controls.Add(this.btn_addVideo);
            this.Controls.Add(this.btn_addStatus);
            this.Controls.Add(this.btn_addPhoto);
            this.Name = "frm_add";
            this.Text = "Add Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_add_FormClosing);
            this.Load += new System.EventHandler(this.frm_add_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addPhoto;
        private System.Windows.Forms.Button btn_addStatus;
        private System.Windows.Forms.Button btn_addVideo;
        private System.Windows.Forms.Button btn_addTweet;
        private System.Windows.Forms.Button btn_addlog;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_changeLocation;
    }
}