using System;
using System.IO;

namespace JournalPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal(new PromptGenerator());
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
                        journal.CreateJournalEntry();
                        break;

                    case 2:                    
                        journal.DisplayJournalEntries();
                        break;

                    case 3:
                        journal.LoadFromCsv();
                        break;

                    case 4:
                        journal.CreateJournalEntry();
                        break;

                    case 5:
                        Console.WriteLine("Goodbye.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}
