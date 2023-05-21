public class Comment
{
    public List<Comment> Comments;
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
    }
}