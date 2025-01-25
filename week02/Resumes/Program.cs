using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "TechCorp";
        job1._startDate = "January 2020";
        job1._endDate = "December 2022";

      
        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "DataSolutions";
        job2._startDate = "March 2018";
        job2._endDate = "December 2019";

      
        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

      
        resume.Display();
    }
}
