using System;

namespace Different_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Arithmetic Operators 

            int a = 6;
            int b = 2;


            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(++a);
            Console.WriteLine(b--);
            Console.WriteLine("--------------------------");

            //Comparison Operators

            a = 6;
            b = 2;

            Console.WriteLine(a == b);  //False
            Console.WriteLine(a != b);  //True
            Console.WriteLine(a > b);   //True
            Console.WriteLine(a < b);   //False
            Console.WriteLine(a >= b);  //True
            Console.WriteLine(a <= b);  //False
            Console.WriteLine("--------------------------");


            //Assignment Operators

            a = 6;
            b = 2;

            Console.WriteLine(a = b);
            Console.WriteLine(a += a);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a /= b);
            Console.WriteLine("--------------------------");

            //Logical Operators

            a = 6;
            b = 2;

            Console.WriteLine(a != b && b == 2); //AND && both statatements need to be true in order for the next code to run
            Console.WriteLine(a != b && b == 10); //FALSE
            Console.WriteLine((a != b) || (b == 2)); //OR || only one of the statatements need to be true in order for the next code to run
            Console.WriteLine(!(b == 10)); //TRUE
            Console.WriteLine("--------------------------");


            Console.ReadKey();

        }
    }
}
