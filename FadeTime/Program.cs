using SharpOSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FadeTime
{
    static class Program
    {
        private const string AVATAR_PARAMETER_PREFIX = "/avatar/parameters/";

        public static bool DebugMode = false;
        private static bool passedEnd = false;

        private static EventHandler _applicationIdleHandler;
        private static Thread _sendingThread;
        private static UDPSender _sender;
        private static OscMessage _messageParameter;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Configuration.ReadConfigFile())
            {
                Application.Exit();
                return;
            }
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                _applicationIdleHandler = delegate
                {
                    SetupSender();

                    Application.Idle -= _applicationIdleHandler;
                };

                Application.Idle += _applicationIdleHandler;

                Application.ApplicationExit += delegate
                {
                    _sender.Close();
                    _sendingThread.Interrupt();
                    _sendingThread.Join();
                };

                Application.Run(MainForm.Instance);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fade Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.Instance.AddDebugMessage(ex.Message);
            }
        }

        public static float CalcValue()
        {
            DateTime now;
            if (DebugMode)
            {
                now = MainForm.Instance.DebugTime;
            }
            else
            {
                now = DateTimePicker.MinimumDateTime.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
            }

            DateTime tempEndTime = MainForm.Instance.EndTime;

            if (tempEndTime.Day > 1)
            {
                tempEndTime = tempEndTime.AddDays(-1);
                if (now <= tempEndTime)
                    now = now.AddDays(1);
            }

            if (now == MainForm.Instance.EndTime && !MainForm.Instance.ResetAfterEnd)
            {
                MainForm.Instance.EnableResetButton();
                passedEnd = true;
                return 1;
            }

            TimeSpan duration = MainForm.Instance.EndTime - MainForm.Instance.StartTime;
            TimeSpan startTillNow = now - Configuration._configFile.StartTime;

            double value = startTillNow.TotalSeconds / duration.TotalSeconds;
            if (passedEnd)
            {
                return 1;
            }
            else if (value <= 0 || value > 1)
                return 0;
            else
                return (float)value;
            //return (float)value;
        }

        public static void ResetPassedEnd()
        {
            passedEnd = false;
        }

        private static void SetupSender()
        {
            _sender = new UDPSender(Configuration._configFile.IpAddress, Configuration._configFile.PortSend);
            _sendingThread = new Thread(new ThreadStart(SendingLoop));
            _sendingThread.Start();
        }

        static void SendingLoop()
        {
            try
            {
                while (true)
                {
                    float value = CalcValue();
                    _messageParameter = new OscMessage(AVATAR_PARAMETER_PREFIX + Configuration._configFile.AvatarParameter, value);
                    _sender.Send(_messageParameter);
                    MainForm.Instance.AddDebugMessage($"Send parameter value of: {value}");

                    Thread.Sleep(Configuration._configFile.SendCycleMilliseconds);
                }
            }
            catch (Exception ex)
            {
                MainForm.Instance.AddDebugMessage(ex.Message);
            }
            finally
            {
                _sender.Close();
            }
        }
    }
}
