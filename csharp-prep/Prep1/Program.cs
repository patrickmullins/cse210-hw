using System;

class Program
{
    static void Main(string[] args)
    {
        // initial message to user prmopting for their first name
        Console.Write("What is your first name? ");
        // initializing first name variable using input from the console 
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        // displays the user's name in the style of james bond introduction
        Console.Write("Your name is " + lastName + ", " + firstName + " " + lastName + ".");
    }
}