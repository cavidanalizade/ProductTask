using System;


namespace ProductTask
{
    class Library
    {
        public Book[] books;
        public Library()
        {
            books = new Book[0];

        }


        public void AddBook(Book book)
        {
            Book[] newBook = new Book[books.Length+1];
            for (int i = 0; i < books.Length; i++)
            {
                newBook[i] = books[i];

            }
            newBook[newBook.Length-1] = book;
            books = newBook;

        }
        public void GetBook(string name)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Name==name)
                {
                    Console.WriteLine($"{books[i].Name}  {books[i].Price} ");
                }
                
            }
        }
        


    }
}
