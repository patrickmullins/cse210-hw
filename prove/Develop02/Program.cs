using System;
using System.Runtime.InteropServices;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator myGenerator = new PromptGenerator();
        Journal myJournal = new Journal();
       
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
            // using a switch to validate user input for the program. 
            switch(userInput)
            {
                case "1":
                Entry newEntry = new Entry();
                string currentPrompt = myGenerator.GetRandomPrompt();
                Console.WriteLine(currentPrompt);
                newEntry.PromptText = currentPrompt;
                string JournalEntryText = Console.ReadLine();
                newEntry.UserJournalWritten = JournalEntryText;
                newEntry.Date = DateTime.Now.ToShortDateString();
                myJournal.AddEntry(newEntry);
                break;
                case "2":
                myJournal.DisplayAll();
                break;
                case "3":
                Console.WriteLine("What is the filename that you want to load?");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
                break;
                case "4":
                Console.WriteLine("What is the filename that you want to save?");
                string saveFile = Console.ReadLine();
                myJournal.SaveToFile(saveFile);
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