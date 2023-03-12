using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static string goalsFilePath = "goals.txt";

    static void Main(string[] args)
    {

        {
            Console.WriteLine("Eternal Quest - Goals");
            Console.WriteLine($"Your score: {score}");
            Console.WriteLine("------------------------");


            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddNewGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;
            }
        }
    }

    private static void DisplayGoals()
    {
        Console.Read();
    }

    private static void SaveGoals()
    {

    }

    private static void AddNewGoal()
    {
        Console.WriteLine("What type of goal do you want to add?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        string input = Console.ReadLine();

        Console.WriteLine("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Describe the goal: ");
        string name2 = Console.ReadLine();
        switch (input)
        {
            case "1":
                goals.Add(new SimpleGoal { Name = name });
                break;
            case "2":
                goals.Add(new EternalGoal { Name = name });
                break;
            case "3":
                Console.WriteLine("Enter the required count:");
                int requiredCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal { Name = name, RequiredCount = requiredCount });
                break;
            default:
                Console.WriteLine("Invalid input, try again.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Record a new event");
    }

    private static void LoadGoals()
    {
        goals.Clear();

        if (File.Exists(goalsFilePath))
        {
            using (StreamReader reader = new StreamReader(goalsFilePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalData = line.Split(';');

                    switch (goalData[0])
                    {
                        case "Simple":
                            goals.Add(new SimpleGoal { Name = goalData[1], Score = int.Parse(goalData[2]) });
                            break;
                        case "Eternal":
                            goals.Add(new EternalGoal { Name = goalData[1], Score = int.Parse(goalData[2]) });
                            break;
                        case "Checklist":
                            int completedCount = int.Parse(goalData[2]);
                            int requiredCount = int.Parse(goalData[3]);
                            goals.Add(new ChecklistGoal { Name = goalData[1], CompletedCount = completedCount, RequiredCount = requiredCount });
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type: {goalData[0]}");
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"File {goalsFilePath} does not exist.");
        }

    }
}

