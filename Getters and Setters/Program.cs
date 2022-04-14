using System;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie movie1 = new Movie("Lord of the Rings", "Michael Chu", "PG-13");
            Movie movie2 = new Movie("Lord of the Rings", "Michael Chu", "PG");


            Console.WriteLine(movie1.Rating);
            Console.ReadKey();
        }
    }
}
