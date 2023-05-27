using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video
        {
            Title = "SM64 - Watch for Rolling Rocks - 0.5x A Presses (Commentated)",
            Author = "pannenkoek2012",
            Length = 90,
            Comments = new List<Comment>()
        };

        video1.Comments.Add(new Comment {UserName = "realtime", CommentText = "parallel universes"});
        video1.Comments.Add(new Comment {UserName = "Mswordx23", CommentText = "'Now, you're probably wondering what I'm gonna need all this speed for. After all, I do build up speed for 12 hours. But to answer that, we need to talk about parallel universes, and if you thought my other tangents were complicated, just you wait.' Such an iconic line."});
        video1.Comments.Add(new Comment {UserName = "PointCrow", CommentText = "fantastic video. iconic"});

        Video video2 = new Video
        {
            Title = "C# in 100 Seconds",
            Author = "FireShip",
            Length = 100,
            Comments = new List<Comment>()
        };

        video2.Comments.Add(new Comment {UserName = "chadkrause4694", CommentText = "C# is one of my favorite languages. The ease of multithreading/nonblocking calls makes it easy to squeeze a ton of performance out of it"});
        video2.Comments.Add(new Comment {UserName = "jawadsrour8490", CommentText = "great content, as always!"});
        video2.Comments.Add(new Comment {UserName = "Tsunami14", CommentText = "Glad it finally got featured"});

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("# of comments: " + video.NumberOfComments());
            Console.WriteLine("Comments: ");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine(comment.UserName + ": " + comment.CommentText);
            }

            Console.WriteLine();
        }
        Console.ReadLine();
        Console.Clear();
    }
}