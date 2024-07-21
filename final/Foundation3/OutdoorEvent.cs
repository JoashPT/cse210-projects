public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address,
        string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }

    public override void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}