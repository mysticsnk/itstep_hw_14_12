using Task2.Entities;

var coolShop = new Shop("CoolShop","GudliStreet", "It's a cool Shop",
    "123", "cool@Shop.com", 100);

var coolerShop = new Shop("CoolerShop", "GudliStreet", "It's a cooler Shop",
    "123456", "cooler@Shop.com", 1000);

Console.WriteLine(coolShop);
Console.WriteLine(coolerShop);

Console.WriteLine($"Same: {Equals(coolerShop, coolShop)}");
Console.WriteLine($"First has more Area: {coolShop > coolerShop}");
Console.WriteLine($"Second has more Area: {coolShop < coolerShop}");

coolerShop -= 900;
Console.WriteLine("New cooler Shop: ");
Console.WriteLine(coolerShop);

Console.WriteLine($"Equal Area: {coolShop == coolerShop}");