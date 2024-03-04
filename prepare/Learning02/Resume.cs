using System;
using System.Collections.Generic;

namespace Jobs
{
    public class Resume
    {
        // Member variables
        public string _personName;
        public List<Job> _jobs;

        // Constructor
        public Resume()
        {
            _jobs = new List<Job>();
        }

        // Display resume
        public void DisplayResume()
        {
            Console.WriteLine($"Resume of {_personName}:");
            foreach (var job in _jobs)
            {
                job.DisplayJobInfo();
            }
        }
    }
}
