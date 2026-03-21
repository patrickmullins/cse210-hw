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
        List<string> userInputList = new list<string>
    }

}
