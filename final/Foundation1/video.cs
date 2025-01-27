using System;

class Video
{
    private string _videoTitle;
    private string _videoCreator;
    private int _lenOfVid;
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