using System;
using System.Collections.Generic;

namespace Develop05 {
    class Program
    {
        static void Main(string[] args)
        {
            QuestTracker tracker = new QuestTracker();

            // Create and add goals
            SimpleGoal marathonGoal = new SimpleGoal("Run a marathon", 1000);
            EternalGoal scripturesGoal = new EternalGoal("Read scriptures", 100);
            ChecklistGoal templeGoal = new ChecklistGoal("Attend the temple", 50, 10, 500);

            tracker.AddGoal(marathonGoal);
            tracker.AddGoal(scripturesGoal);
            tracker.AddGoal(templeGoal);

            // Record events
            tracker.RecordEvent("Run a marathon");
            tracker.RecordEvent("Read scriptures");
            tracker.RecordEvent("Attend the temple");
            tracker.RecordEvent("Attend the temple");
            tracker.RecordEvent("Attend the temple");

            // Display goals and score
            tracker.DisplayGoals();
            tracker.DisplayScore();

            // Save and load goals
            tracker.SaveGoals("goals.txt");

            // Create a new tracker and load goals
            QuestTracker newTracker = new QuestTracker();
            newTracker.LoadGoals("goals.txt");
            newTracker.DisplayGoals();
        }
    }
}