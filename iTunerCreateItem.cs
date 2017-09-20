using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using iTunerSkin;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    /// <summary>
    /// Create a New Item (Covers all database tables and types)
    /// </summary>
    /// <seealso cref="iTunerSkin.Controls.iTunerForm" />
    public partial class TunerCreateItem : iTunerForm
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerCreateItem"/> class.
        /// </summary>
        public TunerCreateItem()
        {
            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);
        }

        #endregion Constructor

        #region Image Downloader

        /// <summary>
        /// The topics
        /// </summary>
        private readonly List<string> _topics = new List<string>();

        /// <summary>
        /// Gets the HTML code.
        /// </summary>
        /// <returns></returns>
        private string GetHtmlCode()
        {
            var rnd = new Random();

            int topic = rnd.Next(0, _topics.Count - 1);

            string url = "https://www.google.com/search?q=" + _topics[topic] + "&tbm=isch";
            string data;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";

            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return "";
                using (var sr = new StreamReader(dataStream))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }

        /// <summary>
        /// Gets the urls.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <returns></returns>
        private static List<string> GetUrls(string html)
        {
            var urls = new List<string>();

            int ndx = html.IndexOf("\"ou\"", StringComparison.Ordinal);

            while (ndx >= 0)
            {
                ndx = html.IndexOf("\"", ndx + 4, StringComparison.Ordinal);
                ndx++;
                int ndx2 = html.IndexOf("\"", ndx, StringComparison.Ordinal);
                string url = html.Substring(ndx, ndx2 - ndx);
                urls.Add(url);
                ndx = html.IndexOf("\"ou\"", ndx2, StringComparison.Ordinal);
            }
            return urls;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private static byte[] GetImage(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000000);

                    return bytes;
                }
            }

            //return null;
        }

        /// <summary>
        /// Finds the image.
        /// </summary>
        private void FindImage()
        {
            string html = GetHtmlCode();
            List<string> urls = GetUrls(html);
            var rnd = new Random();

            int randomUrl = rnd.Next(0, urls.Count - 1);

            string luckyUrl = urls[randomUrl];

            byte[] image = GetImage(luckyUrl);
            using (var ms = new MemoryStream(image))
            {
                imageFind.Image = Image.FromStream(ms);
            }
        }

        #endregion Image Downloader

        #region Buttons: Internet Getters

        /// <summary>
        /// Handles the Click event of the btnFindImage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFindImage_Click(object sender, EventArgs e)
        {
            //search google for a matching image and add to picturebox
            Invoke((MethodInvoker)delegate { imageLoader.Visible = true; });
            _topics.Add("Uncharted Drake");
            FindImage();
            Invoke((MethodInvoker)delegate { imageLoader.Visible = false; });
        }

        #endregion Buttons: Internet Getters
    }
}
