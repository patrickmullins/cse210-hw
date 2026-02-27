using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        promptUserName();
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
        
    }

    static int promptUserBirthYear()
    {
        
    }
    static int squareNumber()
    {
        
    }
    static void displayResult()
    {
        
    }
}