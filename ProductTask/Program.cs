using System;

namespace ProductTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Sherlock", 32, "Detective");
/*            Console.WriteLine($"{book.Name}  {book.Price} {book.Genre}");
*/            Library library = new Library();

            library.AddBook(book);
            library.GetBook("Sherlock");
            
        }
    }
}
