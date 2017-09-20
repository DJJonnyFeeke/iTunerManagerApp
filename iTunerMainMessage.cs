using iTunerSkin;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    /// <summary>
    /// Help message
    /// </summary>
    /// <seealso cref="iTunerSkin.Controls.iTunerForm" />
    public partial class TunerMainMessage : iTunerForm
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerMainMessage"/> class.
        /// </summary>
        public TunerMainMessage()
        {
            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Gets or sets the i tuner main message text.
        /// </summary>
        /// <value>
        /// The i tuner main message text.
        /// </value>
        public string TunerMainMessageText
        {
            get
            {
                return iTunerLabel.Text;
            }
            set
            {
                iTunerLabel.Text = value;
            }
        }

        #endregion Public Methods
    }
}
