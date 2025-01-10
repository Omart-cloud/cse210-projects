using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number between 1 and 100
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);

            int guess = -1;
            int guessCount = 5;

            Console.WriteLine("A magic number between 1 and 100 has been generated. Try to guess it!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher!");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses to find the magic number!");

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false;
            }
        }
    }
}
