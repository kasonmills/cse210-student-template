using System;

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
    public void SetCommentorName()
    {

    }

    private void SetComment()
    {

    }
}