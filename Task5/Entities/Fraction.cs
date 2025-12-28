namespace Task5.Entities;

public class Fraction
{
    private int _denominator;
    private int _numerator;
    
    public int Numerator
    {
        get => _numerator;
        set
        {
            _numerator = value;
            Simplify();
        }
    }

    public int Denominator
    {
        get => _denominator;
        set
        {
            if (value == 0)
                throw new DivideByZeroException();
            
            _denominator = value;
            Simplify();
        }
    }
    
    public Fraction(int numerator, int denominator)
    {
        Denominator = denominator;
        Numerator = numerator;
        Simplify();
    }
    
    public Fraction() : this(0, 1) {}

    public void Simplify()
    {
        for (int i = 2; i <= Math.Min(Denominator, Numerator); i++)
        {
            if (Numerator % i == 0 && Denominator % i == 0)
            {
                Numerator /= i;
                Denominator /= i;
            }
        }
    }

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

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        
        var other = obj as Fraction;
        
        return Denominator == other.Denominator && Numerator == other.Numerator;
    }
    
    public override int GetHashCode() => HashCode.Combine(Denominator, Numerator);

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}