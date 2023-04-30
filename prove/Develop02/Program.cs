using System;
using System.IO;

namespace JournalPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Journal";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<Entry> entries = new List<Entry>();
            int menuUserInput = 0;

            Console.Write("Welcome to your personal Journal Program!");

            while (menuUserInput != 5)
            {
                Console.WriteLine("\nPlease select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit" );

                int choice = int.Parse(Console.ReadLine());
                switch (menuUserInput)
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
                            Console.WriteLine("No entries found.");
                            break;
                        }

                        else
                        {
                            foreach (Entry e in entries)
                            {
                                Console.WriteLine($"There are {entries.Count} journal entries\n");
                                Console.WriteLine($"Date: {e.Date} - {e.Prompt}\nResponse: {e.Response}");
                            }
                        }                        

                        break;

                    case 3:
                        Console.WriteLine("Enter the filename to load journal entries:");
                        
                        break;

                    case 4:
                        Console.WriteLine("Enter a filename that you would like to save this journal to: ");

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
