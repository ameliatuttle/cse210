using System;
using System.Collections.Generic;

namespace Foundation3
{
    // OutdoorGathering class (inherits from Event)
    class OutdoorGathering : Event
    {
        private string weather;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
            : base(title, description, date, time, address)
        {
            this.weather = weather;
        }

        // Override the GetFullDetails method to include outdoor gathering-specific information
        public override string GetFullDetails()
        {
            // Call the base class's GetFullDetails method to get the common event details
            // and append the outdoor gathering-specific information
            return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
        }
    }
}