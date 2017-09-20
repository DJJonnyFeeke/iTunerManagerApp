using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace iTunerManagerApp
{
    public partial class SampleTransparentForm : Form
    {
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public SampleTransparentForm()
        {
            InitializeComponent();

            //this.TransparencyKey = Color.Turquoise;
            //this.BackColor = Color.Turquoise;

            Opacity = 0.2;
        }

        private void SampleTransparentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
    }
}
