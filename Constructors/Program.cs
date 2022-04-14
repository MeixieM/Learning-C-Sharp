using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Book Title 1","Author Name 1", 200);
            Book book2 = new Book("Book Title 2", "Author Name 2", 300);


            Console.WriteLine(book1.title) ;
            Console.WriteLine(book2.title);

            Console.ReadKey();
        }
    }
}
