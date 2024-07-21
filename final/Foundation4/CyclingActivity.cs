public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
        _activity = "Cycling";
    }

    public override double GetDistance()
    {
        return _speed / 60 * _duration;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}