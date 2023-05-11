using System;

namespace Develop02
{
    public class Prompt
    {
        public List<string> prompts = new List<string> {"What happened today?","What was the best thing that happened today?","What was the worst thing that happened today?",
        "What was the most interesting thing I saw or heard today?","What was the most challenging thing I faced today?","What am I grateful for today?",
        "What did I learn today?","What was the most fun thing I did today?","What was the most surprising thing that happened today?","What did I do today that I am proud of?"};

        public string SelectPrompt()
        {
            var random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}