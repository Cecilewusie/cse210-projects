using System;

class Program
{
    static void Main(string[] args)
    {   
        //Create a new job instance named job1
        Job job1 = new Job();

        //Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2006;
        job1._endYear = 2012;

        //Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
        //Console.WriteLine(job1._company);

        // calling the method in the job class to display all the job details
        job1.DisplayJobDetails();

        //Create a second job, set its variables, display this company on the screen as well.

        Job job2 =  new Job();
        job2._jobTitle = "Data Entry Specialist";
        job2._company = "Africa Helping Hands";
        job2._startYear = 2018;
        job2._endYear = 2022;

        //Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
        //Console.WriteLine(job2._company);

        // calling the method in the job class to display all the job details
        job2.DisplayJobDetails();

        //create a new instance of the Resume class.
        Resume resume = new Resume();

        //Setting the member variable name _name to a value
        resume._name = "Cecil Ewusie";

        //Add the two jobs you created earlier, to the list of jobs in the resume object.
        resume._resumeJobs.Add(job1);
        resume._resumeJobs.Add(job2);

        //Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle .
        //Console.WriteLine(resume._resumeJobs[0]._jobTitle);

        //add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line.
        resume.DisplayJobsWithResume();



    }
}