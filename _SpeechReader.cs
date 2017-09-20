using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace iTunerManagerApp
{
    /// <summary>
    /// Speech Module
    /// </summary>
    public class SpeechModule
    {
        #region Listener

        /// <summary>
        /// The listener
        /// </summary>
        public SpeechRecognitionEngine Listener;

        /// <summary>
        /// Speeches the listener initialize.
        /// </summary>
        public void SpeechListenerInit()
        {
            Listener = new SpeechRecognitionEngine(new CultureInfo("en-GB"));//SpeechRecognizer();
        }

        /// <summary>
        /// Speeches the start listening.
        /// </summary>
        public void SpeechStartListening()
        {
            SpeechListenerInit();
            var simpleReply = SimpleReply();

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(simpleReply);

            Grammar g = new Grammar(gb);
            Listener.LoadGrammar(g);

            Listener.SetInputToDefaultAudioDevice();
            Listener.RecognizeAsync(RecognizeMode.Multiple);
            Listener.SpeechRecognized += listener_SpeechRecognised;
        }

        /// <summary>
        /// Simples the reply.
        /// </summary>
        /// <returns></returns>
        private static Choices SimpleReply()
        {
            Choices simpleReply = new Choices();
            SpeechInputs(simpleReply);
            return simpleReply;
        }

        /// <summary>
        /// Speeches the stop listening.
        /// </summary>
        public void SpeechStopListening()
        {
            //if (Reader != null)
            //{
            //    Reader.Dispose();
            //}
            if (Listener == null) return;
            Listener.Dispose();
            Listener = null;
        }

        /// <summary>
        /// Handles the SpeechRecognised event of the listener control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SpeechRecognizedEventArgs" /> instance containing the event data.</param>
        public void listener_SpeechRecognised(object sender, SpeechRecognizedEventArgs e)
        {
            SpeechOutputs(e);
        }
        
        #endregion Listener

        #region Speaking

        /// <summary>
        /// The reader
        /// </summary>
        public SpeechSynthesizer Reader;// = new SpeechSynthesizer();

        /// <summary>
        /// The reader gender
        /// </summary>
        public VoiceGender ReaderGender = VoiceGender.Male;

        /// <summary>
        /// The vol changed
        /// </summary>
        public bool VolChanged;

        /// <summary>
        /// Speeches the reader initialize.
        /// </summary>
        public void SpeechReaderInit()
        {
            Reader = new SpeechSynthesizer();
        }

        /// <summary>
        /// Speaks the text.
        /// </summary>
        /// <param name="speakThis">The speak this.</param>
        public void SpeechReaderSpeak(string speakThis)
        {
            const string informUser = @"Speaker Volume changed Automatically!";
            SpeechStopListening();
            SpeechReaderInit();
            if (VolChanged != true)
            {
                try
                {
                    double currVol = VolumeUtilities.GetMasterVolume();


                    while (currVol < 0.1)
                    {
                        VolumeUtilities.VolUp();
                        currVol = currVol + 0.01;
                    }
                }
                catch (Exception) { Console.WriteLine(@"Sound is Throwing an unknown error"); }
            }
            Reader.SelectVoiceByHints(ReaderGender);
            if (VolChanged != true)
            {
                Thread.Sleep(500);
                Reader.Speak(informUser);
                VolChanged = true;
            }
            Reader.SpeakAsync(speakThis);
            Reader.SpeakCompleted += reader_SpeakCompleted;
        }

        /// <summary>
        /// Handles the SpeakCompleted event of the reader control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Speech.Synthesis.SpeakCompletedEventArgs" /> instance containing the event data.</param>
        private void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            //listen for a reply
            SpeechStartListening();
        }

        /// <summary>
        /// Pauses the text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public void SpeechReaderPause(object sender, EventArgs e)
        {
            if (Reader == null) return;
            if (Reader.State == SynthesizerState.Speaking)
            {
                Reader.Pause();
            }
        }

        /// <summary>
        /// Resumes the text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public void SpeechReaderResume(object sender, EventArgs e)
        {
            if (Reader == null) return;
            if (Reader.State == SynthesizerState.Paused)
            {
                Reader.Resume();
            }
        }

        /// <summary>
        /// Stops the text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public void SpeechReaderStop(object sender, EventArgs e)
        {
            if (Reader != null)
            {
                Reader.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class VolumeUtilities
        {
            /// <summary>
            /// Gets the master volume.
            /// </summary>
            /// <returns></returns>
            public static float GetMasterVolume()
            {
                // get the speakers (1st render + multimedia) device
                // ReSharper disable once SuspiciousTypeConversion.Global
                IMmDeviceEnumerator deviceEnumerator = (IMmDeviceEnumerator) new MMDeviceEnumerator();
                IMmDevice speakers;
                const int eRender = 0;
                const int eMultimedia = 1;
                deviceEnumerator.GetDefaultAudioEndpoint(eRender, eMultimedia, out speakers);

                object o;
                speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out o);
                IAudioEndpointVolume aepv = (IAudioEndpointVolume)o;
                float volume = aepv.GetMasterVolumeLevelScalar();
                Marshal.ReleaseComObject(aepv);
                Marshal.ReleaseComObject(speakers);
                Marshal.ReleaseComObject(deviceEnumerator);
                return volume;
            }

            /// <summary>
            /// 
            /// </summary>
            [ComImport]
            [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
            private class MMDeviceEnumerator
            {
            }

            /// <summary>
            /// 
            /// </summary>
            [Guid("5CDF2C82-841E-4546-9722-0CF74078229A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
            private interface IAudioEndpointVolume
            {
                /// <summary>
                /// VTBLs the gap1 6.
                /// </summary>
                void _VtblGap1_6();
                /// <summary>
                /// Gets the master volume level scalar.
                /// </summary>
                /// <returns></returns>
                float GetMasterVolumeLevelScalar();
            }

            /// <summary>
            /// 
            /// </summary>
            [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
            private interface IMmDeviceEnumerator
            {
                /// <summary>
                /// VTBLs the gap1 1.
                /// </summary>
                void _VtblGap1_1();

                /// <summary>
                /// Gets the default audio endpoint.
                /// </summary>
                /// <param name="dataFlow">The data flow.</param>
                /// <param name="role">The role.</param>
                /// <param name="ppDevice">The pp device.</param>
                /// <returns></returns>
                [PreserveSig]
                int GetDefaultAudioEndpoint(int dataFlow, int role, out IMmDevice ppDevice);
            }

            /// <summary>
            /// 
            /// </summary>
            [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
            private interface IMmDevice
            {
                /// <summary>
                /// Activates the specified iid.
                /// </summary>
                /// <param name="iid">The iid.</param>
                /// <param name="dwClsCtx">The dw CLS CTX.</param>
                /// <param name="pActivationParams">The p activation parameters.</param>
                /// <param name="ppInterface">The pp interface.</param>
                /// <returns></returns>
                [PreserveSig]
                int Activate([MarshalAs(UnmanagedType.LPStruct)] Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
            }

            /// <summary>
            /// The appcommand volume mute
            /// </summary>
            private const int AppcommandVolumeMute = 0x80000;
            /// <summary>
            /// The appcommand volume up
            /// </summary>
            private const int AppcommandVolumeUp = 0xA0000;
            /// <summary>
            /// The appcommand volume down
            /// </summary>
            private const int AppcommandVolumeDown = 0x90000;
            /// <summary>
            /// The wm appcommand
            /// </summary>
            private const int WmAppcommand = 0x319;

            /// <summary>
            /// Sends the message w.
            /// </summary>
            /// <param name="hWnd">The h WND.</param>
            /// <param name="msg">The MSG.</param>
            /// <param name="wParam">The w parameter.</param>
            /// <param name="lParam">The l parameter.</param>
            /// <returns></returns>
            [DllImport("user32.dll")]
            public static extern IntPtr SendMessageW(IntPtr hWnd, int msg,
                IntPtr wParam, IntPtr lParam);

            private static readonly Form MemoryForm = new Form();
            private static readonly IntPtr FormHandle = MemoryForm.Handle;
            public static IntPtr WinHandle = FormHandle;

            /// <summary>
            /// Mutes this instance.
            /// </summary>
            public static void Mute()
            {
                SendMessageW(WinHandle, WmAppcommand, WinHandle,(IntPtr)AppcommandVolumeMute);
            }

            /// <summary>
            /// Vols down.
            /// </summary>
            public static void VolDown()
            {
                SendMessageW(WinHandle, WmAppcommand,WinHandle,(IntPtr)AppcommandVolumeDown);
            }

            /// <summary>
            /// Vols up.
            /// </summary>
            public static void VolUp()
            {
                SendMessageW(WinHandle, WmAppcommand, WinHandle,(IntPtr)AppcommandVolumeUp);
            }
        }

        #endregion Speaking

        #region Speech: Inputs/Outputs

        /// <summary>
        /// Speeches the inputs.
        /// </summary>
        /// <param name="simpleReply">The simple reply.</param>
        private static void SpeechInputs(Choices simpleReply)
        {
            //Change to Male Voice
            simpleReply.Add("Hello Father");
            //Change to Female Voice
            simpleReply.Add("Hello Mother");
            //Bot Response by Name
            simpleReply.Add("Who am i speaking with?");
            //List of Directives to Complete
            simpleReply.Add("List Directives");
            //Negative Response to Initial StartUp
            simpleReply.Add("that's rude");
            //Positive Response to Initial Startup
            simpleReply.Add("Thank You");
            //Close the Application
            simpleReply.Add("Shutdown Application");
            //Stop Talking
            simpleReply.Add("Stop Talking");
            //Pause Talking
            simpleReply.Add("Pause Talking");
            //Continue talking
            simpleReply.Add("Continue talking");
            //Record Parameters
            simpleReply.Add("Record Mode");            
            simpleReply.Add("Record Process");
            simpleReply.Add("Save Process");
        }

        /// <summary>
        /// Speeches the outputs.
        /// </summary>
        /// <param name="e">The <see cref="SpeechRecognizedEventArgs"/> instance containing the event data.</param>
        private void SpeechOutputs(RecognitionEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Hello Father":
                    if (Reader.Voice.Gender == VoiceGender.Female)
                    {
                        ReaderGender = VoiceGender.Male;
                        SpeechReaderSpeak("Cheers Mother! Hello Sir, I hope Mother was not too much trouble!");
                        break;
                    }
                    SpeechReaderSpeak("Hello Sir, how can i be of Assistance!");
                    break;
                case "Hello Mother":
                    if (Reader.Voice.Gender == VoiceGender.Male)
                    {
                        ReaderGender = VoiceGender.Female;
                        SpeechReaderSpeak("Goodbye Father! Hello Sir, how can i be of Assistance!");
                        break;
                    }
                    SpeechReaderSpeak("How can i be of Assistance Sir!");
                    break;
                case "Who am i speaking with?":
                    if (Reader.Voice.Gender == VoiceGender.Male)
                    {
                        SpeechReaderSpeak("Father Sir, at your Service!");
                        break;
                    }
                    else
                    {
                        SpeechReaderSpeak("Mother Sir, your wishes are limited to my parameters!");
                        break;
                    }
                case "List Directives":
                    SpeechReaderSpeak("Directive One: Create my Intelligence Module,Directive Two: Create my Name, Mood, Humour Percentage, Security Privileges, Monitoring Settings, Grammar Configuration and Automated Procedures!. End of Directives. Thank You!");
                    break;
                case "that's rude":
                    SpeechReaderSpeak("Should i turn this setting off?");
                    break;
                case "Thank You":
                    SpeechReaderSpeak("Im always here to Assist Sir!");
                    break;
                case "Shutdown Application":
                    SpeechReaderSpeak("GoodBye Sir!");
                    Thread.Sleep(500); 
                    SpeechExecutions("Exit");
                    break;
                case "Stop Talking":
                    SpeechReaderStop(Reader,e);
                    break;
                case "Pause Talking":
                    SpeechReaderPause(Reader,e);
                    break;
                case "Continue Talking":
                    SpeechReaderResume(Reader,e);
                    break;
                case "Record Mode":
                    SpeechReaderSpeak("Record Mode Ready");
                    SpeechExecutions("NewProcess");
                    break;
                case "Record Process":
                    SpeechReaderSpeak("Repeating Recorded Process" + RecProcess.Replace("Record Process", ""));
                    SpeechExecutions("NewProcessFunction");
                    break;
                case "Save Process":
                    SpeechReaderSpeak("Repeating Recorded Function" + RecProcessFunction.Replace("Save Process", ""));
                    SpeechExecutions("SaveProcess");
                    break;
                default:
                    Console.WriteLine(@"No Speech Recognised");
                    break;
            }
        }

        /// <summary>
        /// The record process
        /// </summary>
        public string RecProcess;

        /// <summary>
        /// The record process function
        /// </summary>
        public string RecProcessFunction;

        /// <summary>
        /// The new process
        /// </summary>
        public SpeechSynthesizer NewProcess;

        /// <summary>
        /// Speeches the executions.
        /// </summary>
        /// <param name="type">The type.</param>
        public void SpeechExecutions(string type)
        {
            switch (type)
            {
                case "Exit":
                    Application.Exit();
                    break;
                case "NewProcess":
                    NewProcess = new SpeechSynthesizer();
                    NewProcess.SpeakProgress += (sender, args) => RecProcess += args.Text;
                    break;
                case "NewProcessFunction":
                    NewProcess = new SpeechSynthesizer();
                    NewProcess.SpeakProgress += (sender, args) => RecProcessFunction += args.Text;
                    break;
                case "SaveProcess":
                    SaveSpeechSettings();
                    break;
                default:
                    Console.WriteLine(@"No Process Defined");
                    break;
            }
        }

        #endregion Speech: Inputs/Outputs

        #region Settings

        /// <summary>
        /// Saves the speech settings.
        /// </summary>
        public void SaveSpeechSettings()
        {
            SpeechSettings settings = SpeechSettings.Load();

            settings.Process = RecProcess;
            settings.Function = RecProcessFunction;

            string appPath = Application.StartupPath;
            string settingsPath = appPath + "\\SpeechSettings.json";

            settings.Save(settingsPath);
        }

        /// <inheritdoc />
        /// <summary>
        /// Speech Settings Class
        /// </summary>
        /// <seealso cref="T:iTunerManagerApp.SpeechModule.SpeechSettings" />
        public class SpeechSettings : SpeechSettingsSerializer<SpeechSettings>
        {
            /// <summary>
            /// My function
            /// </summary>
            public string Process = "The Function";
            /// <summary>
            /// My function value
            /// </summary>
            public string Function = "The Function Name";
        }

        /// <summary>
        /// Speech Settings Serializer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class SpeechSettingsSerializer<T> where T : new()
        {
            /// <summary>
            /// The default filename
            /// </summary>
            private const string DefaultFilename = "SpeechSettings.json";
            /// <summary>
            /// Saves the specified file name.
            /// </summary>
            /// <param name="fileName">Name of the file.</param>
            public void Save(string fileName = DefaultFilename)
            {
                File.WriteAllText(fileName, new JavaScriptSerializer().Serialize(this));
            }

            /// <summary>
            /// Saves the specified p settings.
            /// </summary>
            /// <param name="pSettings">The p settings.</param>
            /// <param name="fileName">Name of the file.</param>
            public static void Save(T pSettings, string fileName = DefaultFilename)
            {
                File.WriteAllText(fileName, new JavaScriptSerializer().Serialize(pSettings));
            }

            /// <summary>
            /// Loads the specified file name.
            /// </summary>
            /// <param name="fileName">Name of the file.</param>
            /// <returns></returns>
            public static T Load(string fileName = DefaultFilename)
            {
                T t = new T();
                if (File.Exists(fileName))
                    t = new JavaScriptSerializer().Deserialize<T>(File.ReadAllText(fileName));
                return t;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public class BotResponsibilities
        {
            //Bot specific
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }
            /// <summary>
            /// Gets or sets the role.
            /// </summary>
            /// <value>
            /// The role.
            /// </value>
            public string Role { get; set; }
            //Save and Retrieve Data Logs (initially Text Repsonse but will Save Voice Logs
            /// <summary>
            /// Gets or sets the data log.
            /// </summary>
            /// <value>
            /// The data log.
            /// </value>
            public Tuple<int,DateTime,string> DataLog { get; set; }
            //Command functions for Bot to Perform
            /// <summary>
            /// Gets or sets the function list.
            /// </summary>
            /// <value>
            /// The function list.
            /// </value>
            public Tuple<int,DateTime,string> FunctionList { get; set; }
        }

        public class AppClickEvents
        {
            public List<string> AddEvents()
            {
                var eventList = new List<string> {"picDock_Click"};

                return eventList;
            }
            
            public void CallEvent(string eventName)
            {

            }
        }

        #endregion Settings
    }
}
