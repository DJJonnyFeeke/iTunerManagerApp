using System.ComponentModel;
using System.Windows.Forms;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    partial class TunerFindMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerFindMedia));
            this.btnFetchSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.iTunerTabSelectorFindMedia = new iTunerSkin.Controls.iTunerTabSelector();
            this.iTunerTabControlFindMedia = new iTunerSkin.Controls.iTunerTabControl();
            this.DownloadManager = new System.Windows.Forms.TabPage();
            this.Shazam = new System.Windows.Forms.TabPage();
            this.groupBoxShazamListView = new System.Windows.Forms.GroupBox();
            this.lstHtmlListShazam = new iTunerSkin.Controls.iTunerListView();
            this.ShazamItemNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShazamArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShazamTrackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShazamImagePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShazamDownloadUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxFetchShazam = new System.Windows.Forms.GroupBox();
            this.btnDownloadShazam = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnGetHTMLListShazam = new iTunerSkin.Controls.iTunerRaisedButton();
            this.groupBoxGetShazam = new System.Windows.Forms.GroupBox();
            this.iTunerLabel1 = new iTunerSkin.Controls.iTunerLabel();
            this.rtbHtmlTextShazam = new System.Windows.Forms.RichTextBox();
            this.lblNumShazams = new iTunerSkin.Controls.iTunerLabel();
            this.txtNumShazams = new System.Windows.Forms.TextBox();
            this.groupBoxOpenShazam = new System.Windows.Forms.GroupBox();
            this.btnGetShazamWeb = new iTunerSkin.Controls.iTunerRaisedButton();
            this.SoundCloud = new System.Windows.Forms.TabPage();
            this.groupBoxDefaultDownloaderTrackList = new System.Windows.Forms.GroupBox();
            this.lstDefaultDownloaderTrackListSoundCloud = new iTunerSkin.Controls.iTunerListView();
            this.SoundCloudNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoundcloudArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoundCloudTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoundCloudDownloaded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMultipleTrackDownloader = new System.Windows.Forms.GroupBox();
            this.btnShowMultipleTracksSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.lblMultipleTracks = new System.Windows.Forms.Label();
            this.rtbMultipleTracksSoundCloud = new System.Windows.Forms.RichTextBox();
            this.btnMultipleTracksDownloadSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.groupBoxPlaylistDownloader = new System.Windows.Forms.GroupBox();
            this.btnPlaylistDownloadSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnShowPlaylistTracksSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.txtPlaylistNameSoundCloud = new System.Windows.Forms.TextBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnChangeDownloadDirectorySoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.groupBoxSelectiveTrackDownloader = new System.Windows.Forms.GroupBox();
            this.btnDownloadAllArtistTracksSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.btnDownloadSingleTrackSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.groupBoxDefaultDownloader = new System.Windows.Forms.GroupBox();
            this.picSoundCloudUser = new System.Windows.Forms.PictureBox();
            this.lblSoundCloudUserName = new System.Windows.Forms.Label();
            this.btnDownloadAllSoundCloud = new iTunerSkin.Controls.iTunerRaisedButton();
            this.txtSoundCloudUserName = new System.Windows.Forms.TextBox();
            this.YouTube = new System.Windows.Forms.TabPage();
            this.groupBoxYouTubeDownloadList = new System.Windows.Forms.GroupBox();
            this.lstYouTubeDownloadList = new iTunerSkin.Controls.iTunerListView();
            this.YouTubeNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YouTubeLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxYouTubeDownload = new System.Windows.Forms.GroupBox();
            this.chkVideos = new iTunerSkin.Controls.iTunerCheckBox();
            this.btnDownloadAllYouTube = new iTunerSkin.Controls.iTunerRaisedButton();
            this.groupBoxYouTubeDetails = new System.Windows.Forms.GroupBox();
            this.btnGetYouTubeLinks = new iTunerSkin.Controls.iTunerRaisedButton();
            this.lblSearchDepth = new iTunerSkin.Controls.iTunerLabel();
            this.txtSearchDepth = new System.Windows.Forms.TextBox();
            this.lblYouTubeInitialDownloadLink = new System.Windows.Forms.Label();
            this.txtYouTubeInitialDownloadLink = new System.Windows.Forms.TextBox();
            this.iTunerTabControlFindMedia.SuspendLayout();
            this.Shazam.SuspendLayout();
            this.groupBoxShazamListView.SuspendLayout();
            this.groupBoxFetchShazam.SuspendLayout();
            this.groupBoxGetShazam.SuspendLayout();
            this.groupBoxOpenShazam.SuspendLayout();
            this.SoundCloud.SuspendLayout();
            this.groupBoxDefaultDownloaderTrackList.SuspendLayout();
            this.groupBoxMultipleTrackDownloader.SuspendLayout();
            this.groupBoxPlaylistDownloader.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxSelectiveTrackDownloader.SuspendLayout();
            this.groupBoxDefaultDownloader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoundCloudUser)).BeginInit();
            this.YouTube.SuspendLayout();
            this.groupBoxYouTubeDownloadList.SuspendLayout();
            this.groupBoxYouTubeDownload.SuspendLayout();
            this.groupBoxYouTubeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetchSoundCloud
            // 
            this.btnFetchSoundCloud.AutoSize = true;
            this.btnFetchSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFetchSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetchSoundCloud.Depth = 0;
            this.btnFetchSoundCloud.Enabled = false;
            this.btnFetchSoundCloud.Icon = null;
            this.btnFetchSoundCloud.Location = new System.Drawing.Point(233, 19);
            this.btnFetchSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnFetchSoundCloud.Name = "btnFetchSoundCloud";
            this.btnFetchSoundCloud.Primary = true;
            this.btnFetchSoundCloud.Size = new System.Drawing.Size(76, 36);
            this.btnFetchSoundCloud.TabIndex = 15;
            this.btnFetchSoundCloud.Text = "Fetch All";
            this.btnFetchSoundCloud.UseVisualStyleBackColor = true;
            this.btnFetchSoundCloud.Click += new System.EventHandler(this.btnFetchSoundCloud_Click);
            // 
            // iTunerTabSelectorFindMedia
            // 
            this.iTunerTabSelectorFindMedia.BaseTabControl = this.iTunerTabControlFindMedia;
            this.iTunerTabSelectorFindMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerTabSelectorFindMedia.Depth = 0;
            this.iTunerTabSelectorFindMedia.Location = new System.Drawing.Point(0, 63);
            this.iTunerTabSelectorFindMedia.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerTabSelectorFindMedia.Name = "iTunerTabSelectorFindMedia";
            this.iTunerTabSelectorFindMedia.Size = new System.Drawing.Size(1019, 31);
            this.iTunerTabSelectorFindMedia.TabIndex = 17;
            this.iTunerTabSelectorFindMedia.Text = "iTunerTabSelector1";
            // 
            // iTunerTabControlFindMedia
            // 
            this.iTunerTabControlFindMedia.Controls.Add(this.DownloadManager);
            this.iTunerTabControlFindMedia.Controls.Add(this.Shazam);
            this.iTunerTabControlFindMedia.Controls.Add(this.SoundCloud);
            this.iTunerTabControlFindMedia.Controls.Add(this.YouTube);
            this.iTunerTabControlFindMedia.Depth = 0;
            this.iTunerTabControlFindMedia.Location = new System.Drawing.Point(0, 100);
            this.iTunerTabControlFindMedia.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerTabControlFindMedia.Name = "iTunerTabControlFindMedia";
            this.iTunerTabControlFindMedia.SelectedIndex = 0;
            this.iTunerTabControlFindMedia.Size = new System.Drawing.Size(1019, 681);
            this.iTunerTabControlFindMedia.TabIndex = 18;
            // 
            // DownloadManager
            // 
            this.DownloadManager.Location = new System.Drawing.Point(4, 22);
            this.DownloadManager.Name = "DownloadManager";
            this.DownloadManager.Size = new System.Drawing.Size(1011, 655);
            this.DownloadManager.TabIndex = 3;
            this.DownloadManager.Text = "Download Manager";
            this.DownloadManager.UseVisualStyleBackColor = true;
            // 
            // Shazam
            // 
            this.Shazam.Controls.Add(this.groupBoxShazamListView);
            this.Shazam.Controls.Add(this.groupBoxFetchShazam);
            this.Shazam.Controls.Add(this.groupBoxGetShazam);
            this.Shazam.Controls.Add(this.groupBoxOpenShazam);
            this.Shazam.Location = new System.Drawing.Point(4, 22);
            this.Shazam.Name = "Shazam";
            this.Shazam.Padding = new System.Windows.Forms.Padding(3);
            this.Shazam.Size = new System.Drawing.Size(1011, 655);
            this.Shazam.TabIndex = 0;
            this.Shazam.Text = "Shazam";
            this.Shazam.UseVisualStyleBackColor = true;
            // 
            // groupBoxShazamListView
            // 
            this.groupBoxShazamListView.Controls.Add(this.lstHtmlListShazam);
            this.groupBoxShazamListView.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxShazamListView.Location = new System.Drawing.Point(8, 77);
            this.groupBoxShazamListView.Name = "groupBoxShazamListView";
            this.groupBoxShazamListView.Size = new System.Drawing.Size(997, 570);
            this.groupBoxShazamListView.TabIndex = 19;
            this.groupBoxShazamListView.TabStop = false;
            this.groupBoxShazamListView.Text = "Shazam List View:";
            // 
            // lstHtmlListShazam
            // 
            this.lstHtmlListShazam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHtmlListShazam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShazamItemNo,
            this.ShazamArtist,
            this.ShazamTrackName,
            this.ShazamImagePath,
            this.ShazamDownloadUrl});
            this.lstHtmlListShazam.Depth = 0;
            this.lstHtmlListShazam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstHtmlListShazam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstHtmlListShazam.FullRowSelect = true;
            this.lstHtmlListShazam.GridLines = true;
            this.lstHtmlListShazam.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstHtmlListShazam.Location = new System.Drawing.Point(6, 19);
            this.lstHtmlListShazam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstHtmlListShazam.MouseState = iTunerSkin.MouseState.OUT;
            this.lstHtmlListShazam.Name = "lstHtmlListShazam";
            this.lstHtmlListShazam.OwnerDraw = true;
            this.lstHtmlListShazam.Size = new System.Drawing.Size(984, 545);
            this.lstHtmlListShazam.TabIndex = 10;
            this.lstHtmlListShazam.UseCompatibleStateImageBehavior = false;
            this.lstHtmlListShazam.View = System.Windows.Forms.View.Details;
            // 
            // ShazamItemNo
            // 
            this.ShazamItemNo.Text = "No";
            this.ShazamItemNo.Width = 61;
            // 
            // ShazamArtist
            // 
            this.ShazamArtist.Text = "Artist";
            this.ShazamArtist.Width = 150;
            // 
            // ShazamTrackName
            // 
            this.ShazamTrackName.Text = "Track Name";
            this.ShazamTrackName.Width = 200;
            // 
            // ShazamImagePath
            // 
            this.ShazamImagePath.Text = "Image URL";
            this.ShazamImagePath.Width = 190;
            // 
            // ShazamDownloadUrl
            // 
            this.ShazamDownloadUrl.Text = "Download URL";
            this.ShazamDownloadUrl.Width = 614;
            // 
            // groupBoxFetchShazam
            // 
            this.groupBoxFetchShazam.Controls.Add(this.btnDownloadShazam);
            this.groupBoxFetchShazam.Controls.Add(this.btnGetHTMLListShazam);
            this.groupBoxFetchShazam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxFetchShazam.Location = new System.Drawing.Point(789, 0);
            this.groupBoxFetchShazam.Name = "groupBoxFetchShazam";
            this.groupBoxFetchShazam.Size = new System.Drawing.Size(216, 71);
            this.groupBoxFetchShazam.TabIndex = 18;
            this.groupBoxFetchShazam.TabStop = false;
            this.groupBoxFetchShazam.Text = "Fetch Shazam:";
            // 
            // btnDownloadShazam
            // 
            this.btnDownloadShazam.AutoSize = true;
            this.btnDownloadShazam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadShazam.Depth = 0;
            this.btnDownloadShazam.Icon = null;
            this.btnDownloadShazam.Location = new System.Drawing.Point(129, 18);
            this.btnDownloadShazam.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnDownloadShazam.Name = "btnDownloadShazam";
            this.btnDownloadShazam.Primary = true;
            this.btnDownloadShazam.Size = new System.Drawing.Size(80, 36);
            this.btnDownloadShazam.TabIndex = 20;
            this.btnDownloadShazam.Text = "Download";
            this.btnDownloadShazam.UseVisualStyleBackColor = true;
            this.btnDownloadShazam.Click += new System.EventHandler(this.btnDownloadShazam_Click);
            // 
            // btnGetHTMLListShazam
            // 
            this.btnGetHTMLListShazam.AutoSize = true;
            this.btnGetHTMLListShazam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetHTMLListShazam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetHTMLListShazam.Depth = 0;
            this.btnGetHTMLListShazam.Enabled = false;
            this.btnGetHTMLListShazam.Icon = null;
            this.btnGetHTMLListShazam.Location = new System.Drawing.Point(6, 18);
            this.btnGetHTMLListShazam.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnGetHTMLListShazam.Name = "btnGetHTMLListShazam";
            this.btnGetHTMLListShazam.Primary = true;
            this.btnGetHTMLListShazam.Size = new System.Drawing.Size(117, 36);
            this.btnGetHTMLListShazam.TabIndex = 11;
            this.btnGetHTMLListShazam.Text = "Fetch Track List";
            this.btnGetHTMLListShazam.UseVisualStyleBackColor = true;
            this.btnGetHTMLListShazam.Click += new System.EventHandler(this.btnGetHTMLList_Click);
            // 
            // groupBoxGetShazam
            // 
            this.groupBoxGetShazam.Controls.Add(this.iTunerLabel1);
            this.groupBoxGetShazam.Controls.Add(this.rtbHtmlTextShazam);
            this.groupBoxGetShazam.Controls.Add(this.lblNumShazams);
            this.groupBoxGetShazam.Controls.Add(this.txtNumShazams);
            this.groupBoxGetShazam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxGetShazam.Location = new System.Drawing.Point(140, 0);
            this.groupBoxGetShazam.Name = "groupBoxGetShazam";
            this.groupBoxGetShazam.Size = new System.Drawing.Size(643, 71);
            this.groupBoxGetShazam.TabIndex = 17;
            this.groupBoxGetShazam.TabStop = false;
            this.groupBoxGetShazam.Text = "Get Shazam:";
            // 
            // iTunerLabel1
            // 
            this.iTunerLabel1.AutoSize = true;
            this.iTunerLabel1.Depth = 0;
            this.iTunerLabel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.iTunerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iTunerLabel1.Location = new System.Drawing.Point(6, 16);
            this.iTunerLabel1.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerLabel1.Name = "iTunerLabel1";
            this.iTunerLabel1.Size = new System.Drawing.Size(119, 15);
            this.iTunerLabel1.TabIndex = 14;
            this.iTunerLabel1.Text = "Shazam Code HERE:";
            // 
            // rtbHtmlTextShazam
            // 
            this.rtbHtmlTextShazam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbHtmlTextShazam.Location = new System.Drawing.Point(131, 15);
            this.rtbHtmlTextShazam.Name = "rtbHtmlTextShazam";
            this.rtbHtmlTextShazam.Size = new System.Drawing.Size(402, 50);
            this.rtbHtmlTextShazam.TabIndex = 9;
            this.rtbHtmlTextShazam.Text = "";
            this.rtbHtmlTextShazam.TextChanged += new System.EventHandler(this.CheckShazam);
            // 
            // lblNumShazams
            // 
            this.lblNumShazams.AutoSize = true;
            this.lblNumShazams.Depth = 0;
            this.lblNumShazams.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblNumShazams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNumShazams.Location = new System.Drawing.Point(539, 19);
            this.lblNumShazams.MouseState = iTunerSkin.MouseState.HOVER;
            this.lblNumShazams.Name = "lblNumShazams";
            this.lblNumShazams.Size = new System.Drawing.Size(98, 15);
            this.lblNumShazams.TabIndex = 13;
            this.lblNumShazams.Text = "Total Shazams?:";
            // 
            // txtNumShazams
            // 
            this.txtNumShazams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumShazams.Location = new System.Drawing.Point(542, 39);
            this.txtNumShazams.Name = "txtNumShazams";
            this.txtNumShazams.Size = new System.Drawing.Size(95, 20);
            this.txtNumShazams.TabIndex = 15;
            this.txtNumShazams.Text = "0";
            this.txtNumShazams.TextChanged += new System.EventHandler(this.CheckShazam);
            // 
            // groupBoxOpenShazam
            // 
            this.groupBoxOpenShazam.Controls.Add(this.btnGetShazamWeb);
            this.groupBoxOpenShazam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxOpenShazam.Location = new System.Drawing.Point(8, 0);
            this.groupBoxOpenShazam.Name = "groupBoxOpenShazam";
            this.groupBoxOpenShazam.Size = new System.Drawing.Size(126, 71);
            this.groupBoxOpenShazam.TabIndex = 16;
            this.groupBoxOpenShazam.TabStop = false;
            this.groupBoxOpenShazam.Text = "Open Shazam:";
            // 
            // btnGetShazamWeb
            // 
            this.btnGetShazamWeb.AutoSize = true;
            this.btnGetShazamWeb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetShazamWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetShazamWeb.Depth = 0;
            this.btnGetShazamWeb.Icon = null;
            this.btnGetShazamWeb.Location = new System.Drawing.Point(6, 19);
            this.btnGetShazamWeb.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnGetShazamWeb.Name = "btnGetShazamWeb";
            this.btnGetShazamWeb.Primary = true;
            this.btnGetShazamWeb.Size = new System.Drawing.Size(113, 36);
            this.btnGetShazamWeb.TabIndex = 8;
            this.btnGetShazamWeb.Text = "Open MyShazam";
            this.btnGetShazamWeb.UseVisualStyleBackColor = true;
            this.btnGetShazamWeb.Click += new System.EventHandler(this.btnGetShazam_Click);
            // 
            // SoundCloud
            // 
            this.SoundCloud.Controls.Add(this.groupBoxDefaultDownloaderTrackList);
            this.SoundCloud.Controls.Add(this.groupBoxMultipleTrackDownloader);
            this.SoundCloud.Controls.Add(this.groupBoxPlaylistDownloader);
            this.SoundCloud.Controls.Add(this.groupBoxSettings);
            this.SoundCloud.Controls.Add(this.groupBoxSelectiveTrackDownloader);
            this.SoundCloud.Controls.Add(this.groupBoxDefaultDownloader);
            this.SoundCloud.Location = new System.Drawing.Point(4, 22);
            this.SoundCloud.Name = "SoundCloud";
            this.SoundCloud.Padding = new System.Windows.Forms.Padding(3);
            this.SoundCloud.Size = new System.Drawing.Size(1011, 655);
            this.SoundCloud.TabIndex = 1;
            this.SoundCloud.Text = "SoundCloud";
            this.SoundCloud.UseVisualStyleBackColor = true;
            // 
            // groupBoxDefaultDownloaderTrackList
            // 
            this.groupBoxDefaultDownloaderTrackList.Controls.Add(this.lstDefaultDownloaderTrackListSoundCloud);
            this.groupBoxDefaultDownloaderTrackList.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxDefaultDownloaderTrackList.Location = new System.Drawing.Point(8, 76);
            this.groupBoxDefaultDownloaderTrackList.Name = "groupBoxDefaultDownloaderTrackList";
            this.groupBoxDefaultDownloaderTrackList.Size = new System.Drawing.Size(707, 576);
            this.groupBoxDefaultDownloaderTrackList.TabIndex = 34;
            this.groupBoxDefaultDownloaderTrackList.TabStop = false;
            this.groupBoxDefaultDownloaderTrackList.Text = "Default Downloader || Track List:";
            // 
            // lstDefaultDownloaderTrackListSoundCloud
            // 
            this.lstDefaultDownloaderTrackListSoundCloud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDefaultDownloaderTrackListSoundCloud.CheckBoxes = true;
            this.lstDefaultDownloaderTrackListSoundCloud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoundCloudNo,
            this.SoundcloudArtist,
            this.SoundCloudTitle,
            this.SoundCloudDownloaded});
            this.lstDefaultDownloaderTrackListSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstDefaultDownloaderTrackListSoundCloud.Depth = 0;
            this.lstDefaultDownloaderTrackListSoundCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstDefaultDownloaderTrackListSoundCloud.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstDefaultDownloaderTrackListSoundCloud.FullRowSelect = true;
            this.lstDefaultDownloaderTrackListSoundCloud.GridLines = true;
            this.lstDefaultDownloaderTrackListSoundCloud.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDefaultDownloaderTrackListSoundCloud.Location = new System.Drawing.Point(9, 20);
            this.lstDefaultDownloaderTrackListSoundCloud.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstDefaultDownloaderTrackListSoundCloud.MouseState = iTunerSkin.MouseState.OUT;
            this.lstDefaultDownloaderTrackListSoundCloud.Name = "lstDefaultDownloaderTrackListSoundCloud";
            this.lstDefaultDownloaderTrackListSoundCloud.OwnerDraw = true;
            this.lstDefaultDownloaderTrackListSoundCloud.Size = new System.Drawing.Size(692, 550);
            this.lstDefaultDownloaderTrackListSoundCloud.TabIndex = 0;
            this.lstDefaultDownloaderTrackListSoundCloud.UseCompatibleStateImageBehavior = false;
            this.lstDefaultDownloaderTrackListSoundCloud.View = System.Windows.Forms.View.Details;
            // 
            // SoundCloudNo
            // 
            this.SoundCloudNo.Text = "No";
            // 
            // SoundcloudArtist
            // 
            this.SoundcloudArtist.Text = "Artist";
            this.SoundcloudArtist.Width = 100;
            // 
            // SoundCloudTitle
            // 
            this.SoundCloudTitle.Text = "Title";
            this.SoundCloudTitle.Width = 150;
            // 
            // SoundCloudDownloaded
            // 
            this.SoundCloudDownloaded.Text = "Downloaded";
            this.SoundCloudDownloaded.Width = 407;
            // 
            // groupBoxMultipleTrackDownloader
            // 
            this.groupBoxMultipleTrackDownloader.Controls.Add(this.btnShowMultipleTracksSoundCloud);
            this.groupBoxMultipleTrackDownloader.Controls.Add(this.lblMultipleTracks);
            this.groupBoxMultipleTrackDownloader.Controls.Add(this.rtbMultipleTracksSoundCloud);
            this.groupBoxMultipleTrackDownloader.Controls.Add(this.btnMultipleTracksDownloadSoundCloud);
            this.groupBoxMultipleTrackDownloader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxMultipleTrackDownloader.Location = new System.Drawing.Point(721, 76);
            this.groupBoxMultipleTrackDownloader.Name = "groupBoxMultipleTrackDownloader";
            this.groupBoxMultipleTrackDownloader.Size = new System.Drawing.Size(286, 425);
            this.groupBoxMultipleTrackDownloader.TabIndex = 33;
            this.groupBoxMultipleTrackDownloader.TabStop = false;
            this.groupBoxMultipleTrackDownloader.Text = "Multiple Track Downloader:";
            // 
            // btnShowMultipleTracksSoundCloud
            // 
            this.btnShowMultipleTracksSoundCloud.AutoSize = true;
            this.btnShowMultipleTracksSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMultipleTracksSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMultipleTracksSoundCloud.Depth = 0;
            this.btnShowMultipleTracksSoundCloud.Icon = null;
            this.btnShowMultipleTracksSoundCloud.Location = new System.Drawing.Point(6, 19);
            this.btnShowMultipleTracksSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnShowMultipleTracksSoundCloud.Name = "btnShowMultipleTracksSoundCloud";
            this.btnShowMultipleTracksSoundCloud.Primary = true;
            this.btnShowMultipleTracksSoundCloud.Size = new System.Drawing.Size(150, 36);
            this.btnShowMultipleTracksSoundCloud.TabIndex = 21;
            this.btnShowMultipleTracksSoundCloud.Text = "Show Multiple Tracks";
            this.btnShowMultipleTracksSoundCloud.UseVisualStyleBackColor = true;
            this.btnShowMultipleTracksSoundCloud.Click += new System.EventHandler(this.btnShowMultipleTracksSoundCloud_Click);
            // 
            // lblMultipleTracks
            // 
            this.lblMultipleTracks.AutoSize = true;
            this.lblMultipleTracks.Location = new System.Drawing.Point(6, 58);
            this.lblMultipleTracks.Name = "lblMultipleTracks";
            this.lblMultipleTracks.Size = new System.Drawing.Size(82, 13);
            this.lblMultipleTracks.TabIndex = 28;
            this.lblMultipleTracks.Text = "Multiple Tracks:";
            // 
            // rtbMultipleTracksSoundCloud
            // 
            this.rtbMultipleTracksSoundCloud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMultipleTracksSoundCloud.Enabled = false;
            this.rtbMultipleTracksSoundCloud.Location = new System.Drawing.Point(6, 74);
            this.rtbMultipleTracksSoundCloud.Name = "rtbMultipleTracksSoundCloud";
            this.rtbMultipleTracksSoundCloud.Size = new System.Drawing.Size(274, 303);
            this.rtbMultipleTracksSoundCloud.TabIndex = 25;
            this.rtbMultipleTracksSoundCloud.Text = "";
            // 
            // btnMultipleTracksDownloadSoundCloud
            // 
            this.btnMultipleTracksDownloadSoundCloud.AutoSize = true;
            this.btnMultipleTracksDownloadSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMultipleTracksDownloadSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultipleTracksDownloadSoundCloud.Depth = 0;
            this.btnMultipleTracksDownloadSoundCloud.Enabled = false;
            this.btnMultipleTracksDownloadSoundCloud.Icon = null;
            this.btnMultipleTracksDownloadSoundCloud.Location = new System.Drawing.Point(200, 383);
            this.btnMultipleTracksDownloadSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnMultipleTracksDownloadSoundCloud.Name = "btnMultipleTracksDownloadSoundCloud";
            this.btnMultipleTracksDownloadSoundCloud.Primary = true;
            this.btnMultipleTracksDownloadSoundCloud.Size = new System.Drawing.Size(80, 36);
            this.btnMultipleTracksDownloadSoundCloud.TabIndex = 24;
            this.btnMultipleTracksDownloadSoundCloud.Text = "Download";
            this.btnMultipleTracksDownloadSoundCloud.UseVisualStyleBackColor = true;
            this.btnMultipleTracksDownloadSoundCloud.Click += new System.EventHandler(this.btnDownloadMultipleTracks_Click);
            // 
            // groupBoxPlaylistDownloader
            // 
            this.groupBoxPlaylistDownloader.Controls.Add(this.btnPlaylistDownloadSoundCloud);
            this.groupBoxPlaylistDownloader.Controls.Add(this.btnShowPlaylistTracksSoundCloud);
            this.groupBoxPlaylistDownloader.Controls.Add(this.lblPlaylistName);
            this.groupBoxPlaylistDownloader.Controls.Add(this.txtPlaylistNameSoundCloud);
            this.groupBoxPlaylistDownloader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxPlaylistDownloader.Location = new System.Drawing.Point(722, 507);
            this.groupBoxPlaylistDownloader.Name = "groupBoxPlaylistDownloader";
            this.groupBoxPlaylistDownloader.Size = new System.Drawing.Size(286, 145);
            this.groupBoxPlaylistDownloader.TabIndex = 32;
            this.groupBoxPlaylistDownloader.TabStop = false;
            this.groupBoxPlaylistDownloader.Text = "Playlist Downloader:";
            // 
            // btnPlaylistDownloadSoundCloud
            // 
            this.btnPlaylistDownloadSoundCloud.AutoSize = true;
            this.btnPlaylistDownloadSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaylistDownloadSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylistDownloadSoundCloud.Depth = 0;
            this.btnPlaylistDownloadSoundCloud.Enabled = false;
            this.btnPlaylistDownloadSoundCloud.Icon = null;
            this.btnPlaylistDownloadSoundCloud.Location = new System.Drawing.Point(200, 100);
            this.btnPlaylistDownloadSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnPlaylistDownloadSoundCloud.Name = "btnPlaylistDownloadSoundCloud";
            this.btnPlaylistDownloadSoundCloud.Primary = true;
            this.btnPlaylistDownloadSoundCloud.Size = new System.Drawing.Size(80, 36);
            this.btnPlaylistDownloadSoundCloud.TabIndex = 35;
            this.btnPlaylistDownloadSoundCloud.Text = "Download";
            this.btnPlaylistDownloadSoundCloud.UseVisualStyleBackColor = true;
            this.btnPlaylistDownloadSoundCloud.Click += new System.EventHandler(this.btnDownloadPlaylistTracksSoundCloud_Click);
            // 
            // btnShowPlaylistTracksSoundCloud
            // 
            this.btnShowPlaylistTracksSoundCloud.AutoSize = true;
            this.btnShowPlaylistTracksSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowPlaylistTracksSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPlaylistTracksSoundCloud.Depth = 0;
            this.btnShowPlaylistTracksSoundCloud.Icon = null;
            this.btnShowPlaylistTracksSoundCloud.Location = new System.Drawing.Point(6, 19);
            this.btnShowPlaylistTracksSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnShowPlaylistTracksSoundCloud.Name = "btnShowPlaylistTracksSoundCloud";
            this.btnShowPlaylistTracksSoundCloud.Primary = true;
            this.btnShowPlaylistTracksSoundCloud.Size = new System.Drawing.Size(177, 36);
            this.btnShowPlaylistTracksSoundCloud.TabIndex = 22;
            this.btnShowPlaylistTracksSoundCloud.Text = "Download Playlist Tracks";
            this.btnShowPlaylistTracksSoundCloud.UseVisualStyleBackColor = true;
            this.btnShowPlaylistTracksSoundCloud.Click += new System.EventHandler(this.btnShowPlaylistTracksSoundCloud_Click);
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Location = new System.Drawing.Point(6, 58);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(73, 13);
            this.lblPlaylistName.TabIndex = 27;
            this.lblPlaylistName.Text = "Playlist Name:";
            // 
            // txtPlaylistNameSoundCloud
            // 
            this.txtPlaylistNameSoundCloud.Enabled = false;
            this.txtPlaylistNameSoundCloud.Location = new System.Drawing.Point(6, 74);
            this.txtPlaylistNameSoundCloud.Name = "txtPlaylistNameSoundCloud";
            this.txtPlaylistNameSoundCloud.Size = new System.Drawing.Size(274, 20);
            this.txtPlaylistNameSoundCloud.TabIndex = 26;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.btnChangeDownloadDirectorySoundCloud);
            this.groupBoxSettings.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxSettings.Location = new System.Drawing.Point(807, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(200, 67);
            this.groupBoxSettings.TabIndex = 31;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings:";
            // 
            // btnChangeDownloadDirectorySoundCloud
            // 
            this.btnChangeDownloadDirectorySoundCloud.AutoSize = true;
            this.btnChangeDownloadDirectorySoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeDownloadDirectorySoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeDownloadDirectorySoundCloud.Depth = 0;
            this.btnChangeDownloadDirectorySoundCloud.Icon = null;
            this.btnChangeDownloadDirectorySoundCloud.Location = new System.Drawing.Point(6, 19);
            this.btnChangeDownloadDirectorySoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnChangeDownloadDirectorySoundCloud.Name = "btnChangeDownloadDirectorySoundCloud";
            this.btnChangeDownloadDirectorySoundCloud.Primary = true;
            this.btnChangeDownloadDirectorySoundCloud.Size = new System.Drawing.Size(188, 36);
            this.btnChangeDownloadDirectorySoundCloud.TabIndex = 19;
            this.btnChangeDownloadDirectorySoundCloud.Text = "Change Download Directory";
            this.btnChangeDownloadDirectorySoundCloud.UseVisualStyleBackColor = true;
            this.btnChangeDownloadDirectorySoundCloud.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // groupBoxSelectiveTrackDownloader
            // 
            this.groupBoxSelectiveTrackDownloader.Controls.Add(this.btnDownloadAllArtistTracksSoundCloud);
            this.groupBoxSelectiveTrackDownloader.Controls.Add(this.btnDownloadSingleTrackSoundCloud);
            this.groupBoxSelectiveTrackDownloader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxSelectiveTrackDownloader.Location = new System.Drawing.Point(437, 3);
            this.groupBoxSelectiveTrackDownloader.Name = "groupBoxSelectiveTrackDownloader";
            this.groupBoxSelectiveTrackDownloader.Size = new System.Drawing.Size(364, 67);
            this.groupBoxSelectiveTrackDownloader.TabIndex = 30;
            this.groupBoxSelectiveTrackDownloader.TabStop = false;
            this.groupBoxSelectiveTrackDownloader.Text = "Selective Track Downloader:";
            // 
            // btnDownloadAllArtistTracksSoundCloud
            // 
            this.btnDownloadAllArtistTracksSoundCloud.AutoSize = true;
            this.btnDownloadAllArtistTracksSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadAllArtistTracksSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadAllArtistTracksSoundCloud.Depth = 0;
            this.btnDownloadAllArtistTracksSoundCloud.Icon = null;
            this.btnDownloadAllArtistTracksSoundCloud.Location = new System.Drawing.Point(170, 19);
            this.btnDownloadAllArtistTracksSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnDownloadAllArtistTracksSoundCloud.Name = "btnDownloadAllArtistTracksSoundCloud";
            this.btnDownloadAllArtistTracksSoundCloud.Primary = true;
            this.btnDownloadAllArtistTracksSoundCloud.Size = new System.Drawing.Size(186, 36);
            this.btnDownloadAllArtistTracksSoundCloud.TabIndex = 23;
            this.btnDownloadAllArtistTracksSoundCloud.Text = "Download All Artist Tracks";
            this.btnDownloadAllArtistTracksSoundCloud.UseVisualStyleBackColor = true;
            this.btnDownloadAllArtistTracksSoundCloud.Click += new System.EventHandler(this.btnDownloadArtistTracksSoundCloud_Click);
            // 
            // btnDownloadSingleTrackSoundCloud
            // 
            this.btnDownloadSingleTrackSoundCloud.AutoSize = true;
            this.btnDownloadSingleTrackSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadSingleTrackSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadSingleTrackSoundCloud.Depth = 0;
            this.btnDownloadSingleTrackSoundCloud.Icon = null;
            this.btnDownloadSingleTrackSoundCloud.Location = new System.Drawing.Point(6, 19);
            this.btnDownloadSingleTrackSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnDownloadSingleTrackSoundCloud.Name = "btnDownloadSingleTrackSoundCloud";
            this.btnDownloadSingleTrackSoundCloud.Primary = true;
            this.btnDownloadSingleTrackSoundCloud.Size = new System.Drawing.Size(158, 36);
            this.btnDownloadSingleTrackSoundCloud.TabIndex = 20;
            this.btnDownloadSingleTrackSoundCloud.Text = "Download Single Track";
            this.btnDownloadSingleTrackSoundCloud.UseVisualStyleBackColor = true;
            this.btnDownloadSingleTrackSoundCloud.Click += new System.EventHandler(this.btnDownloadSingleTrackSoundCloud_Click);
            // 
            // groupBoxDefaultDownloader
            // 
            this.groupBoxDefaultDownloader.Controls.Add(this.picSoundCloudUser);
            this.groupBoxDefaultDownloader.Controls.Add(this.lblSoundCloudUserName);
            this.groupBoxDefaultDownloader.Controls.Add(this.btnDownloadAllSoundCloud);
            this.groupBoxDefaultDownloader.Controls.Add(this.txtSoundCloudUserName);
            this.groupBoxDefaultDownloader.Controls.Add(this.btnFetchSoundCloud);
            this.groupBoxDefaultDownloader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxDefaultDownloader.Location = new System.Drawing.Point(8, 3);
            this.groupBoxDefaultDownloader.Name = "groupBoxDefaultDownloader";
            this.groupBoxDefaultDownloader.Size = new System.Drawing.Size(423, 67);
            this.groupBoxDefaultDownloader.TabIndex = 29;
            this.groupBoxDefaultDownloader.TabStop = false;
            this.groupBoxDefaultDownloader.Text = "Default Downloader:";
            // 
            // picSoundCloudUser
            // 
            this.picSoundCloudUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSoundCloudUser.Image = global::iTunerManagerApp.Properties.Resources.ImagePattern;
            this.picSoundCloudUser.InitialImage = global::iTunerManagerApp.Properties.Resources.ImagePattern;
            this.picSoundCloudUser.Location = new System.Drawing.Point(191, 19);
            this.picSoundCloudUser.Name = "picSoundCloudUser";
            this.picSoundCloudUser.Size = new System.Drawing.Size(36, 36);
            this.picSoundCloudUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoundCloudUser.TabIndex = 19;
            this.picSoundCloudUser.TabStop = false;
            // 
            // lblSoundCloudUserName
            // 
            this.lblSoundCloudUserName.AutoSize = true;
            this.lblSoundCloudUserName.Location = new System.Drawing.Point(6, 16);
            this.lblSoundCloudUserName.Name = "lblSoundCloudUserName";
            this.lblSoundCloudUserName.Size = new System.Drawing.Size(121, 13);
            this.lblSoundCloudUserName.TabIndex = 17;
            this.lblSoundCloudUserName.Text = "SoundCloud UserName:";
            // 
            // btnDownloadAllSoundCloud
            // 
            this.btnDownloadAllSoundCloud.AutoSize = true;
            this.btnDownloadAllSoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadAllSoundCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadAllSoundCloud.Depth = 0;
            this.btnDownloadAllSoundCloud.Enabled = false;
            this.btnDownloadAllSoundCloud.Icon = null;
            this.btnDownloadAllSoundCloud.Location = new System.Drawing.Point(315, 19);
            this.btnDownloadAllSoundCloud.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnDownloadAllSoundCloud.Name = "btnDownloadAllSoundCloud";
            this.btnDownloadAllSoundCloud.Primary = true;
            this.btnDownloadAllSoundCloud.Size = new System.Drawing.Size(102, 36);
            this.btnDownloadAllSoundCloud.TabIndex = 18;
            this.btnDownloadAllSoundCloud.Text = "Download All";
            this.btnDownloadAllSoundCloud.UseVisualStyleBackColor = true;
            this.btnDownloadAllSoundCloud.Click += new System.EventHandler(this.btnDownloadAllSoundCloud_Click);
            // 
            // txtSoundCloudUserName
            // 
            this.txtSoundCloudUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoundCloudUserName.Location = new System.Drawing.Point(9, 32);
            this.txtSoundCloudUserName.Name = "txtSoundCloudUserName";
            this.txtSoundCloudUserName.Size = new System.Drawing.Size(176, 20);
            this.txtSoundCloudUserName.TabIndex = 16;
            this.txtSoundCloudUserName.TextChanged += new System.EventHandler(this.CheckSoundCloud);
            // 
            // YouTube
            // 
            this.YouTube.Controls.Add(this.groupBoxYouTubeDownloadList);
            this.YouTube.Controls.Add(this.groupBoxYouTubeDownload);
            this.YouTube.Controls.Add(this.groupBoxYouTubeDetails);
            this.YouTube.Location = new System.Drawing.Point(4, 22);
            this.YouTube.Name = "YouTube";
            this.YouTube.Size = new System.Drawing.Size(1011, 655);
            this.YouTube.TabIndex = 2;
            this.YouTube.Text = "YouTube";
            this.YouTube.UseVisualStyleBackColor = true;
            // 
            // groupBoxYouTubeDownloadList
            // 
            this.groupBoxYouTubeDownloadList.Controls.Add(this.lstYouTubeDownloadList);
            this.groupBoxYouTubeDownloadList.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxYouTubeDownloadList.Location = new System.Drawing.Point(8, 69);
            this.groupBoxYouTubeDownloadList.Name = "groupBoxYouTubeDownloadList";
            this.groupBoxYouTubeDownloadList.Size = new System.Drawing.Size(993, 578);
            this.groupBoxYouTubeDownloadList.TabIndex = 22;
            this.groupBoxYouTubeDownloadList.TabStop = false;
            this.groupBoxYouTubeDownloadList.Text = "Download Lists:";
            // 
            // lstYouTubeDownloadList
            // 
            this.lstYouTubeDownloadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstYouTubeDownloadList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.YouTubeNo,
            this.YouTubeLink});
            this.lstYouTubeDownloadList.Depth = 0;
            this.lstYouTubeDownloadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstYouTubeDownloadList.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstYouTubeDownloadList.FullRowSelect = true;
            this.lstYouTubeDownloadList.GridLines = true;
            this.lstYouTubeDownloadList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstYouTubeDownloadList.Location = new System.Drawing.Point(6, 19);
            this.lstYouTubeDownloadList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstYouTubeDownloadList.MouseState = iTunerSkin.MouseState.OUT;
            this.lstYouTubeDownloadList.Name = "lstYouTubeDownloadList";
            this.lstYouTubeDownloadList.OwnerDraw = true;
            this.lstYouTubeDownloadList.Size = new System.Drawing.Size(973, 553);
            this.lstYouTubeDownloadList.TabIndex = 0;
            this.lstYouTubeDownloadList.UseCompatibleStateImageBehavior = false;
            this.lstYouTubeDownloadList.View = System.Windows.Forms.View.Details;
            // 
            // YouTubeNo
            // 
            this.YouTubeNo.Text = "No";
            // 
            // YouTubeLink
            // 
            this.YouTubeLink.Text = "Download Link";
            this.YouTubeLink.Width = 1000;
            // 
            // groupBoxYouTubeDownload
            // 
            this.groupBoxYouTubeDownload.Controls.Add(this.chkVideos);
            this.groupBoxYouTubeDownload.Controls.Add(this.btnDownloadAllYouTube);
            this.groupBoxYouTubeDownload.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxYouTubeDownload.Location = new System.Drawing.Point(777, 3);
            this.groupBoxYouTubeDownload.Name = "groupBoxYouTubeDownload";
            this.groupBoxYouTubeDownload.Size = new System.Drawing.Size(224, 60);
            this.groupBoxYouTubeDownload.TabIndex = 21;
            this.groupBoxYouTubeDownload.TabStop = false;
            this.groupBoxYouTubeDownload.Text = "Download:";
            // 
            // chkVideos
            // 
            this.chkVideos.AutoSize = true;
            this.chkVideos.BackColor = System.Drawing.Color.White;
            this.chkVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVideos.Depth = 0;
            this.chkVideos.Font = new System.Drawing.Font("Roboto", 8F);
            this.chkVideos.Location = new System.Drawing.Point(114, 18);
            this.chkVideos.Margin = new System.Windows.Forms.Padding(0);
            this.chkVideos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkVideos.MouseState = iTunerSkin.MouseState.HOVER;
            this.chkVideos.Name = "chkVideos";
            this.chkVideos.Ripple = true;
            this.chkVideos.Size = new System.Drawing.Size(104, 30);
            this.chkVideos.TabIndex = 10;
            this.chkVideos.Text = "Include Video\'s";
            this.chkVideos.UseVisualStyleBackColor = false;
            // 
            // btnDownloadAllYouTube
            // 
            this.btnDownloadAllYouTube.AutoSize = true;
            this.btnDownloadAllYouTube.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownloadAllYouTube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadAllYouTube.Depth = 0;
            this.btnDownloadAllYouTube.Enabled = false;
            this.btnDownloadAllYouTube.Icon = null;
            this.btnDownloadAllYouTube.Location = new System.Drawing.Point(9, 16);
            this.btnDownloadAllYouTube.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnDownloadAllYouTube.Name = "btnDownloadAllYouTube";
            this.btnDownloadAllYouTube.Primary = true;
            this.btnDownloadAllYouTube.Size = new System.Drawing.Size(102, 36);
            this.btnDownloadAllYouTube.TabIndex = 1;
            this.btnDownloadAllYouTube.Text = "Download All";
            this.btnDownloadAllYouTube.UseVisualStyleBackColor = true;
            this.btnDownloadAllYouTube.Click += new System.EventHandler(this.btnDownloadAllYouTube_Click);
            // 
            // groupBoxYouTubeDetails
            // 
            this.groupBoxYouTubeDetails.Controls.Add(this.btnGetYouTubeLinks);
            this.groupBoxYouTubeDetails.Controls.Add(this.lblSearchDepth);
            this.groupBoxYouTubeDetails.Controls.Add(this.txtSearchDepth);
            this.groupBoxYouTubeDetails.Controls.Add(this.lblYouTubeInitialDownloadLink);
            this.groupBoxYouTubeDetails.Controls.Add(this.txtYouTubeInitialDownloadLink);
            this.groupBoxYouTubeDetails.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxYouTubeDetails.Location = new System.Drawing.Point(8, 3);
            this.groupBoxYouTubeDetails.Name = "groupBoxYouTubeDetails";
            this.groupBoxYouTubeDetails.Size = new System.Drawing.Size(763, 60);
            this.groupBoxYouTubeDetails.TabIndex = 20;
            this.groupBoxYouTubeDetails.TabStop = false;
            this.groupBoxYouTubeDetails.Text = "YouTube Details:";
            // 
            // btnGetYouTubeLinks
            // 
            this.btnGetYouTubeLinks.AutoSize = true;
            this.btnGetYouTubeLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetYouTubeLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetYouTubeLinks.Depth = 0;
            this.btnGetYouTubeLinks.Enabled = false;
            this.btnGetYouTubeLinks.Icon = null;
            this.btnGetYouTubeLinks.Location = new System.Drawing.Point(683, 16);
            this.btnGetYouTubeLinks.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnGetYouTubeLinks.Name = "btnGetYouTubeLinks";
            this.btnGetYouTubeLinks.Primary = true;
            this.btnGetYouTubeLinks.Size = new System.Drawing.Size(74, 36);
            this.btnGetYouTubeLinks.TabIndex = 22;
            this.btnGetYouTubeLinks.Text = "Get Links";
            this.btnGetYouTubeLinks.UseVisualStyleBackColor = true;
            this.btnGetYouTubeLinks.Click += new System.EventHandler(this.btnGetYouTube_Click);
            // 
            // lblSearchDepth
            // 
            this.lblSearchDepth.AutoSize = true;
            this.lblSearchDepth.Depth = 0;
            this.lblSearchDepth.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblSearchDepth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSearchDepth.Location = new System.Drawing.Point(405, 14);
            this.lblSearchDepth.MouseState = iTunerSkin.MouseState.HOVER;
            this.lblSearchDepth.Name = "lblSearchDepth";
            this.lblSearchDepth.Size = new System.Drawing.Size(88, 15);
            this.lblSearchDepth.TabIndex = 20;
            this.lblSearchDepth.Text = "Search Depth?:";
            // 
            // txtSearchDepth
            // 
            this.txtSearchDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDepth.Location = new System.Drawing.Point(408, 32);
            this.txtSearchDepth.Name = "txtSearchDepth";
            this.txtSearchDepth.Size = new System.Drawing.Size(95, 20);
            this.txtSearchDepth.TabIndex = 21;
            this.txtSearchDepth.Text = "0";
            this.txtSearchDepth.TextChanged += new System.EventHandler(this.CheckYouTube);
            // 
            // lblYouTubeInitialDownloadLink
            // 
            this.lblYouTubeInitialDownloadLink.AutoSize = true;
            this.lblYouTubeInitialDownloadLink.Location = new System.Drawing.Point(8, 16);
            this.lblYouTubeInitialDownloadLink.Name = "lblYouTubeInitialDownloadLink";
            this.lblYouTubeInitialDownloadLink.Size = new System.Drawing.Size(155, 13);
            this.lblYouTubeInitialDownloadLink.TabIndex = 19;
            this.lblYouTubeInitialDownloadLink.Text = "YouTube Initial Download Link:";
            // 
            // txtYouTubeInitialDownloadLink
            // 
            this.txtYouTubeInitialDownloadLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYouTubeInitialDownloadLink.Location = new System.Drawing.Point(11, 32);
            this.txtYouTubeInitialDownloadLink.Name = "txtYouTubeInitialDownloadLink";
            this.txtYouTubeInitialDownloadLink.Size = new System.Drawing.Size(391, 20);
            this.txtYouTubeInitialDownloadLink.TabIndex = 18;
            this.txtYouTubeInitialDownloadLink.TextChanged += new System.EventHandler(this.CheckYouTube);
            // 
            // TunerFindMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 781);
            this.Controls.Add(this.iTunerTabControlFindMedia);
            this.Controls.Add(this.iTunerTabSelectorFindMedia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TunerFindMedia";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Media";
            this.TopMost = true;
            this.iTunerTabControlFindMedia.ResumeLayout(false);
            this.Shazam.ResumeLayout(false);
            this.groupBoxShazamListView.ResumeLayout(false);
            this.groupBoxFetchShazam.ResumeLayout(false);
            this.groupBoxFetchShazam.PerformLayout();
            this.groupBoxGetShazam.ResumeLayout(false);
            this.groupBoxGetShazam.PerformLayout();
            this.groupBoxOpenShazam.ResumeLayout(false);
            this.groupBoxOpenShazam.PerformLayout();
            this.SoundCloud.ResumeLayout(false);
            this.groupBoxDefaultDownloaderTrackList.ResumeLayout(false);
            this.groupBoxMultipleTrackDownloader.ResumeLayout(false);
            this.groupBoxMultipleTrackDownloader.PerformLayout();
            this.groupBoxPlaylistDownloader.ResumeLayout(false);
            this.groupBoxPlaylistDownloader.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxSelectiveTrackDownloader.ResumeLayout(false);
            this.groupBoxSelectiveTrackDownloader.PerformLayout();
            this.groupBoxDefaultDownloader.ResumeLayout(false);
            this.groupBoxDefaultDownloader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoundCloudUser)).EndInit();
            this.YouTube.ResumeLayout(false);
            this.groupBoxYouTubeDownloadList.ResumeLayout(false);
            this.groupBoxYouTubeDownload.ResumeLayout(false);
            this.groupBoxYouTubeDownload.PerformLayout();
            this.groupBoxYouTubeDetails.ResumeLayout(false);
            this.groupBoxYouTubeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTunerRaisedButton btnFetchSoundCloud;
        private iTunerTabSelector iTunerTabSelectorFindMedia;
        private iTunerTabControl iTunerTabControlFindMedia;
        private TabPage Shazam;
        private iTunerRaisedButton btnGetShazamWeb;
        private iTunerListView lstHtmlListShazam;
        private ColumnHeader ShazamItemNo;
        private ColumnHeader ShazamArtist;
        private ColumnHeader ShazamTrackName;
        private ColumnHeader ShazamImagePath;
        private ColumnHeader ShazamDownloadUrl;
        private iTunerLabel iTunerLabel1;
        private RichTextBox rtbHtmlTextShazam;
        private iTunerRaisedButton btnGetHTMLListShazam;
        private iTunerLabel lblNumShazams;
        private TabPage SoundCloud;
        private TabPage YouTube;
        private TextBox txtNumShazams;
        private TabPage DownloadManager;
        private TextBox txtSoundCloudUserName;
        private Label lblSoundCloudUserName;
        private iTunerRaisedButton btnDownloadAllSoundCloud;
        private iTunerRaisedButton btnMultipleTracksDownloadSoundCloud;
        private iTunerRaisedButton btnDownloadAllArtistTracksSoundCloud;
        private iTunerRaisedButton btnShowPlaylistTracksSoundCloud;
        private iTunerRaisedButton btnShowMultipleTracksSoundCloud;
        private iTunerRaisedButton btnDownloadSingleTrackSoundCloud;
        private iTunerRaisedButton btnChangeDownloadDirectorySoundCloud;
        private Label lblMultipleTracks;
        private Label lblPlaylistName;
        private TextBox txtPlaylistNameSoundCloud;
        private RichTextBox rtbMultipleTracksSoundCloud;
        private GroupBox groupBoxDefaultDownloaderTrackList;
        private GroupBox groupBoxMultipleTrackDownloader;
        private GroupBox groupBoxPlaylistDownloader;
        private GroupBox groupBoxSettings;
        private GroupBox groupBoxSelectiveTrackDownloader;
        private GroupBox groupBoxDefaultDownloader;
        private iTunerRaisedButton btnPlaylistDownloadSoundCloud;
        private iTunerListView lstDefaultDownloaderTrackListSoundCloud;
        private ColumnHeader SoundCloudNo;
        private ColumnHeader SoundcloudArtist;
        private ColumnHeader SoundCloudTitle;
        private ColumnHeader SoundCloudDownloaded;
        private GroupBox groupBoxShazamListView;
        private GroupBox groupBoxFetchShazam;
        private iTunerRaisedButton btnDownloadShazam;
        private GroupBox groupBoxGetShazam;
        private GroupBox groupBoxOpenShazam;
        private GroupBox groupBoxYouTubeDownloadList;
        private iTunerListView lstYouTubeDownloadList;
        private ColumnHeader YouTubeNo;
        private ColumnHeader YouTubeLink;
        private GroupBox groupBoxYouTubeDownload;
        private iTunerRaisedButton btnDownloadAllYouTube;
        private GroupBox groupBoxYouTubeDetails;
        private iTunerLabel lblSearchDepth;
        private TextBox txtSearchDepth;
        private Label lblYouTubeInitialDownloadLink;
        private TextBox txtYouTubeInitialDownloadLink;
        private PictureBox picSoundCloudUser;
        private iTunerRaisedButton btnGetYouTubeLinks;
        private iTunerCheckBox chkVideos;
    }
}