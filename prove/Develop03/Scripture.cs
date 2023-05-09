using System;

class Scripture
{
    public string Reference;
    public GetScripture()
    {
        Writeit = Console.WriteLine("I will go and do");
        return Writeit;
    }
    public string words;

    bool HasWordsLeft = true;

    static void Main(string[] args)
    {
        GetScripture Nephi = new GetScripture();
        Console.WriteLine(Nephi.GetScripture);
    }
    
}