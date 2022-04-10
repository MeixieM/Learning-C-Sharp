using System;

namespace Mad_Lib_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity, choice;

            do
            {
                Console.Write("Enter color: ");
                color = Console.ReadLine();

                Console.Write("Enter a plural noun: ");
                pluralNoun = Console.ReadLine();

                Console.Write("Enter a celebrity: ");
                celebrity = Console.ReadLine();

                Console.WriteLine($"Roses are {color}");
                Console.WriteLine($"{pluralNoun} are blue");
                Console.WriteLine($"I love {celebrity}");

                Console.WriteLine("Do you want to play again? [yes] [no]");
                choice = Console.ReadLine();
                Console.WriteLine("---------------------------------------");
            } while (choice == "yes");

            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}
