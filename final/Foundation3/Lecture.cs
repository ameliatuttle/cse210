using System;
using System.Collections.Generic;

namespace Foundation3
{
    // Lecture class (inherits from Event)
    class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        // Override the GetFullDetails method to include lecture-specific information
        public override string GetFullDetails()
        {
            // Call the base class's GetFullDetails method to get the common event details
            // and append the lecture-specific information
            return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
        }
    }
}