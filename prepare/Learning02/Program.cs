using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job.company = "apple";
        job.jobTitle = "dev";
        job.endYear= 2024;
        job.startYear = 2020;

       // job.display();

        List<Job> lol = new List<Job>();
        lol.Add(job);

        Job bob = new Job();
        bob.company = "Google";
        bob.jobTitle = "Nerd";
        bob.startYear = 1990;
        bob.endYear = 2019;
        
        lol.Add(bob);


        Resume resume = new Resume();
        resume.jobs = lol;
        resume.name = "bob";
        resume.display();

    }
}