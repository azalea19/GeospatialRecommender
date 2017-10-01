namespace GeospatialRecommender.EventForms
{
    partial class frm_trackLogEvent
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(12, 38);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(86, 51);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Upload Track Log";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(12, 12);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(265, 20);
            this.dtPicker.TabIndex = 1;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(197, 38);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 51);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(104, 38);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 51);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // frm_trackLogEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 98);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btn_upload);
            this.Name = "frm_trackLogEvent";
            this.Text = "Add Track Log Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
    }
}