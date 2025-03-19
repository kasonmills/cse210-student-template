using System;

namespace video;
class Video
{
    protected string _videoTitle;
    protected string _videoCreator;
    protected int _lenOfVid;
    List<Comment> comments = new List<Comment>();
    public Video(string video, string creator, int length)
    {
        _videoTitle = video;
        _videoCreator = creator;
        _lenOfVid = length;
    }
    public int GetNumOfComments()
    {
        return comments.Count;
    }

    private void SetVideo()
    {
        
    }

    private void GetVideo()
    {
        
    }
}