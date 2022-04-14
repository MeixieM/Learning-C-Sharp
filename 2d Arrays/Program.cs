using System;

namespace _2d_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
