using Task4.Containers;
using Task4.Entities;

var temps = new TemperatureArray();

temps[0] = new Temperature { C = 0 };
temps[1] = new Temperature { C = 10 };
temps[2] = new Temperature { C = 20 };
temps[3] = new Temperature { C = 30 };
temps[4] = new Temperature { C = 40 };
temps[5] = new Temperature { C = 25 };
temps[6] = new Temperature { C = 15 };

Console.WriteLine("--- Full Print ---");
temps.Print();

Console.WriteLine("\n--- Celsius ---");
temps.PrintC();

Console.WriteLine("\n--- Fahrenheit ---");
temps.PrintF();

Console.WriteLine("\n--- Averages ---");
Console.WriteLine($"Average C: {temps.GetAverageC()}");
Console.WriteLine($"Average F: {temps.GetAverageF()}");

Console.WriteLine("\n--- Indexer Test ---");
Console.WriteLine($"Wednesday temp: {temps[2].C}C");