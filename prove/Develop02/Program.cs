using System;
using System.IO;

class Program
{
        static void Main(string[] args)
        {
        Journal journal = new Journal(new PromptGenerator());
        int menuUserInput = 0;

        List<string> menu = new List<string>
        {
        "Please select one of the following choices:",
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit",
        "What would you like to do?"
        };

            Console.Write("Welcome to your personal Journal Program!");

            while (menuUserInput != 5)
            {
                foreach (string menuItem in menu)
                {
                    Console.WriteLine(menuItem);
                }

                try
                {
                    menuUserInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                //Console.WriteLine("\nPlease select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit" );

                //int choice = int.Parse(Console.ReadLine());
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
                        journal.SaveToCsv();
                        break;

                    case 5:
                        Console.WriteLine("Goodbye.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                        break;
            }
        }
    }
}