using System;
using System.Collections.Generic;

namespace Foundation4
{
    // Derived class representing a cycling activity
    class Cycling : Activity
    {
        private double speed; // Speed of the cycling activity

        // Constructor to initialize the date, length, and speed of the cycling activity
        public Cycling(DateTime date, int length, double speed) : base(date, length)
        {
            this.speed = speed;
        }

        // Override the GetSpeed method to return the speed of the cycling activity
        public override double GetSpeed()
        {
            return speed;
        }

        // Override the GetPace method to calculate and return the pace of the cycling activity
        public override double GetPace()
        {
            if (speed == 0)
                return 0;

            return 60 / speed;
        }

        // Override the GetSummary method to generate the summary string for the cycling activity
        public override string GetSummary()
        {
            string unit = "km";
            double pace = GetPace();

            if (pace <= 0)
                pace = 0;

            return $"{date.ToString("dd MMM yyyy")} Cycling ({length} min) - Speed: {speed} kph, Pace: {pace} min per {unit}";
        }
    }
}