using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "School District";
        job1._jobTitle = "School Counselor";
        job1._startYear = 2018;
        job1._endYear = 2022;
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Certified Clean Care";
        job2._jobTitle = "Carpet Technician";
        job2._startYear = 2022;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._company = "ACTION Inc.";
        job3._jobTitle = "Case Manager";
        job3._startYear = 2022;
        job3._endYear = 2023;
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Stuart Evans";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}