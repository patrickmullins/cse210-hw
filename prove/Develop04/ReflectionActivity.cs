class ReflectionActivity : Activity
{
    public ReflectionActivity(): base("Reflection",  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public override void Run()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        string question = _questions[rand.Next(_questions.Count)];

        standardStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_userSessionDuration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        showCountSession(3);
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n ----- {prompt} ---- \n");
        Console.WriteLine("When you have something in mind, press enter to continuie.");
        Console.ReadLine();
        while(DateTime.Now < endTime)
        {
            Console.WriteLine($"\n ----- {question} ---- \n");
            showCountSession(4);
        }

    }
}