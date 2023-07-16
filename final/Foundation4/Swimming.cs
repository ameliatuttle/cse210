using System;
using System.Collections.Generic;

namespace Foundation4
{
    // Derived class representing a swimming activity
    class Swimming : Activity
    {
        private int laps; // Number of laps swam during the activity

        // Constructor to initialize the date, length, and laps of the swimming activity
        public Swimming(DateTime date, int length, int laps) : base(date, length)
        {
            this.laps = laps;
        }

        // Override the GetDistance method to calculate and return the distance covered during swimming
        public override double GetDistance()
        {
            return laps * 50 / 1000; // 50 meters per lap, converting to kilometers
        }

        // Override the GetSpeed method to calculate and return the speed of the swimming activity
        public override double GetSpeed()
        {
            double distance = GetDistance();

            if (distance == 0)
                return 0;

            return (distance / length) * 60;
        }

        // Override the GetPace method to calculate and return the pace of the swimming activity
        public override double GetPace()
        {
            double distance = GetDistance();

            if (distance == 0)
                return 0;

            return length / distance;
        }

        // Override the GetSummary method to generate the summary string for the swimming activity
        public override string GetSummary()
        {
            string unit = "km";
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();

            if (distance <= 0)
                distance = 0;

            if (speed <= 0)
                speed = 0;

            if (pace <= 0)
                pace = 0;

            return $"{date.ToString("dd MMM yyyy")} Swimming ({length} min) - Distance: {distance} {unit}, Speed: {speed} kph, Pace: {pace} min per {unit}";
        }
    }
}