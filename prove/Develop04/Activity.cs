using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity(string name, string discription)
{
    private string _name = name;
    private string _discription = discription;

    protected int _userSessionDuration;

    public void standardStartMessage()
    {
        Console.Clear();
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
        
        DateTime endTimer = DateTime.Now.AddSeconds(_userSessionDuration);
        List<string> timer = new List<string>() {"|", "/",  "-", "\\"};
        int i = 0;
        while(DateTime.Now < endTimer)
            {
                Console.Write(timer[i]);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i++;
                if (i >= timer.Count)
                    {
                    i = 0;
                    }
            }


    }
    public void countingDown()
    {
        for(int i = 3; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public abstract void Run();

}