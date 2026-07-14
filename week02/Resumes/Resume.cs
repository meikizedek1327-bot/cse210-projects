using System;
using System.Collections.Generic;

public class Resume
{
    // These are the member Variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // This is the method to display resume
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}