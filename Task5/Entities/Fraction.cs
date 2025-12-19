namespace Task5.Entities;

public class Fraction
{
    private int _denominator;
    
    public int Numerator { get; set; }

    public int Denominator
    {
        get => _denominator;
        set
        {
            if (value == 0)
                throw new DivideByZeroException();
            
            _denominator = value;
        }
    }
    
    public Fraction(int numerator, int denominator)
    {
        Denominator = denominator;
        Numerator = numerator;
    }
    
    public Fraction() : this(0, 1) {}

    public static Fraction operator +(Fraction a, Fraction b)
    {
        var result = new Fraction();
        result.Denominator = a.Denominator * b.Denominator;
        result.Numerator = a.Numerator * b.Denominator + b.Numerator *  a.Denominator;
        return result;
    } 
    
    public static Fraction operator -(Fraction a, Fraction b)
    {
        var result = new Fraction();
        result.Denominator = a.Denominator * b.Denominator;
        result.Numerator = a.Numerator * b.Denominator - b.Numerator *  a.Denominator;
        return result;
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        var result = new Fraction();
        result.Numerator = a.Numerator * b.Numerator;
        result.Denominator = a.Denominator * b.Denominator;
        return result;
    }
    
    public static Fraction operator /(Fraction a, Fraction b)
    {
        var result = new Fraction();
        result.Numerator = a.Numerator * b.Denominator;
        result.Denominator = a.Denominator * b.Numerator;
        return result;
    }

    public static bool operator ==(Fraction a, Fraction b) 
    {
        return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
    }
    
    public static bool operator !=(Fraction a, Fraction b) =>  !(a == b);
    
    
}