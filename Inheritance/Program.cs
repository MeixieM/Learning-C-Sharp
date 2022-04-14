using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            chef.MakeSpecialDish();


            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadKey();

        }
    }
}
