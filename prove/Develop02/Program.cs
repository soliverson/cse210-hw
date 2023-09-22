using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Mail;
namespace WindowsApplication1;

class Program
{
    static void Main(string[] args)
    
    {
        
        PromptGenerator gen1 = new PromptGenerator();
        gen1._prompts.Add("What was the most exciting part of your day?");
        gen1._prompts.Add("Who did you talk with today?");
        gen1._prompts.Add("How can you make tomorrow a better day?");
        gen1._prompts.Add("What teaching moments can you take from today?");
        gen1._prompts.Add("What was something funny that happened today?");

        Journal daily = new Journal();

        string choice = "";

        do 
        {
            Console.WriteLine("Please select one of the following choices: ");
            List<string> options = new List<string> {"1.Write", "2.Display", "3.Load", "4.Save", "5.Quit"};
            foreach (string option in options) 
            {
                Console.WriteLine(option);
            }

                choice = Console.ReadLine();

            if (choice == "1") 
            {

                DateTime current = DateTime.Now;
                Entry ent1 = new Entry();
                ent1._promptText = gen1.GetRandomPrompt();
                ent1._date = current.ToShortDateString();


                Console.Write(ent1._promptText);
                ent1._entryText = Console.ReadLine();               
                daily._entries.Add(ent1);

            } 
            else if (choice == "2")
            {
                daily.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();

                daily._entries = daily.LoadFromFile(name);         
                
                
            } else if (choice == "4")
            
            {
                daily.SaveToFile(daily._entries);   
            }

                        
        } while (choice != "5");
        
    
    }
}
