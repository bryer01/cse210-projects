public class Entry
{


    public string Prompt;
    public string Response;
    public string DateTime;


    public Entry()
    {

    }

    public void Add()

    {
        List<string> prompts = new List<string>()

        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);

        Prompt = prompts[randomIndex];

        Console.WriteLine("Random Prompt: " + Prompt);




        Console.WriteLine("Write whatever you'd like: ");
        Response = Console.ReadLine();
        DateTime dateTime = new DateTime();
        DateTime = dateTime.ToString("dd/MM/yyyy");

    }
}