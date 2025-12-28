namespace Task3.Entities;

public class Book
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    
    public Book(string name, string description, string author, int year) {
        Name = name;
        Description = description;
        Author = author;
        Year = year;
    }
    
    public override string ToString() => $"{Name}, {Description}, {Author}, {Year}";

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        
        Book other = obj as Book;
        
        return Name ==  other.Name 
               && Description == other.Description 
               && Author == other.Author 
               && Year == other.Year;
    }
    
    public override int GetHashCode() => HashCode.Combine(Name, Description, Author, Year);
}