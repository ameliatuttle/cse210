using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity activity = new Activity();

            while (true)
            {
                string choice = activity.Menu();

                switch (choice)
                {
                    case "1":
                        Breathing breathingActivity = new Breathing();
                        breathingActivity.PerformActivity();
                        break;
                    case "2":
                        Reflection reflectionActivity = new Reflection();
                        reflectionActivity.PerformActivity();
                        break;
                    case "3":
                        Listing listingActivity = new Listing();
                        listingActivity.PerformActivity();
                        break;
                    case "4":
                        activity.DisplayActivityLog();
                        break;
                    case "5":
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}