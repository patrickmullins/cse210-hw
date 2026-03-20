using System;


class Activity(name, discription)
{
    private string _name = name;
    private string _discription = discription;

    protected int _userSessionDuration;


public void standardEndMessage()
    {
        Console.Write("Well done!");
    }

public void standardStartMessage()
    {
        Console.clear();

        Console.Write("This is a test from the start message method");
    }

public abstract void Run();

}