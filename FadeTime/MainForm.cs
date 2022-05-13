using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FadeTime
{
    public sealed partial class MainForm : Form
    {
        private static MainForm _instance = new MainForm();
        public static MainForm Instance => _instance;

        private Size smallSize = new Size(339, 456);
        private Size largeSize = new Size(339, 596);

        public DateTime DebugTime = DateTimePicker.MinimumDateTime;
        public DateTime StartTime = DateTimePicker.MinimumDateTime;
        public DateTime EndTime = DateTimePicker.MinimumDateTime;
        public bool ResetAfterEnd = false;

        private MainForm()
        {
            InitializeComponent();

            txtParameter.Text = Configuration._configFile.AvatarParameter;
            lblTime.Text = DateTime.Now.ToShortTimeString();

            timer10s.Enabled = true;
            timer10s.Interval = Configuration._configFile.SendCycleMilliseconds;

            nupUpdateInterval.Value = Configuration._configFile.SendCycleMilliseconds / 1000;
            chkResetAfterEnd.Checked = Configuration._configFile.ResetAfterEndTime;

            dtpStartTime.Value = Configuration._configFile.StartTime;
            dtpEndTime.Value = Configuration._configFile.EndTime;
            dtpDebugTime.Value = DateTimePicker.MinimumDateTime;

            StartTime = Configuration._configFile.StartTime;
            EndTime = Configuration._configFile.EndTime;

            changeToSmallSize();
        }

        private void changeToSmallSize()
        {
            this.MinimumSize = smallSize;
            this.Size = smallSize;
            this.MaximumSize = smallSize;

            dtpDebugTime.Visible = false;
            lblFakeTime.Visible = false;
            lstDebugBox.Visible = false;
            chkDebugTime.Visible = false;
        }

        private void changeToLargeSize()
        {
            this.MaximumSize = largeSize;
            this.Size = largeSize;
            this.MinimumSize = largeSize;

            dtpDebugTime.Visible = true;
            lblFakeTime.Visible = true;
            lstDebugBox.Visible = true;
            chkDebugTime.Visible = true;
        }

        private void timer10s_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            if (Configuration._configFile.StartTime != StartTime || Configuration._configFile.EndTime != EndTime)
            {
                Configuration.SetTimes(StartTime, EndTime);

                AddDebugMessage($"Times Updated");
            }
            lblValue.Text = Program.CalcValue().ToString();
        }

        private void chkDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDebug.Checked)
            {
                changeToLargeSize();
            } else
            {
                changeToSmallSize();
            }
        }

        private void dtpDebugTime_ValueChanged(object sender, EventArgs e)
        {
            DebugTime = DateTimePicker.MinimumDateTime.AddHours(dtpDebugTime.Value.Hour).AddMinutes(dtpDebugTime.Value.Minute);
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            StartTime = DateTimePicker.MinimumDateTime.AddHours(dtpStartTime.Value.Hour).AddMinutes(dtpStartTime.Value.Minute);
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            EndTime = DateTimePicker.MinimumDateTime.AddHours(dtpEndTime.Value.Hour).AddMinutes(dtpEndTime.Value.Minute);
            if (EndTime < StartTime)
                EndTime = EndTime.AddDays(1);
        }

        private void btnChangeParameter_Click(object sender, EventArgs e)
        {
            Configuration.SetAvatarParameter(txtParameter.Text);

            AddDebugMessage($"Avatar Parameter Changed to: {txtParameter.Text}");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnApplyInterval_Click(object sender, EventArgs e)
        {
            int timeInMilli = Convert.ToInt32(nupUpdateInterval.Value * 1000);
            Configuration.SetUpdateIntervalTime(timeInMilli);
            timer10s.Interval = timeInMilli;
            AddDebugMessage($"Interval Time Changed to: {timeInMilli}");
        }

        public void AddDebugMessage(string message)
        {
            try
            {
                if (InvokeRequired)
                {
                    lstDebugBox.Invoke(new Action<string>(AddDebugMessage), new object[] { message });
                    return;
                }

                lstDebugBox.AppendText(Environment.NewLine + message);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fade Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnableResetButton()
        {
            btnResetValue.Enabled = true;
        }

        private void btnResetValue_Click(object sender, EventArgs e)
        {
            Program.ResetPassedEnd();
            btnResetValue.Enabled = false;

            AddDebugMessage($"Value Reset");
        }

        private void chkResetAfterEnd_CheckedChanged(object sender, EventArgs e)
        {
            ResetAfterEnd = chkResetAfterEnd.Checked;
            Configuration.SetResetAfterEndTime(ResetAfterEnd);
        }

        private void chkDebugTime_CheckedChanged(object sender, EventArgs e)
        {
            Program.DebugMode = chkDebugTime.Checked;
        }
    }
}
