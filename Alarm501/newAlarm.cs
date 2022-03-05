using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class newAlarm : Form
    {
        public BindingList<Alarm> _list;
        public Alarm _a;
        public newAlarm(BindingList<Alarm> list, Alarm a = null)
        {
            InitializeComponent();
            AlarmSet.Format = DateTimePickerFormat.Time;
            _list = list;
            _a = a;
            //Case for editing an alarm
            if(_a != null)
            {
                AlarmSet.Value = _a.Time;
                onOrOff.Checked = _a.OnOrOff;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (_a == null)
            {
                Alarm alarm = new Alarm(onOrOff.Checked, AlarmSet.Value);
                _list.Add(alarm);
                StreamWriter writer = new StreamWriter("AlarmData.txt");
                writer.WriteLine(alarm.ToString());
                writer.Close();
            }
            else
            {
                _a.Time = AlarmSet.Value;
                _a.OnOrOff = onOrOff.Checked;
                StreamWriter writer = new StreamWriter("AlarmData.txt");
                writer.WriteLine(_a.ToString());
                writer.Close();
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
