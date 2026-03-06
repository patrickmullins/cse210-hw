using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator myGenerator = new PromptGenerator();
        bool keepOnRunning = true;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                Console.WriteLine("Write");
                string currentPrompt = myGenerator.GetRandomPrompt();
                Console.WriteLine(currentPrompt);
                string JournalEntryText = Console.ReadLine();
                break;
                case "2":
                Console.WriteLine("Display");
                break;
                case "3":
                Console.WriteLine("Load");
                break;
                case "4":
                Console.WriteLine("Save");
                break;
                case "5":
                keepOnRunning = false;
                break;
                default:
                Console.WriteLine("Invalid Choice, please select a number from 1-5 to choose an option.");
                break;
            }

        }
        while (keepOnRunning);
        
    }
}