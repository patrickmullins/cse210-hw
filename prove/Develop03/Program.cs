using System;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureRefs = new List<Scripture>();
        scriptureRefs.Add(new Scripture(new Reference("proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him,and he shall direct thy paths."));
        scriptureRefs.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptureRefs.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."));
        scriptureRefs.Add(new Scripture(new Reference("Galatians", 5, 22, 23), "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, Meekness, temperance: against such there is no law."));
        // using random number generator to pick a random scripture from the list above.
        Random rand = new Random();
        int randomIndex = rand.Next(scriptureRefs.Count);
        Scripture scripture = scriptureRefs[randomIndex];
        bool keepOnRunning = true;
            do
                {
               // clears console so most up to date passage of the scripture is available.
                Console.Clear();
                //displays the scripture text using the 
                Console.WriteLine(scripture.GetDisplayText());
                if (scripture.IsCompletelyHidden())
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