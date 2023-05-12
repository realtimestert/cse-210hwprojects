using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        Reference scriptureReference = new Reference("Genesis", "1","1");
        Scripture scripture = new Scripture(scriptureReference, "In the beginning God created the heaven and the earth");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();

            Console.Write("Type 'Enter' to continue or type 'quit' to close out the program. ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine("Good job with memorizing the scripture!");
    }
}