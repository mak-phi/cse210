using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Console.WriteLine("Guess the magic number? (between 1 - 100)");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);
            int attempts = 0;
            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;
                
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();
        }
    }
}