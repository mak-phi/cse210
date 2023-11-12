using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1._name = "James Buchanan Barnes";
        Job job1 = new Job();
        job1._company = "US Army";
        job1._jobTitle = "Sergeant";
        job1._startYear = 1939;
        job1._endYear = 1943;
        // Console.WriteLine(job1._company);
        // job1.Display();
        
        resume1._jobs.Add(job1);


        Job job2 = new Job();
        job2._company = "Hydra";
        job2._jobTitle = "Assassin";
        job2._startYear = 1943;
        job2._endYear = 2017;
        // Console.WriteLine(job2.Display());
        // job2.Display();
        resume1._jobs.Add(job2);

        Job job3 = new Job();
        job3._company = "Avengers";
        job3._jobTitle = "Avenger";
        job3._startYear = 2018;
        job3._endYear = 2024;
        resume1._jobs.Add(job3);

        resume1.Display();
    }
}