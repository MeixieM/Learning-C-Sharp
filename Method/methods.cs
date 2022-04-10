using System;

namespace Method
{
    class methods
    {
        static void Main(string[] args)
        {
            SayHi("Alex", 10);
            SayHi("Ana", 12);
            SayHi("Mei", 15);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age} years old.");
        }
    }
 
}
