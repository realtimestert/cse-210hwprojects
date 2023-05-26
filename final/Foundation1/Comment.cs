using System;
public class Comment
{
    public string _name;
    public string _comment;

    public List<Video> _videos = new List<Video>();

    public void displayComment()
    {
        Console.WriteLine($"@{_name}");
        Console.WriteLine($"{_comment}");

        foreach(Video video in _videos)
        {
            video.DisplayVideo();
        }
    }

    /*public List<Comment> Comments;
    public NameGen NameGen;
    public CommentGen CommentGen;

    public Comment(NameGen nameGen, CommentGen commentGen)
    {
        Comments = new List<Comment>();
        NameGen = nameGen;
        CommentGen = commentGen;
    }

    public void NameComment()
    {
        string userName = NameGen.ChooseName();
        string userComment = CommentGen.ChooseComments();
        Console.WriteLine($"@{userName}");
        Console.WriteLine($"{userComment}");
    }*/
}