using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Develop04
{

    class Breathing : Activity
    {
        private string _activityName = "Breathing";
        private List<string> _prompts = new List<string>()
        {
            "Breathe in...",
            "Breathe out..."
        };

        // Performs the breathing activity
        public void PerformActivity()
        {
            string introMessage = Start(_activityName, "Take a deep breath and exhale slowly.");
            Console.WriteLine(introMessage);

            int duration = GetDuration();

            Console.WriteLine("Prepare to begin...");
            System.Threading.Thread.Sleep(3000); // Pause for 3 seconds

            Console.WriteLine("Starting activity...");

            int countdownDuration = duration;
            Random random = new Random();

            while (countdownDuration > 0)
            {
                string prompt = _prompts[random.Next(_prompts.Count)];
                Console.WriteLine(prompt);

                System.Threading.Thread.Sleep(2000); // Pause for 2 seconds

                countdownDuration -= 2;
            }

            System.Threading.Thread.Sleep(3000); // Pause for 3 seconds

            string sendOffMessage = End(_activityName, "feeling relaxed", duration.ToString());
            Console.WriteLine(sendOffMessage);

            if (ActivityLog.ContainsKey(_activityName))
            {
                ActivityLog[_activityName]++;
            }
            else
            {
                ActivityLog[_activityName] = 1;
            }
        }
    }
}