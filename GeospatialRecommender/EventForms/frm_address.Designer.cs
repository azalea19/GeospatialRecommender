namespace GeospatialRecommender.EventForms
{
    partial class frm_address
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
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.lbl_postcode = new System.Windows.Forms.Label();
            this.lbl_suburb = new System.Windows.Forms.Label();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(9, 40);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(41, 13);
            this.lbl_street.TabIndex = 0;
            this.lbl_street.Text = "Street: ";
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Location = new System.Drawing.Point(9, 13);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(29, 13);
            this.lbl_unit.TabIndex = 1;
            this.lbl_unit.Text = "Unit:";
            // 
            // lbl_postcode
            // 
            this.lbl_postcode.AutoSize = true;
            this.lbl_postcode.Location = new System.Drawing.Point(9, 90);
            this.lbl_postcode.Name = "lbl_postcode";
            this.lbl_postcode.Size = new System.Drawing.Size(55, 13);
            this.lbl_postcode.TabIndex = 2;
            this.lbl_postcode.Text = "Postcode:";
            // 
            // lbl_suburb
            // 
            this.lbl_suburb.AutoSize = true;
            this.lbl_suburb.Location = new System.Drawing.Point(9, 65);
            this.lbl_suburb.Name = "lbl_suburb";
            this.lbl_suburb.Size = new System.Drawing.Size(44, 13);
            this.lbl_suburb.TabIndex = 3;
            this.lbl_suburb.Text = "Suburb:";
            // 
            // txt_unit
            // 
            this.txt_unit.Location = new System.Drawing.Point(78, 6);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(273, 20);
            this.txt_unit.TabIndex = 4;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(78, 33);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(273, 20);
            this.txt_street.TabIndex = 5;
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(78, 58);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(273, 20);
            this.txt_suburb.TabIndex = 6;
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(78, 83);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(273, 20);
            this.txt_postcode.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(138, 109);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(219, 109);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(75, 23);
            this.btn_.TabIndex = 9;
            this.btn_.Text = "Cancel";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // btn_cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 138);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.txt_suburb);
            this.Controls.Add(this.txt_street);
            this.Controls.Add(this.txt_unit);
            this.Controls.Add(this.lbl_suburb);
            this.Controls.Add(this.lbl_postcode);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.lbl_street);
            this.Name = "btn_cancel";
            this.Text = "Add Address";
            this.Load += new System.EventHandler(this.frm_address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label lbl_postcode;
        private System.Windows.Forms.Label lbl_suburb;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_;
    }
}