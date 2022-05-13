using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FadeTime
{
    internal static class Configuration
    {
        internal static ConfigFile _configFile;

        internal static string _configFilePath = Path.Combine(Environment.CurrentDirectory, @"Config.json");

        internal static bool ReadConfigFile()
        {
            try
            {
                if (!File.Exists(_configFilePath))
                {
                    if (!writeConfigFile(new ConfigFile
                    (
                        ipAddress: "127.0.0.1",
                        portSend: 9000,
                        sendCycleMilliseconds: 10000,
                        avatarParameter: "",
                        startTime: DateTimePicker.MinimumDateTime.AddHours(22),
                        endTime: DateTimePicker.MinimumDateTime.AddHours(6).AddDays(1),
                        resetAfterEndTime: true
                    )))
                        return false;
                }

                string configFileContent = File.ReadAllText(_configFilePath);
                ConfigFile configFile = JsonConvert.DeserializeObject<ConfigFile>(configFileContent);
                _configFile = configFile;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to read config file 'Config.json': {ex.Message}", "Fade Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static bool writeConfigFile(ConfigFile configFile)
        {
            try
            {
                string configFileContent = JsonConvert.SerializeObject(configFile);
                File.WriteAllText(_configFilePath, configFileContent);
                _configFile = configFile;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to write config file 'Config.json': {ex.Message}", "Fade Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void SetAvatarParameter(string avatarParameter)
        {
            _configFile.AvatarParameter = avatarParameter;
            writeConfigFile(_configFile);
        }

        public static void SetTimes(DateTime startTime, DateTime endTime)
        {
            DateTime _endTime = DateTimePicker.MinimumDateTime.AddHours(endTime.Hour).AddMinutes(endTime.Minute);
            if (_endTime < startTime)
            {
                _endTime = _endTime.AddDays(1);
            }

            _configFile.StartTime = startTime;
            _configFile.EndTime = endTime;
            writeConfigFile(_configFile);
        }

        public static void SetUpdateIntervalTime(int SendCycleMilliseconds)
        {
            _configFile.SendCycleMilliseconds = SendCycleMilliseconds;
            writeConfigFile(_configFile);
        }

        public static void SetResetAfterEndTime(bool reset)
        {
            _configFile.ResetAfterEndTime = reset;
            writeConfigFile(_configFile);
        }
    }

    [JsonObject]
    public class ConfigFile
    {
        public ConfigFile() { }

        public ConfigFile(string ipAddress, int portSend, int sendCycleMilliseconds, string avatarParameter, DateTime startTime, DateTime endTime, bool resetAfterEndTime)
        {
            this.IpAddress = ipAddress;
            this.PortSend = portSend;
            this.SendCycleMilliseconds = sendCycleMilliseconds < 500 ? 500 : sendCycleMilliseconds;
            this.AvatarParameter = avatarParameter;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ResetAfterEndTime = resetAfterEndTime;
        }

        private string _ipAddress;
        private int _portSend;
        private int _sendCycleMilliseconds;
        private string _avatarParameter;
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _resetAfterEndTime;

        public string IpAddress { get => _ipAddress; set => _ipAddress = value; }
        public int PortSend { get => _portSend; set => _portSend = value; }
        public int SendCycleMilliseconds { get => _sendCycleMilliseconds;
            set {
                _sendCycleMilliseconds = value < 500 ? 500 : value;
            }
        }
        public string AvatarParameter { get => _avatarParameter; set => _avatarParameter = value; }
        public DateTime StartTime { get => _startTime; set => _startTime = value; }
        public DateTime EndTime { get => _endTime; set => _endTime = value; }
        public bool ResetAfterEndTime { get => _resetAfterEndTime; set => _resetAfterEndTime = value; }
    }
}
