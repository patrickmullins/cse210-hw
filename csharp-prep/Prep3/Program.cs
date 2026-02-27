using System;

class Program
{
    static void Main(string[] args)
    {
        Random numberGen = new();

        int magicNumber = numberGen.Next(1, 201);
        
        int guessNumber = 0;

        while (guessNumber != magicNumber)

        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            // output message to user that they guess the random number correctly
            if (guessNumber == magicNumber)
            {
                Console.WriteLine("Congratulations, You guess the number correctly!");
            }
            // creating logic to print to user that the number is lower then the random number
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Try again, higher");
            }
        }
    }
}