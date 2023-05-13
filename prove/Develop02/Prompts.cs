using System;
using System.Collections.Generic;

namespace develop02 {

    public class Prompts
    {
        public List<string> promptList = new List<string>
        { "Who was the most interesting person I interacted with today?", "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?", "Did you see a cat today?",
         "Hows your girl?" };

         public string GetRandomPrompt()
         {
            var random = new Random();
            int index = random.Next(promptList.Count);
            return promptList[index];
         }
    }
}