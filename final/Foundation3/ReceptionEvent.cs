public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent()
    {
        // Empty constructor
    }

    public ReceptionEvent(string title, string description, DateTime date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public override void GenerateFullMessage()
    {
        Console.WriteLine($"{GetType().ToString().Substring(0,GetType().ToString().Length-5)}"); // https://stackoverflow.com/questions/20928315/how-can-i-slice-a-string-in-c
        Console.WriteLine($"{GetTitle()}");
        Console.WriteLine($"{GetDate().ToLongDateString()} | {GetTime()}");
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine($"\nVenue: \n{GetAddress().GetAddressString()}");
        Console.WriteLine($"\nRSVP: {_email}");
    }
}