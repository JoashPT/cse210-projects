public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string numerator = _top.ToString();
        string denominator = _bottom.ToString();
        string fraction = $"{numerator}/{denominator}";

        return fraction;
    }

    public double GetDecimalValue()
    {
        double rationalNumber = (double)_top / _bottom;

        return rationalNumber;
    }
}