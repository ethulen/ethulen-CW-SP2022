using System;

public class Alarm : INotifyPropertyChanged
{
	public Alarm()
	{
		
	}
	private DateTime _time;
	public DateTime Time { get { return _time; } set { _time = value; } };
    private bool _onOrOff;

    public bool OnOrOff
    {
        get { return _onOrOff; }
        set { _onOrOff = value; }
    }


}
