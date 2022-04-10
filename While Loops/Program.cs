using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 5;

            //while (index <= 100)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            do 
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5) ;

            Console.ReadLine();
        }
    }
}
