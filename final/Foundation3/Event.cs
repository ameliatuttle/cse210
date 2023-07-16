using System;
using System.Collections.Generic;

namespace Foundation3
{
    // Base Event class
    class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private TimeSpan time;
        private Address address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        // Get the standard details of the event
        public string GetStandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.ToString()}";
        }

        // Get the full details of the event (including event-specific information)
        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        // Get a short description of the event
        public virtual string GetShortDescription()
        {
            return $"Type: Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
        }
    }
}