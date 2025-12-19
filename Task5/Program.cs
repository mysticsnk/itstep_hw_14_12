using Task5.Entities;

var a = new Fraction(1, 2);
var b = new Fraction(1, 3);
var c = new Fraction();

Console.WriteLine($"{a.Numerator}/{a.Denominator}");
Console.WriteLine($"{b.Numerator}/{b.Denominator}");
Console.WriteLine($"{c.Numerator}/{c.Denominator}");

var add = a + b;
Console.WriteLine($"{add.Numerator}/{add.Denominator}");

var sub = a - b;
Console.WriteLine($"{sub.Numerator}/{sub.Denominator}");

var mul = a * b;
Console.WriteLine($"{mul.Numerator}/{mul.Denominator}");

var div = a / b;
Console.WriteLine($"{div.Numerator}/{div.Denominator}");

var x = new Fraction(2, 4);
var y = new Fraction(1, 2);

Console.WriteLine(x == y);
Console.WriteLine(a == new Fraction(1, 2));

try
{
    var bad = new Fraction(1, 0);
}
catch (DivideByZeroException)
{
    Console.WriteLine("DivideByZeroException");
}