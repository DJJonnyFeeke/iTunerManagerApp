using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunerManagerApp.Properties;

namespace iTunerManagerApp
{
    /// <inheritdoc />
    /// <summary>
    /// Splash Form
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Form" />
    public partial class TunerSplash : Form
    {
        #region Constructor

        /// <summary>
        /// Used for Threading
        /// </summary>
        private delegate void SetImage();

        /// <summary>
        /// Creates the round rect RGN.
        /// </summary>
        /// <param name="nLeftRect">The n left rect.</param>
        /// <param name="nTopRect">The n top rect.</param>
        /// <param name="nRightRect">The n right rect.</param>
        /// <param name="nBottomRect">The n bottom rect.</param>
        /// <param name="nWidthEllipse">The n width ellipse.</param>
        /// <param name="nHeightEllipse">The n height ellipse.</param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int csDropshadow = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= csDropshadow;
                return cp;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTunerManagerApp.TunerSplash" /> class.
        /// </summary>
        public TunerSplash()
        {
            InitializeComponent();

            //create rounded corners for form
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 2, 2));

            //change the image to the app logo
            var newThread = new Thread(SetTimer);
            newThread.Start();

            //set the form opacity
            //this.Opacity = 0.99;
        }

        #endregion Constructor

        #region Change Image

        /// <summary>
        /// Sets the timer.
        /// </summary>
        private void SetTimer()
        {
            Task.Delay(3000).ContinueWith(t => ChangeImage());
        }

        /// <summary>
        /// Changes the image.
        /// </summary>
        private void ChangeImage()
        {
            if (picSplash.InvokeRequired)
            {
                SetImage I = ChangeImage;
                Invoke(I);
            }
            else 
            {
                picSplash.Image = Resources.Wind0ws;
                Refresh();
                Thread.Sleep(6000);
                Close();
            }
        }

        #endregion Change Image

        #region Fade Out Form

        /// <summary>
        /// Forms the fade.
        /// </summary>
        /// <param name="fType">Type of the f.</param>
        public void FormFade(string fType)
        {
            if (fType != "in")
            {
                if (fType == "out")
                {
                    const double i = 0;
                    const double tolerance = i;
                    while (Math.Abs(Opacity) > tolerance)
                    {
                        Opacity -= 0.05;
                        Thread.Sleep(50); //This is for the speed of the opacity... and will let the form redraw
                    }
                }
            }
            else
            {
                const double i = 0;
                const double tolerance = i;
                while (Math.Abs(Opacity - 1) > tolerance)
                {
                    Opacity += 0.05;
                    Thread.Sleep(50); //This is for the speed of the opacity... and will let the form redraw
                }
            }
            Opacity = 1;
        }

        #endregion Fade Out Form
    }
}
