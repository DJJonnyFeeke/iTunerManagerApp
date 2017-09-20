using System;
using System.Windows.Forms;

namespace iTunerManagerApp
{
    /// <summary>
    /// Startup
    /// </summary>
    internal static class Program
    {
        #region Constructor

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TunerManager());

            //SystemTrayProcessIcon taskbarIcon = new SystemTrayProcessIcon();
            //taskbarIcon.Display();

            //Application.Run(new SampleTransparentForm());
        }

        #endregion Constructor
    }
}
