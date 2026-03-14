using System;
using System.Collections;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text ="Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture = new Scripture(reference, text);
        bool keepOnRunning = true;
            do
                {
               
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                if (scripture.IsCompletelyHidden() == true)
                    {
                        keepOnRunning = false;
                        break;
                    }
                Console.Write("\nPress enter to continue or type 'quit' to exit the program: ");
                string userInput = Console.ReadLine();
                switch(userInput)
                    {
                    
                    case "":
                    scripture.HideRandomWords(3);
                    break;

                    case "quit":
                    keepOnRunning = false;
                    break;
                        
                    default:
                    Console.WriteLine("Please input a valid response, press enter or type 'quit' to exit the program.");
                    Console.ReadLine();
                    break;
                    }
                }
            while (keepOnRunning);
    }
}