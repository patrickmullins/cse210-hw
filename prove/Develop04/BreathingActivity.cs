class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
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
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            countingDown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            countingDown(5);
            Console.WriteLine();

        }
       
        standardEndMessage();
        showCountSession(5);
    }
}