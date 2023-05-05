using System;
using System.Collections.Generic;

public class Resume
{
    public string _personsName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personsName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.GetJob();
        }
    }
}
