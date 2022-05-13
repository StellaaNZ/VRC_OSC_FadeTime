
using System;

namespace FadeTime
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeParameter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.timer10s = new System.Windows.Forms.Timer(this.components);
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.lblFakeTime = new System.Windows.Forms.Label();
            this.dtpDebugTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nupUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.chkResetAfterEnd = new System.Windows.Forms.CheckBox();
            this.btnApplyInterval = new System.Windows.Forms.Button();
            this.btnResetValue = new System.Windows.Forms.Button();
            this.lstDebugBox = new System.Windows.Forms.TextBox();
            this.chkDebugTime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupUpdateInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "h:mm tt";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(50, 154);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(94, 23);
            this.dtpStartTime.TabIndex = 0;
            this.dtpStartTime.Value = new System.DateTime(1753, 1, 1, 22, 0, 0, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "h:mm tt";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(174, 154);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(94, 23);
            this.dtpEndTime.TabIndex = 2;
            this.dtpEndTime.Value = new System.DateTime(1753, 1, 1, 6, 0, 0, 0);
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(50, 68);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(218, 23);
            this.txtParameter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parameter Name";
            // 
            // btnChangeParameter
            // 
            this.btnChangeParameter.Location = new System.Drawing.Point(50, 97);
            this.btnChangeParameter.Name = "btnChangeParameter";
            this.btnChangeParameter.Size = new System.Drawing.Size(218, 23);
            this.btnChangeParameter.TabIndex = 6;
            this.btnChangeParameter.Text = "Change Parameter";
            this.btnChangeParameter.UseVisualStyleBackColor = true;
            this.btnChangeParameter.Click += new System.EventHandler(this.btnChangeParameter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Time:";
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Location = new System.Drawing.Point(214, 197);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 15);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "8:01 pm";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblValue
            // 
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValue.Location = new System.Drawing.Point(214, 216);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(54, 15);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "0.00";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer10s
            // 
            this.timer10s.Interval = 10000;
            this.timer10s.Tick += new System.EventHandler(this.timer10s_Tick);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(49, 362);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(61, 19);
            this.chkDebug.TabIndex = 11;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            this.chkDebug.CheckedChanged += new System.EventHandler(this.chkDebug_CheckedChanged);
            // 
            // lblFakeTime
            // 
            this.lblFakeTime.AutoSize = true;
            this.lblFakeTime.Location = new System.Drawing.Point(49, 384);
            this.lblFakeTime.Name = "lblFakeTime";
            this.lblFakeTime.Size = new System.Drawing.Size(103, 15);
            this.lblFakeTime.TabIndex = 13;
            this.lblFakeTime.Text = "Fake Current Time";
            // 
            // dtpDebugTime
            // 
            this.dtpDebugTime.CustomFormat = "h:mm tt";
            this.dtpDebugTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebugTime.Location = new System.Drawing.Point(49, 402);
            this.dtpDebugTime.Name = "dtpDebugTime";
            this.dtpDebugTime.ShowUpDown = true;
            this.dtpDebugTime.Size = new System.Drawing.Size(94, 23);
            this.dtpDebugTime.TabIndex = 12;
            this.dtpDebugTime.Value = new System.DateTime(1753, 1, 1, 22, 0, 0, 0);
            this.dtpDebugTime.ValueChanged += new System.EventHandler(this.dtpDebugTime_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Update Interval (s)";
            // 
            // nupUpdateInterval
            // 
            this.nupUpdateInterval.DecimalPlaces = 2;
            this.nupUpdateInterval.Location = new System.Drawing.Point(210, 252);
            this.nupUpdateInterval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupUpdateInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nupUpdateInterval.Name = "nupUpdateInterval";
            this.nupUpdateInterval.Size = new System.Drawing.Size(58, 23);
            this.nupUpdateInterval.TabIndex = 14;
            this.nupUpdateInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chkResetAfterEnd
            // 
            this.chkResetAfterEnd.AutoSize = true;
            this.chkResetAfterEnd.Location = new System.Drawing.Point(50, 315);
            this.chkResetAfterEnd.Name = "chkResetAfterEnd";
            this.chkResetAfterEnd.Size = new System.Drawing.Size(133, 19);
            this.chkResetAfterEnd.TabIndex = 15;
            this.chkResetAfterEnd.Text = "Reset after End Time";
            this.chkResetAfterEnd.UseVisualStyleBackColor = true;
            this.chkResetAfterEnd.CheckedChanged += new System.EventHandler(this.chkResetAfterEnd_CheckedChanged);
            // 
            // btnApplyInterval
            // 
            this.btnApplyInterval.Location = new System.Drawing.Point(210, 281);
            this.btnApplyInterval.Name = "btnApplyInterval";
            this.btnApplyInterval.Size = new System.Drawing.Size(59, 23);
            this.btnApplyInterval.TabIndex = 17;
            this.btnApplyInterval.Text = "Apply";
            this.btnApplyInterval.UseVisualStyleBackColor = true;
            this.btnApplyInterval.Click += new System.EventHandler(this.btnApplyInterval_Click);
            // 
            // btnResetValue
            // 
            this.btnResetValue.Enabled = false;
            this.btnResetValue.Location = new System.Drawing.Point(210, 312);
            this.btnResetValue.Name = "btnResetValue";
            this.btnResetValue.Size = new System.Drawing.Size(59, 23);
            this.btnResetValue.TabIndex = 18;
            this.btnResetValue.Text = "Reset";
            this.btnResetValue.UseVisualStyleBackColor = true;
            this.btnResetValue.Click += new System.EventHandler(this.btnResetValue_Click);
            // 
            // lstDebugBox
            // 
            this.lstDebugBox.BackColor = System.Drawing.Color.Black;
            this.lstDebugBox.ForeColor = System.Drawing.Color.Lime;
            this.lstDebugBox.Location = new System.Drawing.Point(49, 432);
            this.lstDebugBox.Multiline = true;
            this.lstDebugBox.Name = "lstDebugBox";
            this.lstDebugBox.ReadOnly = true;
            this.lstDebugBox.Size = new System.Drawing.Size(219, 79);
            this.lstDebugBox.TabIndex = 19;
            // 
            // chkDebugTime
            // 
            this.chkDebugTime.AutoSize = true;
            this.chkDebugTime.Location = new System.Drawing.Point(149, 407);
            this.chkDebugTime.Name = "chkDebugTime";
            this.chkDebugTime.Size = new System.Drawing.Size(112, 19);
            this.chkDebugTime.TabIndex = 15;
            this.chkDebugTime.Text = "Use Debug Time";
            this.chkDebugTime.UseVisualStyleBackColor = true;
            this.chkDebugTime.CheckedChanged += new System.EventHandler(this.chkDebugTime_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 540);
            this.Controls.Add(this.lstDebugBox);
            this.Controls.Add(this.btnResetValue);
            this.Controls.Add(this.btnApplyInterval);
            this.Controls.Add(this.chkDebugTime);
            this.Controls.Add(this.chkResetAfterEnd);
            this.Controls.Add(this.nupUpdateInterval);
            this.Controls.Add(this.lblFakeTime);
            this.Controls.Add(this.dtpDebugTime);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChangeParameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartTime);
            this.MinimumSize = new System.Drawing.Size(339, 456);
            this.Name = "MainForm";
            this.Text = "Fade Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nupUpdateInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeParameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Timer timer10s;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label lblFakeTime;
        private System.Windows.Forms.DateTimePicker dtpDebugTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupUpdateInterval;
        private System.Windows.Forms.CheckBox chkResetAfterEnd;
        private System.Windows.Forms.Button btnApplyInterval;
        private System.Windows.Forms.Button btnResetValue;
        private System.Windows.Forms.TextBox lstDebugBox;
        private System.Windows.Forms.CheckBox chkDebugTime;
    }
}

