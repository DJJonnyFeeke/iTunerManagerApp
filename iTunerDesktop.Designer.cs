using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTunerCustomControls.Controls;

namespace iTunerManagerApp
{
    partial class TunerDesktop
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerDesktop));
            this.taskActive = new System.Windows.Forms.PictureBox();
            this.picLogoOverlay = new System.Windows.Forms.PictureBox();
            this.taskGuide = new System.Windows.Forms.PictureBox();
            this.taskEnabled = new System.Windows.Forms.PictureBox();
            this.action1 = new System.Windows.Forms.PictureBox();
            this.action11 = new System.Windows.Forms.PictureBox();
            this.action10 = new System.Windows.Forms.PictureBox();
            this.action9 = new System.Windows.Forms.PictureBox();
            this.action8 = new System.Windows.Forms.PictureBox();
            this.action7 = new System.Windows.Forms.PictureBox();
            this.action6 = new System.Windows.Forms.PictureBox();
            this.action5 = new System.Windows.Forms.PictureBox();
            this.action4 = new System.Windows.Forms.PictureBox();
            this.action3 = new System.Windows.Forms.PictureBox();
            this.action2 = new System.Windows.Forms.PictureBox();
            this.dockbarPanel = new System.Windows.Forms.Panel();
            this.dockBarBottom = new System.Windows.Forms.Panel();
            this.lblDockBar = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.taskEnabledLabel = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.dockBarBack = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.picInternet = new System.Windows.Forms.PictureBox();
            this.timerInternet = new System.Windows.Forms.Timer(this.components);
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picSpeechStatus = new System.Windows.Forms.PictureBox();
            this.picDock = new System.Windows.Forms.PictureBox();
            this.chtSpeechAudioSpectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbAudioDeviceList = new System.Windows.Forms.ComboBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRam = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.lblMenu = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.lblRamInfo = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.lblTime = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.lblDock = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.lblSpeechStatus = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.lblInternet = new iTunerCustomControls.Controls.TunerLabelWithBorder();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.mainMenu = new iTunerSkin.Controls.iTunerContextMenuStrip();
            this.windowsExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunerPanel1 = new iTunerCustomControls.Controls.TunerPanel();
            ((System.ComponentModel.ISupportInitialize)(this.taskActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.action2)).BeginInit();
            this.dockbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeechStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtSpeechAudioSpectrum)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskActive
            // 
            this.taskActive.BackColor = System.Drawing.Color.Transparent;
            this.taskActive.Image = global::iTunerManagerApp.Properties.DockBar.dock_white_glow;
            this.taskActive.Location = new System.Drawing.Point(6, 167);
            this.taskActive.Name = "taskActive";
            this.taskActive.Size = new System.Drawing.Size(100, 100);
            this.taskActive.TabIndex = 6;
            this.taskActive.TabStop = false;
            this.taskActive.Visible = false;
            // 
            // picLogoOverlay
            // 
            this.picLogoOverlay.BackColor = System.Drawing.Color.Transparent;
            this.picLogoOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoOverlay.Image = global::iTunerManagerApp.Properties.Resources.Wind0ws;
            this.picLogoOverlay.Location = new System.Drawing.Point(164, 39);
            this.picLogoOverlay.Name = "picLogoOverlay";
            this.picLogoOverlay.Size = new System.Drawing.Size(192, 192);
            this.picLogoOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogoOverlay.TabIndex = 2;
            this.picLogoOverlay.TabStop = false;
            this.picLogoOverlay.Visible = false;
            // 
            // taskGuide
            // 
            this.taskGuide.BackColor = System.Drawing.Color.Transparent;
            this.taskGuide.Image = global::iTunerManagerApp.Properties.DockBar.dock_base;
            this.taskGuide.Location = new System.Drawing.Point(6, 180);
            this.taskGuide.Name = "taskGuide";
            this.taskGuide.Size = new System.Drawing.Size(1160, 10);
            this.taskGuide.TabIndex = 3;
            this.taskGuide.TabStop = false;
            // 
            // taskEnabled
            // 
            this.taskEnabled.BackColor = System.Drawing.Color.Transparent;
            this.taskEnabled.Image = global::iTunerManagerApp.Properties.DockBar.dock_blue_glow;
            this.taskEnabled.Location = new System.Drawing.Point(6, 40);
            this.taskEnabled.Name = "taskEnabled";
            this.taskEnabled.Size = new System.Drawing.Size(100, 37);
            this.taskEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.taskEnabled.TabIndex = 5;
            this.taskEnabled.TabStop = false;
            this.taskEnabled.Visible = false;
            // 
            // action1
            // 
            this.action1.BackColor = System.Drawing.Color.Transparent;
            this.action1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action1.Image = global::iTunerManagerApp.Properties.DockBar.Folder___downloads;
            this.action1.Location = new System.Drawing.Point(6, 74);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(100, 100);
            this.action1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action1.TabIndex = 7;
            this.action1.TabStop = false;
            this.action1.Tag = "Downloads";
            this.action1.Click += new System.EventHandler(this.ActionClick);
            this.action1.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action1.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action11
            // 
            this.action11.BackColor = System.Drawing.Color.Transparent;
            this.action11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action11.Image = global::iTunerManagerApp.Properties.DockBar.Bin___empty;
            this.action11.Location = new System.Drawing.Point(1066, 74);
            this.action11.Name = "action11";
            this.action11.Size = new System.Drawing.Size(100, 100);
            this.action11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action11.TabIndex = 8;
            this.action11.TabStop = false;
            this.action11.Tag = "Recycle";
            this.action11.Click += new System.EventHandler(this.ActionClick);
            this.action11.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action11.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action10
            // 
            this.action10.BackColor = System.Drawing.Color.Transparent;
            this.action10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action10.Image = global::iTunerManagerApp.Properties.DockBar.Folder___Temporary_Files;
            this.action10.Location = new System.Drawing.Point(960, 74);
            this.action10.Name = "action10";
            this.action10.Size = new System.Drawing.Size(100, 100);
            this.action10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action10.TabIndex = 9;
            this.action10.TabStop = false;
            this.action10.Tag = "Temp";
            this.action10.Click += new System.EventHandler(this.ActionClick);
            this.action10.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action10.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action9
            // 
            this.action9.BackColor = System.Drawing.Color.Transparent;
            this.action9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action9.Image = global::iTunerManagerApp.Properties.DockBar.Folder___scheduled_tasks;
            this.action9.Location = new System.Drawing.Point(854, 74);
            this.action9.Name = "action9";
            this.action9.Size = new System.Drawing.Size(100, 100);
            this.action9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action9.TabIndex = 10;
            this.action9.TabStop = false;
            this.action9.Tag = "Schedules";
            this.action9.Click += new System.EventHandler(this.ActionClick);
            this.action9.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action9.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action8
            // 
            this.action8.BackColor = System.Drawing.Color.Transparent;
            this.action8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action8.Image = global::iTunerManagerApp.Properties.DockBar.Folder___private;
            this.action8.Location = new System.Drawing.Point(748, 74);
            this.action8.Name = "action8";
            this.action8.Size = new System.Drawing.Size(100, 100);
            this.action8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action8.TabIndex = 11;
            this.action8.TabStop = false;
            this.action8.Tag = "Private";
            this.action8.Click += new System.EventHandler(this.ActionClick);
            this.action8.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action8.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action7
            // 
            this.action7.BackColor = System.Drawing.Color.Transparent;
            this.action7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action7.Image = global::iTunerManagerApp.Properties.DockBar.Folder___my_work;
            this.action7.Location = new System.Drawing.Point(642, 74);
            this.action7.Name = "action7";
            this.action7.Size = new System.Drawing.Size(100, 100);
            this.action7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action7.TabIndex = 12;
            this.action7.TabStop = false;
            this.action7.Tag = "Documents";
            this.action7.Click += new System.EventHandler(this.ActionClick);
            this.action7.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action7.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action6
            // 
            this.action6.BackColor = System.Drawing.Color.Transparent;
            this.action6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action6.Image = global::iTunerManagerApp.Properties.DockBar.Folder___my_pictures;
            this.action6.Location = new System.Drawing.Point(536, 74);
            this.action6.Name = "action6";
            this.action6.Size = new System.Drawing.Size(100, 100);
            this.action6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action6.TabIndex = 13;
            this.action6.TabStop = false;
            this.action6.Tag = "Images";
            this.action6.Click += new System.EventHandler(this.ActionClick);
            this.action6.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action6.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action5
            // 
            this.action5.BackColor = System.Drawing.Color.Transparent;
            this.action5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action5.Image = global::iTunerManagerApp.Properties.DockBar.Folder___my_music_3;
            this.action5.Location = new System.Drawing.Point(430, 74);
            this.action5.Name = "action5";
            this.action5.Size = new System.Drawing.Size(100, 100);
            this.action5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action5.TabIndex = 14;
            this.action5.TabStop = false;
            this.action5.Tag = "Audio";
            this.action5.Click += new System.EventHandler(this.ActionClick);
            this.action5.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action5.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action4
            // 
            this.action4.BackColor = System.Drawing.Color.Transparent;
            this.action4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action4.Image = global::iTunerManagerApp.Properties.DockBar.Folder___my_movies;
            this.action4.Location = new System.Drawing.Point(324, 74);
            this.action4.Name = "action4";
            this.action4.Size = new System.Drawing.Size(100, 100);
            this.action4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action4.TabIndex = 15;
            this.action4.TabStop = false;
            this.action4.Tag = "Videos";
            this.action4.Click += new System.EventHandler(this.ActionClick);
            this.action4.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action4.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action3
            // 
            this.action3.BackColor = System.Drawing.Color.Transparent;
            this.action3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action3.Image = global::iTunerManagerApp.Properties.DockBar.Folder___games;
            this.action3.Location = new System.Drawing.Point(218, 74);
            this.action3.Name = "action3";
            this.action3.Size = new System.Drawing.Size(100, 100);
            this.action3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action3.TabIndex = 16;
            this.action3.TabStop = false;
            this.action3.Tag = "Games";
            this.action3.Click += new System.EventHandler(this.ActionClick);
            this.action3.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action3.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // action2
            // 
            this.action2.BackColor = System.Drawing.Color.Transparent;
            this.action2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action2.Image = global::iTunerManagerApp.Properties.DockBar.Folder___favorites;
            this.action2.Location = new System.Drawing.Point(112, 74);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(100, 100);
            this.action2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.action2.TabIndex = 17;
            this.action2.TabStop = false;
            this.action2.Tag = "Favourites";
            this.action2.Click += new System.EventHandler(this.ActionClick);
            this.action2.MouseEnter += new System.EventHandler(this.scalableImage_MouseEnter);
            this.action2.MouseLeave += new System.EventHandler(this.scalableImage_MouseLeave);
            // 
            // dockbarPanel
            // 
            this.dockbarPanel.BackColor = System.Drawing.Color.Transparent;
            this.dockbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockbarPanel.Controls.Add(this.dockBarBottom);
            this.dockbarPanel.Controls.Add(this.taskGuide);
            this.dockbarPanel.Controls.Add(this.lblDockBar);
            this.dockbarPanel.Controls.Add(this.taskEnabledLabel);
            this.dockbarPanel.Controls.Add(this.dockBarBack);
            this.dockbarPanel.Controls.Add(this.action2);
            this.dockbarPanel.Controls.Add(this.taskActive);
            this.dockbarPanel.Controls.Add(this.taskEnabled);
            this.dockbarPanel.Controls.Add(this.action11);
            this.dockbarPanel.Controls.Add(this.action10);
            this.dockbarPanel.Controls.Add(this.action9);
            this.dockbarPanel.Controls.Add(this.action1);
            this.dockbarPanel.Controls.Add(this.action8);
            this.dockbarPanel.Controls.Add(this.action7);
            this.dockbarPanel.Controls.Add(this.action3);
            this.dockbarPanel.Controls.Add(this.action6);
            this.dockbarPanel.Controls.Add(this.action4);
            this.dockbarPanel.Controls.Add(this.action5);
            this.dockbarPanel.Location = new System.Drawing.Point(148, 485);
            this.dockbarPanel.Name = "dockbarPanel";
            this.dockbarPanel.Size = new System.Drawing.Size(1174, 287);
            this.dockbarPanel.TabIndex = 18;
            this.dockbarPanel.Visible = false;
            // 
            // dockBarBottom
            // 
            this.dockBarBottom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockBarBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockBarBottom.Location = new System.Drawing.Point(6, 272);
            this.dockBarBottom.Name = "dockBarBottom";
            this.dockBarBottom.Size = new System.Drawing.Size(1160, 10);
            this.dockBarBottom.TabIndex = 39;
            // 
            // lblDockBar
            // 
            this.lblDockBar.BackColor = System.Drawing.Color.Transparent;
            this.lblDockBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDockBar.Location = new System.Drawing.Point(6, 229);
            this.lblDockBar.Name = "lblDockBar";
            this.lblDockBar.Size = new System.Drawing.Size(1160, 47);
            this.lblDockBar.TabIndex = 39;
            this.lblDockBar.Text = "DOCK BAR";
            this.lblDockBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskEnabledLabel
            // 
            this.taskEnabledLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskEnabledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskEnabledLabel.Location = new System.Drawing.Point(6, 18);
            this.taskEnabledLabel.Name = "taskEnabledLabel";
            this.taskEnabledLabel.Size = new System.Drawing.Size(100, 19);
            this.taskEnabledLabel.TabIndex = 37;
            this.taskEnabledLabel.Text = "RAM";
            this.taskEnabledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taskEnabledLabel.Visible = false;
            // 
            // dockBarBack
            // 
            this.dockBarBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockBarBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockBarBack.Location = new System.Drawing.Point(6, 3);
            this.dockBarBack.Name = "dockBarBack";
            this.dockBarBack.Size = new System.Drawing.Size(1160, 10);
            this.dockBarBack.TabIndex = 38;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1;
            this.timerTime.Tick += new System.EventHandler(this.TimerTimerTick);
            // 
            // picInternet
            // 
            this.picInternet.BackColor = System.Drawing.Color.Transparent;
            this.picInternet.Cursor = System.Windows.Forms.Cursors.No;
            this.picInternet.Image = global::iTunerManagerApp.Properties.Resources.Offline;
            this.picInternet.Location = new System.Drawing.Point(3, 341);
            this.picInternet.Name = "picInternet";
            this.picInternet.Size = new System.Drawing.Size(116, 116);
            this.picInternet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternet.TabIndex = 20;
            this.picInternet.TabStop = false;
            this.picInternet.Visible = false;
            // 
            // timerInternet
            // 
            this.timerInternet.Enabled = true;
            this.timerInternet.Interval = 1000;
            this.timerInternet.Tick += new System.EventHandler(this.TimerInternetTick);
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = global::iTunerManagerApp.Properties.Resources.AppLogoSmall;
            this.picMenu.Location = new System.Drawing.Point(3, 3);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(116, 116);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 26;
            this.picMenu.TabStop = false;
            this.picMenu.Visible = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // picSpeechStatus
            // 
            this.picSpeechStatus.BackColor = System.Drawing.Color.Transparent;
            this.picSpeechStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSpeechStatus.Image = global::iTunerManagerApp.Properties.Resources.Pause;
            this.picSpeechStatus.Location = new System.Drawing.Point(3, 510);
            this.picSpeechStatus.Name = "picSpeechStatus";
            this.picSpeechStatus.Size = new System.Drawing.Size(116, 116);
            this.picSpeechStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpeechStatus.TabIndex = 24;
            this.picSpeechStatus.TabStop = false;
            this.picSpeechStatus.Tag = "Pause";
            this.picSpeechStatus.Visible = false;
            this.picSpeechStatus.Click += new System.EventHandler(this.picSpeechStatus_Click);
            this.picSpeechStatus.MouseEnter += new System.EventHandler(this.picSpeechStatus_MouseEnter);
            this.picSpeechStatus.MouseLeave += new System.EventHandler(this.picSpeechStatus_MouseLeave);
            // 
            // picDock
            // 
            this.picDock.BackColor = System.Drawing.Color.Transparent;
            this.picDock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDock.Image = global::iTunerManagerApp.Properties.Resources.Dock;
            this.picDock.Location = new System.Drawing.Point(3, 172);
            this.picDock.Name = "picDock";
            this.picDock.Size = new System.Drawing.Size(116, 116);
            this.picDock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDock.TabIndex = 28;
            this.picDock.TabStop = false;
            this.picDock.Visible = false;
            this.picDock.Click += new System.EventHandler(this.picDock_Click);
            // 
            // chtSpeechAudioSpectrum
            // 
            this.chtSpeechAudioSpectrum.BackColor = System.Drawing.Color.Transparent;
            this.chtSpeechAudioSpectrum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chtSpeechAudioSpectrum.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chtSpeechAudioSpectrum.BackSecondaryColor = System.Drawing.Color.Silver;
            this.chtSpeechAudioSpectrum.BorderlineColor = System.Drawing.Color.Transparent;
            this.chtSpeechAudioSpectrum.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.chtSpeechAudioSpectrum.ChartAreas.Add(chartArea1);
            this.chtSpeechAudioSpectrum.Cursor = System.Windows.Forms.Cursors.No;
            this.chtSpeechAudioSpectrum.Location = new System.Drawing.Point(3, 679);
            this.chtSpeechAudioSpectrum.Name = "chtSpeechAudioSpectrum";
            this.chtSpeechAudioSpectrum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chtSpeechAudioSpectrum.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow};
            this.chtSpeechAudioSpectrum.Size = new System.Drawing.Size(116, 40);
            this.chtSpeechAudioSpectrum.TabIndex = 24;
            this.chtSpeechAudioSpectrum.Text = "chart1";
            this.chtSpeechAudioSpectrum.Visible = false;
            // 
            // cmbAudioDeviceList
            // 
            this.cmbAudioDeviceList.FormattingEnabled = true;
            this.cmbAudioDeviceList.Location = new System.Drawing.Point(164, 12);
            this.cmbAudioDeviceList.Name = "cmbAudioDeviceList";
            this.cmbAudioDeviceList.Size = new System.Drawing.Size(98, 21);
            this.cmbAudioDeviceList.TabIndex = 23;
            this.cmbAudioDeviceList.Visible = false;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.panel6);
            this.infoPanel.Controls.Add(this.panel5);
            this.infoPanel.Controls.Add(this.panel4);
            this.infoPanel.Controls.Add(this.panel3);
            this.infoPanel.Controls.Add(this.panel2);
            this.infoPanel.Controls.Add(this.panel1);
            this.infoPanel.Controls.Add(this.picMenu);
            this.infoPanel.Controls.Add(this.lblRam);
            this.infoPanel.Controls.Add(this.lblMenu);
            this.infoPanel.Controls.Add(this.lblRamInfo);
            this.infoPanel.Controls.Add(this.picDock);
            this.infoPanel.Controls.Add(this.lblTime);
            this.infoPanel.Controls.Add(this.lblDock);
            this.infoPanel.Controls.Add(this.lblSpeechStatus);
            this.infoPanel.Controls.Add(this.chtSpeechAudioSpectrum);
            this.infoPanel.Controls.Add(this.picInternet);
            this.infoPanel.Controls.Add(this.lblInternet);
            this.infoPanel.Controls.Add(this.picSpeechStatus);
            this.infoPanel.Location = new System.Drawing.Point(12, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(124, 914);
            this.infoPanel.TabIndex = 30;
            this.infoPanel.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(3, 877);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(115, 10);
            this.panel6.TabIndex = 41;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(3, 788);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 10);
            this.panel5.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, 725);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 10);
            this.panel4.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 10);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 10);
            this.panel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 10);
            this.panel1.TabIndex = 40;
            // 
            // lblRam
            // 
            this.lblRam.BackColor = System.Drawing.Color.Transparent;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.Location = new System.Drawing.Point(3, 799);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(116, 43);
            this.lblRam.TabIndex = 37;
            this.lblRam.Text = "RAM";
            this.lblRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(3, 122);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(116, 47);
            this.lblMenu.TabIndex = 29;
            this.lblMenu.Text = "MENU";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRamInfo
            // 
            this.lblRamInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblRamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamInfo.Location = new System.Drawing.Point(3, 831);
            this.lblRamInfo.Name = "lblRamInfo";
            this.lblRamInfo.Size = new System.Drawing.Size(116, 43);
            this.lblRamInfo.TabIndex = 36;
            this.lblRamInfo.Text = "RAM";
            this.lblRamInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(3, 742);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(116, 43);
            this.lblTime.TabIndex = 35;
            this.lblTime.Text = "HH:MM:SS TT";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDock
            // 
            this.lblDock.BackColor = System.Drawing.Color.Transparent;
            this.lblDock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDock.Location = new System.Drawing.Point(3, 291);
            this.lblDock.Name = "lblDock";
            this.lblDock.Size = new System.Drawing.Size(116, 47);
            this.lblDock.TabIndex = 32;
            this.lblDock.Text = "DOCK";
            this.lblDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeechStatus
            // 
            this.lblSpeechStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeechStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeechStatus.Location = new System.Drawing.Point(3, 629);
            this.lblSpeechStatus.Name = "lblSpeechStatus";
            this.lblSpeechStatus.Size = new System.Drawing.Size(116, 47);
            this.lblSpeechStatus.TabIndex = 34;
            this.lblSpeechStatus.Text = "BOT";
            this.lblSpeechStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInternet
            // 
            this.lblInternet.BackColor = System.Drawing.Color.Transparent;
            this.lblInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternet.Location = new System.Drawing.Point(3, 460);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(116, 47);
            this.lblInternet.TabIndex = 33;
            this.lblInternet.Text = "OFFLINE";
            this.lblInternet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Location = new System.Drawing.Point(148, 12);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(10, 467);
            this.pnlSideBar.TabIndex = 31;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainMenu.Depth = 0;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsExplorerToolStripMenuItem,
            this.audioPlayerToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenu.MouseState = iTunerSkin.MouseState.HOVER;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(169, 92);
            // 
            // windowsExplorerToolStripMenuItem
            // 
            this.windowsExplorerToolStripMenuItem.Image = global::iTunerManagerApp.Properties.Resources.NewFolder;
            this.windowsExplorerToolStripMenuItem.Name = "windowsExplorerToolStripMenuItem";
            this.windowsExplorerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.windowsExplorerToolStripMenuItem.Text = "Windows Explorer";
            this.windowsExplorerToolStripMenuItem.Click += new System.EventHandler(this.windowsExplorerToolStripMenuItem_Click);
            // 
            // audioPlayerToolStripMenuItem
            // 
            this.audioPlayerToolStripMenuItem.Image = global::iTunerManagerApp.Properties.Resources.AudioPlayer;
            this.audioPlayerToolStripMenuItem.Name = "audioPlayerToolStripMenuItem";
            this.audioPlayerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.audioPlayerToolStripMenuItem.Text = "Audio Player";
            this.audioPlayerToolStripMenuItem.Click += new System.EventHandler(this.audioPlayerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::iTunerManagerApp.Properties.Resources.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::iTunerManagerApp.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tunerPanel1
            // 
            this.tunerPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tunerPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tunerPanel1.BorderColor = System.Drawing.Color.Black;
            this.tunerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tunerPanel1.BorderWidth = 5;
            this.tunerPanel1.Curvature = 20;
            this.tunerPanel1.GradientMode = iTunerCustomControls.Helpers.iTunerPanel.LinearGradientMode.Vertical;
            this.tunerPanel1.Location = new System.Drawing.Point(433, 135);
            this.tunerPanel1.Name = "tunerPanel1";
            this.tunerPanel1.Size = new System.Drawing.Size(436, 315);
            this.tunerPanel1.TabIndex = 32;
            // 
            // TunerDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::iTunerManagerApp.Properties.Resources.ImagePattern;
            this.ClientSize = new System.Drawing.Size(1779, 1053);
            this.Controls.Add(this.tunerPanel1);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.cmbAudioDeviceList);
            this.Controls.Add(this.dockbarPanel);
            this.Controls.Add(this.picLogoOverlay);
            this.Controls.Add(this.infoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TunerDesktop";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTunerDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.iTunerDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.action2)).EndInit();
            this.dockbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeechStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtSpeechAudioSpectrum)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picLogoOverlay;
        private PictureBox taskGuide;
        private PictureBox taskEnabled;
        private PictureBox action1;
        private PictureBox action11;
        private PictureBox action10;
        private PictureBox action9;
        private PictureBox action8;
        private PictureBox action7;
        private PictureBox action6;
        private PictureBox action5;
        private PictureBox action4;
        private PictureBox action3;
        private PictureBox action2;
        private Panel dockbarPanel;
        private PictureBox taskActive;
        private Timer timerTime;
        private PictureBox picInternet;
        private Timer timerInternet;
        private ComboBox cmbAudioDeviceList;
        private Chart chtSpeechAudioSpectrum;
        private PictureBox picMenu;
        private PictureBox picDock;
        private PictureBox picSpeechStatus;
        private TunerLabelWithBorder lblMenu;
        private Panel infoPanel;
        private Panel pnlSideBar;
        private TunerLabelWithBorder lblDock;
        private TunerLabelWithBorder taskEnabledLabel;
        private TunerLabelWithBorder lblInternet;
        private TunerLabelWithBorder lblSpeechStatus;
        private TunerLabelWithBorder lblTime;
        private TunerLabelWithBorder lblRamInfo;
        private TunerLabelWithBorder lblRam;
        private TunerLabelWithBorder lblDockBar;
        private Panel dockBarBack;
        private Panel dockBarBottom;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private iTunerSkin.Controls.iTunerContextMenuStrip mainMenu;
        private ToolStripMenuItem windowsExplorerToolStripMenuItem;
        private ToolStripMenuItem audioPlayerToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TunerPanel tunerPanel1;
    }
}