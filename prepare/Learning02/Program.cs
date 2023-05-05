using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "The Church";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Database Engineer";
        job2._company = "Amazon";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Console.WriteLine(job1._company);
        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job2._company);
        Console.WriteLine(job2._jobTitle);

        Resume myResume = new Resume();
        myResume._personsName = "Bryant";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}