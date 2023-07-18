using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Develop04
{
    class Listing : Activity
    {
        private string _activityName = "Listing";
        private List<string> _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Performs the listing activity
        public void PerformActivity()
        {
            string introMessage = Start(_activityName, "Reflect on the good things in your life by listing as many items as you can.");
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

                Console.WriteLine("You have...");
                for (int i = countdownDuration; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000); // Pause for 1 second
                }

                countdownDuration = 0;
            }

            System.Threading.Thread.Sleep(3000); // Pause for 3 seconds

            string sendOffMessage = End(_activityName, "listing items", duration.ToString());
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