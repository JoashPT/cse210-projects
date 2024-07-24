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
        string shortString = $"{_date} {_activity} ({_duration} min.)";
        string distanceString = $"Distance: {GetDistance().ToString("0.##")} km";
        string speedString = $"Speed: {GetSpeed().ToString("0.##")} kph";
        string paceString = $"Pace: {GetPace().ToString("0.##")} min per km";
        string combinedString = $"{shortString}\n{distanceString}\n{speedString}\n{paceString}\n";
        return combinedString;
    }
}