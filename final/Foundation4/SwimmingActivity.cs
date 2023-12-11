public class SwimmingActivity : Activity
{
    private int _numOfLaps;

    public SwimmingActivity()
    {
        // Empty constructor
    }

    public SwimmingActivity(DateTime date, int duration, int numOfLaps) : base(date, duration)
    {
        _numOfLaps = numOfLaps;
    }

    public void SetNumOfLaps(int numOfLaps)
    {
        _numOfLaps = numOfLaps;
    }

    public double GetNumOfLaps()
    {
        return _numOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numOfLaps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetDuration()) * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

}