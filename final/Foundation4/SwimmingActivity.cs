public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
        _activity = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _duration;
    }
    public override double GetPace()
    {
        return _duration / GetDistance();
    }
}