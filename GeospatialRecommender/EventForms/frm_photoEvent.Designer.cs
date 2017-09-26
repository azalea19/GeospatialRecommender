namespace GeospatialRecommender.EventForms
{
    partial class frm_photoEvent
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
            this.pb_preview = new System.Windows.Forms.PictureBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_choosePhoto = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_preview
            // 
            this.pb_preview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_preview.Location = new System.Drawing.Point(12, 12);
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.Size = new System.Drawing.Size(320, 240);
            this.pb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_preview.TabIndex = 0;
            this.pb_preview.TabStop = false;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(12, 258);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(320, 20);
            this.dtPicker.TabIndex = 1;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // btn_choosePhoto
            // 
            this.btn_choosePhoto.Location = new System.Drawing.Point(12, 286);
            this.btn_choosePhoto.Name = "btn_choosePhoto";
            this.btn_choosePhoto.Size = new System.Drawing.Size(88, 42);
            this.btn_choosePhoto.TabIndex = 2;
            this.btn_choosePhoto.Text = "Upload Photo";
            this.btn_choosePhoto.UseVisualStyleBackColor = true;
            this.btn_choosePhoto.Click += new System.EventHandler(this.btn_choosePhoto_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(134, 286);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(88, 43);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(244, 286);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 43);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_photoEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 347);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_choosePhoto);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.pb_preview);
            this.Name = "frm_photoEvent";
            this.Text = "Add Photo Event";
            this.Load += new System.EventHandler(this.frm_photoEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_preview;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_choosePhoto;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
    }
}