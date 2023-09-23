using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sleep Specialsit";
        job1._company = "Idaho Mattress Outlet";
        job1._startYear = 2023;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Delivery Driver";
        job2._company = "Norco Medical";
        job2._startYear = 2023;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._name = "Michael Holmes";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}