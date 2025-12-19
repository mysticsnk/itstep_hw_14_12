namespace Task6.Entities;

public class Product
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }
    
    public Product(string name, int amount, int price)
    {
        Name = name;
        Amount = amount;
        Price = price;
    }
    
    public void operator +=(int increment) => Amount += increment;
    public void operator -=(int decrement) => Amount -= decrement;

    public static bool operator ==(Product a, Product b) => a.Price == b.Price;
    public static bool operator !=(Product a, Product b) => a.Price != b.Price;
    
    public static bool operator <(Product a, Product b) => a.Amount < b.Amount;
    public static bool operator >(Product a, Product b) => a.Amount > b.Amount;

    public override string ToString()
    {
        return $"{Name} - {Amount} pc. - {Price}$";
    }
}