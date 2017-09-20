using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using iTunerDatabaseAdministrator;
using iTunerSkin;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    /// <summary>
    /// Main Form
    /// </summary>
    /// <seealso cref="iTunerSkin.Controls.iTunerForm"/>
    public partial class TunerManager : iTunerForm
    {

        #region Constructor

        /// <summary>
        /// The has checked
        /// </summary>
        private bool _hasChecked;

        /// <summary>
        /// The data function{CC2D43FA-BBC4-448A-9D0B-7B57ADF2655C}
        /// </summary>
        private readonly TunerDataMethods _dataFunc = new TunerDataMethods();
        
        /// <summary>
        /// Splashes the form.
        /// </summary>
        public void SplashForm()
        {
            Application.Run(new TunerSplash());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerManager"/> class.
        /// </summary>
        public TunerManager()
        {
            //show the background first
            TunerDesktop frm = new TunerDesktop();
            frm.Show();

            //show splash form
            Thread t = new Thread(SplashForm);
            t.Start();
            Thread.Sleep(6000);

            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);

            CheckDatabaseStatus();

            //start the taskbar app
            // Show the system tray icon.					
            //SystemTrayProcessIcon pi = new SystemTrayProcessIcon();
            //pi.Display();

            //close splash
            t.Abort();

            //set the location of the main app to the top left corner with a offset
            Location = new Point(155, 10);
        }
        
        /// <summary>
        /// Checks the database status.
        /// </summary>
        private bool CheckDatabaseStatus()
        {
            //check database and enable/disable buttons
            try
            {
                _dataFunc.InitDatabase();
                _dataFunc.OpenDatabase();
                bool hasTables = _dataFunc.FindTables(false);

                //enable the buttons if any records are present
                //each individual app will handle the results if no records are present
                //this is just for the initial database creation really
                if (hasTables) { btnViewManager.Enabled = true; btnOpenViewer.Enabled = true; }
                
                _dataFunc.CloseDatabase();
                return true;
            }
            catch
            {
                //no database exists so leave the buttons disabled
                Console.WriteLine(@"Connected.");
                return false;
            }
        }

        #endregion Constructor

        #region DLL Tools

        /// <summary>
        /// Handles the Click event of the btnEditDatabase control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEditDatabase_Click(object sender, EventArgs e)
        {
            using (Form frm = new TunerDatabaseAdministrator())
            {
                frm.FormClosed += WindowClosed_FormClosed;
                MinimizeAllWindows();
                _hasChecked = true;
                frm.ShowDialog();
            }
        }

        #endregion DLL Tools

        #region Browser Tools

        /// <summary>
        /// Handles the Click event of the btnOpenViewer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOpenViewer_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("chrome");
            //var runningProcess = System.Diagnostics.Process.GetProcessesByName("chrome");
            //if (runningProcess.Length != 0)
            //{
                Process.Start("chrome", "file:///D:/Jonathan%20Feeke/My%20Info/Projects/iTunerManagerApplication/iTunerViewer/index.html");
            //}
        }

        #endregion Browser Tools

        #region Main Tools

        /// <summary>
        /// Handles the Click event of the btnViewManager control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnViewManager_Click(object sender, EventArgs e)
        {
            if (CheckDatabaseStatus())
            {
                //show form if the database can be opened
                Form form = new TunerMain();
                form.ShowDialog();
            }
            else
            {
                var frm = new TunerMainMessage
                {
                    TunerMainMessageText = "You have not Created a Database Yet! Please use the Database Tools first!"
                };
                frm.ShowDialog();
            }
        }

        #endregion Main Tools

        #region Information

        /// <summary>
        /// Handles the Click event of the btniTunerHelp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btniTunerHelp_Click(object sender, EventArgs e)
        {
            TunerAbout frmAbout = new TunerAbout();
            frmAbout.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btniTuner3RdParty control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btniTuner3RdParty_Click(object sender, EventArgs e)
        {
            Tuner3RdParty frm3RdParty = new Tuner3RdParty();
            frm3RdParty.ShowDialog();
        }

        #endregion Information

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
                if (frm.Name == "TunerDesktop" || frm.Name == "TunerSplash")
                {
                }
                else
                {
                    frm.WindowState = ws;
                }
            }
        }

        #endregion Window State Controllers

        #region Validation Tools

        /// <summary>
        /// Runs the checks.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RunChecks(object sender, EventArgs e)
        {
            if (!_hasChecked) return;
            CheckDatabaseStatus();
            _hasChecked = false;
        }

        #endregion Validation Tools

    }
}
