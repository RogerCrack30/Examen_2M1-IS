﻿
namespace WeatherConcurrencyApp
{
    partial class DetailsWeather
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblDetailValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(16, 11);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(75, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "DetailWeather";
            this.lblDetail.Click += new System.EventHandler(this.lblDetail_Click);
            // 
            // lblDetailValue
            // 
            this.lblDetailValue.AutoSize = true;
            this.lblDetailValue.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblDetailValue.Location = new System.Drawing.Point(31, 42);
            this.lblDetailValue.Name = "lblDetailValue";
            this.lblDetailValue.Size = new System.Drawing.Size(43, 13);
            this.lblDetailValue.TabIndex = 1;
            this.lblDetailValue.Text = "Value";
            // 
            // DetailsWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetailValue);
            this.Controls.Add(this.lblDetail);
            this.Name = "DetailsWeather";
            this.Size = new System.Drawing.Size(106, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.Label lblDetailValue;
    }
}
