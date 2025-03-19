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
    private string GetCommentorName()
    {
        return _name;
    }

    private string GetComment()
    {
        return _comment;
    }
    private void SetCommentorName()
    {
        _name = _name;
    }

    private void SetComment()
    {

    }
}