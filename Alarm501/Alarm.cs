using System;
using System.ComponentModel;

public class Alarm : INotifyPropertyChanged
{
    
	public Alarm(bool o, DateTime d)
	{
        OnOrOff = o;
        Time = d;
	}
	private DateTime _time;
	public DateTime Time { get { return _time; } set { _time = value; OnPropertyChanged(nameof(Time)); } }
    private bool _onOrOff;
    public bool OnOrOff
    {
        get { return _onOrOff; }
        set { _onOrOff = value;
            OnPropertyChanged(nameof(OnOrOff));
        }
    }
    //TODO: Override ToString for ListBox
    public override string ToString()
    {
        return Time.ToString("hh:mm tt") + " " + OnOrOff.ToString();
    }
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(string replace = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(replace));
    }
}
