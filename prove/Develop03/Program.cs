using System;
using System.Collections;

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
                case "1":
                Console.WriteLine("case 1 test ");
                break;
                
                case "quit":
                keepOnRunning = false;
                break;
                default:
                Console.WriteLine("Please input a valid response, enter or 'quit' to finish the program. ");
                break; 
                }
                
            }
            while (keepOnRunning);
        }
        
    }