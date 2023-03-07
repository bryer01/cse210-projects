class BreathingExercise : Activity
{
    public BreathingExercise()
    {
        StartMessage = "Welcome to the Breathing Exercise";
    }

    public override void Run()
    {
        Console.WriteLine("You have chosen 1 \n");
        Console.WriteLine("Welcome to the Breathing Exercise!");

        Console.Write("Enter the duration of the exercise (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int countdown = 3;
        Console.WriteLine($"Starting in {countdown}...");
        System.Threading.Thread.Sleep(1000);
        countdown--;

        while (countdown > 0)
        {
            Console.WriteLine(countdown + "...");
            System.Threading.Thread.Sleep(1000);
            countdown--;
        }

        Console.WriteLine("Breathe in...");
        System.Threading.Thread.Sleep(3000);

        countdown = duration - 6; // 6 seconds taken by the inhale/exhale messages
        while (countdown > 0)
        {
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(3000);
            countdown -= 6;
        }

        Console.WriteLine("Great job! You've completed the Breathing Exercise.");
    }
}