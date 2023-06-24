using System;
using System.Collections.Generic;

namespace Develop05 {
    public class Goal
    {
        public string Name { get; }
        public int Value { get; }
        public bool Completed { get; set; }

        public Goal(string name, int value)
        {
            Name = name;
            Value = value;
            Completed = false;
        }

        public virtual void Complete()
        {
            Completed = true;
        }

        public virtual int CalculatePoints()
        {
            return Completed ? Value : 0;
        }

        public virtual string DisplayStatus()
        {
            string status = Completed ? "[X]" : "[ ]";
            return $"{status} {Name}";
        }
    }
}