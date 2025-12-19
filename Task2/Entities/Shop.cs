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
    
    public void operator += (int increment) => Area += increment;
    public void operator -= (int decrement) => Area -= decrement;
    
    public static bool operator == (Shop shop1, Shop shop2) => shop1.Area == shop2.Area;
    public static bool operator != (Shop shop1, Shop shop2) => shop1.Area != shop2.Area;
    
    public static bool operator < (Shop shop1, Shop shop2) => shop1.Area < shop2.Area;
    public static bool operator > (Shop shop1, Shop shop2) => shop1.Area > shop2.Area;

    public bool Equals(Shop other)
    {
        return Name == other.Name
               && Address == other.Address
               && PhoneNumber == other.PhoneNumber
               && Email == other.Email
               && Area == other.Area;
    }

    public override string ToString() => $"{Name}, {Address}, {PhoneNumber}, {Email}, {Area}";
}