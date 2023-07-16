using System;
using System.Collections.Generic;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create address objects for different events
            Address address1 = new Address("123 Main St", "Cityville", "Stateville", "Countryland");
            Address address2 = new Address("456 Elm St", "Townsville", "Stateland", "Countryville");
            Address address3 = new Address("789 Oak St", "Villagetown", "Stateville", "Countryland");

            // Create instances of different event types
            Lecture lecture = new Lecture("Lecture 1", "Introduction to Computing", DateTime.Now, new TimeSpan(10, 0, 0), address1, "John Doe", 100);
            Reception reception = new Reception("Reception 1", "Networking Event", DateTime.Now, new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Gathering 1", "Picnic in the Park", DateTime.Now, new TimeSpan(12, 0, 0), address3, "Sunny");

            // Generate marketing messages for each event
            Console.WriteLine("Standard Details:");
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(lecture.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("Standard Details:");
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("Standard Details:");
            Console.WriteLine(outdoorGathering.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(outdoorGathering.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(outdoorGathering.GetShortDescription());
        }
    }
}