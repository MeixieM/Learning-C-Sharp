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
                    Console.Write("Enter guess: ");
                    guessWord = Console.ReadLine();
                    guessCount++;
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
