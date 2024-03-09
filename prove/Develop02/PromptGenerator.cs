using System;

namespace Journal
{
    static class PromptGenerator
    {
        public static string GetRandomPrompt()
        {
            // List of prompts
            List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

            Random rand = new Random();
            return prompts[rand.Next(prompts.Count)];
            
        }
    }
}