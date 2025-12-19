using Task1.Entities;

var coolJournal = new Journal("CoolJournal", 2000, "It's a cool journal",
    "123", "cool@Journal.com", 100);

var coolerJournal = new Journal("CoolerJournal", 2000, "It's a cooler journal",
    "123456", "cooler@Journal.com", 1000);

Console.WriteLine(coolJournal);
Console.WriteLine(coolerJournal);

Console.WriteLine($"Same: {Equals(coolerJournal, coolJournal)}");
Console.WriteLine($"First has more workers: {coolJournal > coolerJournal}");
Console.WriteLine($"Second has more workers: {coolJournal < coolerJournal}");

coolerJournal -= 900;
Console.WriteLine("New cooler Journal: ");
Console.WriteLine(coolerJournal);

Console.WriteLine($"Equal worker amount: {coolJournal == coolerJournal}");