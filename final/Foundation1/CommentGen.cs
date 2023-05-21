using System;
using System.IO;

public class CommentGen
{
    public List<string> _comments;
    public CommentGen()
    {
        _comments = new List<string>()
        {
            "Thanks camera man for your sacrifices and educate us",
            "What if Japan was the same landmass as China(not suddenly)?",
            "Wow I've been curious with this scenario ever since I was a little kid.",
            "Congrats to the guy who tested this for us so we didn't have to do it.",
            "I had almost forgotten this series was still going!",
            "Now, you're probably wondering what I'm gonna need all this speed for. After all, I do build up speed for 12 hours. But to answer that, we need to talk about parallel universes, and if you thought my other tangents were complicated, just you wait.",
            "fantastic video. iconic",
            "It will always blow my mind how we got one of the greatest videos on YouTube simply because people don't read the description section.",
            "this is -  without exaggeration and with all possible sincerity -  one of the best videos I have ever watched",
            "Video needs to be on 24hr loop at the Guggenheim as a work of contemporary art.",
            "brb gonna prank my dad by standing in a corner and scuffing my shoe at incredibly precise intervals for 39 days straight until the universe collapses."
        };
    }

    public string ChooseComments()
    {
        Random rand = new Random();
        int index = rand.Next(_comments.Count);
        return _comments[index];
    }
}