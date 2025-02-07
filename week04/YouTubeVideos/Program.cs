using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // YouTube Video Abstraction Program
        YouTubeVideo video = new YouTubeVideo("Intro to AI", "https://youtube.com/video123", 600);
        TranscriptExtractor extractor = new TranscriptExtractor(video);
        string transcript = extractor.GetTranscript();

        TextProcessor processor = new TextProcessor();
        string cleanedTranscript = processor.CleanText(transcript);

        Summarizer summarizer = new Summarizer();
        string summary = summarizer.GenerateSummary(cleanedTranscript);

        ReportGenerator reportGenerator = new ReportGenerator();
        reportGenerator.GenerateReport(video, summary);

        Console.WriteLine("\n--- Abstraction Program Execution Complete ---\n");
    }
}

public class YouTubeVideo {
    public string Title { get; }
    public string Url { get; }
    public int DurationInSeconds { get; }

    public YouTubeVideo(string title, string url, int duration) {
        Title = title;
        Url = url;
        DurationInSeconds = duration;
    }
}

public class TranscriptExtractor {
    private YouTubeVideo _video;
    public TranscriptExtractor(YouTubeVideo video)
    {
        _video = video;
    }

    public string GetTranscript()
    {
        Console.WriteLine($"Fetching transcript for: {_video.Title}");
        return _FetchFromAPI();
    }

    private string _FetchFromAPI()
    {
        return "This is a sample transcript. The video explains AI concepts in a simple way.";
    }
}

public class TextProcessor
{
    public string CleanText(string text)
    {
        Console.WriteLine("Cleaning transcript...");
        return text.ToLower().Replace(".", "").Replace(",", "");
    }
}

public class Summarizer
{
    public string GenerateSummary(string text)
    {
        Console.WriteLine("Generating summary...");
        var words = text.Split(' ');
        return string.Join(" ", words.Take(words.Length / 2)) + "...";
    }
}

public class ReportGenerator
{
    public void GenerateReport(YouTubeVideo video, string summary)
    {
        Console.WriteLine("\n--- Summary Report ---");
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"URL: {video.Url}");
        Console.WriteLine($"Duration: {video.DurationInSeconds} seconds");
        Console.WriteLine($"Summary: {summary}");
    }
}
