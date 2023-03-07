using System.IO;

class ReflectionExercise : Activity
{
    public override void Run()
    {
        Console.WriteLine("Welcome to the Reflection Exercise!");

        Console.WriteLine("Think about a recent experience that was meaningful to you.");
        Console.WriteLine("Write down your thoughts and feelings about this experience.");

        Console.Write("Press any key to continue...");
        Console.ReadLine();

        Console.WriteLine("\nNow think about what you learned from this experience.");
        Console.WriteLine("Write down your insights and conclusions.");


        Console.Write("Press any key to continue...");
        Console.ReadLine();

        Console.WriteLine("/nFinally, think about how you can apply what you learned to your life going forward.");
        Console.WriteLine("Write down some concrete actions you can take to put your insights.");
    }
}