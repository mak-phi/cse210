public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity()
    {
        // Empty constructor
    }

    public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public override double CalculateDistance()
    {
        return GetDistance();
    }

    public override double CalculateSpeed()
    {
        // return 60 / CalculatePace();
        return (_distance / GetDuration()) * 60;
    }

    public override double CalculatePace()
    {
        // return 60 / CalculateSpeed();
        return GetDuration() / _distance;       
    }
}