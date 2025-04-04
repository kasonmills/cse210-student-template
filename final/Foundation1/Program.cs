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
        Video video = new Video("I built the largest beacon in minecraft", "Kolanni", 500, com);
        Comment comment = new Comment("kason", "wooooow sooooo cooool!");
        com.Add(comment);

        List<Comment> com2 = new List<Comment>();
        Video video1 = new Video("banana being smushed", "monke", 15, com2);
        Comment comment1 = new Comment("tom", "Why is it red?");
        Comment comment2 = new Comment("jack", "who decided it needed to have shaky cam?");
        Comment comment3 = new Comment("gorilla", "bananas are ok");
        com2.Add(comment1);
        com2.Add(comment1);
        com2.Add(comment3);

        List<Comment> com3 = new List<Comment>();
        Video video2 = new Video("slime tutorial", "crazykiwij1", 1573, com3);
        Comment comment4 = new Comment("Jake", "wait how much slime did you make?");
        Comment comment5 = new Comment("bobcat", "I bet that isn't washing out of the carpet");
        Comment comment6 = new Comment("carl", "did anyone else notice the guy was wearing a big bird costume the whole time?");
        Comment comment7 = new Comment("sadcocunut", "I just love making slime");
        com3.Add(comment4);
        com3.Add(comment5);
        com3.Add(comment6);
        com3.Add(comment7);

        List<Comment> com4 = new List<Comment>();
        Video video3 = new Video("is it possible to beat minecraft without...", "font-template=here", 45375, com4);
        Comment comment8 = new Comment("woundedlight", "He had me in the first half not going to lie");
        Comment comment9 = new Comment("alf", "people really need to go outside and touch grass");
        com4.Add(comment8);
        com4.Add(comment9);

        List<Video> vids = new List<Video>();

        vids.Add(video);
        vids.Add(video1);
        vids.Add(video2);
        vids.Add(video3);

        foreach(Video vid in vids)
        {
            Console.WriteLine(vid.GetTitle());
            Console.WriteLine(vid.GetCreatorName());
            Console.WriteLine(vid.GetLengthOfVideo());
            Console.WriteLine(vid.GetNumOfComments());
            com = vid.GetComments();
            foreach (Comment cim in com)
            {
                Console.WriteLine(cim.GetCommentorName());
                Console.WriteLine(cim.GetComment());
            }
            // I need a for loop to loop through each video, displaying, name, author, and length
            // then I needs to display the number of contents
            // then I need to loop through each comment on that video
        }
    }
}