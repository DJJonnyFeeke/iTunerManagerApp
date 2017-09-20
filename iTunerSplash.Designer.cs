using System.ComponentModel;
using System.Windows.Forms;
using iTunerCustomControls.Controls;

namespace iTunerManagerApp
{
    partial class TunerSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerSplash));
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.pnlSplash = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblApp = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.pnlSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSplash
            // 
            this.picSplash.BackColor = System.Drawing.Color.Transparent;
            this.picSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSplash.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picSplash.Image = global::iTunerManagerApp.Properties.Resources.circularLoadingGif;
            this.picSplash.Location = new System.Drawing.Point(3, 3);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(494, 299);
            this.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSplash.TabIndex = 0;
            this.picSplash.TabStop = false;
            // 
            // pnlSplash
            // 
            this.pnlSplash.BackColor = System.Drawing.Color.White;
            this.pnlSplash.BackgroundImage = global::iTunerManagerApp.Properties.Resources.ImagePattern;
            this.pnlSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSplash.Controls.Add(this.lblCopyright);
            this.pnlSplash.Controls.Add(this.picSplash);
            this.pnlSplash.Controls.Add(this.lblApp);
            this.pnlSplash.Location = new System.Drawing.Point(1, 1);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(502, 394);
            this.pnlSplash.TabIndex = 2;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCopyright.Location = new System.Drawing.Point(11, 357);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(477, 25);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2017. All Rights Reserved.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApp
            // 
            this.lblApp.BackColor = System.Drawing.Color.Transparent;
            this.lblApp.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.Color.Black;
            this.lblApp.Location = new System.Drawing.Point(3, 305);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(494, 53);
            this.lblApp.TabIndex = 3;
            this.lblApp.Text = "iTuner Manager";
            this.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TunerSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(505, 397);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSplash);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TunerSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.pnlSplash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picSplash;
        private Panel pnlSplash;
        private Label lblCopyright;
        private TunerLabelWithBorder lblApp;
    }
}