using System;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\evans\Documents";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        List<Entry> entries = new List<Entry>();

        Console.Write("Welcome to the Journal Program!");
        
        Console.WriteLine("Please select one of the following choices: ");

        while (true)
        {
            Console.WriteLine("\nWrite: \n1" );

            int choice = int.Parse(Console.ReadLine());
        }
    }
}