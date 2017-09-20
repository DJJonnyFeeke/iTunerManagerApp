using iTunerSkin;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    public partial class Tuner3RdParty : iTunerForm
    {
        public Tuner3RdParty()
        {
            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
