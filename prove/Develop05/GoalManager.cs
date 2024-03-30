using System;
using System.Collections.Generic;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<EternalQuest.Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<EternalQuest.Goal>();
            _score = 0;
        }

        public void Start()
        {
            // Start the program
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Your current score: {_score} points");
        }

        public void ListGoalNames()
        {
            Console.WriteLine("List of Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("Details of Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal(EternalQuest.Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(int index)
        {
            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                _score += _goals[index].Points;
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void SaveGoals()
        {
            // Save goals to file
            Console.WriteLine("Goals saved successfully.");
        }

        public void LoadGoals()
        {
            // Load goals from file
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}
