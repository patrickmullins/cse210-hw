using System;

class Program
{
    static void Main(string[] args)
    {
        bool runningProgram = true;
        
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "4":
                runningProgram = false;
                break;

                default:
                Console.Write("Invalid Choice, please select a number from 1-4 to choose an option.");
                Console.ReadKey();
                break;
            }

        }

        while(runningProgram);
    }
}