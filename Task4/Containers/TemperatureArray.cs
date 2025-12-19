namespace Task4.Containers;
using Task4.Entities;

public class TemperatureArray
{
    private static string[] _weekDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat",  "Sun" };
    private Temperature[] _weekTemps;
    
    public TemperatureArray() => _weekTemps = new Temperature[7];

    public Temperature this[int index]
    {
        get => _weekTemps[index];
        set => _weekTemps[index] = value;
    }

    public double GetAverageC()
    {
        return _weekTemps.Average(t => t.C);
    }
    
    public double GetAverageF()
    {
        return _weekTemps.Select(temperature => temperature.F).ToArray().Average();
    }

    public void Print()
    {
        for (int i = 0; i < _weekDays.Length; i++)
            Console.WriteLine($"{_weekDays[i]}: {_weekTemps[i].C}C, {_weekTemps[i].F}F");
    }
    
    public void PrintC()
    {
        for (int i = 0; i < _weekDays.Length; i++)
            Console.WriteLine($"{_weekDays[i]}: {_weekTemps[i].C}C");
    }
    
    public void PrintF()
    {
        for (int i = 0; i < _weekDays.Length; i++)
            Console.WriteLine($"{_weekDays[i]}: {_weekTemps[i].F}F");
    }
    
}