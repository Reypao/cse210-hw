using System;


namespace EternalQuest
{
    public class ChecklistGoal : EternalQuest.Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            Console.WriteLine($"Event recorded for checklist goal: {_shortName}");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed the {_shortName} goal and earned a bonus of {_bonus} points.");
            }
        }

        public override string GetDetailsString()
        {
            return $"{base.GetDetailsString()} - Target: {_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"{base.GetStringRepresentation()} - Points: {_points}";
        }
    }
}