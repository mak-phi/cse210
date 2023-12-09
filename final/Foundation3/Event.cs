public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _venue;

    public Event()
    {
        // Empty constructor
    }

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _venue = address;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;    
    }
    
    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetTime()
    {
        return _time;
    }
    
    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    
    public void SetAddress(Address address)
    {
        _venue = address;
    }

    public Address GetAddress()
    {
        return _venue;
    }

    public void GenerateStandardMessage()
    {
        // Lists the title, description, date, time, and address.
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_date.ToLongDateString()} | {_time}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"\nVenue: \n{_venue.GetAddressString()}");
    }

    public abstract void GenerateFullMessage(); // Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.

    public void GenerateShortDescription()
    {
        // Lists the type of event, title, and the date.
        Console.WriteLine($"{GetType().ToString().Substring(0,GetType().ToString().Length-5)}");
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_date.ToLongDateString()}");
    }
    
}