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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
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
            // 
            // btn_addStatus
            // 
            this.btn_addStatus.Location = new System.Drawing.Point(102, 12);
            this.btn_addStatus.Name = "btn_addStatus";
            this.btn_addStatus.Size = new System.Drawing.Size(86, 40);
            this.btn_addStatus.TabIndex = 1;
            this.btn_addStatus.Text = "Add Status Update Event";
            this.btn_addStatus.UseVisualStyleBackColor = true;
            // 
            // btn_addVideo
            // 
            this.btn_addVideo.Location = new System.Drawing.Point(57, 58);
            this.btn_addVideo.Name = "btn_addVideo";
            this.btn_addVideo.Size = new System.Drawing.Size(84, 40);
            this.btn_addVideo.TabIndex = 2;
            this.btn_addVideo.Text = "Add Video Event";
            this.btn_addVideo.UseVisualStyleBackColor = true;
            // 
            // btn_addTweet
            // 
            this.btn_addTweet.Location = new System.Drawing.Point(147, 58);
            this.btn_addTweet.Name = "btn_addTweet";
            this.btn_addTweet.Size = new System.Drawing.Size(86, 40);
            this.btn_addTweet.TabIndex = 3;
            this.btn_addTweet.Text = "Add Tweet Event";
            this.btn_addTweet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Track Log Event";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(57, 117);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(84, 23);
            this.btn_help.TabIndex = 6;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // frm_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 147);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addTweet);
            this.Controls.Add(this.btn_addVideo);
            this.Controls.Add(this.btn_addStatus);
            this.Controls.Add(this.btn_addPhoto);
            this.Name = "frm_add";
            this.Text = "Add Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addPhoto;
        private System.Windows.Forms.Button btn_addStatus;
        private System.Windows.Forms.Button btn_addVideo;
        private System.Windows.Forms.Button btn_addTweet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_help;
    }
}