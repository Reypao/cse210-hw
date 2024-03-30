using System;


namespace EternalQuest
{
    public class SimpleGoal : EternalQuest.Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"Event recorded for simple goal: {_shortName}");
        }

        public override string GetStringRepresentation()
        {
            return $"{base.GetStringRepresentation()} - Completed: {_isComplete}";
        }
    }
}
