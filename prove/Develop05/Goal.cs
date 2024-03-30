using System;
using System.Collections.Generic;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();

        public virtual string GetDetailsString()
        {
            return $"{_shortName} - {_description} - {_points} points";
        }

        public virtual string GetStringRepresentation()
        {
            return $"{_shortName} - {_points} points";
        }
    }
}