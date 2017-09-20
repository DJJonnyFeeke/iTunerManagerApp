using System.ComponentModel;
using System.Windows.Forms;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    partial class TunerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerMain));
            this.mainContextMenu = new iTunerSkin.Controls.iTunerContextMenuStrip();
            this.iTunerToolStripMenuItemSelectAll = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem4 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem5 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem1 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem2 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem3 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem6 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem7 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.iTunerToolStripMenuItem8 = new iTunerSkin.Controls.iTunerToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoLabel = new iTunerSkin.Controls.iTunerLabel();
            this.spacer = new iTunerSkin.Controls.iTunerDivider();
            this.tabControl = new iTunerSkin.Controls.iTunerTabControl();
            this.Manage = new System.Windows.Forms.TabPage();
            this.tunerLoadingCircleA = new iTunerCustomControls.Controls.TunerLoadingCircle();
            this.tunerLoadingCircleB = new iTunerCustomControls.Controls.TunerLoadingCircle();
            this.tunerLoadingCircleD = new iTunerCustomControls.Controls.TunerLoadingCircle();
            this.tunerLoadingCircleC = new iTunerCustomControls.Controls.TunerLoadingCircle();
            this.iTunerDivider4 = new iTunerSkin.Controls.iTunerDivider();
            this.picCreateNewItem = new System.Windows.Forms.PictureBox();
            this.picFindMedia = new System.Windows.Forms.PictureBox();
            this.picDownloadManager = new System.Windows.Forms.PictureBox();
            this.picID3Tagger = new System.Windows.Forms.PictureBox();
            this.btnID3Tagger = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnDownloadManager = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnFindMedia = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnCreateNewItem = new iTunerSkin.Controls.iTunerRaisedButton();
            this.Settings = new System.Windows.Forms.TabPage();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.iTunes = new System.Windows.Forms.TabPage();
            this.Video = new System.Windows.Forms.TabPage();
            this.Gaming = new System.Windows.Forms.TabPage();
            this.Books = new System.Windows.Forms.TabPage();
            this.Documents = new System.Windows.Forms.TabPage();
            this.Images = new System.Windows.Forms.TabPage();
            this.tabSelect = new iTunerSkin.Controls.iTunerTabSelector();
            this.iTunerDivider1 = new iTunerSkin.Controls.iTunerDivider();
            this.iTunerDivider2 = new iTunerSkin.Controls.iTunerDivider();
            this.iTunerDivider3 = new iTunerSkin.Controls.iTunerDivider();
            this.mainContextMenu.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateNewItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFindMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownloadManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID3Tagger)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainContextMenu.Depth = 0;
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTunerToolStripMenuItemSelectAll,
            this.iTunerToolStripMenuItem1,
            this.iTunerToolStripMenuItem6});
            this.mainContextMenu.MouseState = iTunerSkin.MouseState.HOVER;
            this.mainContextMenu.Name = "iTunerContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(110, 94);
            // 
            // iTunerToolStripMenuItemSelectAll
            // 
            this.iTunerToolStripMenuItemSelectAll.AutoSize = false;
            this.iTunerToolStripMenuItemSelectAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTunerToolStripMenuItem4,
            this.iTunerToolStripMenuItem5});
            this.iTunerToolStripMenuItemSelectAll.Name = "iTunerToolStripMenuItemSelectAll";
            this.iTunerToolStripMenuItemSelectAll.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItemSelectAll.Text = "Select";
            // 
            // iTunerToolStripMenuItem4
            // 
            this.iTunerToolStripMenuItem4.AutoSize = false;
            this.iTunerToolStripMenuItem4.Name = "iTunerToolStripMenuItem4";
            this.iTunerToolStripMenuItem4.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem4.Text = "Single";
            // 
            // iTunerToolStripMenuItem5
            // 
            this.iTunerToolStripMenuItem5.AutoSize = false;
            this.iTunerToolStripMenuItem5.Name = "iTunerToolStripMenuItem5";
            this.iTunerToolStripMenuItem5.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem5.Text = "Multiple";
            // 
            // iTunerToolStripMenuItem1
            // 
            this.iTunerToolStripMenuItem1.AutoSize = false;
            this.iTunerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTunerToolStripMenuItem2,
            this.iTunerToolStripMenuItem3});
            this.iTunerToolStripMenuItem1.Name = "iTunerToolStripMenuItem1";
            this.iTunerToolStripMenuItem1.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem1.Text = "Search";
            // 
            // iTunerToolStripMenuItem2
            // 
            this.iTunerToolStripMenuItem2.AutoSize = false;
            this.iTunerToolStripMenuItem2.Name = "iTunerToolStripMenuItem2";
            this.iTunerToolStripMenuItem2.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem2.Text = "Online";
            // 
            // iTunerToolStripMenuItem3
            // 
            this.iTunerToolStripMenuItem3.AutoSize = false;
            this.iTunerToolStripMenuItem3.Name = "iTunerToolStripMenuItem3";
            this.iTunerToolStripMenuItem3.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem3.Text = "Offline";
            // 
            // iTunerToolStripMenuItem6
            // 
            this.iTunerToolStripMenuItem6.AutoSize = false;
            this.iTunerToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTunerToolStripMenuItem7,
            this.iTunerToolStripMenuItem8});
            this.iTunerToolStripMenuItem6.Name = "iTunerToolStripMenuItem6";
            this.iTunerToolStripMenuItem6.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem6.Text = "Clean";
            // 
            // iTunerToolStripMenuItem7
            // 
            this.iTunerToolStripMenuItem7.AutoSize = false;
            this.iTunerToolStripMenuItem7.Name = "iTunerToolStripMenuItem7";
            this.iTunerToolStripMenuItem7.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem7.Text = "Single";
            // 
            // iTunerToolStripMenuItem8
            // 
            this.iTunerToolStripMenuItem8.AutoSize = false;
            this.iTunerToolStripMenuItem8.Name = "iTunerToolStripMenuItem8";
            this.iTunerToolStripMenuItem8.Size = new System.Drawing.Size(120, 30);
            this.iTunerToolStripMenuItem8.Text = "Multiple";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.Controls.Add(this.infoLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.spacer, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tabSelect, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(918, 500);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 9F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoLabel.Location = new System.Drawing.Point(3, 459);
            this.infoLabel.MouseState = iTunerSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(712, 41);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "...";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // spacer
            // 
            this.spacer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel.SetColumnSpan(this.spacer, 2);
            this.spacer.Depth = 0;
            this.spacer.Location = new System.Drawing.Point(3, 438);
            this.spacer.MouseState = iTunerSkin.MouseState.HOVER;
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(912, 18);
            this.spacer.TabIndex = 1;
            this.spacer.Text = "spacer";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.Manage);
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Controls.Add(this.Statistics);
            this.tabControl.Controls.Add(this.iTunes);
            this.tabControl.Controls.Add(this.Video);
            this.tabControl.Controls.Add(this.Gaming);
            this.tabControl.Controls.Add(this.Books);
            this.tabControl.Controls.Add(this.Documents);
            this.tabControl.Controls.Add(this.Images);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(3, 53);
            this.tabControl.MouseState = iTunerSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(912, 379);
            this.tabControl.TabIndex = 2;
            // 
            // Manage
            // 
            this.Manage.BackColor = System.Drawing.Color.White;
            this.Manage.Controls.Add(this.tunerLoadingCircleA);
            this.Manage.Controls.Add(this.tunerLoadingCircleB);
            this.Manage.Controls.Add(this.tunerLoadingCircleD);
            this.Manage.Controls.Add(this.tunerLoadingCircleC);
            this.Manage.Controls.Add(this.iTunerDivider4);
            this.Manage.Controls.Add(this.picCreateNewItem);
            this.Manage.Controls.Add(this.picFindMedia);
            this.Manage.Controls.Add(this.picDownloadManager);
            this.Manage.Controls.Add(this.picID3Tagger);
            this.Manage.Controls.Add(this.btnID3Tagger);
            this.Manage.Controls.Add(this.btnDownloadManager);
            this.Manage.Controls.Add(this.btnFindMedia);
            this.Manage.Controls.Add(this.btnCreateNewItem);
            this.Manage.Location = new System.Drawing.Point(4, 22);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(904, 353);
            this.Manage.TabIndex = 8;
            this.Manage.Text = "Manage";
            // 
            // tunerLoadingCircleA
            // 
            this.tunerLoadingCircleA.Active = true;
            this.tunerLoadingCircleA.BackColor = System.Drawing.Color.Transparent;
            this.tunerLoadingCircleA.Color = System.Drawing.Color.Blue;
            this.tunerLoadingCircleA.InnerCircleRadius = 49;
            this.tunerLoadingCircleA.Location = new System.Drawing.Point(3, 34);
            this.tunerLoadingCircleA.Name = "tunerLoadingCircleA";
            this.tunerLoadingCircleA.NumberSpoke = 20;
            this.tunerLoadingCircleA.OuterCircleRadius = 50;
            this.tunerLoadingCircleA.RotationSpeed = 50;
            this.tunerLoadingCircleA.Size = new System.Drawing.Size(220, 220);
            this.tunerLoadingCircleA.SpokeThickness = 5;
            this.tunerLoadingCircleA.StylePreset = iTunerCustomControls.Controls.TunerLoadingCircle.StylePresets.MacOSX;
            this.tunerLoadingCircleA.TabIndex = 5;
            this.tunerLoadingCircleA.Text = "tunerLoadingCircle";
            // 
            // tunerLoadingCircleB
            // 
            this.tunerLoadingCircleB.Active = true;
            this.tunerLoadingCircleB.BackColor = System.Drawing.Color.Transparent;
            this.tunerLoadingCircleB.Color = System.Drawing.Color.Fuchsia;
            this.tunerLoadingCircleB.InnerCircleRadius = 49;
            this.tunerLoadingCircleB.Location = new System.Drawing.Point(229, 34);
            this.tunerLoadingCircleB.Name = "tunerLoadingCircleB";
            this.tunerLoadingCircleB.NumberSpoke = 20;
            this.tunerLoadingCircleB.OuterCircleRadius = 50;
            this.tunerLoadingCircleB.RotationSpeed = 50;
            this.tunerLoadingCircleB.Size = new System.Drawing.Size(220, 220);
            this.tunerLoadingCircleB.SpokeThickness = 5;
            this.tunerLoadingCircleB.StylePreset = iTunerCustomControls.Controls.TunerLoadingCircle.StylePresets.MacOSX;
            this.tunerLoadingCircleB.TabIndex = 5;
            this.tunerLoadingCircleB.Text = "tunerLoadingCircle";
            // 
            // tunerLoadingCircleD
            // 
            this.tunerLoadingCircleD.Active = true;
            this.tunerLoadingCircleD.BackColor = System.Drawing.Color.Transparent;
            this.tunerLoadingCircleD.Color = System.Drawing.Color.Aqua;
            this.tunerLoadingCircleD.InnerCircleRadius = 49;
            this.tunerLoadingCircleD.Location = new System.Drawing.Point(681, 34);
            this.tunerLoadingCircleD.Name = "tunerLoadingCircleD";
            this.tunerLoadingCircleD.NumberSpoke = 20;
            this.tunerLoadingCircleD.OuterCircleRadius = 50;
            this.tunerLoadingCircleD.RotationSpeed = 50;
            this.tunerLoadingCircleD.Size = new System.Drawing.Size(220, 220);
            this.tunerLoadingCircleD.SpokeThickness = 5;
            this.tunerLoadingCircleD.StylePreset = iTunerCustomControls.Controls.TunerLoadingCircle.StylePresets.MacOSX;
            this.tunerLoadingCircleD.TabIndex = 5;
            this.tunerLoadingCircleD.Text = "tunerLoadingCircle";
            // 
            // tunerLoadingCircleC
            // 
            this.tunerLoadingCircleC.Active = true;
            this.tunerLoadingCircleC.BackColor = System.Drawing.Color.Transparent;
            this.tunerLoadingCircleC.Color = System.Drawing.Color.Lime;
            this.tunerLoadingCircleC.InnerCircleRadius = 49;
            this.tunerLoadingCircleC.Location = new System.Drawing.Point(455, 34);
            this.tunerLoadingCircleC.Name = "tunerLoadingCircleC";
            this.tunerLoadingCircleC.NumberSpoke = 20;
            this.tunerLoadingCircleC.OuterCircleRadius = 50;
            this.tunerLoadingCircleC.RotationSpeed = 50;
            this.tunerLoadingCircleC.Size = new System.Drawing.Size(220, 220);
            this.tunerLoadingCircleC.SpokeThickness = 10;
            this.tunerLoadingCircleC.StylePreset = iTunerCustomControls.Controls.TunerLoadingCircle.StylePresets.MacOSX;
            this.tunerLoadingCircleC.TabIndex = 4;
            this.tunerLoadingCircleC.Text = "tunerLoadingCircle";
            // 
            // iTunerDivider4
            // 
            this.iTunerDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iTunerDivider4.Depth = 0;
            this.iTunerDivider4.Location = new System.Drawing.Point(6, 302);
            this.iTunerDivider4.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerDivider4.Name = "iTunerDivider4";
            this.iTunerDivider4.Size = new System.Drawing.Size(895, 23);
            this.iTunerDivider4.TabIndex = 8;
            this.iTunerDivider4.Text = "iTunerDivider4";
            // 
            // picCreateNewItem
            // 
            this.picCreateNewItem.Image = global::iTunerManagerApp.Properties.Resources.Notification_Center;
            this.picCreateNewItem.Location = new System.Drawing.Point(681, 34);
            this.picCreateNewItem.Name = "picCreateNewItem";
            this.picCreateNewItem.Size = new System.Drawing.Size(220, 220);
            this.picCreateNewItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCreateNewItem.TabIndex = 7;
            this.picCreateNewItem.TabStop = false;
            // 
            // picFindMedia
            // 
            this.picFindMedia.Image = global::iTunerManagerApp.Properties.Resources.Web;
            this.picFindMedia.Location = new System.Drawing.Point(455, 34);
            this.picFindMedia.Name = "picFindMedia";
            this.picFindMedia.Size = new System.Drawing.Size(220, 220);
            this.picFindMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFindMedia.TabIndex = 6;
            this.picFindMedia.TabStop = false;
            // 
            // picDownloadManager
            // 
            this.picDownloadManager.Image = global::iTunerManagerApp.Properties.Resources.Downloads;
            this.picDownloadManager.Location = new System.Drawing.Point(229, 34);
            this.picDownloadManager.Name = "picDownloadManager";
            this.picDownloadManager.Size = new System.Drawing.Size(220, 220);
            this.picDownloadManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDownloadManager.TabIndex = 5;
            this.picDownloadManager.TabStop = false;
            // 
            // picID3Tagger
            // 
            this.picID3Tagger.Image = global::iTunerManagerApp.Properties.Resources.Music_Alt;
            this.picID3Tagger.Location = new System.Drawing.Point(3, 34);
            this.picID3Tagger.Name = "picID3Tagger";
            this.picID3Tagger.Size = new System.Drawing.Size(220, 220);
            this.picID3Tagger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picID3Tagger.TabIndex = 4;
            this.picID3Tagger.TabStop = false;
            // 
            // btnID3Tagger
            // 
            this.btnID3Tagger.AutoSize = true;
            this.btnID3Tagger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnID3Tagger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnID3Tagger.Depth = 0;
            this.btnID3Tagger.Icon = null;
            this.btnID3Tagger.Location = new System.Drawing.Point(69, 260);
            this.btnID3Tagger.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnID3Tagger.Name = "btnID3Tagger";
            this.btnID3Tagger.Primary = true;
            this.btnID3Tagger.Size = new System.Drawing.Size(81, 36);
            this.btnID3Tagger.TabIndex = 3;
            this.btnID3Tagger.Text = "ID3 Tagger";
            this.btnID3Tagger.UseVisualStyleBackColor = true;
            this.btnID3Tagger.Click += new System.EventHandler(this.btnID3Tagger_Click);
            // 
            // btnDownloadManager
            // 
            this.btnDownloadManager.AutoSize = true;
            this.btnDownloadManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadManager.Depth = 0;
            this.btnDownloadManager.Icon = null;
            this.btnDownloadManager.Location = new System.Drawing.Point(272, 260);
            this.btnDownloadManager.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnDownloadManager.Name = "btnDownloadManager";
            this.btnDownloadManager.Primary = true;
            this.btnDownloadManager.Size = new System.Drawing.Size(136, 36);
            this.btnDownloadManager.TabIndex = 2;
            this.btnDownloadManager.Text = "Download Manager";
            this.btnDownloadManager.UseVisualStyleBackColor = true;
            this.btnDownloadManager.Click += new System.EventHandler(this.btnDownloadManager_Click);
            // 
            // btnFindMedia
            // 
            this.btnFindMedia.AutoSize = true;
            this.btnFindMedia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindMedia.Depth = 0;
            this.btnFindMedia.Icon = null;
            this.btnFindMedia.Location = new System.Drawing.Point(524, 260);
            this.btnFindMedia.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnFindMedia.Name = "btnFindMedia";
            this.btnFindMedia.Primary = true;
            this.btnFindMedia.Size = new System.Drawing.Size(80, 36);
            this.btnFindMedia.TabIndex = 1;
            this.btnFindMedia.Text = "Find Media";
            this.btnFindMedia.UseVisualStyleBackColor = true;
            this.btnFindMedia.Click += new System.EventHandler(this.btnFindMedia_Click);
            // 
            // btnCreateNewItem
            // 
            this.btnCreateNewItem.AutoSize = true;
            this.btnCreateNewItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateNewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewItem.Depth = 0;
            this.btnCreateNewItem.Icon = null;
            this.btnCreateNewItem.Location = new System.Drawing.Point(743, 260);
            this.btnCreateNewItem.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnCreateNewItem.Name = "btnCreateNewItem";
            this.btnCreateNewItem.Primary = true;
            this.btnCreateNewItem.Size = new System.Drawing.Size(115, 36);
            this.btnCreateNewItem.TabIndex = 0;
            this.btnCreateNewItem.Text = "Create New Item";
            this.btnCreateNewItem.UseVisualStyleBackColor = true;
            this.btnCreateNewItem.Click += new System.EventHandler(this.btnCreateNewItem_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(904, 353);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.White;
            this.Statistics.Location = new System.Drawing.Point(4, 22);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(3);
            this.Statistics.Size = new System.Drawing.Size(904, 353);
            this.Statistics.TabIndex = 1;
            this.Statistics.Text = "Statistics";
            // 
            // iTunes
            // 
            this.iTunes.BackColor = System.Drawing.Color.White;
            this.iTunes.Location = new System.Drawing.Point(4, 22);
            this.iTunes.Name = "iTunes";
            this.iTunes.Size = new System.Drawing.Size(904, 353);
            this.iTunes.TabIndex = 2;
            this.iTunes.Text = "itunes";
            // 
            // Video
            // 
            this.Video.BackColor = System.Drawing.Color.White;
            this.Video.Location = new System.Drawing.Point(4, 22);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(904, 353);
            this.Video.TabIndex = 3;
            this.Video.Text = "video";
            // 
            // Gaming
            // 
            this.Gaming.BackColor = System.Drawing.Color.White;
            this.Gaming.Location = new System.Drawing.Point(4, 22);
            this.Gaming.Name = "Gaming";
            this.Gaming.Size = new System.Drawing.Size(904, 353);
            this.Gaming.TabIndex = 4;
            this.Gaming.Text = "gaming";
            // 
            // Books
            // 
            this.Books.BackColor = System.Drawing.Color.White;
            this.Books.Location = new System.Drawing.Point(4, 22);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(904, 353);
            this.Books.TabIndex = 5;
            this.Books.Text = "books";
            // 
            // Documents
            // 
            this.Documents.BackColor = System.Drawing.Color.White;
            this.Documents.Location = new System.Drawing.Point(4, 22);
            this.Documents.Name = "Documents";
            this.Documents.Size = new System.Drawing.Size(904, 353);
            this.Documents.TabIndex = 6;
            this.Documents.Text = "documents";
            // 
            // Images
            // 
            this.Images.BackColor = System.Drawing.Color.White;
            this.Images.Location = new System.Drawing.Point(4, 22);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(904, 353);
            this.Images.TabIndex = 7;
            this.Images.Text = "images";
            // 
            // tabSelect
            // 
            this.tabSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelect.BaseTabControl = this.tabControl;
            this.tableLayoutPanel.SetColumnSpan(this.tabSelect, 2);
            this.tabSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSelect.Depth = 0;
            this.tabSelect.Location = new System.Drawing.Point(3, 3);
            this.tabSelect.MouseState = iTunerSkin.MouseState.HOVER;
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Size = new System.Drawing.Size(912, 44);
            this.tabSelect.TabIndex = 3;
            this.tabSelect.Text = "tabSelect";
            // 
            // iTunerDivider1
            // 
            this.iTunerDivider1.BackColor = System.Drawing.Color.White;
            this.iTunerDivider1.Depth = 0;
            this.iTunerDivider1.Location = new System.Drawing.Point(115, 77);
            this.iTunerDivider1.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerDivider1.Name = "iTunerDivider1";
            this.iTunerDivider1.Size = new System.Drawing.Size(11, 44);
            this.iTunerDivider1.TabIndex = 2;
            this.iTunerDivider1.Text = "iTunerDivider1";
            // 
            // iTunerDivider2
            // 
            this.iTunerDivider2.BackColor = System.Drawing.Color.White;
            this.iTunerDivider2.Depth = 0;
            this.iTunerDivider2.Location = new System.Drawing.Point(306, 77);
            this.iTunerDivider2.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerDivider2.Name = "iTunerDivider2";
            this.iTunerDivider2.Size = new System.Drawing.Size(10, 44);
            this.iTunerDivider2.TabIndex = 3;
            this.iTunerDivider2.Text = "iTunerDivider2";
            // 
            // iTunerDivider3
            // 
            this.iTunerDivider3.BackColor = System.Drawing.Color.White;
            this.iTunerDivider3.Depth = 0;
            this.iTunerDivider3.Location = new System.Drawing.Point(388, 77);
            this.iTunerDivider3.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerDivider3.Name = "iTunerDivider3";
            this.iTunerDivider3.Size = new System.Drawing.Size(10, 44);
            this.iTunerDivider3.TabIndex = 3;
            this.iTunerDivider3.Text = "iTunerDivider3";
            // 
            // TunerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 586);
            this.ContextMenuStrip = this.mainContextMenu;
            this.Controls.Add(this.iTunerDivider3);
            this.Controls.Add(this.iTunerDivider2);
            this.Controls.Add(this.iTunerDivider1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TunerMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTuner Manager";
            this.TopMost = true;
            this.mainContextMenu.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Manage.ResumeLayout(false);
            this.Manage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateNewItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFindMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownloadManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID3Tagger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTunerContextMenuStrip mainContextMenu;
        private iTunerToolStripMenuItem iTunerToolStripMenuItemSelectAll;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem1;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem4;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem5;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem2;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem3;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem6;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem7;
        private iTunerToolStripMenuItem iTunerToolStripMenuItem8;
        private TableLayoutPanel tableLayoutPanel;
        private iTunerLabel infoLabel;
        private iTunerDivider spacer;
        private iTunerTabControl tabControl;
        private TabPage Settings;
        private TabPage Statistics;
        private TabPage iTunes;
        private TabPage Video;
        private TabPage Gaming;
        private TabPage Books;
        private TabPage Documents;
        private TabPage Images;
        private iTunerTabSelector tabSelect;
        private TabPage Manage;
        private iTunerDivider iTunerDivider1;
        private iTunerDivider iTunerDivider2;
        private iTunerDivider iTunerDivider3;
        private iTunerRaisedButton btnCreateNewItem;
        private iTunerRaisedButton btnFindMedia;
        private iTunerRaisedButton btnDownloadManager;
        private iTunerRaisedButton btnID3Tagger;
        private PictureBox picID3Tagger;
        private PictureBox picCreateNewItem;
        private PictureBox picFindMedia;
        private PictureBox picDownloadManager;
        private iTunerDivider iTunerDivider4;
        public iTunerCustomControls.Controls.TunerLoadingCircle tunerLoadingCircleC;
        public iTunerCustomControls.Controls.TunerLoadingCircle tunerLoadingCircleA;
        public iTunerCustomControls.Controls.TunerLoadingCircle tunerLoadingCircleB;
        public iTunerCustomControls.Controls.TunerLoadingCircle tunerLoadingCircleD;


    }
}

