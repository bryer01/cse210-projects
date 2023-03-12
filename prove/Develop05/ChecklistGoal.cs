using System;

class ChecklistGoal : Goal
{
    public int CompletedCount { get; set; }
    public int RequiredCount { get; set; }

    public override string GetDescription()
    {
        return "A checklist goal";
    }
}