using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store activities
            List<Activity> activities = new List<Activity>();

            // Add different types of activities to the list
            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0)); // Running with a distance of 3.0 miles
            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8)); // Running with a distance of 4.8 kilometers
            activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 9.7)); // Cycling at a speed of 9.7 kilometers per hour
            activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 50)); // Swimming with 50 laps

            // Iterate through the list of activities and display their summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}