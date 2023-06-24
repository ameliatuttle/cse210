using System;
using System.Collections.Generic;

namespace Develop05 {
    public class ChecklistGoal : Goal
    {
        public int TargetCount { get; }
        public int Bonus { get; }
        public int CurrentCount { get; private set; }

        public ChecklistGoal(string name, int value, int targetCount, int bonus) : base(name, value)
        {
            TargetCount = targetCount;
            Bonus = bonus;
            CurrentCount = 0;
        }

        public override void Complete()
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                Completed = true;
            }
        }

        public override string DisplayStatus()
        {
            string status = $"Completed {CurrentCount}/{TargetCount} times";
            return $"{status} {Name}";
        }

        public override int CalculatePoints()
        {
            return Completed ? Value + Bonus : Value;
        }
    }
}