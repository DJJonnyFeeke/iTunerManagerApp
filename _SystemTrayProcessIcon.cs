using System;
using System.Diagnostics;
using System.Windows.Forms;
using iTunerManagerApp.Properties;

namespace iTunerManagerApp
{
    #region Constructor

    /// <inheritdoc />
    /// <summary>
    /// System Tray Icon
    /// </summary>
    internal class SystemTrayProcessIcon : IDisposable
	{
		/// <summary>
		/// The NotifyIcon object.
		/// </summary>
		private readonly NotifyIcon _ni;

		/// <summary>
		/// Initializes a new instance of the <see cref="SystemTrayProcessIcon"/> class.
		/// </summary>
		public SystemTrayProcessIcon()
		{
			// Instantiate the NotifyIcon object.
			_ni = new NotifyIcon();
		}

		/// <summary>
		/// Displays the icon in the system tray.
		/// </summary>
		public void Display()
		{
			// Put the icon in the system tray and allow it react to mouse clicks.			
			_ni.MouseClick += ni_MouseClick;
			_ni.Icon = Resources.AppLogoIcon;
			_ni.Text = @"iTuner Manager Application";
			_ni.Visible = true;

			// Attach a context menu.
		    //_ni.ContextMenuStrip = 
		}

		/// <inheritdoc />
		/// <summary>
		/// Releases unmanaged and - optionally - managed resources
		/// </summary>
		public void Dispose()
		{
			// When the application closes, this will remove the icon from the system tray immediately.
			_ni.Dispose();
		}

		/// <summary>
		/// Handles the MouseClick event of the ni control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
		private static void ni_MouseClick(object sender, MouseEventArgs e)
		{
			// Handle mouse button clicks.
			if (e.Button == MouseButtons.Left)
			{
				// Start Windows Explorer.
				Process.Start("explorer", null);
			}
		}
    }

    #endregion Constructor
}