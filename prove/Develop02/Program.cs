using System;
using System.IO;

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
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a prompt");
                    string prompt = Console.ReadLine();
                    
                    Console.WriteLine("Enter a response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry(prompt, response, DateTime.Now);
            }
        }
    }
}