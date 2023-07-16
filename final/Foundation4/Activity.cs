using System;
using System.Collections.Generic;

namespace Foundation4
{
    // Address class to store event address details
// Base class representing an activity
    class Activity
    {
        protected DateTime date; // Date of the activity
        protected int length; // Length of the activity in minutes

        // Constructor to initialize the date and length of the activity
        public Activity(DateTime date, int length)
        {
            this.date = date;
            this.length = length;
        }

        // Virtual method to calculate and return the distance of the activity
        public virtual double GetDistance()
        {
            return 0;
        }

        // Virtual method to calculate and return the speed of the activity
        public virtual double GetSpeed()
        {
            return 0;
        }

        // Virtual method to calculate and return the pace of the activity
        public virtual double GetPace()
        {
            return 0;
        }

        // Virtual method to generate the summary string of the activity
        public virtual string GetSummary()
        {
            return "";
        }
    }
}