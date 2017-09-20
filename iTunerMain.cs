using System;
using System.Collections;
using System.Windows.Forms;
using iTunerDownloadManager.App.UI;
using iTunerSkin;
using iTunerSkin.Controls;
using iTunerTagEditor;

namespace iTunerManagerApp
{
    /// <summary>
    /// Main Form
    /// </summary>
    /// <seealso cref="iTunerSkin.Controls.iTunerForm"/>
    public partial class TunerMain : iTunerForm
    {
        #region Constructor

        public string CurrentCircle;

        /// <summary>
        /// Stops the circle.
        /// </summary>
        /// <param name="circleVal">The circle value.</param>
        public void StopCircle(string circleVal)
        {
            switch (circleVal)
            {
                case "A":
                    tunerLoadingCircleA.Visible = false;
                    tunerLoadingCircleA.Active = false;
                    break;
                case "B":
                    tunerLoadingCircleB.Visible = false;
                    tunerLoadingCircleB.Active = false;
                    break;
                case "C":
                    tunerLoadingCircleC.Visible = false;
                    tunerLoadingCircleC.Active = false;
                    break;
                case "D":
                    tunerLoadingCircleD.Visible = false;
                    tunerLoadingCircleD.Active = false;
                    break;
                default:
                    Console.WriteLine(@"Unknown Value Sent Through");
                    break;
            }
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            StopCircle(CurrentCircle);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerManager"/> class.
        /// </summary>
        public TunerMain()
        {
            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);

            StopCircle(@"A");
            StopCircle(@"B");
            StopCircle(@"C");
            StopCircle(@"D");
        }

        #endregion Constructor

        #region Buttons: Internet Getters
        
        /// <summary>
        /// Handles the Click event of the btnFindMedia control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnFindMedia_Click(object sender, EventArgs e)
        {
            tunerLoadingCircleC.Active = true;
            tunerLoadingCircleC.Visible = true;
            tunerLoadingCircleC.Refresh();
            CurrentCircle = @"C";

            OpenFindMedia();
        }

        /// <summary>
        /// Opens the find media.
        /// </summary>
        private void OpenFindMedia()
        {
            Form form = new TunerFindMedia();
            form.Shown += Form_Shown;
            form.ShowDialog();
        }

        #endregion Buttons: Internet Getters
        
        #region Buttons: Local Getters

        /// <summary>
        /// Handles the Click event of the btnCreateNewItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCreateNewItem_Click(object sender, EventArgs e)
        {
            tunerLoadingCircleD.Active = true;
            tunerLoadingCircleD.Visible = true;
            tunerLoadingCircleD.Refresh();
            CurrentCircle = @"D";

            OpenCreateNewItem();
        }

        /// <summary>
        /// Opens the create new item.
        /// </summary>
        private void OpenCreateNewItem()
        {
            Form form = new TunerCreateItem();
            form.Shown += Form_Shown;
            form.ShowDialog();
        }

        #endregion Buttons: Local Getters

        #region Buttons: Local Application Getters

        /// <summary>
        /// Handles the Click event of the btnDownloadManager control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDownloadManager_Click(object sender, EventArgs e)
        {
            tunerLoadingCircleB.Active = true;
            tunerLoadingCircleB.Visible = true;
            tunerLoadingCircleB.Refresh();
            CurrentCircle = @"B";

            OpenDownloadManager();
        }

        /// <summary>
        /// Opens the download manager.
        /// </summary>
        private void OpenDownloadManager()
        {
            using (MainForm frm = new MainForm())
            {
                frm.Shown += Form_Shown;
                frm.FormClosed += WindowClosed_FormClosed;
                MinimizeAllWindows();
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnID3Tagger control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnID3Tagger_Click(object sender, EventArgs e)
        {
            tunerLoadingCircleA.Active = true;
            tunerLoadingCircleA.Visible = true;
            tunerLoadingCircleA.Refresh();
            CurrentCircle = @"A";

            OpenId3Tagger();
        }

        /// <summary>
        /// Opens the i d3 tagger.
        /// </summary>
        private void OpenId3Tagger()
        {
            using (iTunerID3TaggerMain frm = new iTunerID3TaggerMain())
            {
                frm.Shown += Form_Shown;
                frm.FormClosed += WindowClosed_FormClosed;
                MinimizeAllWindows();
                frm.ShowDialog();
            }
        }

        #endregion Buttons: Local Application Getters

        #region Window State Controllers

        private static void MinimizeAllWindows()
        {
            FormCollection fc = Application.OpenForms;
            WindowStateChange(fc, FormWindowState.Minimized);
        }

        private static void WindowClosed_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            WindowStateChange(fc, FormWindowState.Normal);
        }

        private static void WindowStateChange(IEnumerable fc, FormWindowState ws)
        {
            foreach (Form frm in fc)
            {
                if (frm.Name == "iTunerDesktop")
                {
                }
                else
                {
                    frm.WindowState = ws;
                }
            }
        }

        #endregion Window State Controllers
    }
}
