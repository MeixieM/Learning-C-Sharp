using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal piNum = 3.14m;
            string name = "Alex";
            int number = 22;
            float myFloat = 2.8f;

            Console.WriteLine($"My Name is {name} and Im {number} years old");
            Console.WriteLine("The value of pi is " + piNum + " and this is a float num = " + myFloat);

            Console.WriteLine("UPPERCASE " + name.ToUpper());
            Console.ReadKey();
        }
    }
}
