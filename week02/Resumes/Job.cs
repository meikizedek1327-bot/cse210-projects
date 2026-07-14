using System;

public class Job
{
    // These are my Member Variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // This is the method I use to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}