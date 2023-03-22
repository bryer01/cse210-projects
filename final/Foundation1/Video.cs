// Abstract Video class
public abstract class Video
{
    public string title { get; set; }
    public string author { get; set; }
    public int length { get; set; }
    public List<Comment> comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    // Abstract method for displaying video information
    public abstract void DisplayInfo();

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
}