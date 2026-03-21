using System;


class Activity(name, discription)
{
    private string _name = name;
    private string _discription = discription;

    protected int _userSessionDuration;

    public void standardStartMessage()
    {
        Console.clear();

        Console.Write($"Hello welcome to the {_name} Activity.");
        Console.Write(_discription);
        Console.Write("How long, in seconds, would you like for your session?");
        _userSessionDuration = int.Parse(Console.ReadLine());

    }
    public void standardEndMessage()
    {
        Console.Write("Well done!");
        Console.Write($"You have completed another {_userSessionDuration} seconds of the {_name} Activity.");

    }
    
    public void showCountSession()
    {
        List<string> timer = new List<string>() {"|" "/"  "-" "\\"}; 
    }
    
    abstract void Run();


}