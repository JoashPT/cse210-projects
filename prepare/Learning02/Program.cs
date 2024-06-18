using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Student Teacher";
        job1._company = "Augusta Evans School";
        job1._startYear = 2014;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._jobTitle = "Teacher's Assistant";
        job2._company = "Augusta Evans School";
        job2._startYear = 2015;
        job2._endYear = 2017;

        Job job3 = new Job();
        job3._jobTitle = "History Teacher";
        job3._company = "Clark-Shaw Magnet School";
        job3._startYear = 2017;
        job3._endYear = 2019;

        Resume resume1 = new Resume();
        resume1._name = "Bruce Vargas";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);

        resume1.DisplayResume();
    }
}