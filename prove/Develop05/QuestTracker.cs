using System;
using System.Collections.Generic;

namespace Develop05 {
    public class QuestTracker
    {
        private List<Goal> goals;
        public int Score { get; private set; }

        public QuestTracker()
        {
            goals = new List<Goal>();
            Score = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            foreach (Goal goal in goals)
            {
                if (goal.Name == goalName)
                {
                    goal.Complete();
                    Score += goal.CalculatePoints();
                    break;
                }
            }
        }

        public void DisplayGoals()
        {
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.DisplayStatus());
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Current Score: {Score}");
        }

        public void SaveGoals(string filename)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                foreach (Goal goal in goals)
                {
                    file.WriteLine($"{goal.Name},{goal.Completed}");
                }
            }
        }

        public void LoadGoals(string filename)
        {
            goals.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                bool completed = bool.Parse(parts[1]);
                Goal goal = new SimpleGoal(name, 0);
                goal.Completed = completed;
                goals.Add(goal);
            }
        }
    }
}