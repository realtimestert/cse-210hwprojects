using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<string> words = new List<string>();
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine($"There are {words.Count} words in the list.");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
    
}