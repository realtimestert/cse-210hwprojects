using System;

public class NetTube
{
    public List<Video> _video = new List<Video>();
    public List<Comment> _comment = new List<Comment>();

    public void Display()
    {
        foreach (Video video in _video)
        {
            video.DisplayVideo();
        }
        foreach (Comment comment in _comment)
        {
            comment.displayComment();
        }
    }
}