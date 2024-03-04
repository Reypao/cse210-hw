using System;
namespace Jobs
{

class Program
{
    static void Main(string[] args)
    {
        // Create jobs
            Job job1 = new Job(); //"Software Engineer", "Microsoft", 2019, 2022
            Job job2 = new Job(); //"Data Analyst", "Google", 2022, 2024

            job1._company = "Microsoft";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2019;
            job1._endYear = 2022;

            job2._company = "Google";
            job2._jobTitle = "Data Analyst";
            job2._startYear = 2022;
            job2._endYear = 2024;

            // Display company of jobs
            job1.DisplayJobInfo();
            job2.DisplayJobInfo();
            
            Resume resume = new Resume();

            resume._personName = "Effrey Guzman";

            // Add jobs to resume
            resume._jobs.Add(job1);
            resume._jobs.Add(job2);

            // Display resume
            resume.DisplayResume();

            Console.ReadLine();
    }
}
}