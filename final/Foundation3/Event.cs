using System.Net.Sockets;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Date: {_date} - {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public abstract void FullDetails();

    public void ShortDescription()
    {

        Console.WriteLine($"{_eventType}: {_title} - {_date}");
    }
}