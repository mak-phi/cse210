public class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity()
    {
        // Empty constructor
    }

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public void SetDate(int year, int month, int day)
    {
        _date = new DateTime(year, month, day);
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public virtual double CalculateDistance()
    {
        return -1; // To override
    }

    public virtual double CalculateSpeed()
    {
        return -1; // Default; to override
    }

    public virtual double CalculatePace()
    {
        return -1; // Default; to override
    }

    public string GetSummary()
    {
    //  03 Nov 2022 Running (30 min): Distance: 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
    return $"{GetDate().ToString("dd MMM yyy")} {GetType().ToString()[..^8]} ({GetDuration()} min)- Distance: {CalculateDistance():0.0#} km, Speed: {CalculateSpeed():0.0#} kph, Pace: {CalculatePace():0.0#} min per km";
    // https://stackoverflow.com/questions/15546953/convert-date-to-dd-mmm-yyyy-format-c-sharp
    // https://stackoverflow.com/questions/20928315/how-can-i-slice-a-string-in-c
    // https://stackoverflow.com/questions/15288134/how-to-display-values-only-upto-2-decimal-places
    }
}