public abstract class Activity
{
    protected string _date;
    protected double _duration;
    protected string _activity;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $@"{_date} {_activity} ({_duration})
        Distance: {GetDistance().ToString("0.##")} km
        Speed:{GetSpeed().ToString("0.##")} kph
        Pace:{GetPace().ToString("0.##")} min per km";
    }
}