using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Generating a random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int numberOfGuesses = 0;

            Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

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
                    Console.WriteLine($"You guessed it in {numberOfGuesses} guesses!");
                }
            }

            // Asking to the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string userResponse = Console.ReadLine().ToLower();
            playAgain = userResponse == "yes";
        }
    }
}