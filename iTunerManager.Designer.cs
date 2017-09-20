using System.ComponentModel;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    partial class TunerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerManager));
            this.btnEditDatabase = new iTunerSkin.Controls.iTunerFlatButton();
            this.btnOpenViewer = new iTunerSkin.Controls.iTunerFlatButton();
            this.btniTunerAbout = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnViewManager = new iTunerSkin.Controls.iTunerFlatButton();
            this.iTunerDivider1 = new iTunerSkin.Controls.iTunerDivider();
            this.btniTuner3RdParty = new iTunerSkin.Controls.iTunerRaisedButton();
            this.SuspendLayout();
            // 
            // btnEditDatabase
            // 
            this.btnEditDatabase.AutoSize = true;
            this.btnEditDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDatabase.Depth = 0;
            this.btnEditDatabase.Icon = null;
            this.btnEditDatabase.Location = new System.Drawing.Point(13, 70);
            this.btnEditDatabase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditDatabase.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnEditDatabase.Name = "btnEditDatabase";
            this.btnEditDatabase.Primary = false;
            this.btnEditDatabase.Size = new System.Drawing.Size(113, 36);
            this.btnEditDatabase.TabIndex = 2;
            this.btnEditDatabase.Text = "Database Tools";
            this.btnEditDatabase.UseVisualStyleBackColor = true;
            this.btnEditDatabase.Click += new System.EventHandler(this.btnEditDatabase_Click);
            // 
            // btnOpenViewer
            // 
            this.btnOpenViewer.AutoSize = true;
            this.btnOpenViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenViewer.Depth = 0;
            this.btnOpenViewer.Enabled = false;
            this.btnOpenViewer.Icon = null;
            this.btnOpenViewer.Location = new System.Drawing.Point(252, 70);
            this.btnOpenViewer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenViewer.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnOpenViewer.Name = "btnOpenViewer";
            this.btnOpenViewer.Primary = false;
            this.btnOpenViewer.Size = new System.Drawing.Size(59, 36);
            this.btnOpenViewer.TabIndex = 3;
            this.btnOpenViewer.Text = "Viewer";
            this.btnOpenViewer.UseVisualStyleBackColor = true;
            this.btnOpenViewer.Click += new System.EventHandler(this.btnOpenViewer_Click);
            // 
            // btniTunerAbout
            // 
            this.btniTunerAbout.AutoSize = true;
            this.btniTunerAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btniTunerAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniTunerAbout.Depth = 0;
            this.btniTunerAbout.Icon = global::iTunerManagerApp.Properties.Resources.About;
            this.btniTunerAbout.Location = new System.Drawing.Point(318, 70);
            this.btniTunerAbout.MouseState = iTunerSkin.MouseState.HOVER;
            this.btniTunerAbout.Name = "btniTunerAbout";
            this.btniTunerAbout.Primary = true;
            this.btniTunerAbout.Size = new System.Drawing.Size(44, 36);
            this.btniTunerAbout.TabIndex = 4;
            this.btniTunerAbout.UseVisualStyleBackColor = true;
            this.btniTunerAbout.Click += new System.EventHandler(this.btniTunerHelp_Click);
            // 
            // btnViewManager
            // 
            this.btnViewManager.AutoSize = true;
            this.btnViewManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewManager.Depth = 0;
            this.btnViewManager.Enabled = false;
            this.btnViewManager.Icon = null;
            this.btnViewManager.Location = new System.Drawing.Point(134, 70);
            this.btnViewManager.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewManager.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnViewManager.Name = "btnViewManager";
            this.btnViewManager.Primary = false;
            this.btnViewManager.Size = new System.Drawing.Size(110, 36);
            this.btnViewManager.TabIndex = 5;
            this.btnViewManager.Text = "Manager Tools";
            this.btnViewManager.UseVisualStyleBackColor = true;
            this.btnViewManager.Click += new System.EventHandler(this.btnViewManager_Click);
            // 
            // iTunerDivider1
            // 
            this.iTunerDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iTunerDivider1.Depth = 0;
            this.iTunerDivider1.Location = new System.Drawing.Point(13, 112);
            this.iTunerDivider1.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerDivider1.Name = "iTunerDivider1";
            this.iTunerDivider1.Size = new System.Drawing.Size(399, 14);
            this.iTunerDivider1.TabIndex = 6;
            this.iTunerDivider1.Text = "iTunerDivider1";
            // 
            // btniTuner3RdParty
            // 
            this.btniTuner3RdParty.AutoSize = true;
            this.btniTuner3RdParty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btniTuner3RdParty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniTuner3RdParty.Depth = 0;
            this.btniTuner3RdParty.Icon = global::iTunerManagerApp.Properties.Resources.ThirdPartySoftware;
            this.btniTuner3RdParty.Location = new System.Drawing.Point(368, 70);
            this.btniTuner3RdParty.MouseState = iTunerSkin.MouseState.HOVER;
            this.btniTuner3RdParty.Name = "btniTuner3RdParty";
            this.btniTuner3RdParty.Primary = true;
            this.btniTuner3RdParty.Size = new System.Drawing.Size(44, 36);
            this.btniTuner3RdParty.TabIndex = 7;
            this.btniTuner3RdParty.UseVisualStyleBackColor = true;
            this.btniTuner3RdParty.Click += new System.EventHandler(this.btniTuner3RdParty_Click);
            // 
            // iTunerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 138);
            this.Controls.Add(this.btniTuner3RdParty);
            this.Controls.Add(this.iTunerDivider1);
            this.Controls.Add(this.btnViewManager);
            this.Controls.Add(this.btniTunerAbout);
            this.Controls.Add(this.btnOpenViewer);
            this.Controls.Add(this.btnEditDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TunerManager";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "iTuner Manager";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.RunChecks);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTunerFlatButton btnEditDatabase;
        private iTunerFlatButton btnOpenViewer;
        private iTunerRaisedButton btniTunerAbout;
        private iTunerFlatButton btnViewManager;
        private iTunerDivider iTunerDivider1;
        private iTunerRaisedButton btniTuner3RdParty;
    }
}

