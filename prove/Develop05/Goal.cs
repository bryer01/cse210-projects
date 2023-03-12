using System;
abstract class Goal
{
    public string Name { get; set; }
    public int Score { get; set; }

    public abstract string GetDescription();
}

