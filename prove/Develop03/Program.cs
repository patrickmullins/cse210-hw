using System;
using System.Collections;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool keepOnRunning = true;
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            do
                {
                string userInput = Console.ReadLine();
            

                switch(userInput)
                    {
                    case "":
                    Console.Clear();
                    Console.WriteLine("case 1 test ");
                    Console.WriteLine("Enter key has been pressed.");
                    break;
                    
                    case "quit":
                    keepOnRunning = false;
                    break;
                    default:
                    Console.WriteLine("Please input a valid response, press enter or type 'quit' to close the program.");
                    break; 
                    }
                
                }
            while (keepOnRunning);
    }

}