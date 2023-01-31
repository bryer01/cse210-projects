using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop == true)
        {
            Console.WriteLine("Please choose one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string userinput = Console.ReadLine() ?? "";
            {
                Random random = new Random();
                int randomIndex = random.Next(0, prompts.Count);

                string randomPrompt = prompts[randomIndex];

                Console.WriteLine("Random Prompt: " + randomPrompt);

                List<JournalEntry> journal = new List<JournalEntry>();

            }

            if (userinput == "1")
            {
                Console.WriteLine("You have selected number 1");
            }
            else if (userinput == "2")
            {
                Console.WriteLine("You have selected number 2");
            }
            else if (userinput == "3")
            {
                Console.WriteLine("You have selected number 3");
            }
            else if (userinput == "4")
            {
                Console.WriteLine("You have selected number 4");
            }
            else
            {
                loop = false;
            }
        }
    }
    List<string> prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };






    class Journal

    {
        public void Save(string fileName)
        {

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");


            }
        }

        public void Load(string fileName)
        {

            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
        }
        public void Display()
        {
            DateTime theCurrentTime = DateTime.Now;
            Console.ReadLine();


        }
        public class AddEntry
        {
            private object convert;

            public List<Entry> Entries { get; set; }
            public string Prompt { get; private set; }
            public string Response { get; private set; }
            public DateTime Date { get; private set; }

            public AddEntry()
            {
                Entries = new List<Entry>();
            }

            public void Add(string prompt, string response)
            {
                AddEntry entry = new AddEntry();
                entry.Prompt = prompt;
                entry.Response = response;
                entry.Date = DateTime.Now;
            }

        }

        public class Entry { }

    }
}