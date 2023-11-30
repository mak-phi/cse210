public class Square : Shape
{
    private double _length;

    public Square(double length, string color) : base(color)
    {
        _length = length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }

    public override double GetArea()
    {
        return _length * _length;
    }
}