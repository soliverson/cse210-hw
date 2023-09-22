using System;
using System.Collections.Generic;


namespace Develop02
{

    class Program
    {
        static void Main(string[] args)
        {
           // provide a menu to the user to choose between writing and entry, displaying the entries, saving the entries, and loading the entries and a quit option.
            Journal journal = new Journal();
            File file = new File();
            bool loop = true;
            while (loop)
            {
            Console.WriteLine("Welcome to your journal.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Entry entry = new Entry();
                Console.WriteLine("What is the date?(MM/DD/YYYY)");
                string date = Console.ReadLine();
                entry.StoreDate(date);
                int promptNum = new Random().Next(0, 5);
                Console.WriteLine($"{entry.prompts[promptNum]}");
                string response = Console.ReadLine();
                entry.StoreResponse(response);
                journal.StoreEntry(entry);
            }
            else if (choice == "2")
            {
                List<Entry> entries2 = journal.GetEntries();
                foreach (Entry entry in entries2)
                {
                    string message 
                        = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                    Console.WriteLine(message);
                }
            }
            else if (choice == "3")
            {
                file.SaveJournal(journal);
            }
            else if (choice == "4")
            {
                journal = file.LoadJournal();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye.");
                loop = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
           
           
           
           
           
           
           
           
           
           
           
    
            }



        }
    }
}