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
        }
    }
}