using System.ComponentModel;
using System.Windows.Forms;

namespace iTunerManagerApp
{
    partial class Tuner3RdParty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tuner3RdParty));
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbLicense
            // 
            this.rtbLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLicense.ForeColor = System.Drawing.Color.White;
            this.rtbLicense.Location = new System.Drawing.Point(12, 76);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(395, 203);
            this.rtbLicense.TabIndex = 0;
            this.rtbLicense.Text = resources.GetString("rtbLicense.Text");
            // 
            // iTuner3rdParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 291);
            this.Controls.Add(this.rtbLicense);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tuner3RdParty";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTuner Manager License";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbLicense;

    }
}