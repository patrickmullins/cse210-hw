using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string userName = promptUserName();
        int favNum = promptUserNumber();
        int birthYear;
        promptUserBirthYear(out birthYear);
        int squaredNumber = squareNumber(favNum);

        displayResult(userName, squaredNumber, birthYear);
    }
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptUserName()
    {
       Console.Write("Please enter your name: ");
       string name = Console.ReadLine();
       return name; 
    }

    static int promptUserNumber()
    {
        Console.Write("Pease enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void promptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
        
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}