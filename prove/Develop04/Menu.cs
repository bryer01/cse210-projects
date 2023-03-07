using System;

class Menu : Activity
{
    static void Main(string[] args)
    {

        Console.WriteLine("Choose an Activity: ");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");

        int activityNumber = int.Parse(Console.ReadLine());

        if (activityNumber == 1)
        {
            BreathingExercise exercise = new BreathingExercise();
            exercise.Run();
        }
        else if (activityNumber == 2)
        {
            ReflectionExercise exercise = new ReflectionExercise();
            exercise.Run();
        }
        else if (activityNumber == 3)
        {
            ListingExercise exercise = new ListingExercise();
            exercise.Run();
        }
        else
        {
            Console.WriteLine("Invalid activity number.");
        }
    }

    public override void Run()
    {
        throw new NotImplementedException();
    }
}

