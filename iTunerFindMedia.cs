using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using iTunerSkin;
using iTunerSkin.Controls;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using iTunerDatabaseAdministrator;

//Skin
//Shazam
//SoundCloud

//YouTube =>> these already exist above but leaving this here just fyi
//using System;
//using System.IO;
//using System.Net;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Net;
//using Newtonsoft.Json.Linq;

namespace iTunerManagerApp
{
    /// <summary>
    /// Find Media from Various Sources
    /// </summary>
    /// <seealso cref="iTunerSkin.Controls.iTunerForm" />
    public partial class TunerFindMedia : iTunerForm
    {
        #region Constructor

        /// <summary>
        /// The data function
        /// </summary>
        private readonly TunerDataMethods _dataFunc = new TunerDataMethods();

        /// <summary>
        /// The data fields
        /// </summary>
        private readonly TunerDataFields _dataFields = new TunerDataFields();
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TunerFindMedia"/> class.
        /// </summary>
        public TunerFindMedia()
        {
            InitializeComponent();

            // Initialize iTunerSkinManager
            var itunerSkinManager = iTunerSkinManager.Instance;
            itunerSkinManager.AddFormToManage(this);
            itunerSkinManager.Theme = iTunerSkinManager.Themes.DARK;
            itunerSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);

            //init SoundCloud by Creating the DataSaver Once
            GetSoundCloud();
        }

        #endregion Constructor

        #region Shazam

        #region Shazam: Control Functions

        /// <summary>
        /// Handles the Click event of the btnGetShazam control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGetShazam_Click(object sender, EventArgs e)
        {
            //start shazam page
            Process.Start("chrome", "https://www.shazam.com/myshazam");
            //var shazamTab = System.Diagnostics.Process.Start("chrome", "https://www.shazam.com/discovery/v4/en-US/ZA/web/-/tag/FCCE6F06-F3FD-4733-A88D-FF7BFB801A0F?limit=100");  
        }

        /// <summary>
        /// Handles the Click event of the btnDownloadShazam control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDownloadShazam_Click(object sender, EventArgs e)
        {

        }

        #endregion Shazam: Control Functions

        #region Shazam Functions

        /// <summary>
        /// Handles the Click event of the btnGetHTMLList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGetHTMLList_Click(object sender, EventArgs e)
        {
            //database functions
            _dataFunc.InitDatabase();
            _dataFunc.OpenDatabase();

            //clear the list
            lstHtmlListShazam.Items.Clear();

            //get the amount of shazams to process
            int count = Convert.ToInt32(txtNumShazams.Text);

            //load the html text into the agility pack
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(rtbHtmlTextShazam.Text);

            //loop the html and get the required details
            for (int i = 1; i < count + 1; i++)
            {
                try
                {
                    //get track name
                    string trackName = doc.DocumentNode
                        .SelectNodes("/ul[1]/li[" + i + "]/article[1]/div[1]/div[2]/div[1]/a")
                        .First().InnerHtml;

                    //get artist name
                    string artistName;
                    try
                    {
                        artistName = doc.DocumentNode
                            .SelectNodes("/ul[1]/li[" + i + "]/article[1]/div[1]/div[2]/div[2]/a")
                            .First().InnerHtml;
                    }
                    catch
                    {
                        artistName = doc.DocumentNode
                            .SelectNodes("/ul[1]/li[" + i + "]/article[1]/div[1]/div[2]/div[2]/div")
                            .First().InnerHtml;
                    }

                    //get image link
                    string imageLink = doc.DocumentNode
                        .SelectNodes("/ul[1]/li[" + i + "]/article[1]/div[1]/a[1]/img")
                        .First().OuterHtml;
                    //extract the http link
                    int pFrom = imageLink.IndexOf("https", StringComparison.Ordinal);
                    int pTo = imageLink.IndexOf("jpg", StringComparison.Ordinal);
                    string newLink;
                    //determine if there is no cover art
                    if (pFrom == -1)
                    {
                        newLink = "no cover art";
                    }
                    else
                    {
                        newLink = imageLink.Substring(pFrom, pTo - pFrom) + "jpg";
                    }

                    //remove/replace unneeded characters
                    artistName = artistName.Replace("&amp;", "&");
                    trackName = trackName.Replace("&amp;", "&");

                    //build the download link
                    //http://musicpleer.audio/#!charlie+puth+attention
                    string dlLink = "http://musicpleer.audio/#!" + artistName + "+" + trackName;
                    dlLink = dlLink.Replace(" ", "+");

                    //create the list item and add to the list
                    ListViewItem item = new ListViewItem(new[] { i.ToString(), artistName, trackName, newLink, dlLink });

                    _dataFields.TunerId = i;
                    _dataFields.FullPath = dlLink;
                    _dataFields.FileName = artistName + " - " + trackName;
                    _dataFields.FileType = @"Shazam";
                    _dataFields.LinkTable = newLink;
                    _dataFields.Source = dlLink;

                    if (_dataFunc.AddRecord(_dataFields, "mainTable"))
                    {
                        lstHtmlListShazam.Items.Add(item);
                    }
                    else
                    {
                        item = new ListViewItem(new[] { i.ToString(), "...duplicate", "...", "...", "..." });
                        lstHtmlListShazam.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //user probably does not have that many shazams as specified. should notify the user
                    //iTunerMainMessage frm = new iTunerMainMessage();
                    //frm.ShowDialog();
                    //return;
                }
            }
            //database functions
            _dataFunc.CloseDatabase();
        }
        
        /// <summary>
        /// Checks the shazam.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckShazam(object sender, EventArgs e)
        {
            if (rtbHtmlTextShazam.Text == "" || txtNumShazams.Text == "" || txtNumShazams.Text == @"0")
            {
                btnGetHTMLListShazam.Enabled = false;
            }
            else
            {
                btnGetHTMLListShazam.Enabled = true;
            }
        }

        #endregion Shazam Functions

        #endregion Shazam

        #region SoundCloud

        #region SoundCloud: Control Functions

        #region SoundCloud: Main Downloader

        private DataSaver _dataSaver;
        private List<SoundDownloader> _favoritesList;
        private List<TrackInformation> _tracksInfo;
        private string _selectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        private bool _paused;
        private DownloadQueue _queue;
        private Thread _downloadThread;

        private void CheckSoundCloud(object sender, EventArgs e)
        {
            if(txtSoundCloudUserName.Text == "")
            {
                btnFetchSoundCloud.Enabled = false;
                btnDownloadAllSoundCloud.Enabled = false;
            }
            else
            {
                btnFetchSoundCloud.Enabled = true;
            }
        }

        public void GetSoundCloud()
        {
            _dataSaver = new DataSaver();
            SoundCloudAccount.GetPlaylist("https://soundcloud.com/valentinchatelain/sets/electro");
        }

        private void btnFetchSoundCloud_Click(object sender, EventArgs e)
        {
            //database functions
            _dataFunc.InitDatabase();
            _dataFunc.OpenDatabase();

            if (Util.ValidUser(txtSoundCloudUserName.Text))
            {
                var u = SoundCloudAccount.GetUser(txtSoundCloudUserName.Text);

                //System.Windows.Media.Imaging.BitmapImage picSoundCloud = new System.Windows.Media.Imaging.BitmapImage();
                //picSoundCloud.BeginInit();
                //picSoundCloud.UriSource = new Uri(u.AvatarUrl);
                //picSoundCloud.CacheOption = BitmapCacheOption.OnLoad;
                //picSoundCloud.EndInit();
                //picSoundCloudUser.Image = picSoundCloud;

                var wc = new WebClient();
                var bytes = wc.DownloadData(u.AvatarUrl);
                var ms = new MemoryStream(bytes);
                var img = Image.FromStream(ms);

                picSoundCloudUser.Image = img;

                _favoritesList = SoundCloudAccount.GetAllFavorites(txtSoundCloudUserName.Text);
                
                var songs = _dataSaver.Load();
                if (songs != null)
                {
                    foreach (var t in _favoritesList)
                    {
                        foreach (var t1 in songs)
                        {
                            if (t1.Title != t.TrackInformation.Title) continue;
                            t.IsCompleted = true;
                            t.TrackInformation.Downloaded = true;
                            //_favoritesList.Remove(_favoritesList[i]);
                        }
                    }
                }

                //lstDefaultDownloaderTrackListSoundCloud.Items.Clear();

                _tracksInfo = GetTrackInformation(_favoritesList);
                //lstDefaultDownloaderTrackListSoundCloud.Items.AddRange(_tracksInfo);

                var x = 1;
                foreach (var item in _tracksInfo)
                {
                    var curritem = new ListViewItem(new[] { x++.ToString(), item.Artist, item.Title, item.Downloaded.ToString() });

                    _dataFields.TunerId = x;
                    _dataFields.FullPath = @"n/a";
                    _dataFields.FileName = item.Artist + " - " + item.Title;
                    _dataFields.FileType = @"SoundCloud";
                    _dataFields.LinkTable = @"n/a";
                    _dataFields.Source = @"n/a";

                    if (_dataFunc.AddRecord(_dataFields, "mainTable"))
                    {
                        lstDefaultDownloaderTrackListSoundCloud.Items.Add(curritem);
                    }
                    else
                    {
                        curritem = new ListViewItem(new[] { x.ToString(), "...duplicate", "...", "...", "..." });
                        lstDefaultDownloaderTrackListSoundCloud.Items.Add(curritem);
                    }
                }

                btnDownloadAllSoundCloud.Enabled = true;

            }
            else
            {
                MessageBox.Show(@"Invalid username");
            }
            //database functions
            _dataFunc.CloseDatabase();
        }

        private List<TrackInformation> GetTrackInformation(IEnumerable<SoundDownloader> soundList)
        {
            List<TrackInformation> trackList = new List<TrackInformation>();

            foreach (SoundDownloader s in soundList)
            {
                s.OnCompleted += OnCompletedDownload;
                trackList.Add(s.TrackInformation);
            }

            return trackList;
        }

        private void OnCompletedDownload(object sender)
        {
            //database functions
            _dataFunc.InitDatabase();
            _dataFunc.OpenDatabase();

            SoundDownloader sound = sender as SoundDownloader;

            //this.Dispatcher.Invoke(() =>
            //{
                lstDefaultDownloaderTrackListSoundCloud.Items.Clear();
                //lstDefaultDownloaderTrackListSoundCloud.Items.AddRange(_tracksInfo);

                int i = 0;
                foreach (var item in _tracksInfo)
                {
                    ListViewItem curritem = new ListViewItem(new[] { i++.ToString(), item.Artist, item.Title, item.Downloaded.ToString() });

                    _dataFields.TunerId = i;
                    _dataFields.FullPath = @"n/a";
                    _dataFields.FileName = item.Artist + " - " + item.Title;
                    _dataFields.FileType = @"SoundCloud";
                    _dataFields.LinkTable = @"n/a";
                    _dataFields.Source = @"n/a";

                    if (_dataFunc.AddRecord(_dataFields, "mainTable"))
                    {
                        lstDefaultDownloaderTrackListSoundCloud.Items.Add(curritem);
                    }
                    else
                    {
                        curritem = new ListViewItem(new[] { i.ToString(), item.Artist, item.Title, item.Downloaded.ToString() });
                        lstDefaultDownloaderTrackListSoundCloud.Items.Add(curritem);
                    }
                }

            if (sound != null) _dataSaver.SaveTrack(sound.TrackInformation);
            //});

            //database functions
            _dataFunc.CloseDatabase();
        }

        private void btnDownloadAllSoundCloud_Click(object sender, EventArgs e)
        {

            if (!_paused)
            {
                btnDownloadAllSoundCloud.Text = @"Pause";
                _paused = true;
                if (_queue != null)
                {
                    if (_queue.IsPaused)
                    {
                        if (_downloadThread == null)
                        {
                            _downloadThread = new Thread(() =>
                            {
                                _queue.Resume();
                            });
                            _downloadThread.Start();
                        }
                        else
                        {
                            _downloadThread.Abort();
                            _downloadThread = new Thread(() =>
                            {
                                _queue.Resume();
                            });
                            _downloadThread.Start();
                        }


                    }
                }
                if (_downloadThread == null)
                {
                    _downloadThread = new Thread(() =>
                    {
                        _queue = new DownloadQueue(_selectedPath, _favoritesList);
                        _queue.StartDownload();
                    });
                    _downloadThread.Start();
                }
                else
                {
                    _downloadThread.Abort();
                    _downloadThread = new Thread(() =>
                    {
                        _queue = new DownloadQueue(_selectedPath, _favoritesList);
                        _queue.StartDownload();
                    });
                    _downloadThread.Start();
                }

            }
            else
            {
                if (_queue != null)
                {
                    _queue.Pause();
                }
                btnDownloadAllSoundCloud.Text = @"Download All";
                _paused = false;
            }

        }

        public string SelectedPath
        {
            get { return _selectedPath; }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFileDialog = new FolderBrowserDialog();
            DialogResult d = saveFileDialog.ShowDialog();

            if (d == DialogResult.OK)
            {
                _selectedPath = saveFileDialog.SelectedPath;
            }
        }

        private void btnDownloadSingleTrackSoundCloud_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.MyMusic
            };
            var d = saveFileDialog.ShowDialog();

            if (d != DialogResult.OK) return;
            var path = saveFileDialog.SelectedPath;

            var s = Interaction.InputBox("Put a soundcloud track link \nIt will be saved in : " + path,
                "Download single track");

            if (Util.ValidTrackLink(s))
            {
                SoundCloudAccount.DownloadTrack(s, path);
                MessageBox.Show(@"Done !");
            }
            Console.WriteLine(s);
        }

        private void btnShowMultipleTracksSoundCloud_Click(object sender, EventArgs e)
        {
            rtbMultipleTracksSoundCloud.Enabled = true;
            btnMultipleTracksDownloadSoundCloud.Enabled = true;
        }
        
        private void btnShowPlaylistTracksSoundCloud_Click(object sender, EventArgs e)
        {
            txtPlaylistNameSoundCloud.Enabled = true;
            btnShowPlaylistTracksSoundCloud.Enabled = true;
        }
                
        private void btnDownloadArtistTracksSoundCloud_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFileDialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.MyMusic
            };
            DialogResult d = saveFileDialog.ShowDialog();

            if (d != DialogResult.OK) return;
            var path = saveFileDialog.SelectedPath;

            string user = Interaction.InputBox("Put a soundcloud username \nIt will be saved in : " + path,"Download single track");

            if (Util.ValidUser(user))
            {
                var sounds = SoundCloudAccount.GetUserTracks(user);

                DownloadQueue queue = new DownloadQueue(path, sounds);
                Thread t = new Thread(() =>
                {
                    queue.StartDownload();
                    MessageBox.Show(@"Finished !");
                });
                t.Start();
                MessageBox.Show(@"Download started ! \n" +
                                @"Found " + sounds.Count + @" tracks from the artist : " + user);
            }
            Console.WriteLine(user);
        }

        #endregion SoundCloud: Main Downloader

        #region SoundCloud: Playlist Downloader

        private void btnDownloadPlaylistTracksSoundCloud_Click(object sender, EventArgs e)
        {
            string text = txtPlaylistNameSoundCloud.Text;

            JArray tracks = SoundCloudAccount.GetPlaylist(text);
            if (tracks == null)
            {
                MessageBox.Show(@"Error, incorrect url");
                return;
            }

            List<SoundDownloader> soundList = SoundCloudAccount.GetDownloadList(tracks);
            SoundDownloader lastElem = soundList[soundList.Count - 1];
            lastElem.OnCompleted += OnFinishedDownload;
            MessageBox.Show(@"Download starting");
            Thread thread = new Thread(() =>
            {
                foreach (SoundDownloader s in soundList)
                {
                    s.StartDownload(_selectedPath);
                }
            });
            thread.Start();
        }

        private static void OnFinishedDownload(object sender)
        {
            MessageBox.Show(@"Download complete");
        }

        #endregion SoundCloud: Playlist Downloader

        #region SoundCloud: Multiple Track Downloader

        private void btnDownloadMultipleTracks_Click(object sender, EventArgs e)
        {
            string text = rtbMultipleTracksSoundCloud.Text;
            string[] tracks = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            List<string> validTracks = tracks.Where(Util.ValidTrackLink).ToList();
            //List<string> validTracks = tracks.Where(s => Util.ValidTrackLink(s)).ToList();

            MessageBox.Show(@"Found " + validTracks.Count + @" tracks, downloading now ! Songs will be saved at : " +
                            _selectedPath);

            foreach (string t in validTracks)
            {
                SoundCloudAccount.DownloadTrack(t, _selectedPath);
            }

            MessageBox.Show(@"Done ! ");
        }

        #endregion SoundCloud: Multiple Track Downloader

        #endregion SoundCloud: Control Functions

        #region SoundCloud: Functions

        public class DataSaver
        {
            private List<TrackInformation> _soundList;
            public DataSaver()
            {
                _soundList = new List<TrackInformation>();
            }
            public void Save()
            {
                if (_soundList == null)
                    return;
                try
                {
                    using (Stream stream = File.Open("data.bin", FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, _soundList);
                    }
                }
                catch (IOException i)
                {
                    Console.WriteLine(i);
                    throw;
                }
            }
            public void SaveTrack(TrackInformation sound)
            {
                _soundList.Add(sound);
                Save();
            }
            public List<TrackInformation> Load()
            {
                try
                {
                    using (Stream stream = File.Open("data.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        _soundList = (List<TrackInformation>)bin.Deserialize(stream);

                    }
                }
                catch (IOException)
                {
                }

                return _soundList;
            }
        }

        [Serializable]
        public class DownloadQueue
        {
            private readonly Queue<SoundDownloader> _downloadQueue;
            private readonly string _folderPath;

            public DownloadQueue(string folderPath)
            {
                _downloadQueue = new Queue<SoundDownloader>();
                _folderPath = folderPath;
            }

            public DownloadQueue(string folderPath, IEnumerable<SoundDownloader> downloadList)
            {
                _downloadQueue = new Queue<SoundDownloader>();
                _folderPath = folderPath;
                foreach (SoundDownloader s in downloadList)
                {
                    _downloadQueue.Enqueue(s);
                }
            }

            public void Pause()
            {
                IsPaused = true;
            }

            public void Resume()
            {
                if (!IsPaused) return;
                IsPaused = false;
                StartDownload();
            }

            public bool Finished { get; private set; }

            public void Add(SoundDownloader sound)
            {
                lock (_downloadQueue)
                {
                    _downloadQueue.Enqueue(sound);
                }

            }

            public void Get()
            {
                lock (_downloadQueue)
                {
                    _downloadQueue.Dequeue();
                }
            }

            public bool IsPaused { get; private set; }

            public void StartDownload()
            {
                while (true)
                {
                    if (_downloadQueue != null)
                        lock (_downloadQueue)
                        {
                            if (_downloadQueue.Count != 0)
                            {
                                Finished = false;

                                if (IsPaused)
                                {
                                    return;
                                }

                                SoundDownloader currentDl;
                                lock (_downloadQueue)
                                {
                                    currentDl = _downloadQueue.Dequeue();
                                }

                                if (currentDl == null)
                                    return;

                                if (currentDl.IsCompleted)
                                {
                                    continue;
                                }

                                Console.WriteLine(@"Downloading : " + currentDl.TrackTitle);
                                currentDl.OnCompleted += DownloadComplete;
                                try
                                {
                                    currentDl.StartDownload(_folderPath);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.ToString());
                                }
                            }
                            else
                            {
                                Finished = true;
                                Console.WriteLine(@"Connected.");
                            }
                        }
                    break;
                }
            }

            private void DownloadComplete(object sender)
            {
                SoundDownloader s = (SoundDownloader)sender;
                Console.WriteLine(@"Download completed : " + s.TrackTitle);
                if (_downloadQueue.Count != 0)
                {
                    StartDownload();
                }

            }
        }

        public class SoundCloudAccount
        {
            public static string ClientId = "4dd97a35cf647de595b918944aa6915d";
            private static readonly WebClient WebClient = new WebClient();

            public static JObject GetTrack(string url)
            {
                if (!Util.ValidTrackLink(url))
                    return null;

                JObject data =
                   GetJson("http://api.soundcloud.com/resolve.json?url=" + url + "&client_id=" +
                           ClientId);

                return data;
            }

            public static string GetTrackDownloadLink(string url)
            {
                JObject data = GetTrack(url);
                if (data != null && data["stream_url"] != null) return data["stream_url"] + "?client_id=" + ClientId;
                Console.WriteLine(@"Connected.");
                return string.Empty;
            }

            public static void DownloadTrack(string url, string folderPath)
            {
                JObject data = GetTrack(url);
                if (data == null)
                {
                    return;
                }

                try
                {
                    if (data["stream_url"] == null)
                    {
                        if (data["id"] == null)
                            return;

                        WebClient.DownloadFile("https://api.soundcloud.com/tracks/" + data["id"] + "/stream" + "?client_id=" + ClientId, folderPath + @"\" + Util.ValidateString(data["title"].ToString()) + ".mp3");
                        return;
                    }
                    WebClient.DownloadFile(data["stream_url"] + "?client_id=" + ClientId, folderPath + @"\" + Util.ValidateString(data["title"].ToString()) + ".mp3");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            public static JArray GetFavorites(int userId)
            {
                JArray data =
                    GetJsonArray("http://api.soundcloud.com/users/" + userId + "/favorites/?client_id=" + ClientId + "&limit=200");

                return data;
            }

            public static JArray GetPlaylist(string url)
            {
                JObject data =
                    GetJson("http://api.soundcloud.com/resolve.json?url=" + url + "&client_id=" + ClientId);

                JArray t = JArray.Parse(data["tracks"].ToString());

                return t;
            }

            public static List<SoundDownloader> GetUserTracks(string username)
            {
                JArray data =
                    GetJsonArray("http://api.soundcloud.com/users/" + username + "/tracks/?client_id=" + ClientId);

                List<SoundDownloader> sounds = new List<SoundDownloader>();
                if (data == null)
                {
                    return null;
                }

                foreach (var jToken in data)
                {
                    var j = (JObject) jToken;
                    TrackInformation trackInfo = null;
                    if (j["user"]["username"] != null && j["title"] != null && j["duration"] != null)
                    {
                        double duration = Math.Round(double.Parse(j["duration"].ToString()) / 1000 / 60, 2);
                        trackInfo = new TrackInformation(j["user"]["username"].ToString(), j["title"].ToString(), duration);
                    }

                    if (j["stream_url"] == null)
                    {
                        if (j["id"] == null)
                            continue;


                        sounds.Add(new SoundDownloader("https://api.soundcloud.com/tracks/" + j["id"] + "/stream" + "?client_id=" + ClientId, true,
                            trackInfo));
                    }
                    else
                    {
                        sounds.Add(new SoundDownloader(j["stream_url"] + "?client_id=" + ClientId, true, trackInfo));
                    }

                }
                return sounds;
            }

            public static JArray GetFavoritesOffset(int offset, int userId)
            {
                JArray data =
                    GetJsonArray("http://api.soundcloud.com/users/" + userId + "/favorites/?client_id=" + ClientId + "&offset=" + offset + "&limit=200");

                return data;
            }

            public static List<SoundDownloader> GetAllFavorites(string userName)
            {
                User user = GetUser(userName);

                if (user == null)
                {
                    Console.WriteLine(@"Connected.");
                    return null;
                }

                int favoritesCount = user.FavoritesCount;
                int span = (int)Math.Ceiling(favoritesCount / (double)200);
                List<SoundDownloader> soundList = new List<SoundDownloader>();

                for (int i = 0; i < span; i++)
                {
                    JArray data = GetFavoritesOffset(i * 200, user.Id);
                    foreach (var jToken in data)
                    {
                        var j = (JObject) jToken;
                        TrackInformation trackInfo = null;
                        if (j["user"]["username"] != null && j["title"] != null && j["duration"] != null)
                        {
                            double duration = Math.Round(double.Parse(j["duration"].ToString()) / 1000 / 60, 2);
                            trackInfo = new TrackInformation(j["user"]["username"].ToString(), j["title"].ToString(), duration);
                        }

                        if (j["stream_url"] == null)
                        {
                            if (j["id"] == null)
                                continue;


                            soundList.Add(new SoundDownloader("https://api.soundcloud.com/tracks/" + j["id"] + "/stream" + "?client_id=" + ClientId, true,
                                trackInfo));
                        }
                        else
                        {
                            soundList.Add(new SoundDownloader(j["stream_url"] + "?client_id=" + ClientId, true, trackInfo));
                        }

                    }
                }
                return soundList;
            }

            public static List<SoundDownloader> GetDownloadList(JArray soundArray)
            {
                List<SoundDownloader> soundList = new List<SoundDownloader>();
                foreach (var jToken in soundArray)
                {
                    var j = (JObject) jToken;
                    TrackInformation trackInfo = null;
                    if (j["user"]["username"] != null && j["title"] != null && j["duration"] != null)
                    {
                        double duration = Math.Round(double.Parse(j["duration"].ToString()) / 1000 / 60, 2);
                        trackInfo = new TrackInformation(j["user"]["username"].ToString(), j["title"].ToString(), duration);
                    }

                    if (j["stream_url"] == null)
                    {
                        if (j["id"] == null)
                            continue;


                        soundList.Add(new SoundDownloader("https://api.soundcloud.com/tracks/" + j["id"] + "/stream" + "?client_id=" + ClientId, true,
                            trackInfo));
                    }
                    else
                    {
                        soundList.Add(new SoundDownloader(j["stream_url"] + "?client_id=" + ClientId, true, trackInfo));
                    }

                }
                return soundList;
            }

            public static User GetUser(string userName)
            {
                JObject data =
                    GetJson("http://api.soundcloud.com/resolve.json?url=http://soundcloud.com/" + userName + "&client_id=" +
                            ClientId);
                if (data == null)
                {
                    Console.WriteLine(@"Connected.");
                    return null;
                }

                User user = new User(int.Parse(data["id"].ToString()), data["kind"].ToString(), data["permalink"].ToString(), data["username"].ToString(),
                    data["uri"].ToString(), data["permalink_url"].ToString(), data["avatar_url"].ToString(), data["country"].ToString(), data["first_name"].ToString(),
                    data["last_name"].ToString(), data["full_name"].ToString(), data["description"].ToString(), data["city"].ToString(), data["website"].ToString(),
                    data["website_title"].ToString(), bool.Parse(data["online"].ToString()), int.Parse(data["track_count"].ToString()), int.Parse(data["playlist_count"].ToString()),
                    data["plan"].ToString(), int.Parse(data["public_favorites_count"].ToString()), int.Parse(data["followings_count"].ToString()));
                return user;
            }

            public static JObject GetJson(string url)
            {
                try
                {
                    var data = WebClient.DownloadString(url);
                    return JObject.Parse(data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }

            public static JArray GetJsonArray(string url)
            {
                try
                {
                    var data = WebClient.DownloadString(url);
                    return JArray.Parse(data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
        }

        [Serializable]
        public class SoundDownloader
        {
            [NonSerialized]
            private readonly WebClient _webClient;
            [NonSerialized]
            //private AutoResetEvent _waiter;
            private string _url;
            public delegate void OnCompletedEventHandler(object sender);

            private bool _completed;
            public event OnCompletedEventHandler OnCompleted;

            public SoundDownloader(string downloadUrl)
            {
                _webClient = new WebClient();
                _url = downloadUrl;

                DownloadLink = SoundCloudAccount.GetTrackDownloadLink(_url);
                string trackName = SoundCloudAccount.GetTrack(_url)["title"].ToString();

                trackName = Path.GetInvalidFileNameChars().Aggregate(trackName, (current, c) => current.Replace(c, '_'));
                TrackTitle = trackName;

            }

            public SoundDownloader(string downloadUrl, bool isDownLoadLink, TrackInformation trackInfo)
            {
                _webClient = new WebClient();
                DownloadLink = downloadUrl;
                TrackInformation = trackInfo;
                IsDownLoadUrl = isDownLoadLink;
                var trackName = Path.GetInvalidFileNameChars().Aggregate(trackInfo.Title, (current, c) => current.Replace(c, '_'));

                TrackTitle = trackName;
            }

            public TrackInformation TrackInformation { get; private set; }

            public string Url
            {
                get { return _url; }
                set { _url = value; }
            }

            public string TrackTitle { get; private set; }

            public string DownloadLink { get; private set; }

            public bool IsDownLoadUrl { get; private set; }

            public bool IsCompleted
            {
                get { return _completed; }
                set { _completed = value; }
            }

            public void StartDownload(string folderPath)
            {

                _webClient.DownloadFileCompleted += OnDownloadCompleted;
                try
                {
                    _webClient.DownloadFile(DownloadLink, folderPath + @"\" + TrackTitle + ".mp3");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    TrackInformation.Downloaded = true;
                    _completed = true;
                    Completed();

                }
            }

            private void Completed()
            {
                if (OnCompleted != null)
                {
                    OnCompleted(this);

                }
            }

            private static void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
            {
                Console.WriteLine(@"Connected.");
            }

        }

        [Serializable]
        public class TrackInformation
        {
            private bool _downloaded;
            public TrackInformation(string artist, string title, double duration)
            {
                Artist = artist;
                Title = title;
                Duration = duration;
            }

            public string Artist { get; set; }
            public string Title { get; set; }
            public double Duration { get; set; }

            public bool Downloaded
            {
                get { return _downloaded; }
                set { _downloaded = value; }
            }
        }

        public class User
        {
            public User(int id, string kind, string permalink, string username, string uri, string permalinkUrl,
                string avatarUrl, string country, string firstName, string lastName, string fullName, string description,
                string city, string website, string websiteTitle, bool online, int trackCount, int playlistCount, string plan, int favoritesCount, int followingCount
                )
            {
                Id = id;
                Kind = kind;
                Permalink = permalink;
                Username = username;
                Uri1 = uri;
                PermalinkUrl = permalinkUrl;
                AvatarUrl = avatarUrl;
                Country = country;
                FirstName = firstName;
                LastName = lastName;
                FullName = fullName;
                Description = description;
                City = city;
                Website = website;
                WebsiteTitle = websiteTitle;
                Online = online;
                TrackCount = trackCount;
                PlaylistCount = playlistCount;
                Plan = plan;
                FavoritesCount = favoritesCount;
                FollowingCount = followingCount;
            }

            public int Id { get; set; }

            public string Kind { get; set; }

            public string Permalink { get; set; }

            public string Username { get; set; }

            public string Uri1 { get; set; }

            public string PermalinkUrl { get; set; }

            public string AvatarUrl { get; set; }

            public string Country { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string FullName { get; set; }

            public string Description { get; set; }

            public string City { get; set; }

            public string Website { get; set; }

            public string WebsiteTitle { get; set; }

            public bool Online { get; set; }

            public int TrackCount { get; set; }

            public int PlaylistCount { get; set; }

            public string Plan { get; set; }

            public int FavoritesCount { get; set; }

            public int FollowingCount { get; set; }
        }

        public class Util
        {
            public static bool ValidTrackLink(string url)
            {
                Regex r = new Regex(@"https{0,1}:\/\/w{0,3}\.*soundcloud\.com\/([A-Za-z0-9_-]+)\/([A-Za-z0-9_-]+)[^< ]*");
                return r.IsMatch(url);
            }

            public static bool ValidUser(string username)
            {
                JObject data =
                    SoundCloudAccount.GetJson("http://api.soundcloud.com/resolve.json?url=http://soundcloud.com/" + username + "&client_id=" +
                           SoundCloudAccount.ClientId);
                return data != null;
            }

            public static string ValidateString(string s)
            {
                return Path.GetInvalidFileNameChars().Aggregate(s, (current, c) => current.Replace(c, '_'));
            }

        }

        #endregion SoundCloud: Functions

        #endregion SoundCloud

        #region YouTube

        #region YouTube: Control Functions

        /// <summary>
        /// The URL pattern
        /// </summary>
        private const string UrlPattern = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";

        /// <summary>
        /// The tag pattern
        /// </summary>
        private const string TagPattern = @"<a\b[^>]*(.*?)</a>";

        /// <summary>
        /// The email pattern
        /// </summary>
        private const string EmailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        /// <summary>
        /// Downloads the audio.
        /// </summary>
        /// <param name="videoInfos">The video infos.</param>
        private static void DownloadAudio(IEnumerable<VideoInfo> videoInfos)
        {
            /*
             * We want the first extractable video with the highest audio quality.
             */
            //VideoInfo video = videoInfos
            //    .Where(info => info.CanExtractAudio)
            //    .OrderByDescending(info => info.AudioBitrate)
            //    .First();
            foreach (VideoInfo video in videoInfos)
            {
                bool canExtract = video.CanExtractAudio;
                if (!canExtract) continue;
                /*
                     * If the video has a decrypted signature, decipher it
                     */
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                /*
                     * Create the audio downloader.
                     * The first argument is the video where the audio should be extracted from.
                     * The second argument is the path to save the audio file.
                     */

                var audioDownloader = new AudioDownloader(video,
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        RemoveIllegalPathCharacters(video.Title) + video.AudioExtension));

                // Register the progress events. We treat the download progress as 85% of the progress
                // and the extraction progress only as 15% of the progress, because the download will
                // take much longer than the audio extraction.
                audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

                /*
                     * Execute the audio downloader.
                     * For GUI applications note, that this method runs synchronously.
                     */
                audioDownloader.Execute();
            }
        }

        /// <summary>
        /// Downloads the video.
        /// </summary>
        /// <param name="videoInfos">The video infos.</param>
        private static void DownloadVideo(IEnumerable<VideoInfo> videoInfos)
        {
            /*
             * Select the first .mp4 video with 360p resolution
             */
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video,
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));

            // Register the ProgressChanged event and print the current progress
            videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private void btnGetYouTube_Click(object sender, EventArgs e)
        {
            //database functions
            _dataFunc.InitDatabase();
            _dataFunc.OpenDatabase();

            // Our test youtube link
            string link = txtYouTubeInitialDownloadLink.Text;// "https://www.youtube.com/watch?v=YQHsXMglC9A";

            //validate the url
            bool isValid = CheckUrlValid(link);
            if (isValid == false)
            {
                MessageBox.Show(@"Please use a Valid Url to Continue!");
                return;
            }

            // how deep we want to scan for links and total amount of links per page
            //const int level = 2; //technically it is 3 as starts at 0
            int amount = Convert.ToInt32(txtSearchDepth.Text);//5;
            int lv0 = 0, lv1 = 0, lv2 = 0;
            int fileCount = 0;

            //download the initial link
            //RunDownload(link);
            fileCount++;
            Console.WriteLine(@"Total Count: " + fileCount + @" || Count 1st Tier: " + lv0 + @" || Link: " + link);
            ListViewItem item = new ListViewItem(new[] { fileCount.ToString(), link });
            WriteYouTubeDataToDatabase(fileCount, link, item);

            //get the inner links level 0
            IEnumerable<string> innerUrls0 = GetLinks(link);

            //loop the inner links level 0
            foreach (string innerUrl0 in innerUrls0)
            {
                if (!(innerUrl0.IndexOf("/watch?v=", 0, StringComparison.Ordinal) > 0 & lv0 != amount)) continue;
                //RunDownload(innerUrl0);
                fileCount++;
                Console.WriteLine(@"Total Count: " + fileCount + @" || Count 1st Tier: " + lv0 + @" || Link: " + innerUrl0);
                item = new ListViewItem(new[] { fileCount.ToString(), innerUrl0 });
                WriteYouTubeDataToDatabase(fileCount, innerUrl0, item);

                //get the inner links level 1
                IEnumerable<string> innerUrls1 = GetLinks(innerUrl0);

                //loop the inner links level 1
                foreach (string innerUrl1 in innerUrls1)
                {
                    if (!(innerUrl1.IndexOf("/watch?v=", 0, StringComparison.Ordinal) > 0 & lv1 != amount)) continue;
                    //RunDownload(innerUrl1);
                    fileCount++;
                    Console.WriteLine(@"Total Count: " + fileCount + @" || Count 2nd Tier: " + lv1 + @" || Link: " + innerUrl1);
                    item = new ListViewItem(new[] { fileCount.ToString(), innerUrl1 });
                    WriteYouTubeDataToDatabase(fileCount, innerUrl1, item);

                    //get the inner links level 2
                    IEnumerable<string> innerUrls2 = GetLinks(innerUrl1);

                    //loop the inner links level 2
                    foreach (string innerUrl2 in innerUrls2)
                    {
                        if (!(innerUrl2.IndexOf("/watch?v=", 0, StringComparison.Ordinal) > 0 & lv2 != amount)) continue;
                        //RunDownload(innerUrl2);
                        fileCount++;
                        Console.WriteLine(@"Total Count: " + fileCount + @" || Count 3rd Tier: " + lv2 + @" || Link: " + innerUrl2);
                        item = new ListViewItem(new[] { fileCount.ToString(), innerUrl2 });
                        WriteYouTubeDataToDatabase(fileCount, innerUrl2, item);

                        lv2++;
                    }
                    lv2 = 0;
                    lv1++;
                }
                lv1 = 0;
                lv0++;
            }
/*
            lv0 = 0;
*/
            
            Console.WriteLine(@"Connected.");

            btnDownloadAllYouTube.Enabled = true;

            //database functions
            _dataFunc.CloseDatabase();
        }

        /// <summary>
        /// Writes you tube data to database.
        /// </summary>
        /// <param name="fileCount">The file count.</param>
        /// <param name="link">The link.</param>
        /// <param name="item">The item.</param>
        private void WriteYouTubeDataToDatabase(int fileCount, string link, ListViewItem item)
        {
            _dataFields.TunerId = fileCount;
            _dataFields.FullPath = link;
            _dataFields.FileName = @"n/a";
            _dataFields.FileType = @"YouTube";
            _dataFields.LinkTable = @"n/a";
            _dataFields.Source = @"n/a";

            if (_dataFunc.AddRecord(_dataFields, "mainTable"))
            {
                lstYouTubeDownloadList.Items.Add(item);
            }
            else
            {
                item = new ListViewItem(new[] {fileCount.ToString(), "...duplicate", "...", "...", "..."});
                lstYouTubeDownloadList.Items.Add(item);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDownloadAllYouTube control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDownloadAllYouTube_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem row in lstYouTubeDownloadList.Items)
            {
                string dlLink = row.SubItems[1].Text;
                bool vid = chkVideos.Checked;
                RunDownload(dlLink, vid);
            }
        }

        /// <summary>
        /// Runs the download.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <param name="vid"></param>
        private static void RunDownload(string link, bool vid)
        {
            /*
             * Get the available video formats.
             * We'll work with them in the video and audio download examples.
             */
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);

            if (videoInfos == null) return;
            //DownloadAudio(videoInfos);
            //if (vid)
            //{
            //    DownloadVideo(videoInfos);
            //}
            IEnumerable<VideoInfo> infos = videoInfos as VideoInfo[] ?? videoInfos.ToArray();
            DownloadAudio(infos);
            if (vid)
            {
                DownloadVideo(infos);
            }
        }

        /// <summary>
        /// Removes the illegal path characters.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private static IEnumerable<string> GetLinks(string url)
        {
            List<string> innerUrls = GetInnerUrls(url);
            return innerUrls;
        }

        /// <summary>
        /// Checks the URL valid.
        /// </summary>
        /// <param name="strUrl">The string URL.</param>
        /// <returns></returns>
        public static bool CheckUrlValid(string strUrl)
        {
            try
            {
                using (var client = new MyClient())
                {
                    client.HeadOnly = true;
                    string uri = strUrl;
                    try
                    {
                        client.DownloadData(uri);
                        client.Dispose();
                    }
                    catch
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <seealso cref="T:System.Net.WebClient" />
        private class MyClient : WebClient
        {
            /// <summary>
            /// Gets or sets a value indicating whether [head only].
            /// </summary>
            /// <value>
            ///   <c>true</c> if [head only]; otherwise, <c>false</c>.
            /// </value>
            public bool HeadOnly { private get; set; }
            /// <inheritdoc />
            /// <summary>
            /// Returns a <see cref="T:System.Net.WebRequest" /> object for the specified resource.
            /// </summary>
            /// <param name="address">A <see cref="T:System.Uri" /> that identifies the resource to request.</param>
            /// <returns>
            /// A new <see cref="T:System.Net.WebRequest" /> object for the specified resource.
            /// </returns>
            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest req = base.GetWebRequest(address);
                if (req != null && HeadOnly && req.Method == "GET")
                {
                    req.Method = "HEAD";
                }
                return req;
            }
        }

        /// <summary>
        /// Gets the inner urls.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static List<string> GetInnerUrls(string url)
        {
            List<string> innerUrls = new List<string>();

            //create the WebRequest for url eg "http://www.codeproject.com"
            WebRequest request = WebRequest.Create(url);

            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            //get the stream from the web response
            if (responseStream == null) return innerUrls;
            StreamReader reader = new StreamReader(responseStream);

            //get the htmlCode
            string htmlCode = reader.ReadToEnd();

            IEnumerable<string> links = GetMatches(htmlCode);
            foreach (string link in links)
            {
                if (!Regex.IsMatch(link, UrlPattern) && !Regex.IsMatch(link, EmailPattern))
                {
                    string absoluteUrlPath = GetAbsoluteUrl(GetDomainName(url), link);
                    innerUrls.Add(absoluteUrlPath);
                }
                else
                {
                    innerUrls.Add(link);
                }
            }
            return innerUrls;
        }

        /// <summary>
        /// Gets the matches.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        private static IEnumerable<string> GetMatches(string source)
        {
            //reg expression for A Tag [html] 
            //get the collection that match the pattern
            MatchCollection matches = Regex.Matches(source, TagPattern);
            //add the text under the href attribute
            //to the list

            return (from Match match in matches select match.Value.Trim() into val where val.Contains("href=\"") select GetSubstring(val, "href=\"", "\"")).ToList();
        }

        /// <summary>
        /// Gets the substring.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        private static string GetSubstring(string source, string start, string end)
        {
            int startIndex = source.IndexOf(start, StringComparison.Ordinal) + start.Length;
            int length = source.IndexOf(end, startIndex, StringComparison.Ordinal) - startIndex;
            return source.Substring(startIndex, length);
        }

        /// <summary>
        /// Gets the ablosute URL.
        /// </summary>
        /// <param name="domainName">Name of the domain.</param>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        private static string GetAbsoluteUrl(string domainName, string path)
        {
            string absoluteUrl = "";
            if (domainName[domainName.Length - 1] == '/')
            {
                absoluteUrl += domainName;
            }
            else
            {
                absoluteUrl += domainName + "/";
            }

            if (path.Contains("../"))
            {
                string temp = domainName.Substring(0, domainName.LastIndexOf("/", 1, StringComparison.Ordinal));
                temp = temp.Substring(0, temp.LastIndexOf("/", 1, StringComparison.Ordinal));
                absoluteUrl = temp + path.Substring(3);
                return absoluteUrl;
            }
            if (path.Contains("./"))
            {
                string temp = domainName.Substring(0, domainName.LastIndexOf("/", 1, StringComparison.Ordinal));
                absoluteUrl = temp + path.Substring(2);
                return absoluteUrl;
            }
            if (path[0] == '/')
            {
                absoluteUrl += path.Substring(1);
                return absoluteUrl;
            }
            absoluteUrl += path;

            return absoluteUrl;
        }

        /// <summary>
        /// Gets the name of the domain.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private static string GetDomainName(string url)
        {
            int length = url.IndexOf("/", 8, StringComparison.Ordinal);
            string domainName = url.Substring(0, length);
            return domainName;
        }

        /// <summary>
        /// Checks you tube.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckYouTube(object sender, EventArgs e)
        {
            string theDepth = txtSearchDepth.Text;
            if (theDepth == "1" || theDepth == "2" || theDepth == "3")
            {
                if (txtYouTubeInitialDownloadLink.Text == "" || txtSearchDepth.Text == "" || txtSearchDepth.Text == @"0")
                {
                    btnGetYouTubeLinks.Enabled = false;
                }
                else
                {
                    btnGetYouTubeLinks.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(@"The Search Depth should only be between 1 and 3!");
            }
        }

        #endregion YouTube: Control Functions

        #region YouTube: Functions

        internal class AacAudioExtractor : IAudioExtractor
        {
            private readonly FileStream _fileStream;
            private int _aacProfile;
            private int _channelConfig;
            private int _sampleRateIndex;

            public AacAudioExtractor(string path)
            {
                VideoPath = path;
                _fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read, 64 * 1024);
            }

            public string VideoPath { get; private set; }

            public void Dispose()
            {
                _fileStream.Dispose();
            }

            public void WriteChunk(byte[] chunk, uint timeStamp)
            {
                if (chunk.Length < 1)
                {
                    return;
                }

                if (chunk[0] == 0)
                {
                    // Header
                    if (chunk.Length < 3)
                    {
                        return;
                    }

                    ulong bits = (ulong)BigEndianBitConverter.ToUInt16(chunk, 1) << 48;

                    _aacProfile = BitHelper.Read(ref bits, 5) - 1;
                    _sampleRateIndex = BitHelper.Read(ref bits, 4);
                    _channelConfig = BitHelper.Read(ref bits, 4);

                    if (_aacProfile < 0 || _aacProfile > 3)
                        throw new AudioExtractionException("Unsupported AAC profile.");
                    if (_sampleRateIndex > 12)
                        throw new AudioExtractionException("Invalid AAC sample rate index.");
                    if (_channelConfig > 6)
                        throw new AudioExtractionException("Invalid AAC channel configuration.");
                }

                else
                {
                    // Audio data
                    int dataSize = chunk.Length - 1;
                    ulong bits = 0;

                    // Reference: WriteADTSHeader from FAAC's bitstream.c

                    BitHelper.Write(ref bits, 12, 0xFFF);
                    BitHelper.Write(ref bits, 1, 0);
                    BitHelper.Write(ref bits, 2, 0);
                    BitHelper.Write(ref bits, 1, 1);
                    BitHelper.Write(ref bits, 2, _aacProfile);
                    BitHelper.Write(ref bits, 4, _sampleRateIndex);
                    BitHelper.Write(ref bits, 1, 0);
                    BitHelper.Write(ref bits, 3, _channelConfig);
                    BitHelper.Write(ref bits, 1, 0);
                    BitHelper.Write(ref bits, 1, 0);
                    BitHelper.Write(ref bits, 1, 0);
                    BitHelper.Write(ref bits, 1, 0);
                    BitHelper.Write(ref bits, 13, 7 + dataSize);
                    BitHelper.Write(ref bits, 11, 0x7FF);
                    BitHelper.Write(ref bits, 2, 0);

                    _fileStream.Write(BigEndianBitConverter.GetBytes(bits), 1, 7);
                    _fileStream.Write(chunk, 1, dataSize);
                }
            }
        }

        public enum AdaptiveType
        {
            None,
            Audio,
            Video
        }

        /// <inheritdoc />
        /// <summary>
        /// Provides a method to download a video and extract its audio track.
        /// </summary>
        public class AudioDownloader : Downloader
        {
            private bool _isCanceled;

            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTunerManagerApp.iTunerFindMedia.AudioDownloader" /> class.
            /// </summary>
            /// <param name="video">The video to convert.</param>
            /// <param name="savePath">The path to save the audio.</param>
            /// /// <param name="bytesToDownload">An optional value to limit the number of bytes to download.</param>
            /// <exception cref="T:System.ArgumentNullException"><paramref name="video" /> or <paramref name="savePath" /> is <c>null</c>.</exception>
            public AudioDownloader(VideoInfo video, string savePath, int? bytesToDownload = null)
                : base(video, savePath, bytesToDownload)
            { }

            /// <summary>
            /// Occurs when the progress of the audio extraction has changed.
            /// </summary>
            public event EventHandler<ProgressEventArgs> AudioExtractionProgressChanged;

            /// <summary>
            /// Occurs when the download progress of the video file has changed.
            /// </summary>
            public event EventHandler<ProgressEventArgs> DownloadProgressChanged;

            /// <inheritdoc />
            /// <summary>
            /// Downloads the video from YouTube and then extracts the audio track out if it.
            /// </summary>
            /// <exception cref="T:System.IO.IOException">
            /// The temporary video file could not be created.
            /// - or -
            /// The audio file could not be created.
            /// </exception>
            /// <exception cref="T:iTunerManagerApp.iTunerFindMedia.AudioExtractionException">An error occured during audio extraction.</exception>
            /// <exception cref="T:System.Net.WebException">An error occured while downloading the video.</exception>
            public override void Execute()
            {
                string tempPath = Path.GetTempFileName();

                DownloadVideo(tempPath);

                if (!_isCanceled)
                {
                    ExtractAudio(tempPath);
                }

                OnDownloadFinished(EventArgs.Empty);
            }

            private void DownloadVideo(string path)
            {
                var videoDownloader = new VideoDownloader(Video, path, BytesToDownload);

                videoDownloader.DownloadProgressChanged += (sender, args) =>
                {
                    if (DownloadProgressChanged == null) return;
                    DownloadProgressChanged(this, args);

                    _isCanceled = args.Cancel;
                };

                videoDownloader.Execute();
            }

            private void ExtractAudio(string path)
            {
                using (var flvFile = new FlvFile(path, SavePath))
                {
                    flvFile.ConversionProgressChanged += (sender, args) =>
                    {
                        if (AudioExtractionProgressChanged != null)
                        {
                            AudioExtractionProgressChanged(this, new ProgressEventArgs(args.ProgressPercentage));
                        }
                    };

                    flvFile.ExtractStreams();
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// The exception that is thrown when an error occurs durin audio extraction.
        /// </summary>
        [Serializable]
        public class AudioExtractionException : Exception
        {
            public AudioExtractionException(string message)
                : base(message)
            { }

            protected AudioExtractionException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        public enum AudioType
        {
            Aac,
            Mp3,
            Vorbis,

            /// <summary>
            /// The audio type is unknown. This can occur if YoutubeExtractor is not up-to-date.
            /// </summary>
            Unknown
        }

        internal static class BigEndianBitConverter
        {
            public static byte[] GetBytes(ulong value)
            {
                var buff = new byte[8];

                buff[0] = (byte)(value >> 56);
                buff[1] = (byte)(value >> 48);
                buff[2] = (byte)(value >> 40);
                buff[3] = (byte)(value >> 32);
                buff[4] = (byte)(value >> 24);
                buff[5] = (byte)(value >> 16);
                buff[6] = (byte)(value >> 8);
                buff[7] = (byte)value;

                return buff;
            }

            public static byte[] GetBytes(uint value)
            {
                var buff = new byte[4];

                buff[0] = (byte)(value >> 24);
                buff[1] = (byte)(value >> 16);
                buff[2] = (byte)(value >> 8);
                buff[3] = (byte)value;

                return buff;
            }

            public static byte[] GetBytes(ushort value)
            {
                var buff = new byte[2];

                buff[0] = (byte)(value >> 8);
                buff[1] = (byte)value;

                return buff;
            }

            public static ushort ToUInt16(byte[] value, int startIndex)
            {
                return (ushort)(value[startIndex] << 8 | value[startIndex + 1]);
            }

            public static uint ToUInt32(byte[] value, int startIndex)
            {
                return
                    (uint)value[startIndex] << 24 |
                    (uint)value[startIndex + 1] << 16 |
                    (uint)value[startIndex + 2] << 8 |
                    value[startIndex + 3];
            }

            public static ulong ToUInt64(byte[] value, int startIndex)
            {
                return
                    (ulong)value[startIndex] << 56 |
                    (ulong)value[startIndex + 1] << 48 |
                    (ulong)value[startIndex + 2] << 40 |
                    (ulong)value[startIndex + 3] << 32 |
                    (ulong)value[startIndex + 4] << 24 |
                    (ulong)value[startIndex + 5] << 16 |
                    (ulong)value[startIndex + 6] << 8 |
                    value[startIndex + 7];
            }
        }

        internal static class BitHelper
        {
            public static byte[] CopyBlock(byte[] bytes, int offset, int length)
            {
                int startByte = offset / 8;
                int endByte = (offset + length - 1) / 8;
                int shiftA = offset % 8;
                int shiftB = 8 - shiftA;
                var dst = new byte[(length + 7) / 8];

                if (shiftA == 0)
                {
                    Buffer.BlockCopy(bytes, startByte, dst, 0, dst.Length);
                }

                else
                {
                    int i;

                    for (i = 0; i < endByte - startByte; i++)
                    {
                        dst[i] = (byte)(bytes[startByte + i] << shiftA | bytes[startByte + i + 1] >> shiftB);
                    }

                    if (i < dst.Length)
                    {
                        dst[i] = (byte)(bytes[startByte + i] << shiftA);
                    }
                }

                dst[dst.Length - 1] &= (byte)(0xFF << dst.Length * 8 - length);

                return dst;
            }

            public static void CopyBytes(byte[] dst, int dstOffset, byte[] src)
            {
                Buffer.BlockCopy(src, 0, dst, dstOffset, src.Length);
            }

            public static int Read(ref ulong x, int length)
            {
                int r = (int)(x >> 64 - length);
                x <<= length;
                return r;
            }

            public static int Read(byte[] bytes, ref int offset, int length)
            {
                int startByte = offset / 8;
                int endByte = (offset + length - 1) / 8;
                int skipBits = offset % 8;
                ulong bits = 0;

                for (int i = 0; i <= Math.Min(endByte - startByte, 7); i++)
                {
                    bits |= (ulong)bytes[startByte + i] << 56 - i * 8;
                }

                if (skipBits != 0)
                {
                    Read(ref bits, skipBits);
                }

                offset += length;

                return Read(ref bits, length);
            }

            public static void Write(ref ulong x, int length, int value)
            {
                ulong mask = 0xFFFFFFFFFFFFFFFF >> 64 - length;
                x = x << length | (ulong)value & mask;
            }
        }

        internal static class Decipherer
        {
            public static string DecipherWithVersion(string cipher, string cipherVersion)
            {
                string jsUrl = string.Format("http://s.ytimg.com/yts/jsbin/player-{0}.js", cipherVersion);
                string js = HttpHelper.DownloadString(jsUrl);

                //Find "C" in this: var A = B.sig||C (B.s)
                const string functNamePattern = @"\""signature"",\s?([a-zA-Z0-9\$]+)\("; //Regex Formed To Find Word or DollarSign

                var funcName = Regex.Match(js, functNamePattern).Groups[1].Value;

                if (funcName.Contains("$"))
                {
                    funcName = "\\" + funcName; //Due To Dollar Sign Introduction, Need To Escape
                }

                string funcPattern = @"(?!h\.)" + funcName + @"=function\(\w+\)\{.*?\}"; //Escape funcName string
                var funcBody = Regex.Match(js, funcPattern, RegexOptions.Singleline).Value; //Entire sig function
                var lines = funcBody.Split(';'); //Each line in sig function

                string idReverse = "", idSlice = "", idCharSwap = ""; //Hold name for each cipher method
                string functionIdentifier;
                string operations = "";

                foreach (var line in lines.Skip(1).Take(lines.Length - 2)) //Matches the funcBody with each cipher method. Only runs till all three are defined.
                {
                    if (!string.IsNullOrEmpty(idReverse) && !string.IsNullOrEmpty(idSlice) &&
                        !string.IsNullOrEmpty(idCharSwap))
                    {
                        break; //Break loop if all three cipher methods are defined
                    }

                    functionIdentifier = GetFunctionFromLine(line);
                    string reReverse = string.Format(@"{0}:\bfunction\b\(\w+\)", functionIdentifier); //Regex for reverse (one parameter)
                    string reSlice = string.Format(@"{0}:\bfunction\b\([a],b\).(\breturn\b)?.?\w+\.", functionIdentifier); //Regex for slice (return or not)
                    string reSwap = string.Format(@"{0}:\bfunction\b\(\w+\,\w\).\bvar\b.\bc=a\b", functionIdentifier); //Regex for the char swap.

                    if (Regex.Match(js, reReverse).Success)
                    {
                        idReverse = functionIdentifier; //If def matched the regex for reverse then the current function is a defined as the reverse
                    }

                    if (Regex.Match(js, reSlice).Success)
                    {
                        idSlice = functionIdentifier; //If def matched the regex for slice then the current function is defined as the slice.
                    }

                    if (Regex.Match(js, reSwap).Success)
                    {
                        idCharSwap = functionIdentifier; //If def matched the regex for charSwap then the current function is defined as swap.
                    }
                }

                foreach (var line in lines.Skip(1).Take(lines.Length - 2))
                {
                    Match m;
                    functionIdentifier = GetFunctionFromLine(line);

                    if ((m = Regex.Match(line, @"\(\w+,(?<index>\d+)\)")).Success && functionIdentifier == idCharSwap)
                    {
                        operations += "w" + m.Groups["index"].Value + " "; //operation is a swap (w)
                    }

                    if ((m = Regex.Match(line, @"\(\w+,(?<index>\d+)\)")).Success && functionIdentifier == idSlice)
                    {
                        operations += "s" + m.Groups["index"].Value + " "; //operation is a slice
                    }

                    if (functionIdentifier == idReverse) //No regex required for reverse (reverse method has no parameters)
                    {
                        operations += "r "; //operation is a reverse
                    }
                }

                operations = operations.Trim();

                return DecipherWithOperations(cipher, operations);
            }

            private static string ApplyOperation(string cipher, string op)
            {
                switch (op[0])
                {
                    case 'r':
                        return new string(cipher.ToCharArray().Reverse().ToArray());

                    case 'w':
                        {
                            int index = GetOpIndex(op);
                            return SwapFirstChar(cipher, index);
                        }

                    case 's':
                        {
                            int index = GetOpIndex(op);
                            return cipher.Substring(index);
                        }

                    default:
                        throw new NotImplementedException("Couldn't find cipher operation.");
                }
            }

            private static string DecipherWithOperations(string cipher, string operations)
            {
                return operations.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Aggregate(cipher, ApplyOperation);
            }

            private static string GetFunctionFromLine(string currentLine)
            {
                Regex matchFunctionReg = new Regex(@"\w+\.(?<functionID>\w+)\("); //lc.ac(b,c) want the ac part.
                Match rgMatch = matchFunctionReg.Match(currentLine);
                string matchedFunction = rgMatch.Groups["functionID"].Value;
                return matchedFunction; //return 'ac'
            }

            private static int GetOpIndex(string op)
            {
                string parsed = new Regex(@".(\d+)").Match(op).Result("$1");
                int index = int.Parse(parsed);

                return index;
            }

            private static string SwapFirstChar(string cipher, int index)
            {
                var builder = new StringBuilder(cipher);
                builder[0] = cipher[index];
                builder[index] = cipher[0];

                return builder.ToString();
            }
        }

        /// <summary>
        /// Provides the base class for the <see cref="AudioDownloader"/> and <see cref="VideoDownloader"/> class.
        /// </summary>
        public abstract class Downloader
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Downloader"/> class.
            /// </summary>
            /// <param name="video">The video to download/convert.</param>
            /// <param name="savePath">The path to save the video/audio.</param>
            /// /// <param name="bytesToDownload">An optional value to limit the number of bytes to download.</param>
            /// <exception cref="ArgumentNullException"><paramref name="video"/> or <paramref name="savePath"/> is <c>null</c>.</exception>
            protected Downloader(VideoInfo video, string savePath, int? bytesToDownload = null)
            {
                if (video == null)
                    throw new ArgumentNullException("video");

                if (savePath == null)
                    throw new ArgumentNullException("savePath");

                Video = video;
                SavePath = savePath;
                BytesToDownload = bytesToDownload;
            }

            /// <summary>
            /// Occurs when the download finished.
            /// </summary>
            public event EventHandler DownloadFinished;

            /// <summary>
            /// Occurs when the download is starts.
            /// </summary>
            public event EventHandler DownloadStarted;

            /// <summary>
            /// Gets the number of bytes to download. <c>null</c>, if everything is downloaded.
            /// </summary>
            public int? BytesToDownload { get; private set; }

            /// <summary>
            /// Gets the path to save the video/audio.
            /// </summary>
            public string SavePath { get; private set; }

            /// <summary>
            /// Gets the video to download/convert.
            /// </summary>
            public VideoInfo Video { get; private set; }

            /// <summary>
            /// Starts the work of the <see cref="Downloader"/>.
            /// </summary>
            public abstract void Execute();

            protected void OnDownloadFinished(EventArgs e)
            {
                if (DownloadFinished != null)
                {
                    DownloadFinished(this, e);
                }
            }

            protected void OnDownloadStarted(EventArgs e)
            {
                if (DownloadStarted != null)
                {
                    DownloadStarted(this, e);
                }
            }
        }

        /// <summary>
        /// Provides a method to get the download link of a YouTube video.
        /// </summary>
        public static class DownloadUrlResolver
        {
            private const string RateBypassFlag = "ratebypass";
            private const string SignatureQuery = "signature";

            /// <summary>
            /// Decrypts the signature in the <see cref="VideoInfo.DownloadUrl" /> property and sets it
            /// to the decrypted URL. Use this method, if you have decryptSignature in the <see
            /// cref="GetDownloadUrls" /> method set to false.
            /// </summary>
            /// <param name="videoInfo">The video info which's downlaod URL should be decrypted.</param>
            /// <exception cref="YoutubeParseException">
            /// There was an error while deciphering the signature.
            /// </exception>
            public static void DecryptDownloadUrl(VideoInfo videoInfo)
            {
                IDictionary<string, string> queries = HttpHelper.ParseQueryString(videoInfo.DownloadUrl);

                if (!queries.ContainsKey(SignatureQuery)) return;
                string encryptedSignature = queries[SignatureQuery];

                string decrypted;

                try
                {
                    decrypted = GetDecipheredSignature(videoInfo.HtmlPlayerVersion, encryptedSignature);
                }

                catch (Exception ex)
                {
                    throw new YoutubeParseException("Could not decipher signature", ex);
                }

                videoInfo.DownloadUrl = HttpHelper.ReplaceQueryStringParameter(videoInfo.DownloadUrl, SignatureQuery, decrypted);
                videoInfo.RequiresDecryption = false;
            }

            /// <summary>
            /// Gets a list of <see cref="VideoInfo" />s for the specified URL.
            /// </summary>
            /// <param name="videoUrl">The URL of the YouTube video.</param>
            /// <param name="decryptSignature">
            /// A value indicating whether the video signatures should be decrypted or not. Decrypting
            /// consists of a HTTP request for each <see cref="VideoInfo" />, so you may want to set
            /// this to false and call <see cref="DecryptDownloadUrl" /> on your selected <see
            /// cref="VideoInfo" /> later.
            /// </param>
            /// <returns>A list of <see cref="VideoInfo" />s that can be used to download the video.</returns>
            /// <exception cref="ArgumentNullException">
            /// The <paramref name="videoUrl" /> parameter is <c>null</c>.
            /// </exception>
            /// <exception cref="ArgumentException">
            /// The <paramref name="videoUrl" /> parameter is not a valid YouTube URL.
            /// </exception>
            /// <exception cref="VideoNotAvailableException">The video is not available.</exception>
            /// <exception cref="WebException">
            /// An error occurred while downloading the YouTube page html.
            /// </exception>
            /// <exception cref="YoutubeParseException">The Youtube page could not be parsed.</exception>
            public static IEnumerable<VideoInfo> GetDownloadUrls(string videoUrl, bool decryptSignature = true)
            {
                if (videoUrl == null)
                    throw new ArgumentNullException("videoUrl");

                bool isYoutubeUrl = TryNormalizeYoutubeUrl(videoUrl, out videoUrl);

                if (!isYoutubeUrl)
                {
                    throw new ArgumentException("URL is not a valid youtube URL!");
                }

                try
                {
                    var json = LoadJson(videoUrl);

                    string videoTitle = GetVideoTitle(json);

                    IEnumerable<ExtractionInfo> downloadUrls = ExtractDownloadUrls(json);

                    IEnumerable<VideoInfo> infos = GetVideoInfos(downloadUrls, videoTitle).ToList();

                    string htmlPlayerVersion = GetHtml5PlayerVersion(json);

                    foreach (VideoInfo info in infos)
                    {
                        info.HtmlPlayerVersion = htmlPlayerVersion;

                        if (decryptSignature && info.RequiresDecryption)
                        {
                            DecryptDownloadUrl(info);
                        }
                    }

                    return infos;
                }

                catch (Exception ex)
                {
                    if (ex is WebException || ex is VideoNotAvailableException)
                    {
                        throw;
                    }

                    ThrowYoutubeParseException(ex, videoUrl);
                }

                return null; // Will never happen, but the compiler requires it
            }

            /// <summary>
            /// Normalizes the given YouTube URL to the format http://youtube.com/watch?v={youtube-id}
            /// and returns whether the normalization was successful or not.
            /// </summary>
            /// <param name="url">The YouTube URL to normalize.</param>
            /// <param name="normalizedUrl">The normalized YouTube URL.</param>
            /// <returns>
            /// <c>true</c>, if the normalization was successful; <c>false</c>, if the URL is invalid.
            /// </returns>
            public static bool TryNormalizeYoutubeUrl(string url, out string normalizedUrl)
            {
                url = url.Trim();

                url = url.Replace("youtu.be/", "youtube.com/watch?v=");
                url = url.Replace("www.youtube", "youtube");
                url = url.Replace("youtube.com/embed/", "youtube.com/watch?v=");

                if (url.Contains("/v/"))
                {
                    url = "http://youtube.com" + new Uri(url).AbsolutePath.Replace("/v/", "/watch?v=");
                }

                url = url.Replace("/watch#", "/watch?");

                IDictionary<string, string> query = HttpHelper.ParseQueryString(url);

                string v;

                if (!query.TryGetValue("v", out v))
                {
                    normalizedUrl = null;
                    return false;
                }

                normalizedUrl = "http://youtube.com/watch?v=" + v;

                return true;
            }

            private static IEnumerable<ExtractionInfo> ExtractDownloadUrls(JObject json)
            {
                string[] splitByUrls = GetStreamMap(json).Split(',');
                string[] adaptiveFmtSplitByUrls = GetAdaptiveStreamMap(json).Split(',');
                splitByUrls = splitByUrls.Concat(adaptiveFmtSplitByUrls).ToArray();

                foreach (string s in splitByUrls)
                {
                    IDictionary<string, string> queries = HttpHelper.ParseQueryString(s);
                    string url;

                    bool requiresDecryption = false;

                    if (queries.ContainsKey("s") || queries.ContainsKey("sig"))
                    {
                        requiresDecryption = queries.ContainsKey("s");
                        string signature = queries.ContainsKey("s") ? queries["s"] : queries["sig"];

                        url = string.Format("{0}&{1}={2}", queries["url"], SignatureQuery, signature);

                        string fallbackHost = queries.ContainsKey("fallback_host") ? "&fallback_host=" + queries["fallback_host"] : string.Empty;

                        url += fallbackHost;
                    }

                    else
                    {
                        url = queries["url"];
                    }

                    url = HttpHelper.UrlDecode(url);
                    url = HttpHelper.UrlDecode(url);

                    IDictionary<string, string> parameters = HttpHelper.ParseQueryString(url);
                    if (!parameters.ContainsKey(RateBypassFlag))
                        url += string.Format("&{0}={1}", RateBypassFlag, "yes");

                    yield return new ExtractionInfo { RequiresDecryption = requiresDecryption, Uri = new Uri(url) };
                }
            }

            private static string GetAdaptiveStreamMap(JObject json)
            {
                JToken streamMap = json["args"]["adaptive_fmts"] ?? json["args"]["url_encoded_fmt_stream_map"];

                // bugfix: adaptive_fmts is missing in some videos, use url_encoded_fmt_stream_map instead

                return streamMap.ToString();
            }

            private static string GetDecipheredSignature(string htmlPlayerVersion, string signature)
            {
                return Decipherer.DecipherWithVersion(signature, htmlPlayerVersion);
            }

            private static string GetHtml5PlayerVersion(JObject json)
            {
                var regex = new Regex(@"player-(.+?).js");

                string js = json["assets"]["js"].ToString();

                return regex.Match(js).Result("$1");
            }

            private static string GetStreamMap(JObject json)
            {
                JToken streamMap = json["args"]["url_encoded_fmt_stream_map"];

                string streamMapString = streamMap == null ? null : streamMap.ToString();

                if (streamMapString == null || streamMapString.Contains("been+removed"))
                {
                    throw new VideoNotAvailableException("Video is removed or has an age restriction.");
                }

                return streamMapString;
            }

            private static IEnumerable<VideoInfo> GetVideoInfos(IEnumerable<ExtractionInfo> extractionInfos, string videoTitle)
            {
                var downLoadInfos = new List<VideoInfo>();

                foreach (ExtractionInfo extractionInfo in extractionInfos)
                {
                    string itag = HttpHelper.ParseQueryString(extractionInfo.Uri.Query)["itag"];

                    int formatCode = int.Parse(itag);

                    VideoInfo info = VideoInfo.Defaults.SingleOrDefault(videoInfo => videoInfo.FormatCode == formatCode);

                    if (info != null)
                    {
                        info = new VideoInfo(info)
                        {
                            DownloadUrl = extractionInfo.Uri.ToString(),
                            Title = videoTitle,
                            RequiresDecryption = extractionInfo.RequiresDecryption
                        };
                    }

                    else
                    {
                        info = new VideoInfo(formatCode)
                        {
                            DownloadUrl = extractionInfo.Uri.ToString()
                        };
                    }

                    downLoadInfos.Add(info);
                }

                return downLoadInfos;
            }

            private static string GetVideoTitle(JObject json)
            {
                JToken title = json["args"]["title"];

                return title == null ? string.Empty : title.ToString();
            }

            private static bool IsVideoUnavailable(string pageSource)
            {
                const string unavailableContainer = "<div id=\"watch-player-unavailable\">";

                return pageSource.Contains(unavailableContainer);
            }

            private static JObject LoadJson(string url)
            {
                string pageSource = HttpHelper.DownloadString(url);

                if (IsVideoUnavailable(pageSource))
                {
                    throw new VideoNotAvailableException();
                }

                var dataRegex = new Regex(@"ytplayer\.config\s*=\s*(\{.+?\});", RegexOptions.Multiline);

                string extractedJson = dataRegex.Match(pageSource).Result("$1");

                return JObject.Parse(extractedJson);
            }

            private static void ThrowYoutubeParseException(Exception innerException, string videoUrl)
            {
                throw new YoutubeParseException("Could not parse the Youtube page for URL " + videoUrl + "\n" +
                                                "This may be due to a change of the Youtube page structure.\n" +
                                                "Please report this bug at www.github.com/flagbug/YoutubeExtractor/issues", innerException);
            }

            private class ExtractionInfo
            {
                public bool RequiresDecryption { get; set; }

                public Uri Uri { get; set; }
            }
        }

        internal class FlvFile : IDisposable
        {
            private readonly long _fileLength;
            private readonly string _outputPath;
            private IAudioExtractor _audioExtractor;
            private long _fileOffset;
            private FileStream _fileStream;

            /// <summary>
            /// Initializes a new instance of the <see cref="FlvFile"/> class.
            /// </summary>
            /// <param name="inputPath">The path of the input.</param>
            /// <param name="outputPath">The path of the output without extension.</param>
            public FlvFile(string inputPath, string outputPath)
            {
                _outputPath = outputPath;
                _fileStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read, 64 * 1024);
                _fileOffset = 0;
                _fileLength = _fileStream.Length;
            }

            public event EventHandler<ProgressEventArgs> ConversionProgressChanged;

            public bool ExtractedAudio { get; private set; }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            /// <exception cref="AudioExtractionException">The input file is not an FLV file.</exception>
            public void ExtractStreams()
            {
                Seek(0);

                if (ReadUInt32() != 0x464C5601)
                {
                    // not a FLV file
                    throw new AudioExtractionException("Invalid input file. Impossible to extract audio track.");
                }

                ReadUInt8();
                uint dataOffset = ReadUInt32();

                Seek(dataOffset);

                ReadUInt32();

                while (_fileOffset < _fileLength)
                {
                    if (!ReadTag())
                    {
                        break;
                    }

                    if (_fileLength - _fileOffset < 4)
                    {
                        break;
                    }

                    ReadUInt32();

                    double progress = _fileOffset * 1.0 / _fileLength * 100;

                    if (ConversionProgressChanged != null)
                    {
                        ConversionProgressChanged(this, new ProgressEventArgs(progress));
                    }
                }

                CloseOutput(false);
            }

            private void CloseOutput(bool disposing)
            {
                if (_audioExtractor == null) return;
                if (disposing && _audioExtractor.VideoPath != null)
                {
                    try
                    {
                        File.Delete(_audioExtractor.VideoPath);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(@"Unable to Delete Video");
                    }
                }

                _audioExtractor.Dispose();
                _audioExtractor = null;
            }

            private void Dispose(bool disposing)
            {
                if (!disposing) return;
                if (_fileStream != null)
                {
                    _fileStream.Close();
                    _fileStream = null;
                }

                CloseOutput(true);
            }

            private IAudioExtractor GetAudioWriter(uint mediaInfo)
            {
                uint format = mediaInfo >> 4;

                if (format == 14 || format == 2)
                    return new Mp3AudioExtractor(_outputPath);
                if (format == 10)
                {
                    return new AacAudioExtractor(_outputPath);
                }

                string typeStr;

                switch (format)
                {
                    case 1:
                        typeStr = "ADPCM";
                        break;

                    case 6:
                    case 5:
                    case 4:
                        typeStr = "Nellymoser";
                        break;

                    default:
                        typeStr = "format=" + format;
                        break;
                }

                throw new AudioExtractionException("Unable to extract audio (" + typeStr + " is unsupported).");
            }

            private byte[] ReadBytes(int length)
            {
                var buff = new byte[length];

                _fileStream.Read(buff, 0, length);
                _fileOffset += length;

                return buff;
            }

            private bool ReadTag()
            {
                if (_fileLength - _fileOffset < 11)
                    return false;

                // Read tag header
                uint tagType = ReadUInt8();
                uint dataSize = ReadUInt24();
                uint timeStamp = ReadUInt24();
                timeStamp |= ReadUInt8() << 24;
                ReadUInt24();

                // Read tag data
                if (dataSize == 0)
                    return true;

                if (_fileLength - _fileOffset < dataSize)
                    return false;

                uint mediaInfo = ReadUInt8();
                dataSize -= 1;
                byte[] data = ReadBytes((int)dataSize);

                if (tagType != 0x8) return true;
                // If we have no audio writer, create one
                if (_audioExtractor == null)
                {
                    _audioExtractor = GetAudioWriter(mediaInfo);
                    ExtractedAudio = _audioExtractor != null;
                }

                if (_audioExtractor == null)
                {
                    throw new InvalidOperationException("No supported audio writer found.");
                }

                _audioExtractor.WriteChunk(data, timeStamp);

                return true;
            }

            private uint ReadUInt24()
            {
                var x = new byte[4];

                _fileStream.Read(x, 1, 3);
                _fileOffset += 3;

                return BigEndianBitConverter.ToUInt32(x, 0);
            }

            private uint ReadUInt32()
            {
                var x = new byte[4];

                _fileStream.Read(x, 0, 4);
                _fileOffset += 4;

                return BigEndianBitConverter.ToUInt32(x, 0);
            }

            private uint ReadUInt8()
            {
                _fileOffset += 1;
                return (uint)_fileStream.ReadByte();
            }

            private void Seek(long offset)
            {
                _fileStream.Seek(offset, SeekOrigin.Begin);
                _fileOffset = offset;
            }
        }

        internal static class HttpHelper
        {
            public static string DownloadString(string url)
            {
                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    return client.DownloadString(url);
                }
            }

            public static string HtmlDecode(string value)
            {
                return HttpUtility.HtmlDecode(value);
            }

            public static IDictionary<string, string> ParseQueryString(string s)
            {
                // remove anything other than query string from url
                if (s.Contains("?"))
                {
                    s = s.Substring(s.IndexOf('?') + 1);
                }

                return Regex.Split(s, "&").Select(vp => Regex.Split(vp, "=")).ToDictionary(strings => strings[0], strings => strings.Length == 2 ? UrlDecode(strings[1]) : string.Empty);
            }

            public static string ReplaceQueryStringParameter(string currentPageUrl, string paramToReplace, string newValue)
            {
                var query = ParseQueryString(currentPageUrl);

                query[paramToReplace] = newValue;

                var resultQuery = new StringBuilder();
                bool isFirst = true;

                foreach (KeyValuePair<string, string> pair in query)
                {
                    if (!isFirst)
                    {
                        resultQuery.Append("&");
                    }

                    resultQuery.Append(pair.Key);
                    resultQuery.Append("=");
                    resultQuery.Append(pair.Value);

                    isFirst = false;
                }

                var uriBuilder = new UriBuilder(currentPageUrl)
                {
                    Query = resultQuery.ToString()
                };

                return uriBuilder.ToString();
            }

            public static string UrlDecode(string url)
            {
                return HttpUtility.UrlDecode(url);
            }

/*
            private static string ReadStreamFromResponse(WebResponse response)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var sr = new StreamReader(responseStream))
                        {
                            return sr.ReadToEnd();
                        }
                }
            }
*/
        }

        internal interface IAudioExtractor : IDisposable
        {
            string VideoPath { get; }

            /// <exception cref="AudioExtractionException">An error occured while writing the chunk.</exception>
            void WriteChunk(byte[] chunk, uint timeStamp);
        }

        internal class Mp3AudioExtractor : IAudioExtractor
        {
            private readonly List<byte[]> _chunkBuffer;
            private readonly FileStream _fileStream;
            private readonly List<uint> _frameOffsets;
            private readonly List<string> _warnings;
            private int _channelMode;
            private bool _delayWrite;
            private int _firstBitRate;
            private uint _firstFrameHeader;
            private bool _hasVbrHeader;
            private bool _isVbr;
            private int _mpegVersion;
            private int _sampleRate;
            private uint _totalFrameLength;
            private bool _writeVbrHeader;

            public Mp3AudioExtractor(string path)
            {
                VideoPath = path;
                _fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read, 64 * 1024);
                _warnings = new List<string>();
                _chunkBuffer = new List<byte[]>();
                _frameOffsets = new List<uint>();
                _delayWrite = true;
            }

            public string VideoPath { get; private set; }

            public IEnumerable<string> Warnings
            {
                get { return _warnings; }
            }

            public void Dispose()
            {
                Flush();

                if (_writeVbrHeader)
                {
                    _fileStream.Seek(0, SeekOrigin.Begin);
                    WriteVbrHeader(false);
                }

                _fileStream.Dispose();
            }

            public void WriteChunk(byte[] chunk, uint timeStamp)
            {
                _chunkBuffer.Add(chunk);
                ParseMp3Frames(chunk);

                if (_delayWrite && _totalFrameLength >= 65536)
                {
                    _delayWrite = false;
                }

                if (!_delayWrite)
                {
                    Flush();
                }
            }

            private static int GetFrameDataOffset(int mpegVersion, int channelMode)
            {
                return 4 + (mpegVersion == 3 ?
                    (channelMode == 3 ? 17 : 32) :
                    (channelMode == 3 ? 9 : 17));
            }

            private static int GetFrameLength(int mpegVersion, int bitRate, int sampleRate, int padding)
            {
                return (mpegVersion == 3 ? 144 : 72) * bitRate / sampleRate + padding;
            }

            private void Flush()
            {
                foreach (byte[] chunk in _chunkBuffer)
                {
                    _fileStream.Write(chunk, 0, chunk.Length);
                }

                _chunkBuffer.Clear();
            }

            private void ParseMp3Frames(byte[] buffer)
            {
                var mpeg1BitRate = new[] { 0, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320, 0 };
                var mpeg2XBitRate = new[] { 0, 8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 112, 128, 144, 160, 0 };
                var mpeg1SampleRate = new[] { 44100, 48000, 32000, 0 };
                var mpeg20SampleRate = new[] { 22050, 24000, 16000, 0 };
                var mpeg25SampleRate = new[] { 11025, 12000, 8000, 0 };

                int offset = 0;
                int length = buffer.Length;

                while (length >= 4)
                {
                    ulong header = (ulong)BigEndianBitConverter.ToUInt32(buffer, offset) << 32;

                    if (BitHelper.Read(ref header, 11) != 0x7FF)
                    {
                        break;
                    }

                    var mpegVersion = BitHelper.Read(ref header, 2);
                    int layer = BitHelper.Read(ref header, 2);
                    BitHelper.Read(ref header, 1);
                    int bitRate = BitHelper.Read(ref header, 4);
                    var sampleRate = BitHelper.Read(ref header, 2);
                    int padding = BitHelper.Read(ref header, 1);
                    BitHelper.Read(ref header, 1);
                    var channelMode = BitHelper.Read(ref header, 2);

                    if (mpegVersion == 1 || layer != 1 || bitRate == 0 || bitRate == 15 || sampleRate == 3)
                    {
                        break;
                    }

                    bitRate = (mpegVersion == 3 ? mpeg1BitRate[bitRate] : mpeg2XBitRate[bitRate]) * 1000;

                    switch (mpegVersion)
                    {
                        case 2:
                            sampleRate = mpeg20SampleRate[sampleRate];
                            break;

                        case 3:
                            sampleRate = mpeg1SampleRate[sampleRate];
                            break;

                        default:
                            sampleRate = mpeg25SampleRate[sampleRate];
                            break;
                    }

                    int frameLenght = GetFrameLength(mpegVersion, bitRate, sampleRate, padding);

                    if (frameLenght > length)
                    {
                        break;
                    }

                    bool isVbrHeaderFrame = false;

                    if (_frameOffsets.Count == 0)
                    {
                        // Check for an existing VBR header just to be safe (I haven't seen any in FLVs)
                        int o = offset + GetFrameDataOffset(mpegVersion, channelMode);

                        if (BigEndianBitConverter.ToUInt32(buffer, o) == 0x58696E67)
                        {
                            // "Xing"
                            isVbrHeaderFrame = true;
                            _delayWrite = false;
                            _hasVbrHeader = true;
                        }
                    }

                    if (!isVbrHeaderFrame)
                    {
                        if (_firstBitRate == 0)
                        {
                            _firstBitRate = bitRate;
                            _mpegVersion = mpegVersion;
                            _sampleRate = sampleRate;
                            _channelMode = channelMode;
                            _firstFrameHeader = BigEndianBitConverter.ToUInt32(buffer, offset);
                        }

                        else if (!_isVbr && bitRate != _firstBitRate)
                        {
                            _isVbr = true;

                            if (!_hasVbrHeader)
                            {
                                if (_delayWrite)
                                {
                                    WriteVbrHeader(true);
                                    _writeVbrHeader = true;
                                    _delayWrite = false;
                                }

                                else
                                {
                                    _warnings.Add("Detected VBR too late, cannot add VBR header.");
                                }
                            }
                        }
                    }

                    _frameOffsets.Add(_totalFrameLength + (uint)offset);

                    offset += frameLenght;
                    length -= frameLenght;
                }

                _totalFrameLength += (uint)buffer.Length;
            }

            private void WriteVbrHeader(bool isPlaceholder)
            {
                var buffer = new byte[GetFrameLength(_mpegVersion, 64000, _sampleRate, 0)];

                if (!isPlaceholder)
                {
                    uint header = _firstFrameHeader;
                    int dataOffset = GetFrameDataOffset(_mpegVersion, _channelMode);
                    header &= 0xFFFE0DFF; // Clear CRC, bitrate, and padding fields
                    header |= (uint)(_mpegVersion == 3 ? 5 : 8) << 12; // 64 kbit/sec
                    BitHelper.CopyBytes(buffer, 0, BigEndianBitConverter.GetBytes(header));
                    BitHelper.CopyBytes(buffer, dataOffset, BigEndianBitConverter.GetBytes(0x58696E67)); // "Xing"
                    BitHelper.CopyBytes(buffer, dataOffset + 4, BigEndianBitConverter.GetBytes((uint)0x7)); // Flags
                    BitHelper.CopyBytes(buffer, dataOffset + 8, BigEndianBitConverter.GetBytes((uint)_frameOffsets.Count)); // Frame count
                    BitHelper.CopyBytes(buffer, dataOffset + 12, BigEndianBitConverter.GetBytes(_totalFrameLength)); // File length

                    for (int i = 0; i < 100; i++)
                    {
                        int frameIndex = (int)(i / 100.0 * _frameOffsets.Count);

                        buffer[dataOffset + 16 + i] = (byte)(_frameOffsets[frameIndex] / (double)_totalFrameLength * 256.0);
                    }
                }

                _fileStream.Write(buffer, 0, buffer.Length);
            }
        }

        public class ProgressEventArgs : EventArgs
        {
            public ProgressEventArgs(double progressPercentage)
            {
                ProgressPercentage = progressPercentage;
            }

            /// <summary>
            /// Gets or sets a token whether the operation that reports the progress should be canceled.
            /// </summary>
            public bool Cancel { get; set; }

            /// <summary>
            /// Gets the progress percentage in a range from 0.0 to 100.0.
            /// </summary>
            public double ProgressPercentage { get; private set; }
        }

        /// <inheritdoc />
        /// <summary>
        /// Provides a method to download a video from YouTube.
        /// </summary>
        public class VideoDownloader : Downloader
        {
            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTunerManagerApp.iTunerFindMedia.VideoDownloader" /> class.
            /// </summary>
            /// <param name="video">The video to download.</param>
            /// <param name="savePath">The path to save the video.</param>
            /// <param name="bytesToDownload">An optional value to limit the number of bytes to download.</param>
            /// <exception cref="T:System.ArgumentNullException"><paramref name="video" /> or <paramref name="savePath" /> is <c>null</c>.</exception>
            public VideoDownloader(VideoInfo video, string savePath, int? bytesToDownload = null)
                : base(video, savePath, bytesToDownload)
            { }

            /// <summary>
            /// Occurs when the downlaod progress of the video file has changed.
            /// </summary>
            public event EventHandler<ProgressEventArgs> DownloadProgressChanged;

            /// <inheritdoc />
            /// <summary>
            /// Starts the video download.
            /// </summary>
            /// <exception cref="T:System.IO.IOException">The video file could not be saved.</exception>
            /// <exception cref="T:System.Net.WebException">An error occured while downloading the video.</exception>
            public override void Execute()
            {
                OnDownloadStarted(EventArgs.Empty);

                var request = (HttpWebRequest)WebRequest.Create(Video.DownloadUrl);

                if (BytesToDownload.HasValue)
                {
                    request.AddRange(0, BytesToDownload.Value - 1);
                }

                // the following code is alternative, you may implement the function after your needs
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream source = response.GetResponseStream())
                    {
                        using (FileStream target = File.Open(SavePath, FileMode.Create, FileAccess.Write))
                        {
                            var buffer = new byte[1024];
                            bool cancel = false;
                            int bytes;
                            int copiedBytes = 0;

                            while (source != null && !cancel && (bytes = source.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                target.Write(buffer, 0, bytes);

                                copiedBytes += bytes;

                                var eventArgs = new ProgressEventArgs(copiedBytes * 1.0 / response.ContentLength * 100);

                                if (DownloadProgressChanged == null) continue;
                                DownloadProgressChanged(this, eventArgs);

                                if (eventArgs.Cancel)
                                {
                                    cancel = true;
                                }
                            }
                        }
                    }
                }

                OnDownloadFinished(EventArgs.Empty);
            }
        }

        public class VideoInfo
        {
            internal static IEnumerable<VideoInfo> Defaults = new List<VideoInfo>
        {
            /* Non-adaptive */
            new VideoInfo(5, VideoType.Flash, 240, false, AudioType.Mp3, 64, AdaptiveType.None),
            new VideoInfo(6, VideoType.Flash, 270, false, AudioType.Mp3, 64, AdaptiveType.None),
            new VideoInfo(13, VideoType.Mobile, 0, false, AudioType.Aac, 0, AdaptiveType.None),
            new VideoInfo(17, VideoType.Mobile, 144, false, AudioType.Aac, 24, AdaptiveType.None),
            new VideoInfo(18, VideoType.Mp4, 360, false, AudioType.Aac, 96, AdaptiveType.None),
            new VideoInfo(22, VideoType.Mp4, 720, false, AudioType.Aac, 192, AdaptiveType.None),
            new VideoInfo(34, VideoType.Flash, 360, false, AudioType.Aac, 128, AdaptiveType.None),
            new VideoInfo(35, VideoType.Flash, 480, false, AudioType.Aac, 128, AdaptiveType.None),
            new VideoInfo(36, VideoType.Mobile, 240, false, AudioType.Aac, 38, AdaptiveType.None),
            new VideoInfo(37, VideoType.Mp4, 1080, false, AudioType.Aac, 192, AdaptiveType.None),
            new VideoInfo(38, VideoType.Mp4, 3072, false, AudioType.Aac, 192, AdaptiveType.None),
            new VideoInfo(43, VideoType.WebM, 360, false, AudioType.Vorbis, 128, AdaptiveType.None),
            new VideoInfo(44, VideoType.WebM, 480, false, AudioType.Vorbis, 128, AdaptiveType.None),
            new VideoInfo(45, VideoType.WebM, 720, false, AudioType.Vorbis, 192, AdaptiveType.None),
            new VideoInfo(46, VideoType.WebM, 1080, false, AudioType.Vorbis, 192, AdaptiveType.None),

            /* 3d */
            new VideoInfo(82, VideoType.Mp4, 360, true, AudioType.Aac, 96, AdaptiveType.None),
            new VideoInfo(83, VideoType.Mp4, 240, true, AudioType.Aac, 96, AdaptiveType.None),
            new VideoInfo(84, VideoType.Mp4, 720, true, AudioType.Aac, 152, AdaptiveType.None),
            new VideoInfo(85, VideoType.Mp4, 520, true, AudioType.Aac, 152, AdaptiveType.None),
            new VideoInfo(100, VideoType.WebM, 360, true, AudioType.Vorbis, 128, AdaptiveType.None),
            new VideoInfo(101, VideoType.WebM, 360, true, AudioType.Vorbis, 192, AdaptiveType.None),
            new VideoInfo(102, VideoType.WebM, 720, true, AudioType.Vorbis, 192, AdaptiveType.None),

            /* Adaptive (aka DASH) - Video */
            new VideoInfo(133, VideoType.Mp4, 240, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(134, VideoType.Mp4, 360, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(135, VideoType.Mp4, 480, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(136, VideoType.Mp4, 720, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(137, VideoType.Mp4, 1080, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(138, VideoType.Mp4, 2160, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(160, VideoType.Mp4, 144, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(242, VideoType.WebM, 240, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(243, VideoType.WebM, 360, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(244, VideoType.WebM, 480, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(247, VideoType.WebM, 720, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(248, VideoType.WebM, 1080, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(264, VideoType.Mp4, 1440, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(271, VideoType.WebM, 1440, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(272, VideoType.WebM, 2160, false, AudioType.Unknown, 0, AdaptiveType.Video),
            new VideoInfo(278, VideoType.WebM, 144, false, AudioType.Unknown, 0, AdaptiveType.Video),

            /* Adaptive (aka DASH) - Audio */
            new VideoInfo(139, VideoType.Mp4, 0, false, AudioType.Aac, 48, AdaptiveType.Audio),
            new VideoInfo(140, VideoType.Mp4, 0, false, AudioType.Aac, 128, AdaptiveType.Audio),
            new VideoInfo(141, VideoType.Mp4, 0, false, AudioType.Aac, 256, AdaptiveType.Audio),
            new VideoInfo(171, VideoType.WebM, 0, false, AudioType.Vorbis, 128, AdaptiveType.Audio),
            new VideoInfo(172, VideoType.WebM, 0, false, AudioType.Vorbis, 192, AdaptiveType.Audio)
        };

            internal VideoInfo(int formatCode)
                : this(formatCode, VideoType.Unknown, 0, false, AudioType.Unknown, 0, AdaptiveType.None)
            { }

            internal VideoInfo(VideoInfo info)
                : this(info.FormatCode, info.VideoType, info.Resolution, info.Is3D, info.AudioType, info.AudioBitrate, info.AdaptiveType)
            { }

            private VideoInfo(int formatCode, VideoType videoType, int resolution, bool is3D, AudioType audioType, int audioBitrate, AdaptiveType adaptiveType)
            {
                FormatCode = formatCode;
                VideoType = videoType;
                Resolution = resolution;
                Is3D = is3D;
                AudioType = audioType;
                AudioBitrate = audioBitrate;
                AdaptiveType = adaptiveType;
            }

            /// <summary>
            /// Gets an enum indicating whether the format is adaptive or not.
            /// </summary>
            /// <value>
            /// <c>AdaptiveType.Audio</c> or <c>AdaptiveType.Video</c> if the format is adaptive;
            /// otherwise, <c>AdaptiveType.None</c>.
            /// </value>
            public AdaptiveType AdaptiveType { get; private set; }

            /// <summary>
            /// The approximate audio bitrate in kbit/s.
            /// </summary>
            /// <value>The approximate audio bitrate in kbit/s, or 0 if the bitrate is unknown.</value>
            public int AudioBitrate { get; private set; }

            /// <summary>
            /// Gets the audio extension.
            /// </summary>
            /// <value>The audio extension, or <c>null</c> if the audio extension is unknown.</value>
            public string AudioExtension
            {
                get
                {
                    switch (AudioType)
                    {
                        case AudioType.Aac:
                            return ".aac";

                        case AudioType.Mp3:
                            return ".mp3";

                        case AudioType.Vorbis:
                            return ".ogg";
                        case AudioType.Unknown:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    return null;
                }
            }

            /// <summary>
            /// Gets the audio type (encoding).
            /// </summary>
            public AudioType AudioType { get; private set; }

            /// <summary>
            /// Gets a value indicating whether the audio of this video can be extracted by YoutubeExtractor.
            /// </summary>
            /// <value>
            /// <c>true</c> if the audio of this video can be extracted by YoutubeExtractor; otherwise, <c>false</c>.
            /// </value>
            public bool CanExtractAudio
            {
                get { return VideoType == VideoType.Flash; }
            }

            /// <summary>
            /// Gets the download URL.
            /// </summary>
            public string DownloadUrl { get; internal set; }

            /// <summary>
            /// Gets the format code, that is used by YouTube internally to differentiate between
            /// quality profiles.
            /// </summary>
            public int FormatCode { get; private set; }

            public bool Is3D { get; private set; }

            /// <summary>
            /// Gets a value indicating whether this video info requires a signature decryption before
            /// the download URL can be used.
            ///
            /// This can be achieved with the <see cref="DownloadUrlResolver.DecryptDownloadUrl"/>
            /// </summary>
            public bool RequiresDecryption { get; internal set; }

            /// <summary>
            /// Gets the resolution of the video.
            /// </summary>
            /// <value>The resolution of the video, or 0 if the resolution is unkown.</value>
            public int Resolution { get; private set; }

            /// <summary>
            /// Gets the video title.
            /// </summary>
            public string Title { get; internal set; }

            /// <summary>
            /// Gets the video extension.
            /// </summary>
            /// <value>The video extension, or <c>null</c> if the video extension is unknown.</value>
            public string VideoExtension
            {
                get
                {
                    switch (VideoType)
                    {
                        case VideoType.Mp4:
                            return ".mp4";

                        case VideoType.Mobile:
                            return ".3gp";

                        case VideoType.Flash:
                            return ".flv";

                        case VideoType.WebM:
                            return ".webm";
                        case VideoType.Unknown:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    return null;
                }
            }

            /// <summary>
            /// Gets the video type (container).
            /// </summary>
            public VideoType VideoType { get; private set; }

            /// <summary>
            /// We use this in the <see cref="DownloadUrlResolver.DecryptDownloadUrl" /> method to
            /// decrypt the signature
            /// </summary>
            /// <returns></returns>
            internal string HtmlPlayerVersion { get; set; }

            public override string ToString()
            {
                return string.Format("Full Title: {0}, Type: {1}, Resolution: {2}p", Title + VideoExtension, VideoType, Resolution);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// The exception that is thrown when the video is not available for viewing.
        /// This can happen when the uploader restricts the video to specific countries.
        /// </summary>
        [Serializable]
        public class VideoNotAvailableException : Exception
        {
            public VideoNotAvailableException()
            { }

            public VideoNotAvailableException(string message)
                : base(message)
            { }

            protected VideoNotAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        /// <summary>
        /// The video type. Also known as video container.
        /// </summary>
        public enum VideoType
        {
            /// <summary>
            /// Video for mobile devices (3GP).
            /// </summary>
            Mobile,

            Flash,
            Mp4,
            WebM,

            /// <summary>
            /// The video type is unknown. This can occur if YoutubeExtractor is not up-to-date.
            /// </summary>
            Unknown
        }

        /// <inheritdoc />
        /// <summary>
        /// <para>
        /// The exception that is thrown when the YouTube page could not be parsed.
        /// This happens, when YouTube changes the structure of their page.
        /// </para>
        /// Please report when this exception happens at www.github.com/flagbug/YoutubeExtractor/issues
        /// </summary>
        [Serializable]
        public class YoutubeParseException : Exception
        {
            public YoutubeParseException(string message, Exception innerException)
                : base(message, innerException)
            { }

            protected YoutubeParseException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        #endregion YouTube: Functions

        #endregion YouTube
    }
}
