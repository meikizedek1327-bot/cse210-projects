using System;

class Program
{
   static void Main(string[] args)
    {
        string playAgain = "yes";
        Random random = new Random();

        while (playAgain.ToLower() == "yes")
        {
            // Here I generate a random magic number between 1 and 100
            int magicNumber = random.Next(1, 21);
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            // It keeps asking until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}