using System.ComponentModel;
using iTunerCustomControls.Controls;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    partial class TunerMainMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerMainMessage));
            this.iTunerLabel = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.btnOk = new iTunerSkin.Controls.iTunerRaisedButton();
            this.SuspendLayout();
            // 
            // iTunerLabel
            // 
            this.iTunerLabel.BackColor = System.Drawing.Color.Transparent;
            this.iTunerLabel.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.iTunerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTunerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iTunerLabel.Location = new System.Drawing.Point(12, 68);
            this.iTunerLabel.Name = "iTunerLabel";
            this.iTunerLabel.Size = new System.Drawing.Size(561, 53);
            this.iTunerLabel.TabIndex = 3;
            this.iTunerLabel.Text = "Messages will be shown here...";
            this.iTunerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Depth = 0;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(578, 77);
            this.btnOk.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Primary = true;
            this.btnOk.Size = new System.Drawing.Size(35, 36);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // TunerMainMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 130);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.iTunerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TunerMainMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TunerLabelWithBorder iTunerLabel;
        private iTunerRaisedButton btnOk;
    }
}