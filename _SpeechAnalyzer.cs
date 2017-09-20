using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Threading;
using Un4seen.Bass;
using Un4seen.BassWasapi;

namespace iTunerManagerApp
{

    /// <summary>
    /// 
    /// </summary>
    public class SpeechAnalyzer
    {
        #region Fields

        /// <summary>
        /// The enable
        /// </summary>
        private bool _enable;               //enabled status
        /// <summary>
        /// The t
        /// </summary>
        private readonly DispatcherTimer _t;         //timer that refreshes the display
        /// <summary>
        /// The FFT
        /// </summary>
        public float[] Fft;               //buffer for fft data
        /// <summary>
        /// The process
        /// </summary>
        private readonly WASAPIPROC _process;        //callback function to obtain data
        /// <summary>
        /// The lastlevel
        /// </summary>
        private int _lastlevel;             //last output level
        /// <summary>
        /// The hanctr
        /// </summary>
        private int _hanctr;                //last output level counter
        /// <summary>
        /// The spectrumdata
        /// </summary>
        public List<byte> Spectrumdata;   //spectrum data buffer
        /// <summary>
        /// The devicelist
        /// </summary>
        private readonly ComboBox _devicelist;       //device list
        /// <summary>
        /// The initialized
        /// </summary>
        private bool _initialized;          //initialized flag
        /// <summary>
        /// The devindex
        /// </summary>
        private int _devindex;               //used device index
        /// <summary>
        /// The chart
        /// </summary>
        private readonly Chart _chart;

        /// <summary>
        /// The lines
        /// </summary>
        private const int Lines = 64; // number of spectrum lines

        #endregion Fields

        #region Constructor
        //ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAnalyzer"/> class.
        /// </summary>
        /// <param name="devicelist">The devicelist.</param>
        /// <param name="chart">The chart.</param>
        public SpeechAnalyzer(ComboBox devicelist, Chart chart)
        {
            Fft = new float[8192];
            _lastlevel = 0;
            _hanctr = 0;
            _t = new DispatcherTimer();
            _t.Tick += _t_Tick;
            _t.Interval = TimeSpan.FromMilliseconds(25); //40hz refresh rate//25
            _t.IsEnabled = false;
            _process = Process;
            Spectrumdata = new List<byte>();
            _chart = chart;
            _devicelist = devicelist;
            _initialized = false;

            chart.Series.Add("wave");
            chart.Series["wave"].ChartType = SeriesChartType.FastLine;
            chart.Series["wave"].ChartArea = "ChartArea1";

            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.Maximum = 255;
            chart.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart.ChartAreas["ChartArea1"].AxisX.Maximum = 64;
            chart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MajorTickMark.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisX.MajorTickMark.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Transparent;
            chart.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Transparent;
            chart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            for (int i = 0; i < chart.ChartAreas["ChartArea1"].AxisX.Maximum; i++)
            {
                chart.Series["wave"].Points.Add(0);
            }

            Init();
        }

        #endregion Constructor

        #region Methods

        // Serial port for arduino output

        // flag for display enable
        /// <summary>
        /// Gets or sets a value indicating whether [display enable].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [display enable]; otherwise, <c>false</c>.
        /// </value>
        public bool DisplayEnable { get; set; }

        //flag for enabling and disabling program functionality
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SpeechAnalyzer"/> is enable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enable; otherwise, <c>false</c>.
        /// </value>
        public bool Enable
        {
            get { return _enable; }
            set
            {
                _enable = value;
                if (value)
                {
                    if (!_initialized)
                    {
                        var array = ((string) _devicelist.Items[_devicelist.SelectedIndex]).Split(' ');
                        _devindex = Convert.ToInt32(array[0]);
                        bool result = BassWasapi.BASS_WASAPI_Init(_devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
                        if (!result)
                        {
                            var error = Bass.BASS_ErrorGetCode();
                            MessageBox.Show(error.ToString());
                        }
                        else
                        {
                            _initialized = true;
                            _devicelist.Enabled = false;
                        }
                    }
                    BassWasapi.BASS_WASAPI_Start();
                }
                else BassWasapi.BASS_WASAPI_Stop(true);
                Thread.Sleep(500);
                _t.IsEnabled = value;
            }
        }

        // initialization
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <exception cref="System.Exception">Init Error</exception>
        private void Init()
        {
            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    _devicelist.Items.Add(string.Format("{0} - {1}", i, device.name));
                }
            }
            _devicelist.SelectedIndex = 0;
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
            var result = Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            if (!result) throw new ArgumentException(@"Init Error");
        }

        //timer 
        /// <summary>
        /// Handles the Tick event of the _t control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void _t_Tick(object sender, EventArgs e)
        {
            int ret = BassWasapi.BASS_WASAPI_GetData(Fft, (int)BASSData.BASS_DATA_FFT8192);  //get ch.annel fft data
            if (ret < -1) return;
            int x;
            int b0 = 0;

            //computes the spectrum data, the code is taken from a bass_wasapi sample.
            for (x = 0; x < Lines; x++)
            {
                float peak = 0;
                int b1 = (int)Math.Pow(2, x * 10.0 / (Lines - 1));
                if (b1 > 1023) b1 = 1023;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < Fft[1 + b0]) peak = Fft[1 + b0];
                }
                var y = (int)(Math.Sqrt(peak) * 3 * 255 - 4);
                if (y > 255) y = 255;
                if (y < 0) y = 0;
                Spectrumdata.Add((byte)y);
                //Console.Write("{0, 3} ", y);
            }

            for (int i = 0; i < Spectrumdata.ToArray().Length; i++)
            {
                try
                {
                    _chart.Series["wave"].Points.Add(Spectrumdata[i]);
                }
                catch (Exception)
                {
                    Console.WriteLine(@"Exception adding points to spectrum");
                }
                try
                {
                    _chart.Series["wave"].Points.RemoveAt(0);
                }
                catch (Exception)
                {
                    Console.WriteLine(@"Exception removing points from spectrum");
                }

            }
            Spectrumdata.Clear();


            int level = BassWasapi.BASS_WASAPI_GetLevel();
            if (level == _lastlevel && level != 0) _hanctr++;
            _lastlevel = level;

            //Required, because some programs hang the output. If the output hangs for a 75ms
            //this piece of code re initializes the output so it doesn't make a gliched sound for long.
            if (_hanctr <= 3) return;
            _hanctr = 0;
            Free();
            Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            _initialized = false;
            Enable = true;
        }

        // WASAPI callback, required for continuous recording
        /// <summary>
        /// Processes the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="length">The length.</param>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        private static int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        //cleanup
        /// <summary>
        /// Frees this instance.
        /// </summary>
        public void Free()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }

        #endregion Methods
    }
}
