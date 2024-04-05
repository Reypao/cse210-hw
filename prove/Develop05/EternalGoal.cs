using System;
using System.IO;

namespace EternalQuest
{
    public class EternalGoal : EternalQuest.Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public EternalGoal(){}

        public EternalGoal(StreamReader reader) { }

        public override void RecordEvent()
        {
            Console.WriteLine($"Event recorded for eternal goal: {_shortName}");
        }

        public override string GetStringRepresentation()
        {
            return $"{base.GetStringRepresentation()} - Points: {_points}";
        }

        protected override string GetFriendlyCompleteActionDescription()
        {
            return "each time this habit is repeated";
        }

        protected override string GetFriendlyGoalTypeName()
        {
            return "eternal habit";
        }

        public override void Complete()
        {
            _isCompleted = false; 
            _pointsEarned += _points;
        }
    }
}
