using System;

class Program
{
    static void Main(string[] args)
    {
        // I first of all create my first job
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Then I create my second job
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Product Manager";
        job2._startYear = 2022;
        job2._endYear = 2025;

        // Here I create the Resume
        Resume myResume = new Resume();
        myResume._name = "John Doe";

        // Then I add the jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // I then now display the resume
        myResume.Display();
    }
}