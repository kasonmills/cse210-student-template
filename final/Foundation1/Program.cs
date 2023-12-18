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
        List<object> vids = video.CreateNewVideo();
        List<string> oneComment = comment.CreateNewComment();
        List<object> titles;
        List<object> authors;
        List<object> videoLengths;
        List<string> namesOfCommentors;
        List<string> CommentsMade;

        Console.WriteLine("How many video's would you like to create? ");
        string amount = Console.ReadLine();
        int number = int.Parse(amount);

        Console.WriteLine("How many comments would you like on each video? ");
        string com = Console.ReadLine();
        int numComments = int.Parse(com);

        for(int a = 0; a < number; a++)
        {
            titles.Add(vids[0]);
            authors.Add(vids[1]);
            videoLengths.Add(vids[2]);
            for(int b = 0; b < numComments; b++)
            {
                namesOfCommentors.Add(oneComment[0]);
                CommentsMade.Add(oneComment[1]);
            }
            
        }
        
        // test code
        // Console.WriteLine(titles[0]);
        DisplayVideoBank();
    }

    void DisplayVideoBank()
    {
        // I will need this for the whole program to work...
    }
}