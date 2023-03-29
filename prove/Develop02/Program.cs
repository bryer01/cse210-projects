class Program
{
    private Journal journal = new Journal();

    public void run()
    {
        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = journal.prompts[new Random().Next(journal.prompts.Count)];
                Console.Write(prompt + "\n");
                string response = Console.ReadLine();
                string date = DateTime.Today.ToString("yyyy-MM-dd");
                Entry entry = new Entry(prompt, response, date);
                journal.add_entry(entry);
            }
            else if (choice == "2")
            {
                journal.display_entries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What file would you like to save to?");
                string filename = Console.ReadLine();
                journal.save_to_file(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What file would you like to load from?");
                string filename = Console.ReadLine();
                journal.load_from_file(filename);
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }
}