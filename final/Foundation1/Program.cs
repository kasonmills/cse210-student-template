using System;

class Program
{
    // I could do it that each item is just a list for each individual item and then make sure that the item in the list matches the number of comment and length in placement...
    // so I need a list of authors, a list of titles, a list of lengths, and a list of comments for each one...
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Video video = new Video();
        Comment comment = new Comment();
        video.CreateNewVideo();
        comment.CreateNewComment();
        Console.WriteLine("It worked!");
    }

    void DisplayVideoBank()
    {
        // I will need this for the whole program to work...
    }
}