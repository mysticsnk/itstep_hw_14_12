using Task3.Entities;
using Task3.Containers;

var book1 = new Book(
    "1984",
    "Dystopian novel",
    "George Orwell",
    1949
);

var book2 = new Book(
    "Brave New World",
    "Science fiction",
    "Aldous Huxley",
    1932
);

var book3 = new Book(
    "Fahrenheit 451",
    "Censorship dystopia",
    "Ray Bradbury",
    1953
);

var bookList = new BookList(new List<Book> { book1, book2 });

bookList += book3;
Console.WriteLine("--- Has added book ---");
Console.WriteLine(bookList.Contains(book3));
bookList.Print();

Console.WriteLine("--- First book ---");
Console.WriteLine(bookList[0]);

bookList -= book2;
Console.WriteLine("--- Has removed book ---");
Console.WriteLine(bookList.Contains(book2));

bookList.Print();