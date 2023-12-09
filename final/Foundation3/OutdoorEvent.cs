public class OutdoorEvent : Event
{
    private string _weatherCondition;

    public OutdoorEvent()
    {
        // Empty constructor
    }

    public OutdoorEvent(string title, string description, DateTime date, string time, Address address, string weatherCondition) : base(title, description, date, time, address)
    {
        _weatherCondition = weatherCondition;
    }

    public void SetWeatherCondition(string weatherCondition)
    {
        _weatherCondition = weatherCondition;
    }

    public string GetWeatherCondition()
    {
        return _weatherCondition;
    }

    public override void GenerateFullMessage()
    {
        Console.WriteLine($"{GetType().ToString().Substring(0,GetType().ToString().Length-5)}");
        Console.WriteLine($"{GetTitle()}");
        Console.WriteLine($"{GetDate().ToLongDateString()} | {GetTime()}");
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine($"\nVenue: \n{GetAddress().GetAddressString()}");
        Console.WriteLine($"\nWeather Forecast: {_weatherCondition}");
    }
}