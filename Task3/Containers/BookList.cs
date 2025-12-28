using Task3.Entities;

namespace Task3.Containers;

public class BookList
{
    private List<Book> _books;
    
    public BookList(List<Book> books) => _books = books;

    public static BookList operator +(BookList books, Book newBook)
    {
        books.Add(newBook);
        return books;
    }

    public static BookList operator -(BookList books, Book book)
    {
        books.Remove(book);
        return books;
    }
    
    public void Add(Book book) => _books.Add(book);
    public void Remove(Book book) => _books.Remove(book);

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        
        var other = obj as BookList;

        foreach (var book in _books)
            if (!book.Equals(other)) return false;
        
        return true;
    }

    public override int GetHashCode()
    {
        int result = 0;
        foreach (var book in _books)
            HashCode.Combine(result, book.GetHashCode());
        
        return result;
    }

    public bool Contains(Book book) => _books.Contains(book);

    public Book this[int index] => _books[index];

    public void Print()
    {
        Console.WriteLine("--- Book List ---");
        foreach (var book in _books)
            Console.WriteLine(book);
    }
}