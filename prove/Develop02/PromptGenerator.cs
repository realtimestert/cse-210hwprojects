using System;
using System.IO;

class PromptGenerator
{
    static void Main(string[] args)
    {        
        string[] allLines = File.ReadAllLines(@"C:\Users\evans\Documents\cse-210hwprojects\prove\Develop02\prompts.txt");
        Random rnd1 = new Random();
        Console.WriteLine(allLines[rnd1.Next(allLines.Length)]);
    }
}

