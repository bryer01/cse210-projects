internal class JournalEntry
{
    public string prompt;
    public string response;
    public DateTime now;

    public JournalEntry(string prompt, string response, DateTime now)
    {
        this.prompt = prompt;
        this.response = response;
        this.now = now;
    }
}