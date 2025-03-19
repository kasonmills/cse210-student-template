using System;


namespace video;
class Program
{
    // I could do it that each item is just a list for each individual item and then make sure that the item in the list matches the number of comment and length in placement...
    // so I need a list of authors, a list of titles, a list of lengths, and a list of comments for each one...
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Foundation1 World!");
        List<Comment> com = new List<Comment>();
        Video video = new Video("I built the largest beacon in minecraft", "Kolanni", 500);
        Comment comment = new Comment("kason", "wooooow sooooo cooool!");
        com.Add(comment);

        List<Comment> com2 = new List<Comment>();
        Video video1 = new Video("", "", 0);
        Comment comment1 = new Comment("", "");
        Comment comment2 = new Comment("", "");
        Comment comment3 = new Comment("", "");
        com2.Add(comment1);
        com2.Add(comment1);
        com2.Add(comment3);

        List<Comment> com3 = new List<Comment>();
        Video video2 = new Video("", "", 0);
        Comment comment4 = new Comment("", "");
        Comment comment5 = new Comment("", "");
        Comment comment6 = new Comment("", "");
        Comment comment7 = new Comment("", "");
        com3.Add(comment4);
        com3.Add(comment5);
        com3.Add(comment6);
        com3.Add(comment7);

        List<Comment> com4 = new List<Comment>();
        Video video3 = new Video("", "", 0);
        Comment comment8 = new Comment("", "");
        Comment comment9 = new Comment("", "");
        com4.Add(comment8);
        com4.Add(comment9);

        List<Video> vids = new List<Video>();

        vids.Add(video);
        vids.Add(video1);
        vids.Add(video2);
        vids.Add(video3);

        foreach(Video vid in vids)
        {
            Console.WriteLine(vid);
            // I need a for loop to loop through each video, displaying, name, author, and length
            // then I needs to display the number of contents
            // then I need to loop through each comment on that video
        }
    }
}