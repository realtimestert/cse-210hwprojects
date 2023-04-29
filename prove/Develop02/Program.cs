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

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit" );

            int choice = int.Parse(Console.ReadLine());
        }
    }
}