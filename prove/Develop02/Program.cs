using System;
using System.IO;

namespace JournalPrompt{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\evans\Documents\cse-210hwprojects";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(@"C:\Users\evans\Documents\cse-210hwprojects");
            }

            List<Entry> entries = new List<Entry>();

            Console.Write("Welcome to your personal Journal Program!");

            while (true)
            {
                Console.WriteLine("\nPlease select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit" );

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("Enter a prompt");
                        //string prompt = Console.ReadLine();

                        PromptGenerator prompt = new PromptGenerator();
                        
                        Console.WriteLine("Enter a response: ");
                        string response = Console.ReadLine();

                        Entry entry = new Entry(response, DateTime.Now);
                        entries.Add(entry);

                        Console.WriteLine("Entry added.");
                        break;

                    case 2:
                        if (entries.Count ==0)
                        {
                            Console.WriteLine("Nothing here.");
                            break;
                        }
                        
                        Console.WriteLine($"There are {entries.Count} journal entries\n");

                        foreach (Entry e in entries)
                        {
                            Console.WriteLine($"Date: {e.Date}\nResponse: {e.Response}");
                        }

                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Goodbye.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
