using iTunerSkin;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    /// <summary>
    /// Audio Player for Ituner
    /// </summary>
    /// <seealso cref="iTunerSkin.Controls.iTunerForm" />
    public partial class TunerDjPlayer : iTunerForm
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerDjPlayer"/> class.
        /// </summary>
        public TunerDjPlayer()
        {
            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);
        }

        #endregion Constructor
    }
}
