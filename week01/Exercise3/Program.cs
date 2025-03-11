using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool correct = false;
        int guesses = 0;

        do
        {
            Console.Write("What is your guess? ");
            string sGuess = Console.ReadLine();
            int guess = int.Parse(sGuess);

            if (guess == number)
            {
                correct = true;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            guesses = guesses + 1;

        }while (correct == false);

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"That took you {guesses} guesses!");

    }
}