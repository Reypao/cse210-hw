using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class Job
    {
        // Member variables
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        // Constructor
        public Job()
        {
        }

        // Display job information
        public void DisplayJobInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}