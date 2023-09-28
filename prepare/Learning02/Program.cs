using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates new job instance
        Job job1 = new Job();
        job1._jobTitle = "Rock Star";
        job1._company = "The Rolling Stones";
        job1._startYear = 1956;
        job1._endYear = 2030;

        // Creates second job
        Job job2 = new Job();
        job2._jobTitle = "Astronaut";
        job2._company = "Space X";
        job2._startYear = 2010;
        job2._endYear = 2050;

        // Creates a resume and adds my name to the resume to display
        Resume myResume = new Resume();
        myResume._name = "Erik Burton";

        // Adds job1 and job2 to my resume to display
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Calls the Display method from the Job class and displays the job details.
        myResume.Display();


        
    }
}