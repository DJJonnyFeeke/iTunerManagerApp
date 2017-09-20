using System.Drawing;
using System.Windows.Forms;

namespace iTunerManagerApp
{
    public partial class TunerAudioPlayer : Form
    {
        public TunerAudioPlayer()
        {
            InitializeComponent();

            //move form to bottom of the screen
            //Rectangle r = Screen.PrimaryScreen.WorkingArea;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width/2 - Width/2, Screen.PrimaryScreen.WorkingArea.Height - Height);
        }
    }
}
