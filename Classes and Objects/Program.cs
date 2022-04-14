using System;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object is an instance of a class
            Book book1 = new Book();
            book1.title = "Discrete Math Version 1";
            book1.author = "Juan Tamad";
            book1.pages = 200;

            Book book2 = new Book();
            book2.title = "Discrete Math Version 2";
            book2.author = "Juan Tamad";
            book2.pages = 300;

            Console.WriteLine(book2.pages);

            Console.ReadKey(); 
        }
    }
}
