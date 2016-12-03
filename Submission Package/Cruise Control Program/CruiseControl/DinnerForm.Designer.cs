﻿namespace CruiseControl
{
    partial class DinnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinnerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSitting = new System.Windows.Forms.ComboBox();
            this.cbDeck = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSitting);
            this.groupBox1.Controls.Add(this.cbDeck);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbSitting
            // 
            this.cbSitting.FormattingEnabled = true;
            this.cbSitting.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSitting.Location = new System.Drawing.Point(7, 46);
            this.cbSitting.Name = "cbSitting";
            this.cbSitting.Size = new System.Drawing.Size(114, 21);
            this.cbSitting.TabIndex = 2;
            this.cbSitting.Text = "Select Sitting";
            this.cbSitting.SelectedIndexChanged += new System.EventHandler(this.cbSitting_SelectedIndexChanged);
            // 
            // cbDeck
            // 
            this.cbDeck.FormattingEnabled = true;
            this.cbDeck.Location = new System.Drawing.Point(7, 19);
            this.cbDeck.Name = "cbDeck";
            this.cbDeck.Size = new System.Drawing.Size(114, 21);
            this.cbDeck.TabIndex = 1;
            this.cbDeck.Text = "Select Date";
            this.cbDeck.SelectedIndexChanged += new System.EventHandler(this.cbDeck_SelectedIndexChanged);
            // 
            // DinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DinnerForm";
            this.Text = "CRUISE CONTROL: Dinner Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDeck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbSitting;
    }
}

