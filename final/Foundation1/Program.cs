using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create some videos and add comments
        Video video1 = new Video("Dogs", "John Doe", 120);
        video1.AddComment(new Comment("Jane Smith", "Great video!"));
        video1.AddComment(new Comment("Bob Johnson", "I loved it!"));
        video1.AddComment(new Comment("Sally Mae", "So cute!"));

        Video video2 = new Video("Cats", "Thomas Newton", 35);
        video2.AddComment(new Comment("Joe Egg", "Awesome video!"));
        video2.AddComment(new Comment("Cody Newton", "Great job!"));
        video2.AddComment(new Comment("Prince Ali", "Adorable!"));

        Video video3 = new Video("Birds", "Billy Bones", 60);
        video3.AddComment(new Comment("Lane Devogue", "Beautiful!"));
        video3.AddComment(new Comment("Bill Johnson", "Amazing!"));
        video3.AddComment(new Comment("Ellen Smith", "Fantastic!"));
        video3.AddComment(new Comment("Arnold Dillon", "Impressive!"));

        // Store the videos in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display the video information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}



