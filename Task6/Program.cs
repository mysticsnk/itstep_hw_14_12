using Task6.Entities;

var p1 = new Product("Apple", 10, 5);
var p2 = new Product("Banana", 20, 3);
var p3 = new Product("Orange", 5, 7);

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

p1 += 5;
p2 -= 7;

Console.WriteLine("--- New Products ---");
Console.WriteLine(p1);
Console.WriteLine(p2);

Console.WriteLine(p1 == p3);
Console.WriteLine(p1 != p2);

Console.WriteLine(p2 < p1);
Console.WriteLine(p2 > p1);