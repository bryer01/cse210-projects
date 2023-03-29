class Journal
{
    public List<string> prompts = new List<string>() {
        "What did you do today?",
        "What are you grateful for today?",
        "What are some challenges you faced today?"
    };
    public List<Entry> entries = new List<Entry>();

    public void add_entry(Entry entry)
    {
        entries.Add(entry);
    }

    public void display_entries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("{0} [{1}]: {2}", entry.prompt, entry.date, entry.response);
        }
    }

    public void save_to_file(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                sw.WriteLine("{0}|{1}|{2}", entry.prompt, entry.date, entry.response);
            }
        }
        Console.WriteLine("Journal saved to file: {0}", filename);
    }

    public void load_from_file(string filename)
    {
        entries.Clear();
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string prompt = parts[0];
                string date = parts[1];
                string response = parts[2];
                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded from file: {0}", filename);
    }
}