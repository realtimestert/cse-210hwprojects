using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Comment comment1 = new Comment();
        video1._title = "Epic Video";
        video1._author = "Some Guy";
        video1._length = 90;
        comment1._name = "realtime";
        comment1._comment = "parallel universes";

        Video video2 = new Video();
        Comment comment2 = new Comment();
        

        NetTube netTube = new NetTube();

        netTube.Display();

    }
}