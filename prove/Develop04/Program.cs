using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflect = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
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
                case "1":
                breathing.Run();
                break;
                case "2":
                reflect.Run();
                break;
                case "3":
                listing.Run();
                break;
                case "4":
                runningProgram = false;
                break;

                default:
                Console.Write("Invalid Choice, please select a number from 1-4 to choose an option. Press any key to continue");
                //used a readkey to allow user to read the error message then prompts them for a keypress to continue with a valid selection for the program
                Console.ReadKey();
                break;
            }

        }

        while(runningProgram);
    }
}