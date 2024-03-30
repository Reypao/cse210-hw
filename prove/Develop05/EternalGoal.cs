using System;


namespace EternalQuest
{
    public class EternalGoal : EternalQuest.Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"Event recorded for eternal goal: {_shortName}");
        }

        public override string GetStringRepresentation()
        {
            return $"{base.GetStringRepresentation()} - Points: {_points}";
        }
    }
}