using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        /* Creating video objects */
        Video video1 = new Video("Intro to AI", "John Doe", 600);
        Video video2 = new Video("Machine Learning Basics", "Jane Smith", 750);
        Video video3 = new Video("Deep Learning Explained", "Alice Johnson", 900);

        /* Adding comments to videos */
        video1.AddComment(new Comment("User1", "Great explanation!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "Helped me a lot!"));

        video2.AddComment(new Comment("User4", "Nice breakdown of concepts."));
        video2.AddComment(new Comment("User5", "I finally understand ML!"));
        video2.AddComment(new Comment("User6", "Well structured and clear."));

        video3.AddComment(new Comment("User7", "Deep learning is fascinating!"));
        video3.AddComment(new Comment("User8", "Amazing content."));
        video3.AddComment(new Comment("User9", "Thanks for this video!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        /* Display video details */
        foreach (var video in videos)
        {
            Console.WriteLine($"\nTitle: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }
    }
}

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        LengthInSeconds = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

public class Comment
{
    public string CommenterName { get; }
    public string Text { get; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
