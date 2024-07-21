public class ReceptionEvent : Event
{
    private string _rsvp;

    public ReceptionEvent(string title, string description, string date, string time, Address address,
        string rsvp) : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
        _eventType = "Reception";
    }

    public override void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Email: {_rsvp}");
    }
}