using System;

namespace video;

class Comment
{
    private string _name;
    private string _comment;
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
    public string GetCommentorName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _comment;
    }
}