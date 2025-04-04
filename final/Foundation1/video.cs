using System;

namespace video;
class Video
{
    protected string _videoTitle;
    protected string _videoCreator;
    protected int _lenOfVid;
    List<Comment> _comments = new List<Comment>();
    public Video(string video, string creator, int length, List<Comment> comments)
    {
        _videoTitle = video;
        _videoCreator = creator;
        _lenOfVid = length;
        _comments = comments;
    }
    public int GetNumOfComments()
    {
        return _comments.Count;
    }

    private void SetVideo()
    {
        
    }

    private void GetVideo()
    {
        
    }
}