public class VideoClass
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<CommentClass> Comments { get; set; }

    // Constructor
    public VideoClass(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<CommentClass>();
    }

    // Add a comment to the video
    public void AddComment(CommentClass comment)
    {
        Comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine("Comments:");

        foreach (CommentClass comment in Comments)
        {
            Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
        }
    }
}