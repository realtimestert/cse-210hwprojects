using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference scriptureReference = new Reference("Genesis", "1", "1", "2");
        Scripture scripture = new Scripture(scriptureReference, "In the beginning God created the heaven and the earth." +
        "And the earth was without form, and void; and darkness was upon the face of the deep." + 
        "And the Spirit of God moved upon the face of the waters");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();

            Console.Write("Press 'Enter' to continue or press 'quit' to close out the program");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.GetScripture());
    }
}