public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
        _activity = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _duration;
    }
    public override double GetPace()
    {
        return _duration * 60 / _distance;
    }
}