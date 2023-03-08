class BreathingExercise : TimedActivity
{
    protected override string Name { get { return "Breathing Exercise"; } }

    protected override void RunInternal()
    {
        Console.Write("Enter the duration of the exercise (in seconds): ");
        Time = int.Parse(Console.ReadLine());

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        StartCountdown();

        while (IsRunning)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(3000);
        }
    }
}