using System.Collections.Generic;


namespace Develop02
{
    /// <summary>
    /// The responsibility of an Entry is to store a prompt, response, and date.
    /// </summary>
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;

        public List<string> prompts;

        public Entry()
        {
            prompts = new List<string>();
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            prompts.Add("What is one thing I learned today?");
        }

        public string GetPrompt()
        {
            return prompt;
        }
        public string GetResponse()
        {
            return response;
        }
        public string GetDate()
        {
            return date;
        }
        public void StorePrompt(string prompt)
        {
            this.prompt = prompt;
        }
        public void StoreResponse(string response)
        {
            this.response = response;
        }
        public void StoreDate(string date)
        {
            this.date = date;
        }

    }
}