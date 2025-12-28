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

    public static Journal operator +(Journal j, int increment)
    {
        return new Journal(j.Name, j.Year, j.Description, j.PhoneNumber, j.Email, j.WorkerAmount + increment);
    }
    
    public static Journal operator -(Journal j, int decrement)
    {
        return new Journal(j.Name, j.Year, j.Description, j.PhoneNumber, j.Email, j.WorkerAmount - decrement);
    }
    
    public static bool operator ==(Journal journal1, Journal journal2) => journal1.WorkerAmount == journal2.WorkerAmount;
    public static bool operator !=(Journal journal1, Journal journal2) => journal1.WorkerAmount != journal2.WorkerAmount;

    public static bool operator <(Journal journal1, Journal journal2) => journal1.WorkerAmount < journal2.WorkerAmount;
    public static bool operator >(Journal journal1, Journal journal2) => journal1.WorkerAmount > journal2.WorkerAmount;

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        
        var other = obj as Journal;
        
        return Name == other.Name 
            && Year == other.Year
            && Description == other.Description
            && PhoneNumber == other.PhoneNumber
            && Email == other.Email
            && WorkerAmount == other.WorkerAmount;
    }

    public override int GetHashCode() => HashCode.Combine(Name, Year, Description, PhoneNumber, Email, WorkerAmount);

    public override string ToString() => $"{Name}, {Year}, {Description}, {PhoneNumber}, {Email}, {WorkerAmount}"; 
}