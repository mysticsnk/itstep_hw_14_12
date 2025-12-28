namespace Task2.Entities;

class Shop
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Area {  get; set; } 

    public Shop(string name, string address, string description, string phoneNumber, string email, int area)
    {
        Name = name;
        Address = address;
        Description = description;
        PhoneNumber = phoneNumber;
        Email = email;
        Area = area;
    }
    
    public static Shop operator+(Shop s, int increment) => new Shop(s.Name, s.Address,  s.Description, s.PhoneNumber, s.Email, s.Area + increment);
    public static Shop operator-(Shop s, int decrement) => new Shop(s.Name, s.Address,  s.Description, s.PhoneNumber, s.Email, s.Area - decrement);
    
    public static bool operator == (Shop shop1, Shop shop2) => shop1.Area == shop2.Area;
    public static bool operator != (Shop shop1, Shop shop2) => shop1.Area != shop2.Area;
    
    public static bool operator < (Shop shop1, Shop shop2) => shop1.Area < shop2.Area;
    public static bool operator > (Shop shop1, Shop shop2) => shop1.Area > shop2.Area;

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())  return false;
        
        Shop other =  obj as Shop;
        
        return Name == other.Name
               && Address == other.Address
               && PhoneNumber == other.PhoneNumber
               && Email == other.Email
               && Area == other.Area;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Address, Description, PhoneNumber, Email, Area);
    }

    public override string ToString() => $"{Name}, {Address}, {PhoneNumber}, {Email}, {Area}";
}