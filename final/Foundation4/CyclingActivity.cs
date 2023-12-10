public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity()
    {
        // Empty constructor
    }

    public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public override double CalculateDistance()
    {
        return (_speed / 60) * GetDuration();

    }

    public override double CalculateSpeed()
    {
        return GetSpeed();
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}