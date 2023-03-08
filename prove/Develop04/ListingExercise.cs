class ListingExercise : TimedActivity
{
    public ListingExercise()
    {
        Time = 30;
    }

    protected override string Name { get { return "Listing Exercise"; } }

    private int count = 0;

    protected override void RunInternal()
    {
        Console.WriteLine("Think of a category, such as types of animals, countries, or books.");
        Console.WriteLine("Write down as many items in that category as you can in 30 seconds.");

        Console.Write("Press any key to start...");
        Console.ReadKey();

        Console.WriteLine("\n30 seconds on the clock...");

        StartActivity();

        while (IsRunning)
        {
            // Do nothing.
        }

        Console.WriteLine("Time's up!");

        Console.Write("How many items did you list? ");
        count = int.Parse(Console.ReadLine());

        Console.WriteLine($"You listed {count} items.");

        if (count <= 5)
        {
            Console.WriteLine("That's a good start! Keep practicing to improve your brainstorming skills.");
        }
        else if (count <= 10)
        {
            Console.WriteLine("Great job! You're off to a good start.");
        }
        else if (count <= 15)
        {
            Console.WriteLine("Wow, that's impressive! You have a talent for brainstorming.");
        }
        else
        {
            Console.WriteLine("Amazing! You're a master brainstormer.");
        }
    }
}