
// Abstract Comment class
public abstract class Comment
{
    public string author { get; set; }
    public string text { get; set; }

    // Constructor
    public Comment(string author, string text)
    {
        this.author = author;
        this.text = text;
    }

    // Method to get the author of the comment
    public string GetAuthor()
    {
        return author;
    }

    // Method to get the text of the comment
    public string GetText()
    {
        return text;
    }
}