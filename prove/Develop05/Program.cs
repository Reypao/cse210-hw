using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            manager.Start();

            SimpleGoal simpleGoal = new SimpleGoal("Run a marathon", "Complete a full marathon", 1000);
            EternalGoal eternalGoal = new EternalGoal("Read scriptures", "Read scriptures daily", 100);
            ChecklistGoal checklistGoal = new ChecklistGoal("Attend temple", "Visit the temple", 50, 10, 500);

            manager.CreateGoal(simpleGoal);
            manager.CreateGoal(eternalGoal);
            manager.CreateGoal(checklistGoal);

            manager.ListGoalNames();

            manager.RecordEvent(0);
            manager.RecordEvent(1);
            manager.RecordEvent(2);
            manager.RecordEvent(2); // Recording multiple times for checklist goal

            manager.DisplayPlayerInfo();
            manager.ListGoalDetails();
        }
    }
}