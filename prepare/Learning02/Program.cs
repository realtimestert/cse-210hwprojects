using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Red Hat";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2005";
        job1._endYear = "2022";
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Valve";
        job2._jobTitle = "Decorative Plant";
        job2._startYear = "2017";
        job2.DisplayJobDetails();
    }

}