using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using iTunerManagerApp.Properties;

namespace iTunerManagerApp
{
    /// <inheritdoc />
    /// <summary>
    /// Desktop Component
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Form" />
    public partial class TunerDesktop : Form
    {
        #region Constructor

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTunerManagerApp.TunerDesktop" /> class.
        /// </summary>
        public TunerDesktop()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the iTunerDesktop control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void iTunerDesktop_Load(object sender, EventArgs e)
        {
            //move the info panel to the bottom left corner
            infoPanel.Left = 0;//this.Left + 20;
            infoPanel.Top = 0;//this.Height - infoPanel.Height - 20;
            infoPanel.Height = Height;

            //move the line panel to the right of the info panel
            pnlSideBar.Left = infoPanel.Width;
            pnlSideBar.Top = 0;
            pnlSideBar.Height = Height;

            //move the time to the top right corner
            //lblTime.Location = new Point(this.Width - (lblTime.Width + 20), this.Top + 20);
            
            //set the forms opacity
            Opacity = 1;

            //centre the logo in the screen
            picLogoOverlay.Location = new Point(Width / 2 - picLogoOverlay.Size.Width / 2, Height / 2 - picLogoOverlay.Size.Height / 2);

            //move the dockbar panel to the bottom of the screen centered
            MoveDockBar(dockbarPanel);

            //have to set the ram label once here initially
            string amountRam = CheckRam();
            lblRamInfo.Text = amountRam;

            //init the Speech
            //const bool useSpeech = true;
//            if (useSpeech)
//            {
            InitSpeech();
            SpeechAnalyzer speechAnalyzer = new SpeechAnalyzer(cmbAudioDeviceList, chtSpeechAudioSpectrum)
            {
                Enable = true,
                DisplayEnable = true
            };
            speechAnalyzer.Enable = true;
//            }

            //show the controls
            picLogoOverlay.Visible = true;
            infoPanel.Visible = true;
            picMenu.Visible = true;
            lblMenu.Visible = true;
            picDock.Visible = true;
            lblDock.Visible = true;
            picInternet.Visible = true;
            lblInternet.Visible = true;
            picSpeechStatus.Visible = true;
            lblSpeechStatus.Visible = true;
            chtSpeechAudioSpectrum.Visible = true;
            lblRamInfo.Visible = true;
            lblRam.Visible = true;
            lblTime.Visible = true;
        }

        /// <summary>
        /// Timers the tick.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void TimerTimerTick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            string checkSeconds = DateTime.Now.ToString("ss");
            if (checkSeconds == "59")
            {
                lblInternet.Text = @"...wait";
                timerInternet.Start();
            }
            string checkMinutes = DateTime.Now.ToString("mm");
            if (!new List<int> {00, 05, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60}.Contains(
                Convert.ToInt32(checkMinutes))) return;
            string amountRam = CheckRam();
            lblRamInfo.Text = amountRam;
        }

        /// <summary>
        /// Timers the internet tick.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void TimerInternetTick(object sender, EventArgs e)
        {
            bool isConnected = CheckInternetConnectivity();
            if (isConnected)
            {
                lblInternet.Text = @"Online";
                picInternet.Image = Resources.Online;
                timerInternet.Stop();
            }
            else
            {
                lblInternet.Text = @"Offline";
                picInternet.Image = Resources.Offline;
                timerInternet.Stop();
            }
        }

        /// <summary>
        /// Checks the internet connectivity.
        /// </summary>
        /// <returns></returns>
        public bool CheckInternetConnectivity()
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create("http://www.google.co.za");
                var resp = (HttpWebResponse)req.GetResponse();

                if (resp.StatusCode.ToString().Equals("OK"))
                {
                    Console.WriteLine(@"Connected.");
                    return true;
                }
                Console.WriteLine(@"Connected.");
                return false;
            }
            catch (Exception exc)
            {
                Console.WriteLine(@"Not Connected." + exc.Message);
                return false;
            }
        }

        /// <summary>
        /// Checks the ram.
        /// </summary>
        /// <returns></returns>
        public string CheckRam()
        {
            Process currentProc = Process.GetCurrentProcess();
            long memory = currentProc.PrivateMemorySize64;

            //long memory = GC.GetTotalMemory(true);
            return ToFileSize(memory);
        }

        /// <summary>
        /// To the size of the file.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        private static string ToFileSize(long source)
        {
            const int byteConversion = 1024;
            var bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 3), 2), " GB");
            }
            if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 2), 2), " MB");
            }
            return bytes >= byteConversion ? string.Concat(Math.Round(bytes / byteConversion, 2), " KB") : string.Concat(bytes, " Bytes");
        }

        #endregion Constructor

        #region Buttons

        /// <summary>
        /// Handles the Click event of the picMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picMenu_Click(object sender, EventArgs e)
        {
            // Attach a context menu.
            mainMenu.Show(picMenu, new Point(-44, mainMenu.Height - (mainMenu.Height + mainMenu.Height)));
        }

        /// <summary>
        /// Handles the Click event of the picDock control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picDock_Click(object sender, EventArgs e)
        {
            dockbarPanel.Visible = dockbarPanel.Visible == false;
        }

        #region MainMenu
        
        /// <summary>
        /// Is the About box displayed?
        /// </summary>
        private bool _isAboutLoaded;

        /// <summary>
        /// is the Audio Player displayed?
        /// </summary>
        private bool _isAudioLoaded;

        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the aboutToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isAboutLoaded) return;
            _isAboutLoaded = true;
            TunerAbout frm = new TunerAbout();
            frm.ShowDialog();
            _isAboutLoaded = false;
        }

        /// <summary>
        /// Handles the Click event of the audioPlayerToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void audioPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isAudioLoaded) return;
            _isAudioLoaded = true;
            var frm = new TunerAudioPlayer();
            frm.Show();
            _isAudioLoaded = false;
        }

        /// <summary>
        /// Handles the Click event of the windowsExplorerToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void windowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", null);
        }

        #endregion MainMenu

        #endregion Buttons

        #region DockBar

        /// <summary>
        /// Updates the task active.
        /// </summary>
        /// <param name="theTask">The task.</param>
        /// <param name="moveLeft">The move left.</param>
        private static void UpdateTaskActive(Control theTask, int moveLeft)
        {
            //update the taskActive visibility and location
            theTask.Left = moveLeft;
            theTask.Visible = true;            
        }

        /// <summary>
        /// Updates the task enabled.
        /// </summary>
        /// <param name="theTask">The task.</param>
        /// <param name="theLabel">The label.</param>
        /// <param name="moveLeft">The move left.</param>
        /// <param name="hide"></param>
        private static void UpdateTaskEnabled(Control theTask,Control theLabel, Control moveLeft, bool hide)
        {
            if (hide)
            {
                theLabel.Visible = false;
                theTask.Visible = false;
            }
            else
            {
                //update the taskEnabled visibility and location
                theLabel.Text = moveLeft.Tag.ToString();
                theLabel.Left = moveLeft.Left;
                theLabel.Visible = true;
                theTask.Left = moveLeft.Left;
                theTask.Visible = true;
            }
        }

        /// <summary>
        /// Actions the click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ActionClick(object sender, EventArgs e)
        {
            //get the specific click and call the proper function
            //PictureBox clickedAction = sender as PictureBox;
            UpdateTaskActive(taskActive, taskEnabled.Left);// clickedAction.Left);
            MessageBox.Show(@"The Button has been Clicked");
        }
        
        /// <summary>
        /// Moves the dock bar.
        /// </summary>
        /// <param name="dockPanel">The dock panel.</param>
        private void MoveDockBar(Control dockPanel)
        {
            dockPanel.Location = new Point(Width / 2 - dockPanel.Width / 2, Height - dockPanel.Height);
            //The Dock Scaler
            //startDockScaler();
        }

        ///// <summary>
        ///// The scale timer
        ///// </summary>
        //private DispatcherTimer scaleTimer = new DispatcherTimer();
        ///// <summary>
        ///// The mouse hover
        ///// </summary>
        //private bool scalableImageHover;
        ///// <summary>
        ///// The scalable started
        ///// </summary>
        //private bool scalableStarted;
        ///// <summary>
        ///// The scalable image width
        ///// </summary>
        //private int scalableImageWidth;
        ///// <summary>
        ///// The scalable image height
        ///// </summary>
        //private int scalableImageHeight;
        ///// <summary>
        ///// The curr scalable image
        ///// </summary>
        //private PictureBox currScalableImage;
        ///// <summary>
        ///// Starts the dock scaler.
        ///// </summary>
        //private void startDockScaler()
        //{
        //    //Image pixels: 192x192
        //    scaleTimer.Interval = TimeSpan.FromMilliseconds(1);
        //    scaleTimer.Tick += scaleTimer_Tick;
        //    scalableImageWidth = 100;
        //    scalableImageHeight = 100;
        //    scaleTimer.Start();
        //}

        ///// <summary>
        ///// Handles the Tick event of the scaleTimer control.
        ///// </summary>
        ///// <param name="sender">The source of the event.</param>
        ///// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        //private void scaleTimer_Tick(object sender, EventArgs e)
        //{
        //    //don't forget to change width and location on : taskEnabled & taskEnabledLabel
        //    if (scalableStarted)
        //    {
        //        if (scalableImageHover)
        //        {
        //            //move label left and up
        //            //this.taskEnabledLabel.Left += (currScalableImage.Width < 192) ? 2 : 0;
        //            this.taskEnabledLabel.Top -= (currScalableImage.Height < 192) ? 2 : 0;
        //            //move enabled picture left and up
        //            //this.taskEnabled.Left += (currScalableImage.Width < 192) ? 2 : 0;
        //            this.taskEnabled.Top -= (currScalableImage.Height < 192) ? 2 : 0;
        //            //move picture left and up
        //            currScalableImage.Left -= (currScalableImage.Width < 192) ? 2 : 0;
        //            currScalableImage.Top -= (currScalableImage.Height < 192) ? 2 : 0;

        //            currScalableImage.Width += (currScalableImage.Width < 192) ? 5 : 0;
        //            currScalableImage.Height += (currScalableImage.Height < 192) ? 5 : 0;                   
        //        }
        //        else
        //        {
        //            //move label left and up
        //            //this.taskEnabledLabel.Left += (currScalableImage.Width > scalableImageWidth) ? 2 : 0;
        //            this.taskEnabledLabel.Top += (currScalableImage.Height > scalableImageHeight) ? 2 : 0;
        //            //move enabled picture left and up
        //            //this.taskEnabled.Left += (currScalableImage.Width > scalableImageWidth) ? 2 : 0;
        //            this.taskEnabled.Top += (currScalableImage.Height > scalableImageHeight) ? 2 : 0;
        //            //move picture right and down
        //            currScalableImage.Left += (currScalableImage.Width > scalableImageWidth) ? 2 : 0;
        //            currScalableImage.Top += (currScalableImage.Height > scalableImageHeight) ? 2 : 0;

        //            currScalableImage.Width += (currScalableImage.Width > scalableImageWidth) ? -5 : 0;
        //            currScalableImage.Height += (currScalableImage.Height > scalableImageHeight) ? -5 : 0;
        //        }
        //    }
        //}

        /// <summary>
        /// Handles the MouseEnter event of the scalableImage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void scalableImage_MouseEnter(object sender, EventArgs e)
        {
            //only start when the user mouse the mouse the initial time
            //scalableStarted = true;

            var currScalableImage = sender as PictureBox;
            if (currScalableImage == null) return;
            currScalableImage.BringToFront();
            //scalableImageHover = true;

            UpdateTaskEnabled(taskEnabled, taskEnabledLabel, currScalableImage, false);
        }

        /// <summary>
        /// Handles the MouseLeave event of the scalableImage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void scalableImage_MouseLeave(object sender, EventArgs e)
        {
            PictureBox currScalableImage = sender as PictureBox;
            //scalableImageHover = false;

            UpdateTaskEnabled(taskEnabled, taskEnabledLabel, currScalableImage, true);
        }

        #endregion DockBar

        #region Speech Reader

        /// <summary>
        /// The sp mod
        /// </summary>
        private readonly SpeechModule _spMod = new SpeechModule();
        
        /// <summary>
        /// Initializes the speech.
        /// </summary>
        public void InitSpeech()
        {            
            int checkHour = Convert.ToInt32(DateTime.Now.ToString("hh"));
            string checkTod = DateTime.Now.ToString("tt");
            string speakTime = "";
            speakTime = TimeSwitch(checkHour, checkTod, speakTime);

            _spMod.SpeechReaderSpeak(speakTime + " , please wait while I perform some System Checks!");
        }

        /// <summary>
        /// Handles the Click event of the picSpeechStatus control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picSpeechStatus_Click(object sender, EventArgs e)
        {
            var currImage = sender as PictureBox;
            if(currImage != null && currImage.Tag.ToString() == "Play")
            {
                //set the image
                currImage.Image = Resources.Pause;
                currImage.Tag = "Pause";
                _spMod.SpeechStartListening();
            }
            else
            {
                //set the image
                if (currImage != null)
                {
                    currImage.Image = Resources.Play;
                    currImage.Tag = "Play";
                }
                _spMod.SpeechStopListening();
            }
        }

        /// <summary>
        /// The speech tool tip
        /// </summary>
        private readonly ToolTip _speechToolTip = new ToolTip();

        /// <summary>
        /// Handles the MouseEnter event of the picSpeechStatus control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picSpeechStatus_MouseEnter(object sender, EventArgs e)
        {
            var currImage = sender as PictureBox;
            if (currImage != null && currImage.Tag.ToString() == "Play")
            {
                _speechToolTip.ToolTipTitle = "Hear BOT?";
                _speechToolTip.Show("Activate BOT Assistance!", picSpeechStatus);
            }
            else
            {
                _speechToolTip.ToolTipTitle = "Mute BOT?";
                _speechToolTip.Show("De-Activate BOT Assistance!", picSpeechStatus);
            }
        }

        /// <summary>
        /// Handles the MouseLeave event of the picSpeechStatus control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picSpeechStatus_MouseLeave(object sender, EventArgs e)
        {
            _speechToolTip.Hide(picSpeechStatus);
        }

        /// <summary>
        /// Times the switch.
        /// </summary>
        /// <param name="checkHour">The check hour.</param>
        /// <param name="checkTod">The check tod.</param>
        /// <param name="speakTime">The speak time.</param>
        /// <returns></returns>
        private static string TimeSwitch(int checkHour, string checkTod, string speakTime)
        {
                    if (Enumerable.Range(6, 10).Contains(checkHour))
                    {
                        if (checkTod != "AM")
                        {
                            if (checkTod == "PM")
                            {
                                speakTime = "Good Evening Sir!";
                            }
                        }
                        else
                        {
                            speakTime = "Good Morning Sir!";
                        }
                    }

                    if (Enumerable.Range(2, 5).Contains(checkHour))
                    {
                        if (checkTod != "AM")
                        {
                            if (checkTod == "PM")
                            {
                                speakTime = "Good Afternoon Sir!";
                            }
                        }
                        else
                        {
                            speakTime = "Working after hours Sir!";
                        }
                    }
            if (checkHour != 11)
            {
                if (checkHour != 1)
                {
                    if (checkHour != 12) return speakTime;
                    if (checkTod != "AM")
                    {
                        if (checkTod == "PM")
                        {
                            speakTime = "Hello Sir!";
                        }
                    }
                    else
                    {
                        speakTime = "You really are up late tonight Sir!";
                    }
                }
                else
                {
                    if (checkTod != "AM")
                    {
                        if (checkTod == "PM")
                        {
                            speakTime = "Good Day Sir!";
                        }
                    }
                    else
                    {
                        speakTime = "You up unusually late Sir!";
                    }
                }
            }
            else if (checkTod != "AM")
            {
                if (checkTod == "PM")
                {
                    speakTime = "Working late Sir!";
                }
            }
            else
            {
                speakTime = "Good Day Sir!";
            }
            return speakTime;
        }

        #endregion Speech Reader

        #region OverRides

        //private PictureBox[] picBoxes;

        //public ICollection<PictureBox> PictureBoxes
        //{
        //    get { return picBoxes; }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    picBoxes = new PictureBox[] { picMenu, action1 };
        //    foreach (PictureBox pb in picBoxes)
        //    {
        //        using (Brush border = new SolidBrush(Color.Gray))
        //        {
        //            Rectangle r = new Rectangle(0, 0, pb.Width, pb.Height);
        //            GraphicsPath gp = new GraphicsPath();
        //            int d = 50;
        //            gp.AddArc(r.X, r.Y, d, d, 180, 90);
        //            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
        //            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
        //            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
        //            pb.Region = new Region(gp);
        //        }
        //    }
        //}

        #endregion Overrides
    }
}
