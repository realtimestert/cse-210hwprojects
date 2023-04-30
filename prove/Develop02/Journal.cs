using System;
using System.IO;
using System.Collections.Generic;

class Journal
{
    static void Main(string[] args){}
        public List<Entry> Entries;
        public PromptGenerator PromptGenerator;
        public Journal(PromptGenerator promptGenerator)
        {
            Entries = new List<Entry>();
            PromptGenerator = promptGenerator;
        }

        public void DisplayJournalEntries()
        {
            int count = 0;
            if (Entries.Count ==0)
            {
                Console.WriteLine("No entries in the journal.");
            }

            else
            {
                foreach(Entry entry in Entries)
                {
                    Console.WriteLine($"Entry #{++count}:");
                    entry.DisplayEntry();
                }
                Console.WriteLine($"Total entries: {Entries.Count}\n");
            }
        }
        
        public void CreateJournalEntry()
        {
            DateTime currentDate = DateTime.Now.Date;
            string prompt = PromptGenerator.ChoosePrompt();

            Console.WriteLine($"{prompt}");
            string response = Console.ReadLine();

            Entry entry = new Entry(currentDate.ToString("MM/dd/yyyy"), prompt, response);
            Entries.Add(entry);

            Console.WriteLine("Entry added to journal.");
        }

        public interface SaveToCsv()
        {
            if (Entries.Count == 0)
            {
                Console.WriteLine("Nothing to save");
                return 0;
            }
        }
}