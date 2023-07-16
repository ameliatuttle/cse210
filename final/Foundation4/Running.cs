using System;
using System.Collections.Generic;

namespace Foundation4
{
    // Derived class representing a running activity
    class Running : Activity
    {
        protected double distance; // Distance covered during the run

        // Constructor to initialize the date, length, and distance of the run
        public Running(DateTime date, int length, double distance) : base(date, length)
        {
            this.distance = distance;
        }

        // Override the GetDistance method to return the distance of the run
        public override double GetDistance()
        {
            return distance;
        }

        // Override the GetSpeed method to calculate and return the speed of the run
        public override double GetSpeed()
        {
            return (distance / length) * 60;
        }

        // Override the GetPace method to calculate and return the pace of the run
        public override double GetPace()
        {
            return length / distance;
        }

        // Override the GetSummary method to generate the summary string for the run
        public override string GetSummary()
        {
            string unit = "miles";
            double speed = GetSpeed();
            double pace = GetPace();

            if (speed <= 0)
                speed = 0;

            if (pace <= 0)
                pace = 0;

            return $"{date.ToString("dd MMM yyyy")} Running ({length} min) - Distance: {distance} {unit}, Speed: {speed} mph, Pace: {pace} min per {unit}";
        }
    }
}