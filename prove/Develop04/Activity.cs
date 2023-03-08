using System;

abstract class Activity
{
    protected abstract string Name { get; }

    public void Run()
    {
        Console.WriteLine(GetWelcomeMessage());
        RunInternal();
        Console.WriteLine(GetEndMessage());
    }

    protected abstract void RunInternal();

    private string GetWelcomeMessage()
    {
        return $"Welcome to the {Name}.";
    }

    private string GetEndMessage()
    {
        return $"Great job! You've completed the {Name}.";
    }
}