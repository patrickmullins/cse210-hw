class ReflectionActivity : Activity
{
    public ReflectionActivity(): base("Reflection",  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    public override void Run()
    {
        standardStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_userSessionDuration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        showCountSession(3);
        while(DateTime.Now < endTime)
        {
            
        }

    }
}