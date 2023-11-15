public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int value)
    {
        _numerator = value;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetDenominator(int value)
    {
        _denominator = value;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }

}