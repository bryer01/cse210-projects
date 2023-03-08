using System;

static class Menu
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an Activity: ");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");

        int activityNumber = int.Parse(Console.ReadLine());

        Activity? exercise = null;

        switch (activityNumber)
        {
            case 1:
                exercise = new BreathingExercise();
                break;
            case 2:
                exercise = new ReflectionExercise();
                break;
            case 3:
                exercise = new ListingExercise();
                break;
            default:
                Console.WriteLine("Invalid activity number.");
                break;
        }

        if (exercise != null)
        {
            exercise.Run();
        }
    }
}

