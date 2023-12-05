using System;

class Video
{
    public List<object> CreateNewVideo()
    {
        List<object> videoDetails;
        videoDetails.Add(CreateNewVideoTitle());
        videoDetails.Add(CreateNewVideoAuthor());
        videoDetails.Add(CreateNewVideoLength());
        return videoDetails;
    }

    private string CreateNewVideoTitle()
    {
        Console.WriteLine("Please input a title of a new video: ");
        string title = Console.ReadLine();
        return title;
    }

    private string CreateNewVideoAuthor()
    {
        Console.WriteLine("Please input a creator of the new video: ");
        string author = Console.ReadLine();
        return author;
    }

    private int CreateNewVideoLength()
    {
        Console.WriteLine("What is the length of the new video (time in seconds): ");
        string input = Console.ReadLine();
        int length = int.Parse(input);
        return length;
    }
}