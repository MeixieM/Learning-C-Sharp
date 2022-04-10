using System;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isMale = false;
            //bool isTall = true;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are not male but you are tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male and not tall");
            //}



            Console.WriteLine(GetMax(2, 10, 5));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }
    }
}
