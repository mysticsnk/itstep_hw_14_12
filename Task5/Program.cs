using Task5.Entities;

var a = new Fraction(1, 2);
var b = new Fraction(1, 3);
var c = new Fraction();

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

var add = a + b;
Console.WriteLine(add);

var sub = a - b;
Console.WriteLine(sub);

var mult = a * b;
Console.WriteLine(mult);

var div = a / b;
Console.WriteLine(div);

var x = new Fraction(2, 4);
var y = new Fraction(1, 2);

Console.WriteLine("--- Equal fractions are equal ---");
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