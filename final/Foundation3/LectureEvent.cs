public class LectureEvent : Event
{
    private string _speakerName;
    private int _venueCapacity;

    public LectureEvent()
    {
        // Empty constructor
    }

    public LectureEvent(string title, string description, DateTime date, string time, Address address, string speakerName, int venueCapacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _venueCapacity = venueCapacity;
    }

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetVenueCapacity(int venueCapacity)
    {
        _venueCapacity = venueCapacity;
    }

    public int GetVenueCapacity()
    {
        return _venueCapacity;
    }

    public override void GenerateFullMessage()
    {
        Console.WriteLine($"{GetType().ToString().Substring(0,GetType().ToString().Length-5)}"); // https://stackoverflow.com/questions/20928315/how-can-i-slice-a-string-in-c
        Console.WriteLine($"{GetTitle()}");
        Console.WriteLine($"{GetDate().ToLongDateString()} | {GetTime()}");
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine($"Guest Speaker: {_speakerName}");
        Console.WriteLine($"\nVenue: \n{GetAddress().GetAddressString()}");
        Console.WriteLine($"Limited Capacity: {_venueCapacity} persons");
    }
}