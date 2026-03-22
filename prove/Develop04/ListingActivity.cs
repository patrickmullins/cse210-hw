class ListingActivity : Activity
{
     public ListingActivity(): base("Listing",  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
   
    public override void Run()
    {
        standardStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_userSessionDuration);
        Console.WriteLine("Get Ready...");
        showCountSession(3);
        Console.Clear();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses are you can to the following prompt: ");
        Console.WriteLine($" ---- {prompt} ---- ");
        countingDown(5);
        Console.WriteLine();

        List<string> userInputList = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            userInputList.Add(input);
        }
        Console.Clear();
        Console.WriteLine($"You listed {userInputList.Count} Items!");
        standardEndMessage();
        
    }

}
