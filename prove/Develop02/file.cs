using System.IO;
using System;

namespace Develop02
{
    /// <summary>
    /// The responsibility of File is to save and load journal entries.
    /// </summary>
    public class File
    {
      public string fileName = "journal.csv";

        public void SaveJournal(Journal journal)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in journal.GetEntries())
                {
                    outputFile.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}|");
                }
            }
            Console.WriteLine("Journal saved.");
        }

        public Journal LoadJournal()
        {
            string fileName = "journal.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            Journal journal = new Journal();
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Entry entry = new Entry();
                entry.StoreDate(parts[0]);
                entry.StorePrompt(parts[1]);
                entry.StoreResponse(parts[2]);
                journal.StoreEntry(entry); 
            }
            Console.WriteLine("Journal loaded.");
            return journal;
        }
    }
}