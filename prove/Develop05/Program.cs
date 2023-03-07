using System;
using System.Collections.Generic;
static void Main(string[] args)
public enum GoalType { SIMPLE, ETERNAL, CHECKLIST }

public class Goal
{
    public GoalType type;
    public string description;
    public int points;
    public int totalTimes;
    public int completedTimes;

    public Goal(GoalType type, string description, int points, int totalTimes)
    {
        this.type = type;
        this.description = description;
        this.points = points;
        this.totalTimes = totalTimes;
        this.completedTimes = 0;
    }

    public new GoalType GetType()
    {
        return type;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetPoints()
    {
        return points;
    }

    public int GetTotalTimes()
    {
        return totalTimes;
    }

    public int GetCompletedTimes()
    {
        return completedTimes;
    }

    public void MarkCompleted()
    {
        completedTimes++;
    }
}

public class GoalTracker
{
    private List<Goal> goals;
    private int score;

    public GoalTracker()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        Goal goal = goals[goalIndex];
        goal.MarkCompleted();
        score += goal.GetPoints();
        if (goal.GetType() == GoalType.CHECKLIST && goal.GetCompletedTimes() == goal.GetTotalTimes())
        {
            score += 500;
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            string status;
            if (goal.GetType() == GoalType.CHECKLIST)
            {
                status = string.Format("Completed {0}/{1} times", goal.GetCompletedTimes(), goal.GetTotalTimes());
            }
            else
            {
                status = goal.GetCompletedTimes() > 0 ? "[X]" : "[ ]";
            }
            Console.WriteLine("{0} {1} ({2} points)", status, goal.GetDescription(), goal.GetPoints());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine("Score: {0}", score);
    }

    public void Save()
    {
        // implementation for saving progress
    }

    public void Load()
    {
        // implementation for loading progress
    }
}
