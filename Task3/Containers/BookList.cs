using Task3.Entities;

namespace Task3.Containers;

public class BookList
{
    private List<Book> _books;
    
    public BookList(List<Book> books) => _books = books;
    
    public void operator +=(Book book) => _books.Add(book);
    public void operator -=(Book book) => _books.Remove(book);
    
    public bool Contains(Book book) => _books.Contains(book);

    public Book this[int index] => _books[index];

    public void Print()
    {
        Console.WriteLine("--- Book List ---");
        foreach (var book in _books)
            Console.WriteLine(book);
    }
}