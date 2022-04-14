using System;

namespace Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPower(3, 2));

            Console.ReadKey();

        }

        static int GetPower(int baseNum, int powerNum)
        {
            int result = 1;
            
            for(int i = 0; i < powerNum; i++)
            {
                result = result * baseNum;
            }

            return result;

        }
    }
}
