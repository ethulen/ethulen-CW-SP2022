using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace Alarm501
{
    public partial class Alarm501 : Form
    {
        private System.Windows.Forms.Timer holder;
        public Alarm501()
        {
            InitializeComponent();

            if (File.Exists("AlarmData.txt"))
            {
                StreamReader reader = new StreamReader("AlarmData.txt");
                // Reads and displays lines from the file until the end of
                // the file is reached.
                while (!reader.EndOfStream)
                {
                    string[] alarmData = reader.ReadLine().Split(' ');
                    bool running = (alarmData[2] == "True");
                    DateTime d = Convert.ToDateTime(alarmData[0]);
                    alarms.Add(new Alarm(running,d));
                }
                reader.Close();

                // Create a timer with a 1-minute interval
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                // Define the event handler
                timer.Elapsed += this.CheckAlarms;
                // Synchronize the timer with the text box
                timer.SynchronizingObject = this;
                // Start the timer
                timer.AutoReset = true;
                timer.Start();
                if (alarms.Count >= 4)
                    addButton.Enabled = false;
            }
            alarmList.DataSource = alarms;

        }
        private void HolderTick(object sender, EventArgs e)
        {
            status.Text = "Alarm went off";
            holder.Enabled = false;
        }

        private void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            foreach (Alarm a in alarms)
            {
                if(a.OnOrOff == true && TimeSpan.Compare(a.Time.TimeOfDay, current.TimeOfDay) == 0)
                {
                    status.Text = "Alarm went off";
                    snoozeButton.Enabled = true;
                    stopButton.Enabled = true;
                }
            }
        }

        public BindingList<Alarm> alarms = new BindingList<Alarm>();
        private void addButton_Click(object sender, EventArgs e)
        {
            newAlarm alarmForm = new newAlarm(alarms, null);
            alarmForm.Show();
            editButton.Enabled = true;
            if (alarms.Count >= 4)
                addButton.Enabled = false;
            status.Text = "Running";
            alarmForm.FormClosed += AlarmForm_FormClosed;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            newAlarm alarmForm = new newAlarm(alarms, alarms[alarmList.SelectedIndex]);
            alarmForm.Show();
            alarmForm.FormClosed += AlarmForm_FormClosed;
        }

        private void AlarmForm_FormClosed(object sender, FormClosedEventArgs e)
        { 
            StringBuilder sb = new StringBuilder();
            foreach(Alarm a in alarms)
            {
                sb.Append(a.ToString() + "\n");
            }
            File.WriteAllText("AlarmData.txt", sb.ToString());
        }

        private void snoozeButton_Click(object sender, EventArgs e)
        {
            newAlarm alarm = new newAlarm(alarms);
            alarm.onOrOff.Checked = false;
            status.Text = "Snoozing";
            Controls.Add(status);

            holder = new System.Windows.Forms.Timer { Interval = 3000 };
            holder.Tick += HolderTick;
            holder.Enabled = true;
            alarm.onOrOff.Checked = true;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            newAlarm alarm = new newAlarm(alarms);
            alarm.onOrOff.Checked = false;
            alarmList.SelectedItem = alarm.AlarmSet.Text;
            status.Text = "Stopped";
        }

        private void alarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(alarms.Count > 0)
                editButton.Enabled = true;
        }
    }
}
