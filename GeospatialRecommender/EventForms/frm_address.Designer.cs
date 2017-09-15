namespace GeospatialRecommender.EventForms
{
    partial class btn_cancel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(273, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(138, 109);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(219, 109);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(75, 23);
            this.btn_.TabIndex = 9;
            this.btn_.Text = "Cancel";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 138);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_suburb);
            this.Controls.Add(this.lbl_postcode);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.lbl_street);
            this.Name = "btn_cancel";
            this.Text = "Add Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label lbl_postcode;
        private System.Windows.Forms.Label lbl_suburb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_;
    }
}