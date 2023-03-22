using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create some videos and add comments
        VideoClass video1 = new VideoClass("Dogs", "John Doe", 120);
        video1.AddComment(new CommentClass("Jane Smith", "Great video!"));
        video1.AddComment(new CommentClass("Bob Johnson", "I loved it!"));
        video1.AddComment(new CommentClass("Sally Mae", "So cute!"));

        VideoClass video2 = new VideoClass("Cats", "Sally Mae", 35);
        video2.AddComment(new CommentClass("Joe Egg", "Awesome video!"));
        video2.AddComment(new CommentClass("Cody Newton", "Great job!"));
        video2.AddComment(new CommentClass("John Doe", "Adorable!"));

        VideoClass video3 = new VideoClass("Birds", "Jane Smith", 60);
        video3.AddComment(new CommentClass("Sally Mae", "Beautiful!"));
        video3.AddComment(new CommentClass("Bob Johnson", "Amazing!"));
        video3.AddComment(new CommentClass("Jane Smith", "Fantastic!"));
        video3.AddComment(new CommentClass("John Doe", "Impressive!"));

        // Store the videos in a list
        List<VideoClass> videos = new List<VideoClass>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display the video information
        foreach (VideoClass video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}
