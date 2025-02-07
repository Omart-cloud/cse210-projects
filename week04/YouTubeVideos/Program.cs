using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating BYU programming-related video objects
        Video video1 = new Video("BYU Computing Bootcamp", "BYU", 1200);
        Video video2 = new Video("BYU Software Engineering Overview", "BYU Computer Science", 900);
        Video video3 = new Video("BYU Supercomputing Debugging Guide", "BYU Supercomputing", 1100);

        // Adding comments to videos
        video1.AddComment(new Comment("User1", "This helped me understand coding better!"));
        video1.AddComment(new Comment("User2", "Great introduction to computing!"));
        video1.AddComment(new Comment("User3", "Very informative and well explained."));

        video2.AddComment(new Comment("User4", "Software engineering is so interesting!"));
        video2.AddComment(new Comment("User5", "I love how this breaks down the concepts."));
        video2.AddComment(new Comment("User6", "Well-structured and easy to follow."));

        video3.AddComment(new Comment("User7", "Supercomputing is fascinating!"));
        video3.AddComment(new Comment("User8", "Great debugging techniques."));
        video3.AddComment(new Comment("User9", "Thanks for sharing this content!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details
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
