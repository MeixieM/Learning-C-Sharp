using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "lion";
            string guessWord = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while (guessWord != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    for(int i = 1; i <= guessLimit; i++)
                    {
                        Console.Write("Enter guess "+i+": ");
                        guessWord = Console.ReadLine();
                        guessCount++;
                    }
                   
                } else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose");
            } else
            {
            Console.Write("You Win");
            }

            Console.ReadLine();
        }
    }
}
