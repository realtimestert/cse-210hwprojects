public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} \nBy {_author} \n{_length} seconds");
    }
}