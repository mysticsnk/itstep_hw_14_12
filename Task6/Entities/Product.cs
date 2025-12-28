namespace Task6.Entities;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    private int _amount;

    public int Amount
    {
        get => _amount;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException("Amount cannot be negative");
            _amount = value;
        }
    }

    public Product(string name, int amount, int price)
    {
        Name = name;
        Amount = amount;
        Price = price;
    }

    public static Product operator +(Product p, int increment) => new Product(p.Name, p.Amount + increment, p.Price);
    public static Product operator -(Product p, int decrement) => new Product(p.Name, p.Amount - decrement, p.Price);

    public static bool operator ==(Product a, Product b) => a.Price == b.Price;
    public static bool operator !=(Product a, Product b) => a.Price != b.Price;

    public static bool operator <(Product a, Product b) => a.Amount < b.Amount;
    public static bool operator >(Product a, Product b) => a.Amount > b.Amount;

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;

        var other = obj as Product;

        return Name == other.Name && Amount == other.Amount && Price == other.Price;
    }
    
    public override int GetHashCode() => HashCode.Combine(Name, Amount, Price);

    public override string ToString()
    {
        return $"{Name} - {Amount} pc. - {Price}$";
    }
}