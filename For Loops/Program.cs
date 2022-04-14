using System;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;
            //while ( i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            int[] luckyNumbers = {2, 6, 34, 1, 25, 76, 1, 99};
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


            Console.ReadLine();

        }
    }
}
