namespace Task1.Entities;

class Journal
{
    public string Name { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int WorkerAmount { get; set; }

    public Journal(string name, int year, string description, string phoneNumber, string email, int workerAmount)
    {
        Name = name;
        Year = year;
        Description = description;
        PhoneNumber = phoneNumber;
        Email = email;
        WorkerAmount = workerAmount;
    }

    public void operator +=(int increment) => WorkerAmount += increment;
    public void operator -=(int decrement) => WorkerAmount -= decrement;

    public static bool operator ==(Journal journal1, Journal journal2) => journal1.WorkerAmount == journal2.WorkerAmount;
    public static bool operator !=(Journal journal1, Journal journal2) => journal1.WorkerAmount != journal2.WorkerAmount;

    public static bool operator <(Journal journal1, Journal journal2) => journal1.WorkerAmount < journal2.WorkerAmount;
    public static bool operator >(Journal journal1, Journal journal2) => journal1.WorkerAmount > journal2.WorkerAmount;

    public static bool Equals(Journal journal1, Journal journal2)
    {
        return journal1.Name == journal2.Name 
            && journal1.Year == journal2.Year
            && journal1.Description == journal2.Description
            && journal1.PhoneNumber == journal2.PhoneNumber
            && journal1.Email == journal2.Email
            && journal1.WorkerAmount == journal2.WorkerAmount;
    }

    public override string ToString() => $"{Name}, {Year}, {Description}, {PhoneNumber}, {Email}, {WorkerAmount}"; 
}