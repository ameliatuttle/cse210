using System;
using System.Collections.Generic;

namespace Foundation3
{
    // Reception class (inherits from Event)
    class Reception : Event
    {
        private string rsvpEmail;

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        // Override the GetFullDetails method to include reception-specific information
        public override string GetFullDetails()
        {
            // Call the base class's GetFullDetails method to get the common event details
            // and append the reception-specific information
            return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
        }
    }
}