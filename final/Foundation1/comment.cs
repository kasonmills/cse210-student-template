using System;

class Comment
{
    public List<string> CreateNewComment()
    {
        List<string> aComment;
        aComment.Add(CreateCommentorName());
        aComment.Add(CreateComment());
        return aComment;
    }

    private string CreateCommentorName()
    {
        Console.WriteLine("Please input a name for a commentor: ");
        string name = Console.ReadLine();
        return name;
    }
    public int GetNumComments()
    {
        // I am not too sure where this is going to be... 12/5
        return 0;
    }

    private string CreateComment()
    {
        Console.WriteLine("Please create a comment that the named person said. ");
        string comment = Console.ReadLine();
        return comment;
    }
}